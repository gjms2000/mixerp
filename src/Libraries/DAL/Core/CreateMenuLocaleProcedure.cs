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
	/// Prepares, validates, and executes the function "core.create_menu_locale(_menu_id integer, _culture text, _menu_text text)" on the database.
	/// </summary>
	public class CreateMenuLocaleProcedure: DbAccess
	{
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
	    public override string ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
	    public override string ObjectName => "create_menu_locale";
        /// <summary>
        /// Login id of application user accessing this PostgreSQL function.
        /// </summary>
		public long LoginId { get; set; }
        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Maps to "_menu_id" argument of the function "core.create_menu_locale".
		/// </summary>
		public int MenuId { get; set; }
		/// <summary>
		/// Maps to "_culture" argument of the function "core.create_menu_locale".
		/// </summary>
		public string Culture { get; set; }
		/// <summary>
		/// Maps to "_menu_text" argument of the function "core.create_menu_locale".
		/// </summary>
		public string MenuText { get; set; }

		/// <summary>
		/// Prepares, validates, and executes the function "core.create_menu_locale(_menu_id integer, _culture text, _menu_text text)" on the database.
		/// </summary>
		public CreateMenuLocaleProcedure()
		{
		}

		/// <summary>
		/// Prepares, validates, and executes the function "core.create_menu_locale(_menu_id integer, _culture text, _menu_text text)" on the database.
		/// </summary>
		/// <param name="menuId">Enter argument value for "_menu_id" parameter of the function "core.create_menu_locale".</param>
		/// <param name="culture">Enter argument value for "_culture" parameter of the function "core.create_menu_locale".</param>
		/// <param name="menuText">Enter argument value for "_menu_text" parameter of the function "core.create_menu_locale".</param>
		public CreateMenuLocaleProcedure(int menuId,string culture,string menuText)
		{
			this.MenuId = menuId;
			this.Culture = culture;
			this.MenuText = menuText;
		}
		/// <summary>
		/// Prepares and executes the function "core.create_menu_locale".
		/// </summary>
		public void Execute()
		{
			if (!this.SkipValidation)
			{
				if (!this.Validated)
				{
					this.Validate(AccessTypeEnum.Execute, this.LoginId, false);
				}
				if (!this.HasAccess)
				{
                    Log.Information("Access to the function \"CreateMenuLocaleProcedure\" was denied to the user with Login ID {LoginId}.", this.LoginId);
					throw new UnauthorizedException("Access is denied.");
				}
			}
			const string query = "SELECT * FROM core.create_menu_locale(@0::integer, @1::text, @2::text);";
			Factory.NonQuery(this.Catalog, query, this.MenuId, this.Culture, this.MenuText);
		} 
	}
}