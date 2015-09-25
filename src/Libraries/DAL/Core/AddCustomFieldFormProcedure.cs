// ReSharper disable All
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
    /// Prepares, validates, and executes the function "core.add_custom_field_form(_form_name character varying, _table_name character varying, _key_name character varying)" on the database.
    /// </summary>
    public class AddCustomFieldFormProcedure : DbAccess
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "add_custom_field_form";
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
        public string _Catalog { get; set; }

        /// <summary>
        /// Maps to "_form_name" argument of the function "core.add_custom_field_form".
        /// </summary>
        public string FormName { get; set; }
        /// <summary>
        /// Maps to "_table_name" argument of the function "core.add_custom_field_form".
        /// </summary>
        public string TableName { get; set; }
        /// <summary>
        /// Maps to "_key_name" argument of the function "core.add_custom_field_form".
        /// </summary>
        public string KeyName { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.add_custom_field_form(_form_name character varying, _table_name character varying, _key_name character varying)" on the database.
        /// </summary>
        public AddCustomFieldFormProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.add_custom_field_form(_form_name character varying, _table_name character varying, _key_name character varying)" on the database.
        /// </summary>
        /// <param name="formName">Enter argument value for "_form_name" parameter of the function "core.add_custom_field_form".</param>
        /// <param name="tableName">Enter argument value for "_table_name" parameter of the function "core.add_custom_field_form".</param>
        /// <param name="keyName">Enter argument value for "_key_name" parameter of the function "core.add_custom_field_form".</param>
        public AddCustomFieldFormProcedure(string formName, string tableName, string keyName)
        {
            this.FormName = formName;
            this.TableName = tableName;
            this.KeyName = keyName;
        }
        /// <summary>
        /// Prepares and executes the function "core.add_custom_field_form".
        /// </summary>
        public void Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"AddCustomFieldFormProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            const string query = "SELECT * FROM core.add_custom_field_form(@0::character varying, @1::character varying, @2::character varying);";
            Factory.NonQuery(this._Catalog, query, this.FormName, this.TableName, this.KeyName);
        }
    }
}