/********************************************************************************
Copyright (C) MixERP Inc. (http://mixof.org).

This file is part of MixERP.

MixERP is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, version 2 of the License.

MixERP is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with MixERP.  If not, see <http://www.gnu.org/licenses/>.
***********************************************************************************/

using System.Collections.Generic;
using MixERP.Net.Entities.Core;
using PetaPoco;

namespace MixERP.Net.Core.Modules.BackOffice.Data
{
    public static class CustomFields
    {
        public static IEnumerable<CustomFieldForm> GetCustomFieldForms(string catalog)
        {
            const string sql = "SELECT * FROM core.custom_field_forms;";
            return Factory.Get<CustomFieldForm>(catalog, sql);
        }

        public static IEnumerable<CustomFieldDataType> GetCustomFieldDataTypes(string catalog)
        {
            const string sql = "SELECT * FROM core.custom_field_data_types;";
            return Factory.Get<CustomFieldDataType>(catalog, sql);
        }

        public static IEnumerable<CustomFieldSetup> GetCustomFieldSetups(string catalog, string formName)
        {
            const string sql = "SELECT * FROM core.custom_field_setup WHERE form_name=@0;";
            return Factory.Get<CustomFieldSetup>(catalog, sql, formName);
        }

        public static void SaveCustomFieldSetups(string catalog, string formName, IEnumerable<CustomFieldSetup> fields)
        {
            const string sql = "DELETE FROM core.custom_field_setup WHERE form_name=@0";
            Factory.NonQuery(catalog, sql, formName);

            foreach (var field in fields)
            {
                Factory.Insert(catalog, field);
            }
        }
    }
}