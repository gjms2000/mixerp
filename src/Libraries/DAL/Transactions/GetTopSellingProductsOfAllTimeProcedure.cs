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
	/// Prepares, validates, and executes the function "transactions.get_top_selling_products_of_all_time(top integer)" on the database.
	/// </summary>
	public class GetTopSellingProductsOfAllTimeProcedure: DbAccess
	{
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
	    public override string ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
	    public override string ObjectName => "get_top_selling_products_of_all_time";
        /// <summary>
        /// Login id of application user accessing this PostgreSQL function.
        /// </summary>
		public long LoginId { get; set; }
        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Maps to "top" argument of the function "transactions.get_top_selling_products_of_all_time".
		/// </summary>
		public int Top { get; set; }

		/// <summary>
		/// Prepares, validates, and executes the function "transactions.get_top_selling_products_of_all_time(top integer)" on the database.
		/// </summary>
		public GetTopSellingProductsOfAllTimeProcedure()
		{
		}

		/// <summary>
		/// Prepares, validates, and executes the function "transactions.get_top_selling_products_of_all_time(top integer)" on the database.
		/// </summary>
		/// <param name="top">Enter argument value for "top" parameter of the function "transactions.get_top_selling_products_of_all_time".</param>
		public GetTopSellingProductsOfAllTimeProcedure(int top)
		{
			this.Top = top;
		}
		/// <summary>
		/// Prepares and executes the function "transactions.get_top_selling_products_of_all_time".
		/// </summary>
		public IEnumerable<DbGetTopSellingProductsOfAllTimeResult> Execute()
		{
			if (!this.SkipValidation)
			{
				if (!this.Validated)
				{
					this.Validate(AccessTypeEnum.Execute, this.LoginId, false);
				}
				if (!this.HasAccess)
				{
                    Log.Information("Access to the function \"GetTopSellingProductsOfAllTimeProcedure\" was denied to the user with Login ID {LoginId}.", this.LoginId);
					throw new UnauthorizedException("Access is denied.");
				}
			}
			const string query = "SELECT * FROM transactions.get_top_selling_products_of_all_time(@0::integer);";
			return Factory.Get<DbGetTopSellingProductsOfAllTimeResult>(this.Catalog, query, this.Top);
		} 
	}
}