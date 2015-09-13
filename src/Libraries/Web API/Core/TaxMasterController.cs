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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Tax Masters.
    /// </summary>
    [RoutePrefix("api/v1.5/core/tax-master")]
    public class TaxMasterController : ApiController
    {
        /// <summary>
        ///     The TaxMaster data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Core.Data.TaxMaster TaxMasterContext;

        public TaxMasterController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.TaxMasterContext = new MixERP.Net.Schemas.Core.Data.TaxMaster
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
        ///     Counts the number of tax masters.
        /// </summary>
        /// <returns>Returns the count of the tax masters.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/core/tax-master/count")]
        public long Count()
        {
            try
            {
                return this.TaxMasterContext.Count();
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
        ///     Returns an instance of tax master.
        /// </summary>
        /// <param name="taxMasterId">Enter TaxMasterId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{taxMasterId}")]
        [Route("~/api/core/tax-master/{taxMasterId}")]
        public MixERP.Net.Entities.Core.TaxMaster Get(int taxMasterId)
        {
            try
            {
                return this.TaxMasterContext.Get(taxMasterId);
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
        [Route("~/api/core/tax-master/get")]
        public IEnumerable<MixERP.Net.Entities.Core.TaxMaster> Get([FromUri] int[] taxMasterIds)
        {
            try
            {
                return this.TaxMasterContext.Get(taxMasterIds);
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
        ///     Creates a paginated collection containing 25 tax masters on each page, sorted by the property TaxMasterId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/core/tax-master")]
        public IEnumerable<MixERP.Net.Entities.Core.TaxMaster> GetPagedResult()
        {
            try
            {
                return this.TaxMasterContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 tax masters on each page, sorted by the property TaxMasterId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/core/tax-master/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.TaxMaster> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.TaxMasterContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 tax masters on each page, sorted by the property TaxMasterId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/core/tax-master/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.TaxMaster> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.TaxMasterContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of tax masters.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of tax masters.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/core/tax-master/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.TaxMasterContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for tax masters.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of tax masters.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/tax-master/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.TaxMasterContext.GetCustomFields(null);
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
        ///     A custom field is a user defined field for tax masters.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of tax masters.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/tax-master/custom-fields/{resourceId}")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
        {
            try
            {
                return this.TaxMasterContext.GetCustomFields(resourceId);
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
        ///     Adds or edits your instance of TaxMaster class.
        /// </summary>
        /// <param name="taxMaster">Your instance of tax masters class to add or edit.</param>
        [AcceptVerbs("PUT")]
        [Route("add-or-edit")]
        [Route("~/api/core/tax-master/add-or-edit")]
        public void AddOrEdit([FromBody]MixERP.Net.Entities.Core.TaxMaster taxMaster)
        {
            if (taxMaster == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.TaxMasterContext.AddOrEdit(taxMaster);
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
        ///     Adds your instance of TaxMaster class.
        /// </summary>
        /// <param name="taxMaster">Your instance of tax masters class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{taxMaster}")]
        [Route("~/api/core/tax-master/add/{taxMaster}")]
        public void Add(MixERP.Net.Entities.Core.TaxMaster taxMaster)
        {
            if (taxMaster == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.TaxMasterContext.Add(taxMaster);
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
        ///     Edits existing record with your instance of TaxMaster class.
        /// </summary>
        /// <param name="taxMaster">Your instance of TaxMaster class to edit.</param>
        /// <param name="taxMasterId">Enter the value for TaxMasterId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{taxMasterId}")]
        [Route("~/api/core/tax-master/edit/{taxMasterId}")]
        public void Edit(int taxMasterId, [FromBody] MixERP.Net.Entities.Core.TaxMaster taxMaster)
        {
            if (taxMaster == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.TaxMasterContext.Update(taxMaster, taxMasterId);
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
        ///     Deletes an existing instance of TaxMaster class via TaxMasterId.
        /// </summary>
        /// <param name="taxMasterId">Enter the value for TaxMasterId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{taxMasterId}")]
        [Route("~/api/core/tax-master/delete/{taxMasterId}")]
        public void Delete(int taxMasterId)
        {
            try
            {
                this.TaxMasterContext.Delete(taxMasterId);
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