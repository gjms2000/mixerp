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

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.item_group_scrud_view")]
    [ExplicitColumns]
    public sealed class ItemGroupScrudView : PetaPocoDB.Record<ItemGroupScrudView>, IPoco
    {
        [Column("item_group_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? ItemGroupId { get; set; }

        [Column("item_group_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string ItemGroupCode { get; set; }

        [Column("item_group_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string ItemGroupName { get; set; }

        [Column("exclude_from_purchase")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? ExcludeFromPurchase { get; set; }

        [Column("exclude_from_sales")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? ExcludeFromSales { get; set; }

        [Column("sales_tax")]
        [ColumnDbType("text", 0, true, "")]
        public string SalesTax { get; set; }

        [Column("parent")]
        [ColumnDbType("text", 0, true, "")]
        public string Parent { get; set; }
    }
}