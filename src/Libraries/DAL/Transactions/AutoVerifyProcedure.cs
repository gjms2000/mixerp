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
	/// Prepares, validates, and executes the function "transactions.auto_verify(_tran_id bigint, _office_id integer)" on the database.
	/// </summary>
	public class AutoVerifyProcedure: DbAccess
	{
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
	    public override string ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
	    public override string ObjectName => "auto_verify";
        /// <summary>
        /// Login id of application user accessing this PostgreSQL function.
        /// </summary>
		public long LoginId { get; set; }
        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Maps to "_tran_id" argument of the function "transactions.auto_verify".
		/// </summary>
		public long TranId { get; set; }
		/// <summary>
		/// Maps to "_office_id" argument of the function "transactions.auto_verify".
		/// </summary>
		public int OfficeId { get; set; }

		/// <summary>
		/// Prepares, validates, and executes the function "transactions.auto_verify(_tran_id bigint, _office_id integer)" on the database.
		/// </summary>
		public AutoVerifyProcedure()
		{
		}

		/// <summary>
		/// Prepares, validates, and executes the function "transactions.auto_verify(_tran_id bigint, _office_id integer)" on the database.
		/// </summary>
		/// <param name="tranId">Enter argument value for "_tran_id" parameter of the function "transactions.auto_verify".</param>
		/// <param name="officeId">Enter argument value for "_office_id" parameter of the function "transactions.auto_verify".</param>
		public AutoVerifyProcedure(long tranId,int officeId)
		{
			this.TranId = tranId;
			this.OfficeId = officeId;
		}
		/// <summary>
		/// Prepares and executes the function "transactions.auto_verify".
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
                    Log.Information("Access to the function \"AutoVerifyProcedure\" was denied to the user with Login ID {LoginId}.", this.LoginId);
					throw new UnauthorizedException("Access is denied.");
				}
			}
			const string query = "SELECT * FROM transactions.auto_verify(@0::bigint, @1::integer);";
			Factory.NonQuery(this.Catalog, query, this.TranId, this.OfficeId);
		} 
	}
}