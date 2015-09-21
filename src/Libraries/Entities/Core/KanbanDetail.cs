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
    [PrimaryKey("kanban_detail_id", autoIncrement = true)]
    [TableName("core.kanban_details")]
    [ExplicitColumns]
    public sealed class KanbanDetail : PetaPocoDB.Record<KanbanDetail>, IPoco
    {
        [Column("kanban_detail_id")]
        [ColumnDbType("int8", 0, false, "nextval('core.kanban_details_kanban_detail_id_seq'::regclass)")]
        public long KanbanDetailId { get; set; }

        [Column("kanban_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long KanbanId { get; set; }

        [Column("rating")]
        [ColumnDbType("int2", 0, true, "")]
        public short? Rating { get; set; }

        [Column("resource_id")]
        [ColumnDbType("varchar", 128, false, "")]
        public string ResourceId { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}