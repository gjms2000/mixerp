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
    [TableName("core.county_sales_tax_scrud_view")]
    [ExplicitColumns]
    public sealed class CountySalesTaxScrudView : PetaPocoDB.Record<CountySalesTaxScrudView>, IPoco
    {
        [Column("county_sales_tax_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? CountySalesTaxId { get; set; }

        [Column("county_sales_tax_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string CountySalesTaxCode { get; set; }

        [Column("county_sales_tax_name")]
        [ColumnDbType("varchar", 100, true, "")]
        public string CountySalesTaxName { get; set; }

        [Column("county")]
        [ColumnDbType("text", 0, true, "")]
        public string County { get; set; }

        [Column("entity_name")]
        [ColumnDbType("varchar", 100, true, "")]
        public string EntityName { get; set; }

        [Column("industry_name")]
        [ColumnDbType("varchar", 100, true, "")]
        public string IndustryName { get; set; }

        [Column("item_group")]
        [ColumnDbType("text", 0, true, "")]
        public string ItemGroup { get; set; }

        [Column("rate")]
        [ColumnDbType("decimal_strict2", 0, true, "")]
        public decimal? Rate { get; set; }
    }
}