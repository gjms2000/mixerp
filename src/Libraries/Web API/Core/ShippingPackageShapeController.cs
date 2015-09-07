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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Shipping Package Shapes.
    /// </summary>
    [RoutePrefix("api/v1.5/core/shipping-package-shape")]
    public class ShippingPackageShapeController : ApiController
    {
        /// <summary>
        ///     The ShippingPackageShape data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Core.Data.ShippingPackageShape ShippingPackageShapeContext;

        public ShippingPackageShapeController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.ShippingPackageShapeContext = new MixERP.Net.Schemas.Core.Data.ShippingPackageShape
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
        ///     Counts the number of shipping package shapes.
        /// </summary>
        /// <returns>Returns the count of the shipping package shapes.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/core/shipping-package-shape/count")]
        public long Count()
        {
            try
            {
                return this.ShippingPackageShapeContext.Count();
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
        ///     Returns an instance of shipping package shape.
        /// </summary>
        /// <param name="shippingPackageShapeId">Enter ShippingPackageShapeId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{shippingPackageShapeId}")]
        [Route("~/api/core/shipping-package-shape/{shippingPackageShapeId}")]
        public MixERP.Net.Entities.Core.ShippingPackageShape Get(int shippingPackageShapeId)
        {
            try
            {
                return this.ShippingPackageShapeContext.Get(shippingPackageShapeId);
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
        ///     Creates a paginated collection containing 25 shipping package shapes on each page, sorted by the property ShippingPackageShapeId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/core/shipping-package-shape")]
        public IEnumerable<MixERP.Net.Entities.Core.ShippingPackageShape> GetPagedResult()
        {
            try
            {
                return this.ShippingPackageShapeContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 shipping package shapes on each page, sorted by the property ShippingPackageShapeId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/core/shipping-package-shape/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.ShippingPackageShape> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.ShippingPackageShapeContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 shipping package shapes on each page, sorted by the property ShippingPackageShapeId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/core/shipping-package-shape/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.ShippingPackageShape> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.ShippingPackageShapeContext.GetWhere(pageNumber, f);
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
        ///     Displayfields is a lightweight key/value collection of shipping package shapes.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of shipping package shapes.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/core/shipping-package-shape/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.ShippingPackageShapeContext.GetDisplayFields();
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
        /// <param name="shippingPackageShape">Your instance of shipping package shapes class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{shippingPackageShape}")]
        [Route("~/api/core/shipping-package-shape/add/{shippingPackageShape}")]
        public void Add(MixERP.Net.Entities.Core.ShippingPackageShape shippingPackageShape)
        {
            if (shippingPackageShape == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.ShippingPackageShapeContext.Add(shippingPackageShape);
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
        /// <param name="shippingPackageShape">Your instance of Account class to edit.</param>
        /// <param name="shippingPackageShapeId">Enter the value for ShippingPackageShapeId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{shippingPackageShapeId}/{shippingPackageShape}")]
        [Route("~/api/core/shipping-package-shape/edit/{shippingPackageShapeId}/{shippingPackageShape}")]
        public void Edit(int shippingPackageShapeId, MixERP.Net.Entities.Core.ShippingPackageShape shippingPackageShape)
        {
            if (shippingPackageShape == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.ShippingPackageShapeContext.Update(shippingPackageShape, shippingPackageShapeId);
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
        ///     Deletes an existing instance of Account class via ShippingPackageShapeId.
        /// </summary>
        /// <param name="shippingPackageShapeId">Enter the value for ShippingPackageShapeId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{shippingPackageShapeId}")]
        [Route("~/api/core/shipping-package-shape/delete/{shippingPackageShapeId}")]
        public void Delete(int shippingPackageShapeId)
        {
            try
            {
                this.ShippingPackageShapeContext.Delete(shippingPackageShapeId);
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