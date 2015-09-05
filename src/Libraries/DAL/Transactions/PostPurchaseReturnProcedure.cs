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
	/// Prepares, validates, and executes the function "transactions.post_purchase_return(_transaction_master_id bigint, _office_id integer, _user_id integer, _login_id bigint, _value_date date, _store_id integer, _party_code character varying, _price_type_id integer, _reference_number character varying, _statement_reference text, _details transactions.stock_detail_type[], _attachments core.attachment_type[])" on the database.
	/// </summary>
	public class PostPurchaseReturnProcedure: DbAccess
	{
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
	    public override string ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
	    public override string ObjectName => "post_purchase_return";
        /// <summary>
        /// Login id of application user accessing this PostgreSQL function.
        /// </summary>
		public long LoginId { get; set; }
        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Maps to "_transaction_master_id" argument of the function "transactions.post_purchase_return".
		/// </summary>
		public long TransactionMasterId { get; set; }
		/// <summary>
		/// Maps to "_office_id" argument of the function "transactions.post_purchase_return".
		/// </summary>
		public int OfficeId { get; set; }
		/// <summary>
		/// Maps to "_user_id" argument of the function "transactions.post_purchase_return".
		/// </summary>
		public int UserId { get; set; }
		/// <summary>
		/// Maps to "_login_id" argument of the function "transactions.post_purchase_return".
		/// </summary>
		public long LoginIdParameter { get; set; }
		/// <summary>
		/// Maps to "_value_date" argument of the function "transactions.post_purchase_return".
		/// </summary>
		public DateTime ValueDate { get; set; }
		/// <summary>
		/// Maps to "_store_id" argument of the function "transactions.post_purchase_return".
		/// </summary>
		public int StoreId { get; set; }
		/// <summary>
		/// Maps to "_party_code" argument of the function "transactions.post_purchase_return".
		/// </summary>
		public string PartyCode { get; set; }
		/// <summary>
		/// Maps to "_price_type_id" argument of the function "transactions.post_purchase_return".
		/// </summary>
		public int PriceTypeId { get; set; }
		/// <summary>
		/// Maps to "_reference_number" argument of the function "transactions.post_purchase_return".
		/// </summary>
		public string ReferenceNumber { get; set; }
		/// <summary>
		/// Maps to "_statement_reference" argument of the function "transactions.post_purchase_return".
		/// </summary>
		public string StatementReference { get; set; }
		/// <summary>
		/// Maps to "_details" argument of the function "transactions.post_purchase_return".
		/// </summary>
		public MixERP.Net.Entities.Transactions.StockDetailType[][] Details { get; set; }
		/// <summary>
		/// Maps to "_attachments" argument of the function "transactions.post_purchase_return".
		/// </summary>
		public MixERP.Net.Entities.Core.AttachmentType[][] Attachments { get; set; }

		/// <summary>
		/// Prepares, validates, and executes the function "transactions.post_purchase_return(_transaction_master_id bigint, _office_id integer, _user_id integer, _login_id bigint, _value_date date, _store_id integer, _party_code character varying, _price_type_id integer, _reference_number character varying, _statement_reference text, _details transactions.stock_detail_type[], _attachments core.attachment_type[])" on the database.
		/// </summary>
		public PostPurchaseReturnProcedure()
		{
		}

		/// <summary>
		/// Prepares, validates, and executes the function "transactions.post_purchase_return(_transaction_master_id bigint, _office_id integer, _user_id integer, _login_id bigint, _value_date date, _store_id integer, _party_code character varying, _price_type_id integer, _reference_number character varying, _statement_reference text, _details transactions.stock_detail_type[], _attachments core.attachment_type[])" on the database.
		/// </summary>
		/// <param name="transactionMasterId">Enter argument value for "_transaction_master_id" parameter of the function "transactions.post_purchase_return".</param>
		/// <param name="officeId">Enter argument value for "_office_id" parameter of the function "transactions.post_purchase_return".</param>
		/// <param name="userId">Enter argument value for "_user_id" parameter of the function "transactions.post_purchase_return".</param>
		/// <param name="loginIdParameter">Enter argument value for "_login_id" parameter of the function "transactions.post_purchase_return".</param>
		/// <param name="valueDate">Enter argument value for "_value_date" parameter of the function "transactions.post_purchase_return".</param>
		/// <param name="storeId">Enter argument value for "_store_id" parameter of the function "transactions.post_purchase_return".</param>
		/// <param name="partyCode">Enter argument value for "_party_code" parameter of the function "transactions.post_purchase_return".</param>
		/// <param name="priceTypeId">Enter argument value for "_price_type_id" parameter of the function "transactions.post_purchase_return".</param>
		/// <param name="referenceNumber">Enter argument value for "_reference_number" parameter of the function "transactions.post_purchase_return".</param>
		/// <param name="statementReference">Enter argument value for "_statement_reference" parameter of the function "transactions.post_purchase_return".</param>
		/// <param name="details">Enter argument value for "_details" parameter of the function "transactions.post_purchase_return".</param>
		/// <param name="attachments">Enter argument value for "_attachments" parameter of the function "transactions.post_purchase_return".</param>
		public PostPurchaseReturnProcedure(long transactionMasterId,int officeId,int userId,long loginIdParameter,DateTime valueDate,int storeId,string partyCode,int priceTypeId,string referenceNumber,string statementReference,MixERP.Net.Entities.Transactions.StockDetailType[][] details,MixERP.Net.Entities.Core.AttachmentType[][] attachments)
		{
			this.TransactionMasterId = transactionMasterId;
			this.OfficeId = officeId;
			this.UserId = userId;
			this.LoginIdParameter = loginIdParameter;
			this.ValueDate = valueDate;
			this.StoreId = storeId;
			this.PartyCode = partyCode;
			this.PriceTypeId = priceTypeId;
			this.ReferenceNumber = referenceNumber;
			this.StatementReference = statementReference;
			this.Details = details;
			this.Attachments = attachments;
		}
		/// <summary>
		/// Prepares and executes the function "transactions.post_purchase_return".
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
                    Log.Information("Access to the function \"PostPurchaseReturnProcedure\" was denied to the user with Login ID {LoginId}.", this.LoginId);
					throw new UnauthorizedException("Access is denied.");
				}
			}
			const string query = "SELECT * FROM transactions.post_purchase_return(@0::bigint, @1::integer, @2::integer, @3::bigint, @4::date, @5::integer, @6::character varying, @7::integer, @8::character varying, @9::text, @10::transactions.stock_detail_type[], @11::core.attachment_type[]);";
			return Factory.Scalar<long>(this.Catalog, query, this.TransactionMasterId, this.OfficeId, this.UserId, this.LoginIdParameter, this.ValueDate, this.StoreId, this.PartyCode, this.PriceTypeId, this.ReferenceNumber, this.StatementReference, this.Details, this.Attachments);
		} 
	}
}