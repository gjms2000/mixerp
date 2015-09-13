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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Day Operation Routines.
    /// </summary>
    [RoutePrefix("api/v1.5/transactions/day-operation-routine")]
    public class DayOperationRoutineController : ApiController
    {
        /// <summary>
        ///     The DayOperationRoutine data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Transactions.Data.DayOperationRoutine DayOperationRoutineContext;

        public DayOperationRoutineController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.DayOperationRoutineContext = new MixERP.Net.Schemas.Transactions.Data.DayOperationRoutine
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
        ///     Counts the number of day operation routines.
        /// </summary>
        /// <returns>Returns the count of the day operation routines.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/transactions/day-operation-routine/count")]
        public long Count()
        {
            try
            {
                return this.DayOperationRoutineContext.Count();
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
        ///     Returns an instance of day operation routine.
        /// </summary>
        /// <param name="dayOperationRoutineId">Enter DayOperationRoutineId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{dayOperationRoutineId}")]
        [Route("~/api/transactions/day-operation-routine/{dayOperationRoutineId}")]
        public MixERP.Net.Entities.Transactions.DayOperationRoutine Get(long dayOperationRoutineId)
        {
            try
            {
                return this.DayOperationRoutineContext.Get(dayOperationRoutineId);
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
        [Route("~/api/transactions/day-operation-routine/get")]
        public IEnumerable<MixERP.Net.Entities.Transactions.DayOperationRoutine> Get([FromUri] long[] dayOperationRoutineIds)
        {
            try
            {
                return this.DayOperationRoutineContext.Get(dayOperationRoutineIds);
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
        ///     Creates a paginated collection containing 25 day operation routines on each page, sorted by the property DayOperationRoutineId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/transactions/day-operation-routine")]
        public IEnumerable<MixERP.Net.Entities.Transactions.DayOperationRoutine> GetPagedResult()
        {
            try
            {
                return this.DayOperationRoutineContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 day operation routines on each page, sorted by the property DayOperationRoutineId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/transactions/day-operation-routine/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Transactions.DayOperationRoutine> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.DayOperationRoutineContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 day operation routines on each page, sorted by the property DayOperationRoutineId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/transactions/day-operation-routine/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Transactions.DayOperationRoutine> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.DayOperationRoutineContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of day operation routines.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of day operation routines.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/transactions/day-operation-routine/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.DayOperationRoutineContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for day operation routines.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of day operation routines.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/transactions/day-operation-routine/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.DayOperationRoutineContext.GetCustomFields(null);
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
        ///     A custom field is a user defined field for day operation routines.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of day operation routines.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/transactions/day-operation-routine/custom-fields/{resourceId}")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
        {
            try
            {
                return this.DayOperationRoutineContext.GetCustomFields(resourceId);
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
        ///     Adds or edits your instance of DayOperationRoutine class.
        /// </summary>
        /// <param name="dayOperationRoutine">Your instance of day operation routines class to add or edit.</param>
        [AcceptVerbs("PUT")]
        [Route("add-or-edit")]
        [Route("~/api/transactions/day-operation-routine/add-or-edit")]
        public void AddOrEdit([FromBody]MixERP.Net.Entities.Transactions.DayOperationRoutine dayOperationRoutine)
        {
            if (dayOperationRoutine == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.DayOperationRoutineContext.AddOrEdit(dayOperationRoutine);
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
        ///     Adds your instance of DayOperationRoutine class.
        /// </summary>
        /// <param name="dayOperationRoutine">Your instance of day operation routines class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{dayOperationRoutine}")]
        [Route("~/api/transactions/day-operation-routine/add/{dayOperationRoutine}")]
        public void Add(MixERP.Net.Entities.Transactions.DayOperationRoutine dayOperationRoutine)
        {
            if (dayOperationRoutine == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.DayOperationRoutineContext.Add(dayOperationRoutine);
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
        ///     Edits existing record with your instance of DayOperationRoutine class.
        /// </summary>
        /// <param name="dayOperationRoutine">Your instance of DayOperationRoutine class to edit.</param>
        /// <param name="dayOperationRoutineId">Enter the value for DayOperationRoutineId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{dayOperationRoutineId}")]
        [Route("~/api/transactions/day-operation-routine/edit/{dayOperationRoutineId}")]
        public void Edit(long dayOperationRoutineId, [FromBody] MixERP.Net.Entities.Transactions.DayOperationRoutine dayOperationRoutine)
        {
            if (dayOperationRoutine == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.DayOperationRoutineContext.Update(dayOperationRoutine, dayOperationRoutineId);
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
        ///     Deletes an existing instance of DayOperationRoutine class via DayOperationRoutineId.
        /// </summary>
        /// <param name="dayOperationRoutineId">Enter the value for DayOperationRoutineId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{dayOperationRoutineId}")]
        [Route("~/api/transactions/day-operation-routine/delete/{dayOperationRoutineId}")]
        public void Delete(long dayOperationRoutineId)
        {
            try
            {
                this.DayOperationRoutineContext.Delete(dayOperationRoutineId);
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