using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using MixERP.Net.EntityParser;
using Newtonsoft.Json;
using PetaPoco;

namespace MixERP.Net.Api.Config
{
    /// <summary>
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Open Exchange Rate Scrud Views.
    /// </summary>
    [RoutePrefix("api/v1.5/config/open-exchange-rate-scrud-view")]
    public class OpenExchangeRateScrudViewController : ApiController
    {
        /// <summary>
        ///     The OpenExchangeRateScrudView data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Config.Data.OpenExchangeRateScrudView OpenExchangeRateScrudViewContext;

        public OpenExchangeRateScrudViewController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.OpenExchangeRateScrudViewContext = new MixERP.Net.Schemas.Config.Data.OpenExchangeRateScrudView
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
        ///     Counts the number of open exchange rate scrud views.
        /// </summary>
        /// <returns>Returns the count of the open exchange rate scrud views.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/config/open-exchange-rate-scrud-view/count")]
        public long Count()
        {
            try
            {
                return this.OpenExchangeRateScrudViewContext.Count();
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
        ///     Creates a paginated collection containing 25 open exchange rate scrud views on each page, sorted by the property .
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/config/open-exchange-rate-scrud-view")]
        public IEnumerable<MixERP.Net.Entities.Config.OpenExchangeRateScrudView> GetPagedResult()
        {
            try
            {
                return this.OpenExchangeRateScrudViewContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 open exchange rate scrud views on each page, sorted by the property .
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/config/open-exchange-rate-scrud-view/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Config.OpenExchangeRateScrudView> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.OpenExchangeRateScrudViewContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 open exchange rate scrud views on each page, sorted by the property .
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/config/open-exchange-rate-scrud-view/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Config.OpenExchangeRateScrudView> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.OpenExchangeRateScrudViewContext.GetWhere(pageNumber, f);
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