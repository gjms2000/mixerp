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
using MixERP.Net.Entities.Transactions;
using Npgsql;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
namespace MixERP.Net.Schemas.Transactions.Data
{
    /// <summary>
    /// Prepares, validates, and executes the function "transactions.contains_incompatible_taxes(arr bigint[])" on the database.
    /// </summary>
    public class ContainsIncompatibleTaxesProcedure : DbAccess
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "contains_incompatible_taxes";
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
        /// Maps to "arr" argument of the function "transactions.contains_incompatible_taxes".
        /// </summary>
        public long[] Arr { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.contains_incompatible_taxes(arr bigint[])" on the database.
        /// </summary>
        public ContainsIncompatibleTaxesProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.contains_incompatible_taxes(arr bigint[])" on the database.
        /// </summary>
        /// <param name="arr">Enter argument value for "arr" parameter of the function "transactions.contains_incompatible_taxes".</param>
        public ContainsIncompatibleTaxesProcedure(long[] arr)
        {
            this.Arr = arr;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.contains_incompatible_taxes".
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
                    Log.Information("Access to the function \"ContainsIncompatibleTaxesProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            const string query = "SELECT * FROM transactions.contains_incompatible_taxes(@0::bigint[]);";
            return Factory.Scalar<bool>(this._Catalog, query, this.Arr);
        }
    }
}