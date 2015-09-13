using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using MixERP.Net.EntityParser;
using Newtonsoft.Json;
using PetaPoco;

namespace MixERP.Net.Api.Transactions
{
    /// <summary>
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Day Operations.
    /// </summary>
    [RoutePrefix("api/v1.5/transactions/day-operation")]
    public class DayOperationController : ApiController
    {
        /// <summary>
        ///     The DayOperation data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Transactions.Data.DayOperation DayOperationContext;

        public DayOperationController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.DayOperationContext = new MixERP.Net.Schemas.Transactions.Data.DayOperation
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
        ///     Counts the number of day operations.
        /// </summary>
        /// <returns>Returns the count of the day operations.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/transactions/day-operation/count")]
        public long Count()
        {
            try
            {
                return this.DayOperationContext.Count();
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
        ///     Returns an instance of day operation.
        /// </summary>
        /// <param name="dayId">Enter DayId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{dayId}")]
        [Route("~/api/transactions/day-operation/{dayId}")]
        public MixERP.Net.Entities.Transactions.DayOperation Get(long dayId)
        {
            try
            {
                return this.DayOperationContext.Get(dayId);
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
        [Route("~/api/transactions/day-operation/get")]
        public IEnumerable<MixERP.Net.Entities.Transactions.DayOperation> Get([FromUri] long[] dayIds)
        {
            try
            {
                return this.DayOperationContext.Get(dayIds);
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
        ///     Creates a paginated collection containing 25 day operations on each page, sorted by the property DayId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/transactions/day-operation")]
        public IEnumerable<MixERP.Net.Entities.Transactions.DayOperation> GetPagedResult()
        {
            try
            {
                return this.DayOperationContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 day operations on each page, sorted by the property DayId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/transactions/day-operation/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Transactions.DayOperation> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.DayOperationContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 day operations on each page, sorted by the property DayId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/transactions/day-operation/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Transactions.DayOperation> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.DayOperationContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of day operations.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of day operations.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/transactions/day-operation/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.DayOperationContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for day operations.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of day operations.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/transactions/day-operation/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.DayOperationContext.GetCustomFields(null);
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
        ///     A custom field is a user defined field for day operations.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of day operations.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/transactions/day-operation/custom-fields/{resourceId}")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
        {
            try
            {
                return this.DayOperationContext.GetCustomFields(resourceId);
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
        ///     Adds or edits your instance of DayOperation class.
        /// </summary>
        /// <param name="dayOperation">Your instance of day operations class to add or edit.</param>
        [AcceptVerbs("PUT")]
        [Route("add-or-edit")]
        [Route("~/api/transactions/day-operation/add-or-edit")]
        public void AddOrEdit([FromBody]MixERP.Net.Entities.Transactions.DayOperation dayOperation)
        {
            if (dayOperation == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.DayOperationContext.AddOrEdit(dayOperation);
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
        ///     Adds your instance of DayOperation class.
        /// </summary>
        /// <param name="dayOperation">Your instance of day operations class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{dayOperation}")]
        [Route("~/api/transactions/day-operation/add/{dayOperation}")]
        public void Add(MixERP.Net.Entities.Transactions.DayOperation dayOperation)
        {
            if (dayOperation == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.DayOperationContext.Add(dayOperation);
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
        ///     Edits existing record with your instance of DayOperation class.
        /// </summary>
        /// <param name="dayOperation">Your instance of DayOperation class to edit.</param>
        /// <param name="dayId">Enter the value for DayId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{dayId}")]
        [Route("~/api/transactions/day-operation/edit/{dayId}")]
        public void Edit(long dayId, [FromBody] MixERP.Net.Entities.Transactions.DayOperation dayOperation)
        {
            if (dayOperation == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.DayOperationContext.Update(dayOperation, dayId);
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
        ///     Deletes an existing instance of DayOperation class via DayId.
        /// </summary>
        /// <param name="dayId">Enter the value for DayId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{dayId}")]
        [Route("~/api/transactions/day-operation/delete/{dayId}")]
        public void Delete(long dayId)
        {
            try
            {
                this.DayOperationContext.Delete(dayId);
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