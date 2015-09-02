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
    [PrimaryKey("employee_qualification_id", autoIncrement=false)]
    [TableName("hrm.employee_qualifications")]
    [ExplicitColumns]
    public sealed class EmployeeQualification : PetaPocoDB.Record<EmployeeQualification>, IPoco
    {
        [Column("employee_qualification_id")]
        [ColumnDbType("int8", 0, false, "")] 
        public long EmployeeQualificationId { get; set; }
    
        [Column("employee_id")]
        [ColumnDbType("int4", 0, false, "")] 
        public int EmployeeId { get; set; }
    
        [Column("education_level_id")]
        [ColumnDbType("int4", 0, false, "")] 
        public int EducationLevelId { get; set; }
    
        [Column("institution")]
        [ColumnDbType("varchar", 128, false, "")] 
        public string Institution { get; set; }
    
        [Column("majors")]
        [ColumnDbType("varchar", 128, false, "")] 
        public string Majors { get; set; }
    
        [Column("total_years")]
        [ColumnDbType("int4", 0, true, "")] 
        public int? TotalYears { get; set; }
    
        [Column("score")]
        [ColumnDbType("numeric", 0, true, "")] 
        public decimal? Score { get; set; }
    
        [Column("started_on")]
        [ColumnDbType("date", 0, true, "")] 
        public DateTime? StartedOn { get; set; }
    
        [Column("completed_on")]
        [ColumnDbType("date", 0, true, "")] 
        public DateTime? CompletedOn { get; set; }
    
        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }
    
        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }
    }
}