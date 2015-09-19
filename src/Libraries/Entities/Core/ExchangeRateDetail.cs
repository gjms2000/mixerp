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
    [PrimaryKey("exchange_rate_detail_id", autoIncrement = true)]
    [TableName("core.exchange_rate_details")]
    [ExplicitColumns]
    public sealed class ExchangeRateDetail : PetaPocoDB.Record<ExchangeRateDetail>, IPoco
    {
        [Column("exchange_rate_detail_id")]
        [ColumnDbType("int8", 0, false, "nextval('core.exchange_rate_details_exchange_rate_detail_id_seq'::regclass)")]
        public long ExchangeRateDetailId { get; set; }

        [Column("exchange_rate_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long ExchangeRateId { get; set; }

        [Column("local_currency_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string LocalCurrencyCode { get; set; }

        [Column("foreign_currency_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string ForeignCurrencyCode { get; set; }

        [Column("unit")]
        [ColumnDbType("integer_strict", 0, false, "")]
        public int Unit { get; set; }

        [Column("exchange_rate")]
        [ColumnDbType("decimal_strict", 0, false, "")]
        public decimal ExchangeRate { get; set; }
    }
}