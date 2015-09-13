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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Sales Tax Types.
    /// </summary>
    [RoutePrefix("api/v1.5/core/sales-tax-type")]
    public class SalesTaxTypeController : ApiController
    {
        /// <summary>
        ///     The SalesTaxType data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Core.Data.SalesTaxType SalesTaxTypeContext;

        public SalesTaxTypeController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.SalesTaxTypeContext = new MixERP.Net.Schemas.Core.Data.SalesTaxType
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
        ///     Counts the number of sales tax types.
        /// </summary>
        /// <returns>Returns the count of the sales tax types.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/core/sales-tax-type/count")]
        public long Count()
        {
            try
            {
                return this.SalesTaxTypeContext.Count();
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
        ///     Returns an instance of sales tax type.
        /// </summary>
        /// <param name="salesTaxTypeId">Enter SalesTaxTypeId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{salesTaxTypeId}")]
        [Route("~/api/core/sales-tax-type/{salesTaxTypeId}")]
        public MixERP.Net.Entities.Core.SalesTaxType Get(int salesTaxTypeId)
        {
            try
            {
                return this.SalesTaxTypeContext.Get(salesTaxTypeId);
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
        [Route("~/api/core/sales-tax-type/get")]
        public IEnumerable<MixERP.Net.Entities.Core.SalesTaxType> Get([FromUri] int[] salesTaxTypeIds)
        {
            try
            {
                return this.SalesTaxTypeContext.Get(salesTaxTypeIds);
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
        ///     Creates a paginated collection containing 25 sales tax types on each page, sorted by the property SalesTaxTypeId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/core/sales-tax-type")]
        public IEnumerable<MixERP.Net.Entities.Core.SalesTaxType> GetPagedResult()
        {
            try
            {
                return this.SalesTaxTypeContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 sales tax types on each page, sorted by the property SalesTaxTypeId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/core/sales-tax-type/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.SalesTaxType> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.SalesTaxTypeContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 sales tax types on each page, sorted by the property SalesTaxTypeId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/core/sales-tax-type/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.SalesTaxType> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.SalesTaxTypeContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of sales tax types.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of sales tax types.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/core/sales-tax-type/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.SalesTaxTypeContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for sales tax types.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of sales tax types.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/sales-tax-type/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.SalesTaxTypeContext.GetCustomFields(null);
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
        ///     A custom field is a user defined field for sales tax types.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of sales tax types.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/sales-tax-type/custom-fields/{resourceId}")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
        {
            try
            {
                return this.SalesTaxTypeContext.GetCustomFields(resourceId);
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
        ///     Adds or edits your instance of SalesTaxType class.
        /// </summary>
        /// <param name="salesTaxType">Your instance of sales tax types class to add or edit.</param>
        [AcceptVerbs("PUT")]
        [Route("add-or-edit")]
        [Route("~/api/core/sales-tax-type/add-or-edit")]
        public void AddOrEdit([FromBody]MixERP.Net.Entities.Core.SalesTaxType salesTaxType)
        {
            if (salesTaxType == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.SalesTaxTypeContext.AddOrEdit(salesTaxType);
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
        ///     Adds your instance of SalesTaxType class.
        /// </summary>
        /// <param name="salesTaxType">Your instance of sales tax types class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{salesTaxType}")]
        [Route("~/api/core/sales-tax-type/add/{salesTaxType}")]
        public void Add(MixERP.Net.Entities.Core.SalesTaxType salesTaxType)
        {
            if (salesTaxType == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.SalesTaxTypeContext.Add(salesTaxType);
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
        ///     Edits existing record with your instance of SalesTaxType class.
        /// </summary>
        /// <param name="salesTaxType">Your instance of SalesTaxType class to edit.</param>
        /// <param name="salesTaxTypeId">Enter the value for SalesTaxTypeId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{salesTaxTypeId}")]
        [Route("~/api/core/sales-tax-type/edit/{salesTaxTypeId}")]
        public void Edit(int salesTaxTypeId, [FromBody] MixERP.Net.Entities.Core.SalesTaxType salesTaxType)
        {
            if (salesTaxType == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.SalesTaxTypeContext.Update(salesTaxType, salesTaxTypeId);
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
        ///     Deletes an existing instance of SalesTaxType class via SalesTaxTypeId.
        /// </summary>
        /// <param name="salesTaxTypeId">Enter the value for SalesTaxTypeId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{salesTaxTypeId}")]
        [Route("~/api/core/sales-tax-type/delete/{salesTaxTypeId}")]
        public void Delete(int salesTaxTypeId)
        {
            try
            {
                this.SalesTaxTypeContext.Delete(salesTaxTypeId);
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