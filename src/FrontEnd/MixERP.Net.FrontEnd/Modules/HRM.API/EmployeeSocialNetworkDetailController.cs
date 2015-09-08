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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Employee Social Network Details.
    /// </summary>
    [RoutePrefix("api/v1.5/hrm/employee-social-network-detail")]
    public class EmployeeSocialNetworkDetailController : ApiController
    {
        /// <summary>
        ///     The EmployeeSocialNetworkDetail data context.
        /// </summary>
        private readonly MixERP.Net.Core.Modules.HRM.Data.EmployeeSocialNetworkDetail EmployeeSocialNetworkDetailContext;

        public EmployeeSocialNetworkDetailController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.EmployeeSocialNetworkDetailContext = new MixERP.Net.Core.Modules.HRM.Data.EmployeeSocialNetworkDetail
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
        ///     Counts the number of employee social network details.
        /// </summary>
        /// <returns>Returns the count of the employee social network details.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/hrm/employee-social-network-detail/count")]
        public long Count()
        {
            try
            {
                return this.EmployeeSocialNetworkDetailContext.Count();
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
        ///     Returns an instance of employee social network detail.
        /// </summary>
        /// <param name="employeeSocialNetworkDetailId">Enter EmployeeSocialNetworkDetailId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{employeeSocialNetworkDetailId}")]
        [Route("~/api/hrm/employee-social-network-detail/{employeeSocialNetworkDetailId}")]
        public MixERP.Net.Entities.HRM.EmployeeSocialNetworkDetail Get(long employeeSocialNetworkDetailId)
        {
            try
            {
                return this.EmployeeSocialNetworkDetailContext.Get(employeeSocialNetworkDetailId);
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
        ///     Creates a paginated collection containing 25 employee social network details on each page, sorted by the property EmployeeSocialNetworkDetailId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/hrm/employee-social-network-detail")]
        public IEnumerable<MixERP.Net.Entities.HRM.EmployeeSocialNetworkDetail> GetPagedResult()
        {
            try
            {
                return this.EmployeeSocialNetworkDetailContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 employee social network details on each page, sorted by the property EmployeeSocialNetworkDetailId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/hrm/employee-social-network-detail/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.HRM.EmployeeSocialNetworkDetail> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.EmployeeSocialNetworkDetailContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 employee social network details on each page, sorted by the property EmployeeSocialNetworkDetailId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/hrm/employee-social-network-detail/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.HRM.EmployeeSocialNetworkDetail> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.EmployeeSocialNetworkDetailContext.GetWhere(pageNumber, f);
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
        ///     Displayfields is a lightweight key/value collection of employee social network details.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of employee social network details.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/hrm/employee-social-network-detail/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.EmployeeSocialNetworkDetailContext.GetDisplayFields();
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
        /// <param name="employeeSocialNetworkDetail">Your instance of employee social network details class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{employeeSocialNetworkDetail}")]
        [Route("~/api/hrm/employee-social-network-detail/add/{employeeSocialNetworkDetail}")]
        public void Add(MixERP.Net.Entities.HRM.EmployeeSocialNetworkDetail employeeSocialNetworkDetail)
        {
            if (employeeSocialNetworkDetail == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.EmployeeSocialNetworkDetailContext.Add(employeeSocialNetworkDetail);
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
        /// <param name="employeeSocialNetworkDetail">Your instance of Account class to edit.</param>
        /// <param name="employeeSocialNetworkDetailId">Enter the value for EmployeeSocialNetworkDetailId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{employeeSocialNetworkDetailId}/{employeeSocialNetworkDetail}")]
        [Route("~/api/hrm/employee-social-network-detail/edit/{employeeSocialNetworkDetailId}/{employeeSocialNetworkDetail}")]
        public void Edit(long employeeSocialNetworkDetailId, MixERP.Net.Entities.HRM.EmployeeSocialNetworkDetail employeeSocialNetworkDetail)
        {
            if (employeeSocialNetworkDetail == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.EmployeeSocialNetworkDetailContext.Update(employeeSocialNetworkDetail, employeeSocialNetworkDetailId);
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
        ///     Deletes an existing instance of Account class via EmployeeSocialNetworkDetailId.
        /// </summary>
        /// <param name="employeeSocialNetworkDetailId">Enter the value for EmployeeSocialNetworkDetailId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{employeeSocialNetworkDetailId}")]
        [Route("~/api/hrm/employee-social-network-detail/delete/{employeeSocialNetworkDetailId}")]
        public void Delete(long employeeSocialNetworkDetailId)
        {
            try
            {
                this.EmployeeSocialNetworkDetailContext.Delete(employeeSocialNetworkDetailId);
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