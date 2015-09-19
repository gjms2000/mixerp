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
    [TableName("core.payment_card_scrud_view")]
    [ExplicitColumns]
    public sealed class PaymentCardScrudView : PetaPocoDB.Record<PaymentCardScrudView>, IPoco
    {
        [Column("payment_card_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? PaymentCardId { get; set; }

        [Column("payment_card_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string PaymentCardCode { get; set; }

        [Column("payment_card_name")]
        [ColumnDbType("varchar", 100, true, "")]
        public string PaymentCardName { get; set; }

        [Column("card_type")]
        [ColumnDbType("text", 0, true, "")]
        public string CardType { get; set; }
    }
}