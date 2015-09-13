using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using MixERP.Net.EntityParser;
using Newtonsoft.Json;
using PetaPoco;

namespace MixERP.Net.Api.Core
{
    /// <summary>
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Attachments.
    /// </summary>
    [RoutePrefix("api/v1.5/core/attachment")]
    public class AttachmentController : ApiController
    {
        /// <summary>
        ///     The Attachment data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Core.Data.Attachment AttachmentContext;

        public AttachmentController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.AttachmentContext = new MixERP.Net.Schemas.Core.Data.Attachment
            {
                Catalog = this.Catalog,
                LoginId = this.LoginId
            };
        }

        public long LoginId { get; }
        public int UserId { get; private set; }
        public int OfficeId { get; private set; }
        public string Catalog { get; }

        /// <summary>
        ///     Counts the number of attachments.
        /// </summary>
        /// <returns>Returns the count of the attachments.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/core/attachment/count")]
        public long Count()
        {
            try
            {
                return this.AttachmentContext.Count();
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Returns an instance of attachment.
        /// </summary>
        /// <param name="attachmentId">Enter AttachmentId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{attachmentId}")]
        [Route("~/api/core/attachment/{attachmentId}")]
        public MixERP.Net.Entities.Core.Attachment Get(long attachmentId)
        {
            try
            {
                return this.AttachmentContext.Get(attachmentId);
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        [AcceptVerbs("GET", "HEAD")]
        [Route("get")]
        [Route("~/api/core/attachment/get")]
        public IEnumerable<MixERP.Net.Entities.Core.Attachment> Get([FromUri] long[] attachmentIds)
        {
            try
            {
                return this.AttachmentContext.Get(attachmentIds);
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Creates a paginated collection containing 25 attachments on each page, sorted by the property AttachmentId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/core/attachment")]
        public IEnumerable<MixERP.Net.Entities.Core.Attachment> GetPagedResult()
        {
            try
            {
                return this.AttachmentContext.GetPagedResult();
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Creates a paginated collection containing 25 attachments on each page, sorted by the property AttachmentId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/core/attachment/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.Attachment> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.AttachmentContext.GetPagedResult(pageNumber);
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Creates a filtered and paginated collection containing 25 attachments on each page, sorted by the property AttachmentId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/core/attachment/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.Attachment> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.AttachmentContext.GetWhere(pageNumber, f);
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Displayfield is a lightweight key/value collection of attachments.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of attachments.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/core/attachment/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.AttachmentContext.GetDisplayFields();
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     A custom field is a user defined field for attachments.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of attachments.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/attachment/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.AttachmentContext.GetCustomFields(null);
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     A custom field is a user defined field for attachments.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of attachments.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/attachment/custom-fields/{resourceId}")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
        {
            try
            {
                return this.AttachmentContext.GetCustomFields(resourceId);
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Adds or edits your instance of Attachment class.
        /// </summary>
        /// <param name="attachment">Your instance of attachments class to add or edit.</param>
        [AcceptVerbs("PUT")]
        [Route("add-or-edit")]
        [Route("~/api/core/attachment/add-or-edit")]
        public void AddOrEdit([FromBody]MixERP.Net.Entities.Core.Attachment attachment)
        {
            if (attachment == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.AttachmentContext.AddOrEdit(attachment);
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Adds your instance of Attachment class.
        /// </summary>
        /// <param name="attachment">Your instance of attachments class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{attachment}")]
        [Route("~/api/core/attachment/add/{attachment}")]
        public void Add(MixERP.Net.Entities.Core.Attachment attachment)
        {
            if (attachment == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.AttachmentContext.Add(attachment);
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Edits existing record with your instance of Attachment class.
        /// </summary>
        /// <param name="attachment">Your instance of Attachment class to edit.</param>
        /// <param name="attachmentId">Enter the value for AttachmentId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{attachmentId}")]
        [Route("~/api/core/attachment/edit/{attachmentId}")]
        public void Edit(long attachmentId, [FromBody] MixERP.Net.Entities.Core.Attachment attachment)
        {
            if (attachment == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.AttachmentContext.Update(attachment, attachmentId);
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Deletes an existing instance of Attachment class via AttachmentId.
        /// </summary>
        /// <param name="attachmentId">Enter the value for AttachmentId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{attachmentId}")]
        [Route("~/api/core/attachment/delete/{attachmentId}")]
        public void Delete(long attachmentId)
        {
            try
            {
                this.AttachmentContext.Delete(attachmentId);
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        [Route("document/{*path}")]
        [Route("document/{width:int}/{*path}")]
        [Route("document/{width:int}/{height:int}/{*path}")]
        [Route("~/api/core/attachment/document/{*path}")]
        [Route("~/api/core/attachment/document/{width:int}/{*path}")]
        [Route("~/api/core/attachment/document/{width:int}/{height:int}/{*path}")]
        [HttpGet]
        public HttpResponseMessage GetImage(string path, int width = 0, int height = 0)
        {
            bool isValid = !(string.IsNullOrWhiteSpace(path) || string.IsNullOrWhiteSpace(this.Catalog) || this.LoginId <= 0);

            if (!isValid)
            {
                return new HttpResponseMessage(HttpStatusCode.Forbidden);
            }

            path = "/Resource/Static/Attachments/" + path;

            if (System.IO.File.Exists(System.Web.Hosting.HostingEnvironment.MapPath(path)))
            {
                path = System.Web.Hosting.HostingEnvironment.MapPath(path);

                if (!MixERP.Net.Common.Helpers.ImageHelper.IsValidBitmap(path))
                {
                    path = System.Web.Hosting.HostingEnvironment.MapPath("/Static/images/document.png");
                }

                // ReSharper disable once AssignNullToNotNullAttribute
                System.IO.FileInfo file = new System.IO.FileInfo(path);

                // ReSharper disable once AssignNullToNotNullAttribute
                using (System.Drawing.Bitmap originalImage = new System.Drawing.Bitmap(path))
                {
                    byte[] buffer = MixERP.Net.Common.Helpers.ImageHelper.GetResizedImage(originalImage, width, height);
                    HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);

                    response.Content = new ByteArrayContent(buffer);
                    response.Content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("inline");
                    response.Content.Headers.ContentDisposition.FileName = file.Name;
                    response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(MixERP.Net.Common.Helpers.ImageHelper.GetContentType(file.Extension));

                    return response;
                }
            }

            return new HttpResponseMessage(HttpStatusCode.NotFound);
        }

        [Route("document/raw/{*path}")]
        [Route("~/api/core/attachment/document/raw/{*path}")]
        [HttpGet]
        public HttpResponseMessage GetRaw(string path)
        {
            bool isValid = !(string.IsNullOrWhiteSpace(path) || string.IsNullOrWhiteSpace(this.Catalog) || this.LoginId <= 0);

            if (!isValid)
            {
                return new HttpResponseMessage(HttpStatusCode.Forbidden);
            }

            path = "/Resource/Static/Attachments/" + path;

            if (System.IO.File.Exists(System.Web.Hosting.HostingEnvironment.MapPath(path)))
            {
                path = System.Web.Hosting.HostingEnvironment.MapPath(path);

                // ReSharper disable once AssignNullToNotNullAttribute
                System.IO.FileInfo file = new System.IO.FileInfo(path);

                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);

                response.Content = new StreamContent(new System.IO.FileStream(path, System.IO.FileMode.Open, System.IO.FileAccess.Read));
                response.Content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("inline");
                response.Content.Headers.ContentDisposition.FileName = file.Name;
                response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(MixERP.Net.Common.Helpers.ImageHelper.GetContentType(file.Extension));

                return response;
            }

            return new HttpResponseMessage(HttpStatusCode.NotFound);
        }
    }
}