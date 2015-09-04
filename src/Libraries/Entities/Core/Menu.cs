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
    [PrimaryKey("menu_id", autoIncrement=true)]
    [TableName("core.menus")]
    [ExplicitColumns]
    public sealed class Menu : PetaPocoDB.Record<Menu>, IPoco
    {
        [Column("menu_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.menus_menu_id_seq'::regclass)")] 
        public int MenuId { get; set; }
    
        [Column("menu_text")]
        [ColumnDbType("varchar", 250, false, "")] 
        public string MenuText { get; set; }
    
        [Column("url")]
        [ColumnDbType("varchar", 250, true, "")] 
        public string Url { get; set; }
    
        [Column("menu_code")]
        [ColumnDbType("varchar", 12, false, "")] 
        public string MenuCode { get; set; }
    
        [Column("level")]
        [ColumnDbType("int2", 0, false, "")] 
        public short Level { get; set; }
    
        [Column("parent_menu_id")]
        [ColumnDbType("int4", 0, true, "")] 
        public int? ParentMenuId { get; set; }
    
        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }
    
        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }
    }
}