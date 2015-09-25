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
    /// Prepares, validates, and executes the function "core.get_account_id_by_shipper_id(_shipper_id integer)" on the database.
    /// </summary>
    public class GetAccountIdByShipperIdProcedure : DbAccess
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_account_id_by_shipper_id";
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
        /// Maps to "_shipper_id" argument of the function "core.get_account_id_by_shipper_id".
        /// </summary>
        public int ShipperId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_account_id_by_shipper_id(_shipper_id integer)" on the database.
        /// </summary>
        public GetAccountIdByShipperIdProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_account_id_by_shipper_id(_shipper_id integer)" on the database.
        /// </summary>
        /// <param name="shipperId">Enter argument value for "_shipper_id" parameter of the function "core.get_account_id_by_shipper_id".</param>
        public GetAccountIdByShipperIdProcedure(int shipperId)
        {
            this.ShipperId = shipperId;
        }
        /// <summary>
        /// Prepares and executes the function "core.get_account_id_by_shipper_id".
        /// </summary>
        public long Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"GetAccountIdByShipperIdProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            const string query = "SELECT * FROM core.get_account_id_by_shipper_id(@0::integer);";
            return Factory.Scalar<long>(this._Catalog, query, this.ShipperId);
        }
    }
}