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

using System.Threading;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Helpers;
using MixERP.Net.i18n.Resources;
using MixERP.Net.Messaging.Email;

namespace MixERP.Net.WebControls.TransactionChecklist.Helpers
{
    internal sealed class EmailHelper
    {
        public EmailHelper(string catalog, string html, string subject, string recipient, string attachmentFileName)
        {
            this.Catalog = catalog;
            this.EmailBody = string.Format(Labels.EmailBody, AppUsers.GetCurrent().View.OfficeName);
            this.Html = html;
            this.Subject = subject;
            this.Recipient = recipient;
            this.AttachmentFileName = attachmentFileName;
        }

        public string Catalog { get; set; }
        internal string EmailBody { get; set; }
        internal string Html { get; set; }
        internal string Recipient { get; set; }
        internal string Subject { get; set; }
        internal string AttachmentFileName { get; set; }

        internal void SendEmail()
        {
            ExportHelper.CreatePDF(this.Html, this.AttachmentFileName);

            
            ThreadPool.QueueUserWorkItem(async callback =>
            {
                Processor processor = new Processor(this.Catalog);
                await processor.Send(this.Recipient, this.Subject, this.EmailBody, true, this.AttachmentFileName);
            });

        }
    }
}