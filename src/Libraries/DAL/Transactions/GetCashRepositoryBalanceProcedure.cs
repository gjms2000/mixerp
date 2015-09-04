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
	/// Prepares, validates, and executes the function "transactions.get_cash_repository_balance(_cash_repository_id integer, _currency_code character varying)" on the database.
	/// </summary>
	public class GetCashRepositoryBalanceProcedure: DbAccess
	{
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
	    public override string ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
	    public override string ObjectName => "get_cash_repository_balance";
        /// <summary>
        /// Login id of application user accessing this PostgreSQL function.
        /// </summary>
		public long LoginId { get; set; }
        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Maps to "_cash_repository_id" argument of the function "transactions.get_cash_repository_balance".
		/// </summary>
		public int CashRepositoryId { get; set; }
		/// <summary>
		/// Maps to "_currency_code" argument of the function "transactions.get_cash_repository_balance".
		/// </summary>
		public string CurrencyCode { get; set; }

		/// <summary>
		/// Prepares, validates, and executes the function "transactions.get_cash_repository_balance(_cash_repository_id integer, _currency_code character varying)" on the database.
		/// </summary>
		public GetCashRepositoryBalanceProcedure()
		{
		}

		/// <summary>
		/// Prepares, validates, and executes the function "transactions.get_cash_repository_balance(_cash_repository_id integer, _currency_code character varying)" on the database.
		/// </summary>
		/// <param name="cashRepositoryId">Enter argument value for "_cash_repository_id" parameter of the function "transactions.get_cash_repository_balance".</param>
		/// <param name="currencyCode">Enter argument value for "_currency_code" parameter of the function "transactions.get_cash_repository_balance".</param>
		public GetCashRepositoryBalanceProcedure(int cashRepositoryId,string currencyCode)
		{
			this.CashRepositoryId = cashRepositoryId;
			this.CurrencyCode = currencyCode;
		}
		/// <summary>
		/// Prepares and executes the function "transactions.get_cash_repository_balance".
		/// </summary>
		public decimal Execute()
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
				const string query = "SELECT * FROM transactions.get_cash_repository_balance(@0::integer, @1::character varying);";
				return Factory.Get<decimal>(this.Catalog, query, this.CashRepositoryId, this.CurrencyCode).FirstOrDefault();
			}
			catch (UnauthorizedException ex)
			{
				Log.Error("{Exception} {@Exception}", ex.Message, ex);
                throw new MixERPException(ex.Message, ex);
			}
		} 
	}
}