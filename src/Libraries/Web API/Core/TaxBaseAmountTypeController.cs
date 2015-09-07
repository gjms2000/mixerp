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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Tax Base Amount Types.
    /// </summary>
    [RoutePrefix("api/v1.5/core/tax-base-amount-type")]
    public class TaxBaseAmountTypeController : ApiController
    {
        /// <summary>
        ///     The TaxBaseAmountType data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Core.Data.TaxBaseAmountType TaxBaseAmountTypeContext;

        public TaxBaseAmountTypeController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.TaxBaseAmountTypeContext = new MixERP.Net.Schemas.Core.Data.TaxBaseAmountType
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
        ///     Counts the number of tax base amount types.
        /// </summary>
        /// <returns>Returns the count of the tax base amount types.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        public long Count()
        {
            try
            {
                return this.TaxBaseAmountTypeContext.Count();
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
        ///     Returns an instance of tax base amount type.
        /// </summary>
        /// <param name="taxBaseAmountTypeCode">Enter TaxBaseAmountTypeCode to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{taxBaseAmountTypeCode}")]
        public MixERP.Net.Entities.Core.TaxBaseAmountType Get(string taxBaseAmountTypeCode)
        {
            try
            {
                return this.TaxBaseAmountTypeContext.Get(taxBaseAmountTypeCode);
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
        ///     Creates a paginated collection containing 25 tax base amount types on each page, sorted by the property TaxBaseAmountTypeCode.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        public IEnumerable<MixERP.Net.Entities.Core.TaxBaseAmountType> GetPagedResult()
        {
            try
            {
                return this.TaxBaseAmountTypeContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 tax base amount types on each page, sorted by the property TaxBaseAmountTypeCode.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.TaxBaseAmountType> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.TaxBaseAmountTypeContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 tax base amount types on each page, sorted by the property TaxBaseAmountTypeCode.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.TaxBaseAmountType> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.TaxBaseAmountTypeContext.GetWhere(pageNumber, f);
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
        ///     Displayfields is a lightweight key/value collection of tax base amount types.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of tax base amount types.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.TaxBaseAmountTypeContext.GetDisplayFields();
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
        /// <param name="taxBaseAmountType">Your instance of tax base amount types class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{taxBaseAmountType}")]
        public void Add(MixERP.Net.Entities.Core.TaxBaseAmountType taxBaseAmountType)
        {
            if (taxBaseAmountType == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.TaxBaseAmountTypeContext.Add(taxBaseAmountType);
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
        /// <param name="taxBaseAmountType">Your instance of Account class to edit.</param>
        /// <param name="taxBaseAmountTypeCode">Enter the value for TaxBaseAmountTypeCode in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{taxBaseAmountTypeCode}/{taxBaseAmountType}")]
        public void Edit(string taxBaseAmountTypeCode, MixERP.Net.Entities.Core.TaxBaseAmountType taxBaseAmountType)
        {
            if (taxBaseAmountType == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.TaxBaseAmountTypeContext.Update(taxBaseAmountType, taxBaseAmountTypeCode);
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
        ///     Deletes an existing instance of Account class via TaxBaseAmountTypeCode.
        /// </summary>
        /// <param name="taxBaseAmountTypeCode">Enter the value for TaxBaseAmountTypeCode in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{taxBaseAmountTypeCode}")]
        public void Delete(string taxBaseAmountTypeCode)
        {
            try
            {
                this.TaxBaseAmountTypeContext.Delete(taxBaseAmountTypeCode);
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