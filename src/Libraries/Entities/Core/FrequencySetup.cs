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
    [PrimaryKey("frequency_setup_id", autoIncrement = true)]
    [TableName("core.frequency_setups")]
    [ExplicitColumns]
    public sealed class FrequencySetup : PetaPocoDB.Record<FrequencySetup>, IPoco
    {
        [Column("frequency_setup_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.frequency_setups_frequency_setup_id_seq'::regclass)")]
        public int FrequencySetupId { get; set; }

        [Column("fiscal_year_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string FiscalYearCode { get; set; }

        [Column("frequency_setup_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string FrequencySetupCode { get; set; }

        [Column("value_date")]
        [ColumnDbType("date", 0, false, "")]
        public DateTime ValueDate { get; set; }

        [Column("frequency_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int FrequencyId { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}