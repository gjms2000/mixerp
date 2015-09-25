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
    [PrimaryKey("data_type", autoIncrement = false)]
    [TableName("core.custom_field_data_types")]
    [ExplicitColumns]
    public sealed class CustomFieldDataType : PetaPocoDB.Record<CustomFieldDataType>, IPoco
    {
        [Column("data_type")]
        [ColumnDbType("varchar", 50, false, "")]
        public string DataType { get; set; }

        [Column("is_number")]
        [ColumnDbType("bool", 0, true, "false")]
        public bool? IsNumber { get; set; }

        [Column("is_date")]
        [ColumnDbType("bool", 0, true, "false")]
        public bool? IsDate { get; set; }

        [Column("is_boolean")]
        [ColumnDbType("bool", 0, true, "false")]
        public bool? IsBoolean { get; set; }

        [Column("is_long_text")]
        [ColumnDbType("bool", 0, true, "false")]
        public bool? IsLongText { get; set; }
    }
}