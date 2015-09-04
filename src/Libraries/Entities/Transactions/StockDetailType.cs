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
    [PrimaryKey("", autoIncrement=false)]
    [TableName("transactions.stock_detail_type")]
    [ExplicitColumns]
    public sealed class StockDetailType : PetaPocoDB.Record<StockDetailType>, IPoco
    {
        [Column("store_id")]
        [ColumnDbType("integer", 0, false, "")] 
        public int StoreId { get; set; }
    
        [Column("item_code")]
        [ColumnDbType("character varying", 0, false, "")] 
        public string ItemCode { get; set; }
    
        [Column("quantity")]
        [ColumnDbType("integer_strict", 0, false, "")] 
        public int Quantity { get; set; }
    
        [Column("unit_name")]
        [ColumnDbType("character varying", 0, false, "")] 
        public string UnitName { get; set; }
    
        [Column("price")]
        [ColumnDbType("money_strict", 0, false, "")] 
        public decimal Price { get; set; }
    
        [Column("discount")]
        [ColumnDbType("money_strict2", 0, false, "")] 
        public decimal Discount { get; set; }
    
        [Column("shipping_charge")]
        [ColumnDbType("money_strict2", 0, false, "")] 
        public decimal ShippingCharge { get; set; }
    
        [Column("tax_form")]
        [ColumnDbType("character varying", 0, false, "")] 
        public string TaxForm { get; set; }
    
        [Column("tax")]
        [ColumnDbType("money_strict2", 0, false, "")] 
        public decimal Tax { get; set; }
    }
}