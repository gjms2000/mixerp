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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Compound Items.
    /// </summary>
    [RoutePrefix("api/v1.5/core/compound-item")]
    public class CompoundItemController : ApiController
    {
        /// <summary>
        ///     The CompoundItem data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Core.Data.CompoundItem CompoundItemContext;

        public CompoundItemController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.CompoundItemContext = new MixERP.Net.Schemas.Core.Data.CompoundItem
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
        ///     Counts the number of compound items.
        /// </summary>
        /// <returns>Returns the count of the compound items.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/core/compound-item/count")]
        public long Count()
        {
            try
            {
                return this.CompoundItemContext.Count();
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
        ///     Returns an instance of compound item.
        /// </summary>
        /// <param name="compoundItemId">Enter CompoundItemId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{compoundItemId}")]
        [Route("~/api/core/compound-item/{compoundItemId}")]
        public MixERP.Net.Entities.Core.CompoundItem Get(int compoundItemId)
        {
            try
            {
                return this.CompoundItemContext.Get(compoundItemId);
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
        [Route("~/api/core/compound-item/get")]
        public IEnumerable<MixERP.Net.Entities.Core.CompoundItem> Get([FromUri] int[] compoundItemIds)
        {
            try
            {
                return this.CompoundItemContext.Get(compoundItemIds);
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
        ///     Creates a paginated collection containing 25 compound items on each page, sorted by the property CompoundItemId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/core/compound-item")]
        public IEnumerable<MixERP.Net.Entities.Core.CompoundItem> GetPagedResult()
        {
            try
            {
                return this.CompoundItemContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 compound items on each page, sorted by the property CompoundItemId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/core/compound-item/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.CompoundItem> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.CompoundItemContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 compound items on each page, sorted by the property CompoundItemId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/core/compound-item/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.CompoundItem> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.CompoundItemContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of compound items.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of compound items.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/core/compound-item/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.CompoundItemContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for compound items.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of compound items.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/compound-item/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.CompoundItemContext.GetCustomFields(null);
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
        ///     A custom field is a user defined field for compound items.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of compound items.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/compound-item/custom-fields/{resourceId}")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
        {
            try
            {
                return this.CompoundItemContext.GetCustomFields(resourceId);
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
        ///     Adds or edits your instance of CompoundItem class.
        /// </summary>
        /// <param name="compoundItem">Your instance of compound items class to add or edit.</param>
        [AcceptVerbs("PUT")]
        [Route("add-or-edit")]
        [Route("~/api/core/compound-item/add-or-edit")]
        public void AddOrEdit([FromBody]MixERP.Net.Entities.Core.CompoundItem compoundItem)
        {
            if (compoundItem == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.CompoundItemContext.AddOrEdit(compoundItem);
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
        ///     Adds your instance of CompoundItem class.
        /// </summary>
        /// <param name="compoundItem">Your instance of compound items class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{compoundItem}")]
        [Route("~/api/core/compound-item/add/{compoundItem}")]
        public void Add(MixERP.Net.Entities.Core.CompoundItem compoundItem)
        {
            if (compoundItem == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.CompoundItemContext.Add(compoundItem);
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
        ///     Edits existing record with your instance of CompoundItem class.
        /// </summary>
        /// <param name="compoundItem">Your instance of CompoundItem class to edit.</param>
        /// <param name="compoundItemId">Enter the value for CompoundItemId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{compoundItemId}")]
        [Route("~/api/core/compound-item/edit/{compoundItemId}")]
        public void Edit(int compoundItemId, [FromBody] MixERP.Net.Entities.Core.CompoundItem compoundItem)
        {
            if (compoundItem == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.CompoundItemContext.Update(compoundItem, compoundItemId);
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
        ///     Deletes an existing instance of CompoundItem class via CompoundItemId.
        /// </summary>
        /// <param name="compoundItemId">Enter the value for CompoundItemId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{compoundItemId}")]
        [Route("~/api/core/compound-item/delete/{compoundItemId}")]
        public void Delete(int compoundItemId)
        {
            try
            {
                this.CompoundItemContext.Delete(compoundItemId);
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