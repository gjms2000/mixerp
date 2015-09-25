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
    [TableName("hrm.termination_scrud_view")]
    [ExplicitColumns]
    public sealed class TerminationScrudView : PetaPocoDB.Record<TerminationScrudView>, IPoco
    {
        [Column("termination_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? TerminationId { get; set; }

        [Column("employee")]
        [ColumnDbType("text", 0, true, "")]
        public string Employee { get; set; }

        [Column("photo")]
        [ColumnDbType("image", 0, true, "")]
        public string Photo { get; set; }

        [Column("notice_date")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? NoticeDate { get; set; }

        [Column("service_end_date")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? ServiceEndDate { get; set; }

        [Column("forward_to")]
        [ColumnDbType("text", 0, true, "")]
        public string ForwardTo { get; set; }

        [Column("employment_status")]
        [ColumnDbType("text", 0, true, "")]
        public string EmploymentStatus { get; set; }

        [Column("reason")]
        [ColumnDbType("varchar", 128, true, "")]
        public string Reason { get; set; }

        [Column("details")]
        [ColumnDbType("text", 0, true, "")]
        public string Details { get; set; }
    }
}