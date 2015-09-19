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
    /// Prepares, validates, and executes the function "core.create_flag(user_id_ integer, flag_type_id_ integer, resource_ text, resource_key_ text, resource_id_ text)" on the database.
    /// </summary>
    public class CreateFlagProcedure : DbAccess
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string ObjectName => "create_flag";
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
        /// Maps to "user_id_" argument of the function "core.create_flag".
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Maps to "flag_type_id_" argument of the function "core.create_flag".
        /// </summary>
        public int FlagTypeId { get; set; }
        /// <summary>
        /// Maps to "resource_" argument of the function "core.create_flag".
        /// </summary>
        public string Resource { get; set; }
        /// <summary>
        /// Maps to "resource_key_" argument of the function "core.create_flag".
        /// </summary>
        public string ResourceKey { get; set; }
        /// <summary>
        /// Maps to "resource_id_" argument of the function "core.create_flag".
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.create_flag(user_id_ integer, flag_type_id_ integer, resource_ text, resource_key_ text, resource_id_ text)" on the database.
        /// </summary>
        public CreateFlagProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.create_flag(user_id_ integer, flag_type_id_ integer, resource_ text, resource_key_ text, resource_id_ text)" on the database.
        /// </summary>
        /// <param name="userId">Enter argument value for "user_id_" parameter of the function "core.create_flag".</param>
        /// <param name="flagTypeId">Enter argument value for "flag_type_id_" parameter of the function "core.create_flag".</param>
        /// <param name="resource">Enter argument value for "resource_" parameter of the function "core.create_flag".</param>
        /// <param name="resourceKey">Enter argument value for "resource_key_" parameter of the function "core.create_flag".</param>
        /// <param name="resourceId">Enter argument value for "resource_id_" parameter of the function "core.create_flag".</param>
        public CreateFlagProcedure(int userId, int flagTypeId, string resource, string resourceKey, string resourceId)
        {
            this.UserId = userId;
            this.FlagTypeId = flagTypeId;
            this.Resource = resource;
            this.ResourceKey = resourceKey;
            this.ResourceId = resourceId;
        }
        /// <summary>
        /// Prepares and executes the function "core.create_flag".
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
                    Log.Information("Access to the function \"CreateFlagProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            const string query = "SELECT * FROM core.create_flag(@0::integer, @1::integer, @2::text, @3::text, @4::text);";
            Factory.NonQuery(this.Catalog, query, this.UserId, this.FlagTypeId, this.Resource, this.ResourceKey, this.ResourceId);
        }
    }
}