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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Custom Field Data Types.
    /// </summary>
    [RoutePrefix("api/v1.5/core/custom-field-data-type")]
    public class CustomFieldDataTypeController : ApiController
    {
        /// <summary>
        ///     The CustomFieldDataType data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Core.Data.CustomFieldDataType CustomFieldDataTypeContext;

        public CustomFieldDataTypeController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.CustomFieldDataTypeContext = new MixERP.Net.Schemas.Core.Data.CustomFieldDataType
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
        ///     Counts the number of custom field data types.
        /// </summary>
        /// <returns>Returns the count of the custom field data types.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/core/custom-field-data-type/count")]
        public long Count()
        {
            try
            {
                return this.CustomFieldDataTypeContext.Count();
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
        ///     Returns an instance of custom field data type.
        /// </summary>
        /// <param name="dataType">Enter DataType to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{dataType}")]
        [Route("~/api/core/custom-field-data-type/{dataType}")]
        public MixERP.Net.Entities.Core.CustomFieldDataType Get(string dataType)
        {
            try
            {
                return this.CustomFieldDataTypeContext.Get(dataType);
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
        ///     Creates a paginated collection containing 25 custom field data types on each page, sorted by the property DataType.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/core/custom-field-data-type")]
        public IEnumerable<MixERP.Net.Entities.Core.CustomFieldDataType> GetPagedResult()
        {
            try
            {
                return this.CustomFieldDataTypeContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 custom field data types on each page, sorted by the property DataType.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/core/custom-field-data-type/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.CustomFieldDataType> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.CustomFieldDataTypeContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 custom field data types on each page, sorted by the property DataType.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/core/custom-field-data-type/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.CustomFieldDataType> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.CustomFieldDataTypeContext.GetWhere(pageNumber, f);
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
        ///     Displayfields is a lightweight key/value collection of custom field data types.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of custom field data types.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/core/custom-field-data-type/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.CustomFieldDataTypeContext.GetDisplayFields();
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
        /// <param name="customFieldDataType">Your instance of custom field data types class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{customFieldDataType}")]
        [Route("~/api/core/custom-field-data-type/add/{customFieldDataType}")]
        public void Add(MixERP.Net.Entities.Core.CustomFieldDataType customFieldDataType)
        {
            if (customFieldDataType == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.CustomFieldDataTypeContext.Add(customFieldDataType);
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
        /// <param name="customFieldDataType">Your instance of Account class to edit.</param>
        /// <param name="dataType">Enter the value for DataType in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{dataType}/{customFieldDataType}")]
        [Route("~/api/core/custom-field-data-type/edit/{dataType}/{customFieldDataType}")]
        public void Edit(string dataType, MixERP.Net.Entities.Core.CustomFieldDataType customFieldDataType)
        {
            if (customFieldDataType == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.CustomFieldDataTypeContext.Update(customFieldDataType, dataType);
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
        ///     Deletes an existing instance of Account class via DataType.
        /// </summary>
        /// <param name="dataType">Enter the value for DataType in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{dataType}")]
        [Route("~/api/core/custom-field-data-type/delete/{dataType}")]
        public void Delete(string dataType)
        {
            try
            {
                this.CustomFieldDataTypeContext.Delete(dataType);
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