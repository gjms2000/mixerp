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

using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using MixERP.Net.Entities.Core;
using MixERP.Net.Entities.Office;
using MixERP.Net.Entities.Transactions;
using PetaPoco;

namespace MixERP.Net.Core.Modules.Inventory.Data.Setup
{
    public static class PartyInfo
    {
        public static IEnumerable<PartySalesChartView> GetPartySalesChartView(string catalog, long partyId)
        {
            const string sql = @"SELECT
                                    ROW_NUMBER() OVER (ORDER BY value_date, transaction_master_id) AS row_number,
                                    transaction_master_id,
                                    party_id,
                                    book,
                                    value_date,
                                    amount
                                FROM transactions.party_sales_chart_view
                                WHERE party_id = @0;";

            return Factory.Get<PartySalesChartView>(catalog, sql, partyId);
        }
        
        public static IEnumerable<PartyPurchaseChartView> GetPartyPurchaseChartView(string catalog, long partyId)
        {
            const string sql = @"SELECT
                                    ROW_NUMBER() OVER (ORDER BY value_date, transaction_master_id) AS row_number,
                                    transaction_master_id,
                                    party_id,
                                    book,
                                    value_date,
                                    amount
                                FROM transactions.party_purchase_chart_view
                                WHERE party_id = @0;";

            return Factory.Get<PartyPurchaseChartView>(catalog, sql, partyId);
        }

        public static IEnumerable<PartyItemChartView> GetPartyItemChartView(string catalog, long partyId)
        {
            const string sql = @"SELECT *
                                FROM transactions.party_item_chart_view
                                WHERE party_id = @0;";

            return Factory.Get<PartyItemChartView>(catalog, sql, partyId);
        }

        public static IEnumerable<DbGetAccountStatementResult> GetAccountStatement(string catalog, long partyId, int officeId, int userId)
        {
            const string sql = @"SELECT * FROM transactions.get_account_statement
                                (
                                    core.get_fiscal_year_start_date(@0)::date, 
                                    core.get_fiscal_year_end_date(@0)::date, 
                                    @1::integer, 
                                    core.get_account_id_by_party_id(@2)::bigint, 
                                    @0::integer
                                );
                                ";

            return Factory.Get<DbGetAccountStatementResult>(catalog, sql, officeId, userId, partyId);
        }

        public static IEnumerable<ShippingAddressView> GetShippingAddressView(string catalog, long partyId)
        {
            const string sql = "SELECT * FROM core.shipping_address_view WHERE party_id=@0;";

            return Factory.Get<ShippingAddressView>(catalog, sql, partyId);
        }

        public static PartyView GetPartyView(string catalog, long partyId)
        {
            const string sql = "SELECT * FROM core.party_view WHERE party_id=@0;";
            return Factory.Get<PartyView>(catalog, sql, partyId).FirstOrDefault();
        }
    }
}