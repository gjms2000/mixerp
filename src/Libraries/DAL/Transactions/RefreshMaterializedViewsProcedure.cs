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
	/// Prepares, validates, and executes the function "transactions.refresh_materialized_views(_user_id integer, _login_id bigint, _office_id integer, _value_date date)" on the database.
	/// </summary>
	public class RefreshMaterializedViewsProcedure: DbAccess
	{
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
	    public override string ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
	    public override string ObjectName => "refresh_materialized_views";
        /// <summary>
        /// Login id of application user accessing this PostgreSQL function.
        /// </summary>
		public long LoginId { get; set; }
        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Maps to "_user_id" argument of the function "transactions.refresh_materialized_views".
		/// </summary>
		public int UserId { get; set; }
		/// <summary>
		/// Maps to "_login_id" argument of the function "transactions.refresh_materialized_views".
		/// </summary>
		public long LoginIdParameter { get; set; }
		/// <summary>
		/// Maps to "_office_id" argument of the function "transactions.refresh_materialized_views".
		/// </summary>
		public int OfficeId { get; set; }
		/// <summary>
		/// Maps to "_value_date" argument of the function "transactions.refresh_materialized_views".
		/// </summary>
		public DateTime ValueDate { get; set; }

		/// <summary>
		/// Prepares, validates, and executes the function "transactions.refresh_materialized_views(_user_id integer, _login_id bigint, _office_id integer, _value_date date)" on the database.
		/// </summary>
		public RefreshMaterializedViewsProcedure()
		{
		}

		/// <summary>
		/// Prepares, validates, and executes the function "transactions.refresh_materialized_views(_user_id integer, _login_id bigint, _office_id integer, _value_date date)" on the database.
		/// </summary>
		/// <param name="userId">Enter argument value for "_user_id" parameter of the function "transactions.refresh_materialized_views".</param>
		/// <param name="loginIdParameter">Enter argument value for "_login_id" parameter of the function "transactions.refresh_materialized_views".</param>
		/// <param name="officeId">Enter argument value for "_office_id" parameter of the function "transactions.refresh_materialized_views".</param>
		/// <param name="valueDate">Enter argument value for "_value_date" parameter of the function "transactions.refresh_materialized_views".</param>
		public RefreshMaterializedViewsProcedure(int userId,long loginIdParameter,int officeId,DateTime valueDate)
		{
			this.UserId = userId;
			this.LoginIdParameter = loginIdParameter;
			this.OfficeId = officeId;
			this.ValueDate = valueDate;
		}
		/// <summary>
		/// Prepares and executes the function "transactions.refresh_materialized_views".
		/// </summary>
		public void Execute()
		{
			if (!this.SkipValidation)
			{
				if (!this.Validated)
				{
					this.Validate(AccessTypeEnum.Execute, this.LoginId, false);
				}
				if (!this.HasAccess)
				{
                    Log.Information("Access to the function \"RefreshMaterializedViewsProcedure\" was denied to the user with Login ID {LoginId}.", this.LoginId);
					throw new UnauthorizedException("Access is denied.");
				}
			}
			const string query = "SELECT * FROM transactions.refresh_materialized_views(@0::integer, @1::bigint, @2::integer, @3::date);";
			Factory.NonQuery(this.Catalog, query, this.UserId, this.LoginIdParameter, this.OfficeId, this.ValueDate);
		} 
	}
}