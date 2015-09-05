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
using MixERP.Net.Entities.Policy;
using Npgsql;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
namespace MixERP.Net.Schemas.Policy.Data
{
	/// <summary>
	/// Prepares, validates, and executes the function "policy.change_password(_admin_user_id integer, _user_name text, _new_password text)" on the database.
	/// </summary>
	public class ChangePasswordProcedure: DbAccess
	{
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
	    public override string ObjectNamespace => "policy";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
	    public override string ObjectName => "change_password";
        /// <summary>
        /// Login id of application user accessing this PostgreSQL function.
        /// </summary>
		public long LoginId { get; set; }
        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Maps to "_admin_user_id" argument of the function "policy.change_password".
		/// </summary>
		public int AdminUserId { get; set; }
		/// <summary>
		/// Maps to "_user_name" argument of the function "policy.change_password".
		/// </summary>
		public string UserName { get; set; }
		/// <summary>
		/// Maps to "_new_password" argument of the function "policy.change_password".
		/// </summary>
		public string NewPassword { get; set; }

		/// <summary>
		/// Prepares, validates, and executes the function "policy.change_password(_admin_user_id integer, _user_name text, _new_password text)" on the database.
		/// </summary>
		public ChangePasswordProcedure()
		{
		}

		/// <summary>
		/// Prepares, validates, and executes the function "policy.change_password(_admin_user_id integer, _user_name text, _new_password text)" on the database.
		/// </summary>
		/// <param name="adminUserId">Enter argument value for "_admin_user_id" parameter of the function "policy.change_password".</param>
		/// <param name="userName">Enter argument value for "_user_name" parameter of the function "policy.change_password".</param>
		/// <param name="newPassword">Enter argument value for "_new_password" parameter of the function "policy.change_password".</param>
		public ChangePasswordProcedure(int adminUserId,string userName,string newPassword)
		{
			this.AdminUserId = adminUserId;
			this.UserName = userName;
			this.NewPassword = newPassword;
		}
		/// <summary>
		/// Prepares and executes the function "policy.change_password".
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
                    Log.Information("Access to the function \"ChangePasswordProcedure\" was denied to the user with Login ID {LoginId}.", this.LoginId);
					throw new UnauthorizedException("Access is denied.");
				}
			}
			const string query = "SELECT * FROM policy.change_password(@0::integer, @1::text, @2::text);";
			Factory.NonQuery(this.Catalog, query, this.AdminUserId, this.UserName, this.NewPassword);
		} 
	}
}