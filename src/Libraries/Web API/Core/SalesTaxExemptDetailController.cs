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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Sales Tax Exempt Details.
    /// </summary>
    [RoutePrefix("api/v1.5/core/sales-tax-exempt-detail")]
    public class SalesTaxExemptDetailController : ApiController
    {
        /// <summary>
        ///     The SalesTaxExemptDetail data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Core.Data.SalesTaxExemptDetail SalesTaxExemptDetailContext;

        public SalesTaxExemptDetailController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.SalesTaxExemptDetailContext = new MixERP.Net.Schemas.Core.Data.SalesTaxExemptDetail
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
        ///     Counts the number of sales tax exempt details.
        /// </summary>
        /// <returns>Returns the count of the sales tax exempt details.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        public long Count()
        {
            try
            {
                return this.SalesTaxExemptDetailContext.Count();
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
        ///     Returns an instance of sales tax exempt detail.
        /// </summary>
        /// <param name="salesTaxExemptDetailId">Enter SalesTaxExemptDetailId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{salesTaxExemptDetailId}")]
        public MixERP.Net.Entities.Core.SalesTaxExemptDetail Get(int salesTaxExemptDetailId)
        {
            try
            {
                return this.SalesTaxExemptDetailContext.Get(salesTaxExemptDetailId);
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
        ///     Creates a paginated collection containing 25 sales tax exempt details on each page, sorted by the property SalesTaxExemptDetailId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        public IEnumerable<MixERP.Net.Entities.Core.SalesTaxExemptDetail> GetPagedResult()
        {
            try
            {
                return this.SalesTaxExemptDetailContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 sales tax exempt details on each page, sorted by the property SalesTaxExemptDetailId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.SalesTaxExemptDetail> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.SalesTaxExemptDetailContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 sales tax exempt details on each page, sorted by the property SalesTaxExemptDetailId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.SalesTaxExemptDetail> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.SalesTaxExemptDetailContext.GetWhere(pageNumber, f);
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
        ///     Displayfields is a lightweight key/value collection of sales tax exempt details.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of sales tax exempt details.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.SalesTaxExemptDetailContext.GetDisplayFields();
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
        /// <param name="salesTaxExemptDetail">Your instance of sales tax exempt details class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{salesTaxExemptDetail}")]
        public void Add(MixERP.Net.Entities.Core.SalesTaxExemptDetail salesTaxExemptDetail)
        {
            if (salesTaxExemptDetail == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.SalesTaxExemptDetailContext.Add(salesTaxExemptDetail);
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
        /// <param name="salesTaxExemptDetail">Your instance of Account class to edit.</param>
        /// <param name="salesTaxExemptDetailId">Enter the value for SalesTaxExemptDetailId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{salesTaxExemptDetailId}/{salesTaxExemptDetail}")]
        public void Edit(int salesTaxExemptDetailId, MixERP.Net.Entities.Core.SalesTaxExemptDetail salesTaxExemptDetail)
        {
            if (salesTaxExemptDetail == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.SalesTaxExemptDetailContext.Update(salesTaxExemptDetail, salesTaxExemptDetailId);
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
        ///     Deletes an existing instance of Account class via SalesTaxExemptDetailId.
        /// </summary>
        /// <param name="salesTaxExemptDetailId">Enter the value for SalesTaxExemptDetailId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{salesTaxExemptDetailId}")]
        public void Delete(int salesTaxExemptDetailId)
        {
            try
            {
                this.SalesTaxExemptDetailContext.Delete(salesTaxExemptDetailId);
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