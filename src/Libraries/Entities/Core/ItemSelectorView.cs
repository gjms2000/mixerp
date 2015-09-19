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
    [TableName("core.item_selector_view")]
    [ExplicitColumns]
    public sealed class ItemSelectorView : PetaPocoDB.Record<ItemSelectorView>, IPoco
    {
        [Column("item_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? ItemId { get; set; }

        [Column("item_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string ItemCode { get; set; }

        [Column("item_name")]
        [ColumnDbType("varchar", 150, true, "")]
        public string ItemName { get; set; }

        [Column("item_group_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? ItemGroupId { get; set; }

        [Column("item_type_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? ItemTypeId { get; set; }

        [Column("brand_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? BrandId { get; set; }

        [Column("preferred_supplier_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? PreferredSupplierId { get; set; }

        [Column("lead_time_in_days")]
        [ColumnDbType("int4", 0, true, "")]
        public int? LeadTimeInDays { get; set; }

        [Column("weight_in_grams")]
        [ColumnDbType("float8", 0, true, "")]
        public double? WeightInGrams { get; set; }

        [Column("width_in_centimeters")]
        [ColumnDbType("float8", 0, true, "")]
        public double? WidthInCentimeters { get; set; }

        [Column("height_in_centimeters")]
        [ColumnDbType("float8", 0, true, "")]
        public double? HeightInCentimeters { get; set; }

        [Column("length_in_centimeters")]
        [ColumnDbType("float8", 0, true, "")]
        public double? LengthInCentimeters { get; set; }

        [Column("machinable")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? Machinable { get; set; }

        [Column("preferred_shipping_mail_type_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? PreferredShippingMailTypeId { get; set; }

        [Column("shipping_package_shape_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? ShippingPackageShapeId { get; set; }

        [Column("unit_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? UnitId { get; set; }

        [Column("hot_item")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? HotItem { get; set; }

        [Column("cost_price")]
        [ColumnDbType("money_strict2", 0, true, "")]
        public decimal? CostPrice { get; set; }

        [Column("selling_price")]
        [ColumnDbType("money_strict", 0, true, "")]
        public decimal? SellingPrice { get; set; }

        [Column("selling_price_includes_tax")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? SellingPriceIncludesTax { get; set; }

        [Column("sales_tax_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? SalesTaxId { get; set; }

        [Column("reorder_unit_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? ReorderUnitId { get; set; }

        [Column("reorder_level")]
        [ColumnDbType("int4", 0, true, "")]
        public int? ReorderLevel { get; set; }

        [Column("reorder_quantity")]
        [ColumnDbType("int4", 0, true, "")]
        public int? ReorderQuantity { get; set; }

        [Column("maintain_stock")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? MaintainStock { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }

        [Column("photo")]
        [ColumnDbType("image", 0, true, "")]
        public string Photo { get; set; }
    }
}