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
using MixERP.Net.Entities.Office;
using Npgsql;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
namespace MixERP.Net.Schemas.Office.Data
{
	/// <summary>
	/// Prepares, validates, and executes the function "office.validate_login(user_name text, password text, challenge text)" on the database.
	/// </summary>
	public class ValidateLoginProcedure: DbAccess
	{
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
	    public override string ObjectNamespace => "office";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
	    public override string ObjectName => "validate_login";
        /// <summary>
        /// Login id of application user accessing this PostgreSQL function.
        /// </summary>
		public long LoginId { get; set; }
        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Maps to "user_name" argument of the function "office.validate_login".
		/// </summary>
		public string UserName { get; set; }
		/// <summary>
		/// Maps to "password" argument of the function "office.validate_login".
		/// </summary>
		public string Password { get; set; }
		/// <summary>
		/// Maps to "challenge" argument of the function "office.validate_login".
		/// </summary>
		public string Challenge { get; set; }

		/// <summary>
		/// Prepares, validates, and executes the function "office.validate_login(user_name text, password text, challenge text)" on the database.
		/// </summary>
		public ValidateLoginProcedure()
		{
		}

		/// <summary>
		/// Prepares, validates, and executes the function "office.validate_login(user_name text, password text, challenge text)" on the database.
		/// </summary>
		/// <param name="userName">Enter argument value for "user_name" parameter of the function "office.validate_login".</param>
		/// <param name="password">Enter argument value for "password" parameter of the function "office.validate_login".</param>
		/// <param name="challenge">Enter argument value for "challenge" parameter of the function "office.validate_login".</param>
		public ValidateLoginProcedure(string userName,string password,string challenge)
		{
			this.UserName = userName;
			this.Password = password;
			this.Challenge = challenge;
		}
		/// <summary>
		/// Prepares and executes the function "office.validate_login".
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
				const string query = "SELECT * FROM office.validate_login(@0::text, @1::text, @2::text);";
				return Factory.Scalar<bool>(this.Catalog, query, this.UserName, this.Password, this.Challenge);
			}
			catch (UnauthorizedException ex)
			{
				Log.Error("{Exception} {@Exception}", ex.Message, ex);
                throw new MixERPException(ex.Message, ex);
			}
		} 
	}
}