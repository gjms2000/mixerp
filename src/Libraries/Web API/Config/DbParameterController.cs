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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Db Parameters.
    /// </summary>
    [RoutePrefix("api/v1.5/config/db-parameter")]
    public class DbParameterController : ApiController
    {
        /// <summary>
        ///     The DbParameter data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Config.Data.DbParameter DbParameterContext;

        public DbParameterController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.DbParameterContext = new MixERP.Net.Schemas.Config.Data.DbParameter
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
        ///     Counts the number of db parameters.
        /// </summary>
        /// <returns>Returns the count of the db parameters.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/config/db-parameter/count")]
        public long Count()
        {
            try
            {
                return this.DbParameterContext.Count();
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
        ///     Returns an instance of db parameter.
        /// </summary>
        /// <param name="key">Enter Key to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{key}")]
        [Route("~/api/config/db-parameter/{key}")]
        public MixERP.Net.Entities.Config.DbParameter Get(string key)
        {
            try
            {
                return this.DbParameterContext.Get(key);
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
        [Route("~/api/config/db-parameter/get")]
        public IEnumerable<MixERP.Net.Entities.Config.DbParameter> Get([FromUri] string[] keys)
        {
            try
            {
                return this.DbParameterContext.Get(keys);
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
        ///     Creates a paginated collection containing 25 db parameters on each page, sorted by the property Key.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/config/db-parameter")]
        public IEnumerable<MixERP.Net.Entities.Config.DbParameter> GetPagedResult()
        {
            try
            {
                return this.DbParameterContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 db parameters on each page, sorted by the property Key.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/config/db-parameter/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Config.DbParameter> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.DbParameterContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 db parameters on each page, sorted by the property Key.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/config/db-parameter/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Config.DbParameter> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.DbParameterContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of db parameters.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of db parameters.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/config/db-parameter/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.DbParameterContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for db parameters.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of db parameters.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/config/db-parameter/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.DbParameterContext.GetCustomFields(null);
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
        ///     A custom field is a user defined field for db parameters.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of db parameters.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/config/db-parameter/custom-fields/{resourceId}")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
        {
            try
            {
                return this.DbParameterContext.GetCustomFields(resourceId);
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
        ///     Adds or edits your instance of DbParameter class.
        /// </summary>
        /// <param name="dbParameter">Your instance of db parameters class to add or edit.</param>
        [AcceptVerbs("PUT")]
        [Route("add-or-edit")]
        [Route("~/api/config/db-parameter/add-or-edit")]
        public void AddOrEdit([FromBody]MixERP.Net.Entities.Config.DbParameter dbParameter)
        {
            if (dbParameter == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.DbParameterContext.AddOrEdit(dbParameter);
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
        ///     Adds your instance of DbParameter class.
        /// </summary>
        /// <param name="dbParameter">Your instance of db parameters class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{dbParameter}")]
        [Route("~/api/config/db-parameter/add/{dbParameter}")]
        public void Add(MixERP.Net.Entities.Config.DbParameter dbParameter)
        {
            if (dbParameter == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.DbParameterContext.Add(dbParameter);
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
        ///     Edits existing record with your instance of DbParameter class.
        /// </summary>
        /// <param name="dbParameter">Your instance of DbParameter class to edit.</param>
        /// <param name="key">Enter the value for Key in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{key}")]
        [Route("~/api/config/db-parameter/edit/{key}")]
        public void Edit(string key, [FromBody] MixERP.Net.Entities.Config.DbParameter dbParameter)
        {
            if (dbParameter == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.DbParameterContext.Update(dbParameter, key);
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
        ///     Deletes an existing instance of DbParameter class via Key.
        /// </summary>
        /// <param name="key">Enter the value for Key in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{key}")]
        [Route("~/api/config/db-parameter/delete/{key}")]
        public void Delete(string key)
        {
            try
            {
                this.DbParameterContext.Delete(key);
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