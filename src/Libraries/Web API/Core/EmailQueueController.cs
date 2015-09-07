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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Email Queues.
    /// </summary>
    [RoutePrefix("api/v1.5/core/email-queue")]
    public class EmailQueueController : ApiController
    {
        /// <summary>
        ///     The EmailQueue data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Core.Data.EmailQueue EmailQueueContext;

        public EmailQueueController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.EmailQueueContext = new MixERP.Net.Schemas.Core.Data.EmailQueue
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
        ///     Counts the number of email queues.
        /// </summary>
        /// <returns>Returns the count of the email queues.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/core/email-queue/count")]
        public long Count()
        {
            try
            {
                return this.EmailQueueContext.Count();
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
        ///     Returns an instance of email queue.
        /// </summary>
        /// <param name="queueId">Enter QueueId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{queueId}")]
        [Route("~/api/core/email-queue/{queueId}")]
        public MixERP.Net.Entities.Core.EmailQueue Get(long queueId)
        {
            try
            {
                return this.EmailQueueContext.Get(queueId);
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
        ///     Creates a paginated collection containing 25 email queues on each page, sorted by the property QueueId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/core/email-queue")]
        public IEnumerable<MixERP.Net.Entities.Core.EmailQueue> GetPagedResult()
        {
            try
            {
                return this.EmailQueueContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 email queues on each page, sorted by the property QueueId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/core/email-queue/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.EmailQueue> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.EmailQueueContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 email queues on each page, sorted by the property QueueId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/core/email-queue/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.EmailQueue> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.EmailQueueContext.GetWhere(pageNumber, f);
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
        ///     Displayfields is a lightweight key/value collection of email queues.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of email queues.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/core/email-queue/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.EmailQueueContext.GetDisplayFields();
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
        /// <param name="emailQueue">Your instance of email queues class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{emailQueue}")]
        [Route("~/api/core/email-queue/add/{emailQueue}")]
        public void Add(MixERP.Net.Entities.Core.EmailQueue emailQueue)
        {
            if (emailQueue == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.EmailQueueContext.Add(emailQueue);
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
        /// <param name="emailQueue">Your instance of Account class to edit.</param>
        /// <param name="queueId">Enter the value for QueueId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{queueId}/{emailQueue}")]
        [Route("~/api/core/email-queue/edit/{queueId}/{emailQueue}")]
        public void Edit(long queueId, MixERP.Net.Entities.Core.EmailQueue emailQueue)
        {
            if (emailQueue == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.EmailQueueContext.Update(emailQueue, queueId);
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
        ///     Deletes an existing instance of Account class via QueueId.
        /// </summary>
        /// <param name="queueId">Enter the value for QueueId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{queueId}")]
        [Route("~/api/core/email-queue/delete/{queueId}")]
        public void Delete(long queueId)
        {
            try
            {
                this.EmailQueueContext.Delete(queueId);
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