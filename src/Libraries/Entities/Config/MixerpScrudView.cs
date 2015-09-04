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

namespace MixERP.Net.Entities.Config
{
    [PrimaryKey("", autoIncrement=false)]
    [TableName("config.mixerp_scrud_view")]
    [ExplicitColumns]
    public sealed class MixerpScrudView : PetaPocoDB.Record<MixerpScrudView>, IPoco
    {
        [Column("key")]
        [ColumnDbType("text", 0, true, "")] 
        public string Key { get; set; }
    
        [Column("value")]
        [ColumnDbType("text", 0, true, "")] 
        public string Value { get; set; }
    
        [Column("description")]
        [ColumnDbType("text", 0, true, "")] 
        public string Description { get; set; }
    }
}