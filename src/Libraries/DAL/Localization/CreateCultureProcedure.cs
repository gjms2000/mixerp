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
using MixERP.Net.Entities.Localization;
using Npgsql;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
namespace MixERP.Net.Schemas.Localization.Data
{
	/// <summary>
	/// Prepares, validates, and executes the function "localization.create_culture(_culture_code text, _culture_name text)" on the database.
	/// </summary>
	public class CreateCultureProcedure: DbAccess
	{
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
	    public override string ObjectNamespace => "localization";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
	    public override string ObjectName => "create_culture";
        /// <summary>
        /// Login id of application user accessing this PostgreSQL function.
        /// </summary>
		public long LoginId { get; set; }
        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Maps to "_culture_code" argument of the function "localization.create_culture".
		/// </summary>
		public string CultureCode { get; set; }
		/// <summary>
		/// Maps to "_culture_name" argument of the function "localization.create_culture".
		/// </summary>
		public string CultureName { get; set; }

		/// <summary>
		/// Prepares, validates, and executes the function "localization.create_culture(_culture_code text, _culture_name text)" on the database.
		/// </summary>
		public CreateCultureProcedure()
		{
		}

		/// <summary>
		/// Prepares, validates, and executes the function "localization.create_culture(_culture_code text, _culture_name text)" on the database.
		/// </summary>
		/// <param name="cultureCode">Enter argument value for "_culture_code" parameter of the function "localization.create_culture".</param>
		/// <param name="cultureName">Enter argument value for "_culture_name" parameter of the function "localization.create_culture".</param>
		public CreateCultureProcedure(string cultureCode,string cultureName)
		{
			this.CultureCode = cultureCode;
			this.CultureName = cultureName;
		}
		/// <summary>
		/// Prepares and executes the function "localization.create_culture".
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
                    Log.Information("Access to the function \"CreateCultureProcedure\" was denied to the user with Login ID {LoginId}.", this.LoginId);
					throw new UnauthorizedException("Access is denied.");
				}
			}
			const string query = "SELECT * FROM localization.create_culture(@0::text, @1::text);";
			Factory.NonQuery(this.Catalog, query, this.CultureCode, this.CultureName);
		} 
	}
}