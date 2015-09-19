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
    /// Prepares, validates, and executes the function "transactions.get_sales_tax(_tran_book character varying, _store_id integer, _party_code character varying, _shipping_address_code character varying, _price_type_id integer, _item_code character varying, _price money_strict2, _quantity integer_strict2, _discount money_strict2, _shipping_charge money_strict2, _sales_tax_id integer)" on the database.
    /// </summary>
    public class GetSalesTaxProcedure : DbAccess
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string ObjectName => "get_sales_tax";
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
        /// Maps to "_tran_book" argument of the function "transactions.get_sales_tax".
        /// </summary>
        public string TranBook { get; set; }
        /// <summary>
        /// Maps to "_store_id" argument of the function "transactions.get_sales_tax".
        /// </summary>
        public int StoreId { get; set; }
        /// <summary>
        /// Maps to "_party_code" argument of the function "transactions.get_sales_tax".
        /// </summary>
        public string PartyCode { get; set; }
        /// <summary>
        /// Maps to "_shipping_address_code" argument of the function "transactions.get_sales_tax".
        /// </summary>
        public string ShippingAddressCode { get; set; }
        /// <summary>
        /// Maps to "_price_type_id" argument of the function "transactions.get_sales_tax".
        /// </summary>
        public int PriceTypeId { get; set; }
        /// <summary>
        /// Maps to "_item_code" argument of the function "transactions.get_sales_tax".
        /// </summary>
        public string ItemCode { get; set; }
        /// <summary>
        /// Maps to "_price" argument of the function "transactions.get_sales_tax".
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Maps to "_quantity" argument of the function "transactions.get_sales_tax".
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// Maps to "_discount" argument of the function "transactions.get_sales_tax".
        /// </summary>
        public decimal Discount { get; set; }
        /// <summary>
        /// Maps to "_shipping_charge" argument of the function "transactions.get_sales_tax".
        /// </summary>
        public decimal ShippingCharge { get; set; }
        /// <summary>
        /// Maps to "_sales_tax_id" argument of the function "transactions.get_sales_tax".
        /// </summary>
        public int SalesTaxId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_sales_tax(_tran_book character varying, _store_id integer, _party_code character varying, _shipping_address_code character varying, _price_type_id integer, _item_code character varying, _price money_strict2, _quantity integer_strict2, _discount money_strict2, _shipping_charge money_strict2, _sales_tax_id integer)" on the database.
        /// </summary>
        public GetSalesTaxProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_sales_tax(_tran_book character varying, _store_id integer, _party_code character varying, _shipping_address_code character varying, _price_type_id integer, _item_code character varying, _price money_strict2, _quantity integer_strict2, _discount money_strict2, _shipping_charge money_strict2, _sales_tax_id integer)" on the database.
        /// </summary>
        /// <param name="tranBook">Enter argument value for "_tran_book" parameter of the function "transactions.get_sales_tax".</param>
        /// <param name="storeId">Enter argument value for "_store_id" parameter of the function "transactions.get_sales_tax".</param>
        /// <param name="partyCode">Enter argument value for "_party_code" parameter of the function "transactions.get_sales_tax".</param>
        /// <param name="shippingAddressCode">Enter argument value for "_shipping_address_code" parameter of the function "transactions.get_sales_tax".</param>
        /// <param name="priceTypeId">Enter argument value for "_price_type_id" parameter of the function "transactions.get_sales_tax".</param>
        /// <param name="itemCode">Enter argument value for "_item_code" parameter of the function "transactions.get_sales_tax".</param>
        /// <param name="price">Enter argument value for "_price" parameter of the function "transactions.get_sales_tax".</param>
        /// <param name="quantity">Enter argument value for "_quantity" parameter of the function "transactions.get_sales_tax".</param>
        /// <param name="discount">Enter argument value for "_discount" parameter of the function "transactions.get_sales_tax".</param>
        /// <param name="shippingCharge">Enter argument value for "_shipping_charge" parameter of the function "transactions.get_sales_tax".</param>
        /// <param name="salesTaxId">Enter argument value for "_sales_tax_id" parameter of the function "transactions.get_sales_tax".</param>
        public GetSalesTaxProcedure(string tranBook, int storeId, string partyCode, string shippingAddressCode, int priceTypeId, string itemCode, decimal price, int quantity, decimal discount, decimal shippingCharge, int salesTaxId)
        {
            this.TranBook = tranBook;
            this.StoreId = storeId;
            this.PartyCode = partyCode;
            this.ShippingAddressCode = shippingAddressCode;
            this.PriceTypeId = priceTypeId;
            this.ItemCode = itemCode;
            this.Price = price;
            this.Quantity = quantity;
            this.Discount = discount;
            this.ShippingCharge = shippingCharge;
            this.SalesTaxId = salesTaxId;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.get_sales_tax".
        /// </summary>
        public IEnumerable<DbGetSalesTaxResult> Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"GetSalesTaxProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            const string query = "SELECT * FROM transactions.get_sales_tax(@0::character varying, @1::integer, @2::character varying, @3::character varying, @4::integer, @5::character varying, @6::money_strict2, @7::integer_strict2, @8::money_strict2, @9::money_strict2, @10::integer);";
            return Factory.Get<DbGetSalesTaxResult>(this.Catalog, query, this.TranBook, this.StoreId, this.PartyCode, this.ShippingAddressCode, this.PriceTypeId, this.ItemCode, this.Price, this.Quantity, this.Discount, this.ShippingCharge, this.SalesTaxId);
        }
    }
}