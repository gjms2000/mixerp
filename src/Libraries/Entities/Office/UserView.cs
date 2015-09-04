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
    [TableName("office.user_view")]
    [ExplicitColumns]
    public sealed class UserView : PetaPocoDB.Record<UserView>, IPoco
    {
        [Column("user_id")]
        [ColumnDbType("int4", 0, true, "")] 
        public int? UserId { get; set; }
    
        [Column("user_name")]
        [ColumnDbType("varchar", 50, true, "")] 
        public string UserName { get; set; }
    
        [Column("full_name")]
        [ColumnDbType("varchar", 100, true, "")] 
        public string FullName { get; set; }
    
        [Column("role_name")]
        [ColumnDbType("varchar", 50, true, "")] 
        public string RoleName { get; set; }
    
        [Column("office_name")]
        [ColumnDbType("varchar", 150, true, "")] 
        public string OfficeName { get; set; }
    }
}