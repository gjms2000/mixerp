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
using MixERP.Net.Entities.Policy;
using Npgsql;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
namespace MixERP.Net.Schemas.Policy.Data
{
    /// <summary>
    /// Prepares, validates, and executes the function "policy.save_menu_policy(_user_id integer, _office_id integer, _menu_ids integer[])" on the database.
    /// </summary>
    public class SaveMenuPolicyProcedure : DbAccess
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string ObjectNamespace => "policy";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string ObjectName => "save_menu_policy";
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
        /// Maps to "_user_id" argument of the function "policy.save_menu_policy".
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Maps to "_office_id" argument of the function "policy.save_menu_policy".
        /// </summary>
        public int OfficeId { get; set; }
        /// <summary>
        /// Maps to "_menu_ids" argument of the function "policy.save_menu_policy".
        /// </summary>
        public int[] MenuIds { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "policy.save_menu_policy(_user_id integer, _office_id integer, _menu_ids integer[])" on the database.
        /// </summary>
        public SaveMenuPolicyProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "policy.save_menu_policy(_user_id integer, _office_id integer, _menu_ids integer[])" on the database.
        /// </summary>
        /// <param name="userId">Enter argument value for "_user_id" parameter of the function "policy.save_menu_policy".</param>
        /// <param name="officeId">Enter argument value for "_office_id" parameter of the function "policy.save_menu_policy".</param>
        /// <param name="menuIds">Enter argument value for "_menu_ids" parameter of the function "policy.save_menu_policy".</param>
        public SaveMenuPolicyProcedure(int userId, int officeId, int[] menuIds)
        {
            this.UserId = userId;
            this.OfficeId = officeId;
            this.MenuIds = menuIds;
        }
        /// <summary>
        /// Prepares and executes the function "policy.save_menu_policy".
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
                    Log.Information("Access to the function \"SaveMenuPolicyProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            const string query = "SELECT * FROM policy.save_menu_policy(@0::integer, @1::integer, @2::integer[]);";
            Factory.NonQuery(this.Catalog, query, this.UserId, this.OfficeId, this.MenuIds);
        }
    }
}