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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Compound Units.
    /// </summary>
    [RoutePrefix("api/v1.5/core/compound-unit")]
    public class CompoundUnitController : ApiController
    {
        /// <summary>
        ///     The CompoundUnit data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Core.Data.CompoundUnit CompoundUnitContext;

        public CompoundUnitController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.CompoundUnitContext = new MixERP.Net.Schemas.Core.Data.CompoundUnit
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
        ///     Counts the number of compound units.
        /// </summary>
        /// <returns>Returns the count of the compound units.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/core/compound-unit/count")]
        public long Count()
        {
            try
            {
                return this.CompoundUnitContext.Count();
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
        ///     Returns an instance of compound unit.
        /// </summary>
        /// <param name="compoundUnitId">Enter CompoundUnitId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{compoundUnitId}")]
        [Route("~/api/core/compound-unit/{compoundUnitId}")]
        public MixERP.Net.Entities.Core.CompoundUnit Get(int compoundUnitId)
        {
            try
            {
                return this.CompoundUnitContext.Get(compoundUnitId);
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
        ///     Creates a paginated collection containing 25 compound units on each page, sorted by the property CompoundUnitId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/core/compound-unit")]
        public IEnumerable<MixERP.Net.Entities.Core.CompoundUnit> GetPagedResult()
        {
            try
            {
                return this.CompoundUnitContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 compound units on each page, sorted by the property CompoundUnitId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/core/compound-unit/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.CompoundUnit> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.CompoundUnitContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 compound units on each page, sorted by the property CompoundUnitId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/core/compound-unit/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.CompoundUnit> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.CompoundUnitContext.GetWhere(pageNumber, f);
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
        ///     Displayfields is a lightweight key/value collection of compound units.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of compound units.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/core/compound-unit/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.CompoundUnitContext.GetDisplayFields();
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
        /// <param name="compoundUnit">Your instance of compound units class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{compoundUnit}")]
        [Route("~/api/core/compound-unit/add/{compoundUnit}")]
        public void Add(MixERP.Net.Entities.Core.CompoundUnit compoundUnit)
        {
            if (compoundUnit == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.CompoundUnitContext.Add(compoundUnit);
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
        /// <param name="compoundUnit">Your instance of Account class to edit.</param>
        /// <param name="compoundUnitId">Enter the value for CompoundUnitId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{compoundUnitId}/{compoundUnit}")]
        [Route("~/api/core/compound-unit/edit/{compoundUnitId}/{compoundUnit}")]
        public void Edit(int compoundUnitId, MixERP.Net.Entities.Core.CompoundUnit compoundUnit)
        {
            if (compoundUnit == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.CompoundUnitContext.Update(compoundUnit, compoundUnitId);
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
        ///     Deletes an existing instance of Account class via CompoundUnitId.
        /// </summary>
        /// <param name="compoundUnitId">Enter the value for CompoundUnitId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{compoundUnitId}")]
        [Route("~/api/core/compound-unit/delete/{compoundUnitId}")]
        public void Delete(int compoundUnitId)
        {
            try
            {
                this.CompoundUnitContext.Delete(compoundUnitId);
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