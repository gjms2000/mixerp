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
using MixERP.Net.Entities.Contracts;
using PetaPoco;
using System;

namespace MixERP.Net.Entities.HRM
{
    [PrimaryKey("salary_id", autoIncrement=false)]
    [TableName("hrm.salaries")]
    [ExplicitColumns]
    public sealed class Salary : PetaPocoDB.Record<Salary>, IPoco
    {
        [Column("salary_id")]
        [ColumnDbType("int8", 0, false, "")] 
        public long SalaryId { get; set; }
    
        [Column("employee_id")]
        [ColumnDbType("int4", 0, false, "")] 
        public int EmployeeId { get; set; }
    
        [Column("salary_type_id")]
        [ColumnDbType("int4", 0, false, "")] 
        public int SalaryTypeId { get; set; }
    
        [Column("pay_grade_id")]
        [ColumnDbType("int4", 0, false, "")] 
        public int PayGradeId { get; set; }
    
        [Column("salary_frequency_id")]
        [ColumnDbType("int4", 0, false, "")] 
        public int SalaryFrequencyId { get; set; }
    
        [Column("currency_code")]
        [ColumnDbType("varchar", 12, false, "")] 
        public string CurrencyCode { get; set; }
    
        [Column("amount")]
        [ColumnDbType("money_strict", 0, false, "")] 
        public decimal Amount { get; set; }
    
        [Column("deduction_applicable")]
        [ColumnDbType("bool", 0, false, "false")] 
        public bool DeductionApplicable { get; set; }
    
        [Column("auto_deduction_based_on_attendance")]
        [ColumnDbType("bool", 0, false, "false")] 
        public bool AutoDeductionBasedOnAttendance { get; set; }
    
        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }
    
        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }
    }
}