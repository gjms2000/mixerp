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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Inventory Transfer Requests.
    /// </summary>
    [RoutePrefix("api/v1.5/transactions/inventory-transfer-request")]
    public class InventoryTransferRequestController : ApiController
    {
        /// <summary>
        ///     The InventoryTransferRequest data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Transactions.Data.InventoryTransferRequest InventoryTransferRequestContext;

        public InventoryTransferRequestController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.InventoryTransferRequestContext = new MixERP.Net.Schemas.Transactions.Data.InventoryTransferRequest
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
        ///     Counts the number of inventory transfer requests.
        /// </summary>
        /// <returns>Returns the count of the inventory transfer requests.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/transactions/inventory-transfer-request/count")]
        public long Count()
        {
            try
            {
                return this.InventoryTransferRequestContext.Count();
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
        ///     Returns an instance of inventory transfer request.
        /// </summary>
        /// <param name="inventoryTransferRequestId">Enter InventoryTransferRequestId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{inventoryTransferRequestId}")]
        [Route("~/api/transactions/inventory-transfer-request/{inventoryTransferRequestId}")]
        public MixERP.Net.Entities.Transactions.InventoryTransferRequest Get(long inventoryTransferRequestId)
        {
            try
            {
                return this.InventoryTransferRequestContext.Get(inventoryTransferRequestId);
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
        [Route("~/api/transactions/inventory-transfer-request/get")]
        public IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferRequest> Get([FromUri] long[] inventoryTransferRequestIds)
        {
            try
            {
                return this.InventoryTransferRequestContext.Get(inventoryTransferRequestIds);
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
        ///     Creates a paginated collection containing 25 inventory transfer requests on each page, sorted by the property InventoryTransferRequestId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/transactions/inventory-transfer-request")]
        public IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferRequest> GetPagedResult()
        {
            try
            {
                return this.InventoryTransferRequestContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 inventory transfer requests on each page, sorted by the property InventoryTransferRequestId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/transactions/inventory-transfer-request/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferRequest> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.InventoryTransferRequestContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 inventory transfer requests on each page, sorted by the property InventoryTransferRequestId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/transactions/inventory-transfer-request/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferRequest> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.InventoryTransferRequestContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of inventory transfer requests.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of inventory transfer requests.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/transactions/inventory-transfer-request/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.InventoryTransferRequestContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for inventory transfer requests.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of inventory transfer requests.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/transactions/inventory-transfer-request/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.InventoryTransferRequestContext.GetCustomFields(null);
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
        ///     A custom field is a user defined field for inventory transfer requests.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of inventory transfer requests.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/transactions/inventory-transfer-request/custom-fields/{resourceId}")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
        {
            try
            {
                return this.InventoryTransferRequestContext.GetCustomFields(resourceId);
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
        ///     Adds or edits your instance of InventoryTransferRequest class.
        /// </summary>
        /// <param name="inventoryTransferRequest">Your instance of inventory transfer requests class to add or edit.</param>
        [AcceptVerbs("PUT")]
        [Route("add-or-edit")]
        [Route("~/api/transactions/inventory-transfer-request/add-or-edit")]
        public void AddOrEdit([FromBody]MixERP.Net.Entities.Transactions.InventoryTransferRequest inventoryTransferRequest)
        {
            if (inventoryTransferRequest == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.InventoryTransferRequestContext.AddOrEdit(inventoryTransferRequest);
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
        ///     Adds your instance of InventoryTransferRequest class.
        /// </summary>
        /// <param name="inventoryTransferRequest">Your instance of inventory transfer requests class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{inventoryTransferRequest}")]
        [Route("~/api/transactions/inventory-transfer-request/add/{inventoryTransferRequest}")]
        public void Add(MixERP.Net.Entities.Transactions.InventoryTransferRequest inventoryTransferRequest)
        {
            if (inventoryTransferRequest == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.InventoryTransferRequestContext.Add(inventoryTransferRequest);
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
        ///     Edits existing record with your instance of InventoryTransferRequest class.
        /// </summary>
        /// <param name="inventoryTransferRequest">Your instance of InventoryTransferRequest class to edit.</param>
        /// <param name="inventoryTransferRequestId">Enter the value for InventoryTransferRequestId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{inventoryTransferRequestId}")]
        [Route("~/api/transactions/inventory-transfer-request/edit/{inventoryTransferRequestId}")]
        public void Edit(long inventoryTransferRequestId, [FromBody] MixERP.Net.Entities.Transactions.InventoryTransferRequest inventoryTransferRequest)
        {
            if (inventoryTransferRequest == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.InventoryTransferRequestContext.Update(inventoryTransferRequest, inventoryTransferRequestId);
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
        ///     Deletes an existing instance of InventoryTransferRequest class via InventoryTransferRequestId.
        /// </summary>
        /// <param name="inventoryTransferRequestId">Enter the value for InventoryTransferRequestId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{inventoryTransferRequestId}")]
        [Route("~/api/transactions/inventory-transfer-request/delete/{inventoryTransferRequestId}")]
        public void Delete(long inventoryTransferRequestId)
        {
            try
            {
                this.InventoryTransferRequestContext.Delete(inventoryTransferRequestId);
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