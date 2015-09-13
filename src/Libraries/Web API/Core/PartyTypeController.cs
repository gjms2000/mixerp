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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Party Types.
    /// </summary>
    [RoutePrefix("api/v1.5/core/party-type")]
    public class PartyTypeController : ApiController
    {
        /// <summary>
        ///     The PartyType data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Core.Data.PartyType PartyTypeContext;

        public PartyTypeController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.PartyTypeContext = new MixERP.Net.Schemas.Core.Data.PartyType
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
        ///     Counts the number of party types.
        /// </summary>
        /// <returns>Returns the count of the party types.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/core/party-type/count")]
        public long Count()
        {
            try
            {
                return this.PartyTypeContext.Count();
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
        ///     Returns an instance of party type.
        /// </summary>
        /// <param name="partyTypeId">Enter PartyTypeId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{partyTypeId}")]
        [Route("~/api/core/party-type/{partyTypeId}")]
        public MixERP.Net.Entities.Core.PartyType Get(int partyTypeId)
        {
            try
            {
                return this.PartyTypeContext.Get(partyTypeId);
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
        [Route("~/api/core/party-type/get")]
        public IEnumerable<MixERP.Net.Entities.Core.PartyType> Get([FromUri] int[] partyTypeIds)
        {
            try
            {
                return this.PartyTypeContext.Get(partyTypeIds);
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
        ///     Creates a paginated collection containing 25 party types on each page, sorted by the property PartyTypeId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/core/party-type")]
        public IEnumerable<MixERP.Net.Entities.Core.PartyType> GetPagedResult()
        {
            try
            {
                return this.PartyTypeContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 party types on each page, sorted by the property PartyTypeId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/core/party-type/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.PartyType> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.PartyTypeContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 party types on each page, sorted by the property PartyTypeId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/core/party-type/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.PartyType> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.PartyTypeContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of party types.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of party types.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/core/party-type/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.PartyTypeContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for party types.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of party types.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/party-type/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.PartyTypeContext.GetCustomFields(null);
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
        ///     A custom field is a user defined field for party types.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of party types.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/party-type/custom-fields/{resourceId}")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
        {
            try
            {
                return this.PartyTypeContext.GetCustomFields(resourceId);
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
        ///     Adds or edits your instance of PartyType class.
        /// </summary>
        /// <param name="partyType">Your instance of party types class to add or edit.</param>
        [AcceptVerbs("PUT")]
        [Route("add-or-edit")]
        [Route("~/api/core/party-type/add-or-edit")]
        public void AddOrEdit([FromBody]MixERP.Net.Entities.Core.PartyType partyType)
        {
            if (partyType == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.PartyTypeContext.AddOrEdit(partyType);
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
        ///     Adds your instance of PartyType class.
        /// </summary>
        /// <param name="partyType">Your instance of party types class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{partyType}")]
        [Route("~/api/core/party-type/add/{partyType}")]
        public void Add(MixERP.Net.Entities.Core.PartyType partyType)
        {
            if (partyType == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.PartyTypeContext.Add(partyType);
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
        ///     Edits existing record with your instance of PartyType class.
        /// </summary>
        /// <param name="partyType">Your instance of PartyType class to edit.</param>
        /// <param name="partyTypeId">Enter the value for PartyTypeId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{partyTypeId}")]
        [Route("~/api/core/party-type/edit/{partyTypeId}")]
        public void Edit(int partyTypeId, [FromBody] MixERP.Net.Entities.Core.PartyType partyType)
        {
            if (partyType == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.PartyTypeContext.Update(partyType, partyTypeId);
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
        ///     Deletes an existing instance of PartyType class via PartyTypeId.
        /// </summary>
        /// <param name="partyTypeId">Enter the value for PartyTypeId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{partyTypeId}")]
        [Route("~/api/core/party-type/delete/{partyTypeId}")]
        public void Delete(int partyTypeId)
        {
            try
            {
                this.PartyTypeContext.Delete(partyTypeId);
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