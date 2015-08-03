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

using System.Globalization;
using System.Text;
using System.Web;

namespace MixERP.Net.FrontEnd.Handlers
{
    public class StylesheetHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            string path = "/bundles/stylesheets/master-page.min.css";

            if (this.IsRtl())
            {
                path = path.Replace("min.css", "rtl.min.css");
            }


            context.Response.TransmitFile(path);
            context.Response.ContentEncoding = Encoding.UTF8;
            context.Response.ContentType = "text/css";
        }

        public bool IsReusable
        {
            get { return false; }
        }

        private bool IsRtl()
        {
            return CultureInfo.DefaultThreadCurrentCulture.TextInfo.IsRightToLeft;
        }
    }
}