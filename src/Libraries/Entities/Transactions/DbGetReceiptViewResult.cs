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
    [FunctionName("transactions.get_receipt_view")]
    [ExplicitColumns]
    public sealed class DbGetReceiptViewResult : PetaPocoDB.Record<DbGetReceiptViewResult>, IPoco
    {
        [Column("id")]
        [ColumnDbType("bigint", 0, false, "")]
        public long Id { get; set; }

        [Column("value_date")]
        [ColumnDbType("date", 0, false, "")]
        public DateTime ValueDate { get; set; }

        [Column("reference_number")]
        [ColumnDbType("text", 0, false, "")]
        public string ReferenceNumber { get; set; }

        [Column("statement_reference")]
        [ColumnDbType("text", 0, false, "")]
        public string StatementReference { get; set; }

        [Column("office")]
        [ColumnDbType("text", 0, false, "")]
        public string Office { get; set; }

        [Column("party")]
        [ColumnDbType("text", 0, false, "")]
        public string Party { get; set; }

        [Column("user")]
        [ColumnDbType("text", 0, false, "")]
        public string User { get; set; }

        [Column("currency_code")]
        [ColumnDbType("text", 0, false, "")]
        public string CurrencyCode { get; set; }

        [Column("amount")]
        [ColumnDbType("money_strict", 0, false, "")]
        public decimal Amount { get; set; }

        [Column("transaction_ts")]
        [ColumnDbType("timestamp with time zone", 0, false, "")]
        public DateTime TransactionTs { get; set; }

        [Column("flag_background_color")]
        [ColumnDbType("text", 0, false, "")]
        public string FlagBackgroundColor { get; set; }

        [Column("flag_foreground_color")]
        [ColumnDbType("text", 0, false, "")]
        public string FlagForegroundColor { get; set; }
    }
}