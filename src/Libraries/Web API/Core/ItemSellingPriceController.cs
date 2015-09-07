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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Item Selling Prices.
    /// </summary>
    [RoutePrefix("api/v1.5/core/item-selling-price")]
    public class ItemSellingPriceController : ApiController
    {
        /// <summary>
        ///     The ItemSellingPrice data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Core.Data.ItemSellingPrice ItemSellingPriceContext;

        public ItemSellingPriceController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.ItemSellingPriceContext = new MixERP.Net.Schemas.Core.Data.ItemSellingPrice
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
        ///     Counts the number of item selling prices.
        /// </summary>
        /// <returns>Returns the count of the item selling prices.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/core/item-selling-price/count")]
        public long Count()
        {
            try
            {
                return this.ItemSellingPriceContext.Count();
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
        ///     Returns an instance of item selling price.
        /// </summary>
        /// <param name="itemSellingPriceId">Enter ItemSellingPriceId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{itemSellingPriceId}")]
        [Route("~/api/core/item-selling-price/{itemSellingPriceId}")]
        public MixERP.Net.Entities.Core.ItemSellingPrice Get(long itemSellingPriceId)
        {
            try
            {
                return this.ItemSellingPriceContext.Get(itemSellingPriceId);
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
        ///     Creates a paginated collection containing 25 item selling prices on each page, sorted by the property ItemSellingPriceId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/core/item-selling-price")]
        public IEnumerable<MixERP.Net.Entities.Core.ItemSellingPrice> GetPagedResult()
        {
            try
            {
                return this.ItemSellingPriceContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 item selling prices on each page, sorted by the property ItemSellingPriceId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/core/item-selling-price/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.ItemSellingPrice> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.ItemSellingPriceContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 item selling prices on each page, sorted by the property ItemSellingPriceId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/core/item-selling-price/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.ItemSellingPrice> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.ItemSellingPriceContext.GetWhere(pageNumber, f);
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
        ///     Displayfields is a lightweight key/value collection of item selling prices.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of item selling prices.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/core/item-selling-price/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.ItemSellingPriceContext.GetDisplayFields();
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
        /// <param name="itemSellingPrice">Your instance of item selling prices class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{itemSellingPrice}")]
        [Route("~/api/core/item-selling-price/add/{itemSellingPrice}")]
        public void Add(MixERP.Net.Entities.Core.ItemSellingPrice itemSellingPrice)
        {
            if (itemSellingPrice == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.ItemSellingPriceContext.Add(itemSellingPrice);
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
        /// <param name="itemSellingPrice">Your instance of Account class to edit.</param>
        /// <param name="itemSellingPriceId">Enter the value for ItemSellingPriceId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{itemSellingPriceId}/{itemSellingPrice}")]
        [Route("~/api/core/item-selling-price/edit/{itemSellingPriceId}/{itemSellingPrice}")]
        public void Edit(long itemSellingPriceId, MixERP.Net.Entities.Core.ItemSellingPrice itemSellingPrice)
        {
            if (itemSellingPrice == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.ItemSellingPriceContext.Update(itemSellingPrice, itemSellingPriceId);
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
        ///     Deletes an existing instance of Account class via ItemSellingPriceId.
        /// </summary>
        /// <param name="itemSellingPriceId">Enter the value for ItemSellingPriceId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{itemSellingPriceId}")]
        [Route("~/api/core/item-selling-price/delete/{itemSellingPriceId}")]
        public void Delete(long itemSellingPriceId)
        {
            try
            {
                this.ItemSellingPriceContext.Delete(itemSellingPriceId);
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