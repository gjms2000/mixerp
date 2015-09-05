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
	/// Prepares, validates, and executes the function "transactions.get_closing_stock(_on_date date, _office_id integer)" on the database.
	/// </summary>
	public class GetClosingStockProcedure: DbAccess
	{
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
	    public override string ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
	    public override string ObjectName => "get_closing_stock";
        /// <summary>
        /// Login id of application user accessing this PostgreSQL function.
        /// </summary>
		public long LoginId { get; set; }
        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Maps to "_on_date" argument of the function "transactions.get_closing_stock".
		/// </summary>
		public DateTime OnDate { get; set; }
		/// <summary>
		/// Maps to "_office_id" argument of the function "transactions.get_closing_stock".
		/// </summary>
		public int OfficeId { get; set; }

		/// <summary>
		/// Prepares, validates, and executes the function "transactions.get_closing_stock(_on_date date, _office_id integer)" on the database.
		/// </summary>
		public GetClosingStockProcedure()
		{
		}

		/// <summary>
		/// Prepares, validates, and executes the function "transactions.get_closing_stock(_on_date date, _office_id integer)" on the database.
		/// </summary>
		/// <param name="onDate">Enter argument value for "_on_date" parameter of the function "transactions.get_closing_stock".</param>
		/// <param name="officeId">Enter argument value for "_office_id" parameter of the function "transactions.get_closing_stock".</param>
		public GetClosingStockProcedure(DateTime onDate,int officeId)
		{
			this.OnDate = onDate;
			this.OfficeId = officeId;
		}
		/// <summary>
		/// Prepares and executes the function "transactions.get_closing_stock".
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
                    Log.Information("Access to the function \"GetClosingStockProcedure\" was denied to the user with Login ID {LoginId}.", this.LoginId);
					throw new UnauthorizedException("Access is denied.");
				}
			}
			const string query = "SELECT * FROM transactions.get_closing_stock(@0::date, @1::integer);";
			return Factory.Scalar<decimal>(this.Catalog, query, this.OnDate, this.OfficeId);
		} 
	}
}