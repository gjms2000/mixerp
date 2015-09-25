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
    [PrimaryKey("exchange_rate_id", autoIncrement = true)]
    [TableName("core.exchange_rates")]
    [ExplicitColumns]
    public sealed class ExchangeRate : PetaPocoDB.Record<ExchangeRate>, IPoco
    {
        [Column("exchange_rate_id")]
        [ColumnDbType("int8", 0, false, "nextval('core.exchange_rates_exchange_rate_id_seq'::regclass)")]
        public long ExchangeRateId { get; set; }

        [Column("updated_on")]
        [ColumnDbType("timestamptz", 0, false, "")]
        public DateTime UpdatedOn { get; set; }

        [Column("office_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int OfficeId { get; set; }

        [Column("status")]
        [ColumnDbType("bool", 0, false, "true")]
        public bool Status { get; set; }
    }
}