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
    [PrimaryKey("employee_wage_id", autoIncrement = true)]
    [TableName("hrm.employee_wages")]
    [ExplicitColumns]
    public sealed class EmployeeWage : PetaPocoDB.Record<EmployeeWage>, IPoco
    {
        [Column("employee_wage_id")]
        [ColumnDbType("int8", 0, false, "nextval('hrm.employee_wages_employee_wage_id_seq'::regclass)")]
        public long EmployeeWageId { get; set; }

        [Column("employee_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int EmployeeId { get; set; }

        [Column("wages_setup_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int WagesSetupId { get; set; }

        [Column("currency_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string CurrencyCode { get; set; }

        [Column("max_week_hours")]
        [ColumnDbType("int4", 0, false, "")]
        public int MaxWeekHours { get; set; }

        [Column("hourly_rate")]
        [ColumnDbType("money_strict", 0, false, "")]
        public decimal HourlyRate { get; set; }

        [Column("overtime_applicable")]
        [ColumnDbType("bool", 0, false, "")]
        public bool OvertimeApplicable { get; set; }

        [Column("overtime_hourly_rate")]
        [ColumnDbType("money_strict2", 0, true, "0")]
        public decimal? OvertimeHourlyRate { get; set; }

        [Column("valid_till")]
        [ColumnDbType("date", 0, false, "")]
        public DateTime ValidTill { get; set; }

        [Column("is_active")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? IsActive { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}