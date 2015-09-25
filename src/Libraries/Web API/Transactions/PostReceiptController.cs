// ReSharper disable All
/********************************************************************************
Copyright (C) MixERP Inc. (http://mixof.org).
This file is part of MixERP.
MixERP is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, version 2 of the License.

MixERP is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.
You should have received a copy of the GNU General Public License
along with MixERP.  If not, see <http://www.gnu.org/licenses/>.
***********************************************************************************/
using MixERP.Net.Framework;
using MixERP.Net.Entities.Transactions;
using MixERP.Net.Schemas.Transactions.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using PetaPoco;
namespace MixERP.Net.Api.Transactions
{
    /// <summary>
    /// Provides a direct HTTP access to execute the function PostReceipt.
    /// </summary>
    [RoutePrefix("api/v1.5/transactions/procedures/post-receipt")]
    public class PostReceiptController : ApiController
    {
        /// <summary>
        /// Login id of application user accessing this API.
        /// </summary>
        public long _LoginId { get; set; }

        /// <summary>
        /// User id of application user accessing this API.
        /// </summary>
        public int _UserId { get; set; }

        /// <summary>
        /// Currently logged in office id of application user accessing this API.
        /// </summary>
        public int _OfficeId { get; set; }

        /// <summary>
        /// The name of the database where queries are being executed on.
        /// </summary>
        public string _Catalog { get; set; }

        private PostReceiptProcedure procedure;
        public class Annotation
        {
            public int UserId { get; set; }
            public int OfficeId { get; set; }
            public long LoginId { get; set; }
            public string PartyCode { get; set; }
            public string CurrencyCode { get; set; }
            public decimal Amount { get; set; }
            public decimal ExchangeRateDebit { get; set; }
            public decimal ExchangeRateCredit { get; set; }
            public string ReferenceNumber { get; set; }
            public string StatementReference { get; set; }
            public int CostCenterId { get; set; }
            public int CashRepositoryId { get; set; }
            public DateTime PostedDate { get; set; }
            public long BankAccountId { get; set; }
            public int PaymentCardId { get; set; }
            public string BankInstrumentCode { get; set; }
            public string BankTranCode { get; set; }
            public long CascadingTranId { get; set; }
        }

        public PostReceiptController()
        {
            this._LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this._UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this._OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this._Catalog = AppUsers.GetCurrentUserDB();
            this.procedure = new PostReceiptProcedure
            {
                _Catalog = this._Catalog,
                _LoginId = this._LoginId,
                _UserId = this._UserId
            };
        }

        [AcceptVerbs("POST")]
        [Route("execute")]
        [Route("~/api/transactions/procedures/post-receipt/execute")]
        public long Execute([FromBody] Annotation annotation)
        {
            try
            {
                this.procedure.UserId = annotation.UserId;
                this.procedure.OfficeId = annotation.OfficeId;
                this.procedure.LoginId = annotation.LoginId;
                this.procedure.PartyCode = annotation.PartyCode;
                this.procedure.CurrencyCode = annotation.CurrencyCode;
                this.procedure.Amount = annotation.Amount;
                this.procedure.ExchangeRateDebit = annotation.ExchangeRateDebit;
                this.procedure.ExchangeRateCredit = annotation.ExchangeRateCredit;
                this.procedure.ReferenceNumber = annotation.ReferenceNumber;
                this.procedure.StatementReference = annotation.StatementReference;
                this.procedure.CostCenterId = annotation.CostCenterId;
                this.procedure.CashRepositoryId = annotation.CashRepositoryId;
                this.procedure.PostedDate = annotation.PostedDate;
                this.procedure.BankAccountId = annotation.BankAccountId;
                this.procedure.PaymentCardId = annotation.PaymentCardId;
                this.procedure.BankInstrumentCode = annotation.BankInstrumentCode;
                this.procedure.BankTranCode = annotation.BankTranCode;
                this.procedure.CascadingTranId = annotation.CascadingTranId;

                return this.procedure.Execute();
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden));
            }
            catch (MixERPException ex)
            {
                throw new HttpResponseException(new HttpResponseMessage
                {
                    Content = new StringContent(ex.Message),
                    StatusCode = HttpStatusCode.InternalServerError
                });
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }
    }
}