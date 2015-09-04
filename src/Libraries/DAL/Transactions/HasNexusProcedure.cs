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
	/// Prepares, validates, and executes the function "transactions.has_nexus(_state_id integer)" on the database.
	/// </summary>
	public class HasNexusProcedure: DbAccess
	{
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
	    public override string ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
	    public override string ObjectName => "has_nexus";
        /// <summary>
        /// Login id of application user accessing this PostgreSQL function.
        /// </summary>
		public long LoginId { get; set; }
        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Maps to "_state_id" argument of the function "transactions.has_nexus".
		/// </summary>
		public int StateId { get; set; }

		/// <summary>
		/// Prepares, validates, and executes the function "transactions.has_nexus(_state_id integer)" on the database.
		/// </summary>
		public HasNexusProcedure()
		{
		}

		/// <summary>
		/// Prepares, validates, and executes the function "transactions.has_nexus(_state_id integer)" on the database.
		/// </summary>
		/// <param name="stateId">Enter argument value for "_state_id" parameter of the function "transactions.has_nexus".</param>
		public HasNexusProcedure(int stateId)
		{
			this.StateId = stateId;
		}
		/// <summary>
		/// Prepares and executes the function "transactions.has_nexus".
		/// </summary>
		public bool Execute()
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
				const string query = "SELECT * FROM transactions.has_nexus(@0::integer);";
				return Factory.Scalar<bool>(this.Catalog, query, this.StateId);
			}
			catch (UnauthorizedException ex)
			{
				Log.Error("{Exception} {@Exception}", ex.Message, ex);
                throw new MixERPException(ex.Message, ex);
			}
		} 
	}
}