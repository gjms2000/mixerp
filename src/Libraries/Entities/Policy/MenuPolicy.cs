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
    [PrimaryKey("policy_id", autoIncrement = true)]
    [TableName("policy.menu_policy")]
    [ExplicitColumns]
    public sealed class MenuPolicy : PetaPocoDB.Record<MenuPolicy>, IPoco
    {
        [Column("policy_id")]
        [ColumnDbType("int4", 0, false, "nextval('policy.menu_policy_policy_id_seq'::regclass)")]
        public int PolicyId { get; set; }

        [Column("menu_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int MenuId { get; set; }

        [Column("office_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? OfficeId { get; set; }

        [Column("inherit_in_child_offices")]
        [ColumnDbType("bool", 0, false, "false")]
        public bool InheritInChildOffices { get; set; }

        [Column("role_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? RoleId { get; set; }

        [Column("user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? UserId { get; set; }

        [Column("scope")]
        [ColumnDbType("varchar", 12, false, "")]
        public string Scope { get; set; }
    }
}