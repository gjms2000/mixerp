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
    [PrimaryKey("stock_tax_detail_id", autoIncrement = true)]
    [TableName("transactions.stock_tax_details")]
    [ExplicitColumns]
    public sealed class StockTaxDetail : PetaPocoDB.Record<StockTaxDetail>, IPoco
    {
        [Column("stock_detail_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long StockDetailId { get; set; }

        [Column("sales_tax_detail_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int SalesTaxDetailId { get; set; }

        [Column("state_sales_tax_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? StateSalesTaxId { get; set; }

        [Column("county_sales_tax_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? CountySalesTaxId { get; set; }

        [Column("principal")]
        [ColumnDbType("money_strict", 0, false, "")]
        public decimal Principal { get; set; }

        [Column("rate")]
        [ColumnDbType("decimal_strict", 0, false, "")]
        public decimal Rate { get; set; }

        [Column("tax")]
        [ColumnDbType("money_strict", 0, false, "")]
        public decimal Tax { get; set; }

        [Column("stock_tax_detail_id")]
        [ColumnDbType("int8", 0, false, "nextval('stock_tax_details_stock_tax_detail_id_seq'::regclass)")]
        public long StockTaxDetailId { get; set; }
    }
}