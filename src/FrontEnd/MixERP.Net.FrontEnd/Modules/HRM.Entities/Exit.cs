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
    [PrimaryKey("exit_id", autoIncrement=true)]
    [TableName("hrm.exits")]
    [ExplicitColumns]
    public sealed class Exit : PetaPocoDB.Record<Exit>, IPoco
    {
        [Column("exit_id")]
        [ColumnDbType("int8", 0, false, "nextval('hrm.exits_exit_id_seq'::regclass)")] 
        public long ExitId { get; set; }
    
        [Column("employee_id")]
        [ColumnDbType("int4", 0, false, "")] 
        public int EmployeeId { get; set; }
    
        [Column("change_status_code_to")]
        [ColumnDbType("int4", 0, false, "")] 
        public int ChangeStatusCodeTo { get; set; }
    
        [Column("exit_type_id")]
        [ColumnDbType("int4", 0, false, "")] 
        public int ExitTypeId { get; set; }
    
        [Column("exit_interview_details")]
        [ColumnDbType("text", 0, true, "")] 
        public string ExitInterviewDetails { get; set; }
    
        [Column("reason")]
        [ColumnDbType("varchar", 128, false, "")] 
        public string Reason { get; set; }
    
        [Column("details")]
        [ColumnDbType("text", 0, true, "")] 
        public string Details { get; set; }
    
        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }
    
        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }
    }
}