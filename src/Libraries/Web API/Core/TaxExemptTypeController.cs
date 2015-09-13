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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Tax Exempt Types.
    /// </summary>
    [RoutePrefix("api/v1.5/core/tax-exempt-type")]
    public class TaxExemptTypeController : ApiController
    {
        /// <summary>
        ///     The TaxExemptType data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Core.Data.TaxExemptType TaxExemptTypeContext;

        public TaxExemptTypeController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.TaxExemptTypeContext = new MixERP.Net.Schemas.Core.Data.TaxExemptType
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
        ///     Counts the number of tax exempt types.
        /// </summary>
        /// <returns>Returns the count of the tax exempt types.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/core/tax-exempt-type/count")]
        public long Count()
        {
            try
            {
                return this.TaxExemptTypeContext.Count();
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
        ///     Returns an instance of tax exempt type.
        /// </summary>
        /// <param name="taxExemptTypeId">Enter TaxExemptTypeId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{taxExemptTypeId}")]
        [Route("~/api/core/tax-exempt-type/{taxExemptTypeId}")]
        public MixERP.Net.Entities.Core.TaxExemptType Get(int taxExemptTypeId)
        {
            try
            {
                return this.TaxExemptTypeContext.Get(taxExemptTypeId);
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
        [Route("~/api/core/tax-exempt-type/get")]
        public IEnumerable<MixERP.Net.Entities.Core.TaxExemptType> Get([FromUri] int[] taxExemptTypeIds)
        {
            try
            {
                return this.TaxExemptTypeContext.Get(taxExemptTypeIds);
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
        ///     Creates a paginated collection containing 25 tax exempt types on each page, sorted by the property TaxExemptTypeId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/core/tax-exempt-type")]
        public IEnumerable<MixERP.Net.Entities.Core.TaxExemptType> GetPagedResult()
        {
            try
            {
                return this.TaxExemptTypeContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 tax exempt types on each page, sorted by the property TaxExemptTypeId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/core/tax-exempt-type/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.TaxExemptType> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.TaxExemptTypeContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 tax exempt types on each page, sorted by the property TaxExemptTypeId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/core/tax-exempt-type/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.TaxExemptType> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.TaxExemptTypeContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of tax exempt types.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of tax exempt types.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/core/tax-exempt-type/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.TaxExemptTypeContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for tax exempt types.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of tax exempt types.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/tax-exempt-type/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.TaxExemptTypeContext.GetCustomFields(null);
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
        ///     A custom field is a user defined field for tax exempt types.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of tax exempt types.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/tax-exempt-type/custom-fields/{resourceId}")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
        {
            try
            {
                return this.TaxExemptTypeContext.GetCustomFields(resourceId);
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
        ///     Adds or edits your instance of TaxExemptType class.
        /// </summary>
        /// <param name="taxExemptType">Your instance of tax exempt types class to add or edit.</param>
        [AcceptVerbs("PUT")]
        [Route("add-or-edit")]
        [Route("~/api/core/tax-exempt-type/add-or-edit")]
        public void AddOrEdit([FromBody]MixERP.Net.Entities.Core.TaxExemptType taxExemptType)
        {
            if (taxExemptType == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.TaxExemptTypeContext.AddOrEdit(taxExemptType);
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
        ///     Adds your instance of TaxExemptType class.
        /// </summary>
        /// <param name="taxExemptType">Your instance of tax exempt types class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{taxExemptType}")]
        [Route("~/api/core/tax-exempt-type/add/{taxExemptType}")]
        public void Add(MixERP.Net.Entities.Core.TaxExemptType taxExemptType)
        {
            if (taxExemptType == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.TaxExemptTypeContext.Add(taxExemptType);
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
        ///     Edits existing record with your instance of TaxExemptType class.
        /// </summary>
        /// <param name="taxExemptType">Your instance of TaxExemptType class to edit.</param>
        /// <param name="taxExemptTypeId">Enter the value for TaxExemptTypeId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{taxExemptTypeId}")]
        [Route("~/api/core/tax-exempt-type/edit/{taxExemptTypeId}")]
        public void Edit(int taxExemptTypeId, [FromBody] MixERP.Net.Entities.Core.TaxExemptType taxExemptType)
        {
            if (taxExemptType == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.TaxExemptTypeContext.Update(taxExemptType, taxExemptTypeId);
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
        ///     Deletes an existing instance of TaxExemptType class via TaxExemptTypeId.
        /// </summary>
        /// <param name="taxExemptTypeId">Enter the value for TaxExemptTypeId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{taxExemptTypeId}")]
        [Route("~/api/core/tax-exempt-type/delete/{taxExemptTypeId}")]
        public void Delete(int taxExemptTypeId)
        {
            try
            {
                this.TaxExemptTypeContext.Delete(taxExemptTypeId);
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