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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Recurring Invoice Account Selector Views.
    /// </summary>
    [RoutePrefix("api/v1.5/core/recurring-invoice-account-selector-view")]
    public class RecurringInvoiceAccountSelectorViewController : ApiController
    {
        /// <summary>
        ///     The RecurringInvoiceAccountSelectorView data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Core.Data.RecurringInvoiceAccountSelectorView RecurringInvoiceAccountSelectorViewContext;

        public RecurringInvoiceAccountSelectorViewController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.RecurringInvoiceAccountSelectorViewContext = new MixERP.Net.Schemas.Core.Data.RecurringInvoiceAccountSelectorView
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
        ///     Counts the number of recurring invoice account selector views.
        /// </summary>
        /// <returns>Returns the count of the recurring invoice account selector views.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/core/recurring-invoice-account-selector-view/count")]
        public long Count()
        {
            try
            {
                return this.RecurringInvoiceAccountSelectorViewContext.Count();
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
        ///     Creates a paginated collection containing 25 recurring invoice account selector views on each page, sorted by the property .
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/core/recurring-invoice-account-selector-view")]
        public IEnumerable<MixERP.Net.Entities.Core.RecurringInvoiceAccountSelectorView> GetPagedResult()
        {
            try
            {
                return this.RecurringInvoiceAccountSelectorViewContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 recurring invoice account selector views on each page, sorted by the property .
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/core/recurring-invoice-account-selector-view/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.RecurringInvoiceAccountSelectorView> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.RecurringInvoiceAccountSelectorViewContext.GetPagedResult(pageNumber);
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
        ///     Displayfield is a lightweight key/value collection of recurring invoice account selector views.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of recurring invoice account selector views.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/core/recurring-invoice-account-selector-view/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.RecurringInvoiceAccountSelectorViewContext.GetDisplayFields();
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
        ///     Creates a filtered and paginated collection containing 25 recurring invoice account selector views on each page, sorted by the property .
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/core/recurring-invoice-account-selector-view/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.RecurringInvoiceAccountSelectorView> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.RecurringInvoiceAccountSelectorViewContext.GetWhere(pageNumber, f);
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