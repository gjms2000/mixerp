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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Zip Code Types.
    /// </summary>
    [RoutePrefix("api/v1.5/core/zip-code-type")]
    public class ZipCodeTypeController : ApiController
    {
        /// <summary>
        ///     The ZipCodeType data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Core.Data.ZipCodeType ZipCodeTypeContext;

        public ZipCodeTypeController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.ZipCodeTypeContext = new MixERP.Net.Schemas.Core.Data.ZipCodeType
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
        ///     Counts the number of zip code types.
        /// </summary>
        /// <returns>Returns the count of the zip code types.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/core/zip-code-type/count")]
        public long Count()
        {
            try
            {
                return this.ZipCodeTypeContext.Count();
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
        ///     Returns an instance of zip code type.
        /// </summary>
        /// <param name="zipCodeTypeId">Enter ZipCodeTypeId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{zipCodeTypeId}")]
        [Route("~/api/core/zip-code-type/{zipCodeTypeId}")]
        public MixERP.Net.Entities.Core.ZipCodeType Get(int zipCodeTypeId)
        {
            try
            {
                return this.ZipCodeTypeContext.Get(zipCodeTypeId);
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
        [Route("~/api/core/zip-code-type/get")]
        public IEnumerable<MixERP.Net.Entities.Core.ZipCodeType> Get([FromUri] int[] zipCodeTypeIds)
        {
            try
            {
                return this.ZipCodeTypeContext.Get(zipCodeTypeIds);
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
        ///     Creates a paginated collection containing 25 zip code types on each page, sorted by the property ZipCodeTypeId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/core/zip-code-type")]
        public IEnumerable<MixERP.Net.Entities.Core.ZipCodeType> GetPagedResult()
        {
            try
            {
                return this.ZipCodeTypeContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 zip code types on each page, sorted by the property ZipCodeTypeId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/core/zip-code-type/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.ZipCodeType> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.ZipCodeTypeContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 zip code types on each page, sorted by the property ZipCodeTypeId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/core/zip-code-type/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.ZipCodeType> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.ZipCodeTypeContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of zip code types.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of zip code types.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/core/zip-code-type/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.ZipCodeTypeContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for zip code types.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of zip code types.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/zip-code-type/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.ZipCodeTypeContext.GetCustomFields(null);
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
        ///     A custom field is a user defined field for zip code types.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of zip code types.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/zip-code-type/custom-fields/{resourceId}")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
        {
            try
            {
                return this.ZipCodeTypeContext.GetCustomFields(resourceId);
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
        ///     Adds or edits your instance of ZipCodeType class.
        /// </summary>
        /// <param name="zipCodeType">Your instance of zip code types class to add or edit.</param>
        [AcceptVerbs("PUT")]
        [Route("add-or-edit")]
        [Route("~/api/core/zip-code-type/add-or-edit")]
        public void AddOrEdit([FromBody]MixERP.Net.Entities.Core.ZipCodeType zipCodeType)
        {
            if (zipCodeType == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.ZipCodeTypeContext.AddOrEdit(zipCodeType);
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
        ///     Adds your instance of ZipCodeType class.
        /// </summary>
        /// <param name="zipCodeType">Your instance of zip code types class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{zipCodeType}")]
        [Route("~/api/core/zip-code-type/add/{zipCodeType}")]
        public void Add(MixERP.Net.Entities.Core.ZipCodeType zipCodeType)
        {
            if (zipCodeType == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.ZipCodeTypeContext.Add(zipCodeType);
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
        ///     Edits existing record with your instance of ZipCodeType class.
        /// </summary>
        /// <param name="zipCodeType">Your instance of ZipCodeType class to edit.</param>
        /// <param name="zipCodeTypeId">Enter the value for ZipCodeTypeId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{zipCodeTypeId}")]
        [Route("~/api/core/zip-code-type/edit/{zipCodeTypeId}")]
        public void Edit(int zipCodeTypeId, [FromBody] MixERP.Net.Entities.Core.ZipCodeType zipCodeType)
        {
            if (zipCodeType == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.ZipCodeTypeContext.Update(zipCodeType, zipCodeTypeId);
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
        ///     Deletes an existing instance of ZipCodeType class via ZipCodeTypeId.
        /// </summary>
        /// <param name="zipCodeTypeId">Enter the value for ZipCodeTypeId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{zipCodeTypeId}")]
        [Route("~/api/core/zip-code-type/delete/{zipCodeTypeId}")]
        public void Delete(int zipCodeTypeId)
        {
            try
            {
                this.ZipCodeTypeContext.Delete(zipCodeTypeId);
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