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
    [PrimaryKey("state_sales_tax_id", autoIncrement=true)]
    [TableName("core.state_sales_taxes")]
    [ExplicitColumns]
    public sealed class StateSalesTax : PetaPocoDB.Record<StateSalesTax>, IPoco
    {
        [Column("state_sales_tax_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.state_sales_taxes_state_sales_tax_id_seq'::regclass)")] 
        public int StateSalesTaxId { get; set; }
    
        [Column("state_sales_tax_code")]
        [ColumnDbType("varchar", 12, false, "")] 
        public string StateSalesTaxCode { get; set; }
    
        [Column("state_sales_tax_name")]
        [ColumnDbType("varchar", 100, false, "")] 
        public string StateSalesTaxName { get; set; }
    
        [Column("state_id")]
        [ColumnDbType("int4", 0, false, "")] 
        public int StateId { get; set; }
    
        [Column("entity_id")]
        [ColumnDbType("int4", 0, true, "")] 
        public int? EntityId { get; set; }
    
        [Column("industry_id")]
        [ColumnDbType("int4", 0, true, "")] 
        public int? IndustryId { get; set; }
    
        [Column("item_group_id")]
        [ColumnDbType("int4", 0, true, "")] 
        public int? ItemGroupId { get; set; }
    
        [Column("rate")]
        [ColumnDbType("decimal_strict2", 0, false, "0")] 
        public decimal Rate { get; set; }
    
        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }
    
        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }
    }
}