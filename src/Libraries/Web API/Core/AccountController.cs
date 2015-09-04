using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using MixERP.Net.Schemas.Core.Data;
using PetaPoco;

namespace MixERP.Net.Api.Core
{
    /// <summary>
    ///     Provide a direct HTTP access to perform various tasks such as adding, editing, and removing Accounts.
    /// </summary>
    public class AccountController : ApiController
    {
        /// <summary>
        ///     The Account data context.
        /// </summary>
        private readonly Account AccountContext;

        public AccountController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.AccountContext = new Account
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
        ///     Counts the number of accounts.
        /// </summary>
        /// <returns>Returns the count of the accounts.</returns>
        [AcceptVerbs("GET", "HEAD")]
        public long Count()
        {
            try
            {
                return this.AccountContext.Count();
            }
            catch (UnauthorizedException)
            {
                // ReSharper disable once ThrowFromCatchWithNoInnerException
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Unauthorized));
            }
            catch
            {
                // ReSharper disable once ThrowFromCatchWithNoInnerException
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Returns an instance of account.
        /// </summary>
        /// <param name="accountId">Enter an AccountId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("api/account/get/{accountId:long}")]
        public Entities.Core.Account Get(long accountId)
        {
            if (accountId <= 0)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }

            try
            {
                return this.AccountContext.Get(accountId);
            }
            catch (UnauthorizedException)
            {
                // ReSharper disable once ThrowFromCatchWithNoInnerException
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Unauthorized));
            }
            catch
            {
                // ReSharper disable once ThrowFromCatchWithNoInnerException
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Creates a paginated collection containing 25 accounts on each page, sorted by the property AccountId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("api/account")]
        public IEnumerable<Entities.Core.Account> GetPagedResult()
        {
            try
            {
                return this.AccountContext.GetPagedResult();
            }
            catch (UnauthorizedException)
            {
                // ReSharper disable once ThrowFromCatchWithNoInnerException
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Unauthorized));
            }
            catch
            {
                // ReSharper disable once ThrowFromCatchWithNoInnerException
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Creates a paginated collection containing 25 accounts on each page, sorted by the property AccountId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("api/account/page/{pageNumber:long}")]
        public IEnumerable<Entities.Core.Account> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.AccountContext.GetPagedResult(pageNumber);
            }
            catch (UnauthorizedException)
            {
                // ReSharper disable once ThrowFromCatchWithNoInnerException
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Unauthorized));
            }
            catch
            {
                // ReSharper disable once ThrowFromCatchWithNoInnerException
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Displayfields is a lightweight key/value collection of accounts.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of accounts.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("api/account/get-display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.AccountContext.GetDisplayFields();
            }
            catch (UnauthorizedException)
            {
                // ReSharper disable once ThrowFromCatchWithNoInnerException
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Unauthorized));
            }
            catch
            {
                // ReSharper disable once ThrowFromCatchWithNoInnerException
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Adds your instance of Account class.
        /// </summary>
        /// <param name="account">Your instance of Account class to add.</param>
        [AcceptVerbs("POST")]
        public void Add(Entities.Core.Account account)
        {
            if (account == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.AccountContext.Add(account);
            }
            catch (UnauthorizedException)
            {
                // ReSharper disable once ThrowFromCatchWithNoInnerException
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Unauthorized));
            }
            catch
            {
                // ReSharper disable once ThrowFromCatchWithNoInnerException
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Edits existing record with your instance of Account class.
        /// </summary>
        /// <param name="account">Your instance of Account class to edit.</param>
        /// <param name="accountId">Enter the value for AccountId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        public void Edit(Entities.Core.Account account, long accountId)
        {
            if (accountId <= 0)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }

            if (account == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.AccountContext.Update(account, accountId);
            }
            catch (UnauthorizedException)
            {
                // ReSharper disable once ThrowFromCatchWithNoInnerException
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Unauthorized));
            }
            catch
            {
                // ReSharper disable once ThrowFromCatchWithNoInnerException
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Deletes an existing instance of Account class via AccountId.
        /// </summary>
        /// <param name="accountId">Enter the value for AccountId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        public void Delete(long accountId)
        {
            if (accountId <= 0)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }

            try
            {
                this.AccountContext.Delete(accountId);
            }
            catch (UnauthorizedException)
            {
                // ReSharper disable once ThrowFromCatchWithNoInnerException
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Unauthorized));
            }
            catch
            {
                // ReSharper disable once ThrowFromCatchWithNoInnerException
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }
    }
}