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

using MixERP.Net.Common;
using MixERP.Net.Common.Helpers;
using System;
using System.Linq;
using System.Net.Mail;
using System.Security;
using System.Web.Hosting;
using PetaPoco;

namespace MixERP.Net.Messaging.Email.Helpers
{
    internal class Config
    {
        public Config(string catalog)
        {
            var smtp = this.GetSmtpConfig(catalog);

            this.Catalog = catalog;
            this.Enabled = smtp.Enabled;
            this.FromName = smtp.FromDisplayName;
            this.FromEmail = smtp.FromEmailAddress;
            this.SmtpHost = smtp.SmpHost;
            this.EnableSsl = smtp.SmtpEnableSsl;
            this.SmtpPort = smtp.SmtpPort;
            this.SmtpUsername = smtp.SmtpUsername;
            this.SmtpUserPassword = GetSmtpUserPassword(smtp.SmtpPassword);
            this.DeliveryMethod = SmtpDeliveryMethod.Network;
        }

        private Entities.Config.Smtp GetSmtpConfig(string catalog)
        {
            const string sql = "SELECT * FROM config.smtp WHERE enabled AND is_default LIMIT 1;";
            return Factory.Get<Entities.Config.Smtp>(catalog, sql).FirstOrDefault();
        }

        public string Catalog { get; set; }
        public bool Enabled { get; set; }
        public bool EnableSsl { get; set; }
        public string FromName { get; set; }
        public string FromEmail { get; set; }
        public SmtpDeliveryMethod DeliveryMethod { get; set; }
        public string SmtpHost { get; set; }
        public int SmtpPort { get; set; }
        public string SmtpUsername { get; set; }
        public SecureString SmtpUserPassword { get; set; }
        public string PickupDirectory { get; set; }

        private SecureString GetSmtpUserPassword(string password)
        {
            SecureString secureString = new SecureString();
            foreach (char c in password)
            {
                secureString.AppendChar(c);
            }

            return secureString;
        }
    }
}