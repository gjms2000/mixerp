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
    [FunctionName("policy.get_menu_policy")]
    [ExplicitColumns]
    public sealed class DbGetMenuPolicyResult : PetaPocoDB.Record<DbGetMenuPolicyResult>, IPoco
    {
        [Column("row_number")]
        [ColumnDbType("bigint", 0, false, "")]
        public long RowNumber { get; set; }

        [Column("access")]
        [ColumnDbType("boolean", 0, false, "")]
        public bool Access { get; set; }

        [Column("menu_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int MenuId { get; set; }

        [Column("menu_code")]
        [ColumnDbType("text", 0, false, "")]
        public string MenuCode { get; set; }

        [Column("menu_text")]
        [ColumnDbType("text", 0, false, "")]
        public string MenuText { get; set; }

        [Column("url")]
        [ColumnDbType("text", 0, false, "")]
        public string Url { get; set; }
    }
}