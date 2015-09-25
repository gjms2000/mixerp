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
using MixERP.Net.Entities.Office;
using MixERP.Net.Schemas.Office.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using PetaPoco;
namespace MixERP.Net.Api.Office
{
    /// <summary>
    /// Provides a direct HTTP access to execute the function AddOffice.
    /// </summary>
    [RoutePrefix("api/v1.5/office/procedures/add-office")]
    public class AddOfficeController : ApiController
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

        private AddOfficeProcedure procedure;
        public class Annotation
        {
            public string OfficeCode { get; set; }
            public string OfficeName { get; set; }
            public string NickName { get; set; }
            public DateTime RegistrationDate { get; set; }
            public string CurrencyCode { get; set; }
            public string CurrencySymbol { get; set; }
            public string CurrencyName { get; set; }
            public string HundredthName { get; set; }
            public string FiscalYearCode { get; set; }
            public string FiscalYearName { get; set; }
            public DateTime StartsFrom { get; set; }
            public DateTime EndsOn { get; set; }
            public bool SalesTaxIsVat { get; set; }
            public bool HasStateSalesTax { get; set; }
            public bool HasCountySalesTax { get; set; }
            public int QuotationValidDays { get; set; }
            public decimal IncomeTaxRate { get; set; }
            public int WeekStartDay { get; set; }
            public DateTime TransactionStartDate { get; set; }
            public bool IsPerpetual { get; set; }
            public string InvValuationMethod { get; set; }
            public string LogoFile { get; set; }
            public string AdminName { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
        }

        public AddOfficeController()
        {
            this._LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this._UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this._OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this._Catalog = AppUsers.GetCurrentUserDB();
            this.procedure = new AddOfficeProcedure
            {
                _Catalog = this._Catalog,
                _LoginId = this._LoginId,
                _UserId = this._UserId
            };
        }

        [AcceptVerbs("POST")]
        [Route("execute")]
        [Route("~/api/office/procedures/add-office/execute")]
        public void Execute([FromBody] Annotation annotation)
        {
            try
            {
                this.procedure.OfficeCode = annotation.OfficeCode;
                this.procedure.OfficeName = annotation.OfficeName;
                this.procedure.NickName = annotation.NickName;
                this.procedure.RegistrationDate = annotation.RegistrationDate;
                this.procedure.CurrencyCode = annotation.CurrencyCode;
                this.procedure.CurrencySymbol = annotation.CurrencySymbol;
                this.procedure.CurrencyName = annotation.CurrencyName;
                this.procedure.HundredthName = annotation.HundredthName;
                this.procedure.FiscalYearCode = annotation.FiscalYearCode;
                this.procedure.FiscalYearName = annotation.FiscalYearName;
                this.procedure.StartsFrom = annotation.StartsFrom;
                this.procedure.EndsOn = annotation.EndsOn;
                this.procedure.SalesTaxIsVat = annotation.SalesTaxIsVat;
                this.procedure.HasStateSalesTax = annotation.HasStateSalesTax;
                this.procedure.HasCountySalesTax = annotation.HasCountySalesTax;
                this.procedure.QuotationValidDays = annotation.QuotationValidDays;
                this.procedure.IncomeTaxRate = annotation.IncomeTaxRate;
                this.procedure.WeekStartDay = annotation.WeekStartDay;
                this.procedure.TransactionStartDate = annotation.TransactionStartDate;
                this.procedure.IsPerpetual = annotation.IsPerpetual;
                this.procedure.InvValuationMethod = annotation.InvValuationMethod;
                this.procedure.LogoFile = annotation.LogoFile;
                this.procedure.AdminName = annotation.AdminName;
                this.procedure.UserName = annotation.UserName;
                this.procedure.Password = annotation.Password;

                this.procedure.Execute();
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