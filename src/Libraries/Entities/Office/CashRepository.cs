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

namespace MixERP.Net.Entities.Office
{
    [PrimaryKey("cash_repository_id", autoIncrement = true)]
    [TableName("office.cash_repositories")]
    [ExplicitColumns]
    public sealed class CashRepository : PetaPocoDB.Record<CashRepository>, IPoco
    {
        [Column("cash_repository_id")]
        [ColumnDbType("int4", 0, false, "nextval('office.cash_repositories_cash_repository_id_seq'::regclass)")]
        public int CashRepositoryId { get; set; }

        [Column("office_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int OfficeId { get; set; }

        [Column("cash_repository_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string CashRepositoryCode { get; set; }

        [Column("cash_repository_name")]
        [ColumnDbType("varchar", 50, false, "")]
        public string CashRepositoryName { get; set; }

        [Column("parent_cash_repository_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? ParentCashRepositoryId { get; set; }

        [Column("description")]
        [ColumnDbType("varchar", 100, true, "")]
        public string Description { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}