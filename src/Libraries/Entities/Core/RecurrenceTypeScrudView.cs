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
    [TableName("core.recurrence_type_scrud_view")]
    [ExplicitColumns]
    public sealed class RecurrenceTypeScrudView : PetaPocoDB.Record<RecurrenceTypeScrudView>, IPoco
    {
        [Column("recurrence_type_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? RecurrenceTypeId { get; set; }

        [Column("recurrence_type_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string RecurrenceTypeCode { get; set; }

        [Column("recurrence_type_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string RecurrenceTypeName { get; set; }

        [Column("is_frequency")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? IsFrequency { get; set; }
    }
}