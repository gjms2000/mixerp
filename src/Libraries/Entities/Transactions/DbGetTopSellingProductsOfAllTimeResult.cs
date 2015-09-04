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
    [FunctionName("transactions.get_top_selling_products_of_all_time")]
    [ExplicitColumns]
    public sealed class DbGetTopSellingProductsOfAllTimeResult : PetaPocoDB.Record<DbGetTopSellingProductsOfAllTimeResult>, IPoco
    {
        [Column("id")]
        [ColumnDbType("integer", 0, false, "")] 
        public int Id { get; set; }
    
        [Column("item_id")]
        [ColumnDbType("integer", 0, false, "")] 
        public int ItemId { get; set; }
    
        [Column("item_code")]
        [ColumnDbType("text", 0, false, "")] 
        public string ItemCode { get; set; }
    
        [Column("item_name")]
        [ColumnDbType("text", 0, false, "")] 
        public string ItemName { get; set; }
    
        [Column("total_sales")]
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal TotalSales { get; set; }
    }
}