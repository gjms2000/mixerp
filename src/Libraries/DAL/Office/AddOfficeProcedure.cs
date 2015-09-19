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
//Resharper disable All
using MixERP.Net.DbFactory;
using MixERP.Net.Framework;
using PetaPoco;
using MixERP.Net.Entities.Office;
using Npgsql;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
namespace MixERP.Net.Schemas.Office.Data
{
    /// <summary>
    /// Prepares, validates, and executes the function "office.add_office(_office_code character varying, _office_name character varying, _nick_name character varying, _registration_date date, _currency_code character varying, _currency_symbol character varying, _currency_name character varying, _hundredth_name character varying, _fiscal_year_code character varying, _fiscal_year_name character varying, _starts_from date, _ends_on date, _sales_tax_is_vat boolean, _has_state_sales_tax boolean, _has_county_sales_tax boolean, _quotation_valid_days integer, _income_tax_rate numeric, _week_start_day integer, _transaction_start_date date, _is_perpetual boolean, _inv_valuation_method character varying, _logo_file text, _admin_name character varying, _user_name character varying, _password character varying)" on the database.
    /// </summary>
    public class AddOfficeProcedure : DbAccess
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string ObjectNamespace => "office";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string ObjectName => "add_office";
        /// <summary>
        /// Login id of application user accessing this PostgreSQL function.
        /// </summary>
        public long _LoginId { get; set; }
        /// <summary>
        /// User id of application user accessing this table.
        /// </summary>
        public int _UserId { get; set; }
        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

        /// <summary>
        /// Maps to "_office_code" argument of the function "office.add_office".
        /// </summary>
        public string OfficeCode { get; set; }
        /// <summary>
        /// Maps to "_office_name" argument of the function "office.add_office".
        /// </summary>
        public string OfficeName { get; set; }
        /// <summary>
        /// Maps to "_nick_name" argument of the function "office.add_office".
        /// </summary>
        public string NickName { get; set; }
        /// <summary>
        /// Maps to "_registration_date" argument of the function "office.add_office".
        /// </summary>
        public DateTime RegistrationDate { get; set; }
        /// <summary>
        /// Maps to "_currency_code" argument of the function "office.add_office".
        /// </summary>
        public string CurrencyCode { get; set; }
        /// <summary>
        /// Maps to "_currency_symbol" argument of the function "office.add_office".
        /// </summary>
        public string CurrencySymbol { get; set; }
        /// <summary>
        /// Maps to "_currency_name" argument of the function "office.add_office".
        /// </summary>
        public string CurrencyName { get; set; }
        /// <summary>
        /// Maps to "_hundredth_name" argument of the function "office.add_office".
        /// </summary>
        public string HundredthName { get; set; }
        /// <summary>
        /// Maps to "_fiscal_year_code" argument of the function "office.add_office".
        /// </summary>
        public string FiscalYearCode { get; set; }
        /// <summary>
        /// Maps to "_fiscal_year_name" argument of the function "office.add_office".
        /// </summary>
        public string FiscalYearName { get; set; }
        /// <summary>
        /// Maps to "_starts_from" argument of the function "office.add_office".
        /// </summary>
        public DateTime StartsFrom { get; set; }
        /// <summary>
        /// Maps to "_ends_on" argument of the function "office.add_office".
        /// </summary>
        public DateTime EndsOn { get; set; }
        /// <summary>
        /// Maps to "_sales_tax_is_vat" argument of the function "office.add_office".
        /// </summary>
        public bool SalesTaxIsVat { get; set; }
        /// <summary>
        /// Maps to "_has_state_sales_tax" argument of the function "office.add_office".
        /// </summary>
        public bool HasStateSalesTax { get; set; }
        /// <summary>
        /// Maps to "_has_county_sales_tax" argument of the function "office.add_office".
        /// </summary>
        public bool HasCountySalesTax { get; set; }
        /// <summary>
        /// Maps to "_quotation_valid_days" argument of the function "office.add_office".
        /// </summary>
        public int QuotationValidDays { get; set; }
        /// <summary>
        /// Maps to "_income_tax_rate" argument of the function "office.add_office".
        /// </summary>
        public decimal IncomeTaxRate { get; set; }
        /// <summary>
        /// Maps to "_week_start_day" argument of the function "office.add_office".
        /// </summary>
        public int WeekStartDay { get; set; }
        /// <summary>
        /// Maps to "_transaction_start_date" argument of the function "office.add_office".
        /// </summary>
        public DateTime TransactionStartDate { get; set; }
        /// <summary>
        /// Maps to "_is_perpetual" argument of the function "office.add_office".
        /// </summary>
        public bool IsPerpetual { get; set; }
        /// <summary>
        /// Maps to "_inv_valuation_method" argument of the function "office.add_office".
        /// </summary>
        public string InvValuationMethod { get; set; }
        /// <summary>
        /// Maps to "_logo_file" argument of the function "office.add_office".
        /// </summary>
        public string LogoFile { get; set; }
        /// <summary>
        /// Maps to "_admin_name" argument of the function "office.add_office".
        /// </summary>
        public string AdminName { get; set; }
        /// <summary>
        /// Maps to "_user_name" argument of the function "office.add_office".
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// Maps to "_password" argument of the function "office.add_office".
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "office.add_office(_office_code character varying, _office_name character varying, _nick_name character varying, _registration_date date, _currency_code character varying, _currency_symbol character varying, _currency_name character varying, _hundredth_name character varying, _fiscal_year_code character varying, _fiscal_year_name character varying, _starts_from date, _ends_on date, _sales_tax_is_vat boolean, _has_state_sales_tax boolean, _has_county_sales_tax boolean, _quotation_valid_days integer, _income_tax_rate numeric, _week_start_day integer, _transaction_start_date date, _is_perpetual boolean, _inv_valuation_method character varying, _logo_file text, _admin_name character varying, _user_name character varying, _password character varying)" on the database.
        /// </summary>
        public AddOfficeProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "office.add_office(_office_code character varying, _office_name character varying, _nick_name character varying, _registration_date date, _currency_code character varying, _currency_symbol character varying, _currency_name character varying, _hundredth_name character varying, _fiscal_year_code character varying, _fiscal_year_name character varying, _starts_from date, _ends_on date, _sales_tax_is_vat boolean, _has_state_sales_tax boolean, _has_county_sales_tax boolean, _quotation_valid_days integer, _income_tax_rate numeric, _week_start_day integer, _transaction_start_date date, _is_perpetual boolean, _inv_valuation_method character varying, _logo_file text, _admin_name character varying, _user_name character varying, _password character varying)" on the database.
        /// </summary>
        /// <param name="officeCode">Enter argument value for "_office_code" parameter of the function "office.add_office".</param>
        /// <param name="officeName">Enter argument value for "_office_name" parameter of the function "office.add_office".</param>
        /// <param name="nickName">Enter argument value for "_nick_name" parameter of the function "office.add_office".</param>
        /// <param name="registrationDate">Enter argument value for "_registration_date" parameter of the function "office.add_office".</param>
        /// <param name="currencyCode">Enter argument value for "_currency_code" parameter of the function "office.add_office".</param>
        /// <param name="currencySymbol">Enter argument value for "_currency_symbol" parameter of the function "office.add_office".</param>
        /// <param name="currencyName">Enter argument value for "_currency_name" parameter of the function "office.add_office".</param>
        /// <param name="hundredthName">Enter argument value for "_hundredth_name" parameter of the function "office.add_office".</param>
        /// <param name="fiscalYearCode">Enter argument value for "_fiscal_year_code" parameter of the function "office.add_office".</param>
        /// <param name="fiscalYearName">Enter argument value for "_fiscal_year_name" parameter of the function "office.add_office".</param>
        /// <param name="startsFrom">Enter argument value for "_starts_from" parameter of the function "office.add_office".</param>
        /// <param name="endsOn">Enter argument value for "_ends_on" parameter of the function "office.add_office".</param>
        /// <param name="salesTaxIsVat">Enter argument value for "_sales_tax_is_vat" parameter of the function "office.add_office".</param>
        /// <param name="hasStateSalesTax">Enter argument value for "_has_state_sales_tax" parameter of the function "office.add_office".</param>
        /// <param name="hasCountySalesTax">Enter argument value for "_has_county_sales_tax" parameter of the function "office.add_office".</param>
        /// <param name="quotationValidDays">Enter argument value for "_quotation_valid_days" parameter of the function "office.add_office".</param>
        /// <param name="incomeTaxRate">Enter argument value for "_income_tax_rate" parameter of the function "office.add_office".</param>
        /// <param name="weekStartDay">Enter argument value for "_week_start_day" parameter of the function "office.add_office".</param>
        /// <param name="transactionStartDate">Enter argument value for "_transaction_start_date" parameter of the function "office.add_office".</param>
        /// <param name="isPerpetual">Enter argument value for "_is_perpetual" parameter of the function "office.add_office".</param>
        /// <param name="invValuationMethod">Enter argument value for "_inv_valuation_method" parameter of the function "office.add_office".</param>
        /// <param name="logoFile">Enter argument value for "_logo_file" parameter of the function "office.add_office".</param>
        /// <param name="adminName">Enter argument value for "_admin_name" parameter of the function "office.add_office".</param>
        /// <param name="userName">Enter argument value for "_user_name" parameter of the function "office.add_office".</param>
        /// <param name="password">Enter argument value for "_password" parameter of the function "office.add_office".</param>
        public AddOfficeProcedure(string officeCode, string officeName, string nickName, DateTime registrationDate, string currencyCode, string currencySymbol, string currencyName, string hundredthName, string fiscalYearCode, string fiscalYearName, DateTime startsFrom, DateTime endsOn, bool salesTaxIsVat, bool hasStateSalesTax, bool hasCountySalesTax, int quotationValidDays, decimal incomeTaxRate, int weekStartDay, DateTime transactionStartDate, bool isPerpetual, string invValuationMethod, string logoFile, string adminName, string userName, string password)
        {
            this.OfficeCode = officeCode;
            this.OfficeName = officeName;
            this.NickName = nickName;
            this.RegistrationDate = registrationDate;
            this.CurrencyCode = currencyCode;
            this.CurrencySymbol = currencySymbol;
            this.CurrencyName = currencyName;
            this.HundredthName = hundredthName;
            this.FiscalYearCode = fiscalYearCode;
            this.FiscalYearName = fiscalYearName;
            this.StartsFrom = startsFrom;
            this.EndsOn = endsOn;
            this.SalesTaxIsVat = salesTaxIsVat;
            this.HasStateSalesTax = hasStateSalesTax;
            this.HasCountySalesTax = hasCountySalesTax;
            this.QuotationValidDays = quotationValidDays;
            this.IncomeTaxRate = incomeTaxRate;
            this.WeekStartDay = weekStartDay;
            this.TransactionStartDate = transactionStartDate;
            this.IsPerpetual = isPerpetual;
            this.InvValuationMethod = invValuationMethod;
            this.LogoFile = logoFile;
            this.AdminName = adminName;
            this.UserName = userName;
            this.Password = password;
        }
        /// <summary>
        /// Prepares and executes the function "office.add_office".
        /// </summary>
        public void Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"AddOfficeProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            const string query = "SELECT * FROM office.add_office(@0::character varying, @1::character varying, @2::character varying, @3::date, @4::character varying, @5::character varying, @6::character varying, @7::character varying, @8::character varying, @9::character varying, @10::date, @11::date, @12::boolean, @13::boolean, @14::boolean, @15::integer, @16::numeric, @17::integer, @18::date, @19::boolean, @20::character varying, @21::text, @22::character varying, @23::character varying, @24::character varying);";
            Factory.NonQuery(this.Catalog, query, this.OfficeCode, this.OfficeName, this.NickName, this.RegistrationDate, this.CurrencyCode, this.CurrencySymbol, this.CurrencyName, this.HundredthName, this.FiscalYearCode, this.FiscalYearName, this.StartsFrom, this.EndsOn, this.SalesTaxIsVat, this.HasStateSalesTax, this.HasCountySalesTax, this.QuotationValidDays, this.IncomeTaxRate, this.WeekStartDay, this.TransactionStartDate, this.IsPerpetual, this.InvValuationMethod, this.LogoFile, this.AdminName, this.UserName, this.Password);
        }
    }
}