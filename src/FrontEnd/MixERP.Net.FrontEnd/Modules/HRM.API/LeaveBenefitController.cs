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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Leave Benefits.
    /// </summary>
    [RoutePrefix("api/v1.5/hrm/leave-benefit")]
    public class LeaveBenefitController : ApiController
    {
        /// <summary>
        ///     The LeaveBenefit data context.
        /// </summary>
        private readonly MixERP.Net.Core.Modules.HRM.Data.LeaveBenefit LeaveBenefitContext;

        public LeaveBenefitController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.LeaveBenefitContext = new MixERP.Net.Core.Modules.HRM.Data.LeaveBenefit
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
        ///     Counts the number of leave benefits.
        /// </summary>
        /// <returns>Returns the count of the leave benefits.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/hrm/leave-benefit/count")]
        public long Count()
        {
            try
            {
                return this.LeaveBenefitContext.Count();
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
        ///     Returns an instance of leave benefit.
        /// </summary>
        /// <param name="leaveBenefitId">Enter LeaveBenefitId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{leaveBenefitId}")]
        [Route("~/api/hrm/leave-benefit/{leaveBenefitId}")]
        public MixERP.Net.Entities.HRM.LeaveBenefit Get(int leaveBenefitId)
        {
            try
            {
                return this.LeaveBenefitContext.Get(leaveBenefitId);
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
        ///     Creates a paginated collection containing 25 leave benefits on each page, sorted by the property LeaveBenefitId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/hrm/leave-benefit")]
        public IEnumerable<MixERP.Net.Entities.HRM.LeaveBenefit> GetPagedResult()
        {
            try
            {
                return this.LeaveBenefitContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 leave benefits on each page, sorted by the property LeaveBenefitId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/hrm/leave-benefit/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.HRM.LeaveBenefit> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.LeaveBenefitContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 leave benefits on each page, sorted by the property LeaveBenefitId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/hrm/leave-benefit/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.HRM.LeaveBenefit> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.LeaveBenefitContext.GetWhere(pageNumber, f);
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
        ///     Displayfields is a lightweight key/value collection of leave benefits.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of leave benefits.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/hrm/leave-benefit/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.LeaveBenefitContext.GetDisplayFields();
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
        /// <param name="leaveBenefit">Your instance of leave benefits class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{leaveBenefit}")]
        [Route("~/api/hrm/leave-benefit/add/{leaveBenefit}")]
        public void Add(MixERP.Net.Entities.HRM.LeaveBenefit leaveBenefit)
        {
            if (leaveBenefit == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.LeaveBenefitContext.Add(leaveBenefit);
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
        /// <param name="leaveBenefit">Your instance of Account class to edit.</param>
        /// <param name="leaveBenefitId">Enter the value for LeaveBenefitId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{leaveBenefitId}/{leaveBenefit}")]
        [Route("~/api/hrm/leave-benefit/edit/{leaveBenefitId}/{leaveBenefit}")]
        public void Edit(int leaveBenefitId, MixERP.Net.Entities.HRM.LeaveBenefit leaveBenefit)
        {
            if (leaveBenefit == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.LeaveBenefitContext.Update(leaveBenefit, leaveBenefitId);
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
        ///     Deletes an existing instance of Account class via LeaveBenefitId.
        /// </summary>
        /// <param name="leaveBenefitId">Enter the value for LeaveBenefitId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{leaveBenefitId}")]
        [Route("~/api/hrm/leave-benefit/delete/{leaveBenefitId}")]
        public void Delete(int leaveBenefitId)
        {
            try
            {
                this.LeaveBenefitContext.Delete(leaveBenefitId);
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