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

namespace MixERP.Net.Entities.HRM
{
    [PrimaryKey("holiday_id", autoIncrement = true)]
    [TableName("hrm.holidays")]
    [ExplicitColumns]
    public sealed class Holiday : PetaPocoDB.Record<Holiday>, IPoco
    {
        [Column("holiday_id")]
        [ColumnDbType("int8", 0, false, "nextval('hrm.holidays_holiday_id_seq'::regclass)")]
        public long HolidayId { get; set; }

        [Column("office_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int OfficeId { get; set; }

        [Column("holiday_name")]
        [ColumnDbType("varchar", 128, false, "")]
        public string HolidayName { get; set; }

        [Column("occurs_on")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? OccursOn { get; set; }

        [Column("ends_on")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? EndsOn { get; set; }

        [Column("comment")]
        [ColumnDbType("text", 0, true, "")]
        public string Comment { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}