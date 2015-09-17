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
    [PrimaryKey("wages_setup_id", autoIncrement=true)]
    [TableName("hrm.wages_setup")]
    [ExplicitColumns]
    public sealed class WagesSetup : PetaPocoDB.Record<WagesSetup>, IPoco
    {
        [Column("wages_setup_id")]
        [ColumnDbType("int4", 0, false, "nextval('hrm.wages_setup_wages_setup_id_seq'::regclass)")] 
        public int WagesSetupId { get; set; }
    
        [Column("wages_setup_code")]
        [ColumnDbType("varchar", 12, false, "")] 
        public string WagesSetupCode { get; set; }
    
        [Column("wages_setup_name")]
        [ColumnDbType("varchar", 128, false, "")] 
        public string WagesSetupName { get; set; }
    
        [Column("currency_code")]
        [ColumnDbType("varchar", 12, false, "")] 
        public string CurrencyCode { get; set; }
    
        [Column("max_week_hours")]
        [ColumnDbType("int4", 0, false, "0")] 
        public int MaxWeekHours { get; set; }
    
        [Column("hourly_rate")]
        [ColumnDbType("money_strict", 0, false, "")] 
        public decimal HourlyRate { get; set; }
    
        [Column("overtime_applicable")]
        [ColumnDbType("bool", 0, false, "true")] 
        public bool OvertimeApplicable { get; set; }
    
        [Column("overtime_hourly_rate")]
        [ColumnDbType("money_strict2", 0, false, "")] 
        public decimal OvertimeHourlyRate { get; set; }
    
        [Column("description")]
        [ColumnDbType("text", 0, true, "")] 
        public string Description { get; set; }
    
        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }
    
        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }
    }
}