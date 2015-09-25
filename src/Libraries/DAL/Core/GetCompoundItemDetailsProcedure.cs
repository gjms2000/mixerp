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
using MixERP.Net.DbFactory;
using MixERP.Net.Framework;
using PetaPoco;
using MixERP.Net.Entities.Core;
using Npgsql;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
namespace MixERP.Net.Schemas.Core.Data
{
    /// <summary>
    /// Prepares, validates, and executes the function "core.get_compound_item_details(_compound_item_code character varying, _sales_tax_code character varying, _tran_book character varying, _store_id integer, _party_code character varying, _price_type_id integer)" on the database.
    /// </summary>
    public class GetCompoundItemDetailsProcedure : DbAccess
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_compound_item_details";
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
        public string _Catalog { get; set; }

        /// <summary>
        /// Maps to "_compound_item_code" argument of the function "core.get_compound_item_details".
        /// </summary>
        public string CompoundItemCode { get; set; }
        /// <summary>
        /// Maps to "_sales_tax_code" argument of the function "core.get_compound_item_details".
        /// </summary>
        public string SalesTaxCode { get; set; }
        /// <summary>
        /// Maps to "_tran_book" argument of the function "core.get_compound_item_details".
        /// </summary>
        public string TranBook { get; set; }
        /// <summary>
        /// Maps to "_store_id" argument of the function "core.get_compound_item_details".
        /// </summary>
        public int StoreId { get; set; }
        /// <summary>
        /// Maps to "_party_code" argument of the function "core.get_compound_item_details".
        /// </summary>
        public string PartyCode { get; set; }
        /// <summary>
        /// Maps to "_price_type_id" argument of the function "core.get_compound_item_details".
        /// </summary>
        public int PriceTypeId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_compound_item_details(_compound_item_code character varying, _sales_tax_code character varying, _tran_book character varying, _store_id integer, _party_code character varying, _price_type_id integer)" on the database.
        /// </summary>
        public GetCompoundItemDetailsProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_compound_item_details(_compound_item_code character varying, _sales_tax_code character varying, _tran_book character varying, _store_id integer, _party_code character varying, _price_type_id integer)" on the database.
        /// </summary>
        /// <param name="compoundItemCode">Enter argument value for "_compound_item_code" parameter of the function "core.get_compound_item_details".</param>
        /// <param name="salesTaxCode">Enter argument value for "_sales_tax_code" parameter of the function "core.get_compound_item_details".</param>
        /// <param name="tranBook">Enter argument value for "_tran_book" parameter of the function "core.get_compound_item_details".</param>
        /// <param name="storeId">Enter argument value for "_store_id" parameter of the function "core.get_compound_item_details".</param>
        /// <param name="partyCode">Enter argument value for "_party_code" parameter of the function "core.get_compound_item_details".</param>
        /// <param name="priceTypeId">Enter argument value for "_price_type_id" parameter of the function "core.get_compound_item_details".</param>
        public GetCompoundItemDetailsProcedure(string compoundItemCode, string salesTaxCode, string tranBook, int storeId, string partyCode, int priceTypeId)
        {
            this.CompoundItemCode = compoundItemCode;
            this.SalesTaxCode = salesTaxCode;
            this.TranBook = tranBook;
            this.StoreId = storeId;
            this.PartyCode = partyCode;
            this.PriceTypeId = priceTypeId;
        }
        /// <summary>
        /// Prepares and executes the function "core.get_compound_item_details".
        /// </summary>
        public IEnumerable<DbGetCompoundItemDetailsResult> Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"GetCompoundItemDetailsProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            const string query = "SELECT * FROM core.get_compound_item_details(@0::character varying, @1::character varying, @2::character varying, @3::integer, @4::character varying, @5::integer);";
            return Factory.Get<DbGetCompoundItemDetailsResult>(this._Catalog, query, this.CompoundItemCode, this.SalesTaxCode, this.TranBook, this.StoreId, this.PartyCode, this.PriceTypeId);
        }
    }
}