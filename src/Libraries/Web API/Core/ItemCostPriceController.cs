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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Item Cost Prices.
    /// </summary>
    [RoutePrefix("api/v1.5/core/item-cost-price")]
    public class ItemCostPriceController : ApiController
    {
        /// <summary>
        ///     The ItemCostPrice data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Core.Data.ItemCostPrice ItemCostPriceContext;

        public ItemCostPriceController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.ItemCostPriceContext = new MixERP.Net.Schemas.Core.Data.ItemCostPrice
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
        ///     Counts the number of item cost prices.
        /// </summary>
        /// <returns>Returns the count of the item cost prices.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/core/item-cost-price/count")]
        public long Count()
        {
            try
            {
                return this.ItemCostPriceContext.Count();
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
        ///     Returns an instance of item cost price.
        /// </summary>
        /// <param name="itemCostPriceId">Enter ItemCostPriceId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{itemCostPriceId}")]
        [Route("~/api/core/item-cost-price/{itemCostPriceId}")]
        public MixERP.Net.Entities.Core.ItemCostPrice Get(long itemCostPriceId)
        {
            try
            {
                return this.ItemCostPriceContext.Get(itemCostPriceId);
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
        [Route("~/api/core/item-cost-price/get")]
        public IEnumerable<MixERP.Net.Entities.Core.ItemCostPrice> Get([FromUri] long[] itemCostPriceIds)
        {
            try
            {
                return this.ItemCostPriceContext.Get(itemCostPriceIds);
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
        ///     Creates a paginated collection containing 25 item cost prices on each page, sorted by the property ItemCostPriceId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/core/item-cost-price")]
        public IEnumerable<MixERP.Net.Entities.Core.ItemCostPrice> GetPagedResult()
        {
            try
            {
                return this.ItemCostPriceContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 item cost prices on each page, sorted by the property ItemCostPriceId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/core/item-cost-price/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.ItemCostPrice> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.ItemCostPriceContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 item cost prices on each page, sorted by the property ItemCostPriceId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/core/item-cost-price/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.ItemCostPrice> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.ItemCostPriceContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of item cost prices.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of item cost prices.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/core/item-cost-price/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.ItemCostPriceContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for item cost prices.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of item cost prices.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/item-cost-price/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.ItemCostPriceContext.GetCustomFields(null);
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
        ///     A custom field is a user defined field for item cost prices.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of item cost prices.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/item-cost-price/custom-fields/{resourceId}")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
        {
            try
            {
                return this.ItemCostPriceContext.GetCustomFields(resourceId);
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
        ///     Adds or edits your instance of ItemCostPrice class.
        /// </summary>
        /// <param name="itemCostPrice">Your instance of item cost prices class to add or edit.</param>
        [AcceptVerbs("PUT")]
        [Route("add-or-edit")]
        [Route("~/api/core/item-cost-price/add-or-edit")]
        public void AddOrEdit([FromBody]MixERP.Net.Entities.Core.ItemCostPrice itemCostPrice)
        {
            if (itemCostPrice == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.ItemCostPriceContext.AddOrEdit(itemCostPrice);
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
        ///     Adds your instance of ItemCostPrice class.
        /// </summary>
        /// <param name="itemCostPrice">Your instance of item cost prices class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{itemCostPrice}")]
        [Route("~/api/core/item-cost-price/add/{itemCostPrice}")]
        public void Add(MixERP.Net.Entities.Core.ItemCostPrice itemCostPrice)
        {
            if (itemCostPrice == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.ItemCostPriceContext.Add(itemCostPrice);
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
        ///     Edits existing record with your instance of ItemCostPrice class.
        /// </summary>
        /// <param name="itemCostPrice">Your instance of ItemCostPrice class to edit.</param>
        /// <param name="itemCostPriceId">Enter the value for ItemCostPriceId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{itemCostPriceId}")]
        [Route("~/api/core/item-cost-price/edit/{itemCostPriceId}")]
        public void Edit(long itemCostPriceId, [FromBody] MixERP.Net.Entities.Core.ItemCostPrice itemCostPrice)
        {
            if (itemCostPrice == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.ItemCostPriceContext.Update(itemCostPrice, itemCostPriceId);
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
        ///     Deletes an existing instance of ItemCostPrice class via ItemCostPriceId.
        /// </summary>
        /// <param name="itemCostPriceId">Enter the value for ItemCostPriceId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{itemCostPriceId}")]
        [Route("~/api/core/item-cost-price/delete/{itemCostPriceId}")]
        public void Delete(long itemCostPriceId)
        {
            try
            {
                this.ItemCostPriceContext.Delete(itemCostPriceId);
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