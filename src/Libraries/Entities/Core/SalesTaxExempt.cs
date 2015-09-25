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
    [PrimaryKey("sales_tax_exempt_id", autoIncrement = true)]
    [TableName("core.sales_tax_exempts")]
    [ExplicitColumns]
    public sealed class SalesTaxExempt : PetaPocoDB.Record<SalesTaxExempt>, IPoco
    {
        [Column("sales_tax_exempt_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.sales_tax_exempts_sales_tax_exempt_id_seq'::regclass)")]
        public int SalesTaxExemptId { get; set; }

        [Column("tax_master_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int TaxMasterId { get; set; }

        [Column("sales_tax_exempt_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string SalesTaxExemptCode { get; set; }

        [Column("sales_tax_exempt_name")]
        [ColumnDbType("varchar", 100, true, "")]
        public string SalesTaxExemptName { get; set; }

        [Column("tax_exempt_type_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int TaxExemptTypeId { get; set; }

        [Column("store_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int StoreId { get; set; }

        [Column("sales_tax_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int SalesTaxId { get; set; }

        [Column("valid_from")]
        [ColumnDbType("date", 0, false, "")]
        public DateTime ValidFrom { get; set; }

        [Column("valid_till")]
        [ColumnDbType("date", 0, false, "")]
        public DateTime ValidTill { get; set; }

        [Column("price_from")]
        [ColumnDbType("money_strict2", 0, false, "0")]
        public decimal PriceFrom { get; set; }

        [Column("price_to")]
        [ColumnDbType("money_strict2", 0, false, "0")]
        public decimal PriceTo { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}