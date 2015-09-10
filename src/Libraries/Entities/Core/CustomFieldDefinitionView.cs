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
    [PrimaryKey("", autoIncrement=false)]
    [TableName("core.custom_field_definition_view")]
    [ExplicitColumns]
    public sealed class CustomFieldDefinitionView : PetaPocoDB.Record<CustomFieldDefinitionView>, IPoco
    {
        [Column("table_name")]
        [ColumnDbType("varchar", 100, true, "")] 
        public string TableName { get; set; }
    
        [Column("key_name")]
        [ColumnDbType("varchar", 100, true, "")] 
        public string KeyName { get; set; }
    
        [Column("form_name")]
        [ColumnDbType("varchar", 100, true, "")] 
        public string FormName { get; set; }
    
        [Column("field_order")]
        [ColumnDbType("int4", 0, true, "")] 
        public int? FieldOrder { get; set; }
    
        [Column("field_name")]
        [ColumnDbType("varchar", 100, true, "")] 
        public string FieldName { get; set; }
    
        [Column("field_label")]
        [ColumnDbType("varchar", 100, true, "")] 
        public string FieldLabel { get; set; }
    
        [Column("description")]
        [ColumnDbType("text", 0, true, "")] 
        public string Description { get; set; }
    
        [Column("data_type")]
        [ColumnDbType("varchar", 50, true, "")] 
        public string DataType { get; set; }
    
        [Column("is_number")]
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsNumber { get; set; }
    
        [Column("is_date")]
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsDate { get; set; }
    
        [Column("is_boolean")]
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsBoolean { get; set; }
    
        [Column("is_long_text")]
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsLongText { get; set; }
    }
}