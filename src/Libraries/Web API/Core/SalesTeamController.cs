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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Sales Teams.
    /// </summary>
    [RoutePrefix("api/v1.5/core/sales-team")]
    public class SalesTeamController : ApiController
    {
        /// <summary>
        ///     The SalesTeam data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Core.Data.SalesTeam SalesTeamContext;

        public SalesTeamController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.SalesTeamContext = new MixERP.Net.Schemas.Core.Data.SalesTeam
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
        ///     Counts the number of sales teams.
        /// </summary>
        /// <returns>Returns the count of the sales teams.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/core/sales-team/count")]
        public long Count()
        {
            try
            {
                return this.SalesTeamContext.Count();
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
        ///     Returns an instance of sales team.
        /// </summary>
        /// <param name="salesTeamId">Enter SalesTeamId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{salesTeamId}")]
        [Route("~/api/core/sales-team/{salesTeamId}")]
        public MixERP.Net.Entities.Core.SalesTeam Get(int salesTeamId)
        {
            try
            {
                return this.SalesTeamContext.Get(salesTeamId);
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
        [Route("~/api/core/sales-team/get")]
        public IEnumerable<MixERP.Net.Entities.Core.SalesTeam> Get([FromUri] int[] salesTeamIds)
        {
            try
            {
                return this.SalesTeamContext.Get(salesTeamIds);
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
        ///     Creates a paginated collection containing 25 sales teams on each page, sorted by the property SalesTeamId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/core/sales-team")]
        public IEnumerable<MixERP.Net.Entities.Core.SalesTeam> GetPagedResult()
        {
            try
            {
                return this.SalesTeamContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 sales teams on each page, sorted by the property SalesTeamId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/core/sales-team/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.SalesTeam> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.SalesTeamContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 sales teams on each page, sorted by the property SalesTeamId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/core/sales-team/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.SalesTeam> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.SalesTeamContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of sales teams.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of sales teams.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/core/sales-team/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.SalesTeamContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for sales teams.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of sales teams.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/sales-team/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.SalesTeamContext.GetCustomFields(null);
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
        ///     A custom field is a user defined field for sales teams.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of sales teams.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/sales-team/custom-fields/{resourceId}")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
        {
            try
            {
                return this.SalesTeamContext.GetCustomFields(resourceId);
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
        ///     Adds or edits your instance of SalesTeam class.
        /// </summary>
        /// <param name="salesTeam">Your instance of sales teams class to add or edit.</param>
        [AcceptVerbs("PUT")]
        [Route("add-or-edit")]
        [Route("~/api/core/sales-team/add-or-edit")]
        public void AddOrEdit([FromBody]MixERP.Net.Entities.Core.SalesTeam salesTeam)
        {
            if (salesTeam == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.SalesTeamContext.AddOrEdit(salesTeam);
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
        ///     Adds your instance of SalesTeam class.
        /// </summary>
        /// <param name="salesTeam">Your instance of sales teams class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{salesTeam}")]
        [Route("~/api/core/sales-team/add/{salesTeam}")]
        public void Add(MixERP.Net.Entities.Core.SalesTeam salesTeam)
        {
            if (salesTeam == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.SalesTeamContext.Add(salesTeam);
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
        ///     Edits existing record with your instance of SalesTeam class.
        /// </summary>
        /// <param name="salesTeam">Your instance of SalesTeam class to edit.</param>
        /// <param name="salesTeamId">Enter the value for SalesTeamId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{salesTeamId}")]
        [Route("~/api/core/sales-team/edit/{salesTeamId}")]
        public void Edit(int salesTeamId, [FromBody] MixERP.Net.Entities.Core.SalesTeam salesTeam)
        {
            if (salesTeam == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.SalesTeamContext.Update(salesTeam, salesTeamId);
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
        ///     Deletes an existing instance of SalesTeam class via SalesTeamId.
        /// </summary>
        /// <param name="salesTeamId">Enter the value for SalesTeamId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{salesTeamId}")]
        [Route("~/api/core/sales-team/delete/{salesTeamId}")]
        public void Delete(int salesTeamId)
        {
            try
            {
                this.SalesTeamContext.Delete(salesTeamId);
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