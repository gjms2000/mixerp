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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Cash Flow Setups.
    /// </summary>
    [RoutePrefix("api/v1.5/core/cash-flow-setup")]
    public class CashFlowSetupController : ApiController
    {
        /// <summary>
        ///     The CashFlowSetup data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Core.Data.CashFlowSetup CashFlowSetupContext;

        public CashFlowSetupController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.CashFlowSetupContext = new MixERP.Net.Schemas.Core.Data.CashFlowSetup
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
        ///     Counts the number of cash flow setups.
        /// </summary>
        /// <returns>Returns the count of the cash flow setups.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/core/cash-flow-setup/count")]
        public long Count()
        {
            try
            {
                return this.CashFlowSetupContext.Count();
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
        ///     Returns an instance of cash flow setup.
        /// </summary>
        /// <param name="cashFlowSetupId">Enter CashFlowSetupId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{cashFlowSetupId}")]
        [Route("~/api/core/cash-flow-setup/{cashFlowSetupId}")]
        public MixERP.Net.Entities.Core.CashFlowSetup Get(int cashFlowSetupId)
        {
            try
            {
                return this.CashFlowSetupContext.Get(cashFlowSetupId);
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
        [Route("~/api/core/cash-flow-setup/get")]
        public IEnumerable<MixERP.Net.Entities.Core.CashFlowSetup> Get([FromUri] int[] cashFlowSetupIds)
        {
            try
            {
                return this.CashFlowSetupContext.Get(cashFlowSetupIds);
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
        ///     Creates a paginated collection containing 25 cash flow setups on each page, sorted by the property CashFlowSetupId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/core/cash-flow-setup")]
        public IEnumerable<MixERP.Net.Entities.Core.CashFlowSetup> GetPagedResult()
        {
            try
            {
                return this.CashFlowSetupContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 cash flow setups on each page, sorted by the property CashFlowSetupId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/core/cash-flow-setup/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.CashFlowSetup> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.CashFlowSetupContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 cash flow setups on each page, sorted by the property CashFlowSetupId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/core/cash-flow-setup/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.CashFlowSetup> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.CashFlowSetupContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of cash flow setups.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of cash flow setups.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/core/cash-flow-setup/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.CashFlowSetupContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for cash flow setups.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of cash flow setups.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/cash-flow-setup/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.CashFlowSetupContext.GetCustomFields(null);
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
        ///     A custom field is a user defined field for cash flow setups.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of cash flow setups.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/cash-flow-setup/custom-fields/{resourceId}")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
        {
            try
            {
                return this.CashFlowSetupContext.GetCustomFields(resourceId);
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
        ///     Adds or edits your instance of CashFlowSetup class.
        /// </summary>
        /// <param name="cashFlowSetup">Your instance of cash flow setups class to add or edit.</param>
        [AcceptVerbs("PUT")]
        [Route("add-or-edit")]
        [Route("~/api/core/cash-flow-setup/add-or-edit")]
        public void AddOrEdit([FromBody]MixERP.Net.Entities.Core.CashFlowSetup cashFlowSetup)
        {
            if (cashFlowSetup == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.CashFlowSetupContext.AddOrEdit(cashFlowSetup);
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
        ///     Adds your instance of CashFlowSetup class.
        /// </summary>
        /// <param name="cashFlowSetup">Your instance of cash flow setups class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{cashFlowSetup}")]
        [Route("~/api/core/cash-flow-setup/add/{cashFlowSetup}")]
        public void Add(MixERP.Net.Entities.Core.CashFlowSetup cashFlowSetup)
        {
            if (cashFlowSetup == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.CashFlowSetupContext.Add(cashFlowSetup);
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
        ///     Edits existing record with your instance of CashFlowSetup class.
        /// </summary>
        /// <param name="cashFlowSetup">Your instance of CashFlowSetup class to edit.</param>
        /// <param name="cashFlowSetupId">Enter the value for CashFlowSetupId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{cashFlowSetupId}")]
        [Route("~/api/core/cash-flow-setup/edit/{cashFlowSetupId}")]
        public void Edit(int cashFlowSetupId, [FromBody] MixERP.Net.Entities.Core.CashFlowSetup cashFlowSetup)
        {
            if (cashFlowSetup == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.CashFlowSetupContext.Update(cashFlowSetup, cashFlowSetupId);
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
        ///     Deletes an existing instance of CashFlowSetup class via CashFlowSetupId.
        /// </summary>
        /// <param name="cashFlowSetupId">Enter the value for CashFlowSetupId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{cashFlowSetupId}")]
        [Route("~/api/core/cash-flow-setup/delete/{cashFlowSetupId}")]
        public void Delete(int cashFlowSetupId)
        {
            try
            {
                this.CashFlowSetupContext.Delete(cashFlowSetupId);
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