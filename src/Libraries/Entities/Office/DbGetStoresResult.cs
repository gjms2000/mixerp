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

namespace MixERP.Net.Entities.Office
{
    [PrimaryKey("", autoIncrement = false)]
    [FunctionName("office.get_stores")]
    [ExplicitColumns]
    public sealed class DbGetStoresResult : PetaPocoDB.Record<DbGetStoresResult>, IPoco
    {
        [Column("store_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int StoreId { get; set; }

        [Column("office_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int OfficeId { get; set; }

        [Column("store_code")]
        [ColumnDbType("character varying", 0, false, "")]
        public string StoreCode { get; set; }

        [Column("store_name")]
        [ColumnDbType("character varying", 0, false, "")]
        public string StoreName { get; set; }

        [Column("address")]
        [ColumnDbType("character varying", 0, false, "")]
        public string Address { get; set; }

        [Column("store_type_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int StoreTypeId { get; set; }

        [Column("allow_sales")]
        [ColumnDbType("boolean", 0, false, "")]
        public bool AllowSales { get; set; }

        [Column("sales_tax_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int SalesTaxId { get; set; }

        [Column("default_cash_account_id")]
        [ColumnDbType("bigint", 0, false, "")]
        public long DefaultCashAccountId { get; set; }

        [Column("default_cash_repository_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int DefaultCashRepositoryId { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamp with time zone", 0, false, "")]
        public DateTime AuditTs { get; set; }
    }
}