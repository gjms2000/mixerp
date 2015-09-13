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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Frequency Setups.
    /// </summary>
    [RoutePrefix("api/v1.5/core/frequency-setup")]
    public class FrequencySetupController : ApiController
    {
        /// <summary>
        ///     The FrequencySetup data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Core.Data.FrequencySetup FrequencySetupContext;

        public FrequencySetupController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.FrequencySetupContext = new MixERP.Net.Schemas.Core.Data.FrequencySetup
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
        ///     Counts the number of frequency setups.
        /// </summary>
        /// <returns>Returns the count of the frequency setups.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/core/frequency-setup/count")]
        public long Count()
        {
            try
            {
                return this.FrequencySetupContext.Count();
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
        ///     Returns an instance of frequency setup.
        /// </summary>
        /// <param name="frequencySetupId">Enter FrequencySetupId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{frequencySetupId}")]
        [Route("~/api/core/frequency-setup/{frequencySetupId}")]
        public MixERP.Net.Entities.Core.FrequencySetup Get(int frequencySetupId)
        {
            try
            {
                return this.FrequencySetupContext.Get(frequencySetupId);
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
        [Route("~/api/core/frequency-setup/get")]
        public IEnumerable<MixERP.Net.Entities.Core.FrequencySetup> Get([FromUri] int[] frequencySetupIds)
        {
            try
            {
                return this.FrequencySetupContext.Get(frequencySetupIds);
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
        ///     Creates a paginated collection containing 25 frequency setups on each page, sorted by the property FrequencySetupId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/core/frequency-setup")]
        public IEnumerable<MixERP.Net.Entities.Core.FrequencySetup> GetPagedResult()
        {
            try
            {
                return this.FrequencySetupContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 frequency setups on each page, sorted by the property FrequencySetupId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/core/frequency-setup/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.FrequencySetup> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.FrequencySetupContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 frequency setups on each page, sorted by the property FrequencySetupId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/core/frequency-setup/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.FrequencySetup> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.FrequencySetupContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of frequency setups.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of frequency setups.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/core/frequency-setup/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.FrequencySetupContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for frequency setups.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of frequency setups.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/frequency-setup/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.FrequencySetupContext.GetCustomFields(null);
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
        ///     A custom field is a user defined field for frequency setups.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of frequency setups.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/frequency-setup/custom-fields/{resourceId}")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
        {
            try
            {
                return this.FrequencySetupContext.GetCustomFields(resourceId);
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
        ///     Adds or edits your instance of FrequencySetup class.
        /// </summary>
        /// <param name="frequencySetup">Your instance of frequency setups class to add or edit.</param>
        [AcceptVerbs("PUT")]
        [Route("add-or-edit")]
        [Route("~/api/core/frequency-setup/add-or-edit")]
        public void AddOrEdit([FromBody]MixERP.Net.Entities.Core.FrequencySetup frequencySetup)
        {
            if (frequencySetup == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.FrequencySetupContext.AddOrEdit(frequencySetup);
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
        ///     Adds your instance of FrequencySetup class.
        /// </summary>
        /// <param name="frequencySetup">Your instance of frequency setups class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{frequencySetup}")]
        [Route("~/api/core/frequency-setup/add/{frequencySetup}")]
        public void Add(MixERP.Net.Entities.Core.FrequencySetup frequencySetup)
        {
            if (frequencySetup == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.FrequencySetupContext.Add(frequencySetup);
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
        ///     Edits existing record with your instance of FrequencySetup class.
        /// </summary>
        /// <param name="frequencySetup">Your instance of FrequencySetup class to edit.</param>
        /// <param name="frequencySetupId">Enter the value for FrequencySetupId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{frequencySetupId}")]
        [Route("~/api/core/frequency-setup/edit/{frequencySetupId}")]
        public void Edit(int frequencySetupId, [FromBody] MixERP.Net.Entities.Core.FrequencySetup frequencySetup)
        {
            if (frequencySetup == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.FrequencySetupContext.Update(frequencySetup, frequencySetupId);
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
        ///     Deletes an existing instance of FrequencySetup class via FrequencySetupId.
        /// </summary>
        /// <param name="frequencySetupId">Enter the value for FrequencySetupId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{frequencySetupId}")]
        [Route("~/api/core/frequency-setup/delete/{frequencySetupId}")]
        public void Delete(int frequencySetupId)
        {
            try
            {
                this.FrequencySetupContext.Delete(frequencySetupId);
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