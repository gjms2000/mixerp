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
	/// Prepares, validates, and executes the function "core.count_purchases(_item_id integer, _unit_id integer, _store_id integer)" on the database.
	/// </summary>
	public class CountPurchasesProcedure: DbAccess
	{
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
	    public override string ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
	    public override string ObjectName => "count_purchases";
        /// <summary>
        /// Login id of application user accessing this PostgreSQL function.
        /// </summary>
		public long LoginId { get; set; }
        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Maps to "_item_id" argument of the function "core.count_purchases".
		/// </summary>
		public int ItemId { get; set; }
		/// <summary>
		/// Maps to "_unit_id" argument of the function "core.count_purchases".
		/// </summary>
		public int UnitId { get; set; }
		/// <summary>
		/// Maps to "_store_id" argument of the function "core.count_purchases".
		/// </summary>
		public int StoreId { get; set; }

		/// <summary>
		/// Prepares, validates, and executes the function "core.count_purchases(_item_id integer, _unit_id integer, _store_id integer)" on the database.
		/// </summary>
		public CountPurchasesProcedure()
		{
		}

		/// <summary>
		/// Prepares, validates, and executes the function "core.count_purchases(_item_id integer, _unit_id integer, _store_id integer)" on the database.
		/// </summary>
		/// <param name="itemId">Enter argument value for "_item_id" parameter of the function "core.count_purchases".</param>
		/// <param name="unitId">Enter argument value for "_unit_id" parameter of the function "core.count_purchases".</param>
		/// <param name="storeId">Enter argument value for "_store_id" parameter of the function "core.count_purchases".</param>
		public CountPurchasesProcedure(int itemId,int unitId,int storeId)
		{
			this.ItemId = itemId;
			this.UnitId = unitId;
			this.StoreId = storeId;
		}
		/// <summary>
		/// Prepares and executes the function "core.count_purchases".
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
                    Log.Information("Access to the function \"CountPurchasesProcedure\" was denied to the user with Login ID {LoginId}.", this.LoginId);
					throw new UnauthorizedException("Access is denied.");
				}
			}
			const string query = "SELECT * FROM core.count_purchases(@0::integer, @1::integer, @2::integer);";
			return Factory.Scalar<decimal>(this.Catalog, query, this.ItemId, this.UnitId, this.StoreId);
		} 
	}
}