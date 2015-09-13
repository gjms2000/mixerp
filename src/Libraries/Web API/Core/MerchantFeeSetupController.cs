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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Merchant Fee Setups.
    /// </summary>
    [RoutePrefix("api/v1.5/core/merchant-fee-setup")]
    public class MerchantFeeSetupController : ApiController
    {
        /// <summary>
        ///     The MerchantFeeSetup data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Core.Data.MerchantFeeSetup MerchantFeeSetupContext;

        public MerchantFeeSetupController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.MerchantFeeSetupContext = new MixERP.Net.Schemas.Core.Data.MerchantFeeSetup
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
        ///     Counts the number of merchant fee setups.
        /// </summary>
        /// <returns>Returns the count of the merchant fee setups.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/core/merchant-fee-setup/count")]
        public long Count()
        {
            try
            {
                return this.MerchantFeeSetupContext.Count();
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
        ///     Returns an instance of merchant fee setup.
        /// </summary>
        /// <param name="merchantFeeSetupId">Enter MerchantFeeSetupId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{merchantFeeSetupId}")]
        [Route("~/api/core/merchant-fee-setup/{merchantFeeSetupId}")]
        public MixERP.Net.Entities.Core.MerchantFeeSetup Get(int merchantFeeSetupId)
        {
            try
            {
                return this.MerchantFeeSetupContext.Get(merchantFeeSetupId);
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
        [Route("~/api/core/merchant-fee-setup/get")]
        public IEnumerable<MixERP.Net.Entities.Core.MerchantFeeSetup> Get([FromUri] int[] merchantFeeSetupIds)
        {
            try
            {
                return this.MerchantFeeSetupContext.Get(merchantFeeSetupIds);
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
        ///     Creates a paginated collection containing 25 merchant fee setups on each page, sorted by the property MerchantFeeSetupId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/core/merchant-fee-setup")]
        public IEnumerable<MixERP.Net.Entities.Core.MerchantFeeSetup> GetPagedResult()
        {
            try
            {
                return this.MerchantFeeSetupContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 merchant fee setups on each page, sorted by the property MerchantFeeSetupId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/core/merchant-fee-setup/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.MerchantFeeSetup> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.MerchantFeeSetupContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 merchant fee setups on each page, sorted by the property MerchantFeeSetupId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/core/merchant-fee-setup/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.MerchantFeeSetup> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.MerchantFeeSetupContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of merchant fee setups.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of merchant fee setups.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/core/merchant-fee-setup/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.MerchantFeeSetupContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for merchant fee setups.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of merchant fee setups.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/merchant-fee-setup/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.MerchantFeeSetupContext.GetCustomFields(null);
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
        ///     A custom field is a user defined field for merchant fee setups.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of merchant fee setups.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/merchant-fee-setup/custom-fields/{resourceId}")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
        {
            try
            {
                return this.MerchantFeeSetupContext.GetCustomFields(resourceId);
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
        ///     Adds or edits your instance of MerchantFeeSetup class.
        /// </summary>
        /// <param name="merchantFeeSetup">Your instance of merchant fee setups class to add or edit.</param>
        [AcceptVerbs("PUT")]
        [Route("add-or-edit")]
        [Route("~/api/core/merchant-fee-setup/add-or-edit")]
        public void AddOrEdit([FromBody]MixERP.Net.Entities.Core.MerchantFeeSetup merchantFeeSetup)
        {
            if (merchantFeeSetup == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.MerchantFeeSetupContext.AddOrEdit(merchantFeeSetup);
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
        ///     Adds your instance of MerchantFeeSetup class.
        /// </summary>
        /// <param name="merchantFeeSetup">Your instance of merchant fee setups class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{merchantFeeSetup}")]
        [Route("~/api/core/merchant-fee-setup/add/{merchantFeeSetup}")]
        public void Add(MixERP.Net.Entities.Core.MerchantFeeSetup merchantFeeSetup)
        {
            if (merchantFeeSetup == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.MerchantFeeSetupContext.Add(merchantFeeSetup);
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
        ///     Edits existing record with your instance of MerchantFeeSetup class.
        /// </summary>
        /// <param name="merchantFeeSetup">Your instance of MerchantFeeSetup class to edit.</param>
        /// <param name="merchantFeeSetupId">Enter the value for MerchantFeeSetupId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{merchantFeeSetupId}")]
        [Route("~/api/core/merchant-fee-setup/edit/{merchantFeeSetupId}")]
        public void Edit(int merchantFeeSetupId, [FromBody] MixERP.Net.Entities.Core.MerchantFeeSetup merchantFeeSetup)
        {
            if (merchantFeeSetup == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.MerchantFeeSetupContext.Update(merchantFeeSetup, merchantFeeSetupId);
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
        ///     Deletes an existing instance of MerchantFeeSetup class via MerchantFeeSetupId.
        /// </summary>
        /// <param name="merchantFeeSetupId">Enter the value for MerchantFeeSetupId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{merchantFeeSetupId}")]
        [Route("~/api/core/merchant-fee-setup/delete/{merchantFeeSetupId}")]
        public void Delete(int merchantFeeSetupId)
        {
            try
            {
                this.MerchantFeeSetupContext.Delete(merchantFeeSetupId);
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