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
    [PrimaryKey("inventory_transfer_request_detail_id", autoIncrement = true)]
    [TableName("transactions.inventory_transfer_request_details")]
    [ExplicitColumns]
    public sealed class InventoryTransferRequestDetail : PetaPocoDB.Record<InventoryTransferRequestDetail>, IPoco
    {
        [Column("inventory_transfer_request_detail_id")]
        [ColumnDbType("int8", 0, false, "nextval('inventory_transfer_request_de_inventory_transfer_request_de_seq'::regclass)")]
        public long InventoryTransferRequestDetailId { get; set; }

        [Column("inventory_transfer_request_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long InventoryTransferRequestId { get; set; }

        [Column("value_date")]
        [ColumnDbType("date", 0, false, "")]
        public DateTime ValueDate { get; set; }

        [Column("item_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int ItemId { get; set; }

        [Column("quantity")]
        [ColumnDbType("int4", 0, false, "")]
        public int Quantity { get; set; }

        [Column("unit_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int UnitId { get; set; }

        [Column("base_quantity")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal BaseQuantity { get; set; }

        [Column("base_unit_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int BaseUnitId { get; set; }
    }
}