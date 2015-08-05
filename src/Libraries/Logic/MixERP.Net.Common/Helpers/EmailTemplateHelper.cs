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
using System.IO;
using System.Text;
using System.Web.Hosting;

namespace MixERP.Net.Common.Helpers
{
    public static class EmailTemplateHelper
    {
        public static string GetTemplateFileContents(string path)
        {
            string header = GetHeader();
            string footer = GetFooter();
            string template = GetLocalizedTemplateFile(path);

            return template.Replace("{Header}", header).Replace("{Footer}", footer);
        }

        public static string GetHeader()
        {
            return GetLocalizedTemplateFile("/Static/Templates/Email/EmailHeader.html");
        }

        public static string GetFooter()
        {
            return GetLocalizedTemplateFile("/Static/Templates/Email/EmailFooter.html");
        }

        private static string GetLocalizedTemplateFile(string path)
        {
            string template =
                HostingEnvironment.MapPath(path.Replace("html", "") +
                                           CultureInfo.DefaultThreadCurrentCulture.TwoLetterISOLanguageName
                                               .ToLowerInvariant() + ".html");

            if (!File.Exists(template))
            {
                template = HostingEnvironment.MapPath(path);
            }

            if (!File.Exists(template) || template == null)
            {
                return string.Empty;
            }

            return File.ReadAllText(template, Encoding.UTF8);
        }
    }
}