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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Menu Accesses.
    /// </summary>
    [RoutePrefix("api/v1.5/policy/menu-access")]
    public class MenuAccessController : ApiController
    {
        /// <summary>
        ///     The MenuAccess data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Policy.Data.MenuAccess MenuAccessContext;

        public MenuAccessController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.MenuAccessContext = new MixERP.Net.Schemas.Policy.Data.MenuAccess
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
        ///     Counts the number of menu accesses.
        /// </summary>
        /// <returns>Returns the count of the menu accesses.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/policy/menu-access/count")]
        public long Count()
        {
            try
            {
                return this.MenuAccessContext.Count();
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
        ///     Returns an instance of menu access.
        /// </summary>
        /// <param name="accessId">Enter AccessId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{accessId}")]
        [Route("~/api/policy/menu-access/{accessId}")]
        public MixERP.Net.Entities.Policy.MenuAccess Get(long accessId)
        {
            try
            {
                return this.MenuAccessContext.Get(accessId);
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
        [Route("~/api/policy/menu-access/get")]
        public IEnumerable<MixERP.Net.Entities.Policy.MenuAccess> Get([FromUri] long[] accessIds)
        {
            try
            {
                return this.MenuAccessContext.Get(accessIds);
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
        ///     Creates a paginated collection containing 25 menu accesses on each page, sorted by the property AccessId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/policy/menu-access")]
        public IEnumerable<MixERP.Net.Entities.Policy.MenuAccess> GetPagedResult()
        {
            try
            {
                return this.MenuAccessContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 menu accesses on each page, sorted by the property AccessId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/policy/menu-access/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Policy.MenuAccess> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.MenuAccessContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 menu accesses on each page, sorted by the property AccessId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/policy/menu-access/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Policy.MenuAccess> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.MenuAccessContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of menu accesses.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of menu accesses.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/policy/menu-access/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.MenuAccessContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for menu accesses.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of menu accesses.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/policy/menu-access/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.MenuAccessContext.GetCustomFields(null);
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
        ///     A custom field is a user defined field for menu accesses.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of menu accesses.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/policy/menu-access/custom-fields/{resourceId}")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
        {
            try
            {
                return this.MenuAccessContext.GetCustomFields(resourceId);
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
        ///     Adds or edits your instance of MenuAccess class.
        /// </summary>
        /// <param name="menuAccess">Your instance of menu accesses class to add or edit.</param>
        [AcceptVerbs("PUT")]
        [Route("add-or-edit")]
        [Route("~/api/policy/menu-access/add-or-edit")]
        public void AddOrEdit([FromBody]MixERP.Net.Entities.Policy.MenuAccess menuAccess)
        {
            if (menuAccess == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.MenuAccessContext.AddOrEdit(menuAccess);
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
        ///     Adds your instance of MenuAccess class.
        /// </summary>
        /// <param name="menuAccess">Your instance of menu accesses class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{menuAccess}")]
        [Route("~/api/policy/menu-access/add/{menuAccess}")]
        public void Add(MixERP.Net.Entities.Policy.MenuAccess menuAccess)
        {
            if (menuAccess == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.MenuAccessContext.Add(menuAccess);
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
        ///     Edits existing record with your instance of MenuAccess class.
        /// </summary>
        /// <param name="menuAccess">Your instance of MenuAccess class to edit.</param>
        /// <param name="accessId">Enter the value for AccessId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{accessId}")]
        [Route("~/api/policy/menu-access/edit/{accessId}")]
        public void Edit(long accessId, [FromBody] MixERP.Net.Entities.Policy.MenuAccess menuAccess)
        {
            if (menuAccess == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.MenuAccessContext.Update(menuAccess, accessId);
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
        ///     Deletes an existing instance of MenuAccess class via AccessId.
        /// </summary>
        /// <param name="accessId">Enter the value for AccessId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{accessId}")]
        [Route("~/api/policy/menu-access/delete/{accessId}")]
        public void Delete(long accessId)
        {
            try
            {
                this.MenuAccessContext.Delete(accessId);
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