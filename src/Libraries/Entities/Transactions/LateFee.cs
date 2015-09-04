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
    [PrimaryKey("transaction_master_id", autoIncrement=false)]
    [TableName("transactions.late_fee")]
    [ExplicitColumns]
    public sealed class LateFee : PetaPocoDB.Record<LateFee>, IPoco
    {
        [Column("transaction_master_id")]
        [ColumnDbType("int8", 0, false, "")] 
        public long TransactionMasterId { get; set; }
    
        [Column("party_id")]
        [ColumnDbType("int8", 0, false, "")] 
        public long PartyId { get; set; }
    
        [Column("value_date")]
        [ColumnDbType("date", 0, false, "")] 
        public DateTime ValueDate { get; set; }
    
        [Column("late_fee_tran_id")]
        [ColumnDbType("int8", 0, false, "")] 
        public long LateFeeTranId { get; set; }
    
        [Column("amount")]
        [ColumnDbType("money_strict", 0, true, "")] 
        public decimal? Amount { get; set; }
    }
}