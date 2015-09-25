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
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.period")]
    [ExplicitColumns]
    public sealed class Period : PetaPocoDB.Record<Period>, IPoco
    {
        [Column("period_name")]
        [ColumnDbType("text", 0, false, "")]
        public string PeriodName { get; set; }

        [Column("date_from")]
        [ColumnDbType("date", 0, false, "")]
        public DateTime DateFrom { get; set; }

        [Column("date_to")]
        [ColumnDbType("date", 0, false, "")]
        public DateTime DateTo { get; set; }
    }
}