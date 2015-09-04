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
    [PrimaryKey("employee_social_network_detail_id", autoIncrement=true)]
    [TableName("hrm.employee_social_network_details")]
    [ExplicitColumns]
    public sealed class EmployeeSocialNetworkDetail : PetaPocoDB.Record<EmployeeSocialNetworkDetail>, IPoco
    {
        [Column("employee_social_network_detail_id")]
        [ColumnDbType("int8", 0, false, "nextval('hrm.employee_social_network_detai_employee_social_network_detai_seq'::regclass)")] 
        public long EmployeeSocialNetworkDetailId { get; set; }
    
        [Column("employee_id")]
        [ColumnDbType("int4", 0, false, "")] 
        public int EmployeeId { get; set; }
    
        [Column("social_network_name")]
        [ColumnDbType("varchar", 128, false, "")] 
        public string SocialNetworkName { get; set; }
    
        [Column("social_network_id")]
        [ColumnDbType("text", 0, true, "")] 
        public string SocialNetworkId { get; set; }
    
        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }
    
        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }
    }
}