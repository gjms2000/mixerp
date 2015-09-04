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

namespace MixERP.Net.Entities.Office
{
    [PrimaryKey("", autoIncrement=false)]
    [TableName("office.store_scrud_view")]
    [ExplicitColumns]
    public sealed class StoreScrudView : PetaPocoDB.Record<StoreScrudView>, IPoco
    {
        [Column("store_id")]
        [ColumnDbType("int4", 0, true, "")] 
        public int? StoreId { get; set; }
    
        [Column("office")]
        [ColumnDbType("text", 0, true, "")] 
        public string Office { get; set; }
    
        [Column("store_code")]
        [ColumnDbType("varchar", 12, true, "")] 
        public string StoreCode { get; set; }
    
        [Column("store_name")]
        [ColumnDbType("varchar", 50, true, "")] 
        public string StoreName { get; set; }
    
        [Column("address")]
        [ColumnDbType("varchar", 50, true, "")] 
        public string Address { get; set; }
    
        [Column("store_type")]
        [ColumnDbType("text", 0, true, "")] 
        public string StoreType { get; set; }
    
        [Column("allow_sales")]
        [ColumnDbType("bool", 0, true, "")] 
        public bool? AllowSales { get; set; }
    
        [Column("sales_tax")]
        [ColumnDbType("text", 0, true, "")] 
        public string SalesTax { get; set; }
    
        [Column("default_cash_account")]
        [ColumnDbType("text", 0, true, "")] 
        public string DefaultCashAccount { get; set; }
    
        [Column("default_cash_repository")]
        [ColumnDbType("text", 0, true, "")] 
        public string DefaultCashRepository { get; set; }
    }
}