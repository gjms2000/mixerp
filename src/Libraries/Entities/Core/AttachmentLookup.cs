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

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("attachment_lookup_id", autoIncrement = true)]
    [TableName("core.attachment_lookup")]
    [ExplicitColumns]
    public sealed class AttachmentLookup : PetaPocoDB.Record<AttachmentLookup>, IPoco
    {
        [Column("attachment_lookup_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.attachment_lookup_attachment_lookup_id_seq'::regclass)")]
        public int AttachmentLookupId { get; set; }

        [Column("book")]
        [ColumnDbType("varchar", 50, false, "")]
        public string Book { get; set; }

        [Column("resource")]
        [ColumnDbType("text", 0, false, "")]
        public string Resource { get; set; }

        [Column("resource_key")]
        [ColumnDbType("text", 0, false, "")]
        public string ResourceKey { get; set; }
    }
}