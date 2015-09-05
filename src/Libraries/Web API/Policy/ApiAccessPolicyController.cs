using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using PetaPoco;

namespace MixERP.Net.Api.Policy
{
    /// <summary>
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Api Access Policies.
    /// </summary>
    [RoutePrefix("api/v1.5/policy/api-access-policy")]
    public class ApiAccessPolicyController : ApiController
    {
        /// <summary>
        ///     The ApiAccessPolicy data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Policy.Data.ApiAccessPolicy ApiAccessPolicyContext;

        public ApiAccessPolicyController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.ApiAccessPolicyContext = new MixERP.Net.Schemas.Policy.Data.ApiAccessPolicy
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
        ///     Counts the number of api access policies.
        /// </summary>
        /// <returns>Returns the count of the api access policies.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        public long Count()
        {
            try
            {
                return this.ApiAccessPolicyContext.Count();
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Unauthorized));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Returns an instance of api access policy.
        /// </summary>
        /// <param name="apiAccessPolicyId">Enter ApiAccessPolicyId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{apiAccessPolicyId}")]
        public MixERP.Net.Entities.Policy.ApiAccessPolicy Get(long apiAccessPolicyId)
        {
            try
            {
                return this.ApiAccessPolicyContext.Get(apiAccessPolicyId);
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Unauthorized));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Creates a paginated collection containing 25 api access policies on each page, sorted by the property ApiAccessPolicyId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        public IEnumerable<MixERP.Net.Entities.Policy.ApiAccessPolicy> GetPagedResult()
        {
            try
            {
                return this.ApiAccessPolicyContext.GetPagedResult();
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Unauthorized));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Creates a paginated collection containing 25 api access policies on each page, sorted by the property ApiAccessPolicyId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Policy.ApiAccessPolicy> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.ApiAccessPolicyContext.GetPagedResult(pageNumber);
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Unauthorized));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Displayfields is a lightweight key/value collection of api access policies.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of api access policies.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.ApiAccessPolicyContext.GetDisplayFields();
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Unauthorized));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Adds your instance of Account class.
        /// </summary>
        /// <param name="apiAccessPolicy">Your instance of api access policies class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{apiAccessPolicy}")]
        public void Add(MixERP.Net.Entities.Policy.ApiAccessPolicy apiAccessPolicy)
        {
            if (apiAccessPolicy == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.ApiAccessPolicyContext.Add(apiAccessPolicy);
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Unauthorized));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Edits existing record with your instance of Account class.
        /// </summary>
        /// <param name="apiAccessPolicy">Your instance of Account class to edit.</param>
        /// <param name="apiAccessPolicyId">Enter the value for ApiAccessPolicyId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{apiAccessPolicyId}/{apiAccessPolicy}")]
        public void Edit(long apiAccessPolicyId, MixERP.Net.Entities.Policy.ApiAccessPolicy apiAccessPolicy)
        {
            if (apiAccessPolicy == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.ApiAccessPolicyContext.Update(apiAccessPolicy, apiAccessPolicyId);
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Unauthorized));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Deletes an existing instance of Account class via ApiAccessPolicyId.
        /// </summary>
        /// <param name="apiAccessPolicyId">Enter the value for ApiAccessPolicyId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{apiAccessPolicyId}")]
        public void Delete(long apiAccessPolicyId)
        {
            try
            {
                this.ApiAccessPolicyContext.Delete(apiAccessPolicyId);
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Unauthorized));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }
    }
}