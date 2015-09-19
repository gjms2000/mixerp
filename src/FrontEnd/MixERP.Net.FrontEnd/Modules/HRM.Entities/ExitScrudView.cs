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
    [TableName("hrm.exit_scrud_view")]
    [ExplicitColumns]
    public sealed class ExitScrudView : PetaPocoDB.Record<ExitScrudView>, IPoco
    {
        [Column("exit_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? ExitId { get; set; }

        [Column("employee_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? EmployeeId { get; set; }

        [Column("employee_name")]
        [ColumnDbType("varchar", 160, true, "")]
        public string EmployeeName { get; set; }

        [Column("reason")]
        [ColumnDbType("varchar", 128, true, "")]
        public string Reason { get; set; }

        [Column("employment_status_code")]
        [ColumnDbType("text", 0, true, "")]
        public string EmploymentStatusCode { get; set; }

        [Column("exit_type")]
        [ColumnDbType("text", 0, true, "")]
        public string ExitType { get; set; }

        [Column("details")]
        [ColumnDbType("text", 0, true, "")]
        public string Details { get; set; }

        [Column("exit_interview_details")]
        [ColumnDbType("text", 0, true, "")]
        public string ExitInterviewDetails { get; set; }
    }
}