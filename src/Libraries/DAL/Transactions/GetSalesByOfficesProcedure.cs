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
	/// Prepares, validates, and executes the function "transactions.get_sales_by_offices(office_id integer, divide_by integer)" on the database.
	/// </summary>
	public class GetSalesByOfficesProcedure: DbAccess
	{
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
	    public override string ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
	    public override string ObjectName => "get_sales_by_offices";
        /// <summary>
        /// Login id of application user accessing this PostgreSQL function.
        /// </summary>
		public long LoginId { get; set; }
        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Maps to "office_id" argument of the function "transactions.get_sales_by_offices".
		/// </summary>
		public int OfficeId { get; set; }
		/// <summary>
		/// Maps to "divide_by" argument of the function "transactions.get_sales_by_offices".
		/// </summary>
		public int DivideBy { get; set; }

		/// <summary>
		/// Prepares, validates, and executes the function "transactions.get_sales_by_offices(office_id integer, divide_by integer)" on the database.
		/// </summary>
		public GetSalesByOfficesProcedure()
		{
		}

		/// <summary>
		/// Prepares, validates, and executes the function "transactions.get_sales_by_offices(office_id integer, divide_by integer)" on the database.
		/// </summary>
		/// <param name="officeId">Enter argument value for "office_id" parameter of the function "transactions.get_sales_by_offices".</param>
		/// <param name="divideBy">Enter argument value for "divide_by" parameter of the function "transactions.get_sales_by_offices".</param>
		public GetSalesByOfficesProcedure(int officeId,int divideBy)
		{
			this.OfficeId = officeId;
			this.DivideBy = divideBy;
		}
		/// <summary>
		/// Prepares and executes the function "transactions.get_sales_by_offices".
		/// </summary>
		public IEnumerable<DbGetSalesByOfficesResult> Execute()
		{
			if (!this.SkipValidation)
			{
				if (!this.Validated)
				{
					this.Validate(AccessTypeEnum.Execute, this.LoginId, false);
				}
				if (!this.HasAccess)
				{
                    Log.Information("Access to the function \"GetSalesByOfficesProcedure\" was denied to the user with Login ID {LoginId}.", this.LoginId);
					throw new UnauthorizedException("Access is denied.");
				}
			}
			const string query = "SELECT * FROM transactions.get_sales_by_offices(@0::integer, @1::integer);";
			return Factory.Get<DbGetSalesByOfficesResult>(this.Catalog, query, this.OfficeId, this.DivideBy);
		} 
	}
}