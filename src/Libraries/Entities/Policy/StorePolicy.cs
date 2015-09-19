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

namespace MixERP.Net.Entities.Policy
{
    [PrimaryKey("store_policy_id", autoIncrement = true)]
    [TableName("policy.store_policies")]
    [ExplicitColumns]
    public sealed class StorePolicy : PetaPocoDB.Record<StorePolicy>, IPoco
    {
        [Column("store_policy_id")]
        [ColumnDbType("int8", 0, false, "nextval('policy.store_policies_store_policy_id_seq'::regclass)")]
        public long StorePolicyId { get; set; }

        [Column("written_by_user_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int WrittenByUserId { get; set; }

        [Column("status")]
        [ColumnDbType("bool", 0, false, "")]
        public bool Status { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}