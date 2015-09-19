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
    /// Prepares, validates, and executes the function "localization.add_resource(resource_class text, key text, value text)" on the database.
    /// </summary>
    public class AddResourceProcedure : DbAccess
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string ObjectNamespace => "localization";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string ObjectName => "add_resource";
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
        /// Maps to "resource_class" argument of the function "localization.add_resource".
        /// </summary>
        public string ResourceClass { get; set; }
        /// <summary>
        /// Maps to "key" argument of the function "localization.add_resource".
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// Maps to "value" argument of the function "localization.add_resource".
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "localization.add_resource(resource_class text, key text, value text)" on the database.
        /// </summary>
        public AddResourceProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "localization.add_resource(resource_class text, key text, value text)" on the database.
        /// </summary>
        /// <param name="resourceClass">Enter argument value for "resource_class" parameter of the function "localization.add_resource".</param>
        /// <param name="key">Enter argument value for "key" parameter of the function "localization.add_resource".</param>
        /// <param name="value">Enter argument value for "value" parameter of the function "localization.add_resource".</param>
        public AddResourceProcedure(string resourceClass, string key, string value)
        {
            this.ResourceClass = resourceClass;
            this.Key = key;
            this.Value = value;
        }
        /// <summary>
        /// Prepares and executes the function "localization.add_resource".
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
                    Log.Information("Access to the function \"AddResourceProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            const string query = "SELECT * FROM localization.add_resource(@0::text, @1::text, @2::text);";
            Factory.NonQuery(this.Catalog, query, this.ResourceClass, this.Key, this.Value);
        }
    }
}