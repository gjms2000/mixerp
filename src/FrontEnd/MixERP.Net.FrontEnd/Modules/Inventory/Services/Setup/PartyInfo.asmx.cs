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
using System.ComponentModel;
using System.Linq;
using System.Web.Script.Services;
using System.Web.Services;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using MixERP.Net.Entities.Core;
using MixERP.Net.Entities.Transactions;

namespace MixERP.Net.Core.Modules.Inventory.Services.Setup
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    [ScriptService]
    public class PartyInfo : WebService
    {
        [WebMethod]
        public List<PartySalesChartView> GetSalesChartView(long partyId)
        {
            string catalog = AppUsers.GetCurrentUserDB();

            if (partyId <= 0)
            {
                return null;
            }

            return Data.Setup.PartyInfo.GetPartySalesChartView(catalog, partyId).ToList();
        }

        [WebMethod]
        public List<PartyPurchaseChartView> GetPurchaseChartView(long partyId)
        {
            string catalog = AppUsers.GetCurrentUserDB();

            if (partyId <= 0)
            {
                return null;
            }

            return Data.Setup.PartyInfo.GetPartyPurchaseChartView(catalog, partyId).ToList();
        }

        [WebMethod]
        public List<PartyItemChartView> GetPartyItemChartView(long partyId)
        {
            string catalog = AppUsers.GetCurrentUserDB();

            if (partyId <= 0)
            {
                return null;
            }

            return Data.Setup.PartyInfo.GetPartyItemChartView(catalog, partyId).ToList();
        }

        [WebMethod]
        public List<DbGetAccountStatementResult> GetAccountStatement(long partyId)
        {
            string catalog = AppUsers.GetCurrentUserDB();
            int officeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            int userId = AppUsers.GetCurrent().View.UserId.ToInt();

            if (partyId <= 0)
            {
                return null;
            }

            return Data.Setup.PartyInfo.GetAccountStatement(catalog, partyId, officeId, userId).ToList();
        }

        [WebMethod]
        public List<ShippingAddressView> GetShippingAddressView(long partyId)
        {
            string catalog = AppUsers.GetCurrentUserDB();

            if (partyId <= 0)
            {
                return null;
            }

            return Data.Setup.PartyInfo.GetShippingAddressView(catalog, partyId).ToList();
        }

        [WebMethod]
        public PartyView GetPartyView(long partyId)
        {
            string catalog = AppUsers.GetCurrentUserDB();

            if (partyId <= 0)
            {
                return null;
            }

            return Data.Setup.PartyInfo.GetPartyView(catalog, partyId);
        }
    }
}