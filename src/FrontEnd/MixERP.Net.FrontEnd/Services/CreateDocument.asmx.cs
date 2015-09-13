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

using System.ComponentModel;
using System.IO;
using System.Web;
using System.Web.Hosting;
using System.Web.Script.Services;
using System.Web.Services;
using MixERP.Net.Common.Helpers;
using MixERP.Net.FrontEnd.Base;

namespace MixERP.Net.FrontEnd.Services
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    [ScriptService]
    public class CreateDocument : MixERPWebService
    {
       private readonly string basePath = HostingEnvironment.MapPath("/");

        [WebMethod]
        public string CreatePdf(string html, string documentName)
        {
            if (!this.IsValid(html, documentName))
            {
                return string.Empty;
            }

            string destination = HostingEnvironment.MapPath("/Resource/Documents/" + documentName);

            if (File.Exists(destination))
            {
                File.Delete(destination);
            }

             ExportHelper.CreatePDF(html, destination);

            return "/" + destination.Replace(this.basePath, string.Empty).Replace(@"\", "/");
        }

        private bool IsValid(string html, string documentName)
        {
            if (!this.Context.User.Identity.IsAuthenticated)
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(html) || string.IsNullOrWhiteSpace(documentName))
            {
                return false;
            }

            return true;
        }

        [WebMethod]
        public string CreateDoc(string html, string documentName)
        {
            if (!this.IsValid(html, documentName))
            {
                return string.Empty;
            }

            string destination = ExportHelper.CreateWord(html, documentName);
            return "/" + destination.Replace(this.basePath, string.Empty).Replace(@"\", "/");
        }

        [WebMethod]
        public string CreateXls(string html, string documentName)
        {
            if (!this.IsValid(html, documentName))
            {
                return string.Empty;
            }

            string destination = ExportHelper.CreateExcel(html, documentName);
            return "/" + destination.Replace(this.basePath, string.Empty).Replace(@"\", "/");
        }

    }
}