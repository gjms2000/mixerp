using System;
using System.Linq;
using System.Reflection;
using MixERP.Net.Entities.Contracts;
using MixERP.Net.Framework.Extensions;
using PetaPoco;

namespace MixERP.Net.EntityParser
{
    public class PocoHelper
    {
        public static string GetTableName<T>(T poco)
        {
            string name = poco.GetType().GetAttributeValue((TableNameAttribute attribute) => attribute.Value);

            return name;
        }

        public static string GetKeyName<T>(T poco)
        {
            string name = poco.GetType().GetAttributeValue((PrimaryKeyAttribute attribute) => attribute.Value);

            return name;
        }

        public static object GetInstanceOf(string className)
        {
            Type type = AppDomain.CurrentDomain.GetAssemblies().SelectMany(s => s.GetTypes())
                .First(t => t.Name == className && typeof (IPoco).IsAssignableFrom(t));

            return Activator.CreateInstance(type);
        }

        public static bool HasColumn<T>(T poco, string columnName)
        {
            var type = poco.GetType();
            foreach (PropertyInfo a in type.GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                int attributes = a.GetCustomAttributes(typeof (ColumnAttribute), false)
                    .Cast<ColumnAttribute>()
                    .Count(b => b.Name.ToUpperInvariant().Equals(columnName.ToUpperInvariant()));

                if (attributes > 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}