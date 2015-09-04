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
    [TableName("core.bonus_slab_scrud_view")]
    [ExplicitColumns]
    public sealed class BonusSlabScrudView : PetaPocoDB.Record<BonusSlabScrudView>, IPoco
    {
        [Column("bonus_slab_id")]
        [ColumnDbType("int4", 0, true, "")] 
        public int? BonusSlabId { get; set; }
    
        [Column("bonus_slab_code")]
        [ColumnDbType("varchar", 12, true, "")] 
        public string BonusSlabCode { get; set; }
    
        [Column("bonus_slab_name")]
        [ColumnDbType("varchar", 50, true, "")] 
        public string BonusSlabName { get; set; }
    
        [Column("effective_from")]
        [ColumnDbType("date", 0, true, "")] 
        public DateTime? EffectiveFrom { get; set; }
    
        [Column("ends_on")]
        [ColumnDbType("date", 0, true, "")] 
        public DateTime? EndsOn { get; set; }
    
        [Column("checking_frequency")]
        [ColumnDbType("text", 0, true, "")] 
        public string CheckingFrequency { get; set; }
    
        [Column("account")]
        [ColumnDbType("text", 0, true, "")] 
        public string Account { get; set; }
    
        [Column("statement_reference")]
        [ColumnDbType("varchar", 100, true, "")] 
        public string StatementReference { get; set; }
    }
}