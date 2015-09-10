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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Exchange Rate Details.
    /// </summary>
    [RoutePrefix("api/v1.5/core/exchange-rate-detail")]
    public class ExchangeRateDetailController : ApiController
    {
        /// <summary>
        ///     The ExchangeRateDetail data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Core.Data.ExchangeRateDetail ExchangeRateDetailContext;

        public ExchangeRateDetailController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.ExchangeRateDetailContext = new MixERP.Net.Schemas.Core.Data.ExchangeRateDetail
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
        ///     Counts the number of exchange rate details.
        /// </summary>
        /// <returns>Returns the count of the exchange rate details.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/core/exchange-rate-detail/count")]
        public long Count()
        {
            try
            {
                return this.ExchangeRateDetailContext.Count();
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
        ///     Returns an instance of exchange rate detail.
        /// </summary>
        /// <param name="exchangeRateDetailId">Enter ExchangeRateDetailId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{exchangeRateDetailId}")]
        [Route("~/api/core/exchange-rate-detail/{exchangeRateDetailId}")]
        public MixERP.Net.Entities.Core.ExchangeRateDetail Get(long exchangeRateDetailId)
        {
            try
            {
                return this.ExchangeRateDetailContext.Get(exchangeRateDetailId);
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
        ///     Creates a paginated collection containing 25 exchange rate details on each page, sorted by the property ExchangeRateDetailId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/core/exchange-rate-detail")]
        public IEnumerable<MixERP.Net.Entities.Core.ExchangeRateDetail> GetPagedResult()
        {
            try
            {
                return this.ExchangeRateDetailContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 exchange rate details on each page, sorted by the property ExchangeRateDetailId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/core/exchange-rate-detail/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.ExchangeRateDetail> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.ExchangeRateDetailContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 exchange rate details on each page, sorted by the property ExchangeRateDetailId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/core/exchange-rate-detail/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.ExchangeRateDetail> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.ExchangeRateDetailContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of exchange rate details.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of exchange rate details.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/core/exchange-rate-detail/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.ExchangeRateDetailContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for exchange rate details.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of exchange rate details.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/exchange-rate-detail/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.ExchangeRateDetailContext.GetCustomFields();
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
        /// <param name="exchangeRateDetail">Your instance of exchange rate details class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{exchangeRateDetail}")]
        [Route("~/api/core/exchange-rate-detail/add/{exchangeRateDetail}")]
        public void Add(MixERP.Net.Entities.Core.ExchangeRateDetail exchangeRateDetail)
        {
            if (exchangeRateDetail == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.ExchangeRateDetailContext.Add(exchangeRateDetail);
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
        /// <param name="exchangeRateDetail">Your instance of Account class to edit.</param>
        /// <param name="exchangeRateDetailId">Enter the value for ExchangeRateDetailId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{exchangeRateDetailId}/{exchangeRateDetail}")]
        [Route("~/api/core/exchange-rate-detail/edit/{exchangeRateDetailId}/{exchangeRateDetail}")]
        public void Edit(long exchangeRateDetailId, MixERP.Net.Entities.Core.ExchangeRateDetail exchangeRateDetail)
        {
            if (exchangeRateDetail == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.ExchangeRateDetailContext.Update(exchangeRateDetail, exchangeRateDetailId);
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
        ///     Deletes an existing instance of Account class via ExchangeRateDetailId.
        /// </summary>
        /// <param name="exchangeRateDetailId">Enter the value for ExchangeRateDetailId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{exchangeRateDetailId}")]
        [Route("~/api/core/exchange-rate-detail/delete/{exchangeRateDetailId}")]
        public void Delete(long exchangeRateDetailId)
        {
            try
            {
                this.ExchangeRateDetailContext.Delete(exchangeRateDetailId);
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