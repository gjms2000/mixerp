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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Currency Layers.
    /// </summary>
    [RoutePrefix("api/v1.5/config/currency-layer")]
    public class CurrencyLayerController : ApiController
    {
        /// <summary>
        ///     The CurrencyLayer data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Config.Data.CurrencyLayer CurrencyLayerContext;

        public CurrencyLayerController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.CurrencyLayerContext = new MixERP.Net.Schemas.Config.Data.CurrencyLayer
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
        ///     Counts the number of currency layers.
        /// </summary>
        /// <returns>Returns the count of the currency layers.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/config/currency-layer/count")]
        public long Count()
        {
            try
            {
                return this.CurrencyLayerContext.Count();
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
        ///     Returns an instance of currency layer.
        /// </summary>
        /// <param name="key">Enter Key to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{key}")]
        [Route("~/api/config/currency-layer/{key}")]
        public MixERP.Net.Entities.Config.CurrencyLayer Get(string key)
        {
            try
            {
                return this.CurrencyLayerContext.Get(key);
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
        [Route("~/api/config/currency-layer/get")]
        public IEnumerable<MixERP.Net.Entities.Config.CurrencyLayer> Get([FromUri] string[] keys)
        {
            try
            {
                return this.CurrencyLayerContext.Get(keys);
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
        ///     Creates a paginated collection containing 25 currency layers on each page, sorted by the property Key.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/config/currency-layer")]
        public IEnumerable<MixERP.Net.Entities.Config.CurrencyLayer> GetPagedResult()
        {
            try
            {
                return this.CurrencyLayerContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 currency layers on each page, sorted by the property Key.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/config/currency-layer/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Config.CurrencyLayer> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.CurrencyLayerContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 currency layers on each page, sorted by the property Key.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/config/currency-layer/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Config.CurrencyLayer> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.CurrencyLayerContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of currency layers.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of currency layers.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/config/currency-layer/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.CurrencyLayerContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for currency layers.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of currency layers.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/config/currency-layer/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.CurrencyLayerContext.GetCustomFields(null);
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
        ///     A custom field is a user defined field for currency layers.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of currency layers.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/config/currency-layer/custom-fields/{resourceId}")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
        {
            try
            {
                return this.CurrencyLayerContext.GetCustomFields(resourceId);
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
        ///     Adds or edits your instance of CurrencyLayer class.
        /// </summary>
        /// <param name="currencyLayer">Your instance of currency layers class to add or edit.</param>
        [AcceptVerbs("PUT")]
        [Route("add-or-edit")]
        [Route("~/api/config/currency-layer/add-or-edit")]
        public void AddOrEdit([FromBody]MixERP.Net.Entities.Config.CurrencyLayer currencyLayer)
        {
            if (currencyLayer == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.CurrencyLayerContext.AddOrEdit(currencyLayer);
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
        ///     Adds your instance of CurrencyLayer class.
        /// </summary>
        /// <param name="currencyLayer">Your instance of currency layers class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{currencyLayer}")]
        [Route("~/api/config/currency-layer/add/{currencyLayer}")]
        public void Add(MixERP.Net.Entities.Config.CurrencyLayer currencyLayer)
        {
            if (currencyLayer == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.CurrencyLayerContext.Add(currencyLayer);
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
        ///     Edits existing record with your instance of CurrencyLayer class.
        /// </summary>
        /// <param name="currencyLayer">Your instance of CurrencyLayer class to edit.</param>
        /// <param name="key">Enter the value for Key in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{key}")]
        [Route("~/api/config/currency-layer/edit/{key}")]
        public void Edit(string key, [FromBody] MixERP.Net.Entities.Config.CurrencyLayer currencyLayer)
        {
            if (currencyLayer == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.CurrencyLayerContext.Update(currencyLayer, key);
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
        ///     Deletes an existing instance of CurrencyLayer class via Key.
        /// </summary>
        /// <param name="key">Enter the value for Key in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{key}")]
        [Route("~/api/config/currency-layer/delete/{key}")]
        public void Delete(string key)
        {
            try
            {
                this.CurrencyLayerContext.Delete(key);
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