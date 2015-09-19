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
    [TableName("hrm.employee_view")]
    [ExplicitColumns]
    public sealed class EmployeeView : PetaPocoDB.Record<EmployeeView>, IPoco
    {
        [Column("employee_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? EmployeeId { get; set; }

        [Column("first_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string FirstName { get; set; }

        [Column("middle_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string MiddleName { get; set; }

        [Column("last_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string LastName { get; set; }

        [Column("employee_name")]
        [ColumnDbType("varchar", 160, true, "")]
        public string EmployeeName { get; set; }

        [Column("gender_code")]
        [ColumnDbType("varchar", 4, true, "")]
        public string GenderCode { get; set; }

        [Column("gender_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string GenderName { get; set; }

        [Column("joined_on")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? JoinedOn { get; set; }

        [Column("office_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? OfficeId { get; set; }

        [Column("office")]
        [ColumnDbType("text", 0, true, "")]
        public string Office { get; set; }

        [Column("user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? UserId { get; set; }

        [Column("user_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string UserName { get; set; }

        [Column("employee_type_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? EmployeeTypeId { get; set; }

        [Column("employee_type")]
        [ColumnDbType("text", 0, true, "")]
        public string EmployeeType { get; set; }

        [Column("current_department_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? CurrentDepartmentId { get; set; }

        [Column("current_department")]
        [ColumnDbType("text", 0, true, "")]
        public string CurrentDepartment { get; set; }

        [Column("current_role_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? CurrentRoleId { get; set; }

        [Column("role")]
        [ColumnDbType("text", 0, true, "")]
        public string Role { get; set; }

        [Column("current_employment_status_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? CurrentEmploymentStatusId { get; set; }

        [Column("employment_status")]
        [ColumnDbType("text", 0, true, "")]
        public string EmploymentStatus { get; set; }

        [Column("current_job_title_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? CurrentJobTitleId { get; set; }

        [Column("job_title")]
        [ColumnDbType("text", 0, true, "")]
        public string JobTitle { get; set; }

        [Column("current_pay_grade_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? CurrentPayGradeId { get; set; }

        [Column("pay_grade")]
        [ColumnDbType("text", 0, true, "")]
        public string PayGrade { get; set; }

        [Column("current_shift_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? CurrentShiftId { get; set; }

        [Column("shift")]
        [ColumnDbType("text", 0, true, "")]
        public string Shift { get; set; }

        [Column("nationality_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string NationalityCode { get; set; }

        [Column("nationality")]
        [ColumnDbType("text", 0, true, "")]
        public string Nationality { get; set; }

        [Column("date_of_birth")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? DateOfBirth { get; set; }

        [Column("photo")]
        [ColumnDbType("image", 0, true, "")]
        public string Photo { get; set; }

        [Column("zip_code")]
        [ColumnDbType("varchar", 128, true, "")]
        public string ZipCode { get; set; }

        [Column("address_line_1")]
        [ColumnDbType("varchar", 128, true, "")]
        public string AddressLine1 { get; set; }

        [Column("address_line_2")]
        [ColumnDbType("varchar", 128, true, "")]
        public string AddressLine2 { get; set; }

        [Column("street")]
        [ColumnDbType("varchar", 128, true, "")]
        public string Street { get; set; }

        [Column("city")]
        [ColumnDbType("varchar", 128, true, "")]
        public string City { get; set; }

        [Column("state")]
        [ColumnDbType("varchar", 128, true, "")]
        public string State { get; set; }

        [Column("country_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? CountryId { get; set; }

        [Column("country")]
        [ColumnDbType("varchar", 100, true, "")]
        public string Country { get; set; }

        [Column("phone_home")]
        [ColumnDbType("varchar", 128, true, "")]
        public string PhoneHome { get; set; }

        [Column("phone_cell")]
        [ColumnDbType("varchar", 128, true, "")]
        public string PhoneCell { get; set; }

        [Column("phone_office_extension")]
        [ColumnDbType("varchar", 128, true, "")]
        public string PhoneOfficeExtension { get; set; }

        [Column("phone_emergency")]
        [ColumnDbType("varchar", 128, true, "")]
        public string PhoneEmergency { get; set; }

        [Column("phone_emergency2")]
        [ColumnDbType("varchar", 128, true, "")]
        public string PhoneEmergency2 { get; set; }

        [Column("email_address")]
        [ColumnDbType("varchar", 128, true, "")]
        public string EmailAddress { get; set; }

        [Column("website")]
        [ColumnDbType("varchar", 128, true, "")]
        public string Website { get; set; }

        [Column("blog")]
        [ColumnDbType("varchar", 128, true, "")]
        public string Blog { get; set; }
    }
}