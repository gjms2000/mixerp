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
using MixERP.Net.Entities.Transactions;
using Npgsql;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
namespace MixERP.Net.Schemas.Transactions.Data
{
	/// <summary>
	/// Prepares, validates, and executes the function "transactions.post_receipt(_user_id integer, _office_id integer, _login_id bigint, _party_code character varying, _currency_code character varying, _amount money_strict, _exchange_rate_debit decimal_strict, _exchange_rate_credit decimal_strict, _reference_number character varying, _statement_reference character varying, _cost_center_id integer, _cash_repository_id integer, _posted_date date, _bank_account_id bigint, _payment_card_id integer, _bank_instrument_code character varying, _bank_tran_code character varying, _cascading_tran_id bigint)" on the database.
	/// </summary>
	public class PostReceiptProcedure: DbAccess
	{
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
	    public override string ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
	    public override string ObjectName => "post_receipt";
        /// <summary>
        /// Login id of application user accessing this PostgreSQL function.
        /// </summary>
		public long LoginId { get; set; }
        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Maps to "_user_id" argument of the function "transactions.post_receipt".
		/// </summary>
		public int UserId { get; set; }
		/// <summary>
		/// Maps to "_office_id" argument of the function "transactions.post_receipt".
		/// </summary>
		public int OfficeId { get; set; }
		/// <summary>
		/// Maps to "_login_id" argument of the function "transactions.post_receipt".
		/// </summary>
		public long LoginIdParameter { get; set; }
		/// <summary>
		/// Maps to "_party_code" argument of the function "transactions.post_receipt".
		/// </summary>
		public string PartyCode { get; set; }
		/// <summary>
		/// Maps to "_currency_code" argument of the function "transactions.post_receipt".
		/// </summary>
		public string CurrencyCode { get; set; }
		/// <summary>
		/// Maps to "_amount" argument of the function "transactions.post_receipt".
		/// </summary>
		public decimal Amount { get; set; }
		/// <summary>
		/// Maps to "_exchange_rate_debit" argument of the function "transactions.post_receipt".
		/// </summary>
		public decimal ExchangeRateDebit { get; set; }
		/// <summary>
		/// Maps to "_exchange_rate_credit" argument of the function "transactions.post_receipt".
		/// </summary>
		public decimal ExchangeRateCredit { get; set; }
		/// <summary>
		/// Maps to "_reference_number" argument of the function "transactions.post_receipt".
		/// </summary>
		public string ReferenceNumber { get; set; }
		/// <summary>
		/// Maps to "_statement_reference" argument of the function "transactions.post_receipt".
		/// </summary>
		public string StatementReference { get; set; }
		/// <summary>
		/// Maps to "_cost_center_id" argument of the function "transactions.post_receipt".
		/// </summary>
		public int CostCenterId { get; set; }
		/// <summary>
		/// Maps to "_cash_repository_id" argument of the function "transactions.post_receipt".
		/// </summary>
		public int CashRepositoryId { get; set; }
		/// <summary>
		/// Maps to "_posted_date" argument of the function "transactions.post_receipt".
		/// </summary>
		public DateTime PostedDate { get; set; }
		/// <summary>
		/// Maps to "_bank_account_id" argument of the function "transactions.post_receipt".
		/// </summary>
		public long BankAccountId { get; set; }
		/// <summary>
		/// Maps to "_payment_card_id" argument of the function "transactions.post_receipt".
		/// </summary>
		public int PaymentCardId { get; set; }
		/// <summary>
		/// Maps to "_bank_instrument_code" argument of the function "transactions.post_receipt".
		/// </summary>
		public string BankInstrumentCode { get; set; }
		/// <summary>
		/// Maps to "_bank_tran_code" argument of the function "transactions.post_receipt".
		/// </summary>
		public string BankTranCode { get; set; }
		/// <summary>
		/// Maps to "_cascading_tran_id" argument of the function "transactions.post_receipt".
		/// </summary>
		public long CascadingTranId { get; set; }

		/// <summary>
		/// Prepares, validates, and executes the function "transactions.post_receipt(_user_id integer, _office_id integer, _login_id bigint, _party_code character varying, _currency_code character varying, _amount money_strict, _exchange_rate_debit decimal_strict, _exchange_rate_credit decimal_strict, _reference_number character varying, _statement_reference character varying, _cost_center_id integer, _cash_repository_id integer, _posted_date date, _bank_account_id bigint, _payment_card_id integer, _bank_instrument_code character varying, _bank_tran_code character varying, _cascading_tran_id bigint)" on the database.
		/// </summary>
		public PostReceiptProcedure()
		{
		}

		/// <summary>
		/// Prepares, validates, and executes the function "transactions.post_receipt(_user_id integer, _office_id integer, _login_id bigint, _party_code character varying, _currency_code character varying, _amount money_strict, _exchange_rate_debit decimal_strict, _exchange_rate_credit decimal_strict, _reference_number character varying, _statement_reference character varying, _cost_center_id integer, _cash_repository_id integer, _posted_date date, _bank_account_id bigint, _payment_card_id integer, _bank_instrument_code character varying, _bank_tran_code character varying, _cascading_tran_id bigint)" on the database.
		/// </summary>
		/// <param name="userId">Enter argument value for "_user_id" parameter of the function "transactions.post_receipt".</param>
		/// <param name="officeId">Enter argument value for "_office_id" parameter of the function "transactions.post_receipt".</param>
		/// <param name="loginIdParameter">Enter argument value for "_login_id" parameter of the function "transactions.post_receipt".</param>
		/// <param name="partyCode">Enter argument value for "_party_code" parameter of the function "transactions.post_receipt".</param>
		/// <param name="currencyCode">Enter argument value for "_currency_code" parameter of the function "transactions.post_receipt".</param>
		/// <param name="amount">Enter argument value for "_amount" parameter of the function "transactions.post_receipt".</param>
		/// <param name="exchangeRateDebit">Enter argument value for "_exchange_rate_debit" parameter of the function "transactions.post_receipt".</param>
		/// <param name="exchangeRateCredit">Enter argument value for "_exchange_rate_credit" parameter of the function "transactions.post_receipt".</param>
		/// <param name="referenceNumber">Enter argument value for "_reference_number" parameter of the function "transactions.post_receipt".</param>
		/// <param name="statementReference">Enter argument value for "_statement_reference" parameter of the function "transactions.post_receipt".</param>
		/// <param name="costCenterId">Enter argument value for "_cost_center_id" parameter of the function "transactions.post_receipt".</param>
		/// <param name="cashRepositoryId">Enter argument value for "_cash_repository_id" parameter of the function "transactions.post_receipt".</param>
		/// <param name="postedDate">Enter argument value for "_posted_date" parameter of the function "transactions.post_receipt".</param>
		/// <param name="bankAccountId">Enter argument value for "_bank_account_id" parameter of the function "transactions.post_receipt".</param>
		/// <param name="paymentCardId">Enter argument value for "_payment_card_id" parameter of the function "transactions.post_receipt".</param>
		/// <param name="bankInstrumentCode">Enter argument value for "_bank_instrument_code" parameter of the function "transactions.post_receipt".</param>
		/// <param name="bankTranCode">Enter argument value for "_bank_tran_code" parameter of the function "transactions.post_receipt".</param>
		/// <param name="cascadingTranId">Enter argument value for "_cascading_tran_id" parameter of the function "transactions.post_receipt".</param>
		public PostReceiptProcedure(int userId,int officeId,long loginIdParameter,string partyCode,string currencyCode,decimal amount,decimal exchangeRateDebit,decimal exchangeRateCredit,string referenceNumber,string statementReference,int costCenterId,int cashRepositoryId,DateTime postedDate,long bankAccountId,int paymentCardId,string bankInstrumentCode,string bankTranCode,long cascadingTranId)
		{
			this.UserId = userId;
			this.OfficeId = officeId;
			this.LoginIdParameter = loginIdParameter;
			this.PartyCode = partyCode;
			this.CurrencyCode = currencyCode;
			this.Amount = amount;
			this.ExchangeRateDebit = exchangeRateDebit;
			this.ExchangeRateCredit = exchangeRateCredit;
			this.ReferenceNumber = referenceNumber;
			this.StatementReference = statementReference;
			this.CostCenterId = costCenterId;
			this.CashRepositoryId = cashRepositoryId;
			this.PostedDate = postedDate;
			this.BankAccountId = bankAccountId;
			this.PaymentCardId = paymentCardId;
			this.BankInstrumentCode = bankInstrumentCode;
			this.BankTranCode = bankTranCode;
			this.CascadingTranId = cascadingTranId;
		}
		/// <summary>
		/// Prepares and executes the function "transactions.post_receipt".
		/// </summary>
		public long Execute()
		{
			if (!this.SkipValidation)
			{
				if (!this.Validated)
				{
					this.Validate(AccessTypeEnum.Execute, this.LoginId, false);
				}
				if (!this.HasAccess)
				{
                    Log.Information("Access to the function \"PostReceiptProcedure\" was denied to the user with Login ID {LoginId}.", this.LoginId);
					throw new UnauthorizedException("Access is denied.");
				}
			}
			const string query = "SELECT * FROM transactions.post_receipt(@0::integer, @1::integer, @2::bigint, @3::character varying, @4::character varying, @5::money_strict, @6::decimal_strict, @7::decimal_strict, @8::character varying, @9::character varying, @10::integer, @11::integer, @12::date, @13::bigint, @14::integer, @15::character varying, @16::character varying, @17::bigint);";
			return Factory.Scalar<long>(this.Catalog, query, this.UserId, this.OfficeId, this.LoginIdParameter, this.PartyCode, this.CurrencyCode, this.Amount, this.ExchangeRateDebit, this.ExchangeRateCredit, this.ReferenceNumber, this.StatementReference, this.CostCenterId, this.CashRepositoryId, this.PostedDate, this.BankAccountId, this.PaymentCardId, this.BankInstrumentCode, this.BankTranCode, this.CascadingTranId);
		} 
	}
}