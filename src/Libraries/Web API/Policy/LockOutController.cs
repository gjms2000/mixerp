using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using MixERP.Net.EntityParser;
using Newtonsoft.Json;
using PetaPoco;

namespace MixERP.Net.Api.Policy
{
    /// <summary>
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Lock Outs.
    /// </summary>
    [RoutePrefix("api/v1.5/policy/lock-out")]
    public class LockOutController : ApiController
    {
        /// <summary>
        ///     The LockOut data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Policy.Data.LockOut LockOutContext;

        public LockOutController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.LockOutContext = new MixERP.Net.Schemas.Policy.Data.LockOut
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
        ///     Counts the number of lock outs.
        /// </summary>
        /// <returns>Returns the count of the lock outs.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/policy/lock-out/count")]
        public long Count()
        {
            try
            {
                return this.LockOutContext.Count();
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
        ///     Returns an instance of lock out.
        /// </summary>
        /// <param name="lockOutId">Enter LockOutId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{lockOutId}")]
        [Route("~/api/policy/lock-out/{lockOutId}")]
        public MixERP.Net.Entities.Policy.LockOut Get(long lockOutId)
        {
            try
            {
                return this.LockOutContext.Get(lockOutId);
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
        [Route("~/api/policy/lock-out/get")]
        public IEnumerable<MixERP.Net.Entities.Policy.LockOut> Get([FromUri] long[] lockOutIds)
        {
            try
            {
                return this.LockOutContext.Get(lockOutIds);
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
        ///     Creates a paginated collection containing 25 lock outs on each page, sorted by the property LockOutId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/policy/lock-out")]
        public IEnumerable<MixERP.Net.Entities.Policy.LockOut> GetPagedResult()
        {
            try
            {
                return this.LockOutContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 lock outs on each page, sorted by the property LockOutId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/policy/lock-out/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Policy.LockOut> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.LockOutContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 lock outs on each page, sorted by the property LockOutId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/policy/lock-out/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Policy.LockOut> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.LockOutContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of lock outs.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of lock outs.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/policy/lock-out/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.LockOutContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for lock outs.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of lock outs.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/policy/lock-out/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.LockOutContext.GetCustomFields(null);
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
        ///     A custom field is a user defined field for lock outs.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of lock outs.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/policy/lock-out/custom-fields/{resourceId}")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
        {
            try
            {
                return this.LockOutContext.GetCustomFields(resourceId);
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
        ///     Adds or edits your instance of LockOut class.
        /// </summary>
        /// <param name="lockOut">Your instance of lock outs class to add or edit.</param>
        [AcceptVerbs("PUT")]
        [Route("add-or-edit")]
        [Route("~/api/policy/lock-out/add-or-edit")]
        public void AddOrEdit([FromBody]MixERP.Net.Entities.Policy.LockOut lockOut)
        {
            if (lockOut == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.LockOutContext.AddOrEdit(lockOut);
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
        ///     Adds your instance of LockOut class.
        /// </summary>
        /// <param name="lockOut">Your instance of lock outs class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{lockOut}")]
        [Route("~/api/policy/lock-out/add/{lockOut}")]
        public void Add(MixERP.Net.Entities.Policy.LockOut lockOut)
        {
            if (lockOut == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.LockOutContext.Add(lockOut);
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
        ///     Edits existing record with your instance of LockOut class.
        /// </summary>
        /// <param name="lockOut">Your instance of LockOut class to edit.</param>
        /// <param name="lockOutId">Enter the value for LockOutId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{lockOutId}")]
        [Route("~/api/policy/lock-out/edit/{lockOutId}")]
        public void Edit(long lockOutId, [FromBody] MixERP.Net.Entities.Policy.LockOut lockOut)
        {
            if (lockOut == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.LockOutContext.Update(lockOut, lockOutId);
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
        ///     Deletes an existing instance of LockOut class via LockOutId.
        /// </summary>
        /// <param name="lockOutId">Enter the value for LockOutId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{lockOutId}")]
        [Route("~/api/policy/lock-out/delete/{lockOutId}")]
        public void Delete(long lockOutId)
        {
            try
            {
                this.LockOutContext.Delete(lockOutId);
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