// ReSharper disable All
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
    [TableName("transactions.sales_delivery_view")]
    [ExplicitColumns]
    public sealed class SalesDeliveryView : PetaPocoDB.Record<SalesDeliveryView>, IPoco
    {
        [Column("tran_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? TranId { get; set; }

        [Column("transaction_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? TransactionTs { get; set; }

        [Column("value_date")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? ValueDate { get; set; }

        [Column("entered_by")]
        [ColumnDbType("varchar", 50, true, "")]
        public string EnteredBy { get; set; }

        [Column("status")]
        [ColumnDbType("varchar", 128, true, "")]
        public string Status { get; set; }

        [Column("due_date")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? DueDate { get; set; }

        [Column("reference_number")]
        [ColumnDbType("varchar", 24, true, "")]
        public string ReferenceNumber { get; set; }

        [Column("statement_reference")]
        [ColumnDbType("text", 0, true, "")]
        public string StatementReference { get; set; }

        [Column("customer_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string CustomerCode { get; set; }

        [Column("customer_name")]
        [ColumnDbType("text", 0, true, "")]
        public string CustomerName { get; set; }

        [Column("pan_number")]
        [ColumnDbType("varchar", 50, true, "")]
        public string PanNumber { get; set; }

        [Column("sst_number")]
        [ColumnDbType("varchar", 50, true, "")]
        public string SstNumber { get; set; }

        [Column("cst_number")]
        [ColumnDbType("varchar", 50, true, "")]
        public string CstNumber { get; set; }

        [Column("store_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string StoreName { get; set; }

        [Column("shipping_address")]
        [ColumnDbType("text", 0, true, "")]
        public string ShippingAddress { get; set; }

        [Column("shipper_name")]
        [ColumnDbType("varchar", 150, true, "")]
        public string ShipperName { get; set; }

        [Column("shipping_charge")]
        [ColumnDbType("money_strict2", 0, true, "")]
        public decimal? ShippingCharge { get; set; }

        [Column("invoice_amount")]
        [ColumnDbType("money_strict2", 0, true, "")]
        public decimal? InvoiceAmount { get; set; }
    }
}