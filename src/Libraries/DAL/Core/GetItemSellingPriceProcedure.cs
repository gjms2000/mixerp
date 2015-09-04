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
using MixERP.Net.Entities.Core;
using Npgsql;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
namespace MixERP.Net.Schemas.Core.Data
{
	/// <summary>
	/// Prepares, validates, and executes the function "core.get_item_selling_price(item_id_ integer, party_type_id_ integer, price_type_id_ integer, unit_id_ integer)" on the database.
	/// </summary>
	public class GetItemSellingPriceProcedure: DbAccess
	{
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
	    public override string ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
	    public override string ObjectName => "get_item_selling_price";
        /// <summary>
        /// Login id of application user accessing this PostgreSQL function.
        /// </summary>
		public long LoginId { get; set; }
        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Maps to "item_id_" argument of the function "core.get_item_selling_price".
		/// </summary>
		public int ItemId { get; set; }
		/// <summary>
		/// Maps to "party_type_id_" argument of the function "core.get_item_selling_price".
		/// </summary>
		public int PartyTypeId { get; set; }
		/// <summary>
		/// Maps to "price_type_id_" argument of the function "core.get_item_selling_price".
		/// </summary>
		public int PriceTypeId { get; set; }
		/// <summary>
		/// Maps to "unit_id_" argument of the function "core.get_item_selling_price".
		/// </summary>
		public int UnitId { get; set; }

		/// <summary>
		/// Prepares, validates, and executes the function "core.get_item_selling_price(item_id_ integer, party_type_id_ integer, price_type_id_ integer, unit_id_ integer)" on the database.
		/// </summary>
		public GetItemSellingPriceProcedure()
		{
		}

		/// <summary>
		/// Prepares, validates, and executes the function "core.get_item_selling_price(item_id_ integer, party_type_id_ integer, price_type_id_ integer, unit_id_ integer)" on the database.
		/// </summary>
		/// <param name="itemId">Enter argument value for "item_id_" parameter of the function "core.get_item_selling_price".</param>
		/// <param name="partyTypeId">Enter argument value for "party_type_id_" parameter of the function "core.get_item_selling_price".</param>
		/// <param name="priceTypeId">Enter argument value for "price_type_id_" parameter of the function "core.get_item_selling_price".</param>
		/// <param name="unitId">Enter argument value for "unit_id_" parameter of the function "core.get_item_selling_price".</param>
		public GetItemSellingPriceProcedure(int itemId,int partyTypeId,int priceTypeId,int unitId)
		{
			this.ItemId = itemId;
			this.PartyTypeId = partyTypeId;
			this.PriceTypeId = priceTypeId;
			this.UnitId = unitId;
		}
		/// <summary>
		/// Prepares and executes the function "core.get_item_selling_price".
		/// </summary>
		public decimal Execute()
		{
			if (!this.SkipValidation)
			{
				if (!this.Validated)
				{
					this.Validate(AccessTypeEnum.Execute, this.LoginId, false);
				}
				if (!this.HasAccess)
				{
                    Log.Information("Access to the function \"GetItemSellingPriceProcedure\" was denied to the user with Login ID {LoginId}.", this.LoginId);
					throw new UnauthorizedException("Access is denied.");
				}
			}
			const string query = "SELECT * FROM core.get_item_selling_price(@0::integer, @1::integer, @2::integer, @3::integer);";
			return Factory.Get<decimal>(this.Catalog, query, this.ItemId, this.PartyTypeId, this.PriceTypeId, this.UnitId).FirstOrDefault();
		} 
	}
}