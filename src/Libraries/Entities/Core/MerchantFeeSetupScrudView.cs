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
    [TableName("core.merchant_fee_setup_scrud_view")]
    [ExplicitColumns]
    public sealed class MerchantFeeSetupScrudView : PetaPocoDB.Record<MerchantFeeSetupScrudView>, IPoco
    {
        [Column("merchant_fee_setup_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? MerchantFeeSetupId { get; set; }

        [Column("merchant_account")]
        [ColumnDbType("text", 0, true, "")]
        public string MerchantAccount { get; set; }

        [Column("payment_card")]
        [ColumnDbType("text", 0, true, "")]
        public string PaymentCard { get; set; }

        [Column("rate")]
        [ColumnDbType("decimal_strict", 0, true, "")]
        public decimal? Rate { get; set; }

        [Column("customer_pays_fee")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? CustomerPaysFee { get; set; }

        [Column("account")]
        [ColumnDbType("text", 0, true, "")]
        public string Account { get; set; }

        [Column("statement_reference")]
        [ColumnDbType("varchar", 128, true, "")]
        public string StatementReference { get; set; }
    }
}