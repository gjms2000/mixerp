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
    [PrimaryKey("holiday_id", autoIncrement = false)]
    [TableName("office.holidays")]
    [ExplicitColumns]
    public sealed class Holiday : PetaPocoDB.Record<Holiday>, IPoco
    {
        [Column("holiday_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int HolidayId { get; set; }

        [Column("office_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int OfficeId { get; set; }

        [Column("falls_on")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? FallsOn { get; set; }

        [Column("holiday_name")]
        [ColumnDbType("varchar", 100, false, "")]
        public string HolidayName { get; set; }

        [Column("description")]
        [ColumnDbType("text", 0, true, "")]
        public string Description { get; set; }

        [Column("recurs_next_year")]
        [ColumnDbType("bool", 0, false, "true")]
        public bool RecursNextYear { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}