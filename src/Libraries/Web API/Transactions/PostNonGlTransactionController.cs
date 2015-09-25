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
    /// Provides a direct HTTP access to execute the function PostNonGlTransaction.
    /// </summary>
    [RoutePrefix("api/v1.5/transactions/procedures/post-non-gl-transaction")]
    public class PostNonGlTransactionController : ApiController
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

        private PostNonGlTransactionProcedure procedure;
        public class Annotation
        {
            public string BookName { get; set; }
            public int OfficeId { get; set; }
            public int UserId { get; set; }
            public long LoginId { get; set; }
            public DateTime ValueDate { get; set; }
            public string ReferenceNumber { get; set; }
            public string StatementReference { get; set; }
            public string PartyCode { get; set; }
            public int PriceTypeId { get; set; }
            public bool IsNonTaxableSales { get; set; }
            public int SalespersonId { get; set; }
            public int ShipperId { get; set; }
            public string ShippingAddressCode { get; set; }
            public int StoreId { get; set; }
            public long[] TranIds { get; set; }
            public MixERP.Net.Entities.Transactions.StockDetailType[][] Details { get; set; }
            public MixERP.Net.Entities.Core.AttachmentType[][] Attachments { get; set; }
        }

        public PostNonGlTransactionController()
        {
            this._LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this._UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this._OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this._Catalog = AppUsers.GetCurrentUserDB();
            this.procedure = new PostNonGlTransactionProcedure
            {
                _Catalog = this._Catalog,
                _LoginId = this._LoginId,
                _UserId = this._UserId
            };
        }

        [AcceptVerbs("POST")]
        [Route("execute")]
        [Route("~/api/transactions/procedures/post-non-gl-transaction/execute")]
        public long Execute([FromBody] Annotation annotation)
        {
            try
            {
                this.procedure.BookName = annotation.BookName;
                this.procedure.OfficeId = annotation.OfficeId;
                this.procedure.UserId = annotation.UserId;
                this.procedure.LoginId = annotation.LoginId;
                this.procedure.ValueDate = annotation.ValueDate;
                this.procedure.ReferenceNumber = annotation.ReferenceNumber;
                this.procedure.StatementReference = annotation.StatementReference;
                this.procedure.PartyCode = annotation.PartyCode;
                this.procedure.PriceTypeId = annotation.PriceTypeId;
                this.procedure.IsNonTaxableSales = annotation.IsNonTaxableSales;
                this.procedure.SalespersonId = annotation.SalespersonId;
                this.procedure.ShipperId = annotation.ShipperId;
                this.procedure.ShippingAddressCode = annotation.ShippingAddressCode;
                this.procedure.StoreId = annotation.StoreId;
                this.procedure.TranIds = annotation.TranIds;
                this.procedure.Details = annotation.Details;
                this.procedure.Attachments = annotation.Attachments;

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