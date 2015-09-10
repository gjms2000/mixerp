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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Attachment Lookups.
    /// </summary>
    [RoutePrefix("api/v1.5/core/attachment-lookup")]
    public class AttachmentLookupController : ApiController
    {
        /// <summary>
        ///     The AttachmentLookup data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Core.Data.AttachmentLookup AttachmentLookupContext;

        public AttachmentLookupController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.AttachmentLookupContext = new MixERP.Net.Schemas.Core.Data.AttachmentLookup
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
        ///     Counts the number of attachment lookups.
        /// </summary>
        /// <returns>Returns the count of the attachment lookups.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/core/attachment-lookup/count")]
        public long Count()
        {
            try
            {
                return this.AttachmentLookupContext.Count();
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
        ///     Returns an instance of attachment lookup.
        /// </summary>
        /// <param name="attachmentLookupId">Enter AttachmentLookupId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{attachmentLookupId}")]
        [Route("~/api/core/attachment-lookup/{attachmentLookupId}")]
        public MixERP.Net.Entities.Core.AttachmentLookup Get(int attachmentLookupId)
        {
            try
            {
                return this.AttachmentLookupContext.Get(attachmentLookupId);
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
        ///     Creates a paginated collection containing 25 attachment lookups on each page, sorted by the property AttachmentLookupId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/core/attachment-lookup")]
        public IEnumerable<MixERP.Net.Entities.Core.AttachmentLookup> GetPagedResult()
        {
            try
            {
                return this.AttachmentLookupContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 attachment lookups on each page, sorted by the property AttachmentLookupId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/core/attachment-lookup/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.AttachmentLookup> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.AttachmentLookupContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 attachment lookups on each page, sorted by the property AttachmentLookupId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/core/attachment-lookup/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.AttachmentLookup> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.AttachmentLookupContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of attachment lookups.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of attachment lookups.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/core/attachment-lookup/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.AttachmentLookupContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for attachment lookups.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of attachment lookups.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/attachment-lookup/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.AttachmentLookupContext.GetCustomFields();
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
        ///     Adds your instance of Account class.
        /// </summary>
        /// <param name="attachmentLookup">Your instance of attachment lookups class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{attachmentLookup}")]
        [Route("~/api/core/attachment-lookup/add/{attachmentLookup}")]
        public void Add(MixERP.Net.Entities.Core.AttachmentLookup attachmentLookup)
        {
            if (attachmentLookup == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.AttachmentLookupContext.Add(attachmentLookup);
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
        ///     Edits existing record with your instance of Account class.
        /// </summary>
        /// <param name="attachmentLookup">Your instance of Account class to edit.</param>
        /// <param name="attachmentLookupId">Enter the value for AttachmentLookupId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{attachmentLookupId}/{attachmentLookup}")]
        [Route("~/api/core/attachment-lookup/edit/{attachmentLookupId}/{attachmentLookup}")]
        public void Edit(int attachmentLookupId, MixERP.Net.Entities.Core.AttachmentLookup attachmentLookup)
        {
            if (attachmentLookup == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.AttachmentLookupContext.Update(attachmentLookup, attachmentLookupId);
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
        ///     Deletes an existing instance of Account class via AttachmentLookupId.
        /// </summary>
        /// <param name="attachmentLookupId">Enter the value for AttachmentLookupId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{attachmentLookupId}")]
        [Route("~/api/core/attachment-lookup/delete/{attachmentLookupId}")]
        public void Delete(int attachmentLookupId)
        {
            try
            {
                this.AttachmentLookupContext.Delete(attachmentLookupId);
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


    }
}