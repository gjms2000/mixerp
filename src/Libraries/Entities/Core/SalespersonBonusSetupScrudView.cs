// ReSharper disable All
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
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.salesperson_bonus_setup_scrud_view")]
    [ExplicitColumns]
    public sealed class SalespersonBonusSetupScrudView : PetaPocoDB.Record<SalespersonBonusSetupScrudView>, IPoco
    {
        [Column("salesperson_bonus_setup_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? SalespersonBonusSetupId { get; set; }

        [Column("salesperson")]
        [ColumnDbType("text", 0, true, "")]
        public string Salesperson { get; set; }

        [Column("bonus_slab")]
        [ColumnDbType("text", 0, true, "")]
        public string BonusSlab { get; set; }
    }
}