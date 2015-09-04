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

namespace MixERP.Net.Entities.Policy
{
    [PrimaryKey("access_id", autoIncrement=true)]
    [TableName("policy.menu_access")]
    [ExplicitColumns]
    public sealed class MenuAccess : PetaPocoDB.Record<MenuAccess>, IPoco
    {
        [Column("access_id")]
        [ColumnDbType("int8", 0, false, "nextval('policy.menu_access_access_id_seq'::regclass)")] 
        public long AccessId { get; set; }
    
        [Column("office_id")]
        [ColumnDbType("int4", 0, false, "")] 
        public int OfficeId { get; set; }
    
        [Column("menu_id")]
        [ColumnDbType("int4", 0, false, "")] 
        public int MenuId { get; set; }
    
        [Column("user_id")]
        [ColumnDbType("int4", 0, true, "")] 
        public int? UserId { get; set; }
    }
}