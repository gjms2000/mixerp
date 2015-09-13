using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using MixERP.Net.EntityParser;
using Newtonsoft.Json;
using PetaPoco;

namespace MixERP.Net.Api.Transactions
{
    /// <summary>
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Stock Details.
    /// </summary>
    [RoutePrefix("api/v1.5/transactions/stock-detail")]
    public class StockDetailController : ApiController
    {
        /// <summary>
        ///     The StockDetail data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Transactions.Data.StockDetail StockDetailContext;

        public StockDetailController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.StockDetailContext = new MixERP.Net.Schemas.Transactions.Data.StockDetail
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
        ///     Counts the number of stock details.
        /// </summary>
        /// <returns>Returns the count of the stock details.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/transactions/stock-detail/count")]
        public long Count()
        {
            try
            {
                return this.StockDetailContext.Count();
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
        ///     Returns an instance of stock detail.
        /// </summary>
        /// <param name="stockDetailId">Enter StockDetailId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{stockDetailId}")]
        [Route("~/api/transactions/stock-detail/{stockDetailId}")]
        public MixERP.Net.Entities.Transactions.StockDetail Get(long stockDetailId)
        {
            try
            {
                return this.StockDetailContext.Get(stockDetailId);
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
        [Route("~/api/transactions/stock-detail/get")]
        public IEnumerable<MixERP.Net.Entities.Transactions.StockDetail> Get([FromUri] long[] stockDetailIds)
        {
            try
            {
                return this.StockDetailContext.Get(stockDetailIds);
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
        ///     Creates a paginated collection containing 25 stock details on each page, sorted by the property StockDetailId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/transactions/stock-detail")]
        public IEnumerable<MixERP.Net.Entities.Transactions.StockDetail> GetPagedResult()
        {
            try
            {
                return this.StockDetailContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 stock details on each page, sorted by the property StockDetailId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/transactions/stock-detail/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Transactions.StockDetail> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.StockDetailContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 stock details on each page, sorted by the property StockDetailId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/transactions/stock-detail/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Transactions.StockDetail> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.StockDetailContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of stock details.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of stock details.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/transactions/stock-detail/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.StockDetailContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for stock details.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of stock details.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/transactions/stock-detail/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.StockDetailContext.GetCustomFields(null);
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
        ///     A custom field is a user defined field for stock details.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of stock details.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/transactions/stock-detail/custom-fields/{resourceId}")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
        {
            try
            {
                return this.StockDetailContext.GetCustomFields(resourceId);
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
        ///     Adds or edits your instance of StockDetail class.
        /// </summary>
        /// <param name="stockDetail">Your instance of stock details class to add or edit.</param>
        [AcceptVerbs("PUT")]
        [Route("add-or-edit")]
        [Route("~/api/transactions/stock-detail/add-or-edit")]
        public void AddOrEdit([FromBody]MixERP.Net.Entities.Transactions.StockDetail stockDetail)
        {
            if (stockDetail == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.StockDetailContext.AddOrEdit(stockDetail);
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
        ///     Adds your instance of StockDetail class.
        /// </summary>
        /// <param name="stockDetail">Your instance of stock details class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{stockDetail}")]
        [Route("~/api/transactions/stock-detail/add/{stockDetail}")]
        public void Add(MixERP.Net.Entities.Transactions.StockDetail stockDetail)
        {
            if (stockDetail == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.StockDetailContext.Add(stockDetail);
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
        ///     Edits existing record with your instance of StockDetail class.
        /// </summary>
        /// <param name="stockDetail">Your instance of StockDetail class to edit.</param>
        /// <param name="stockDetailId">Enter the value for StockDetailId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{stockDetailId}")]
        [Route("~/api/transactions/stock-detail/edit/{stockDetailId}")]
        public void Edit(long stockDetailId, [FromBody] MixERP.Net.Entities.Transactions.StockDetail stockDetail)
        {
            if (stockDetail == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.StockDetailContext.Update(stockDetail, stockDetailId);
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
        ///     Deletes an existing instance of StockDetail class via StockDetailId.
        /// </summary>
        /// <param name="stockDetailId">Enter the value for StockDetailId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{stockDetailId}")]
        [Route("~/api/transactions/stock-detail/delete/{stockDetailId}")]
        public void Delete(long stockDetailId)
        {
            try
            {
                this.StockDetailContext.Delete(stockDetailId);
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