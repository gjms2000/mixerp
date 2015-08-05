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
using System.IO;
using System.Web;
using System.Web.Hosting;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Helpers;

namespace MixERP.Net.FrontEnd.Handlers
{
    public class LogoHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            string path = this.GetPath();

            context.Response.ContentType = MimeMapping.GetMimeMapping(path);
            context.Response.Cache.SetCacheability(HttpCacheability.Public);
            context.Response.Cache.SetExpires(DateTime.Now.AddDays(1));
            context.Response.Cache.SetMaxAge(new TimeSpan(24, 0, 0));
            context.Response.TransmitFile(path);
        }

        public bool IsReusable
        {
            get { return false; }
        }

        private string GetPath()
        {
            string logo = "/Static/images/mixerp-logo-light.png";

            string officeLogoFile = AppUsers.GetCurrent().View.LogoFile;

            if (!string.IsNullOrWhiteSpace(officeLogoFile))
            {
                string attachmentsDirectory = DbConfig.GetAttachmentParameter(AppUsers.GetCurrentUserDB(),
                    "AttachmentsDirectory");

                officeLogoFile = Path.Combine(attachmentsDirectory, officeLogoFile);

                if (File.Exists(HostingEnvironment.MapPath(officeLogoFile)))
                {
                    logo = officeLogoFile;
                }
            }

            return logo;
        }
    }
}