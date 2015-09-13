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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Employees.
    /// </summary>
    [RoutePrefix("api/v1.5/hrm/employee")]
    public class EmployeeController : ApiController
    {
        /// <summary>
        ///     The Employee data context.
        /// </summary>
        private readonly MixERP.Net.Core.Modules.HRM.Data.Employee EmployeeContext;

        public EmployeeController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.EmployeeContext = new MixERP.Net.Core.Modules.HRM.Data.Employee
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
        ///     Counts the number of employees.
        /// </summary>
        /// <returns>Returns the count of the employees.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/hrm/employee/count")]
        public long Count()
        {
            try
            {
                return this.EmployeeContext.Count();
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
        ///     Returns an instance of employee.
        /// </summary>
        /// <param name="employeeId">Enter EmployeeId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{employeeId}")]
        [Route("~/api/hrm/employee/{employeeId}")]
        public MixERP.Net.Entities.HRM.Employee Get(int employeeId)
        {
            try
            {
                return this.EmployeeContext.Get(employeeId);
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
        [Route("~/api/hrm/employee/get")]
        public IEnumerable<MixERP.Net.Entities.HRM.Employee> Get([FromUri] int[] employeeIds)
        {
            try
            {
                return this.EmployeeContext.Get(employeeIds);
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
        ///     Creates a paginated collection containing 25 employees on each page, sorted by the property EmployeeId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/hrm/employee")]
        public IEnumerable<MixERP.Net.Entities.HRM.Employee> GetPagedResult()
        {
            try
            {
                return this.EmployeeContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 employees on each page, sorted by the property EmployeeId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/hrm/employee/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.HRM.Employee> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.EmployeeContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 employees on each page, sorted by the property EmployeeId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/hrm/employee/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.HRM.Employee> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.EmployeeContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of employees.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of employees.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/hrm/employee/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.EmployeeContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for employees.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of employees.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/hrm/employee/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.EmployeeContext.GetCustomFields(null);
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
        ///     A custom field is a user defined field for employees.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of employees.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/hrm/employee/custom-fields/{resourceId}")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
        {
            try
            {
                return this.EmployeeContext.GetCustomFields(resourceId);
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
        ///     Adds or edits your instance of Employee class.
        /// </summary>
        /// <param name="employee">Your instance of employees class to add or edit.</param>
        [AcceptVerbs("PUT")]
        [Route("add-or-edit")]
        [Route("~/api/hrm/employee/add-or-edit")]
        public void AddOrEdit([FromBody]MixERP.Net.Entities.HRM.Employee employee)
        {
            if (employee == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.EmployeeContext.AddOrEdit(employee);
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
        ///     Adds your instance of Employee class.
        /// </summary>
        /// <param name="employee">Your instance of employees class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{employee}")]
        [Route("~/api/hrm/employee/add/{employee}")]
        public void Add(MixERP.Net.Entities.HRM.Employee employee)
        {
            if (employee == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.EmployeeContext.Add(employee);
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
        ///     Edits existing record with your instance of Employee class.
        /// </summary>
        /// <param name="employee">Your instance of Employee class to edit.</param>
        /// <param name="employeeId">Enter the value for EmployeeId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{employeeId}")]
        [Route("~/api/hrm/employee/edit/{employeeId}")]
        public void Edit(int employeeId, [FromBody] MixERP.Net.Entities.HRM.Employee employee)
        {
            if (employee == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.EmployeeContext.Update(employee, employeeId);
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
        ///     Deletes an existing instance of Employee class via EmployeeId.
        /// </summary>
        /// <param name="employeeId">Enter the value for EmployeeId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{employeeId}")]
        [Route("~/api/hrm/employee/delete/{employeeId}")]
        public void Delete(int employeeId)
        {
            try
            {
                this.EmployeeContext.Delete(employeeId);
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