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
    [TableName("core.late_fee_scrud_view")]
    [ExplicitColumns]
    public sealed class LateFeeScrudView : PetaPocoDB.Record<LateFeeScrudView>, IPoco
    {
        [Column("late_fee_id")]
        [ColumnDbType("int4", 0, true, "")] 
        public int? LateFeeId { get; set; }
    
        [Column("late_fee_code")]
        [ColumnDbType("varchar", 12, true, "")] 
        public string LateFeeCode { get; set; }
    
        [Column("late_fee_name")]
        [ColumnDbType("varchar", 50, true, "")] 
        public string LateFeeName { get; set; }
    
        [Column("is_flat_amount")]
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsFlatAmount { get; set; }
    
        [Column("rate")]
        [ColumnDbType("numeric", 1572868, true, "")] 
        public decimal? Rate { get; set; }
    
        [Column("account")]
        [ColumnDbType("text", 0, true, "")] 
        public string Account { get; set; }
    }
}