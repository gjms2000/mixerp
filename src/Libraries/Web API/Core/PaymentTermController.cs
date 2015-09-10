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
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Payment Terms.
    /// </summary>
    [RoutePrefix("api/v1.5/core/payment-term")]
    public class PaymentTermController : ApiController
    {
        /// <summary>
        ///     The PaymentTerm data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Core.Data.PaymentTerm PaymentTermContext;

        public PaymentTermController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.PaymentTermContext = new MixERP.Net.Schemas.Core.Data.PaymentTerm
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
        ///     Counts the number of payment terms.
        /// </summary>
        /// <returns>Returns the count of the payment terms.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/core/payment-term/count")]
        public long Count()
        {
            try
            {
                return this.PaymentTermContext.Count();
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
        ///     Returns an instance of payment term.
        /// </summary>
        /// <param name="paymentTermId">Enter PaymentTermId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{paymentTermId}")]
        [Route("~/api/core/payment-term/{paymentTermId}")]
        public MixERP.Net.Entities.Core.PaymentTerm Get(int paymentTermId)
        {
            try
            {
                return this.PaymentTermContext.Get(paymentTermId);
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
        ///     Creates a paginated collection containing 25 payment terms on each page, sorted by the property PaymentTermId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/core/payment-term")]
        public IEnumerable<MixERP.Net.Entities.Core.PaymentTerm> GetPagedResult()
        {
            try
            {
                return this.PaymentTermContext.GetPagedResult();
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
        ///     Creates a paginated collection containing 25 payment terms on each page, sorted by the property PaymentTermId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/core/payment-term/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.PaymentTerm> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.PaymentTermContext.GetPagedResult(pageNumber);
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
        ///     Creates a filtered and paginated collection containing 25 payment terms on each page, sorted by the property PaymentTermId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/core/payment-term/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.PaymentTerm> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.PaymentTermContext.GetWhere(pageNumber, f);
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
        ///     Displayfield is a lightweight key/value collection of payment terms.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of payment terms.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/core/payment-term/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.PaymentTermContext.GetDisplayFields();
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
        ///     A custom field is a user defined field for payment terms.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of payment terms.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/payment-term/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.PaymentTermContext.GetCustomFields();
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
        /// <param name="paymentTerm">Your instance of payment terms class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{paymentTerm}")]
        [Route("~/api/core/payment-term/add/{paymentTerm}")]
        public void Add(MixERP.Net.Entities.Core.PaymentTerm paymentTerm)
        {
            if (paymentTerm == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.PaymentTermContext.Add(paymentTerm);
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
        /// <param name="paymentTerm">Your instance of Account class to edit.</param>
        /// <param name="paymentTermId">Enter the value for PaymentTermId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{paymentTermId}/{paymentTerm}")]
        [Route("~/api/core/payment-term/edit/{paymentTermId}/{paymentTerm}")]
        public void Edit(int paymentTermId, MixERP.Net.Entities.Core.PaymentTerm paymentTerm)
        {
            if (paymentTerm == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.PaymentTermContext.Update(paymentTerm, paymentTermId);
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
        ///     Deletes an existing instance of Account class via PaymentTermId.
        /// </summary>
        /// <param name="paymentTermId">Enter the value for PaymentTermId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{paymentTermId}")]
        [Route("~/api/core/payment-term/delete/{paymentTermId}")]
        public void Delete(int paymentTermId)
        {
            try
            {
                this.PaymentTermContext.Delete(paymentTermId);
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