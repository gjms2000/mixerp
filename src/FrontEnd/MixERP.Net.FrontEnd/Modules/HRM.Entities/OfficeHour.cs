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
    [PrimaryKey("week_day_id")]
    [TableName("hrm.office_hours")]
    [ExplicitColumns]
    public sealed class OfficeHour : PetaPocoDB.Record<OfficeHour>, IPoco
    {
        [Column("week_day_id")]
        [ColumnDbType("int4", 0, "")] 
        public int WeekDayId { get; set; }
    
        [Column("office_id")]
        [ColumnDbType("int4", 0, "")] 
        public int OfficeId { get; set; }
    
        [Column("shift_id")]
        [ColumnDbType("int4", 0, "")] 
        public int ShiftId { get; set; }
    
        [Column("begins_from")]
        [ColumnDbType("time", 0, "")] 
        public DateTime BeginsFrom { get; set; }
    
        [Column("ends_on")]
        [ColumnDbType("time", 0, "")] 
        public DateTime EndsOn { get; set; }
    
        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, "")] 
        public int? AuditUserId { get; set; }
    
        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, "")] 
        public DateTime? AuditTs { get; set; }
    }
}