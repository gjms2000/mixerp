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
	/// Prepares, validates, and executes the function "transactions.post_sales(_book_name character varying, _office_id integer, _user_id integer, _login_id bigint, _value_date date, _cost_center_id integer, _reference_number character varying, _statement_reference text, _is_credit boolean, _payment_term_id integer, _party_code character varying, _price_type_id integer, _salesperson_id integer, _shipper_id integer, _shipping_address_code character varying, _store_id integer, _is_non_taxable_sales boolean, _details transactions.stock_detail_type[], _attachments core.attachment_type[], _non_gl_tran_ids bigint[])" on the database.
	/// </summary>
	public class PostSalesProcedure: DbAccess
	{
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
	    public override string ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
	    public override string ObjectName => "post_sales";
        /// <summary>
        /// Login id of application user accessing this PostgreSQL function.
        /// </summary>
		public long LoginId { get; set; }
        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Maps to "_book_name" argument of the function "transactions.post_sales".
		/// </summary>
		public string BookName { get; set; }
		/// <summary>
		/// Maps to "_office_id" argument of the function "transactions.post_sales".
		/// </summary>
		public int OfficeId { get; set; }
		/// <summary>
		/// Maps to "_user_id" argument of the function "transactions.post_sales".
		/// </summary>
		public int UserId { get; set; }
		/// <summary>
		/// Maps to "_login_id" argument of the function "transactions.post_sales".
		/// </summary>
		public long LoginIdParameter { get; set; }
		/// <summary>
		/// Maps to "_value_date" argument of the function "transactions.post_sales".
		/// </summary>
		public DateTime ValueDate { get; set; }
		/// <summary>
		/// Maps to "_cost_center_id" argument of the function "transactions.post_sales".
		/// </summary>
		public int CostCenterId { get; set; }
		/// <summary>
		/// Maps to "_reference_number" argument of the function "transactions.post_sales".
		/// </summary>
		public string ReferenceNumber { get; set; }
		/// <summary>
		/// Maps to "_statement_reference" argument of the function "transactions.post_sales".
		/// </summary>
		public string StatementReference { get; set; }
		/// <summary>
		/// Maps to "_is_credit" argument of the function "transactions.post_sales".
		/// </summary>
		public bool IsCredit { get; set; }
		/// <summary>
		/// Maps to "_payment_term_id" argument of the function "transactions.post_sales".
		/// </summary>
		public int PaymentTermId { get; set; }
		/// <summary>
		/// Maps to "_party_code" argument of the function "transactions.post_sales".
		/// </summary>
		public string PartyCode { get; set; }
		/// <summary>
		/// Maps to "_price_type_id" argument of the function "transactions.post_sales".
		/// </summary>
		public int PriceTypeId { get; set; }
		/// <summary>
		/// Maps to "_salesperson_id" argument of the function "transactions.post_sales".
		/// </summary>
		public int SalespersonId { get; set; }
		/// <summary>
		/// Maps to "_shipper_id" argument of the function "transactions.post_sales".
		/// </summary>
		public int ShipperId { get; set; }
		/// <summary>
		/// Maps to "_shipping_address_code" argument of the function "transactions.post_sales".
		/// </summary>
		public string ShippingAddressCode { get; set; }
		/// <summary>
		/// Maps to "_store_id" argument of the function "transactions.post_sales".
		/// </summary>
		public int StoreId { get; set; }
		/// <summary>
		/// Maps to "_is_non_taxable_sales" argument of the function "transactions.post_sales".
		/// </summary>
		public bool IsNonTaxableSales { get; set; }
		/// <summary>
		/// Maps to "_details" argument of the function "transactions.post_sales".
		/// </summary>
		public MixERP.Net.Entities.Transactions.StockDetailType[][] Details { get; set; }
		/// <summary>
		/// Maps to "_attachments" argument of the function "transactions.post_sales".
		/// </summary>
		public MixERP.Net.Entities.Core.AttachmentType[][] Attachments { get; set; }
		/// <summary>
		/// Maps to "_non_gl_tran_ids" argument of the function "transactions.post_sales".
		/// </summary>
		public long[] NonGlTranIds { get; set; }

		/// <summary>
		/// Prepares, validates, and executes the function "transactions.post_sales(_book_name character varying, _office_id integer, _user_id integer, _login_id bigint, _value_date date, _cost_center_id integer, _reference_number character varying, _statement_reference text, _is_credit boolean, _payment_term_id integer, _party_code character varying, _price_type_id integer, _salesperson_id integer, _shipper_id integer, _shipping_address_code character varying, _store_id integer, _is_non_taxable_sales boolean, _details transactions.stock_detail_type[], _attachments core.attachment_type[], _non_gl_tran_ids bigint[])" on the database.
		/// </summary>
		public PostSalesProcedure()
		{
		}

		/// <summary>
		/// Prepares, validates, and executes the function "transactions.post_sales(_book_name character varying, _office_id integer, _user_id integer, _login_id bigint, _value_date date, _cost_center_id integer, _reference_number character varying, _statement_reference text, _is_credit boolean, _payment_term_id integer, _party_code character varying, _price_type_id integer, _salesperson_id integer, _shipper_id integer, _shipping_address_code character varying, _store_id integer, _is_non_taxable_sales boolean, _details transactions.stock_detail_type[], _attachments core.attachment_type[], _non_gl_tran_ids bigint[])" on the database.
		/// </summary>
		/// <param name="bookName">Enter argument value for "_book_name" parameter of the function "transactions.post_sales".</param>
		/// <param name="officeId">Enter argument value for "_office_id" parameter of the function "transactions.post_sales".</param>
		/// <param name="userId">Enter argument value for "_user_id" parameter of the function "transactions.post_sales".</param>
		/// <param name="loginIdParameter">Enter argument value for "_login_id" parameter of the function "transactions.post_sales".</param>
		/// <param name="valueDate">Enter argument value for "_value_date" parameter of the function "transactions.post_sales".</param>
		/// <param name="costCenterId">Enter argument value for "_cost_center_id" parameter of the function "transactions.post_sales".</param>
		/// <param name="referenceNumber">Enter argument value for "_reference_number" parameter of the function "transactions.post_sales".</param>
		/// <param name="statementReference">Enter argument value for "_statement_reference" parameter of the function "transactions.post_sales".</param>
		/// <param name="isCredit">Enter argument value for "_is_credit" parameter of the function "transactions.post_sales".</param>
		/// <param name="paymentTermId">Enter argument value for "_payment_term_id" parameter of the function "transactions.post_sales".</param>
		/// <param name="partyCode">Enter argument value for "_party_code" parameter of the function "transactions.post_sales".</param>
		/// <param name="priceTypeId">Enter argument value for "_price_type_id" parameter of the function "transactions.post_sales".</param>
		/// <param name="salespersonId">Enter argument value for "_salesperson_id" parameter of the function "transactions.post_sales".</param>
		/// <param name="shipperId">Enter argument value for "_shipper_id" parameter of the function "transactions.post_sales".</param>
		/// <param name="shippingAddressCode">Enter argument value for "_shipping_address_code" parameter of the function "transactions.post_sales".</param>
		/// <param name="storeId">Enter argument value for "_store_id" parameter of the function "transactions.post_sales".</param>
		/// <param name="isNonTaxableSales">Enter argument value for "_is_non_taxable_sales" parameter of the function "transactions.post_sales".</param>
		/// <param name="details">Enter argument value for "_details" parameter of the function "transactions.post_sales".</param>
		/// <param name="attachments">Enter argument value for "_attachments" parameter of the function "transactions.post_sales".</param>
		/// <param name="nonGlTranIds">Enter argument value for "_non_gl_tran_ids" parameter of the function "transactions.post_sales".</param>
		public PostSalesProcedure(string bookName,int officeId,int userId,long loginIdParameter,DateTime valueDate,int costCenterId,string referenceNumber,string statementReference,bool isCredit,int paymentTermId,string partyCode,int priceTypeId,int salespersonId,int shipperId,string shippingAddressCode,int storeId,bool isNonTaxableSales,MixERP.Net.Entities.Transactions.StockDetailType[][] details,MixERP.Net.Entities.Core.AttachmentType[][] attachments,long[] nonGlTranIds)
		{
			this.BookName = bookName;
			this.OfficeId = officeId;
			this.UserId = userId;
			this.LoginIdParameter = loginIdParameter;
			this.ValueDate = valueDate;
			this.CostCenterId = costCenterId;
			this.ReferenceNumber = referenceNumber;
			this.StatementReference = statementReference;
			this.IsCredit = isCredit;
			this.PaymentTermId = paymentTermId;
			this.PartyCode = partyCode;
			this.PriceTypeId = priceTypeId;
			this.SalespersonId = salespersonId;
			this.ShipperId = shipperId;
			this.ShippingAddressCode = shippingAddressCode;
			this.StoreId = storeId;
			this.IsNonTaxableSales = isNonTaxableSales;
			this.Details = details;
			this.Attachments = attachments;
			this.NonGlTranIds = nonGlTranIds;
		}
		/// <summary>
		/// Prepares and executes the function "transactions.post_sales".
		/// </summary>
		public long Execute()
		{
			try
			{
				if (!this.SkipValidation)
				{
					if (!this.Validated)
					{
						this.Validate(AccessTypeEnum.Execute, this.LoginId, false);
					}
					if (!this.HasAccess)
					{
						throw new UnauthorizedException("Access is denied.");
					}
				}
				const string query = "SELECT * FROM transactions.post_sales(@0::character varying, @1::integer, @2::integer, @3::bigint, @4::date, @5::integer, @6::character varying, @7::text, @8::boolean, @9::integer, @10::character varying, @11::integer, @12::integer, @13::integer, @14::character varying, @15::integer, @16::boolean, @17::transactions.stock_detail_type[], @18::core.attachment_type[], @19::bigint[]);";
				return Factory.Scalar<long>(this.Catalog, query, this.BookName, this.OfficeId, this.UserId, this.LoginIdParameter, this.ValueDate, this.CostCenterId, this.ReferenceNumber, this.StatementReference, this.IsCredit, this.PaymentTermId, this.PartyCode, this.PriceTypeId, this.SalespersonId, this.ShipperId, this.ShippingAddressCode, this.StoreId, this.IsNonTaxableSales, this.Details, this.Attachments, this.NonGlTranIds);
			}
			catch (UnauthorizedException ex)
			{
				Log.Error("{Exception} {@Exception}", ex.Message, ex);
                throw new MixERPException(ex.Message, ex);
			}
		} 
	}
}