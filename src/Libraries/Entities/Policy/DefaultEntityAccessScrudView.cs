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
    [TableName("policy.default_entity_access_scrud_view")]
    [ExplicitColumns]
    public sealed class DefaultEntityAccessScrudView : PetaPocoDB.Record<DefaultEntityAccessScrudView>, IPoco
    {
        [Column("default_entity_access_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? DefaultEntityAccessId { get; set; }

        [Column("entity_name")]
        [ColumnDbType("varchar", 0, true, "")]
        public string EntityName { get; set; }

        [Column("role_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string RoleName { get; set; }

        [Column("access_type_name")]
        [ColumnDbType("varchar", 0, true, "")]
        public string AccessTypeName { get; set; }

        [Column("allow_access")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? AllowAccess { get; set; }
    }
}