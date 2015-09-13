using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using MixERP.Net.EntityParser;
using Newtonsoft.Json;
using PetaPoco;

namespace MixERP.Net.Api.Office
{
    /// <summary>
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Configurations.
    /// </summary>
    [RoutePrefix("api/v1.5/office/configuration")]
    public class ConfigurationController : ApiController
    {
        /// <summary>
        ///     The Configuration data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Office.Data.Configuration ConfigurationContext;

        public ConfigurationController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.ConfigurationContext = new MixERP.Net.Schemas.Office.Data.Configuration
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
        ///     Counts the number of configurations.
        /// </summary>
        /// <returns>Returns the count of the configurations.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/office/configuration/count")]
        public long Count()
        {
            try
            {
                return this.ConfigurationContext.Count();
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
        ///     Returns an instance of configuration.
        /// </summary>
        /// <param name="configurationId">Enter ConfigurationId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{configurationId}")]
        [Route("~/api/office/configuration/{configurationId}")]
        public MixERP.Net.Entities.Office.Configuration Get(int configurationId)
        {
            try
            {
                return this.ConfigurationContext.Get(configurationId);
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
        [Route("~/api/office/configuration/get")]
        public IEnumerable<MixERP.Net.Entities.Office.Configuration> Get([FromUri] int[] configurationIds)
        {
            try
            {
                return this.ConfigurationContext.Get(configurationIds);
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
        ///     Creates a paginated collection containing 25 configurations on each page, sorted by the property ConfigurationId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/office/configuration")]
        public IEnumerable<MixERP.Net.Entities.Office.Configuration> GetPagedResult()
        {
            try
            {
                return this.ConfigurationContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 configurations on each page, sorted by the property ConfigurationId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/office/configuration/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Office.Configuration> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.ConfigurationContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 configurations on each page, sorted by the property ConfigurationId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/office/configuration/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Office.Configuration> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.ConfigurationContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of configurations.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of configurations.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/office/configuration/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.ConfigurationContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for configurations.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of configurations.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/office/configuration/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.ConfigurationContext.GetCustomFields(null);
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
        ///     A custom field is a user defined field for configurations.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of configurations.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/office/configuration/custom-fields/{resourceId}")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
        {
            try
            {
                return this.ConfigurationContext.GetCustomFields(resourceId);
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
        ///     Adds or edits your instance of Configuration class.
        /// </summary>
        /// <param name="configuration">Your instance of configurations class to add or edit.</param>
        [AcceptVerbs("PUT")]
        [Route("add-or-edit")]
        [Route("~/api/office/configuration/add-or-edit")]
        public void AddOrEdit([FromBody]MixERP.Net.Entities.Office.Configuration configuration)
        {
            if (configuration == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.ConfigurationContext.AddOrEdit(configuration);
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
        ///     Adds your instance of Configuration class.
        /// </summary>
        /// <param name="configuration">Your instance of configurations class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{configuration}")]
        [Route("~/api/office/configuration/add/{configuration}")]
        public void Add(MixERP.Net.Entities.Office.Configuration configuration)
        {
            if (configuration == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.ConfigurationContext.Add(configuration);
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
        ///     Edits existing record with your instance of Configuration class.
        /// </summary>
        /// <param name="configuration">Your instance of Configuration class to edit.</param>
        /// <param name="configurationId">Enter the value for ConfigurationId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{configurationId}")]
        [Route("~/api/office/configuration/edit/{configurationId}")]
        public void Edit(int configurationId, [FromBody] MixERP.Net.Entities.Office.Configuration configuration)
        {
            if (configuration == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.ConfigurationContext.Update(configuration, configurationId);
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
        ///     Deletes an existing instance of Configuration class via ConfigurationId.
        /// </summary>
        /// <param name="configurationId">Enter the value for ConfigurationId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{configurationId}")]
        [Route("~/api/office/configuration/delete/{configurationId}")]
        public void Delete(int configurationId)
        {
            try
            {
                this.ConfigurationContext.Delete(configurationId);
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