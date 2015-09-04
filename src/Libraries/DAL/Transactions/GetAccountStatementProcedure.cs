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
	/// Prepares, validates, and executes the function "transactions.get_account_statement(_value_date_from date, _value_date_to date, _user_id integer, _account_id bigint, _office_id integer)" on the database.
	/// </summary>
	public class GetAccountStatementProcedure: DbAccess
	{
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
	    public override string ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
	    public override string ObjectName => "get_account_statement";
        /// <summary>
        /// Login id of application user accessing this PostgreSQL function.
        /// </summary>
		public long LoginId { get; set; }
        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Maps to "_value_date_from" argument of the function "transactions.get_account_statement".
		/// </summary>
		public DateTime ValueDateFrom { get; set; }
		/// <summary>
		/// Maps to "_value_date_to" argument of the function "transactions.get_account_statement".
		/// </summary>
		public DateTime ValueDateTo { get; set; }
		/// <summary>
		/// Maps to "_user_id" argument of the function "transactions.get_account_statement".
		/// </summary>
		public int UserId { get; set; }
		/// <summary>
		/// Maps to "_account_id" argument of the function "transactions.get_account_statement".
		/// </summary>
		public long AccountId { get; set; }
		/// <summary>
		/// Maps to "_office_id" argument of the function "transactions.get_account_statement".
		/// </summary>
		public int OfficeId { get; set; }

		/// <summary>
		/// Prepares, validates, and executes the function "transactions.get_account_statement(_value_date_from date, _value_date_to date, _user_id integer, _account_id bigint, _office_id integer)" on the database.
		/// </summary>
		public GetAccountStatementProcedure()
		{
		}

		/// <summary>
		/// Prepares, validates, and executes the function "transactions.get_account_statement(_value_date_from date, _value_date_to date, _user_id integer, _account_id bigint, _office_id integer)" on the database.
		/// </summary>
		/// <param name="valueDateFrom">Enter argument value for "_value_date_from" parameter of the function "transactions.get_account_statement".</param>
		/// <param name="valueDateTo">Enter argument value for "_value_date_to" parameter of the function "transactions.get_account_statement".</param>
		/// <param name="userId">Enter argument value for "_user_id" parameter of the function "transactions.get_account_statement".</param>
		/// <param name="accountId">Enter argument value for "_account_id" parameter of the function "transactions.get_account_statement".</param>
		/// <param name="officeId">Enter argument value for "_office_id" parameter of the function "transactions.get_account_statement".</param>
		public GetAccountStatementProcedure(DateTime valueDateFrom,DateTime valueDateTo,int userId,long accountId,int officeId)
		{
			this.ValueDateFrom = valueDateFrom;
			this.ValueDateTo = valueDateTo;
			this.UserId = userId;
			this.AccountId = accountId;
			this.OfficeId = officeId;
		}
		/// <summary>
		/// Prepares and executes the function "transactions.get_account_statement".
		/// </summary>
		public IEnumerable<DbGetAccountStatementResult> Execute()
		{
			try
			{
				if (!this.SkipValidation)
				{
					if (!this.Validated)
					{
						this.Validate(AccessTypeEnum.Execute, this.LoginId, false);
					}
					if (!this.HasAccess)
					{
						throw new UnauthorizedException("Access is denied.");
					}
				}
				const string query = "SELECT * FROM transactions.get_account_statement(@0::date, @1::date, @2::integer, @3::bigint, @4::integer);";
				return Factory.Get<DbGetAccountStatementResult>(this.Catalog, query, this.ValueDateFrom, this.ValueDateTo, this.UserId, this.AccountId, this.OfficeId);
			}
			catch (UnauthorizedException ex)
			{
				Log.Error("{Exception} {@Exception}", ex.Message, ex);
                throw new MixERPException(ex.Message, ex);
			}
		} 
	}
}