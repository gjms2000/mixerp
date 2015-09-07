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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Custom Field Forms.
    /// </summary>
    [RoutePrefix("api/v1.5/core/custom-field-form")]
    public class CustomFieldFormController : ApiController
    {
        /// <summary>
        ///     The CustomFieldForm data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Core.Data.CustomFieldForm CustomFieldFormContext;

        public CustomFieldFormController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.CustomFieldFormContext = new MixERP.Net.Schemas.Core.Data.CustomFieldForm
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
        ///     Counts the number of custom field forms.
        /// </summary>
        /// <returns>Returns the count of the custom field forms.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/core/custom-field-form/count")]
        public long Count()
        {
            try
            {
                return this.CustomFieldFormContext.Count();
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
        ///     Returns an instance of custom field form.
        /// </summary>
        /// <param name="formName">Enter FormName to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{formName}")]
        [Route("~/api/core/custom-field-form/{formName}")]
        public MixERP.Net.Entities.Core.CustomFieldForm Get(string formName)
        {
            try
            {
                return this.CustomFieldFormContext.Get(formName);
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
        ///     Creates a paginated collection containing 25 custom field forms on each page, sorted by the property FormName.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/core/custom-field-form")]
        public IEnumerable<MixERP.Net.Entities.Core.CustomFieldForm> GetPagedResult()
        {
            try
            {
                return this.CustomFieldFormContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 custom field forms on each page, sorted by the property FormName.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/core/custom-field-form/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.CustomFieldForm> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.CustomFieldFormContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 custom field forms on each page, sorted by the property FormName.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/core/custom-field-form/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.CustomFieldForm> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.CustomFieldFormContext.GetWhere(pageNumber, f);
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
        ///     Displayfields is a lightweight key/value collection of custom field forms.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of custom field forms.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/core/custom-field-form/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.CustomFieldFormContext.GetDisplayFields();
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
        /// <param name="customFieldForm">Your instance of custom field forms class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{customFieldForm}")]
        [Route("~/api/core/custom-field-form/add/{customFieldForm}")]
        public void Add(MixERP.Net.Entities.Core.CustomFieldForm customFieldForm)
        {
            if (customFieldForm == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.CustomFieldFormContext.Add(customFieldForm);
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
        /// <param name="customFieldForm">Your instance of Account class to edit.</param>
        /// <param name="formName">Enter the value for FormName in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{formName}/{customFieldForm}")]
        [Route("~/api/core/custom-field-form/edit/{formName}/{customFieldForm}")]
        public void Edit(string formName, MixERP.Net.Entities.Core.CustomFieldForm customFieldForm)
        {
            if (customFieldForm == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.CustomFieldFormContext.Update(customFieldForm, formName);
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
        ///     Deletes an existing instance of Account class via FormName.
        /// </summary>
        /// <param name="formName">Enter the value for FormName in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{formName}")]
        [Route("~/api/core/custom-field-form/delete/{formName}")]
        public void Delete(string formName)
        {
            try
            {
                this.CustomFieldFormContext.Delete(formName);
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