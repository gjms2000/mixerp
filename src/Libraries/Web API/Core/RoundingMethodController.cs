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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Rounding Methods.
    /// </summary>
    [RoutePrefix("api/v1.5/core/rounding-method")]
    public class RoundingMethodController : ApiController
    {
        /// <summary>
        ///     The RoundingMethod data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Core.Data.RoundingMethod RoundingMethodContext;

        public RoundingMethodController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.RoundingMethodContext = new MixERP.Net.Schemas.Core.Data.RoundingMethod
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
        ///     Counts the number of rounding methods.
        /// </summary>
        /// <returns>Returns the count of the rounding methods.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/core/rounding-method/count")]
        public long Count()
        {
            try
            {
                return this.RoundingMethodContext.Count();
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
        ///     Returns an instance of rounding method.
        /// </summary>
        /// <param name="roundingMethodCode">Enter RoundingMethodCode to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{roundingMethodCode}")]
        [Route("~/api/core/rounding-method/{roundingMethodCode}")]
        public MixERP.Net.Entities.Core.RoundingMethod Get(string roundingMethodCode)
        {
            try
            {
                return this.RoundingMethodContext.Get(roundingMethodCode);
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
        ///     Creates a paginated collection containing 25 rounding methods on each page, sorted by the property RoundingMethodCode.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/core/rounding-method")]
        public IEnumerable<MixERP.Net.Entities.Core.RoundingMethod> GetPagedResult()
        {
            try
            {
                return this.RoundingMethodContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 rounding methods on each page, sorted by the property RoundingMethodCode.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/core/rounding-method/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.RoundingMethod> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.RoundingMethodContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 rounding methods on each page, sorted by the property RoundingMethodCode.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/core/rounding-method/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.RoundingMethod> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.RoundingMethodContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of rounding methods.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of rounding methods.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/core/rounding-method/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.RoundingMethodContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for rounding methods.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of rounding methods.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/rounding-method/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.RoundingMethodContext.GetCustomFields();
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
        /// <param name="roundingMethod">Your instance of rounding methods class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{roundingMethod}")]
        [Route("~/api/core/rounding-method/add/{roundingMethod}")]
        public void Add(MixERP.Net.Entities.Core.RoundingMethod roundingMethod)
        {
            if (roundingMethod == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.RoundingMethodContext.Add(roundingMethod);
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
        /// <param name="roundingMethod">Your instance of Account class to edit.</param>
        /// <param name="roundingMethodCode">Enter the value for RoundingMethodCode in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{roundingMethodCode}/{roundingMethod}")]
        [Route("~/api/core/rounding-method/edit/{roundingMethodCode}/{roundingMethod}")]
        public void Edit(string roundingMethodCode, MixERP.Net.Entities.Core.RoundingMethod roundingMethod)
        {
            if (roundingMethod == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.RoundingMethodContext.Update(roundingMethod, roundingMethodCode);
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
        ///     Deletes an existing instance of Account class via RoundingMethodCode.
        /// </summary>
        /// <param name="roundingMethodCode">Enter the value for RoundingMethodCode in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{roundingMethodCode}")]
        [Route("~/api/core/rounding-method/delete/{roundingMethodCode}")]
        public void Delete(string roundingMethodCode)
        {
            try
            {
                this.RoundingMethodContext.Delete(roundingMethodCode);
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