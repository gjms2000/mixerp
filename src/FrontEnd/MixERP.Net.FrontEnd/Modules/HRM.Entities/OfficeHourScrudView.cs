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
    [TableName("hrm.office_hour_scrud_view")]
    [ExplicitColumns]
    public sealed class OfficeHourScrudView : PetaPocoDB.Record<OfficeHourScrudView>, IPoco
    {
        [Column("office_hour_id")]
        [ColumnDbType("int4", 0, true, "")] 
        public int? OfficeHourId { get; set; }
    
        [Column("office")]
        [ColumnDbType("text", 0, true, "")] 
        public string Office { get; set; }
    
        [Column("shift")]
        [ColumnDbType("text", 0, true, "")] 
        public string Shift { get; set; }
    
        [Column("week_day")]
        [ColumnDbType("text", 0, true, "")] 
        public string WeekDay { get; set; }
    
        [Column("begins_from")]
        [ColumnDbType("time", 0, true, "")] 
        public DateTime? BeginsFrom { get; set; }
    
        [Column("ends_on")]
        [ColumnDbType("time", 0, true, "")] 
        public DateTime? EndsOn { get; set; }
    }
}