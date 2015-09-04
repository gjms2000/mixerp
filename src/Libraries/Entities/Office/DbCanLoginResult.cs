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

namespace MixERP.Net.Entities.Office
{
    [PrimaryKey("", autoIncrement=false)]
    [FunctionName("office.can_login")]
    [ExplicitColumns]
    public sealed class DbCanLoginResult : PetaPocoDB.Record<DbCanLoginResult>, IPoco
    {
        [Column("result")]
        [ColumnDbType("boolean", 0, false, "")] 
        public bool Result { get; set; }
    
        [Column("message")]
        [ColumnDbType("text", 0, false, "")] 
        public string Message { get; set; }
    }
}