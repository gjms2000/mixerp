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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Transaction Details.
    /// </summary>
    [RoutePrefix("api/v1.5/transactions/transaction-detail")]
    public class TransactionDetailController : ApiController
    {
        /// <summary>
        ///     The TransactionDetail data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Transactions.Data.TransactionDetail TransactionDetailContext;

        public TransactionDetailController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.TransactionDetailContext = new MixERP.Net.Schemas.Transactions.Data.TransactionDetail
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
        ///     Counts the number of transaction details.
        /// </summary>
        /// <returns>Returns the count of the transaction details.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/transactions/transaction-detail/count")]
        public long Count()
        {
            try
            {
                return this.TransactionDetailContext.Count();
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
        ///     Returns an instance of transaction detail.
        /// </summary>
        /// <param name="transactionDetailId">Enter TransactionDetailId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{transactionDetailId}")]
        [Route("~/api/transactions/transaction-detail/{transactionDetailId}")]
        public MixERP.Net.Entities.Transactions.TransactionDetail Get(long transactionDetailId)
        {
            try
            {
                return this.TransactionDetailContext.Get(transactionDetailId);
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
        [Route("~/api/transactions/transaction-detail/get")]
        public IEnumerable<MixERP.Net.Entities.Transactions.TransactionDetail> Get([FromUri] long[] transactionDetailIds)
        {
            try
            {
                return this.TransactionDetailContext.Get(transactionDetailIds);
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
        ///     Creates a paginated collection containing 25 transaction details on each page, sorted by the property TransactionDetailId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/transactions/transaction-detail")]
        public IEnumerable<MixERP.Net.Entities.Transactions.TransactionDetail> GetPagedResult()
        {
            try
            {
                return this.TransactionDetailContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 transaction details on each page, sorted by the property TransactionDetailId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/transactions/transaction-detail/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Transactions.TransactionDetail> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.TransactionDetailContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 transaction details on each page, sorted by the property TransactionDetailId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/transactions/transaction-detail/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Transactions.TransactionDetail> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.TransactionDetailContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of transaction details.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of transaction details.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/transactions/transaction-detail/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.TransactionDetailContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for transaction details.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of transaction details.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/transactions/transaction-detail/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.TransactionDetailContext.GetCustomFields(null);
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
        ///     A custom field is a user defined field for transaction details.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of transaction details.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/transactions/transaction-detail/custom-fields/{resourceId}")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
        {
            try
            {
                return this.TransactionDetailContext.GetCustomFields(resourceId);
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
        ///     Adds or edits your instance of TransactionDetail class.
        /// </summary>
        /// <param name="transactionDetail">Your instance of transaction details class to add or edit.</param>
        [AcceptVerbs("PUT")]
        [Route("add-or-edit")]
        [Route("~/api/transactions/transaction-detail/add-or-edit")]
        public void AddOrEdit([FromBody]MixERP.Net.Entities.Transactions.TransactionDetail transactionDetail)
        {
            if (transactionDetail == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.TransactionDetailContext.AddOrEdit(transactionDetail);
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
        ///     Adds your instance of TransactionDetail class.
        /// </summary>
        /// <param name="transactionDetail">Your instance of transaction details class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{transactionDetail}")]
        [Route("~/api/transactions/transaction-detail/add/{transactionDetail}")]
        public void Add(MixERP.Net.Entities.Transactions.TransactionDetail transactionDetail)
        {
            if (transactionDetail == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.TransactionDetailContext.Add(transactionDetail);
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
        ///     Edits existing record with your instance of TransactionDetail class.
        /// </summary>
        /// <param name="transactionDetail">Your instance of TransactionDetail class to edit.</param>
        /// <param name="transactionDetailId">Enter the value for TransactionDetailId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{transactionDetailId}")]
        [Route("~/api/transactions/transaction-detail/edit/{transactionDetailId}")]
        public void Edit(long transactionDetailId, [FromBody] MixERP.Net.Entities.Transactions.TransactionDetail transactionDetail)
        {
            if (transactionDetail == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.TransactionDetailContext.Update(transactionDetail, transactionDetailId);
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
        ///     Deletes an existing instance of TransactionDetail class via TransactionDetailId.
        /// </summary>
        /// <param name="transactionDetailId">Enter the value for TransactionDetailId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{transactionDetailId}")]
        [Route("~/api/transactions/transaction-detail/delete/{transactionDetailId}")]
        public void Delete(long transactionDetailId)
        {
            try
            {
                this.TransactionDetailContext.Delete(transactionDetailId);
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