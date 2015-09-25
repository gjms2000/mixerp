// ReSharper disable All
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
// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("form_name", autoIncrement = false)]
    [TableName("core.custom_field_forms")]
    [ExplicitColumns]
    public sealed class CustomFieldForm : PetaPocoDB.Record<CustomFieldForm>, IPoco
    {
        [Column("form_name")]
        [ColumnDbType("varchar", 100, false, "")]
        public string FormName { get; set; }

        [Column("table_name")]
        [ColumnDbType("varchar", 100, false, "")]
        public string TableName { get; set; }

        [Column("key_name")]
        [ColumnDbType("varchar", 100, false, "")]
        public string KeyName { get; set; }
    }
}