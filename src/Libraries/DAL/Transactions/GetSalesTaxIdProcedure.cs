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
	/// Prepares, validates, and executes the function "transactions.get_sales_tax_id(_tran_book character varying, _store_id integer, _party_code character varying, _shipping_address_code character varying, _price_type_id integer, _item_code character varying, _unit_id integer, _price money_strict)" on the database.
	/// </summary>
	public class GetSalesTaxIdProcedure: DbAccess
	{
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
	    public override string ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
	    public override string ObjectName => "get_sales_tax_id";
        /// <summary>
        /// Login id of application user accessing this PostgreSQL function.
        /// </summary>
		public long LoginId { get; set; }
        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Maps to "_tran_book" argument of the function "transactions.get_sales_tax_id".
		/// </summary>
		public string TranBook { get; set; }
		/// <summary>
		/// Maps to "_store_id" argument of the function "transactions.get_sales_tax_id".
		/// </summary>
		public int StoreId { get; set; }
		/// <summary>
		/// Maps to "_party_code" argument of the function "transactions.get_sales_tax_id".
		/// </summary>
		public string PartyCode { get; set; }
		/// <summary>
		/// Maps to "_shipping_address_code" argument of the function "transactions.get_sales_tax_id".
		/// </summary>
		public string ShippingAddressCode { get; set; }
		/// <summary>
		/// Maps to "_price_type_id" argument of the function "transactions.get_sales_tax_id".
		/// </summary>
		public int PriceTypeId { get; set; }
		/// <summary>
		/// Maps to "_item_code" argument of the function "transactions.get_sales_tax_id".
		/// </summary>
		public string ItemCode { get; set; }
		/// <summary>
		/// Maps to "_unit_id" argument of the function "transactions.get_sales_tax_id".
		/// </summary>
		public int UnitId { get; set; }
		/// <summary>
		/// Maps to "_price" argument of the function "transactions.get_sales_tax_id".
		/// </summary>
		public decimal Price { get; set; }

		/// <summary>
		/// Prepares, validates, and executes the function "transactions.get_sales_tax_id(_tran_book character varying, _store_id integer, _party_code character varying, _shipping_address_code character varying, _price_type_id integer, _item_code character varying, _unit_id integer, _price money_strict)" on the database.
		/// </summary>
		public GetSalesTaxIdProcedure()
		{
		}

		/// <summary>
		/// Prepares, validates, and executes the function "transactions.get_sales_tax_id(_tran_book character varying, _store_id integer, _party_code character varying, _shipping_address_code character varying, _price_type_id integer, _item_code character varying, _unit_id integer, _price money_strict)" on the database.
		/// </summary>
		/// <param name="tranBook">Enter argument value for "_tran_book" parameter of the function "transactions.get_sales_tax_id".</param>
		/// <param name="storeId">Enter argument value for "_store_id" parameter of the function "transactions.get_sales_tax_id".</param>
		/// <param name="partyCode">Enter argument value for "_party_code" parameter of the function "transactions.get_sales_tax_id".</param>
		/// <param name="shippingAddressCode">Enter argument value for "_shipping_address_code" parameter of the function "transactions.get_sales_tax_id".</param>
		/// <param name="priceTypeId">Enter argument value for "_price_type_id" parameter of the function "transactions.get_sales_tax_id".</param>
		/// <param name="itemCode">Enter argument value for "_item_code" parameter of the function "transactions.get_sales_tax_id".</param>
		/// <param name="unitId">Enter argument value for "_unit_id" parameter of the function "transactions.get_sales_tax_id".</param>
		/// <param name="price">Enter argument value for "_price" parameter of the function "transactions.get_sales_tax_id".</param>
		public GetSalesTaxIdProcedure(string tranBook,int storeId,string partyCode,string shippingAddressCode,int priceTypeId,string itemCode,int unitId,decimal price)
		{
			this.TranBook = tranBook;
			this.StoreId = storeId;
			this.PartyCode = partyCode;
			this.ShippingAddressCode = shippingAddressCode;
			this.PriceTypeId = priceTypeId;
			this.ItemCode = itemCode;
			this.UnitId = unitId;
			this.Price = price;
		}
		/// <summary>
		/// Prepares and executes the function "transactions.get_sales_tax_id".
		/// </summary>
		public int Execute()
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
				const string query = "SELECT * FROM transactions.get_sales_tax_id(@0::character varying, @1::integer, @2::character varying, @3::character varying, @4::integer, @5::character varying, @6::integer, @7::money_strict);";
				return Factory.Scalar<int>(this.Catalog, query, this.TranBook, this.StoreId, this.PartyCode, this.ShippingAddressCode, this.PriceTypeId, this.ItemCode, this.UnitId, this.Price);
			}
			catch (UnauthorizedException ex)
			{
				Log.Error("{Exception} {@Exception}", ex.Message, ex);
                throw new MixERPException(ex.Message, ex);
			}
		} 
	}
}