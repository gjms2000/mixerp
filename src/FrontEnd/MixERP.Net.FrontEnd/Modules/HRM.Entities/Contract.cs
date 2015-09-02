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
    [PrimaryKey("contract_id", autoIncrement=true)]
    [TableName("hrm.contracts")]
    [ExplicitColumns]
    public sealed class Contract : PetaPocoDB.Record<Contract>, IPoco
    {
        [Column("contract_id")]
        [ColumnDbType("int8", 0, false, "nextval('hrm.contracts_contract_id_seq'::regclass)")] 
        public long ContractId { get; set; }
    
        [Column("employee_id")]
        [ColumnDbType("int4", 0, false, "")] 
        public int EmployeeId { get; set; }
    
        [Column("office_id")]
        [ColumnDbType("int4", 0, false, "")] 
        public int OfficeId { get; set; }
    
        [Column("department_id")]
        [ColumnDbType("int4", 0, false, "")] 
        public int DepartmentId { get; set; }
    
        [Column("role_id")]
        [ColumnDbType("int4", 0, true, "")] 
        public int? RoleId { get; set; }
    
        [Column("leave_benefit_id")]
        [ColumnDbType("int4", 0, true, "")] 
        public int? LeaveBenefitId { get; set; }
    
        [Column("began_on")]
        [ColumnDbType("date", 0, true, "")] 
        public DateTime? BeganOn { get; set; }
    
        [Column("ended_on")]
        [ColumnDbType("date", 0, true, "")] 
        public DateTime? EndedOn { get; set; }
    
        [Column("employment_status_code_id")]
        [ColumnDbType("int4", 0, false, "")] 
        public int EmploymentStatusCodeId { get; set; }
    
        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }
    
        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }
    }
}