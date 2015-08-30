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
    [PrimaryKey("job_title_id")]
    [TableName("hrm.job_titles")]
    [ExplicitColumns]
    public sealed class JobTitle : PetaPocoDB.Record<JobTitle>, IPoco
    {
        [Column("job_title_id")]
        [ColumnDbType("int4", 0, "nextval('hrm.job_titles_job_title_id_seq'::regclass)")] 
        public int JobTitleId { get; set; }
    
        [Column("job_title_code")]
        [ColumnDbType("varchar", 12, "")] 
        public string JobTitleCode { get; set; }
    
        [Column("job_title_name")]
        [ColumnDbType("varchar", 100, "")] 
        public string JobTitleName { get; set; }
    
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