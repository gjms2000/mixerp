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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Inventory Transfer Request Details.
    /// </summary>
    [RoutePrefix("api/v1.5/transactions/inventory-transfer-request-detail")]
    public class InventoryTransferRequestDetailController : ApiController
    {
        /// <summary>
        ///     The InventoryTransferRequestDetail data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Transactions.Data.InventoryTransferRequestDetail InventoryTransferRequestDetailContext;

        public InventoryTransferRequestDetailController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.InventoryTransferRequestDetailContext = new MixERP.Net.Schemas.Transactions.Data.InventoryTransferRequestDetail
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
        ///     Counts the number of inventory transfer request details.
        /// </summary>
        /// <returns>Returns the count of the inventory transfer request details.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/transactions/inventory-transfer-request-detail/count")]
        public long Count()
        {
            try
            {
                return this.InventoryTransferRequestDetailContext.Count();
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
        ///     Returns an instance of inventory transfer request detail.
        /// </summary>
        /// <param name="inventoryTransferRequestDetailId">Enter InventoryTransferRequestDetailId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{inventoryTransferRequestDetailId}")]
        [Route("~/api/transactions/inventory-transfer-request-detail/{inventoryTransferRequestDetailId}")]
        public MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail Get(long inventoryTransferRequestDetailId)
        {
            try
            {
                return this.InventoryTransferRequestDetailContext.Get(inventoryTransferRequestDetailId);
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
        ///     Creates a paginated collection containing 25 inventory transfer request details on each page, sorted by the property InventoryTransferRequestDetailId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/transactions/inventory-transfer-request-detail")]
        public IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail> GetPagedResult()
        {
            try
            {
                return this.InventoryTransferRequestDetailContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 inventory transfer request details on each page, sorted by the property InventoryTransferRequestDetailId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/transactions/inventory-transfer-request-detail/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.InventoryTransferRequestDetailContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 inventory transfer request details on each page, sorted by the property InventoryTransferRequestDetailId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/transactions/inventory-transfer-request-detail/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.InventoryTransferRequestDetailContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of inventory transfer request details.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of inventory transfer request details.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/transactions/inventory-transfer-request-detail/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.InventoryTransferRequestDetailContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for inventory transfer request details.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of inventory transfer request details.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/transactions/inventory-transfer-request-detail/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.InventoryTransferRequestDetailContext.GetCustomFields();
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
        /// <param name="inventoryTransferRequestDetail">Your instance of inventory transfer request details class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{inventoryTransferRequestDetail}")]
        [Route("~/api/transactions/inventory-transfer-request-detail/add/{inventoryTransferRequestDetail}")]
        public void Add(MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail inventoryTransferRequestDetail)
        {
            if (inventoryTransferRequestDetail == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.InventoryTransferRequestDetailContext.Add(inventoryTransferRequestDetail);
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
        /// <param name="inventoryTransferRequestDetail">Your instance of Account class to edit.</param>
        /// <param name="inventoryTransferRequestDetailId">Enter the value for InventoryTransferRequestDetailId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{inventoryTransferRequestDetailId}/{inventoryTransferRequestDetail}")]
        [Route("~/api/transactions/inventory-transfer-request-detail/edit/{inventoryTransferRequestDetailId}/{inventoryTransferRequestDetail}")]
        public void Edit(long inventoryTransferRequestDetailId, MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail inventoryTransferRequestDetail)
        {
            if (inventoryTransferRequestDetail == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.InventoryTransferRequestDetailContext.Update(inventoryTransferRequestDetail, inventoryTransferRequestDetailId);
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
        ///     Deletes an existing instance of Account class via InventoryTransferRequestDetailId.
        /// </summary>
        /// <param name="inventoryTransferRequestDetailId">Enter the value for InventoryTransferRequestDetailId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{inventoryTransferRequestDetailId}")]
        [Route("~/api/transactions/inventory-transfer-request-detail/delete/{inventoryTransferRequestDetailId}")]
        public void Delete(long inventoryTransferRequestDetailId)
        {
            try
            {
                this.InventoryTransferRequestDetailContext.Delete(inventoryTransferRequestDetailId);
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