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

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement=false)]
    [TableName("core.frequency_setup_scrud_view")]
    [ExplicitColumns]
    public sealed class FrequencySetupScrudView : PetaPocoDB.Record<FrequencySetupScrudView>, IPoco
    {
        [Column("frequency_setup_id")]
        [ColumnDbType("int4", 0, true, "")] 
        public int? FrequencySetupId { get; set; }
    
        [Column("frequency_setup_code")]
        [ColumnDbType("varchar", 12, true, "")] 
        public string FrequencySetupCode { get; set; }
    
        [Column("fiscal_year_code")]
        [ColumnDbType("varchar", 12, true, "")] 
        public string FiscalYearCode { get; set; }
    
        [Column("value_date")]
        [ColumnDbType("date", 0, true, "")] 
        public DateTime? ValueDate { get; set; }
    
        [Column("frequency_code")]
        [ColumnDbType("text", 0, true, "")] 
        public string FrequencyCode { get; set; }
    }
}