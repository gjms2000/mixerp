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

using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Web.Script.Services;
using System.Web.Services;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common;
using MixERP.Net.Common.Extensions;
using MixERP.Net.Core.Modules.Sales.Data.Helpers;
using MixERP.Net.Entities.Core;
using MixERP.Net.Entities.Transactions.Models;
using MixERP.Net.i18n;
using MixERP.Net.i18n.Resources;
using MixERP.Net.TransactionGovernor.Verification;
using MixERP.Net.WebControls.StockTransactionFactory.Helpers;
using Serilog;

namespace MixERP.Net.Core.Modules.Sales.Services.Entry
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    [ScriptService]
    public class Delivery : WebService
    {
        [WebMethod]
        public long Save(DateTime valueDate, int storeId, string partyCode, int priceTypeId, int paymentTermId,
            string referenceNumber, string data, string statementReference, int salespersonId, int shipperId,
            string shippingAddressCode, decimal shippingCharge, int costCenterId, string transactionIds,
            string attachmentsJSON, bool nonTaxable)
        {
            try
            {
                Collection<StockDetail> details = CollectionHelper.GetStockMasterDetailCollection(data, storeId);
                Collection<long> tranIds = new Collection<long>();

                Collection<Attachment> attachments = CollectionHelper.GetAttachmentCollection(attachmentsJSON);

                if (!Stores.IsSalesAllowed(AppUsers.GetCurrentUserDB(), storeId))
                {
                    throw new InvalidOperationException("Sales is not allowed here.");
                }

                foreach (StockDetail model in details)
                {
                    if (Items.IsStockItem(AppUsers.GetCurrentUserDB(), model.ItemCode))
                    {
                        decimal available = Items.CountItemInStock(AppUsers.GetCurrentUserDB(),
                            model.ItemCode, model.UnitName, model.StoreId);

                        if (available < model.Quantity)
                        {
                            throw new InvalidOperationException(string.Format(CultureManager.GetCurrent(),
                                Warnings.InsufficientStockWarning, available, model.UnitName, model.ItemCode));
                        }
                    }
                }

                if (!string.IsNullOrWhiteSpace(transactionIds))
                {
                    foreach (string transactionId in transactionIds.Split(','))
                    {
                        tranIds.Add(Conversion.TryCastLong(transactionId));
                    }
                }

                int officeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
                int userId = AppUsers.GetCurrent().View.UserId.ToInt();
                long loginId = AppUsers.GetCurrent().View.LoginId.ToLong();

                long tranId = Data.Transactions.Delivery.Add(AppUsers.GetCurrentUserDB(), officeId, userId, loginId,
                    valueDate,
                    storeId, partyCode, priceTypeId, paymentTermId, details, shipperId, shippingAddressCode,
                    shippingCharge, costCenterId, referenceNumber, salespersonId, statementReference, tranIds,
                    attachments, nonTaxable);


                VerificationModel status =
                    Status.GetVerificationStatus(
                        AppUsers.GetCurrentUserDB(), tranId, false);


                if (status.VerificationStatusId > 0)
                {
                    Notification.Delivery notification = new Notification.Delivery();
                    notification.Send(tranId);
                }

                return tranId;
            }
            catch (Exception ex)
            {
                Log.Warning("Could not save sales delivery entry. {Exception}", ex);
                throw;
            }
        }
    }
}