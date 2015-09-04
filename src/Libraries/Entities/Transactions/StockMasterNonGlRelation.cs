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
    [PrimaryKey("stock_master_non_gl_relation_id", autoIncrement=true)]
    [TableName("transactions.stock_master_non_gl_relations")]
    [ExplicitColumns]
    public sealed class StockMasterNonGlRelation : PetaPocoDB.Record<StockMasterNonGlRelation>, IPoco
    {
        [Column("stock_master_non_gl_relation_id")]
        [ColumnDbType("int8", 0, false, "nextval('transactions.stock_master_non_gl_relations_stock_master_non_gl_relation__seq'::regclass)")] 
        public long StockMasterNonGlRelationId { get; set; }
    
        [Column("stock_master_id")]
        [ColumnDbType("int8", 0, false, "")] 
        public long StockMasterId { get; set; }
    
        [Column("non_gl_stock_master_id")]
        [ColumnDbType("int8", 0, false, "")] 
        public long NonGlStockMasterId { get; set; }
    }
}