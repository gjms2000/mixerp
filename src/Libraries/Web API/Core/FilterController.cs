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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Filters.
    /// </summary>
    [RoutePrefix("api/v1.5/core/filter")]
    public class FilterController : ApiController
    {
        /// <summary>
        ///     The Filter data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Core.Data.Filter FilterContext;

        public FilterController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.FilterContext = new MixERP.Net.Schemas.Core.Data.Filter
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
        ///     Counts the number of filters.
        /// </summary>
        /// <returns>Returns the count of the filters.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/core/filter/count")]
        public long Count()
        {
            try
            {
                return this.FilterContext.Count();
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
        ///     Returns an instance of filter.
        /// </summary>
        /// <param name="filterId">Enter FilterId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{filterId}")]
        [Route("~/api/core/filter/{filterId}")]
        public MixERP.Net.Entities.Core.Filter Get(long filterId)
        {
            try
            {
                return this.FilterContext.Get(filterId);
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
        [Route("~/api/core/filter/get")]
        public IEnumerable<MixERP.Net.Entities.Core.Filter> Get([FromUri] long[] filterIds)
        {
            try
            {
                return this.FilterContext.Get(filterIds);
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
        ///     Creates a paginated collection containing 25 filters on each page, sorted by the property FilterId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/core/filter")]
        public IEnumerable<MixERP.Net.Entities.Core.Filter> GetPagedResult()
        {
            try
            {
                return this.FilterContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 filters on each page, sorted by the property FilterId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/core/filter/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.Filter> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.FilterContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 filters on each page, sorted by the property FilterId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/core/filter/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.Filter> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.FilterContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of filters.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of filters.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/core/filter/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.FilterContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for filters.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of filters.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/filter/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.FilterContext.GetCustomFields(null);
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
        ///     A custom field is a user defined field for filters.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of filters.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/filter/custom-fields/{resourceId}")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
        {
            try
            {
                return this.FilterContext.GetCustomFields(resourceId);
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
        ///     Adds or edits your instance of Filter class.
        /// </summary>
        /// <param name="filter">Your instance of filters class to add or edit.</param>
        [AcceptVerbs("PUT")]
        [Route("add-or-edit")]
        [Route("~/api/core/filter/add-or-edit")]
        public void AddOrEdit([FromBody]MixERP.Net.Entities.Core.Filter filter)
        {
            if (filter == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.FilterContext.AddOrEdit(filter);
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
        ///     Adds your instance of Filter class.
        /// </summary>
        /// <param name="filter">Your instance of filters class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{filter}")]
        [Route("~/api/core/filter/add/{filter}")]
        public void Add(MixERP.Net.Entities.Core.Filter filter)
        {
            if (filter == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.FilterContext.Add(filter);
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
        ///     Edits existing record with your instance of Filter class.
        /// </summary>
        /// <param name="filter">Your instance of Filter class to edit.</param>
        /// <param name="filterId">Enter the value for FilterId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{filterId}")]
        [Route("~/api/core/filter/edit/{filterId}")]
        public void Edit(long filterId, [FromBody] MixERP.Net.Entities.Core.Filter filter)
        {
            if (filter == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.FilterContext.Update(filter, filterId);
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
        ///     Deletes an existing instance of Filter class via FilterId.
        /// </summary>
        /// <param name="filterId">Enter the value for FilterId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{filterId}")]
        [Route("~/api/core/filter/delete/{filterId}")]
        public void Delete(long filterId)
        {
            try
            {
                this.FilterContext.Delete(filterId);
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