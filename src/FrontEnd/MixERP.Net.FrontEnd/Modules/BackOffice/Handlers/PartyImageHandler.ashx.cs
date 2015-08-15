using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using MixERP.Net.Common;
using MixERP.Net.Common.Helpers;

namespace MixERP.Net.Core.Modules.BackOffice.Handlers
{
    /// <summary>
    /// Summary description for PartyImageHandler
    /// </summary>
    public class PartyImageHandler : IHttpHandler
    {
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        public void ProcessRequest(HttpContext context)
        {
            ProcessImage(context);
        }

        private static void ProcessImage(HttpContext context)
        {
            string path = string.Empty;
            int width = 0;
            int height = 0;

            if (!string.IsNullOrWhiteSpace(context.Request.QueryString["Path"]))
            {
                path = HostingEnvironment.MapPath("/Resource/Static/Attachments/" + Conversion.TryCastString(context.Request.QueryString["Path"]));
            }

            if (!string.IsNullOrWhiteSpace(context.Request.QueryString["W"]))
            {
                width = Convert.ToInt32(context.Request.QueryString["W"], CultureInfo.InvariantCulture);
            }

            if (!string.IsNullOrWhiteSpace(context.Request.QueryString["H"]))
            {
                height = Convert.ToInt32(context.Request.QueryString["H"], CultureInfo.InvariantCulture);
            }

            context.Response.Clear();

            if (!System.IO.File.Exists(path))
            {
                path = HostingEnvironment.MapPath("/Static/Images/not-found.png");
            }

            System.IO.FileInfo file = new System.IO.FileInfo(path);

            if (!IsValidBitmap(path))
            {
                path = context.Server.MapPath("~/Static/images/document.png");
            }

            using (Bitmap originalImage = new Bitmap(path))
            {
                byte[] buffer = ImageHelper.GetResizedImage(originalImage, width, height);

                context.Response.ContentType = ImageHelper.GetContentType(file.Extension);
                context.Response.Cache.SetCacheability(HttpCacheability.Public);
                context.Response.Cache.SetExpires(DateTime.Now.AddMonths(1));
                context.Response.Cache.SetMaxAge(new TimeSpan(30, 0, 0, 0, 0));
                context.Response.AddHeader("Last-Modified", DateTime.Now.ToShortDateString());

                context.Response.OutputStream.Write(buffer, 0, buffer.Length);
                context.Response.End();
            }

        }

        private static bool IsValidBitmap(string path)
        {
            try
            {
                using (new Bitmap(path))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

    }
}