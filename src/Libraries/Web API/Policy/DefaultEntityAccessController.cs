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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Default Entity Accesses.
    /// </summary>
    [RoutePrefix("api/v1.5/policy/default-entity-access")]
    public class DefaultEntityAccessController : ApiController
    {
        /// <summary>
        ///     The DefaultEntityAccess data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Policy.Data.DefaultEntityAccess DefaultEntityAccessContext;

        public DefaultEntityAccessController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.DefaultEntityAccessContext = new MixERP.Net.Schemas.Policy.Data.DefaultEntityAccess
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
        ///     Counts the number of default entity accesses.
        /// </summary>
        /// <returns>Returns the count of the default entity accesses.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/policy/default-entity-access/count")]
        public long Count()
        {
            try
            {
                return this.DefaultEntityAccessContext.Count();
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
        ///     Returns an instance of default entity access.
        /// </summary>
        /// <param name="defaultEntityAccessId">Enter DefaultEntityAccessId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{defaultEntityAccessId}")]
        [Route("~/api/policy/default-entity-access/{defaultEntityAccessId}")]
        public MixERP.Net.Entities.Policy.DefaultEntityAccess Get(int defaultEntityAccessId)
        {
            try
            {
                return this.DefaultEntityAccessContext.Get(defaultEntityAccessId);
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
        ///     Creates a paginated collection containing 25 default entity accesses on each page, sorted by the property DefaultEntityAccessId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/policy/default-entity-access")]
        public IEnumerable<MixERP.Net.Entities.Policy.DefaultEntityAccess> GetPagedResult()
        {
            try
            {
                return this.DefaultEntityAccessContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 default entity accesses on each page, sorted by the property DefaultEntityAccessId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/policy/default-entity-access/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Policy.DefaultEntityAccess> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.DefaultEntityAccessContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 default entity accesses on each page, sorted by the property DefaultEntityAccessId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/policy/default-entity-access/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Policy.DefaultEntityAccess> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.DefaultEntityAccessContext.GetWhere(pageNumber, f);
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
        ///     Displayfields is a lightweight key/value collection of default entity accesses.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of default entity accesses.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/policy/default-entity-access/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.DefaultEntityAccessContext.GetDisplayFields();
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
        /// <param name="defaultEntityAccess">Your instance of default entity accesses class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{defaultEntityAccess}")]
        [Route("~/api/policy/default-entity-access/add/{defaultEntityAccess}")]
        public void Add(MixERP.Net.Entities.Policy.DefaultEntityAccess defaultEntityAccess)
        {
            if (defaultEntityAccess == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.DefaultEntityAccessContext.Add(defaultEntityAccess);
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
        /// <param name="defaultEntityAccess">Your instance of Account class to edit.</param>
        /// <param name="defaultEntityAccessId">Enter the value for DefaultEntityAccessId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{defaultEntityAccessId}/{defaultEntityAccess}")]
        [Route("~/api/policy/default-entity-access/edit/{defaultEntityAccessId}/{defaultEntityAccess}")]
        public void Edit(int defaultEntityAccessId, MixERP.Net.Entities.Policy.DefaultEntityAccess defaultEntityAccess)
        {
            if (defaultEntityAccess == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.DefaultEntityAccessContext.Update(defaultEntityAccess, defaultEntityAccessId);
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
        ///     Deletes an existing instance of Account class via DefaultEntityAccessId.
        /// </summary>
        /// <param name="defaultEntityAccessId">Enter the value for DefaultEntityAccessId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{defaultEntityAccessId}")]
        [Route("~/api/policy/default-entity-access/delete/{defaultEntityAccessId}")]
        public void Delete(int defaultEntityAccessId)
        {
            try
            {
                this.DefaultEntityAccessContext.Delete(defaultEntityAccessId);
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