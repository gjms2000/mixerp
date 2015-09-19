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
    [PrimaryKey("receipt_id", autoIncrement = true)]
    [TableName("transactions.customer_receipts")]
    [ExplicitColumns]
    public sealed class CustomerReceipt : PetaPocoDB.Record<CustomerReceipt>, IPoco
    {
        [Column("receipt_id")]
        [ColumnDbType("int8", 0, false, "nextval('transactions.customer_receipts_receipt_id_seq'::regclass)")]
        public long ReceiptId { get; set; }

        [Column("transaction_master_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long TransactionMasterId { get; set; }

        [Column("party_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long PartyId { get; set; }

        [Column("currency_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string CurrencyCode { get; set; }

        [Column("amount")]
        [ColumnDbType("money_strict", 0, false, "")]
        public decimal Amount { get; set; }

        [Column("er_debit")]
        [ColumnDbType("decimal_strict", 0, false, "")]
        public decimal ErDebit { get; set; }

        [Column("er_credit")]
        [ColumnDbType("decimal_strict", 0, false, "")]
        public decimal ErCredit { get; set; }

        [Column("cash_repository_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? CashRepositoryId { get; set; }

        [Column("posted_date")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? PostedDate { get; set; }

        [Column("bank_account_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? BankAccountId { get; set; }

        [Column("bank_instrument_code")]
        [ColumnDbType("varchar", 128, true, "")]
        public string BankInstrumentCode { get; set; }

        [Column("bank_tran_code")]
        [ColumnDbType("varchar", 128, true, "")]
        public string BankTranCode { get; set; }
    }
}