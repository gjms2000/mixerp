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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Item Groups.
    /// </summary>
    [RoutePrefix("api/v1.5/core/item-group")]
    public class ItemGroupController : ApiController
    {
        /// <summary>
        ///     The ItemGroup data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Core.Data.ItemGroup ItemGroupContext;

        public ItemGroupController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.ItemGroupContext = new MixERP.Net.Schemas.Core.Data.ItemGroup
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
        ///     Counts the number of item groups.
        /// </summary>
        /// <returns>Returns the count of the item groups.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/core/item-group/count")]
        public long Count()
        {
            try
            {
                return this.ItemGroupContext.Count();
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
        ///     Returns an instance of item group.
        /// </summary>
        /// <param name="itemGroupId">Enter ItemGroupId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{itemGroupId}")]
        [Route("~/api/core/item-group/{itemGroupId}")]
        public MixERP.Net.Entities.Core.ItemGroup Get(int itemGroupId)
        {
            try
            {
                return this.ItemGroupContext.Get(itemGroupId);
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
        [Route("~/api/core/item-group/get")]
        public IEnumerable<MixERP.Net.Entities.Core.ItemGroup> Get([FromUri] int[] itemGroupIds)
        {
            try
            {
                return this.ItemGroupContext.Get(itemGroupIds);
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
        ///     Creates a paginated collection containing 25 item groups on each page, sorted by the property ItemGroupId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/core/item-group")]
        public IEnumerable<MixERP.Net.Entities.Core.ItemGroup> GetPagedResult()
        {
            try
            {
                return this.ItemGroupContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 item groups on each page, sorted by the property ItemGroupId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/core/item-group/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.ItemGroup> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.ItemGroupContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 item groups on each page, sorted by the property ItemGroupId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/core/item-group/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.ItemGroup> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.ItemGroupContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of item groups.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of item groups.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/core/item-group/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.ItemGroupContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for item groups.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of item groups.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/item-group/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.ItemGroupContext.GetCustomFields(null);
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
        ///     A custom field is a user defined field for item groups.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of item groups.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/item-group/custom-fields/{resourceId}")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
        {
            try
            {
                return this.ItemGroupContext.GetCustomFields(resourceId);
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
        ///     Adds or edits your instance of ItemGroup class.
        /// </summary>
        /// <param name="itemGroup">Your instance of item groups class to add or edit.</param>
        [AcceptVerbs("PUT")]
        [Route("add-or-edit")]
        [Route("~/api/core/item-group/add-or-edit")]
        public void AddOrEdit([FromBody]MixERP.Net.Entities.Core.ItemGroup itemGroup)
        {
            if (itemGroup == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.ItemGroupContext.AddOrEdit(itemGroup);
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
        ///     Adds your instance of ItemGroup class.
        /// </summary>
        /// <param name="itemGroup">Your instance of item groups class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{itemGroup}")]
        [Route("~/api/core/item-group/add/{itemGroup}")]
        public void Add(MixERP.Net.Entities.Core.ItemGroup itemGroup)
        {
            if (itemGroup == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.ItemGroupContext.Add(itemGroup);
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
        ///     Edits existing record with your instance of ItemGroup class.
        /// </summary>
        /// <param name="itemGroup">Your instance of ItemGroup class to edit.</param>
        /// <param name="itemGroupId">Enter the value for ItemGroupId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{itemGroupId}")]
        [Route("~/api/core/item-group/edit/{itemGroupId}")]
        public void Edit(int itemGroupId, [FromBody] MixERP.Net.Entities.Core.ItemGroup itemGroup)
        {
            if (itemGroup == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.ItemGroupContext.Update(itemGroup, itemGroupId);
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
        ///     Deletes an existing instance of ItemGroup class via ItemGroupId.
        /// </summary>
        /// <param name="itemGroupId">Enter the value for ItemGroupId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{itemGroupId}")]
        [Route("~/api/core/item-group/delete/{itemGroupId}")]
        public void Delete(int itemGroupId)
        {
            try
            {
                this.ItemGroupContext.Delete(itemGroupId);
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