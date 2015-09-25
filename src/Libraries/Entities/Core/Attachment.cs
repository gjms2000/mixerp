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
    [PrimaryKey("attachment_id", autoIncrement = true)]
    [TableName("core.attachments")]
    [ExplicitColumns]
    public sealed class Attachment : PetaPocoDB.Record<Attachment>, IPoco
    {
        [Column("attachment_id")]
        [ColumnDbType("int8", 0, false, "nextval('core.attachments_attachment_id_seq'::regclass)")]
        public long AttachmentId { get; set; }

        [Column("user_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int UserId { get; set; }

        [Column("resource")]
        [ColumnDbType("text", 0, false, "")]
        public string Resource { get; set; }

        [Column("resource_key")]
        [ColumnDbType("text", 0, false, "")]
        public string ResourceKey { get; set; }

        [Column("resource_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long ResourceId { get; set; }

        [Column("original_file_name")]
        [ColumnDbType("text", 0, false, "")]
        public string OriginalFileName { get; set; }

        [Column("file_extension")]
        [ColumnDbType("varchar", 12, false, "")]
        public string FileExtension { get; set; }

        [Column("file_path")]
        [ColumnDbType("text", 0, false, "")]
        public string FilePath { get; set; }

        [Column("comment")]
        [ColumnDbType("varchar", 96, false, "")]
        public string Comment { get; set; }

        [Column("added_on")]
        [ColumnDbType("timestamptz", 0, false, "")]
        public DateTime AddedOn { get; set; }
    }
}