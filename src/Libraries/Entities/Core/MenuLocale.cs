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
    [PrimaryKey("menu_locale_id", autoIncrement = true)]
    [TableName("core.menu_locale")]
    [ExplicitColumns]
    public sealed class MenuLocale : PetaPocoDB.Record<MenuLocale>, IPoco
    {
        [Column("menu_locale_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.menu_locale_menu_locale_id_seq'::regclass)")]
        public int MenuLocaleId { get; set; }

        [Column("menu_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int MenuId { get; set; }

        [Column("culture")]
        [ColumnDbType("varchar", 12, false, "")]
        public string Culture { get; set; }

        [Column("menu_text")]
        [ColumnDbType("varchar", 250, false, "")]
        public string MenuText { get; set; }
    }
}