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
    [TableName("core.state_scrud_view")]
    [ExplicitColumns]
    public sealed class StateScrudView : PetaPocoDB.Record<StateScrudView>, IPoco
    {
        [Column("state_id")]
        [ColumnDbType("int4", 0, true, "")] 
        public int? StateId { get; set; }
    
        [Column("country_name")]
        [ColumnDbType("text", 0, true, "")] 
        public string CountryName { get; set; }
    
        [Column("state_code")]
        [ColumnDbType("varchar", 12, true, "")] 
        public string StateCode { get; set; }
    
        [Column("state_name")]
        [ColumnDbType("varchar", 100, true, "")] 
        public string StateName { get; set; }
    }
}