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
    /// Prepares, validates, and executes the function "core.get_party_code(pg_arg0 text, pg_arg1 text, pg_arg2 text)" on the database.
    /// </summary>
    public class GetPartyCodeProcedure : DbAccess
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_party_code";
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
        /// Maps to "pg_arg0" argument of the function "core.get_party_code".
        /// </summary>
        public string PgArg0 { get; set; }
        /// <summary>
        /// Maps to "pg_arg1" argument of the function "core.get_party_code".
        /// </summary>
        public string PgArg1 { get; set; }
        /// <summary>
        /// Maps to "pg_arg2" argument of the function "core.get_party_code".
        /// </summary>
        public string PgArg2 { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_party_code(pg_arg0 text, pg_arg1 text, pg_arg2 text)" on the database.
        /// </summary>
        public GetPartyCodeProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_party_code(pg_arg0 text, pg_arg1 text, pg_arg2 text)" on the database.
        /// </summary>
        /// <param name="pgArg0">Enter argument value for "pg_arg0" parameter of the function "core.get_party_code".</param>
        /// <param name="pgArg1">Enter argument value for "pg_arg1" parameter of the function "core.get_party_code".</param>
        /// <param name="pgArg2">Enter argument value for "pg_arg2" parameter of the function "core.get_party_code".</param>
        public GetPartyCodeProcedure(string pgArg0, string pgArg1, string pgArg2)
        {
            this.PgArg0 = pgArg0;
            this.PgArg1 = pgArg1;
            this.PgArg2 = pgArg2;
        }
        /// <summary>
        /// Prepares and executes the function "core.get_party_code".
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
                    Log.Information("Access to the function \"GetPartyCodeProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            const string query = "SELECT * FROM core.get_party_code(@0::text, @1::text, @2::text);";
            return Factory.Scalar<string>(this._Catalog, query, this.PgArg0, this.PgArg1, this.PgArg2);
        }
    }
}