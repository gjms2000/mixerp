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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Exchange Rates.
    /// </summary>
    [RoutePrefix("api/v1.5/core/exchange-rate")]
    public class ExchangeRateController : ApiController
    {
        /// <summary>
        ///     The ExchangeRate data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Core.Data.ExchangeRate ExchangeRateContext;

        public ExchangeRateController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.ExchangeRateContext = new MixERP.Net.Schemas.Core.Data.ExchangeRate
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
        ///     Counts the number of exchange rates.
        /// </summary>
        /// <returns>Returns the count of the exchange rates.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/core/exchange-rate/count")]
        public long Count()
        {
            try
            {
                return this.ExchangeRateContext.Count();
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
        ///     Returns an instance of exchange rate.
        /// </summary>
        /// <param name="exchangeRateId">Enter ExchangeRateId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{exchangeRateId}")]
        [Route("~/api/core/exchange-rate/{exchangeRateId}")]
        public MixERP.Net.Entities.Core.ExchangeRate Get(long exchangeRateId)
        {
            try
            {
                return this.ExchangeRateContext.Get(exchangeRateId);
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
        ///     Creates a paginated collection containing 25 exchange rates on each page, sorted by the property ExchangeRateId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/core/exchange-rate")]
        public IEnumerable<MixERP.Net.Entities.Core.ExchangeRate> GetPagedResult()
        {
            try
            {
                return this.ExchangeRateContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 exchange rates on each page, sorted by the property ExchangeRateId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/core/exchange-rate/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.ExchangeRate> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.ExchangeRateContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 exchange rates on each page, sorted by the property ExchangeRateId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/core/exchange-rate/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.ExchangeRate> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.ExchangeRateContext.GetWhere(pageNumber, f);
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
        ///     Displayfields is a lightweight key/value collection of exchange rates.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of exchange rates.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/core/exchange-rate/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.ExchangeRateContext.GetDisplayFields();
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
        /// <param name="exchangeRate">Your instance of exchange rates class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{exchangeRate}")]
        [Route("~/api/core/exchange-rate/add/{exchangeRate}")]
        public void Add(MixERP.Net.Entities.Core.ExchangeRate exchangeRate)
        {
            if (exchangeRate == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.ExchangeRateContext.Add(exchangeRate);
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
        /// <param name="exchangeRate">Your instance of Account class to edit.</param>
        /// <param name="exchangeRateId">Enter the value for ExchangeRateId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{exchangeRateId}/{exchangeRate}")]
        [Route("~/api/core/exchange-rate/edit/{exchangeRateId}/{exchangeRate}")]
        public void Edit(long exchangeRateId, MixERP.Net.Entities.Core.ExchangeRate exchangeRate)
        {
            if (exchangeRate == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.ExchangeRateContext.Update(exchangeRate, exchangeRateId);
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
        ///     Deletes an existing instance of Account class via ExchangeRateId.
        /// </summary>
        /// <param name="exchangeRateId">Enter the value for ExchangeRateId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{exchangeRateId}")]
        [Route("~/api/core/exchange-rate/delete/{exchangeRateId}")]
        public void Delete(long exchangeRateId)
        {
            try
            {
                this.ExchangeRateContext.Delete(exchangeRateId);
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