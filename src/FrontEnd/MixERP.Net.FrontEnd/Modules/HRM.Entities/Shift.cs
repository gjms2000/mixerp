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
    [PrimaryKey("shift_id")]
    [TableName("hrm.shifts")]
    [ExplicitColumns]
    public sealed class Shift : PetaPocoDB.Record<Shift>, IPoco
    {
        [Column("shift_id")]
        [ColumnDbType("int4", 0, "nextval('hrm.shifts_shift_id_seq'::regclass)")] 
        public int ShiftId { get; set; }
    
        [Column("shift_code")]
        [ColumnDbType("varchar", 12, "")] 
        public string ShiftCode { get; set; }
    
        [Column("shift_name")]
        [ColumnDbType("varchar", 100, "")] 
        public string ShiftName { get; set; }
    
        [Column("begins_from")]
        [ColumnDbType("time", 0, "")] 
        public DateTime BeginsFrom { get; set; }
    
        [Column("ends_on")]
        [ColumnDbType("time", 0, "")] 
        public DateTime EndsOn { get; set; }
    
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