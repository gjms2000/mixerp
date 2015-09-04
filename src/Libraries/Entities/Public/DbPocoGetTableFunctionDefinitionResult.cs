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

namespace MixERP.Net.Entities.Public
{
    [PrimaryKey("", autoIncrement=false)]
    [FunctionName("public.poco_get_table_function_definition")]
    [ExplicitColumns]
    public sealed class DbPocoGetTableFunctionDefinitionResult : PetaPocoDB.Record<DbPocoGetTableFunctionDefinitionResult>, IPoco
    {
        [Column("id")]
        [ColumnDbType("bigint", 0, false, "")] 
        public long Id { get; set; }
    
        [Column("column_name")]
        [ColumnDbType("text", 0, false, "")] 
        public string ColumnName { get; set; }
    
        [Column("is_nullable")]
        [ColumnDbType("text", 0, false, "")] 
        public string IsNullable { get; set; }
    
        [Column("udt_name")]
        [ColumnDbType("text", 0, false, "")] 
        public string UdtName { get; set; }
    
        [Column("column_default")]
        [ColumnDbType("text", 0, false, "")] 
        public string ColumnDefault { get; set; }
    
        [Column("max_length")]
        [ColumnDbType("integer", 0, false, "")] 
        public int MaxLength { get; set; }
    
        [Column("is_primary_key")]
        [ColumnDbType("text", 0, false, "")] 
        public string IsPrimaryKey { get; set; }
    }
}