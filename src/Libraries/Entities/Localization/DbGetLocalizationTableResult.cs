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
    [PrimaryKey("", autoIncrement = false)]
    [FunctionName("localization.get_localization_table")]
    [ExplicitColumns]
    public sealed class DbGetLocalizationTableResult : PetaPocoDB.Record<DbGetLocalizationTableResult>, IPoco
    {
        [Column("id")]
        [ColumnDbType("bigint", 0, false, "")]
        public long Id { get; set; }

        [Column("resource_class")]
        [ColumnDbType("text", 0, false, "")]
        public string ResourceClass { get; set; }

        [Column("key")]
        [ColumnDbType("text", 0, false, "")]
        public string Key { get; set; }

        [Column("original")]
        [ColumnDbType("text", 0, false, "")]
        public string Original { get; set; }

        [Column("translated")]
        [ColumnDbType("text", 0, false, "")]
        public string Translated { get; set; }
    }
}