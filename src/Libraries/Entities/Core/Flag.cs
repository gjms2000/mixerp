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
    [PrimaryKey("flag_id", autoIncrement = true)]
    [TableName("core.flags")]
    [ExplicitColumns]
    public sealed class Flag : PetaPocoDB.Record<Flag>, IPoco
    {
        [Column("flag_id")]
        [ColumnDbType("int8", 0, false, "nextval('core.flags_flag_id_seq'::regclass)")]
        public long FlagId { get; set; }

        [Column("user_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int UserId { get; set; }

        [Column("flag_type_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int FlagTypeId { get; set; }

        [Column("resource")]
        [ColumnDbType("text", 0, true, "")]
        public string Resource { get; set; }

        [Column("resource_key")]
        [ColumnDbType("text", 0, true, "")]
        public string ResourceKey { get; set; }

        [Column("resource_id")]
        [ColumnDbType("text", 0, true, "")]
        public string ResourceId { get; set; }

        [Column("flagged_on")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? FlaggedOn { get; set; }
    }
}