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
    [FunctionName("transactions.get_balance_sheet")]
    [ExplicitColumns]
    public sealed class DbGetBalanceSheetResult : PetaPocoDB.Record<DbGetBalanceSheetResult>, IPoco
    {
        [Column("id")]
        [ColumnDbType("bigint", 0, false, "")] 
        public long Id { get; set; }
    
        [Column("item")]
        [ColumnDbType("text", 0, false, "")] 
        public string Item { get; set; }
    
        [Column("previous_period")]
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal PreviousPeriod { get; set; }
    
        [Column("current_period")]
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal CurrentPeriod { get; set; }
    
        [Column("account_id")]
        [ColumnDbType("integer", 0, false, "")] 
        public int AccountId { get; set; }
    
        [Column("account_number")]
        [ColumnDbType("text", 0, false, "")] 
        public string AccountNumber { get; set; }
    
        [Column("is_retained_earning")]
        [ColumnDbType("boolean", 0, false, "")] 
        public bool IsRetainedEarning { get; set; }
    }
}