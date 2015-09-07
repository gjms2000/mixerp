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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Stock Master Non Gl Relations.
    /// </summary>
    [RoutePrefix("api/v1.5/transactions/stock-master-non-gl-relation")]
    public class StockMasterNonGlRelationController : ApiController
    {
        /// <summary>
        ///     The StockMasterNonGlRelation data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Transactions.Data.StockMasterNonGlRelation StockMasterNonGlRelationContext;

        public StockMasterNonGlRelationController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.StockMasterNonGlRelationContext = new MixERP.Net.Schemas.Transactions.Data.StockMasterNonGlRelation
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
        ///     Counts the number of stock master non gl relations.
        /// </summary>
        /// <returns>Returns the count of the stock master non gl relations.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/transactions/stock-master-non-gl-relation/count")]
        public long Count()
        {
            try
            {
                return this.StockMasterNonGlRelationContext.Count();
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Unauthorized));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Returns an instance of stock master non gl relation.
        /// </summary>
        /// <param name="stockMasterNonGlRelationId">Enter StockMasterNonGlRelationId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{stockMasterNonGlRelationId}")]
        [Route("~/api/transactions/stock-master-non-gl-relation/{stockMasterNonGlRelationId}")]
        public MixERP.Net.Entities.Transactions.StockMasterNonGlRelation Get(long stockMasterNonGlRelationId)
        {
            try
            {
                return this.StockMasterNonGlRelationContext.Get(stockMasterNonGlRelationId);
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Unauthorized));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Creates a paginated collection containing 25 stock master non gl relations on each page, sorted by the property StockMasterNonGlRelationId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/transactions/stock-master-non-gl-relation")]
        public IEnumerable<MixERP.Net.Entities.Transactions.StockMasterNonGlRelation> GetPagedResult()
        {
            try
            {
                return this.StockMasterNonGlRelationContext.GetPagedResult();
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Unauthorized));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Creates a paginated collection containing 25 stock master non gl relations on each page, sorted by the property StockMasterNonGlRelationId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/transactions/stock-master-non-gl-relation/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Transactions.StockMasterNonGlRelation> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.StockMasterNonGlRelationContext.GetPagedResult(pageNumber);
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Unauthorized));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Creates a filtered and paginated collection containing 25 stock master non gl relations on each page, sorted by the property StockMasterNonGlRelationId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/transactions/stock-master-non-gl-relation/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Transactions.StockMasterNonGlRelation> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.StockMasterNonGlRelationContext.GetWhere(pageNumber, f);
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Unauthorized));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Displayfields is a lightweight key/value collection of stock master non gl relations.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of stock master non gl relations.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/transactions/stock-master-non-gl-relation/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.StockMasterNonGlRelationContext.GetDisplayFields();
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Unauthorized));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Adds your instance of Account class.
        /// </summary>
        /// <param name="stockMasterNonGlRelation">Your instance of stock master non gl relations class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{stockMasterNonGlRelation}")]
        [Route("~/api/transactions/stock-master-non-gl-relation/add/{stockMasterNonGlRelation}")]
        public void Add(MixERP.Net.Entities.Transactions.StockMasterNonGlRelation stockMasterNonGlRelation)
        {
            if (stockMasterNonGlRelation == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.StockMasterNonGlRelationContext.Add(stockMasterNonGlRelation);
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Unauthorized));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Edits existing record with your instance of Account class.
        /// </summary>
        /// <param name="stockMasterNonGlRelation">Your instance of Account class to edit.</param>
        /// <param name="stockMasterNonGlRelationId">Enter the value for StockMasterNonGlRelationId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{stockMasterNonGlRelationId}/{stockMasterNonGlRelation}")]
        [Route("~/api/transactions/stock-master-non-gl-relation/edit/{stockMasterNonGlRelationId}/{stockMasterNonGlRelation}")]
        public void Edit(long stockMasterNonGlRelationId, MixERP.Net.Entities.Transactions.StockMasterNonGlRelation stockMasterNonGlRelation)
        {
            if (stockMasterNonGlRelation == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.StockMasterNonGlRelationContext.Update(stockMasterNonGlRelation, stockMasterNonGlRelationId);
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Unauthorized));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Deletes an existing instance of Account class via StockMasterNonGlRelationId.
        /// </summary>
        /// <param name="stockMasterNonGlRelationId">Enter the value for StockMasterNonGlRelationId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{stockMasterNonGlRelationId}")]
        [Route("~/api/transactions/stock-master-non-gl-relation/delete/{stockMasterNonGlRelationId}")]
        public void Delete(long stockMasterNonGlRelationId)
        {
            try
            {
                this.StockMasterNonGlRelationContext.Delete(stockMasterNonGlRelationId);
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Unauthorized));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }


    }
}