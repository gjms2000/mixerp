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

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("non_gl_stock_detail_id", autoIncrement=true)]
    [TableName("transactions.non_gl_stock_details")]
    [ExplicitColumns]
    public sealed class NonGlStockDetail : PetaPocoDB.Record<NonGlStockDetail>, IPoco
    {
        [Column("non_gl_stock_detail_id")]
        [ColumnDbType("int8", 0, false, "nextval('transactions.non_gl_stock_details_non_gl_stock_detail_id_seq'::regclass)")] 
        public long NonGlStockDetailId { get; set; }
    
        [Column("non_gl_stock_master_id")]
        [ColumnDbType("int8", 0, false, "")] 
        public long NonGlStockMasterId { get; set; }
    
        [Column("value_date")]
        [ColumnDbType("date", 0, false, "")] 
        public DateTime ValueDate { get; set; }
    
        [Column("item_id")]
        [ColumnDbType("int4", 0, false, "")] 
        public int ItemId { get; set; }
    
        [Column("quantity")]
        [ColumnDbType("int4", 0, false, "")] 
        public int Quantity { get; set; }
    
        [Column("unit_id")]
        [ColumnDbType("int4", 0, false, "")] 
        public int UnitId { get; set; }
    
        [Column("base_quantity")]
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal BaseQuantity { get; set; }
    
        [Column("base_unit_id")]
        [ColumnDbType("int4", 0, false, "")] 
        public int BaseUnitId { get; set; }
    
        [Column("price")]
        [ColumnDbType("money_strict", 0, false, "")] 
        public decimal Price { get; set; }
    
        [Column("discount")]
        [ColumnDbType("money_strict2", 0, false, "0")] 
        public decimal Discount { get; set; }
    
        [Column("shipping_charge")]
        [ColumnDbType("money_strict2", 0, false, "0")] 
        public decimal ShippingCharge { get; set; }
    
        [Column("sales_tax_id")]
        [ColumnDbType("int4", 0, true, "")] 
        public int? SalesTaxId { get; set; }
    
        [Column("tax")]
        [ColumnDbType("money_strict2", 0, false, "0")] 
        public decimal Tax { get; set; }
    
        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }
    
        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }
    }
}