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
using Codaxy.WkHtmlToPdf;
using MixERP.Net.Common;

namespace MixERP.Net.WebControls.ReportEngine.Helpers
{
    public static class DownloadHelper
    {
        public static string CreatePDF(string html)
        {
            string id = Guid.NewGuid().ToString();

            //public directory is allowed direct access
            string source = "~/Resource/Temp/Public/" + id + ".html";
            string destination = HostingEnvironment.MapPath("~/Resource/Temp/" + id + ".pdf");

            WriteHtml(source, html);
            ToPdf(source, destination);
            RemoveFile(source);

            return destination;
        }

        public static string CreateExcel(string html)
        {
            string id = Guid.NewGuid().ToString();

            //public directory is allowed direct access
            string source = "~/Resource/Temp/Public/" + id + ".xls";
            WriteHtml(source, html);
            return HostingEnvironment.MapPath(source);
        }

        public static void DownloadExcel(string html)
        {
            string path = CreateExcel(html);
            OpenDownload(path, "application/vnd.xls", "xls");
            File.Delete(path);
        }

        public static void DownloadWord(string html)
        {
            string path = CreateExcel(html);
            OpenDownload(path, "application/vnd.doc", "doc");
            File.Delete(path);
        }

        public static void DownloadPdf(string html)
        {
            if (HttpContext.Current == null)
            {
                return;
            }

            string path = CreatePDF(html);
            OpenDownload(path, "application/pdf", "pdf");
            File.Delete(path);
        }

        private static void OpenDownload(string path, string mimeType, string extension)
        {
            string fileName = Path.GetFileNameWithoutExtension(HttpContext.Current.Request.Url.AbsolutePath);

            FileInfo file = new FileInfo(path);

            if (!file.Exists)
            {
                return;
            }

            HttpResponse response = HttpContext.Current.Response;


            response.Clear();
            response.ClearHeaders();
            response.ClearContent();
            response.AddHeader("Content-Disposition", "attachment; filename=" + fileName + "." + extension);
            response.AddHeader("Content-Length", file.Length.ToString());
            response.ContentType = mimeType;
            response.Flush();
            response.TransmitFile(file.FullName);
            response.End();
        }

        private static void WriteHtml(string path, string html)
        {
            string file = HostingEnvironment.MapPath(path);

            if (file != null)
            {
                File.WriteAllText(file, html);
            }
        }

        private static void RemoveFile(string path)
        {
            string file = HostingEnvironment.MapPath(path);

            if (file != null)
            {
                File.Delete(file);
            }
        }

        public static void ToPdf(string source, string destination)
        {
            PdfConvert.Environment.WkHtmlToPdfPath = HostingEnvironment.MapPath("~/plugins/wkhtmltopdf/wkhtmltopdf.exe");
            PdfConvert.Environment.Timeout = 30000;

            PdfConvert.ConvertHtmlToPdf(new PdfDocument
            {
                Url = PageUtility.ResolveAbsoluteUrl(source)
            }, new PdfOutput
            {
                OutputFilePath = destination
            });
        }
    }
}