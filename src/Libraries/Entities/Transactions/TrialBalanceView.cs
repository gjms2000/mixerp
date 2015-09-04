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
    [TableName("transactions.trial_balance_view")]
    [ExplicitColumns]
    public sealed class TrialBalanceView : PetaPocoDB.Record<TrialBalanceView>, IPoco
    {
        [Column("get_account_name")]
        [ColumnDbType("text", 0, false, "")] 
        public string GetAccountName { get; set; }
    
        [Column("debit")]
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal Debit { get; set; }
    
        [Column("credit")]
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal Credit { get; set; }
    }
}