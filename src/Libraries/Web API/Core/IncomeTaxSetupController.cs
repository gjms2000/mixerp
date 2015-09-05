using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using PetaPoco;

namespace MixERP.Net.Api.Core
{
    /// <summary>
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Income Tax Setups.
    /// </summary>
    [RoutePrefix("api/v1.5/core/income-tax-setup")]
    public class IncomeTaxSetupController : ApiController
    {
        /// <summary>
        ///     The IncomeTaxSetup data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Core.Data.IncomeTaxSetup IncomeTaxSetupContext;

        public IncomeTaxSetupController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.IncomeTaxSetupContext = new MixERP.Net.Schemas.Core.Data.IncomeTaxSetup
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
        ///     Counts the number of income tax setups.
        /// </summary>
        /// <returns>Returns the count of the income tax setups.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        public long Count()
        {
            try
            {
                return this.IncomeTaxSetupContext.Count();
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
        ///     Returns an instance of income tax setup.
        /// </summary>
        /// <param name="incomeTaxSetupId">Enter IncomeTaxSetupId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{incomeTaxSetupId}")]
        public MixERP.Net.Entities.Core.IncomeTaxSetup Get(int incomeTaxSetupId)
        {
            try
            {
                return this.IncomeTaxSetupContext.Get(incomeTaxSetupId);
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
        ///     Creates a paginated collection containing 25 income tax setups on each page, sorted by the property IncomeTaxSetupId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        public IEnumerable<MixERP.Net.Entities.Core.IncomeTaxSetup> GetPagedResult()
        {
            try
            {
                return this.IncomeTaxSetupContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 income tax setups on each page, sorted by the property IncomeTaxSetupId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.IncomeTaxSetup> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.IncomeTaxSetupContext.GetPagedResult(pageNumber);
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
        ///     Displayfields is a lightweight key/value collection of income tax setups.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of income tax setups.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.IncomeTaxSetupContext.GetDisplayFields();
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
        /// <param name="incomeTaxSetup">Your instance of income tax setups class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{incomeTaxSetup}")]
        public void Add(MixERP.Net.Entities.Core.IncomeTaxSetup incomeTaxSetup)
        {
            if (incomeTaxSetup == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.IncomeTaxSetupContext.Add(incomeTaxSetup);
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
        /// <param name="incomeTaxSetup">Your instance of Account class to edit.</param>
        /// <param name="incomeTaxSetupId">Enter the value for IncomeTaxSetupId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{incomeTaxSetupId}/{incomeTaxSetup}")]
        public void Edit(int incomeTaxSetupId, MixERP.Net.Entities.Core.IncomeTaxSetup incomeTaxSetup)
        {
            if (incomeTaxSetup == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.IncomeTaxSetupContext.Update(incomeTaxSetup, incomeTaxSetupId);
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
        ///     Deletes an existing instance of Account class via IncomeTaxSetupId.
        /// </summary>
        /// <param name="incomeTaxSetupId">Enter the value for IncomeTaxSetupId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{incomeTaxSetupId}")]
        public void Delete(int incomeTaxSetupId)
        {
            try
            {
                this.IncomeTaxSetupContext.Delete(incomeTaxSetupId);
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