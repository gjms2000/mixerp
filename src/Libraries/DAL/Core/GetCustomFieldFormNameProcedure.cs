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
	/// Prepares, validates, and executes the function "core.get_custom_field_form_name(_schema_name character varying, _table_name character varying)" on the database.
	/// </summary>
	public class GetCustomFieldFormNameProcedure: DbAccess
	{
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
	    public override string ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
	    public override string ObjectName => "get_custom_field_form_name";
        /// <summary>
        /// Login id of application user accessing this PostgreSQL function.
        /// </summary>
		public long LoginId { get; set; }
        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Maps to "_schema_name" argument of the function "core.get_custom_field_form_name".
		/// </summary>
		public string SchemaName { get; set; }
		/// <summary>
		/// Maps to "_table_name" argument of the function "core.get_custom_field_form_name".
		/// </summary>
		public string TableName { get; set; }

		/// <summary>
		/// Prepares, validates, and executes the function "core.get_custom_field_form_name(_schema_name character varying, _table_name character varying)" on the database.
		/// </summary>
		public GetCustomFieldFormNameProcedure()
		{
		}

		/// <summary>
		/// Prepares, validates, and executes the function "core.get_custom_field_form_name(_schema_name character varying, _table_name character varying)" on the database.
		/// </summary>
		/// <param name="schemaName">Enter argument value for "_schema_name" parameter of the function "core.get_custom_field_form_name".</param>
		/// <param name="tableName">Enter argument value for "_table_name" parameter of the function "core.get_custom_field_form_name".</param>
		public GetCustomFieldFormNameProcedure(string schemaName,string tableName)
		{
			this.SchemaName = schemaName;
			this.TableName = tableName;
		}
		/// <summary>
		/// Prepares and executes the function "core.get_custom_field_form_name".
		/// </summary>
		public string Execute()
		{
			if (!this.SkipValidation)
			{
				if (!this.Validated)
				{
					this.Validate(AccessTypeEnum.Execute, this.LoginId, false);
				}
				if (!this.HasAccess)
				{
                    Log.Information("Access to the function \"GetCustomFieldFormNameProcedure\" was denied to the user with Login ID {LoginId}.", this.LoginId);
					throw new UnauthorizedException("Access is denied.");
				}
			}
			const string query = "SELECT * FROM core.get_custom_field_form_name(@0::character varying, @1::character varying);";
			return Factory.Scalar<string>(this.Catalog, query, this.SchemaName, this.TableName);
		} 
	}
}