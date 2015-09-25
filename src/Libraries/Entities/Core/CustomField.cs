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
    [PrimaryKey("custom_field_id", autoIncrement = true)]
    [TableName("core.custom_fields")]
    [ExplicitColumns]
    public sealed class CustomField : PetaPocoDB.Record<CustomField>, IPoco
    {
        [Column("custom_field_id")]
        [ColumnDbType("int8", 0, false, "nextval('core.custom_fields_custom_field_id_seq'::regclass)")]
        public long CustomFieldId { get; set; }

        [Column("custom_field_setup_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int CustomFieldSetupId { get; set; }

        [Column("resource_id")]
        [ColumnDbType("text", 0, false, "")]
        public string ResourceId { get; set; }

        [Column("value")]
        [ColumnDbType("text", 0, true, "")]
        public string Value { get; set; }
    }
}