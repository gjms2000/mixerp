using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using MixERP.Net.Framework;
using MixERP.Net.Framework.Extensions;
using MixERP.Net.i18n;
using Npgsql;
using PetaPoco;

namespace MixERP.Net.EntityParser
{
    public class Service
    {
        public static List<Filter> GetFilters(string catalog, object poco, string filterName)
        {
            if (poco == null)
            {
                return null;
            }

            string tableName = PocoHelper.GetTableName(poco);
            if (string.IsNullOrWhiteSpace(tableName))
            {
                return null;
            }
            return Data.Service.GetFilters(catalog, tableName, filterName);
        }

        public static IEnumerable<T> GetView<T>(string catalog, T poco, long page, List<Filter> filters, bool byOffice,
            int officeId, bool showall,
            long pageSize)
        {
            string tableName = PocoHelper.GetTableName(poco);
            string keyName = PocoHelper.GetKeyName(poco);

            IEnumerable<T> view = Data.Service.GetView(catalog, poco, tableName, keyName, page, filters, byOffice,
                officeId, showall, pageSize);
            return view;
        }

        public static T GetViewForEdit<T>(string catalog, T poco, object primaryKeyValue)
        {
            string primaryKeyName = PocoHelper.GetKeyName(poco);
            string tableName = PocoHelper.GetTableName(poco);

            return Data.Service.GetViewForEdit<T>(catalog, tableName, primaryKeyName, primaryKeyValue);
        }

        public static void SaveOrUpdate<T>(string catalog, T poco, dynamic entity, EntityView entityView, int userId)
        {
            List<dynamic> entities = new List<dynamic>();
            entities.Add(entity);

            Import(catalog, poco, entities, entityView, userId);
        }

        public static bool HasAccess(string pocoNamespace, AccessTypeEnum accessTypeEnum, int userId)
        {
            int accessType = (int) accessTypeEnum;
            const string sql = "SELECT * FROM policy.has_access(@0, @1, @2);";
            //Todo
            return true;
        }

        public static void DeleteEntity<T>(string catalog, T poco, object primaryKeyValue)
        {
            string primaryKeyName = PocoHelper.GetKeyName(poco);
            string tableName = PocoHelper.GetTableName(poco);

            Data.Service.Delete(catalog, tableName, primaryKeyName, primaryKeyValue);
        }

        public static void Import<T>(string catalog, T poco, List<dynamic> entities, EntityView entityView, int userId)
        {
            string primaryKeyName = PocoHelper.GetKeyName(poco);
            string tableName = PocoHelper.GetTableName(poco);
            List<dynamic> items = new List<dynamic>();

            int line = 0;
            foreach (dynamic entity in entities)
            {
                if (entity == null)
                {
                    continue;
                }

                ExpandoObject item = new ExpandoObject();


                foreach (dynamic o in entity)
                {
                    string key = o.Key;
                    object value = o.Value;

                    EntityColumn column = entityView.Columns.FirstOrDefault(c => c.ColumnName.Equals(key));

                    if (column != null)
                    {
                        bool isNullable = column.IsNullable || primaryKeyName.Equals(key);

                        AddProperty(ref item, column.DataType, isNullable, key, value);
                    }
                }

                if (((ICollection<KeyValuePair<string, object>>) item).Count > 1)
                {
                    line++;

                    ((IDictionary<string, object>) item)["audit_user_id"] = userId;
                    ((IDictionary<string, object>) item)["audit_ts"] = DateTime.UtcNow;

                    items.Add(item);
                }
            }


            line = 0;

            try
            {
                using (Database db = new Database(Factory.GetConnectionString(catalog), Factory.ProviderName))
                {
                    using (Transaction transaction = db.GetTransaction())
                    {
                        foreach (ExpandoObject item in items)
                        {
                            line++;

                            object primaryKeyValue = ((IDictionary<string, object>) item)[primaryKeyName];

                            if (primaryKeyValue != null)
                            {
                                db.Update(tableName, primaryKeyName, item, primaryKeyValue);
                            }
                            else
                            {
                                db.Insert(tableName, primaryKeyName, item);
                            }
                        }

                        transaction.Complete();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                string errorMessage = string.Format(CultureManager.GetCurrent(), "Error on line {0}.", line);

                if (ex.Code.StartsWith("P"))
                {
                    errorMessage += Factory.GetDBErrorResource(ex);

                    throw new MixERPException(errorMessage, ex);
                }

                errorMessage += ex.Message;
                throw new MixERPException(errorMessage, ex);
            }
            catch (Exception ex)
            {
                string errorMessage = string.Format(CultureManager.GetCurrent(), "Error on line {0}.", line);
                throw new MixERPException(errorMessage, ex);
            }
        }

        private static void AddProperty(ref ExpandoObject item, string dataType, bool isNullable, string key,
            object value)
        {
            if (!isNullable)
            {
                switch (dataType)
                {
                    case "System.Boolean":
                        ((IDictionary<string, object>) item)[key] = bool.Parse(value.ToString());
                        break;
                    case "System.Int16":
                        ((IDictionary<string, object>) item)[key] = short.Parse(value.ToString());
                        break;
                    case "System.Int32":
                        ((IDictionary<string, object>) item)[key] = int.Parse(value.ToString());
                        break;
                    case "System.Int64":
                        ((IDictionary<string, object>) item)[key] = int.Parse(value.ToString());
                        break;
                    case "System.Decimal":
                        ((IDictionary<string, object>) item)[key] = decimal.Parse(value.ToString());
                        break;
                    case "System.Single":
                        ((IDictionary<string, object>) item)[key] = float.Parse(value.ToString());
                        break;
                    case "System.Double":
                        ((IDictionary<string, object>) item)[key] = double.Parse(value.ToString());
                        break;
                    case "System.DateTime":
                        ((IDictionary<string, object>) item)[key] = DateTime.Parse(value.ToString());
                        break;
                    default:
                        ((IDictionary<string, object>) item)[key] = value;
                        break;
                }

                return;
            }

            if (value == null)
            {
                ((IDictionary<string, object>) item)[key] = null;
                return;
            }

            switch (dataType)
            {
                case "System.Boolean":
                    ((IDictionary<string, object>) item)[key] = value.ToString().Parse(bool.Parse);
                    break;
                case "System.Int16":
                    ((IDictionary<string, object>) item)[key] = value.ToString().Parse(short.Parse);
                    break;
                case "System.Int32":
                    ((IDictionary<string, object>) item)[key] = value.ToString().Parse(int.Parse);
                    break;
                case "System.Int64":
                    ((IDictionary<string, object>) item)[key] = value.ToString().Parse(long.Parse);
                    break;
                case "System.Decimal":
                    ((IDictionary<string, object>) item)[key] = value.ToString().Parse(decimal.Parse);
                    break;
                case "System.Single":
                    ((IDictionary<string, object>) item)[key] = value.ToString().Parse(float.Parse);
                    break;
                case "System.Double":
                    ((IDictionary<string, object>) item)[key] = value.ToString().Parse(double.Parse);
                    break;
                case "System.DateTime":
                    ((IDictionary<string, object>) item)[key] = value.ToString().Parse(DateTime.Parse);
                    break;
                default:
                    ((IDictionary<string, object>) item)[key] = value;
                    break;
            }
        }

        public static IEnumerable<T> ForDownloadTemplate<T>(string catalog, T poco, bool byOffice, int officeId,
            bool includeData)
        {
            string tableName = PocoHelper.GetTableName(poco);
            string keyName = PocoHelper.GetKeyName(poco);

            IEnumerable<T> view = Data.Service.ForDownloadTemplate(catalog, poco, tableName, keyName, byOffice, officeId,
                includeData);
            return view;
        }

        public static long GetTotalPages<T>(string catalog, T poco, List<Filter> filters, bool byOffice, int officeId,
            bool showall, long pageSize)
        {
            if (showall)
            {
                return 1;
            }

            string tableName = PocoHelper.GetTableName(poco);

            return Data.Service.GetTotalPages(catalog, poco, tableName, filters, byOffice, officeId, showall, pageSize);
        }

        public static void SaveFilter(string catalog, object poco, List<Filter> filters)
        {
            if (poco == null)
            {
                return;
            }

            if (filters == null || filters.Count.Equals(0))
            {
                return;
            }

            string tableName = PocoHelper.GetTableName(poco);

            Data.Service.SaveFilter(catalog, tableName, filters);
        }

        public static List<dynamic> GetFilterNames(string catalog, object poco)
        {
            if (poco == null)
            {
                return null;
            }

            string tableName = PocoHelper.GetTableName(poco);
            return Data.Service.GetFilterNames(catalog, tableName);
        }

        public static void MakeDefaultFilter(string catalog, object poco, string filterName)
        {
            if (poco == null)
            {
                return;
            }

            string tableName = PocoHelper.GetTableName(poco);
            Data.Service.MakeDefaultFilter(catalog, tableName, filterName);
        }
    }
}