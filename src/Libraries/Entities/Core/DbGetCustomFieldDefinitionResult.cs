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
    [PrimaryKey("", autoIncrement = false)]
    [FunctionName("core.get_custom_field_definition")]
    [ExplicitColumns]
    public sealed class DbGetCustomFieldDefinitionResult : PetaPocoDB.Record<DbGetCustomFieldDefinitionResult>, IPoco
    {
        [Column("table_name")]
        [ColumnDbType("character varying", 0, false, "")]
        public string TableName { get; set; }

        [Column("key_name")]
        [ColumnDbType("character varying", 0, false, "")]
        public string KeyName { get; set; }

        [Column("custom_field_setup_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int CustomFieldSetupId { get; set; }

        [Column("form_name")]
        [ColumnDbType("character varying", 0, false, "")]
        public string FormName { get; set; }

        [Column("field_order")]
        [ColumnDbType("integer", 0, false, "")]
        public int FieldOrder { get; set; }

        [Column("field_name")]
        [ColumnDbType("character varying", 0, false, "")]
        public string FieldName { get; set; }

        [Column("field_label")]
        [ColumnDbType("character varying", 0, false, "")]
        public string FieldLabel { get; set; }

        [Column("description")]
        [ColumnDbType("text", 0, false, "")]
        public string Description { get; set; }

        [Column("data_type")]
        [ColumnDbType("character varying", 0, false, "")]
        public string DataType { get; set; }

        [Column("is_number")]
        [ColumnDbType("boolean", 0, false, "")]
        public bool IsNumber { get; set; }

        [Column("is_date")]
        [ColumnDbType("boolean", 0, false, "")]
        public bool IsDate { get; set; }

        [Column("is_boolean")]
        [ColumnDbType("boolean", 0, false, "")]
        public bool IsBoolean { get; set; }

        [Column("is_long_text")]
        [ColumnDbType("boolean", 0, false, "")]
        public bool IsLongText { get; set; }

        [Column("resource_id")]
        [ColumnDbType("text", 0, false, "")]
        public string ResourceId { get; set; }

        [Column("value")]
        [ColumnDbType("text", 0, false, "")]
        public string Value { get; set; }
    }
}