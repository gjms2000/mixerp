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
    [TableName("core.sales_tax_scrud_view")]
    [ExplicitColumns]
    public sealed class SalesTaxScrudView : PetaPocoDB.Record<SalesTaxScrudView>, IPoco
    {
        [Column("sales_tax_id")]
        [ColumnDbType("int4", 0, true, "")] 
        public int? SalesTaxId { get; set; }
    
        [Column("tax_master")]
        [ColumnDbType("text", 0, true, "")] 
        public string TaxMaster { get; set; }
    
        [Column("office")]
        [ColumnDbType("text", 0, true, "")] 
        public string Office { get; set; }
    
        [Column("sales_tax_code")]
        [ColumnDbType("varchar", 24, true, "")] 
        public string SalesTaxCode { get; set; }
    
        [Column("sales_tax_name")]
        [ColumnDbType("varchar", 50, true, "")] 
        public string SalesTaxName { get; set; }
    
        [Column("is_exemption")]
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsExemption { get; set; }
    
        [Column("tax_base_amount")]
        [ColumnDbType("text", 0, true, "")] 
        public string TaxBaseAmount { get; set; }
    
        [Column("rate")]
        [ColumnDbType("decimal_strict2", 0, true, "")] 
        public decimal? Rate { get; set; }
    }
}