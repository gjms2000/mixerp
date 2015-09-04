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
    [FunctionName("transactions.get_trial_balance")]
    [ExplicitColumns]
    public sealed class DbGetTrialBalanceResult : PetaPocoDB.Record<DbGetTrialBalanceResult>, IPoco
    {
        [Column("id")]
        [ColumnDbType("integer", 0, false, "")] 
        public int Id { get; set; }
    
        [Column("account_id")]
        [ColumnDbType("integer", 0, false, "")] 
        public int AccountId { get; set; }
    
        [Column("account_number")]
        [ColumnDbType("text", 0, false, "")] 
        public string AccountNumber { get; set; }
    
        [Column("account")]
        [ColumnDbType("text", 0, false, "")] 
        public string Account { get; set; }
    
        [Column("previous_debit")]
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal PreviousDebit { get; set; }
    
        [Column("previous_credit")]
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal PreviousCredit { get; set; }
    
        [Column("debit")]
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal Debit { get; set; }
    
        [Column("credit")]
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal Credit { get; set; }
    
        [Column("closing_debit")]
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal ClosingDebit { get; set; }
    
        [Column("closing_credit")]
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal ClosingCredit { get; set; }
    }
}