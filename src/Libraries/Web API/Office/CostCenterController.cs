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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Cost Centers.
    /// </summary>
    [RoutePrefix("api/v1.5/office/cost-center")]
    public class CostCenterController : ApiController
    {
        /// <summary>
        ///     The CostCenter data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Office.Data.CostCenter CostCenterContext;

        public CostCenterController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.CostCenterContext = new MixERP.Net.Schemas.Office.Data.CostCenter
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
        ///     Counts the number of cost centers.
        /// </summary>
        /// <returns>Returns the count of the cost centers.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/office/cost-center/count")]
        public long Count()
        {
            try
            {
                return this.CostCenterContext.Count();
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
        ///     Returns an instance of cost center.
        /// </summary>
        /// <param name="costCenterId">Enter CostCenterId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{costCenterId}")]
        [Route("~/api/office/cost-center/{costCenterId}")]
        public MixERP.Net.Entities.Office.CostCenter Get(int costCenterId)
        {
            try
            {
                return this.CostCenterContext.Get(costCenterId);
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
        [Route("~/api/office/cost-center/get")]
        public IEnumerable<MixERP.Net.Entities.Office.CostCenter> Get([FromUri] int[] costCenterIds)
        {
            try
            {
                return this.CostCenterContext.Get(costCenterIds);
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
        ///     Creates a paginated collection containing 25 cost centers on each page, sorted by the property CostCenterId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/office/cost-center")]
        public IEnumerable<MixERP.Net.Entities.Office.CostCenter> GetPagedResult()
        {
            try
            {
                return this.CostCenterContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 cost centers on each page, sorted by the property CostCenterId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/office/cost-center/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Office.CostCenter> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.CostCenterContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 cost centers on each page, sorted by the property CostCenterId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/office/cost-center/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Office.CostCenter> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.CostCenterContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of cost centers.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of cost centers.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/office/cost-center/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.CostCenterContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for cost centers.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of cost centers.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/office/cost-center/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.CostCenterContext.GetCustomFields(null);
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
        ///     A custom field is a user defined field for cost centers.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of cost centers.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/office/cost-center/custom-fields/{resourceId}")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
        {
            try
            {
                return this.CostCenterContext.GetCustomFields(resourceId);
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
        ///     Adds or edits your instance of CostCenter class.
        /// </summary>
        /// <param name="costCenter">Your instance of cost centers class to add or edit.</param>
        [AcceptVerbs("PUT")]
        [Route("add-or-edit")]
        [Route("~/api/office/cost-center/add-or-edit")]
        public void AddOrEdit([FromBody]MixERP.Net.Entities.Office.CostCenter costCenter)
        {
            if (costCenter == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.CostCenterContext.AddOrEdit(costCenter);
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
        ///     Adds your instance of CostCenter class.
        /// </summary>
        /// <param name="costCenter">Your instance of cost centers class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{costCenter}")]
        [Route("~/api/office/cost-center/add/{costCenter}")]
        public void Add(MixERP.Net.Entities.Office.CostCenter costCenter)
        {
            if (costCenter == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.CostCenterContext.Add(costCenter);
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
        ///     Edits existing record with your instance of CostCenter class.
        /// </summary>
        /// <param name="costCenter">Your instance of CostCenter class to edit.</param>
        /// <param name="costCenterId">Enter the value for CostCenterId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{costCenterId}")]
        [Route("~/api/office/cost-center/edit/{costCenterId}")]
        public void Edit(int costCenterId, [FromBody] MixERP.Net.Entities.Office.CostCenter costCenter)
        {
            if (costCenter == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.CostCenterContext.Update(costCenter, costCenterId);
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
        ///     Deletes an existing instance of CostCenter class via CostCenterId.
        /// </summary>
        /// <param name="costCenterId">Enter the value for CostCenterId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{costCenterId}")]
        [Route("~/api/office/cost-center/delete/{costCenterId}")]
        public void Delete(int costCenterId)
        {
            try
            {
                this.CostCenterContext.Delete(costCenterId);
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