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
using System.Web.Hosting;
using System.Web.Script.Services;
using System.Web.Services;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Helpers;
using MixERP.Net.Core.Modules.Sales.Data.Helpers;
using MixERP.Net.Entities;
using MixERP.Net.i18n.Resources;
using MixERP.Net.Messaging.Email;

namespace MixERP.Net.Core.Modules.Sales.Services.Notification
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    [ScriptService]
    public class Delivery : WebService
    {
        [WebMethod]
        public void Send(long tranId)
        {
            if (tranId <= 0)
            {
                return;
            }

            this.CreateEmail(tranId);
        }

        private void CreateEmail(long tranId)
        {
            string sendTo = Parties.GetEmailAddress(AppUsers.GetCurrentUserDB(), TranBook.Sales, SubTranBook.Delivery,
                tranId);

            if (string.IsNullOrWhiteSpace(sendTo))
            {
                return;
            }

            string message = ProcessEmailMessage(tranId);
            string attachment =
                HostingEnvironment.MapPath("/Resource/Documents/" + Titles.SalesDelivery + "-#" + tranId + ".pdf");

            string subject = string.Format(Labels.SalesDeliveryEmailSubject, tranId,
                AppUsers.GetCurrent().View.OfficeName);

            MailQueueManager queue = new MailQueueManager(AppUsers.GetCurrentUserDB(), message, attachment, sendTo,
                subject);
            queue.Add();
        }

        private static string ProcessEmailMessage(long tranId)
        {
            string template = EmailTemplateHelper.GetTemplateFileContents("/Static/Templates/Email/Sales/Delivery.html");

            List<object> dictionary = new List<object>
            {
                AppUsers.GetCurrent().View,
                Data.Transactions.Delivery.GetSalesDeliveryView(AppUsers.GetCurrentUserDB(), tranId)
            };

            var processor = new EmailTemplateProcessor(template, dictionary);
            template = processor.Process();

            return template;
        }
    }
}