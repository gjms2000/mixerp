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
    [FunctionName("transactions.get_reorder_view_function")]
    [ExplicitColumns]
    public sealed class DbGetReorderViewFunctionResult : PetaPocoDB.Record<DbGetReorderViewFunctionResult>, IPoco
    {
        [Column("item_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int ItemId { get; set; }

        [Column("item_code")]
        [ColumnDbType("character varying", 0, false, "")]
        public string ItemCode { get; set; }

        [Column("item_name")]
        [ColumnDbType("character varying", 0, false, "")]
        public string ItemName { get; set; }

        [Column("unit_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int UnitId { get; set; }

        [Column("unit")]
        [ColumnDbType("text", 0, false, "")]
        public string Unit { get; set; }

        [Column("quantity_on_hand")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal QuantityOnHand { get; set; }

        [Column("reorder_level")]
        [ColumnDbType("integer", 0, false, "")]
        public int ReorderLevel { get; set; }

        [Column("reorder_quantity")]
        [ColumnDbType("integer", 0, false, "")]
        public int ReorderQuantity { get; set; }

        [Column("preferred_supplier_id")]
        [ColumnDbType("bigint", 0, false, "")]
        public long PreferredSupplierId { get; set; }

        [Column("preferred_supplier")]
        [ColumnDbType("text", 0, false, "")]
        public string PreferredSupplier { get; set; }

        [Column("price")]
        [ColumnDbType("money_strict2", 0, false, "")]
        public decimal Price { get; set; }
    }
}