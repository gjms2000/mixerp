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
    [PrimaryKey("", autoIncrement=false)]
    [TableName("hrm.employee_experience_scrud_view")]
    [ExplicitColumns]
    public sealed class EmployeeExperienceScrudView : PetaPocoDB.Record<EmployeeExperienceScrudView>, IPoco
    {
        [Column("employee_experience_id")]
        [ColumnDbType("int8", 0, true, "")] 
        public long? EmployeeExperienceId { get; set; }
    
        [Column("employee_id")]
        [ColumnDbType("int4", 0, true, "")] 
        public int? EmployeeId { get; set; }
    
        [Column("employee_name")]
        [ColumnDbType("varchar", 160, true, "")] 
        public string EmployeeName { get; set; }
    
        [Column("organization_name")]
        [ColumnDbType("varchar", 128, true, "")] 
        public string OrganizationName { get; set; }
    
        [Column("title")]
        [ColumnDbType("varchar", 128, true, "")] 
        public string Title { get; set; }
    
        [Column("started_on")]
        [ColumnDbType("date", 0, true, "")] 
        public DateTime? StartedOn { get; set; }
    
        [Column("ended_on")]
        [ColumnDbType("date", 0, true, "")] 
        public DateTime? EndedOn { get; set; }
    }
}