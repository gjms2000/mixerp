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
	/// Prepares, validates, and executes the function "transactions.get_due_date(_value_date date, _payment_term_id integer)" on the database.
	/// </summary>
	public class GetDueDateProcedure: DbAccess
	{
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
	    public override string ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
	    public override string ObjectName => "get_due_date";
        /// <summary>
        /// Login id of application user accessing this PostgreSQL function.
        /// </summary>
		public long LoginId { get; set; }
        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Maps to "_value_date" argument of the function "transactions.get_due_date".
		/// </summary>
		public DateTime ValueDate { get; set; }
		/// <summary>
		/// Maps to "_payment_term_id" argument of the function "transactions.get_due_date".
		/// </summary>
		public int PaymentTermId { get; set; }

		/// <summary>
		/// Prepares, validates, and executes the function "transactions.get_due_date(_value_date date, _payment_term_id integer)" on the database.
		/// </summary>
		public GetDueDateProcedure()
		{
		}

		/// <summary>
		/// Prepares, validates, and executes the function "transactions.get_due_date(_value_date date, _payment_term_id integer)" on the database.
		/// </summary>
		/// <param name="valueDate">Enter argument value for "_value_date" parameter of the function "transactions.get_due_date".</param>
		/// <param name="paymentTermId">Enter argument value for "_payment_term_id" parameter of the function "transactions.get_due_date".</param>
		public GetDueDateProcedure(DateTime valueDate,int paymentTermId)
		{
			this.ValueDate = valueDate;
			this.PaymentTermId = paymentTermId;
		}
		/// <summary>
		/// Prepares and executes the function "transactions.get_due_date".
		/// </summary>
		public DateTime Execute()
		{
			if (!this.SkipValidation)
			{
				if (!this.Validated)
				{
					this.Validate(AccessTypeEnum.Execute, this.LoginId, false);
				}
				if (!this.HasAccess)
				{
                    Log.Information("Access to the function \"GetDueDateProcedure\" was denied to the user with Login ID {LoginId}.", this.LoginId);
					throw new UnauthorizedException("Access is denied.");
				}
			}
			const string query = "SELECT * FROM transactions.get_due_date(@0::date, @1::integer);";
			return Factory.Scalar<DateTime>(this.Catalog, query, this.ValueDate, this.PaymentTermId);
		} 
	}
}