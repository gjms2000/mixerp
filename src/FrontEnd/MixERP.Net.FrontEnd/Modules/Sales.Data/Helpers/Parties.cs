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

using MixERP.Net.Entities;
using PetaPoco;

namespace MixERP.Net.Core.Modules.Sales.Data.Helpers
{
    public static class Parties
    {
        public static string GetEmailAddress(string catalog, TranBook tranBook, SubTranBook subTranBook, long tranId)
        {
            string sql =
                "SELECT core.get_email_address_by_party_id(party_id) FROM transactions.non_gl_stock_master WHERE non_gl_stock_master_id=@0::bigint;";

            if (subTranBook == SubTranBook.Delivery || subTranBook == SubTranBook.Direct ||
                subTranBook == SubTranBook.Invoice || subTranBook == SubTranBook.Return)
            {
                sql =
                    "SELECT core.get_email_address_by_party_id(party_id) FROM transactions.stock_master WHERE transaction_master_id=@0::bigint;";
            }

            if (subTranBook == SubTranBook.Receipt)
            {
                sql =
                    "SELECT core.get_email_address_by_party_id(party_id) FROM transactions.customer_receipts WHERE transaction_master_id=@0::bigint;";
            }

            return Factory.Scalar<string>(catalog, sql, tranId);
        }

        public static string GetEmailAddress(string catalog, string partyCode)
        {
            const string sql = "SELECT email FROM core.parties WHERE party_code =@0";
            return Factory.Scalar<string>(catalog, sql, partyCode);
        }
    }
}