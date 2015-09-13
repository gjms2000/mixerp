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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Entity Accesses.
    /// </summary>
    [RoutePrefix("api/v1.5/policy/entity-access")]
    public class EntityAccessController : ApiController
    {
        /// <summary>
        ///     The EntityAccess data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Policy.Data.EntityAccess EntityAccessContext;

        public EntityAccessController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.EntityAccessContext = new MixERP.Net.Schemas.Policy.Data.EntityAccess
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
        ///     Counts the number of entity accesses.
        /// </summary>
        /// <returns>Returns the count of the entity accesses.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/policy/entity-access/count")]
        public long Count()
        {
            try
            {
                return this.EntityAccessContext.Count();
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
        ///     Returns an instance of entity access.
        /// </summary>
        /// <param name="entityAccessId">Enter EntityAccessId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{entityAccessId}")]
        [Route("~/api/policy/entity-access/{entityAccessId}")]
        public MixERP.Net.Entities.Policy.EntityAccess Get(int entityAccessId)
        {
            try
            {
                return this.EntityAccessContext.Get(entityAccessId);
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
        [Route("~/api/policy/entity-access/get")]
        public IEnumerable<MixERP.Net.Entities.Policy.EntityAccess> Get([FromUri] int[] entityAccessIds)
        {
            try
            {
                return this.EntityAccessContext.Get(entityAccessIds);
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
        ///     Creates a paginated collection containing 25 entity accesses on each page, sorted by the property EntityAccessId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/policy/entity-access")]
        public IEnumerable<MixERP.Net.Entities.Policy.EntityAccess> GetPagedResult()
        {
            try
            {
                return this.EntityAccessContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 entity accesses on each page, sorted by the property EntityAccessId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/policy/entity-access/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Policy.EntityAccess> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.EntityAccessContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 entity accesses on each page, sorted by the property EntityAccessId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/policy/entity-access/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Policy.EntityAccess> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.EntityAccessContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of entity accesses.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of entity accesses.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/policy/entity-access/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.EntityAccessContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for entity accesses.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of entity accesses.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/policy/entity-access/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.EntityAccessContext.GetCustomFields(null);
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
        ///     A custom field is a user defined field for entity accesses.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of entity accesses.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/policy/entity-access/custom-fields/{resourceId}")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
        {
            try
            {
                return this.EntityAccessContext.GetCustomFields(resourceId);
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
        ///     Adds or edits your instance of EntityAccess class.
        /// </summary>
        /// <param name="entityAccess">Your instance of entity accesses class to add or edit.</param>
        [AcceptVerbs("PUT")]
        [Route("add-or-edit")]
        [Route("~/api/policy/entity-access/add-or-edit")]
        public void AddOrEdit([FromBody]MixERP.Net.Entities.Policy.EntityAccess entityAccess)
        {
            if (entityAccess == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.EntityAccessContext.AddOrEdit(entityAccess);
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
        ///     Adds your instance of EntityAccess class.
        /// </summary>
        /// <param name="entityAccess">Your instance of entity accesses class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{entityAccess}")]
        [Route("~/api/policy/entity-access/add/{entityAccess}")]
        public void Add(MixERP.Net.Entities.Policy.EntityAccess entityAccess)
        {
            if (entityAccess == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.EntityAccessContext.Add(entityAccess);
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
        ///     Edits existing record with your instance of EntityAccess class.
        /// </summary>
        /// <param name="entityAccess">Your instance of EntityAccess class to edit.</param>
        /// <param name="entityAccessId">Enter the value for EntityAccessId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{entityAccessId}")]
        [Route("~/api/policy/entity-access/edit/{entityAccessId}")]
        public void Edit(int entityAccessId, [FromBody] MixERP.Net.Entities.Policy.EntityAccess entityAccess)
        {
            if (entityAccess == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.EntityAccessContext.Update(entityAccess, entityAccessId);
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
        ///     Deletes an existing instance of EntityAccess class via EntityAccessId.
        /// </summary>
        /// <param name="entityAccessId">Enter the value for EntityAccessId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{entityAccessId}")]
        [Route("~/api/policy/entity-access/delete/{entityAccessId}")]
        public void Delete(int entityAccessId)
        {
            try
            {
                this.EntityAccessContext.Delete(entityAccessId);
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