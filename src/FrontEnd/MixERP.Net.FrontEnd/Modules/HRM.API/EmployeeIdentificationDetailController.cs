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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Employee Identification Details.
    /// </summary>
    [RoutePrefix("api/v1.5/hrm/employee-identification-detail")]
    public class EmployeeIdentificationDetailController : ApiController
    {
        /// <summary>
        ///     The EmployeeIdentificationDetail data context.
        /// </summary>
        private readonly MixERP.Net.Core.Modules.HRM.Data.EmployeeIdentificationDetail EmployeeIdentificationDetailContext;

        public EmployeeIdentificationDetailController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.EmployeeIdentificationDetailContext = new MixERP.Net.Core.Modules.HRM.Data.EmployeeIdentificationDetail
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
        ///     Counts the number of employee identification details.
        /// </summary>
        /// <returns>Returns the count of the employee identification details.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/hrm/employee-identification-detail/count")]
        public long Count()
        {
            try
            {
                return this.EmployeeIdentificationDetailContext.Count();
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
        ///     Returns an instance of employee identification detail.
        /// </summary>
        /// <param name="employeeIdentificationDetailId">Enter EmployeeIdentificationDetailId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{employeeIdentificationDetailId}")]
        [Route("~/api/hrm/employee-identification-detail/{employeeIdentificationDetailId}")]
        public MixERP.Net.Entities.HRM.EmployeeIdentificationDetail Get(long employeeIdentificationDetailId)
        {
            try
            {
                return this.EmployeeIdentificationDetailContext.Get(employeeIdentificationDetailId);
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
        [Route("~/api/hrm/employee-identification-detail/get")]
        public IEnumerable<MixERP.Net.Entities.HRM.EmployeeIdentificationDetail> Get([FromUri] long[] employeeIdentificationDetailIds)
        {
            try
            {
                return this.EmployeeIdentificationDetailContext.Get(employeeIdentificationDetailIds);
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
        ///     Creates a paginated collection containing 25 employee identification details on each page, sorted by the property EmployeeIdentificationDetailId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/hrm/employee-identification-detail")]
        public IEnumerable<MixERP.Net.Entities.HRM.EmployeeIdentificationDetail> GetPagedResult()
        {
            try
            {
                return this.EmployeeIdentificationDetailContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 employee identification details on each page, sorted by the property EmployeeIdentificationDetailId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/hrm/employee-identification-detail/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.HRM.EmployeeIdentificationDetail> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.EmployeeIdentificationDetailContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 employee identification details on each page, sorted by the property EmployeeIdentificationDetailId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/hrm/employee-identification-detail/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.HRM.EmployeeIdentificationDetail> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.EmployeeIdentificationDetailContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of employee identification details.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of employee identification details.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/hrm/employee-identification-detail/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.EmployeeIdentificationDetailContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for employee identification details.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of employee identification details.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/hrm/employee-identification-detail/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.EmployeeIdentificationDetailContext.GetCustomFields(null);
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
        ///     A custom field is a user defined field for employee identification details.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of employee identification details.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/hrm/employee-identification-detail/custom-fields/{resourceId}")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
        {
            try
            {
                return this.EmployeeIdentificationDetailContext.GetCustomFields(resourceId);
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
        ///     Adds or edits your instance of EmployeeIdentificationDetail class.
        /// </summary>
        /// <param name="employeeIdentificationDetail">Your instance of employee identification details class to add or edit.</param>
        [AcceptVerbs("PUT")]
        [Route("add-or-edit")]
        [Route("~/api/hrm/employee-identification-detail/add-or-edit")]
        public void AddOrEdit([FromBody]MixERP.Net.Entities.HRM.EmployeeIdentificationDetail employeeIdentificationDetail)
        {
            if (employeeIdentificationDetail == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.EmployeeIdentificationDetailContext.AddOrEdit(employeeIdentificationDetail);
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
        ///     Adds your instance of EmployeeIdentificationDetail class.
        /// </summary>
        /// <param name="employeeIdentificationDetail">Your instance of employee identification details class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{employeeIdentificationDetail}")]
        [Route("~/api/hrm/employee-identification-detail/add/{employeeIdentificationDetail}")]
        public void Add(MixERP.Net.Entities.HRM.EmployeeIdentificationDetail employeeIdentificationDetail)
        {
            if (employeeIdentificationDetail == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.EmployeeIdentificationDetailContext.Add(employeeIdentificationDetail);
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
        ///     Edits existing record with your instance of EmployeeIdentificationDetail class.
        /// </summary>
        /// <param name="employeeIdentificationDetail">Your instance of EmployeeIdentificationDetail class to edit.</param>
        /// <param name="employeeIdentificationDetailId">Enter the value for EmployeeIdentificationDetailId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{employeeIdentificationDetailId}")]
        [Route("~/api/hrm/employee-identification-detail/edit/{employeeIdentificationDetailId}")]
        public void Edit(long employeeIdentificationDetailId, [FromBody] MixERP.Net.Entities.HRM.EmployeeIdentificationDetail employeeIdentificationDetail)
        {
            if (employeeIdentificationDetail == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.EmployeeIdentificationDetailContext.Update(employeeIdentificationDetail, employeeIdentificationDetailId);
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
        ///     Deletes an existing instance of EmployeeIdentificationDetail class via EmployeeIdentificationDetailId.
        /// </summary>
        /// <param name="employeeIdentificationDetailId">Enter the value for EmployeeIdentificationDetailId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{employeeIdentificationDetailId}")]
        [Route("~/api/hrm/employee-identification-detail/delete/{employeeIdentificationDetailId}")]
        public void Delete(long employeeIdentificationDetailId)
        {
            try
            {
                this.EmployeeIdentificationDetailContext.Delete(employeeIdentificationDetailId);
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