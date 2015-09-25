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
    /// Prepares, validates, and executes the function "core.create_menu(_menu_text text, _url text, _menu_code text, _level integer, _parent_menu_id integer)" on the database.
    /// </summary>
    public class CreateMenuProcedure : DbAccess
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "create_menu";
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
        /// Maps to "_menu_text" argument of the function "core.create_menu".
        /// </summary>
        public string MenuText { get; set; }
        /// <summary>
        /// Maps to "_url" argument of the function "core.create_menu".
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// Maps to "_menu_code" argument of the function "core.create_menu".
        /// </summary>
        public string MenuCode { get; set; }
        /// <summary>
        /// Maps to "_level" argument of the function "core.create_menu".
        /// </summary>
        public int Level { get; set; }
        /// <summary>
        /// Maps to "_parent_menu_id" argument of the function "core.create_menu".
        /// </summary>
        public int ParentMenuId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.create_menu(_menu_text text, _url text, _menu_code text, _level integer, _parent_menu_id integer)" on the database.
        /// </summary>
        public CreateMenuProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.create_menu(_menu_text text, _url text, _menu_code text, _level integer, _parent_menu_id integer)" on the database.
        /// </summary>
        /// <param name="menuText">Enter argument value for "_menu_text" parameter of the function "core.create_menu".</param>
        /// <param name="url">Enter argument value for "_url" parameter of the function "core.create_menu".</param>
        /// <param name="menuCode">Enter argument value for "_menu_code" parameter of the function "core.create_menu".</param>
        /// <param name="level">Enter argument value for "_level" parameter of the function "core.create_menu".</param>
        /// <param name="parentMenuId">Enter argument value for "_parent_menu_id" parameter of the function "core.create_menu".</param>
        public CreateMenuProcedure(string menuText, string url, string menuCode, int level, int parentMenuId)
        {
            this.MenuText = menuText;
            this.Url = url;
            this.MenuCode = menuCode;
            this.Level = level;
            this.ParentMenuId = parentMenuId;
        }
        /// <summary>
        /// Prepares and executes the function "core.create_menu".
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
                    Log.Information("Access to the function \"CreateMenuProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            const string query = "SELECT * FROM core.create_menu(@0::text, @1::text, @2::text, @3::integer, @4::integer);";
            Factory.NonQuery(this._Catalog, query, this.MenuText, this.Url, this.MenuCode, this.Level, this.ParentMenuId);
        }
    }
}