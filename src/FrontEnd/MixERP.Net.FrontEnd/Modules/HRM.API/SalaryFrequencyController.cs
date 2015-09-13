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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Salary Frequencies.
    /// </summary>
    [RoutePrefix("api/v1.5/hrm/salary-frequency")]
    public class SalaryFrequencyController : ApiController
    {
        /// <summary>
        ///     The SalaryFrequency data context.
        /// </summary>
        private readonly MixERP.Net.Core.Modules.HRM.Data.SalaryFrequency SalaryFrequencyContext;

        public SalaryFrequencyController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.SalaryFrequencyContext = new MixERP.Net.Core.Modules.HRM.Data.SalaryFrequency
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
        ///     Counts the number of salary frequencies.
        /// </summary>
        /// <returns>Returns the count of the salary frequencies.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/hrm/salary-frequency/count")]
        public long Count()
        {
            try
            {
                return this.SalaryFrequencyContext.Count();
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
        ///     Returns an instance of salary frequency.
        /// </summary>
        /// <param name="salaryFrequencyId">Enter SalaryFrequencyId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{salaryFrequencyId}")]
        [Route("~/api/hrm/salary-frequency/{salaryFrequencyId}")]
        public MixERP.Net.Entities.HRM.SalaryFrequency Get(int salaryFrequencyId)
        {
            try
            {
                return this.SalaryFrequencyContext.Get(salaryFrequencyId);
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
        [Route("~/api/hrm/salary-frequency/get")]
        public IEnumerable<MixERP.Net.Entities.HRM.SalaryFrequency> Get([FromUri] int[] salaryFrequencyIds)
        {
            try
            {
                return this.SalaryFrequencyContext.Get(salaryFrequencyIds);
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
        ///     Creates a paginated collection containing 25 salary frequencies on each page, sorted by the property SalaryFrequencyId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/hrm/salary-frequency")]
        public IEnumerable<MixERP.Net.Entities.HRM.SalaryFrequency> GetPagedResult()
        {
            try
            {
                return this.SalaryFrequencyContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 salary frequencies on each page, sorted by the property SalaryFrequencyId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/hrm/salary-frequency/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.HRM.SalaryFrequency> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.SalaryFrequencyContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 salary frequencies on each page, sorted by the property SalaryFrequencyId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/hrm/salary-frequency/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.HRM.SalaryFrequency> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.SalaryFrequencyContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of salary frequencies.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of salary frequencies.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/hrm/salary-frequency/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.SalaryFrequencyContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for salary frequencies.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of salary frequencies.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/hrm/salary-frequency/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.SalaryFrequencyContext.GetCustomFields(null);
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
        ///     A custom field is a user defined field for salary frequencies.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of salary frequencies.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/hrm/salary-frequency/custom-fields/{resourceId}")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
        {
            try
            {
                return this.SalaryFrequencyContext.GetCustomFields(resourceId);
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
        ///     Adds or edits your instance of SalaryFrequency class.
        /// </summary>
        /// <param name="salaryFrequency">Your instance of salary frequencies class to add or edit.</param>
        [AcceptVerbs("PUT")]
        [Route("add-or-edit")]
        [Route("~/api/hrm/salary-frequency/add-or-edit")]
        public void AddOrEdit([FromBody]MixERP.Net.Entities.HRM.SalaryFrequency salaryFrequency)
        {
            if (salaryFrequency == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.SalaryFrequencyContext.AddOrEdit(salaryFrequency);
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
        ///     Adds your instance of SalaryFrequency class.
        /// </summary>
        /// <param name="salaryFrequency">Your instance of salary frequencies class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{salaryFrequency}")]
        [Route("~/api/hrm/salary-frequency/add/{salaryFrequency}")]
        public void Add(MixERP.Net.Entities.HRM.SalaryFrequency salaryFrequency)
        {
            if (salaryFrequency == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.SalaryFrequencyContext.Add(salaryFrequency);
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
        ///     Edits existing record with your instance of SalaryFrequency class.
        /// </summary>
        /// <param name="salaryFrequency">Your instance of SalaryFrequency class to edit.</param>
        /// <param name="salaryFrequencyId">Enter the value for SalaryFrequencyId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{salaryFrequencyId}")]
        [Route("~/api/hrm/salary-frequency/edit/{salaryFrequencyId}")]
        public void Edit(int salaryFrequencyId, [FromBody] MixERP.Net.Entities.HRM.SalaryFrequency salaryFrequency)
        {
            if (salaryFrequency == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.SalaryFrequencyContext.Update(salaryFrequency, salaryFrequencyId);
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
        ///     Deletes an existing instance of SalaryFrequency class via SalaryFrequencyId.
        /// </summary>
        /// <param name="salaryFrequencyId">Enter the value for SalaryFrequencyId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{salaryFrequencyId}")]
        [Route("~/api/hrm/salary-frequency/delete/{salaryFrequencyId}")]
        public void Delete(int salaryFrequencyId)
        {
            try
            {
                this.SalaryFrequencyContext.Delete(salaryFrequencyId);
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