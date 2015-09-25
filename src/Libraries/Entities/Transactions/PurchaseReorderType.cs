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
    [TableName("transactions.purchase_reorder_type")]
    [ExplicitColumns]
    public sealed class PurchaseReorderType : PetaPocoDB.Record<PurchaseReorderType>, IPoco
    {
        [Column("item_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int ItemId { get; set; }

        [Column("supplier_code")]
        [ColumnDbType("character varying", 0, false, "")]
        public string SupplierCode { get; set; }

        [Column("unit_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int UnitId { get; set; }

        [Column("price")]
        [ColumnDbType("decimal_strict", 0, false, "")]
        public decimal Price { get; set; }

        [Column("tax_code")]
        [ColumnDbType("character varying", 0, false, "")]
        public string TaxCode { get; set; }

        [Column("order_quantity")]
        [ColumnDbType("integer_strict", 0, false, "")]
        public int OrderQuantity { get; set; }
    }
}