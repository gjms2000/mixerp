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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Non Gl Stock Master Relations.
    /// </summary>
    [RoutePrefix("api/v1.5/transactions/non-gl-stock-master-relation")]
    public class NonGlStockMasterRelationController : ApiController
    {
        /// <summary>
        ///     The NonGlStockMasterRelation data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Transactions.Data.NonGlStockMasterRelation NonGlStockMasterRelationContext;

        public NonGlStockMasterRelationController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.NonGlStockMasterRelationContext = new MixERP.Net.Schemas.Transactions.Data.NonGlStockMasterRelation
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
        ///     Counts the number of non gl stock master relations.
        /// </summary>
        /// <returns>Returns the count of the non gl stock master relations.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/transactions/non-gl-stock-master-relation/count")]
        public long Count()
        {
            try
            {
                return this.NonGlStockMasterRelationContext.Count();
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
        ///     Returns an instance of non gl stock master relation.
        /// </summary>
        /// <param name="nonGlStockMasterRelationId">Enter NonGlStockMasterRelationId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{nonGlStockMasterRelationId}")]
        [Route("~/api/transactions/non-gl-stock-master-relation/{nonGlStockMasterRelationId}")]
        public MixERP.Net.Entities.Transactions.NonGlStockMasterRelation Get(long nonGlStockMasterRelationId)
        {
            try
            {
                return this.NonGlStockMasterRelationContext.Get(nonGlStockMasterRelationId);
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
        ///     Creates a paginated collection containing 25 non gl stock master relations on each page, sorted by the property NonGlStockMasterRelationId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/transactions/non-gl-stock-master-relation")]
        public IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockMasterRelation> GetPagedResult()
        {
            try
            {
                return this.NonGlStockMasterRelationContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 non gl stock master relations on each page, sorted by the property NonGlStockMasterRelationId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/transactions/non-gl-stock-master-relation/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockMasterRelation> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.NonGlStockMasterRelationContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 non gl stock master relations on each page, sorted by the property NonGlStockMasterRelationId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/transactions/non-gl-stock-master-relation/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockMasterRelation> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.NonGlStockMasterRelationContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of non gl stock master relations.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of non gl stock master relations.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/transactions/non-gl-stock-master-relation/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.NonGlStockMasterRelationContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for non gl stock master relations.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of non gl stock master relations.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/transactions/non-gl-stock-master-relation/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.NonGlStockMasterRelationContext.GetCustomFields();
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
        /// <param name="nonGlStockMasterRelation">Your instance of non gl stock master relations class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{nonGlStockMasterRelation}")]
        [Route("~/api/transactions/non-gl-stock-master-relation/add/{nonGlStockMasterRelation}")]
        public void Add(MixERP.Net.Entities.Transactions.NonGlStockMasterRelation nonGlStockMasterRelation)
        {
            if (nonGlStockMasterRelation == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.NonGlStockMasterRelationContext.Add(nonGlStockMasterRelation);
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
        /// <param name="nonGlStockMasterRelation">Your instance of Account class to edit.</param>
        /// <param name="nonGlStockMasterRelationId">Enter the value for NonGlStockMasterRelationId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{nonGlStockMasterRelationId}/{nonGlStockMasterRelation}")]
        [Route("~/api/transactions/non-gl-stock-master-relation/edit/{nonGlStockMasterRelationId}/{nonGlStockMasterRelation}")]
        public void Edit(long nonGlStockMasterRelationId, MixERP.Net.Entities.Transactions.NonGlStockMasterRelation nonGlStockMasterRelation)
        {
            if (nonGlStockMasterRelation == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.NonGlStockMasterRelationContext.Update(nonGlStockMasterRelation, nonGlStockMasterRelationId);
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
        ///     Deletes an existing instance of Account class via NonGlStockMasterRelationId.
        /// </summary>
        /// <param name="nonGlStockMasterRelationId">Enter the value for NonGlStockMasterRelationId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{nonGlStockMasterRelationId}")]
        [Route("~/api/transactions/non-gl-stock-master-relation/delete/{nonGlStockMasterRelationId}")]
        public void Delete(long nonGlStockMasterRelationId)
        {
            try
            {
                this.NonGlStockMasterRelationContext.Delete(nonGlStockMasterRelationId);
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