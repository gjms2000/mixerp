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
    [PrimaryKey("resignation_id", autoIncrement=true)]
    [TableName("hrm.resignations")]
    [ExplicitColumns]
    public sealed class Resignation : PetaPocoDB.Record<Resignation>, IPoco
    {
        [Column("resignation_id")]
        [ColumnDbType("int4", 0, false, "nextval('hrm.resignations_resignation_id_seq'::regclass)")] 
        public int ResignationId { get; set; }
    
        [Column("entered_by")]
        [ColumnDbType("int4", 0, false, "")] 
        public int EnteredBy { get; set; }
    
        [Column("notice_date")]
        [ColumnDbType("date", 0, false, "")] 
        public DateTime NoticeDate { get; set; }
    
        [Column("desired_resign_date")]
        [ColumnDbType("date", 0, false, "")] 
        public DateTime DesiredResignDate { get; set; }
    
        [Column("employee_id")]
        [ColumnDbType("int4", 0, false, "")] 
        public int EmployeeId { get; set; }
    
        [Column("forward_to")]
        [ColumnDbType("int4", 0, true, "")] 
        public int? ForwardTo { get; set; }
    
        [Column("reason")]
        [ColumnDbType("varchar", 128, false, "")] 
        public string Reason { get; set; }
    
        [Column("details")]
        [ColumnDbType("text", 0, true, "")] 
        public string Details { get; set; }
    
        [Column("verification_status_id")]
        [ColumnDbType("int4", 0, false, "")] 
        public int VerificationStatusId { get; set; }
    
        [Column("verified_by_user_id")]
        [ColumnDbType("int4", 0, false, "")] 
        public int VerifiedByUserId { get; set; }
    
        [Column("verified_on")]
        [ColumnDbType("date", 0, false, "")] 
        public DateTime VerifiedOn { get; set; }
    
        [Column("effecive_resignation_date")]
        [ColumnDbType("date", 0, false, "")] 
        public DateTime EffeciveResignationDate { get; set; }
    
        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }
    
        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }
    }
}