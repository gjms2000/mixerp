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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Identification Types.
    /// </summary>
    [RoutePrefix("api/v1.5/core/identification-type")]
    public class IdentificationTypeController : ApiController
    {
        /// <summary>
        ///     The IdentificationType data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Core.Data.IdentificationType IdentificationTypeContext;

        public IdentificationTypeController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.IdentificationTypeContext = new MixERP.Net.Schemas.Core.Data.IdentificationType
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
        ///     Counts the number of identification types.
        /// </summary>
        /// <returns>Returns the count of the identification types.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/core/identification-type/count")]
        public long Count()
        {
            try
            {
                return this.IdentificationTypeContext.Count();
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
        ///     Returns an instance of identification type.
        /// </summary>
        /// <param name="identificationTypeCode">Enter IdentificationTypeCode to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{identificationTypeCode}")]
        [Route("~/api/core/identification-type/{identificationTypeCode}")]
        public MixERP.Net.Entities.Core.IdentificationType Get(string identificationTypeCode)
        {
            try
            {
                return this.IdentificationTypeContext.Get(identificationTypeCode);
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
        [Route("~/api/core/identification-type/get")]
        public IEnumerable<MixERP.Net.Entities.Core.IdentificationType> Get([FromUri] string[] identificationTypeCodes)
        {
            try
            {
                return this.IdentificationTypeContext.Get(identificationTypeCodes);
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
        ///     Creates a paginated collection containing 25 identification types on each page, sorted by the property IdentificationTypeCode.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/core/identification-type")]
        public IEnumerable<MixERP.Net.Entities.Core.IdentificationType> GetPagedResult()
        {
            try
            {
                return this.IdentificationTypeContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 identification types on each page, sorted by the property IdentificationTypeCode.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/core/identification-type/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.IdentificationType> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.IdentificationTypeContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 identification types on each page, sorted by the property IdentificationTypeCode.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/core/identification-type/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.IdentificationType> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.IdentificationTypeContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of identification types.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of identification types.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/core/identification-type/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.IdentificationTypeContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for identification types.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of identification types.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/identification-type/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.IdentificationTypeContext.GetCustomFields(null);
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
        ///     A custom field is a user defined field for identification types.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of identification types.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/identification-type/custom-fields/{resourceId}")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
        {
            try
            {
                return this.IdentificationTypeContext.GetCustomFields(resourceId);
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
        ///     Adds or edits your instance of IdentificationType class.
        /// </summary>
        /// <param name="identificationType">Your instance of identification types class to add or edit.</param>
        [AcceptVerbs("PUT")]
        [Route("add-or-edit")]
        [Route("~/api/core/identification-type/add-or-edit")]
        public void AddOrEdit([FromBody]MixERP.Net.Entities.Core.IdentificationType identificationType)
        {
            if (identificationType == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.IdentificationTypeContext.AddOrEdit(identificationType);
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
        ///     Adds your instance of IdentificationType class.
        /// </summary>
        /// <param name="identificationType">Your instance of identification types class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{identificationType}")]
        [Route("~/api/core/identification-type/add/{identificationType}")]
        public void Add(MixERP.Net.Entities.Core.IdentificationType identificationType)
        {
            if (identificationType == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.IdentificationTypeContext.Add(identificationType);
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
        ///     Edits existing record with your instance of IdentificationType class.
        /// </summary>
        /// <param name="identificationType">Your instance of IdentificationType class to edit.</param>
        /// <param name="identificationTypeCode">Enter the value for IdentificationTypeCode in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{identificationTypeCode}")]
        [Route("~/api/core/identification-type/edit/{identificationTypeCode}")]
        public void Edit(string identificationTypeCode, [FromBody] MixERP.Net.Entities.Core.IdentificationType identificationType)
        {
            if (identificationType == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.IdentificationTypeContext.Update(identificationType, identificationTypeCode);
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
        ///     Deletes an existing instance of IdentificationType class via IdentificationTypeCode.
        /// </summary>
        /// <param name="identificationTypeCode">Enter the value for IdentificationTypeCode in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{identificationTypeCode}")]
        [Route("~/api/core/identification-type/delete/{identificationTypeCode}")]
        public void Delete(string identificationTypeCode)
        {
            try
            {
                this.IdentificationTypeContext.Delete(identificationTypeCode);
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