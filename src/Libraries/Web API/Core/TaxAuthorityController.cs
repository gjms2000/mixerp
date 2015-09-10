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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Tax Authorities.
    /// </summary>
    [RoutePrefix("api/v1.5/core/tax-authority")]
    public class TaxAuthorityController : ApiController
    {
        /// <summary>
        ///     The TaxAuthority data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Core.Data.TaxAuthority TaxAuthorityContext;

        public TaxAuthorityController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.TaxAuthorityContext = new MixERP.Net.Schemas.Core.Data.TaxAuthority
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
        ///     Counts the number of tax authorities.
        /// </summary>
        /// <returns>Returns the count of the tax authorities.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/core/tax-authority/count")]
        public long Count()
        {
            try
            {
                return this.TaxAuthorityContext.Count();
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
        ///     Returns an instance of tax authority.
        /// </summary>
        /// <param name="taxAuthorityId">Enter TaxAuthorityId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{taxAuthorityId}")]
        [Route("~/api/core/tax-authority/{taxAuthorityId}")]
        public MixERP.Net.Entities.Core.TaxAuthority Get(int taxAuthorityId)
        {
            try
            {
                return this.TaxAuthorityContext.Get(taxAuthorityId);
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
        ///     Creates a paginated collection containing 25 tax authorities on each page, sorted by the property TaxAuthorityId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/core/tax-authority")]
        public IEnumerable<MixERP.Net.Entities.Core.TaxAuthority> GetPagedResult()
        {
            try
            {
                return this.TaxAuthorityContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 tax authorities on each page, sorted by the property TaxAuthorityId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/core/tax-authority/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.TaxAuthority> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.TaxAuthorityContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 tax authorities on each page, sorted by the property TaxAuthorityId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/core/tax-authority/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.TaxAuthority> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.TaxAuthorityContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of tax authorities.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of tax authorities.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/core/tax-authority/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.TaxAuthorityContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for tax authorities.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of tax authorities.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/tax-authority/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.TaxAuthorityContext.GetCustomFields();
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
        /// <param name="taxAuthority">Your instance of tax authorities class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{taxAuthority}")]
        [Route("~/api/core/tax-authority/add/{taxAuthority}")]
        public void Add(MixERP.Net.Entities.Core.TaxAuthority taxAuthority)
        {
            if (taxAuthority == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.TaxAuthorityContext.Add(taxAuthority);
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
        /// <param name="taxAuthority">Your instance of Account class to edit.</param>
        /// <param name="taxAuthorityId">Enter the value for TaxAuthorityId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{taxAuthorityId}/{taxAuthority}")]
        [Route("~/api/core/tax-authority/edit/{taxAuthorityId}/{taxAuthority}")]
        public void Edit(int taxAuthorityId, MixERP.Net.Entities.Core.TaxAuthority taxAuthority)
        {
            if (taxAuthority == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.TaxAuthorityContext.Update(taxAuthority, taxAuthorityId);
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
        ///     Deletes an existing instance of Account class via TaxAuthorityId.
        /// </summary>
        /// <param name="taxAuthorityId">Enter the value for TaxAuthorityId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{taxAuthorityId}")]
        [Route("~/api/core/tax-authority/delete/{taxAuthorityId}")]
        public void Delete(int taxAuthorityId)
        {
            try
            {
                this.TaxAuthorityContext.Delete(taxAuthorityId);
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