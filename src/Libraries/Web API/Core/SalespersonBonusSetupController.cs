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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Salesperson Bonus Setups.
    /// </summary>
    [RoutePrefix("api/v1.5/core/salesperson-bonus-setup")]
    public class SalespersonBonusSetupController : ApiController
    {
        /// <summary>
        ///     The SalespersonBonusSetup data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Core.Data.SalespersonBonusSetup SalespersonBonusSetupContext;

        public SalespersonBonusSetupController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.SalespersonBonusSetupContext = new MixERP.Net.Schemas.Core.Data.SalespersonBonusSetup
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
        ///     Counts the number of salesperson bonus setups.
        /// </summary>
        /// <returns>Returns the count of the salesperson bonus setups.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/core/salesperson-bonus-setup/count")]
        public long Count()
        {
            try
            {
                return this.SalespersonBonusSetupContext.Count();
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
        ///     Returns an instance of salesperson bonus setup.
        /// </summary>
        /// <param name="salespersonBonusSetupId">Enter SalespersonBonusSetupId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{salespersonBonusSetupId}")]
        [Route("~/api/core/salesperson-bonus-setup/{salespersonBonusSetupId}")]
        public MixERP.Net.Entities.Core.SalespersonBonusSetup Get(int salespersonBonusSetupId)
        {
            try
            {
                return this.SalespersonBonusSetupContext.Get(salespersonBonusSetupId);
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
        ///     Creates a paginated collection containing 25 salesperson bonus setups on each page, sorted by the property SalespersonBonusSetupId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/core/salesperson-bonus-setup")]
        public IEnumerable<MixERP.Net.Entities.Core.SalespersonBonusSetup> GetPagedResult()
        {
            try
            {
                return this.SalespersonBonusSetupContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 salesperson bonus setups on each page, sorted by the property SalespersonBonusSetupId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/core/salesperson-bonus-setup/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.SalespersonBonusSetup> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.SalespersonBonusSetupContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 salesperson bonus setups on each page, sorted by the property SalespersonBonusSetupId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/core/salesperson-bonus-setup/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.SalespersonBonusSetup> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.SalespersonBonusSetupContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of salesperson bonus setups.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of salesperson bonus setups.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/core/salesperson-bonus-setup/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.SalespersonBonusSetupContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for salesperson bonus setups.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of salesperson bonus setups.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/salesperson-bonus-setup/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.SalespersonBonusSetupContext.GetCustomFields();
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
        /// <param name="salespersonBonusSetup">Your instance of salesperson bonus setups class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{salespersonBonusSetup}")]
        [Route("~/api/core/salesperson-bonus-setup/add/{salespersonBonusSetup}")]
        public void Add(MixERP.Net.Entities.Core.SalespersonBonusSetup salespersonBonusSetup)
        {
            if (salespersonBonusSetup == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.SalespersonBonusSetupContext.Add(salespersonBonusSetup);
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
        /// <param name="salespersonBonusSetup">Your instance of Account class to edit.</param>
        /// <param name="salespersonBonusSetupId">Enter the value for SalespersonBonusSetupId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{salespersonBonusSetupId}/{salespersonBonusSetup}")]
        [Route("~/api/core/salesperson-bonus-setup/edit/{salespersonBonusSetupId}/{salespersonBonusSetup}")]
        public void Edit(int salespersonBonusSetupId, MixERP.Net.Entities.Core.SalespersonBonusSetup salespersonBonusSetup)
        {
            if (salespersonBonusSetup == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.SalespersonBonusSetupContext.Update(salespersonBonusSetup, salespersonBonusSetupId);
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
        ///     Deletes an existing instance of Account class via SalespersonBonusSetupId.
        /// </summary>
        /// <param name="salespersonBonusSetupId">Enter the value for SalespersonBonusSetupId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{salespersonBonusSetupId}")]
        [Route("~/api/core/salesperson-bonus-setup/delete/{salespersonBonusSetupId}")]
        public void Delete(int salespersonBonusSetupId)
        {
            try
            {
                this.SalespersonBonusSetupContext.Delete(salespersonBonusSetupId);
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