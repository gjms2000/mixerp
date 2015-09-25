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
    [TableName("core.fiscal_year_selector_view")]
    [ExplicitColumns]
    public sealed class FiscalYearSelectorView : PetaPocoDB.Record<FiscalYearSelectorView>, IPoco
    {
        [Column("fiscal_year_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string FiscalYearCode { get; set; }

        [Column("fiscal_year_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string FiscalYearName { get; set; }

        [Column("starts_from")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? StartsFrom { get; set; }

        [Column("ends_on")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? EndsOn { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}