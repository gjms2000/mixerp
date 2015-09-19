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
    [PrimaryKey("inventory_transfer_delivery_id", autoIncrement = true)]
    [TableName("transactions.inventory_transfer_deliveries")]
    [ExplicitColumns]
    public sealed class InventoryTransferDelivery : PetaPocoDB.Record<InventoryTransferDelivery>, IPoco
    {
        [Column("inventory_transfer_delivery_id")]
        [ColumnDbType("int8", 0, false, "nextval('inventory_transfer_deliveries_inventory_transfer_delivery_i_seq'::regclass)")]
        public long InventoryTransferDeliveryId { get; set; }

        [Column("inventory_transfer_request_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long InventoryTransferRequestId { get; set; }

        [Column("office_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int OfficeId { get; set; }

        [Column("user_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int UserId { get; set; }

        [Column("login_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long LoginId { get; set; }

        [Column("source_store_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int SourceStoreId { get; set; }

        [Column("destination_store_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int DestinationStoreId { get; set; }

        [Column("value_date")]
        [ColumnDbType("date", 0, false, "")]
        public DateTime ValueDate { get; set; }

        [Column("transaction_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? TransactionTs { get; set; }

        [Column("reference_number")]
        [ColumnDbType("varchar", 24, false, "")]
        public string ReferenceNumber { get; set; }

        [Column("statement_reference")]
        [ColumnDbType("text", 0, true, "")]
        public string StatementReference { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}