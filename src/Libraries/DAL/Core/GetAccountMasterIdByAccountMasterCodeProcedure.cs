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
using MixERP.Net.Entities.Core;
using Npgsql;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
namespace MixERP.Net.Schemas.Core.Data
{
	/// <summary>
	/// Prepares, validates, and executes the function "core.get_account_master_id_by_account_master_code(_account_master_code text)" on the database.
	/// </summary>
	public class GetAccountMasterIdByAccountMasterCodeProcedure: DbAccess
	{
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
	    public override string ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
	    public override string ObjectName => "get_account_master_id_by_account_master_code";
        /// <summary>
        /// Login id of application user accessing this PostgreSQL function.
        /// </summary>
		public long LoginId { get; set; }
        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Maps to "_account_master_code" argument of the function "core.get_account_master_id_by_account_master_code".
		/// </summary>
		public string AccountMasterCode { get; set; }

		/// <summary>
		/// Prepares, validates, and executes the function "core.get_account_master_id_by_account_master_code(_account_master_code text)" on the database.
		/// </summary>
		public GetAccountMasterIdByAccountMasterCodeProcedure()
		{
		}

		/// <summary>
		/// Prepares, validates, and executes the function "core.get_account_master_id_by_account_master_code(_account_master_code text)" on the database.
		/// </summary>
		/// <param name="accountMasterCode">Enter argument value for "_account_master_code" parameter of the function "core.get_account_master_id_by_account_master_code".</param>
		public GetAccountMasterIdByAccountMasterCodeProcedure(string accountMasterCode)
		{
			this.AccountMasterCode = accountMasterCode;
		}
		/// <summary>
		/// Prepares and executes the function "core.get_account_master_id_by_account_master_code".
		/// </summary>
		public int Execute()
		{
			if (!this.SkipValidation)
			{
				if (!this.Validated)
				{
					this.Validate(AccessTypeEnum.Execute, this.LoginId, false);
				}
				if (!this.HasAccess)
				{
                    Log.Information("Access to the function \"GetAccountMasterIdByAccountMasterCodeProcedure\" was denied to the user with Login ID {LoginId}.", this.LoginId);
					throw new UnauthorizedException("Access is denied.");
				}
			}
			const string query = "SELECT * FROM core.get_account_master_id_by_account_master_code(@0::text);";
			return Factory.Scalar<int>(this.Catalog, query, this.AccountMasterCode);
		} 
	}
}