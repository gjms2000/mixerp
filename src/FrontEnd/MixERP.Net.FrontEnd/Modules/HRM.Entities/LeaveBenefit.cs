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

namespace MixERP.Net.Entities.HRM
{
    [PrimaryKey("leave_benefit_id", autoIncrement = true)]
    [TableName("hrm.leave_benefits")]
    [ExplicitColumns]
    public sealed class LeaveBenefit : PetaPocoDB.Record<LeaveBenefit>, IPoco
    {
        [Column("leave_benefit_id")]
        [ColumnDbType("int4", 0, false, "nextval('hrm.leave_benefits_leave_benefit_id_seq'::regclass)")]
        public int LeaveBenefitId { get; set; }

        [Column("leave_benefit_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string LeaveBenefitCode { get; set; }

        [Column("leave_benefit_name")]
        [ColumnDbType("varchar", 128, false, "")]
        public string LeaveBenefitName { get; set; }

        [Column("total_days")]
        [ColumnDbType("integer_strict", 0, false, "")]
        public int TotalDays { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}