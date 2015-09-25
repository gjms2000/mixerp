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
    [PrimaryKey("", autoIncrement = false)]
    [TableName("hrm.leave_application_scrud_view")]
    [ExplicitColumns]
    public sealed class LeaveApplicationScrudView : PetaPocoDB.Record<LeaveApplicationScrudView>, IPoco
    {
        [Column("leave_application_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? LeaveApplicationId { get; set; }

        [Column("employee")]
        [ColumnDbType("text", 0, true, "")]
        public string Employee { get; set; }

        [Column("photo")]
        [ColumnDbType("image", 0, true, "")]
        public string Photo { get; set; }

        [Column("leave_type")]
        [ColumnDbType("text", 0, true, "")]
        public string LeaveType { get; set; }

        [Column("entered_by")]
        [ColumnDbType("varchar", 50, true, "")]
        public string EnteredBy { get; set; }

        [Column("applied_on")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? AppliedOn { get; set; }

        [Column("reason")]
        [ColumnDbType("text", 0, true, "")]
        public string Reason { get; set; }

        [Column("start_date")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? StartDate { get; set; }

        [Column("end_date")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? EndDate { get; set; }
    }
}