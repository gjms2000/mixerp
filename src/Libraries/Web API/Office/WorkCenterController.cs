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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Work Centers.
    /// </summary>
    [RoutePrefix("api/v1.5/office/work-center")]
    public class WorkCenterController : ApiController
    {
        /// <summary>
        ///     The WorkCenter data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Office.Data.WorkCenter WorkCenterContext;

        public WorkCenterController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.WorkCenterContext = new MixERP.Net.Schemas.Office.Data.WorkCenter
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
        ///     Counts the number of work centers.
        /// </summary>
        /// <returns>Returns the count of the work centers.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/office/work-center/count")]
        public long Count()
        {
            try
            {
                return this.WorkCenterContext.Count();
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
        ///     Returns an instance of work center.
        /// </summary>
        /// <param name="workCenterId">Enter WorkCenterId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{workCenterId}")]
        [Route("~/api/office/work-center/{workCenterId}")]
        public MixERP.Net.Entities.Office.WorkCenter Get(int workCenterId)
        {
            try
            {
                return this.WorkCenterContext.Get(workCenterId);
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
        [Route("~/api/office/work-center/get")]
        public IEnumerable<MixERP.Net.Entities.Office.WorkCenter> Get([FromUri] int[] workCenterIds)
        {
            try
            {
                return this.WorkCenterContext.Get(workCenterIds);
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
        ///     Creates a paginated collection containing 25 work centers on each page, sorted by the property WorkCenterId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/office/work-center")]
        public IEnumerable<MixERP.Net.Entities.Office.WorkCenter> GetPagedResult()
        {
            try
            {
                return this.WorkCenterContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 work centers on each page, sorted by the property WorkCenterId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/office/work-center/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Office.WorkCenter> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.WorkCenterContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 work centers on each page, sorted by the property WorkCenterId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/office/work-center/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Office.WorkCenter> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.WorkCenterContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of work centers.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of work centers.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/office/work-center/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.WorkCenterContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for work centers.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of work centers.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/office/work-center/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.WorkCenterContext.GetCustomFields(null);
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
        ///     A custom field is a user defined field for work centers.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of work centers.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/office/work-center/custom-fields/{resourceId}")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
        {
            try
            {
                return this.WorkCenterContext.GetCustomFields(resourceId);
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
        ///     Adds or edits your instance of WorkCenter class.
        /// </summary>
        /// <param name="workCenter">Your instance of work centers class to add or edit.</param>
        [AcceptVerbs("PUT")]
        [Route("add-or-edit")]
        [Route("~/api/office/work-center/add-or-edit")]
        public void AddOrEdit([FromBody]MixERP.Net.Entities.Office.WorkCenter workCenter)
        {
            if (workCenter == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.WorkCenterContext.AddOrEdit(workCenter);
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
        ///     Adds your instance of WorkCenter class.
        /// </summary>
        /// <param name="workCenter">Your instance of work centers class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{workCenter}")]
        [Route("~/api/office/work-center/add/{workCenter}")]
        public void Add(MixERP.Net.Entities.Office.WorkCenter workCenter)
        {
            if (workCenter == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.WorkCenterContext.Add(workCenter);
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
        ///     Edits existing record with your instance of WorkCenter class.
        /// </summary>
        /// <param name="workCenter">Your instance of WorkCenter class to edit.</param>
        /// <param name="workCenterId">Enter the value for WorkCenterId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{workCenterId}")]
        [Route("~/api/office/work-center/edit/{workCenterId}")]
        public void Edit(int workCenterId, [FromBody] MixERP.Net.Entities.Office.WorkCenter workCenter)
        {
            if (workCenter == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.WorkCenterContext.Update(workCenter, workCenterId);
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
        ///     Deletes an existing instance of WorkCenter class via WorkCenterId.
        /// </summary>
        /// <param name="workCenterId">Enter the value for WorkCenterId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{workCenterId}")]
        [Route("~/api/office/work-center/delete/{workCenterId}")]
        public void Delete(int workCenterId)
        {
            try
            {
                this.WorkCenterContext.Delete(workCenterId);
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