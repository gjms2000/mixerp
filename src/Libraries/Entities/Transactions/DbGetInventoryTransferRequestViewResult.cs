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
    [FunctionName("transactions.get_inventory_transfer_request_view")]
    [ExplicitColumns]
    public sealed class DbGetInventoryTransferRequestViewResult : PetaPocoDB.Record<DbGetInventoryTransferRequestViewResult>, IPoco
    {
        [Column("id")]
        [ColumnDbType("bigint", 0, false, "")]
        public long Id { get; set; }

        [Column("value_date")]
        [ColumnDbType("date", 0, false, "")]
        public DateTime ValueDate { get; set; }

        [Column("office")]
        [ColumnDbType("text", 0, false, "")]
        public string Office { get; set; }

        [Column("user_name")]
        [ColumnDbType("text", 0, false, "")]
        public string UserName { get; set; }

        [Column("store")]
        [ColumnDbType("text", 0, false, "")]
        public string Store { get; set; }

        [Column("reference_number")]
        [ColumnDbType("text", 0, false, "")]
        public string ReferenceNumber { get; set; }

        [Column("statement_reference")]
        [ColumnDbType("text", 0, false, "")]
        public string StatementReference { get; set; }

        [Column("authorized")]
        [ColumnDbType("text", 0, false, "")]
        public string Authorized { get; set; }

        [Column("delivered")]
        [ColumnDbType("text", 0, false, "")]
        public string Delivered { get; set; }

        [Column("received")]
        [ColumnDbType("text", 0, false, "")]
        public string Received { get; set; }

        [Column("flag_background_color")]
        [ColumnDbType("text", 0, false, "")]
        public string FlagBackgroundColor { get; set; }

        [Column("flag_foreground_color")]
        [ColumnDbType("text", 0, false, "")]
        public string FlagForegroundColor { get; set; }
    }
}