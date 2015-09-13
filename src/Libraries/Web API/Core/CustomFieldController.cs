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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Custom Fields.
    /// </summary>
    [RoutePrefix("api/v1.5/core/custom-field")]
    public class CustomFieldController : ApiController
    {
        /// <summary>
        ///     The CustomField data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Core.Data.CustomField CustomFieldContext;

        public CustomFieldController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.CustomFieldContext = new MixERP.Net.Schemas.Core.Data.CustomField
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
        ///     Counts the number of custom fields.
        /// </summary>
        /// <returns>Returns the count of the custom fields.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/core/custom-field/count")]
        public long Count()
        {
            try
            {
                return this.CustomFieldContext.Count();
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
        ///     Returns an instance of custom field.
        /// </summary>
        /// <param name="customFieldId">Enter CustomFieldId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{customFieldId}")]
        [Route("~/api/core/custom-field/{customFieldId}")]
        public MixERP.Net.Entities.Core.CustomField Get(long customFieldId)
        {
            try
            {
                return this.CustomFieldContext.Get(customFieldId);
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
        [Route("~/api/core/custom-field/get")]
        public IEnumerable<MixERP.Net.Entities.Core.CustomField> Get([FromUri] long[] customFieldIds)
        {
            try
            {
                return this.CustomFieldContext.Get(customFieldIds);
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
        ///     Creates a paginated collection containing 25 custom fields on each page, sorted by the property CustomFieldId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/core/custom-field")]
        public IEnumerable<MixERP.Net.Entities.Core.CustomField> GetPagedResult()
        {
            try
            {
                return this.CustomFieldContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 custom fields on each page, sorted by the property CustomFieldId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/core/custom-field/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.CustomField> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.CustomFieldContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 custom fields on each page, sorted by the property CustomFieldId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/core/custom-field/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.CustomField> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.CustomFieldContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of custom fields.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of custom fields.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/core/custom-field/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.CustomFieldContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for custom fields.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of custom fields.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/custom-field/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.CustomFieldContext.GetCustomFields(null);
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
        ///     A custom field is a user defined field for custom fields.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of custom fields.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/custom-field/custom-fields/{resourceId}")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
        {
            try
            {
                return this.CustomFieldContext.GetCustomFields(resourceId);
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
        ///     Adds or edits your instance of CustomField class.
        /// </summary>
        /// <param name="customField">Your instance of custom fields class to add or edit.</param>
        [AcceptVerbs("PUT")]
        [Route("add-or-edit")]
        [Route("~/api/core/custom-field/add-or-edit")]
        public void AddOrEdit([FromBody]MixERP.Net.Entities.Core.CustomField customField)
        {
            if (customField == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.CustomFieldContext.AddOrEdit(customField);
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
        ///     Adds your instance of CustomField class.
        /// </summary>
        /// <param name="customField">Your instance of custom fields class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{customField}")]
        [Route("~/api/core/custom-field/add/{customField}")]
        public void Add(MixERP.Net.Entities.Core.CustomField customField)
        {
            if (customField == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.CustomFieldContext.Add(customField);
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
        ///     Edits existing record with your instance of CustomField class.
        /// </summary>
        /// <param name="customField">Your instance of CustomField class to edit.</param>
        /// <param name="customFieldId">Enter the value for CustomFieldId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{customFieldId}")]
        [Route("~/api/core/custom-field/edit/{customFieldId}")]
        public void Edit(long customFieldId, [FromBody] MixERP.Net.Entities.Core.CustomField customField)
        {
            if (customField == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.CustomFieldContext.Update(customField, customFieldId);
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
        ///     Deletes an existing instance of CustomField class via CustomFieldId.
        /// </summary>
        /// <param name="customFieldId">Enter the value for CustomFieldId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{customFieldId}")]
        [Route("~/api/core/custom-field/delete/{customFieldId}")]
        public void Delete(long customFieldId)
        {
            try
            {
                this.CustomFieldContext.Delete(customFieldId);
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