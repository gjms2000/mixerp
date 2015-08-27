using System.Collections.Generic;
using MixERP.Net.Entities.Core;

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

            return Data.Service.GetView(catalog, poco, tableName, keyName, page, filters, byOffice, officeId, showall,
                page);
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