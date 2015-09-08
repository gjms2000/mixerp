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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Employee Experiences.
    /// </summary>
    [RoutePrefix("api/v1.5/hrm/employee-experience")]
    public class EmployeeExperienceController : ApiController
    {
        /// <summary>
        ///     The EmployeeExperience data context.
        /// </summary>
        private readonly MixERP.Net.Core.Modules.HRM.Data.EmployeeExperience EmployeeExperienceContext;

        public EmployeeExperienceController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.EmployeeExperienceContext = new MixERP.Net.Core.Modules.HRM.Data.EmployeeExperience
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
        ///     Counts the number of employee experiences.
        /// </summary>
        /// <returns>Returns the count of the employee experiences.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/hrm/employee-experience/count")]
        public long Count()
        {
            try
            {
                return this.EmployeeExperienceContext.Count();
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
        ///     Returns an instance of employee experience.
        /// </summary>
        /// <param name="employeeExperienceId">Enter EmployeeExperienceId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{employeeExperienceId}")]
        [Route("~/api/hrm/employee-experience/{employeeExperienceId}")]
        public MixERP.Net.Entities.HRM.EmployeeExperience Get(long employeeExperienceId)
        {
            try
            {
                return this.EmployeeExperienceContext.Get(employeeExperienceId);
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
        ///     Creates a paginated collection containing 25 employee experiences on each page, sorted by the property EmployeeExperienceId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/hrm/employee-experience")]
        public IEnumerable<MixERP.Net.Entities.HRM.EmployeeExperience> GetPagedResult()
        {
            try
            {
                return this.EmployeeExperienceContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 employee experiences on each page, sorted by the property EmployeeExperienceId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/hrm/employee-experience/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.HRM.EmployeeExperience> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.EmployeeExperienceContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 employee experiences on each page, sorted by the property EmployeeExperienceId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/hrm/employee-experience/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.HRM.EmployeeExperience> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.EmployeeExperienceContext.GetWhere(pageNumber, f);
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
        ///     Displayfields is a lightweight key/value collection of employee experiences.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of employee experiences.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/hrm/employee-experience/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.EmployeeExperienceContext.GetDisplayFields();
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
        /// <param name="employeeExperience">Your instance of employee experiences class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{employeeExperience}")]
        [Route("~/api/hrm/employee-experience/add/{employeeExperience}")]
        public void Add(MixERP.Net.Entities.HRM.EmployeeExperience employeeExperience)
        {
            if (employeeExperience == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.EmployeeExperienceContext.Add(employeeExperience);
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
        /// <param name="employeeExperience">Your instance of Account class to edit.</param>
        /// <param name="employeeExperienceId">Enter the value for EmployeeExperienceId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{employeeExperienceId}/{employeeExperience}")]
        [Route("~/api/hrm/employee-experience/edit/{employeeExperienceId}/{employeeExperience}")]
        public void Edit(long employeeExperienceId, MixERP.Net.Entities.HRM.EmployeeExperience employeeExperience)
        {
            if (employeeExperience == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.EmployeeExperienceContext.Update(employeeExperience, employeeExperienceId);
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
        ///     Deletes an existing instance of Account class via EmployeeExperienceId.
        /// </summary>
        /// <param name="employeeExperienceId">Enter the value for EmployeeExperienceId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{employeeExperienceId}")]
        [Route("~/api/hrm/employee-experience/delete/{employeeExperienceId}")]
        public void Delete(long employeeExperienceId)
        {
            try
            {
                this.EmployeeExperienceContext.Delete(employeeExperienceId);
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