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

namespace MixERP.Net.Entities.Localization
{
    [PrimaryKey("localized_resource_id", autoIncrement = true)]
    [TableName("localization.localized_resources")]
    [ExplicitColumns]
    public sealed class LocalizedResource : PetaPocoDB.Record<LocalizedResource>, IPoco
    {
        [Column("resource_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int ResourceId { get; set; }

        [Column("culture_code")]
        [ColumnDbType("text", 0, false, "")]
        public string CultureCode { get; set; }

        [Column("value")]
        [ColumnDbType("text", 0, false, "")]
        public string Value { get; set; }

        [Column("localized_resource_id")]
        [ColumnDbType("int8", 0, false, "nextval('localization.localized_resources_localized_resource_id_seq'::regclass)")]
        public long LocalizedResourceId { get; set; }
    }
}