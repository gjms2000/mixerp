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
    [PrimaryKey("employment_status_id")]
    [TableName("hrm.employment_statuses")]
    [ExplicitColumns]
    public sealed class EmploymentStatus : PetaPocoDB.Record<EmploymentStatus>, IPoco
    {
        [Column("employment_status_id")]
        [ColumnDbType("int4", 0, "nextval('hrm.employment_statuses_employment_status_id_seq'::regclass)")] 
        public int EmploymentStatusId { get; set; }
    
        [Column("employment_status_code")]
        [ColumnDbType("varchar", 12, "")] 
        public string EmploymentStatusCode { get; set; }
    
        [Column("employment_status_name")]
        [ColumnDbType("varchar", 100, "")] 
        public string EmploymentStatusName { get; set; }
    
        [Column("is_contract")]
        [ColumnDbType("bool", 0, "false")] 
        public bool IsContract { get; set; }
    
        [Column("default_employment_status_code_id")]
        [ColumnDbType("int4", 0, "")] 
        public int DefaultEmploymentStatusCodeId { get; set; }
    
        [Column("description")]
        [ColumnDbType("text", 0, "")] 
        public string Description { get; set; }
    
        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, "")] 
        public int? AuditUserId { get; set; }
    
        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, "")] 
        public DateTime? AuditTs { get; set; }
    }
}