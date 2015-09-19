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
    /// Prepares, validates, and executes the function "core.is_parent_account(parent bigint, child bigint)" on the database.
    /// </summary>
    public class IsParentAccountProcedure : DbAccess
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string ObjectName => "is_parent_account";
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
        /// Maps to "parent" argument of the function "core.is_parent_account".
        /// </summary>
        public long Parent { get; set; }
        /// <summary>
        /// Maps to "child" argument of the function "core.is_parent_account".
        /// </summary>
        public long Child { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.is_parent_account(parent bigint, child bigint)" on the database.
        /// </summary>
        public IsParentAccountProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.is_parent_account(parent bigint, child bigint)" on the database.
        /// </summary>
        /// <param name="parent">Enter argument value for "parent" parameter of the function "core.is_parent_account".</param>
        /// <param name="child">Enter argument value for "child" parameter of the function "core.is_parent_account".</param>
        public IsParentAccountProcedure(long parent, long child)
        {
            this.Parent = parent;
            this.Child = child;
        }
        /// <summary>
        /// Prepares and executes the function "core.is_parent_account".
        /// </summary>
        public bool Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"IsParentAccountProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            const string query = "SELECT * FROM core.is_parent_account(@0::bigint, @1::bigint);";
            return Factory.Scalar<bool>(this.Catalog, query, this.Parent, this.Child);
        }
    }
}