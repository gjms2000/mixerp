using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using MixERP.Net.EntityParser;
using Newtonsoft.Json;
using PetaPoco;

namespace MixERP.Net.Api.Audit
{
    /// <summary>
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Failed Logins.
    /// </summary>
    [RoutePrefix("api/v1.5/audit/failed-login")]
    public class FailedLoginController : ApiController
    {
        /// <summary>
        ///     The FailedLogin data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Audit.Data.FailedLogin FailedLoginContext;

        public FailedLoginController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.FailedLoginContext = new MixERP.Net.Schemas.Audit.Data.FailedLogin
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
        ///     Counts the number of failed logins.
        /// </summary>
        /// <returns>Returns the count of the failed logins.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/audit/failed-login/count")]
        public long Count()
        {
            try
            {
                return this.FailedLoginContext.Count();
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
        ///     Returns an instance of failed login.
        /// </summary>
        /// <param name="failedLoginId">Enter FailedLoginId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{failedLoginId}")]
        [Route("~/api/audit/failed-login/{failedLoginId}")]
        public MixERP.Net.Entities.Audit.FailedLogin Get(long failedLoginId)
        {
            try
            {
                return this.FailedLoginContext.Get(failedLoginId);
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
        [Route("~/api/audit/failed-login/get")]
        public IEnumerable<MixERP.Net.Entities.Audit.FailedLogin> Get([FromUri] long[] failedLoginIds)
        {
            try
            {
                return this.FailedLoginContext.Get(failedLoginIds);
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
        ///     Creates a paginated collection containing 25 failed logins on each page, sorted by the property FailedLoginId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/audit/failed-login")]
        public IEnumerable<MixERP.Net.Entities.Audit.FailedLogin> GetPagedResult()
        {
            try
            {
                return this.FailedLoginContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 failed logins on each page, sorted by the property FailedLoginId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/audit/failed-login/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Audit.FailedLogin> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.FailedLoginContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 failed logins on each page, sorted by the property FailedLoginId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/audit/failed-login/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Audit.FailedLogin> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.FailedLoginContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of failed logins.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of failed logins.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/audit/failed-login/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.FailedLoginContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for failed logins.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of failed logins.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/audit/failed-login/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.FailedLoginContext.GetCustomFields(null);
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
        ///     A custom field is a user defined field for failed logins.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of failed logins.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/audit/failed-login/custom-fields/{resourceId}")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
        {
            try
            {
                return this.FailedLoginContext.GetCustomFields(resourceId);
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
        ///     Adds or edits your instance of FailedLogin class.
        /// </summary>
        /// <param name="failedLogin">Your instance of failed logins class to add or edit.</param>
        [AcceptVerbs("PUT")]
        [Route("add-or-edit")]
        [Route("~/api/audit/failed-login/add-or-edit")]
        public void AddOrEdit([FromBody]MixERP.Net.Entities.Audit.FailedLogin failedLogin)
        {
            if (failedLogin == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.FailedLoginContext.AddOrEdit(failedLogin);
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
        ///     Adds your instance of FailedLogin class.
        /// </summary>
        /// <param name="failedLogin">Your instance of failed logins class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{failedLogin}")]
        [Route("~/api/audit/failed-login/add/{failedLogin}")]
        public void Add(MixERP.Net.Entities.Audit.FailedLogin failedLogin)
        {
            if (failedLogin == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.FailedLoginContext.Add(failedLogin);
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
        ///     Edits existing record with your instance of FailedLogin class.
        /// </summary>
        /// <param name="failedLogin">Your instance of FailedLogin class to edit.</param>
        /// <param name="failedLoginId">Enter the value for FailedLoginId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{failedLoginId}")]
        [Route("~/api/audit/failed-login/edit/{failedLoginId}")]
        public void Edit(long failedLoginId, [FromBody] MixERP.Net.Entities.Audit.FailedLogin failedLogin)
        {
            if (failedLogin == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.FailedLoginContext.Update(failedLogin, failedLoginId);
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
        ///     Deletes an existing instance of FailedLogin class via FailedLoginId.
        /// </summary>
        /// <param name="failedLoginId">Enter the value for FailedLoginId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{failedLoginId}")]
        [Route("~/api/audit/failed-login/delete/{failedLoginId}")]
        public void Delete(long failedLoginId)
        {
            try
            {
                this.FailedLoginContext.Delete(failedLoginId);
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