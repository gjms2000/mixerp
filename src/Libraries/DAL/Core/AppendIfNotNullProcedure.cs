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
    /// Prepares, validates, and executes the function "core.append_if_not_null(_source text, _to_append text)" on the database.
    /// </summary>
    public class AppendIfNotNullProcedure : DbAccess
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "append_if_not_null";
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
        /// Maps to "_source" argument of the function "core.append_if_not_null".
        /// </summary>
        public string Source { get; set; }
        /// <summary>
        /// Maps to "_to_append" argument of the function "core.append_if_not_null".
        /// </summary>
        public string ToAppend { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.append_if_not_null(_source text, _to_append text)" on the database.
        /// </summary>
        public AppendIfNotNullProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.append_if_not_null(_source text, _to_append text)" on the database.
        /// </summary>
        /// <param name="source">Enter argument value for "_source" parameter of the function "core.append_if_not_null".</param>
        /// <param name="toAppend">Enter argument value for "_to_append" parameter of the function "core.append_if_not_null".</param>
        public AppendIfNotNullProcedure(string source, string toAppend)
        {
            this.Source = source;
            this.ToAppend = toAppend;
        }
        /// <summary>
        /// Prepares and executes the function "core.append_if_not_null".
        /// </summary>
        public string Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"AppendIfNotNullProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            const string query = "SELECT * FROM core.append_if_not_null(@0::text, @1::text);";
            return Factory.Scalar<string>(this._Catalog, query, this.Source, this.ToAppend);
        }
    }
}