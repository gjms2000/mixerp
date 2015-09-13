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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Cash Repositories.
    /// </summary>
    [RoutePrefix("api/v1.5/office/cash-repository")]
    public class CashRepositoryController : ApiController
    {
        /// <summary>
        ///     The CashRepository data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Office.Data.CashRepository CashRepositoryContext;

        public CashRepositoryController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.CashRepositoryContext = new MixERP.Net.Schemas.Office.Data.CashRepository
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
        ///     Counts the number of cash repositories.
        /// </summary>
        /// <returns>Returns the count of the cash repositories.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/office/cash-repository/count")]
        public long Count()
        {
            try
            {
                return this.CashRepositoryContext.Count();
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
        ///     Returns an instance of cash repository.
        /// </summary>
        /// <param name="cashRepositoryId">Enter CashRepositoryId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{cashRepositoryId}")]
        [Route("~/api/office/cash-repository/{cashRepositoryId}")]
        public MixERP.Net.Entities.Office.CashRepository Get(int cashRepositoryId)
        {
            try
            {
                return this.CashRepositoryContext.Get(cashRepositoryId);
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
        [Route("~/api/office/cash-repository/get")]
        public IEnumerable<MixERP.Net.Entities.Office.CashRepository> Get([FromUri] int[] cashRepositoryIds)
        {
            try
            {
                return this.CashRepositoryContext.Get(cashRepositoryIds);
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
        ///     Creates a paginated collection containing 25 cash repositories on each page, sorted by the property CashRepositoryId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/office/cash-repository")]
        public IEnumerable<MixERP.Net.Entities.Office.CashRepository> GetPagedResult()
        {
            try
            {
                return this.CashRepositoryContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 cash repositories on each page, sorted by the property CashRepositoryId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/office/cash-repository/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Office.CashRepository> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.CashRepositoryContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 cash repositories on each page, sorted by the property CashRepositoryId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/office/cash-repository/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Office.CashRepository> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.CashRepositoryContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of cash repositories.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of cash repositories.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/office/cash-repository/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.CashRepositoryContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for cash repositories.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of cash repositories.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/office/cash-repository/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.CashRepositoryContext.GetCustomFields(null);
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
        ///     A custom field is a user defined field for cash repositories.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of cash repositories.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/office/cash-repository/custom-fields/{resourceId}")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
        {
            try
            {
                return this.CashRepositoryContext.GetCustomFields(resourceId);
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
        ///     Adds or edits your instance of CashRepository class.
        /// </summary>
        /// <param name="cashRepository">Your instance of cash repositories class to add or edit.</param>
        [AcceptVerbs("PUT")]
        [Route("add-or-edit")]
        [Route("~/api/office/cash-repository/add-or-edit")]
        public void AddOrEdit([FromBody]MixERP.Net.Entities.Office.CashRepository cashRepository)
        {
            if (cashRepository == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.CashRepositoryContext.AddOrEdit(cashRepository);
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
        ///     Adds your instance of CashRepository class.
        /// </summary>
        /// <param name="cashRepository">Your instance of cash repositories class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{cashRepository}")]
        [Route("~/api/office/cash-repository/add/{cashRepository}")]
        public void Add(MixERP.Net.Entities.Office.CashRepository cashRepository)
        {
            if (cashRepository == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.CashRepositoryContext.Add(cashRepository);
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
        ///     Edits existing record with your instance of CashRepository class.
        /// </summary>
        /// <param name="cashRepository">Your instance of CashRepository class to edit.</param>
        /// <param name="cashRepositoryId">Enter the value for CashRepositoryId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{cashRepositoryId}")]
        [Route("~/api/office/cash-repository/edit/{cashRepositoryId}")]
        public void Edit(int cashRepositoryId, [FromBody] MixERP.Net.Entities.Office.CashRepository cashRepository)
        {
            if (cashRepository == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.CashRepositoryContext.Update(cashRepository, cashRepositoryId);
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
        ///     Deletes an existing instance of CashRepository class via CashRepositoryId.
        /// </summary>
        /// <param name="cashRepositoryId">Enter the value for CashRepositoryId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{cashRepositoryId}")]
        [Route("~/api/office/cash-repository/delete/{cashRepositoryId}")]
        public void Delete(int cashRepositoryId)
        {
            try
            {
                this.CashRepositoryContext.Delete(cashRepositoryId);
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