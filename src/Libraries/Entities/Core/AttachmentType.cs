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
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.attachment_type")]
    [ExplicitColumns]
    public sealed class AttachmentType : PetaPocoDB.Record<AttachmentType>, IPoco
    {
        [Column("comment")]
        [ColumnDbType("character varying", 0, false, "")]
        public string Comment { get; set; }

        [Column("file_path")]
        [ColumnDbType("text", 0, false, "")]
        public string FilePath { get; set; }

        [Column("original_file_name")]
        [ColumnDbType("text", 0, false, "")]
        public string OriginalFileName { get; set; }

        [Column("file_extension")]
        [ColumnDbType("text", 0, false, "")]
        public string FileExtension { get; set; }
    }
}