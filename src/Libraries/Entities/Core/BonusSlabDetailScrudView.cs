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
    [TableName("core.bonus_slab_detail_scrud_view")]
    [ExplicitColumns]
    public sealed class BonusSlabDetailScrudView : PetaPocoDB.Record<BonusSlabDetailScrudView>, IPoco
    {
        [Column("bonus_slab_detail_id")]
        [ColumnDbType("int4", 0, true, "")] 
        public int? BonusSlabDetailId { get; set; }
    
        [Column("bonus_slab")]
        [ColumnDbType("text", 0, true, "")] 
        public string BonusSlab { get; set; }
    
        [Column("amount_from")]
        [ColumnDbType("money_strict", 0, true, "")] 
        public decimal? AmountFrom { get; set; }
    
        [Column("amount_to")]
        [ColumnDbType("money_strict", 0, true, "")] 
        public decimal? AmountTo { get; set; }
    
        [Column("bonus_rate")]
        [ColumnDbType("decimal_strict", 0, true, "")] 
        public decimal? BonusRate { get; set; }
    }
}