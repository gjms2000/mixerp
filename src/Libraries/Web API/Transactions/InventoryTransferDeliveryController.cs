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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Inventory Transfer Deliveries.
    /// </summary>
    [RoutePrefix("api/v1.5/transactions/inventory-transfer-delivery")]
    public class InventoryTransferDeliveryController : ApiController
    {
        /// <summary>
        ///     The InventoryTransferDelivery data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Transactions.Data.InventoryTransferDelivery InventoryTransferDeliveryContext;

        public InventoryTransferDeliveryController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.InventoryTransferDeliveryContext = new MixERP.Net.Schemas.Transactions.Data.InventoryTransferDelivery
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
        ///     Counts the number of inventory transfer deliveries.
        /// </summary>
        /// <returns>Returns the count of the inventory transfer deliveries.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/transactions/inventory-transfer-delivery/count")]
        public long Count()
        {
            try
            {
                return this.InventoryTransferDeliveryContext.Count();
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Unauthorized));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Returns an instance of inventory transfer delivery.
        /// </summary>
        /// <param name="inventoryTransferDeliveryId">Enter InventoryTransferDeliveryId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{inventoryTransferDeliveryId}")]
        [Route("~/api/transactions/inventory-transfer-delivery/{inventoryTransferDeliveryId}")]
        public MixERP.Net.Entities.Transactions.InventoryTransferDelivery Get(long inventoryTransferDeliveryId)
        {
            try
            {
                return this.InventoryTransferDeliveryContext.Get(inventoryTransferDeliveryId);
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Unauthorized));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Creates a paginated collection containing 25 inventory transfer deliveries on each page, sorted by the property InventoryTransferDeliveryId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/transactions/inventory-transfer-delivery")]
        public IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferDelivery> GetPagedResult()
        {
            try
            {
                return this.InventoryTransferDeliveryContext.GetPagedResult();
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Unauthorized));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Creates a paginated collection containing 25 inventory transfer deliveries on each page, sorted by the property InventoryTransferDeliveryId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/transactions/inventory-transfer-delivery/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferDelivery> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.InventoryTransferDeliveryContext.GetPagedResult(pageNumber);
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Unauthorized));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Creates a filtered and paginated collection containing 25 inventory transfer deliveries on each page, sorted by the property InventoryTransferDeliveryId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/transactions/inventory-transfer-delivery/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferDelivery> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.InventoryTransferDeliveryContext.GetWhere(pageNumber, f);
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Unauthorized));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Displayfields is a lightweight key/value collection of inventory transfer deliveries.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of inventory transfer deliveries.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/transactions/inventory-transfer-delivery/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.InventoryTransferDeliveryContext.GetDisplayFields();
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Unauthorized));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Adds your instance of Account class.
        /// </summary>
        /// <param name="inventoryTransferDelivery">Your instance of inventory transfer deliveries class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{inventoryTransferDelivery}")]
        [Route("~/api/transactions/inventory-transfer-delivery/add/{inventoryTransferDelivery}")]
        public void Add(MixERP.Net.Entities.Transactions.InventoryTransferDelivery inventoryTransferDelivery)
        {
            if (inventoryTransferDelivery == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.InventoryTransferDeliveryContext.Add(inventoryTransferDelivery);
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Unauthorized));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Edits existing record with your instance of Account class.
        /// </summary>
        /// <param name="inventoryTransferDelivery">Your instance of Account class to edit.</param>
        /// <param name="inventoryTransferDeliveryId">Enter the value for InventoryTransferDeliveryId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{inventoryTransferDeliveryId}/{inventoryTransferDelivery}")]
        [Route("~/api/transactions/inventory-transfer-delivery/edit/{inventoryTransferDeliveryId}/{inventoryTransferDelivery}")]
        public void Edit(long inventoryTransferDeliveryId, MixERP.Net.Entities.Transactions.InventoryTransferDelivery inventoryTransferDelivery)
        {
            if (inventoryTransferDelivery == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.InventoryTransferDeliveryContext.Update(inventoryTransferDelivery, inventoryTransferDeliveryId);
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Unauthorized));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Deletes an existing instance of Account class via InventoryTransferDeliveryId.
        /// </summary>
        /// <param name="inventoryTransferDeliveryId">Enter the value for InventoryTransferDeliveryId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{inventoryTransferDeliveryId}")]
        [Route("~/api/transactions/inventory-transfer-delivery/delete/{inventoryTransferDeliveryId}")]
        public void Delete(long inventoryTransferDeliveryId)
        {
            try
            {
                this.InventoryTransferDeliveryContext.Delete(inventoryTransferDeliveryId);
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Unauthorized));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }


    }
}