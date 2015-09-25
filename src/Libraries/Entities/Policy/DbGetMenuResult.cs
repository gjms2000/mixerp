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

namespace MixERP.Net.Entities.Policy
{
    [PrimaryKey("", autoIncrement = false)]
    [FunctionName("policy.get_menu")]
    [ExplicitColumns]
    public sealed class DbGetMenuResult : PetaPocoDB.Record<DbGetMenuResult>, IPoco
    {
        [Column("menu_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int MenuId { get; set; }

        [Column("menu_text")]
        [ColumnDbType("character varying", 0, false, "")]
        public string MenuText { get; set; }

        [Column("url")]
        [ColumnDbType("character varying", 0, false, "")]
        public string Url { get; set; }

        [Column("menu_code")]
        [ColumnDbType("character varying", 0, false, "")]
        public string MenuCode { get; set; }

        [Column("sort")]
        [ColumnDbType("integer", 0, false, "")]
        public int Sort { get; set; }

        [Column("icon")]
        [ColumnDbType("character varying", 0, false, "")]
        public string Icon { get; set; }

        [Column("level")]
        [ColumnDbType("smallint", 0, false, "")]
        public short Level { get; set; }

        [Column("parent_menu_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int ParentMenuId { get; set; }
    }
}