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
    [PrimaryKey("", autoIncrement = false)]
    [FunctionName("transactions.get_party_transaction_summary")]
    [ExplicitColumns]
    public sealed class DbGetPartyTransactionSummaryResult : PetaPocoDB.Record<DbGetPartyTransactionSummaryResult>, IPoco
    {
        [Column("currency_code")]
        [ColumnDbType("text", 0, false, "")]
        public string CurrencyCode { get; set; }

        [Column("currency_symbol")]
        [ColumnDbType("text", 0, false, "")]
        public string CurrencySymbol { get; set; }

        [Column("total_due_amount")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal TotalDueAmount { get; set; }

        [Column("office_due_amount")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal OfficeDueAmount { get; set; }

        [Column("last_receipt_date")]
        [ColumnDbType("date", 0, false, "")]
        public DateTime LastReceiptDate { get; set; }

        [Column("transaction_value")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal TransactionValue { get; set; }
    }
}