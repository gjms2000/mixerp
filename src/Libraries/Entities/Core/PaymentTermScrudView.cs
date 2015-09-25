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
    [TableName("core.payment_term_scrud_view")]
    [ExplicitColumns]
    public sealed class PaymentTermScrudView : PetaPocoDB.Record<PaymentTermScrudView>, IPoco
    {
        [Column("payment_term_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? PaymentTermId { get; set; }

        [Column("payment_term_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string PaymentTermCode { get; set; }

        [Column("payment_term_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string PaymentTermName { get; set; }

        [Column("due_on_date")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? DueOnDate { get; set; }

        [Column("due_days")]
        [ColumnDbType("int4", 0, true, "")]
        public int? DueDays { get; set; }

        [Column("due_frequency")]
        [ColumnDbType("text", 0, true, "")]
        public string DueFrequency { get; set; }

        [Column("grace_period")]
        [ColumnDbType("int4", 0, true, "")]
        public int? GracePeriod { get; set; }

        [Column("late_fee")]
        [ColumnDbType("text", 0, true, "")]
        public string LateFee { get; set; }

        [Column("late_fee_posting_frequency")]
        [ColumnDbType("text", 0, true, "")]
        public string LateFeePostingFrequency { get; set; }
    }
}