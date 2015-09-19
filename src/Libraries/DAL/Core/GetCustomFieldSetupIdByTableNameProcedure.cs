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
    /// Prepares, validates, and executes the function "core.get_custom_field_setup_id_by_table_name(_table_name character varying, _field_name character varying)" on the database.
    /// </summary>
    public class GetCustomFieldSetupIdByTableNameProcedure : DbAccess
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string ObjectName => "get_custom_field_setup_id_by_table_name";
        /// <summary>
        /// Login id of application user accessing this PostgreSQL function.
        /// </summary>
        public long _LoginId { get; set; }
        /// <summary>
        /// User id of application user accessing this table.
        /// </summary>
        public int _UserId { get; set; }
        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

        /// <summary>
        /// Maps to "_table_name" argument of the function "core.get_custom_field_setup_id_by_table_name".
        /// </summary>
        public string TableName { get; set; }
        /// <summary>
        /// Maps to "_field_name" argument of the function "core.get_custom_field_setup_id_by_table_name".
        /// </summary>
        public string FieldName { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_custom_field_setup_id_by_table_name(_table_name character varying, _field_name character varying)" on the database.
        /// </summary>
        public GetCustomFieldSetupIdByTableNameProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_custom_field_setup_id_by_table_name(_table_name character varying, _field_name character varying)" on the database.
        /// </summary>
        /// <param name="tableName">Enter argument value for "_table_name" parameter of the function "core.get_custom_field_setup_id_by_table_name".</param>
        /// <param name="fieldName">Enter argument value for "_field_name" parameter of the function "core.get_custom_field_setup_id_by_table_name".</param>
        public GetCustomFieldSetupIdByTableNameProcedure(string tableName, string fieldName)
        {
            this.TableName = tableName;
            this.FieldName = fieldName;
        }
        /// <summary>
        /// Prepares and executes the function "core.get_custom_field_setup_id_by_table_name".
        /// </summary>
        public int Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"GetCustomFieldSetupIdByTableNameProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            const string query = "SELECT * FROM core.get_custom_field_setup_id_by_table_name(@0::character varying, @1::character varying);";
            return Factory.Scalar<int>(this.Catalog, query, this.TableName, this.FieldName);
        }
    }
}