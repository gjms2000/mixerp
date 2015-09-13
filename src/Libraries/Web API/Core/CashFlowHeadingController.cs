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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Cash Flow Headings.
    /// </summary>
    [RoutePrefix("api/v1.5/core/cash-flow-heading")]
    public class CashFlowHeadingController : ApiController
    {
        /// <summary>
        ///     The CashFlowHeading data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Core.Data.CashFlowHeading CashFlowHeadingContext;

        public CashFlowHeadingController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.CashFlowHeadingContext = new MixERP.Net.Schemas.Core.Data.CashFlowHeading
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
        ///     Counts the number of cash flow headings.
        /// </summary>
        /// <returns>Returns the count of the cash flow headings.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/core/cash-flow-heading/count")]
        public long Count()
        {
            try
            {
                return this.CashFlowHeadingContext.Count();
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
        ///     Returns an instance of cash flow heading.
        /// </summary>
        /// <param name="cashFlowHeadingId">Enter CashFlowHeadingId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{cashFlowHeadingId}")]
        [Route("~/api/core/cash-flow-heading/{cashFlowHeadingId}")]
        public MixERP.Net.Entities.Core.CashFlowHeading Get(int cashFlowHeadingId)
        {
            try
            {
                return this.CashFlowHeadingContext.Get(cashFlowHeadingId);
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
        [Route("~/api/core/cash-flow-heading/get")]
        public IEnumerable<MixERP.Net.Entities.Core.CashFlowHeading> Get([FromUri] int[] cashFlowHeadingIds)
        {
            try
            {
                return this.CashFlowHeadingContext.Get(cashFlowHeadingIds);
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
        ///     Creates a paginated collection containing 25 cash flow headings on each page, sorted by the property CashFlowHeadingId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/core/cash-flow-heading")]
        public IEnumerable<MixERP.Net.Entities.Core.CashFlowHeading> GetPagedResult()
        {
            try
            {
                return this.CashFlowHeadingContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 cash flow headings on each page, sorted by the property CashFlowHeadingId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/core/cash-flow-heading/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.CashFlowHeading> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.CashFlowHeadingContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 cash flow headings on each page, sorted by the property CashFlowHeadingId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/core/cash-flow-heading/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.CashFlowHeading> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.CashFlowHeadingContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of cash flow headings.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of cash flow headings.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/core/cash-flow-heading/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.CashFlowHeadingContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for cash flow headings.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of cash flow headings.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/cash-flow-heading/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.CashFlowHeadingContext.GetCustomFields(null);
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
        ///     A custom field is a user defined field for cash flow headings.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of cash flow headings.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/cash-flow-heading/custom-fields/{resourceId}")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
        {
            try
            {
                return this.CashFlowHeadingContext.GetCustomFields(resourceId);
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
        ///     Adds or edits your instance of CashFlowHeading class.
        /// </summary>
        /// <param name="cashFlowHeading">Your instance of cash flow headings class to add or edit.</param>
        [AcceptVerbs("PUT")]
        [Route("add-or-edit")]
        [Route("~/api/core/cash-flow-heading/add-or-edit")]
        public void AddOrEdit([FromBody]MixERP.Net.Entities.Core.CashFlowHeading cashFlowHeading)
        {
            if (cashFlowHeading == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.CashFlowHeadingContext.AddOrEdit(cashFlowHeading);
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
        ///     Adds your instance of CashFlowHeading class.
        /// </summary>
        /// <param name="cashFlowHeading">Your instance of cash flow headings class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{cashFlowHeading}")]
        [Route("~/api/core/cash-flow-heading/add/{cashFlowHeading}")]
        public void Add(MixERP.Net.Entities.Core.CashFlowHeading cashFlowHeading)
        {
            if (cashFlowHeading == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.CashFlowHeadingContext.Add(cashFlowHeading);
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
        ///     Edits existing record with your instance of CashFlowHeading class.
        /// </summary>
        /// <param name="cashFlowHeading">Your instance of CashFlowHeading class to edit.</param>
        /// <param name="cashFlowHeadingId">Enter the value for CashFlowHeadingId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{cashFlowHeadingId}")]
        [Route("~/api/core/cash-flow-heading/edit/{cashFlowHeadingId}")]
        public void Edit(int cashFlowHeadingId, [FromBody] MixERP.Net.Entities.Core.CashFlowHeading cashFlowHeading)
        {
            if (cashFlowHeading == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.CashFlowHeadingContext.Update(cashFlowHeading, cashFlowHeadingId);
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
        ///     Deletes an existing instance of CashFlowHeading class via CashFlowHeadingId.
        /// </summary>
        /// <param name="cashFlowHeadingId">Enter the value for CashFlowHeadingId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{cashFlowHeadingId}")]
        [Route("~/api/core/cash-flow-heading/delete/{cashFlowHeadingId}")]
        public void Delete(int cashFlowHeadingId)
        {
            try
            {
                this.CashFlowHeadingContext.Delete(cashFlowHeadingId);
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