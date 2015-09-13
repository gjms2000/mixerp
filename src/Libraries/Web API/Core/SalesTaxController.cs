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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Sales Taxes.
    /// </summary>
    [RoutePrefix("api/v1.5/core/sales-tax")]
    public class SalesTaxController : ApiController
    {
        /// <summary>
        ///     The SalesTax data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Core.Data.SalesTax SalesTaxContext;

        public SalesTaxController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.SalesTaxContext = new MixERP.Net.Schemas.Core.Data.SalesTax
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
        ///     Counts the number of sales taxes.
        /// </summary>
        /// <returns>Returns the count of the sales taxes.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/core/sales-tax/count")]
        public long Count()
        {
            try
            {
                return this.SalesTaxContext.Count();
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
        ///     Returns an instance of sales tax.
        /// </summary>
        /// <param name="salesTaxId">Enter SalesTaxId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{salesTaxId}")]
        [Route("~/api/core/sales-tax/{salesTaxId}")]
        public MixERP.Net.Entities.Core.SalesTax Get(int salesTaxId)
        {
            try
            {
                return this.SalesTaxContext.Get(salesTaxId);
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
        [Route("~/api/core/sales-tax/get")]
        public IEnumerable<MixERP.Net.Entities.Core.SalesTax> Get([FromUri] int[] salesTaxIds)
        {
            try
            {
                return this.SalesTaxContext.Get(salesTaxIds);
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
        ///     Creates a paginated collection containing 25 sales taxes on each page, sorted by the property SalesTaxId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/core/sales-tax")]
        public IEnumerable<MixERP.Net.Entities.Core.SalesTax> GetPagedResult()
        {
            try
            {
                return this.SalesTaxContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 sales taxes on each page, sorted by the property SalesTaxId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/core/sales-tax/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.SalesTax> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.SalesTaxContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 sales taxes on each page, sorted by the property SalesTaxId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/core/sales-tax/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.SalesTax> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.SalesTaxContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of sales taxes.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of sales taxes.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/core/sales-tax/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.SalesTaxContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for sales taxes.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of sales taxes.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/sales-tax/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.SalesTaxContext.GetCustomFields(null);
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
        ///     A custom field is a user defined field for sales taxes.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of sales taxes.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/sales-tax/custom-fields/{resourceId}")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
        {
            try
            {
                return this.SalesTaxContext.GetCustomFields(resourceId);
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
        ///     Adds or edits your instance of SalesTax class.
        /// </summary>
        /// <param name="salesTax">Your instance of sales taxes class to add or edit.</param>
        [AcceptVerbs("PUT")]
        [Route("add-or-edit")]
        [Route("~/api/core/sales-tax/add-or-edit")]
        public void AddOrEdit([FromBody]MixERP.Net.Entities.Core.SalesTax salesTax)
        {
            if (salesTax == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.SalesTaxContext.AddOrEdit(salesTax);
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
        ///     Adds your instance of SalesTax class.
        /// </summary>
        /// <param name="salesTax">Your instance of sales taxes class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{salesTax}")]
        [Route("~/api/core/sales-tax/add/{salesTax}")]
        public void Add(MixERP.Net.Entities.Core.SalesTax salesTax)
        {
            if (salesTax == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.SalesTaxContext.Add(salesTax);
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
        ///     Edits existing record with your instance of SalesTax class.
        /// </summary>
        /// <param name="salesTax">Your instance of SalesTax class to edit.</param>
        /// <param name="salesTaxId">Enter the value for SalesTaxId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{salesTaxId}")]
        [Route("~/api/core/sales-tax/edit/{salesTaxId}")]
        public void Edit(int salesTaxId, [FromBody] MixERP.Net.Entities.Core.SalesTax salesTax)
        {
            if (salesTax == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.SalesTaxContext.Update(salesTax, salesTaxId);
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
        ///     Deletes an existing instance of SalesTax class via SalesTaxId.
        /// </summary>
        /// <param name="salesTaxId">Enter the value for SalesTaxId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{salesTaxId}")]
        [Route("~/api/core/sales-tax/delete/{salesTaxId}")]
        public void Delete(int salesTaxId)
        {
            try
            {
                this.SalesTaxContext.Delete(salesTaxId);
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