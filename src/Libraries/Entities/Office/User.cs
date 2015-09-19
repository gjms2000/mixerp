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
    [PrimaryKey("user_id", autoIncrement = true)]
    [TableName("office.users")]
    [ExplicitColumns]
    public sealed class User : PetaPocoDB.Record<User>, IPoco
    {
        [Column("user_id")]
        [ColumnDbType("int4", 0, false, "nextval('office.users_user_id_seq'::regclass)")]
        public int UserId { get; set; }

        [Column("role_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int RoleId { get; set; }

        [Column("department_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int DepartmentId { get; set; }

        [Column("office_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int OfficeId { get; set; }

        [Column("user_name")]
        [ColumnDbType("varchar", 50, false, "")]
        public string UserName { get; set; }

        [Column("full_name")]
        [ColumnDbType("varchar", 100, false, "")]
        public string FullName { get; set; }

        [Column("can_change_password")]
        [ColumnDbType("bool", 0, false, "true")]
        public bool CanChangePassword { get; set; }

        [Column("password")]
        [ColumnDbType("text", 0, false, "")]
        public string Password { get; set; }

        [Column("elevated")]
        [ColumnDbType("bool", 0, false, "false")]
        public bool Elevated { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }

        [Column("store_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? StoreId { get; set; }
    }
}