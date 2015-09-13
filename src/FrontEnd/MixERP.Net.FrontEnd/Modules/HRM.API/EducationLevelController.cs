using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using MixERP.Net.EntityParser;
using Newtonsoft.Json;
using PetaPoco;

namespace MixERP.Net.Api.HRM
{
    /// <summary>
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Education Levels.
    /// </summary>
    [RoutePrefix("api/v1.5/hrm/education-level")]
    public class EducationLevelController : ApiController
    {
        /// <summary>
        ///     The EducationLevel data context.
        /// </summary>
        private readonly MixERP.Net.Core.Modules.HRM.Data.EducationLevel EducationLevelContext;

        public EducationLevelController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.EducationLevelContext = new MixERP.Net.Core.Modules.HRM.Data.EducationLevel
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
        ///     Counts the number of education levels.
        /// </summary>
        /// <returns>Returns the count of the education levels.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/hrm/education-level/count")]
        public long Count()
        {
            try
            {
                return this.EducationLevelContext.Count();
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
        ///     Returns an instance of education level.
        /// </summary>
        /// <param name="educationLevelId">Enter EducationLevelId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{educationLevelId}")]
        [Route("~/api/hrm/education-level/{educationLevelId}")]
        public MixERP.Net.Entities.HRM.EducationLevel Get(int educationLevelId)
        {
            try
            {
                return this.EducationLevelContext.Get(educationLevelId);
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
        [Route("~/api/hrm/education-level/get")]
        public IEnumerable<MixERP.Net.Entities.HRM.EducationLevel> Get([FromUri] int[] educationLevelIds)
        {
            try
            {
                return this.EducationLevelContext.Get(educationLevelIds);
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
        ///     Creates a paginated collection containing 25 education levels on each page, sorted by the property EducationLevelId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/hrm/education-level")]
        public IEnumerable<MixERP.Net.Entities.HRM.EducationLevel> GetPagedResult()
        {
            try
            {
                return this.EducationLevelContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 education levels on each page, sorted by the property EducationLevelId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/hrm/education-level/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.HRM.EducationLevel> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.EducationLevelContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 education levels on each page, sorted by the property EducationLevelId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/hrm/education-level/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.HRM.EducationLevel> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.EducationLevelContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of education levels.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of education levels.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/hrm/education-level/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.EducationLevelContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for education levels.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of education levels.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/hrm/education-level/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.EducationLevelContext.GetCustomFields(null);
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
        ///     A custom field is a user defined field for education levels.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of education levels.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/hrm/education-level/custom-fields/{resourceId}")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
        {
            try
            {
                return this.EducationLevelContext.GetCustomFields(resourceId);
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
        ///     Adds or edits your instance of EducationLevel class.
        /// </summary>
        /// <param name="educationLevel">Your instance of education levels class to add or edit.</param>
        [AcceptVerbs("PUT")]
        [Route("add-or-edit")]
        [Route("~/api/hrm/education-level/add-or-edit")]
        public void AddOrEdit([FromBody]MixERP.Net.Entities.HRM.EducationLevel educationLevel)
        {
            if (educationLevel == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.EducationLevelContext.AddOrEdit(educationLevel);
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
        ///     Adds your instance of EducationLevel class.
        /// </summary>
        /// <param name="educationLevel">Your instance of education levels class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{educationLevel}")]
        [Route("~/api/hrm/education-level/add/{educationLevel}")]
        public void Add(MixERP.Net.Entities.HRM.EducationLevel educationLevel)
        {
            if (educationLevel == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.EducationLevelContext.Add(educationLevel);
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
        ///     Edits existing record with your instance of EducationLevel class.
        /// </summary>
        /// <param name="educationLevel">Your instance of EducationLevel class to edit.</param>
        /// <param name="educationLevelId">Enter the value for EducationLevelId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{educationLevelId}")]
        [Route("~/api/hrm/education-level/edit/{educationLevelId}")]
        public void Edit(int educationLevelId, [FromBody] MixERP.Net.Entities.HRM.EducationLevel educationLevel)
        {
            if (educationLevel == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.EducationLevelContext.Update(educationLevel, educationLevelId);
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
        ///     Deletes an existing instance of EducationLevel class via EducationLevelId.
        /// </summary>
        /// <param name="educationLevelId">Enter the value for EducationLevelId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{educationLevelId}")]
        [Route("~/api/hrm/education-level/delete/{educationLevelId}")]
        public void Delete(int educationLevelId)
        {
            try
            {
                this.EducationLevelContext.Delete(educationLevelId);
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