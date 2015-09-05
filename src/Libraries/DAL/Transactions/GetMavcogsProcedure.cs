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
	/// Prepares, validates, and executes the function "transactions.get_mavcogs(_item_id integer, _store_id integer, _base_quantity numeric, _factor numeric)" on the database.
	/// </summary>
	public class GetMavcogsProcedure: DbAccess
	{
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
	    public override string ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
	    public override string ObjectName => "get_mavcogs";
        /// <summary>
        /// Login id of application user accessing this PostgreSQL function.
        /// </summary>
		public long LoginId { get; set; }
        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Maps to "_item_id" argument of the function "transactions.get_mavcogs".
		/// </summary>
		public int ItemId { get; set; }
		/// <summary>
		/// Maps to "_store_id" argument of the function "transactions.get_mavcogs".
		/// </summary>
		public int StoreId { get; set; }
		/// <summary>
		/// Maps to "_base_quantity" argument of the function "transactions.get_mavcogs".
		/// </summary>
		public decimal BaseQuantity { get; set; }
		/// <summary>
		/// Maps to "_factor" argument of the function "transactions.get_mavcogs".
		/// </summary>
		public decimal Factor { get; set; }

		/// <summary>
		/// Prepares, validates, and executes the function "transactions.get_mavcogs(_item_id integer, _store_id integer, _base_quantity numeric, _factor numeric)" on the database.
		/// </summary>
		public GetMavcogsProcedure()
		{
		}

		/// <summary>
		/// Prepares, validates, and executes the function "transactions.get_mavcogs(_item_id integer, _store_id integer, _base_quantity numeric, _factor numeric)" on the database.
		/// </summary>
		/// <param name="itemId">Enter argument value for "_item_id" parameter of the function "transactions.get_mavcogs".</param>
		/// <param name="storeId">Enter argument value for "_store_id" parameter of the function "transactions.get_mavcogs".</param>
		/// <param name="baseQuantity">Enter argument value for "_base_quantity" parameter of the function "transactions.get_mavcogs".</param>
		/// <param name="factor">Enter argument value for "_factor" parameter of the function "transactions.get_mavcogs".</param>
		public GetMavcogsProcedure(int itemId,int storeId,decimal baseQuantity,decimal factor)
		{
			this.ItemId = itemId;
			this.StoreId = storeId;
			this.BaseQuantity = baseQuantity;
			this.Factor = factor;
		}
		/// <summary>
		/// Prepares and executes the function "transactions.get_mavcogs".
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
                    Log.Information("Access to the function \"GetMavcogsProcedure\" was denied to the user with Login ID {LoginId}.", this.LoginId);
					throw new UnauthorizedException("Access is denied.");
				}
			}
			const string query = "SELECT * FROM transactions.get_mavcogs(@0::integer, @1::integer, @2::numeric, @3::numeric);";
			return Factory.Scalar<decimal>(this.Catalog, query, this.ItemId, this.StoreId, this.BaseQuantity, this.Factor);
		} 
	}
}