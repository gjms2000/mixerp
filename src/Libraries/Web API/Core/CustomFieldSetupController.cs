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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Custom Field Setups.
    /// </summary>
    [RoutePrefix("api/v1.5/core/custom-field-setup")]
    public class CustomFieldSetupController : ApiController
    {
        /// <summary>
        ///     The CustomFieldSetup data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Core.Data.CustomFieldSetup CustomFieldSetupContext;

        public CustomFieldSetupController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.CustomFieldSetupContext = new MixERP.Net.Schemas.Core.Data.CustomFieldSetup
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
        ///     Counts the number of custom field setups.
        /// </summary>
        /// <returns>Returns the count of the custom field setups.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/core/custom-field-setup/count")]
        public long Count()
        {
            try
            {
                return this.CustomFieldSetupContext.Count();
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
        ///     Returns an instance of custom field setup.
        /// </summary>
        /// <param name="customFieldSetupId">Enter CustomFieldSetupId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{customFieldSetupId}")]
        [Route("~/api/core/custom-field-setup/{customFieldSetupId}")]
        public MixERP.Net.Entities.Core.CustomFieldSetup Get(int customFieldSetupId)
        {
            try
            {
                return this.CustomFieldSetupContext.Get(customFieldSetupId);
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
        ///     Creates a paginated collection containing 25 custom field setups on each page, sorted by the property CustomFieldSetupId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/core/custom-field-setup")]
        public IEnumerable<MixERP.Net.Entities.Core.CustomFieldSetup> GetPagedResult()
        {
            try
            {
                return this.CustomFieldSetupContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 custom field setups on each page, sorted by the property CustomFieldSetupId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/core/custom-field-setup/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.CustomFieldSetup> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.CustomFieldSetupContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 custom field setups on each page, sorted by the property CustomFieldSetupId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/core/custom-field-setup/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.CustomFieldSetup> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.CustomFieldSetupContext.GetWhere(pageNumber, f);
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
        ///     Displayfields is a lightweight key/value collection of custom field setups.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of custom field setups.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/core/custom-field-setup/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.CustomFieldSetupContext.GetDisplayFields();
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
        /// <param name="customFieldSetup">Your instance of custom field setups class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{customFieldSetup}")]
        [Route("~/api/core/custom-field-setup/add/{customFieldSetup}")]
        public void Add(MixERP.Net.Entities.Core.CustomFieldSetup customFieldSetup)
        {
            if (customFieldSetup == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.CustomFieldSetupContext.Add(customFieldSetup);
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
        /// <param name="customFieldSetup">Your instance of Account class to edit.</param>
        /// <param name="customFieldSetupId">Enter the value for CustomFieldSetupId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{customFieldSetupId}/{customFieldSetup}")]
        [Route("~/api/core/custom-field-setup/edit/{customFieldSetupId}/{customFieldSetup}")]
        public void Edit(int customFieldSetupId, MixERP.Net.Entities.Core.CustomFieldSetup customFieldSetup)
        {
            if (customFieldSetup == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.CustomFieldSetupContext.Update(customFieldSetup, customFieldSetupId);
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
        ///     Deletes an existing instance of Account class via CustomFieldSetupId.
        /// </summary>
        /// <param name="customFieldSetupId">Enter the value for CustomFieldSetupId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{customFieldSetupId}")]
        [Route("~/api/core/custom-field-setup/delete/{customFieldSetupId}")]
        public void Delete(int customFieldSetupId)
        {
            try
            {
                this.CustomFieldSetupContext.Delete(customFieldSetupId);
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