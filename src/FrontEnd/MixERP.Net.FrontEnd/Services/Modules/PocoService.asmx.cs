using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Web.Script.Services;
using System.Web.Services;
using MixERP.Net.Entities.Core;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using MixERP.Net.Framework.Extensions;
using MixERP.Net.FrontEnd.Base;
using MixERP.Net.i18n.Resources;
using Newtonsoft.Json;
using PetaPoco;
using Filter = MixERP.Net.EntityParser.Filter;

namespace MixERP.Net.FrontEnd.Services.Modules
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    [ScriptService]
    public class PocoService : MixERPWebService
    {
        private const int PAGE_SIZE = 25;
        private const bool SHOW_ALL = false;

        [WebMethod]
        public string GetPocoView(string pocoName, long pageNumber, string filterName, bool byOffice)
        {
            object poco = PocoHelper.GetInstanceOf(pocoName);

            if (poco == null)
            {
                return null;
            }

            bool hasAccess = Service.HasAccess(poco.GetType().FullName, AccessTypeEnum.Read, this.UserId);

            if (!hasAccess)
            {
                throw new MixERPException(Warnings.AccessIsDenied);
            }

            List<Filter> filters = Service.GetFilters(this.Catalog, poco, filterName);

            IEnumerable<object> result = Service.GetView(this.Catalog, poco, pageNumber, filters, byOffice,
                this.OfficeId, SHOW_ALL, PAGE_SIZE);

            return JsonConvert.SerializeObject(result);
        }


        [WebMethod]
        public List<string> GetPocos()
        {
            Type type = typeof(IPoco);
            List<Type> types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p)).ToList();


            List<string> items = types.Select(t => t.FullName).ToList();
            return items;
        }

        [WebMethod]
        public List<string> GetTablePocos()
        {
            Type type = typeof(IPoco);
            List<Type> types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p)).ToList();

            string[] exclue = { "view", "result" };

            List<string> items =
                types.Where(t => !exclue.Any(t.FullName.ToLower().EndsWith)).Select(t => t.FullName).ToList();
            return items;
        }

        [WebMethod]
        public string DownloadTemplate(string pocoName, bool byOffice, bool withData)
        {
            object poco = PocoHelper.GetInstanceOf(pocoName);
            if (poco == null)
            {
                return null;
            }

            bool hasAccess = Service.HasAccess(poco.GetType().FullName, AccessTypeEnum.ImportData, this.UserId);

            if (!hasAccess)
            {
                throw new MixERPException(Warnings.AccessIsDenied);
            }

            IEnumerable<object> result = Service.GetView(this.Catalog, poco, 1, null, byOffice, this.OfficeId, withData,
                PAGE_SIZE);

            return JsonConvert.SerializeObject(result);
        }

        [WebMethod]
        public void Import(string pocoName, List<dynamic> entities)
        {
            object poco = PocoHelper.GetInstanceOf(pocoName);
            if (poco == null)
            {
                return;
            }

            if (entities == null || entities.Count.Equals(0))
            {
                return;
            }

            bool hasAccess = Service.HasAccess(poco.GetType().FullName, AccessTypeEnum.ImportData, this.UserId);

            if (!hasAccess)
            {
                throw new MixERPException(Warnings.AccessIsDenied);
            }
            EntityView entityView = this.GetFormView(pocoName);

            Service.Import(this.Catalog, poco, entities, entityView, this.UserId);
        }

        [WebMethod]
        public string GetViewForEdit(string pocoName, object primaryKeyValue)
        {
            if (primaryKeyValue == null)
            {
                return null;
            }

            object poco = PocoHelper.GetInstanceOf(pocoName);
            if (poco == null)
            {
                return null;
            }

            object item = Service.GetViewForEdit(this.Catalog, poco, primaryKeyValue);
            return JsonConvert.SerializeObject(item);
        }

        [WebMethod]
        public void DeleteEntity(string pocoName, object primaryKeyValue)
        {
            if (primaryKeyValue == null)
            {
                return;
            }

            object poco = PocoHelper.GetInstanceOf(pocoName);

            if (poco == null)
            {
                return;
            }

            Service.DeleteEntity(this.Catalog, poco, primaryKeyValue);
        }

        [WebMethod]
        public long GetTotalPages(string pocoName, string filterName, bool byOffice)
        {
            object poco = PocoHelper.GetInstanceOf(pocoName);
            if (poco == null)
            {
                return 0;
            }

            bool hasAccess = Service.HasAccess(poco.GetType().FullName, AccessTypeEnum.Read, this.UserId);

            if (!hasAccess)
            {
                throw new MixERPException(Warnings.AccessIsDenied);
            }

            List<Filter> filters = Service.GetFilters(this.Catalog, poco, filterName);

            long result = Service.GetTotalPages(this.Catalog, poco, filters, byOffice, this.OfficeId, SHOW_ALL,
                PAGE_SIZE);
            return result;
        }

        [WebMethod]
        public string GetFilteredPocoView(string pocoName, long pageNumber, List<Filter> filters, bool byOffice)
        {
            object poco = PocoHelper.GetInstanceOf(pocoName);
            if (poco == null)
            {
                return null;
            }

            bool hasAccess = Service.HasAccess(poco.GetType().FullName, AccessTypeEnum.Read, this.UserId);

            if (!hasAccess)
            {
                throw new MixERPException(Warnings.AccessIsDenied);
            }

            IEnumerable<object> result = Service.GetView(this.Catalog, poco, pageNumber, filters, byOffice,
                this.OfficeId, SHOW_ALL, PAGE_SIZE);

            return JsonConvert.SerializeObject(result);
        }

        [WebMethod]
        public long GetFilteredTotalPages(string pocoName, List<Filter> filters, bool byOffice)
        {
            object poco = PocoHelper.GetInstanceOf(pocoName);
            if (poco == null)
            {
                return 0;
            }

            bool hasAccess = Service.HasAccess(poco.GetType().FullName, AccessTypeEnum.Read, this.UserId);

            if (!hasAccess)
            {
                throw new MixERPException(Warnings.AccessIsDenied);
            }

            long result = Service.GetTotalPages(this.Catalog, poco, filters, byOffice, this.OfficeId, SHOW_ALL,
                PAGE_SIZE);
            return result;
        }

        [WebMethod]
        public List<Filter> GetFilters(string pocoName, string filterName)
        {
            object poco = PocoHelper.GetInstanceOf(pocoName);
            if (poco == null)
            {
                return null;
            }

            bool hasAccess = Service.HasAccess(poco.GetType().FullName, AccessTypeEnum.Read, this.UserId);

            if (!hasAccess)
            {
                throw new MixERPException(Warnings.AccessIsDenied);
            }

            return Service.GetFilters(this.Catalog, poco, filterName);
        }

        [WebMethod]
        public void SaveFilter(string pocoName, List<Filter> filters)
        {
            object poco = PocoHelper.GetInstanceOf(pocoName);
            if (poco == null)
            {
                return;
            }

            bool hasAccess = Service.HasAccess(poco.GetType().FullName, AccessTypeEnum.CreateFilter, this.UserId);

            if (!hasAccess)
            {
                throw new MixERPException(Warnings.AccessIsDenied);
            }

            Service.SaveFilter(this.Catalog, poco, filters);
        }

        [WebMethod]
        public dynamic GetFilterNames(string pocoName)
        {
            object poco = PocoHelper.GetInstanceOf(pocoName);
            if (poco == null)
            {
                return null;
            }

            return Service.GetFilterNames(this.Catalog, poco);
        }

        [WebMethod]
        public void MakeDefaultFilter(string pocoName, string filterName)
        {
            object poco = PocoHelper.GetInstanceOf(pocoName);
            if (poco == null)
            {
                return;
            }

            Service.MakeDefaultFilter(this.Catalog, poco, filterName);
        }

        [WebMethod]
        public void SaveOrUpdate(string pocoName, dynamic pocoEntity, List<EntityParser.CustomField> customFields)
        {
            object poco = PocoHelper.GetInstanceOf(pocoName);
            if (poco == null)
            {
                return;
            }

            bool hasAccess = Service.HasAccess(poco.GetType().FullName, AccessTypeEnum.Create, this.UserId);

            if (!hasAccess)
            {
                throw new MixERPException(Warnings.AccessIsDenied);
            }

            EntityView entityView = this.GetFormView(pocoName);

            Service.SaveOrUpdate(this.Catalog, poco, pocoEntity, entityView, customFields, this.UserId);
        }

        [WebMethod]
        public EntityView GetFormView(string pocoName)
        {
            EntityView scrud = new EntityView();
            List<EntityColumn> columns = new List<EntityColumn>();

            object poco = PocoHelper.GetInstanceOf(pocoName);
            if (poco == null)
            {
                return null;
            }

            bool hasAccess = Service.HasAccess(poco.GetType().FullName, AccessTypeEnum.Read, this.UserId);

            if (!hasAccess)
            {
                throw new MixERPException(Warnings.AccessIsDenied);
            }

            PrimaryKeyAttribute primaryKey =
                poco.GetType().GetAttributeValue((PrimaryKeyAttribute attribute) => attribute);

            scrud.PrimaryKey = String.Empty;

            if (primaryKey != null)
            {
                scrud.PrimaryKey = primaryKey.Value;
            }

            Type type = poco.GetType();
            foreach (PropertyInfo info in type.GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                EntityColumn column = new EntityColumn();

                column.PropertyName = info.Name;
                column.DataType = info.PropertyType.ToString();

                if (column.DataType.StartsWith("System.Nullable`1["))
                {
                    column.DataType = column.DataType.Replace("System.Nullable`1[", "").Replace("]", "");
                }


                column.ColumnName =
                    info.GetCustomAttributes(typeof(ColumnAttribute), false)
                        .Cast<ColumnAttribute>()
                        .Select(c => c.Name)
                        .FirstOrDefault();

                ColumnDbType dbType =
                    info.GetCustomAttributes(typeof(ColumnDbType), false).Cast<ColumnDbType>().FirstOrDefault();

                if (dbType != null)
                {
                    column.IsNullable = dbType.IsNullable;
                    column.DbDataType = dbType.Name;
                    column.Value = dbType.DefaultValue;
                    column.MaxLength = dbType.MaxLength;

                    if (column.Value.StartsWith("nextval"))
                    {
                        column.Value = "";
                    }
                }

                if (column.ColumnName != null)
                {
                    column.IsPrimaryKey =
                        column.ColumnName.ToUpperInvariant().Equals(scrud.PrimaryKey.ToUpperInvariant());
                }

                if (column.IsPrimaryKey)
                {
                    column.IsSerial = primaryKey.autoIncrement;
                }

                columns.Add(column);
            }

            scrud.Columns = columns;
            return scrud;
        }
    }
}