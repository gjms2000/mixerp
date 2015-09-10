using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using MixERP.Net.EntityParser;
using Newtonsoft.Json;
using PetaPoco;

namespace MixERP.Net.Api.Localization
{
    /// <summary>
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Localized Resources.
    /// </summary>
    [RoutePrefix("api/v1.5/localization/localized-resource")]
    public class LocalizedResourceController : ApiController
    {
        /// <summary>
        ///     The LocalizedResource data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Localization.Data.LocalizedResource LocalizedResourceContext;

        public LocalizedResourceController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.LocalizedResourceContext = new MixERP.Net.Schemas.Localization.Data.LocalizedResource
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
        ///     Counts the number of localized resources.
        /// </summary>
        /// <returns>Returns the count of the localized resources.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/localization/localized-resource/count")]
        public long Count()
        {
            try
            {
                return this.LocalizedResourceContext.Count();
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
        ///     Returns an instance of localized resource.
        /// </summary>
        /// <param name="localizedResourceId">Enter LocalizedResourceId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{localizedResourceId}")]
        [Route("~/api/localization/localized-resource/{localizedResourceId}")]
        public MixERP.Net.Entities.Localization.LocalizedResource Get(long localizedResourceId)
        {
            try
            {
                return this.LocalizedResourceContext.Get(localizedResourceId);
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
        ///     Creates a paginated collection containing 25 localized resources on each page, sorted by the property LocalizedResourceId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/localization/localized-resource")]
        public IEnumerable<MixERP.Net.Entities.Localization.LocalizedResource> GetPagedResult()
        {
            try
            {
                return this.LocalizedResourceContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 localized resources on each page, sorted by the property LocalizedResourceId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/localization/localized-resource/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Localization.LocalizedResource> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.LocalizedResourceContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 localized resources on each page, sorted by the property LocalizedResourceId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/localization/localized-resource/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Localization.LocalizedResource> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.LocalizedResourceContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of localized resources.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of localized resources.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/localization/localized-resource/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.LocalizedResourceContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for localized resources.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of localized resources.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/localization/localized-resource/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.LocalizedResourceContext.GetCustomFields();
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
        /// <param name="localizedResource">Your instance of localized resources class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{localizedResource}")]
        [Route("~/api/localization/localized-resource/add/{localizedResource}")]
        public void Add(MixERP.Net.Entities.Localization.LocalizedResource localizedResource)
        {
            if (localizedResource == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.LocalizedResourceContext.Add(localizedResource);
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
        /// <param name="localizedResource">Your instance of Account class to edit.</param>
        /// <param name="localizedResourceId">Enter the value for LocalizedResourceId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{localizedResourceId}/{localizedResource}")]
        [Route("~/api/localization/localized-resource/edit/{localizedResourceId}/{localizedResource}")]
        public void Edit(long localizedResourceId, MixERP.Net.Entities.Localization.LocalizedResource localizedResource)
        {
            if (localizedResource == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.LocalizedResourceContext.Update(localizedResource, localizedResourceId);
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
        ///     Deletes an existing instance of Account class via LocalizedResourceId.
        /// </summary>
        /// <param name="localizedResourceId">Enter the value for LocalizedResourceId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{localizedResourceId}")]
        [Route("~/api/localization/localized-resource/delete/{localizedResourceId}")]
        public void Delete(long localizedResourceId)
        {
            try
            {
                this.LocalizedResourceContext.Delete(localizedResourceId);
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