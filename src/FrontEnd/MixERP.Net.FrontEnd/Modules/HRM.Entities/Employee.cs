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
    [PrimaryKey("employee_id")]
    [TableName("hrm.employees")]
    [ExplicitColumns]
    public sealed class Employee : PetaPocoDB.Record<Employee>, IPoco
    {
        [Column("employee_id")]
        [ColumnDbType("int4", 0, "nextval('hrm.employees_employee_id_seq'::regclass)")] 
        public int EmployeeId { get; set; }
    
        [Column("first_name")]
        [ColumnDbType("varchar", 50, "")] 
        public string FirstName { get; set; }
    
        [Column("middle_name")]
        [ColumnDbType("varchar", 50, "")] 
        public string MiddleName { get; set; }
    
        [Column("last_name")]
        [ColumnDbType("varchar", 50, "")] 
        public string LastName { get; set; }
    
        [Column("employee_name")]
        [ColumnDbType("varchar", 160, "")] 
        public string EmployeeName { get; set; }
    
        [Column("gender_code")]
        [ColumnDbType("bpchar", 2, "")] 
        public string GenderCode { get; set; }
    
        [Column("joined_on")]
        [ColumnDbType("date", 0, "")] 
        public DateTime? JoinedOn { get; set; }
    
        [Column("office_id")]
        [ColumnDbType("int4", 0, "")] 
        public int OfficeId { get; set; }
    
        [Column("user_id")]
        [ColumnDbType("int4", 0, "")] 
        public int UserId { get; set; }
    
        [Column("employee_type_id")]
        [ColumnDbType("int4", 0, "")] 
        public int EmployeeTypeId { get; set; }
    
        [Column("current_department_id")]
        [ColumnDbType("int4", 0, "")] 
        public int CurrentDepartmentId { get; set; }
    
        [Column("current_role_id")]
        [ColumnDbType("int4", 0, "")] 
        public int? CurrentRoleId { get; set; }
    
        [Column("current_employment_status_code_id")]
        [ColumnDbType("int4", 0, "0")] 
        public int CurrentEmploymentStatusCodeId { get; set; }
    
        [Column("current_employment_status_id")]
        [ColumnDbType("int4", 0, "")] 
        public int CurrentEmploymentStatusId { get; set; }
    
        [Column("current_job_title_id")]
        [ColumnDbType("int4", 0, "")] 
        public int CurrentJobTitleId { get; set; }
    
        [Column("current_pay_grade_id")]
        [ColumnDbType("int4", 0, "")] 
        public int CurrentPayGradeId { get; set; }
    
        [Column("current_shift_id")]
        [ColumnDbType("int4", 0, "")] 
        public int CurrentShiftId { get; set; }
    
        [Column("nationality_code")]
        [ColumnDbType("varchar", 12, "")] 
        public string NationalityCode { get; set; }
    
        [Column("date_of_birth")]
        [ColumnDbType("date", 0, "")] 
        public DateTime? DateOfBirth { get; set; }
    
        [Column("photo")]
        [ColumnDbType("text", 0, "")] 
        public string Photo { get; set; }
    
        [Column("address_line_1")]
        [ColumnDbType("varchar", 128, "")] 
        public string AddressLine1 { get; set; }
    
        [Column("address_line_2")]
        [ColumnDbType("varchar", 128, "")] 
        public string AddressLine2 { get; set; }
    
        [Column("street")]
        [ColumnDbType("varchar", 128, "")] 
        public string Street { get; set; }
    
        [Column("city")]
        [ColumnDbType("varchar", 128, "")] 
        public string City { get; set; }
    
        [Column("state")]
        [ColumnDbType("varchar", 128, "")] 
        public string State { get; set; }
    
        [Column("country_id")]
        [ColumnDbType("int4", 0, "")] 
        public int? CountryId { get; set; }
    
        [Column("phone_home")]
        [ColumnDbType("varchar", 128, "")] 
        public string PhoneHome { get; set; }
    
        [Column("phone_cell")]
        [ColumnDbType("varchar", 128, "")] 
        public string PhoneCell { get; set; }
    
        [Column("phone_office_extension")]
        [ColumnDbType("varchar", 128, "")] 
        public string PhoneOfficeExtension { get; set; }
    
        [Column("phone_emergency")]
        [ColumnDbType("varchar", 128, "")] 
        public string PhoneEmergency { get; set; }
    
        [Column("phone_emergency2")]
        [ColumnDbType("varchar", 128, "")] 
        public string PhoneEmergency2 { get; set; }
    
        [Column("email_address")]
        [ColumnDbType("varchar", 128, "")] 
        public string EmailAddress { get; set; }
    
        [Column("website")]
        [ColumnDbType("varchar", 128, "")] 
        public string Website { get; set; }
    
        [Column("blog")]
        [ColumnDbType("varchar", 128, "")] 
        public string Blog { get; set; }
    
        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, "")] 
        public int? AuditUserId { get; set; }
    
        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, "")] 
        public DateTime? AuditTs { get; set; }
    }
}