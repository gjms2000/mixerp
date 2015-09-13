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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Ageing Slabs.
    /// </summary>
    [RoutePrefix("api/v1.5/core/ageing-slab")]
    public class AgeingSlabController : ApiController
    {
        /// <summary>
        ///     The AgeingSlab data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Core.Data.AgeingSlab AgeingSlabContext;

        public AgeingSlabController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.AgeingSlabContext = new MixERP.Net.Schemas.Core.Data.AgeingSlab
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
        ///     Counts the number of ageing slabs.
        /// </summary>
        /// <returns>Returns the count of the ageing slabs.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/core/ageing-slab/count")]
        public long Count()
        {
            try
            {
                return this.AgeingSlabContext.Count();
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
        ///     Returns an instance of ageing slab.
        /// </summary>
        /// <param name="ageingSlabId">Enter AgeingSlabId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{ageingSlabId}")]
        [Route("~/api/core/ageing-slab/{ageingSlabId}")]
        public MixERP.Net.Entities.Core.AgeingSlab Get(int ageingSlabId)
        {
            try
            {
                return this.AgeingSlabContext.Get(ageingSlabId);
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
        [Route("~/api/core/ageing-slab/get")]
        public IEnumerable<MixERP.Net.Entities.Core.AgeingSlab> Get([FromUri] int[] ageingSlabIds)
        {
            try
            {
                return this.AgeingSlabContext.Get(ageingSlabIds);
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
        ///     Creates a paginated collection containing 25 ageing slabs on each page, sorted by the property AgeingSlabId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/core/ageing-slab")]
        public IEnumerable<MixERP.Net.Entities.Core.AgeingSlab> GetPagedResult()
        {
            try
            {
                return this.AgeingSlabContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 ageing slabs on each page, sorted by the property AgeingSlabId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/core/ageing-slab/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.AgeingSlab> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.AgeingSlabContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 ageing slabs on each page, sorted by the property AgeingSlabId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/core/ageing-slab/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.AgeingSlab> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.AgeingSlabContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of ageing slabs.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of ageing slabs.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/core/ageing-slab/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.AgeingSlabContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for ageing slabs.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of ageing slabs.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/ageing-slab/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.AgeingSlabContext.GetCustomFields(null);
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
        ///     A custom field is a user defined field for ageing slabs.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of ageing slabs.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/ageing-slab/custom-fields/{resourceId}")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
        {
            try
            {
                return this.AgeingSlabContext.GetCustomFields(resourceId);
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
        ///     Adds or edits your instance of AgeingSlab class.
        /// </summary>
        /// <param name="ageingSlab">Your instance of ageing slabs class to add or edit.</param>
        [AcceptVerbs("PUT")]
        [Route("add-or-edit")]
        [Route("~/api/core/ageing-slab/add-or-edit")]
        public void AddOrEdit([FromBody]MixERP.Net.Entities.Core.AgeingSlab ageingSlab)
        {
            if (ageingSlab == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.AgeingSlabContext.AddOrEdit(ageingSlab);
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
        ///     Adds your instance of AgeingSlab class.
        /// </summary>
        /// <param name="ageingSlab">Your instance of ageing slabs class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{ageingSlab}")]
        [Route("~/api/core/ageing-slab/add/{ageingSlab}")]
        public void Add(MixERP.Net.Entities.Core.AgeingSlab ageingSlab)
        {
            if (ageingSlab == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.AgeingSlabContext.Add(ageingSlab);
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
        ///     Edits existing record with your instance of AgeingSlab class.
        /// </summary>
        /// <param name="ageingSlab">Your instance of AgeingSlab class to edit.</param>
        /// <param name="ageingSlabId">Enter the value for AgeingSlabId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{ageingSlabId}")]
        [Route("~/api/core/ageing-slab/edit/{ageingSlabId}")]
        public void Edit(int ageingSlabId, [FromBody] MixERP.Net.Entities.Core.AgeingSlab ageingSlab)
        {
            if (ageingSlab == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.AgeingSlabContext.Update(ageingSlab, ageingSlabId);
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
        ///     Deletes an existing instance of AgeingSlab class via AgeingSlabId.
        /// </summary>
        /// <param name="ageingSlabId">Enter the value for AgeingSlabId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{ageingSlabId}")]
        [Route("~/api/core/ageing-slab/delete/{ageingSlabId}")]
        public void Delete(int ageingSlabId)
        {
            try
            {
                this.AgeingSlabContext.Delete(ageingSlabId);
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