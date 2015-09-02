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
    [PrimaryKey("termination_id", autoIncrement=true)]
    [TableName("hrm.terminations")]
    [ExplicitColumns]
    public sealed class Termination : PetaPocoDB.Record<Termination>, IPoco
    {
        [Column("termination_id")]
        [ColumnDbType("int4", 0, false, "nextval('hrm.terminations_termination_id_seq'::regclass)")] 
        public int TerminationId { get; set; }
    
        [Column("entered_by")]
        [ColumnDbType("int4", 0, false, "")] 
        public int EnteredBy { get; set; }
    
        [Column("notice_date")]
        [ColumnDbType("date", 0, false, "")] 
        public DateTime NoticeDate { get; set; }
    
        [Column("effecive_termination_date")]
        [ColumnDbType("date", 0, false, "")] 
        public DateTime EffeciveTerminationDate { get; set; }
    
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
    
        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }
    
        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }
    }
}