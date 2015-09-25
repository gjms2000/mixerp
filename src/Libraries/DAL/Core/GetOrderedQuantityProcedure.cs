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
    /// Prepares, validates, and executes the function "core.get_ordered_quantity(_item_id integer, _unit_id integer, _office_id integer)" on the database.
    /// </summary>
    public class GetOrderedQuantityProcedure : DbAccess
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_ordered_quantity";
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
        /// Maps to "_item_id" argument of the function "core.get_ordered_quantity".
        /// </summary>
        public int ItemId { get; set; }
        /// <summary>
        /// Maps to "_unit_id" argument of the function "core.get_ordered_quantity".
        /// </summary>
        public int UnitId { get; set; }
        /// <summary>
        /// Maps to "_office_id" argument of the function "core.get_ordered_quantity".
        /// </summary>
        public int OfficeId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_ordered_quantity(_item_id integer, _unit_id integer, _office_id integer)" on the database.
        /// </summary>
        public GetOrderedQuantityProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_ordered_quantity(_item_id integer, _unit_id integer, _office_id integer)" on the database.
        /// </summary>
        /// <param name="itemId">Enter argument value for "_item_id" parameter of the function "core.get_ordered_quantity".</param>
        /// <param name="unitId">Enter argument value for "_unit_id" parameter of the function "core.get_ordered_quantity".</param>
        /// <param name="officeId">Enter argument value for "_office_id" parameter of the function "core.get_ordered_quantity".</param>
        public GetOrderedQuantityProcedure(int itemId, int unitId, int officeId)
        {
            this.ItemId = itemId;
            this.UnitId = unitId;
            this.OfficeId = officeId;
        }
        /// <summary>
        /// Prepares and executes the function "core.get_ordered_quantity".
        /// </summary>
        public decimal Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"GetOrderedQuantityProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            const string query = "SELECT * FROM core.get_ordered_quantity(@0::integer, @1::integer, @2::integer);";
            return Factory.Scalar<decimal>(this._Catalog, query, this.ItemId, this.UnitId, this.OfficeId);
        }
    }
}