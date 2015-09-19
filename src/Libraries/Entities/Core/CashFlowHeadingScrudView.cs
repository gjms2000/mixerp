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
    [TableName("core.cash_flow_heading_scrud_view")]
    [ExplicitColumns]
    public sealed class CashFlowHeadingScrudView : PetaPocoDB.Record<CashFlowHeadingScrudView>, IPoco
    {
        [Column("cash_flow_heading_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? CashFlowHeadingId { get; set; }

        [Column("cash_flow_heading_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string CashFlowHeadingCode { get; set; }

        [Column("cash_flow_heading_name")]
        [ColumnDbType("varchar", 100, true, "")]
        public string CashFlowHeadingName { get; set; }

        [Column("cash_flow_heading_type")]
        [ColumnDbType("bpchar", 1, true, "")]
        public string CashFlowHeadingType { get; set; }

        [Column("is_debit")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? IsDebit { get; set; }

        [Column("is_sales")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? IsSales { get; set; }

        [Column("is_purchase")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? IsPurchase { get; set; }
    }
}