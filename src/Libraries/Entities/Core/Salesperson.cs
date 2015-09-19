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
    [PrimaryKey("salesperson_id", autoIncrement = true)]
    [TableName("core.salespersons")]
    [ExplicitColumns]
    public sealed class Salesperson : PetaPocoDB.Record<Salesperson>, IPoco
    {
        [Column("salesperson_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.salespersons_salesperson_id_seq'::regclass)")]
        public int SalespersonId { get; set; }

        [Column("sales_team_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int SalesTeamId { get; set; }

        [Column("salesperson_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string SalespersonCode { get; set; }

        [Column("salesperson_name")]
        [ColumnDbType("varchar", 100, false, "")]
        public string SalespersonName { get; set; }

        [Column("address")]
        [ColumnDbType("varchar", 100, false, "")]
        public string Address { get; set; }

        [Column("contact_number")]
        [ColumnDbType("varchar", 50, false, "")]
        public string ContactNumber { get; set; }

        [Column("commission_rate")]
        [ColumnDbType("decimal_strict2", 0, false, "0")]
        public decimal CommissionRate { get; set; }

        [Column("account_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long AccountId { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}