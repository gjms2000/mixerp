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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Salespeople.
    /// </summary>
    [RoutePrefix("api/v1.5/core/salesperson")]
    public class SalespersonController : ApiController
    {
        /// <summary>
        ///     The Salesperson data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Core.Data.Salesperson SalespersonContext;

        public SalespersonController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.SalespersonContext = new MixERP.Net.Schemas.Core.Data.Salesperson
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
        ///     Counts the number of salespeople.
        /// </summary>
        /// <returns>Returns the count of the salespeople.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/core/salesperson/count")]
        public long Count()
        {
            try
            {
                return this.SalespersonContext.Count();
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
        ///     Returns an instance of salesperson.
        /// </summary>
        /// <param name="salespersonId">Enter SalespersonId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{salespersonId}")]
        [Route("~/api/core/salesperson/{salespersonId}")]
        public MixERP.Net.Entities.Core.Salesperson Get(int salespersonId)
        {
            try
            {
                return this.SalespersonContext.Get(salespersonId);
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
        [Route("~/api/core/salesperson/get")]
        public IEnumerable<MixERP.Net.Entities.Core.Salesperson> Get([FromUri] int[] salespersonIds)
        {
            try
            {
                return this.SalespersonContext.Get(salespersonIds);
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
        ///     Creates a paginated collection containing 25 salespeople on each page, sorted by the property SalespersonId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/core/salesperson")]
        public IEnumerable<MixERP.Net.Entities.Core.Salesperson> GetPagedResult()
        {
            try
            {
                return this.SalespersonContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 salespeople on each page, sorted by the property SalespersonId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/core/salesperson/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.Salesperson> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.SalespersonContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 salespeople on each page, sorted by the property SalespersonId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/core/salesperson/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.Salesperson> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.SalespersonContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of salespeople.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of salespeople.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/core/salesperson/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.SalespersonContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for salespeople.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of salespeople.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/salesperson/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.SalespersonContext.GetCustomFields(null);
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
        ///     A custom field is a user defined field for salespeople.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of salespeople.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/salesperson/custom-fields/{resourceId}")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
        {
            try
            {
                return this.SalespersonContext.GetCustomFields(resourceId);
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
        ///     Adds or edits your instance of Salesperson class.
        /// </summary>
        /// <param name="salesperson">Your instance of salespeople class to add or edit.</param>
        [AcceptVerbs("PUT")]
        [Route("add-or-edit")]
        [Route("~/api/core/salesperson/add-or-edit")]
        public void AddOrEdit([FromBody]MixERP.Net.Entities.Core.Salesperson salesperson)
        {
            if (salesperson == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.SalespersonContext.AddOrEdit(salesperson);
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
        ///     Adds your instance of Salesperson class.
        /// </summary>
        /// <param name="salesperson">Your instance of salespeople class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{salesperson}")]
        [Route("~/api/core/salesperson/add/{salesperson}")]
        public void Add(MixERP.Net.Entities.Core.Salesperson salesperson)
        {
            if (salesperson == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.SalespersonContext.Add(salesperson);
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
        ///     Edits existing record with your instance of Salesperson class.
        /// </summary>
        /// <param name="salesperson">Your instance of Salesperson class to edit.</param>
        /// <param name="salespersonId">Enter the value for SalespersonId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{salespersonId}")]
        [Route("~/api/core/salesperson/edit/{salespersonId}")]
        public void Edit(int salespersonId, [FromBody] MixERP.Net.Entities.Core.Salesperson salesperson)
        {
            if (salesperson == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.SalespersonContext.Update(salesperson, salespersonId);
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
        ///     Deletes an existing instance of Salesperson class via SalespersonId.
        /// </summary>
        /// <param name="salespersonId">Enter the value for SalespersonId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{salespersonId}")]
        [Route("~/api/core/salesperson/delete/{salespersonId}")]
        public void Delete(int salespersonId)
        {
            try
            {
                this.SalespersonContext.Delete(salespersonId);
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