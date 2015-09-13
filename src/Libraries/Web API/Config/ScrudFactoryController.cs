using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using MixERP.Net.EntityParser;
using Newtonsoft.Json;
using PetaPoco;

namespace MixERP.Net.Api.Config
{
    /// <summary>
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Scrud Factories.
    /// </summary>
    [RoutePrefix("api/v1.5/config/scrud-factory")]
    public class ScrudFactoryController : ApiController
    {
        /// <summary>
        ///     The ScrudFactory data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Config.Data.ScrudFactory ScrudFactoryContext;

        public ScrudFactoryController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.ScrudFactoryContext = new MixERP.Net.Schemas.Config.Data.ScrudFactory
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
        ///     Counts the number of scrud factories.
        /// </summary>
        /// <returns>Returns the count of the scrud factories.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/config/scrud-factory/count")]
        public long Count()
        {
            try
            {
                return this.ScrudFactoryContext.Count();
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
        ///     Returns an instance of scrud factory.
        /// </summary>
        /// <param name="key">Enter Key to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{key}")]
        [Route("~/api/config/scrud-factory/{key}")]
        public MixERP.Net.Entities.Config.ScrudFactory Get(string key)
        {
            try
            {
                return this.ScrudFactoryContext.Get(key);
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
        [Route("~/api/config/scrud-factory/get")]
        public IEnumerable<MixERP.Net.Entities.Config.ScrudFactory> Get([FromUri] string[] keys)
        {
            try
            {
                return this.ScrudFactoryContext.Get(keys);
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
        ///     Creates a paginated collection containing 25 scrud factories on each page, sorted by the property Key.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/config/scrud-factory")]
        public IEnumerable<MixERP.Net.Entities.Config.ScrudFactory> GetPagedResult()
        {
            try
            {
                return this.ScrudFactoryContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 scrud factories on each page, sorted by the property Key.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/config/scrud-factory/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Config.ScrudFactory> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.ScrudFactoryContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 scrud factories on each page, sorted by the property Key.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/config/scrud-factory/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Config.ScrudFactory> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.ScrudFactoryContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of scrud factories.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of scrud factories.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/config/scrud-factory/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.ScrudFactoryContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for scrud factories.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of scrud factories.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/config/scrud-factory/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.ScrudFactoryContext.GetCustomFields(null);
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
        ///     A custom field is a user defined field for scrud factories.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of scrud factories.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/config/scrud-factory/custom-fields/{resourceId}")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
        {
            try
            {
                return this.ScrudFactoryContext.GetCustomFields(resourceId);
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
        ///     Adds or edits your instance of ScrudFactory class.
        /// </summary>
        /// <param name="scrudFactory">Your instance of scrud factories class to add or edit.</param>
        [AcceptVerbs("PUT")]
        [Route("add-or-edit")]
        [Route("~/api/config/scrud-factory/add-or-edit")]
        public void AddOrEdit([FromBody]MixERP.Net.Entities.Config.ScrudFactory scrudFactory)
        {
            if (scrudFactory == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.ScrudFactoryContext.AddOrEdit(scrudFactory);
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
        ///     Adds your instance of ScrudFactory class.
        /// </summary>
        /// <param name="scrudFactory">Your instance of scrud factories class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{scrudFactory}")]
        [Route("~/api/config/scrud-factory/add/{scrudFactory}")]
        public void Add(MixERP.Net.Entities.Config.ScrudFactory scrudFactory)
        {
            if (scrudFactory == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.ScrudFactoryContext.Add(scrudFactory);
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
        ///     Edits existing record with your instance of ScrudFactory class.
        /// </summary>
        /// <param name="scrudFactory">Your instance of ScrudFactory class to edit.</param>
        /// <param name="key">Enter the value for Key in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{key}")]
        [Route("~/api/config/scrud-factory/edit/{key}")]
        public void Edit(string key, [FromBody] MixERP.Net.Entities.Config.ScrudFactory scrudFactory)
        {
            if (scrudFactory == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.ScrudFactoryContext.Update(scrudFactory, key);
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
        ///     Deletes an existing instance of ScrudFactory class via Key.
        /// </summary>
        /// <param name="key">Enter the value for Key in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{key}")]
        [Route("~/api/config/scrud-factory/delete/{key}")]
        public void Delete(string key)
        {
            try
            {
                this.ScrudFactoryContext.Delete(key);
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