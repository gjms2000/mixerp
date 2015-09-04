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
    [FunctionName("core.get_associated_units_from_item_code")]
    [ExplicitColumns]
    public sealed class DbGetAssociatedUnitsFromItemCodeResult : PetaPocoDB.Record<DbGetAssociatedUnitsFromItemCodeResult>, IPoco
    {
        [Column("unit_id")]
        [ColumnDbType("integer", 0, false, "")] 
        public int UnitId { get; set; }
    
        [Column("unit_code")]
        [ColumnDbType("text", 0, false, "")] 
        public string UnitCode { get; set; }
    
        [Column("unit_name")]
        [ColumnDbType("text", 0, false, "")] 
        public string UnitName { get; set; }
    }
}