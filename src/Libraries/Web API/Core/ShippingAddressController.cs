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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Shipping Addresses.
    /// </summary>
    [RoutePrefix("api/v1.5/core/shipping-address")]
    public class ShippingAddressController : ApiController
    {
        /// <summary>
        ///     The ShippingAddress data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Core.Data.ShippingAddress ShippingAddressContext;

        public ShippingAddressController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.ShippingAddressContext = new MixERP.Net.Schemas.Core.Data.ShippingAddress
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
        ///     Counts the number of shipping addresses.
        /// </summary>
        /// <returns>Returns the count of the shipping addresses.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/core/shipping-address/count")]
        public long Count()
        {
            try
            {
                return this.ShippingAddressContext.Count();
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
        ///     Returns an instance of shipping address.
        /// </summary>
        /// <param name="shippingAddressId">Enter ShippingAddressId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{shippingAddressId}")]
        [Route("~/api/core/shipping-address/{shippingAddressId}")]
        public MixERP.Net.Entities.Core.ShippingAddress Get(long shippingAddressId)
        {
            try
            {
                return this.ShippingAddressContext.Get(shippingAddressId);
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
        ///     Creates a paginated collection containing 25 shipping addresses on each page, sorted by the property ShippingAddressId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/core/shipping-address")]
        public IEnumerable<MixERP.Net.Entities.Core.ShippingAddress> GetPagedResult()
        {
            try
            {
                return this.ShippingAddressContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 shipping addresses on each page, sorted by the property ShippingAddressId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/core/shipping-address/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.ShippingAddress> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.ShippingAddressContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 shipping addresses on each page, sorted by the property ShippingAddressId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/core/shipping-address/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.ShippingAddress> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.ShippingAddressContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of shipping addresses.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of shipping addresses.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/core/shipping-address/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.ShippingAddressContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for shipping addresses.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of shipping addresses.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/shipping-address/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.ShippingAddressContext.GetCustomFields();
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
        /// <param name="shippingAddress">Your instance of shipping addresses class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{shippingAddress}")]
        [Route("~/api/core/shipping-address/add/{shippingAddress}")]
        public void Add(MixERP.Net.Entities.Core.ShippingAddress shippingAddress)
        {
            if (shippingAddress == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.ShippingAddressContext.Add(shippingAddress);
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
        /// <param name="shippingAddress">Your instance of Account class to edit.</param>
        /// <param name="shippingAddressId">Enter the value for ShippingAddressId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{shippingAddressId}/{shippingAddress}")]
        [Route("~/api/core/shipping-address/edit/{shippingAddressId}/{shippingAddress}")]
        public void Edit(long shippingAddressId, MixERP.Net.Entities.Core.ShippingAddress shippingAddress)
        {
            if (shippingAddress == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.ShippingAddressContext.Update(shippingAddress, shippingAddressId);
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
        ///     Deletes an existing instance of Account class via ShippingAddressId.
        /// </summary>
        /// <param name="shippingAddressId">Enter the value for ShippingAddressId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{shippingAddressId}")]
        [Route("~/api/core/shipping-address/delete/{shippingAddressId}")]
        public void Delete(long shippingAddressId)
        {
            try
            {
                this.ShippingAddressContext.Delete(shippingAddressId);
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