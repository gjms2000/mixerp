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
	/// Prepares, validates, and executes the function "transactions.get_balance_sheet(_previous_period date, _current_period date, _user_id integer, _office_id integer, _factor integer)" on the database.
	/// </summary>
	public class GetBalanceSheetProcedure: DbAccess
	{
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
	    public override string ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
	    public override string ObjectName => "get_balance_sheet";
        /// <summary>
        /// Login id of application user accessing this PostgreSQL function.
        /// </summary>
		public long LoginId { get; set; }
        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Maps to "_previous_period" argument of the function "transactions.get_balance_sheet".
		/// </summary>
		public DateTime PreviousPeriod { get; set; }
		/// <summary>
		/// Maps to "_current_period" argument of the function "transactions.get_balance_sheet".
		/// </summary>
		public DateTime CurrentPeriod { get; set; }
		/// <summary>
		/// Maps to "_user_id" argument of the function "transactions.get_balance_sheet".
		/// </summary>
		public int UserId { get; set; }
		/// <summary>
		/// Maps to "_office_id" argument of the function "transactions.get_balance_sheet".
		/// </summary>
		public int OfficeId { get; set; }
		/// <summary>
		/// Maps to "_factor" argument of the function "transactions.get_balance_sheet".
		/// </summary>
		public int Factor { get; set; }

		/// <summary>
		/// Prepares, validates, and executes the function "transactions.get_balance_sheet(_previous_period date, _current_period date, _user_id integer, _office_id integer, _factor integer)" on the database.
		/// </summary>
		public GetBalanceSheetProcedure()
		{
		}

		/// <summary>
		/// Prepares, validates, and executes the function "transactions.get_balance_sheet(_previous_period date, _current_period date, _user_id integer, _office_id integer, _factor integer)" on the database.
		/// </summary>
		/// <param name="previousPeriod">Enter argument value for "_previous_period" parameter of the function "transactions.get_balance_sheet".</param>
		/// <param name="currentPeriod">Enter argument value for "_current_period" parameter of the function "transactions.get_balance_sheet".</param>
		/// <param name="userId">Enter argument value for "_user_id" parameter of the function "transactions.get_balance_sheet".</param>
		/// <param name="officeId">Enter argument value for "_office_id" parameter of the function "transactions.get_balance_sheet".</param>
		/// <param name="factor">Enter argument value for "_factor" parameter of the function "transactions.get_balance_sheet".</param>
		public GetBalanceSheetProcedure(DateTime previousPeriod,DateTime currentPeriod,int userId,int officeId,int factor)
		{
			this.PreviousPeriod = previousPeriod;
			this.CurrentPeriod = currentPeriod;
			this.UserId = userId;
			this.OfficeId = officeId;
			this.Factor = factor;
		}
		/// <summary>
		/// Prepares and executes the function "transactions.get_balance_sheet".
		/// </summary>
		public IEnumerable<DbGetBalanceSheetResult> Execute()
		{
			if (!this.SkipValidation)
			{
				if (!this.Validated)
				{
					this.Validate(AccessTypeEnum.Execute, this.LoginId, false);
				}
				if (!this.HasAccess)
				{
                    Log.Information("Access to the function \"GetBalanceSheetProcedure\" was denied to the user with Login ID {LoginId}.", this.LoginId);
					throw new UnauthorizedException("Access is denied.");
				}
			}
			const string query = "SELECT * FROM transactions.get_balance_sheet(@0::date, @1::date, @2::integer, @3::integer, @4::integer);";
			return Factory.Get<DbGetBalanceSheetResult>(this.Catalog, query, this.PreviousPeriod, this.CurrentPeriod, this.UserId, this.OfficeId, this.Factor);
		} 
	}
}