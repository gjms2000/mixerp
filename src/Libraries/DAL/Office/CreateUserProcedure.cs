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
using MixERP.Net.Entities.Office;
using Npgsql;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
namespace MixERP.Net.Schemas.Office.Data
{
	/// <summary>
	/// Prepares, validates, and executes the function "office.create_user(_role_id integer, _department_id integer, _office_id integer, _user_name text, _password text, _full_name text, _elevated boolean)" on the database.
	/// </summary>
	public class CreateUserProcedure: DbAccess
	{
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
	    public override string ObjectNamespace => "office";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
	    public override string ObjectName => "create_user";
        /// <summary>
        /// Login id of application user accessing this PostgreSQL function.
        /// </summary>
		public long LoginId { get; set; }
        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Maps to "_role_id" argument of the function "office.create_user".
		/// </summary>
		public int RoleId { get; set; }
		/// <summary>
		/// Maps to "_department_id" argument of the function "office.create_user".
		/// </summary>
		public int DepartmentId { get; set; }
		/// <summary>
		/// Maps to "_office_id" argument of the function "office.create_user".
		/// </summary>
		public int OfficeId { get; set; }
		/// <summary>
		/// Maps to "_user_name" argument of the function "office.create_user".
		/// </summary>
		public string UserName { get; set; }
		/// <summary>
		/// Maps to "_password" argument of the function "office.create_user".
		/// </summary>
		public string Password { get; set; }
		/// <summary>
		/// Maps to "_full_name" argument of the function "office.create_user".
		/// </summary>
		public string FullName { get; set; }
		/// <summary>
		/// Maps to "_elevated" argument of the function "office.create_user".
		/// </summary>
		public bool Elevated { get; set; }

		/// <summary>
		/// Prepares, validates, and executes the function "office.create_user(_role_id integer, _department_id integer, _office_id integer, _user_name text, _password text, _full_name text, _elevated boolean)" on the database.
		/// </summary>
		public CreateUserProcedure()
		{
		}

		/// <summary>
		/// Prepares, validates, and executes the function "office.create_user(_role_id integer, _department_id integer, _office_id integer, _user_name text, _password text, _full_name text, _elevated boolean)" on the database.
		/// </summary>
		/// <param name="roleId">Enter argument value for "_role_id" parameter of the function "office.create_user".</param>
		/// <param name="departmentId">Enter argument value for "_department_id" parameter of the function "office.create_user".</param>
		/// <param name="officeId">Enter argument value for "_office_id" parameter of the function "office.create_user".</param>
		/// <param name="userName">Enter argument value for "_user_name" parameter of the function "office.create_user".</param>
		/// <param name="password">Enter argument value for "_password" parameter of the function "office.create_user".</param>
		/// <param name="fullName">Enter argument value for "_full_name" parameter of the function "office.create_user".</param>
		/// <param name="elevated">Enter argument value for "_elevated" parameter of the function "office.create_user".</param>
		public CreateUserProcedure(int roleId,int departmentId,int officeId,string userName,string password,string fullName,bool elevated)
		{
			this.RoleId = roleId;
			this.DepartmentId = departmentId;
			this.OfficeId = officeId;
			this.UserName = userName;
			this.Password = password;
			this.FullName = fullName;
			this.Elevated = elevated;
		}
		/// <summary>
		/// Prepares and executes the function "office.create_user".
		/// </summary>
		public void Execute()
		{
			try
			{
				if (!this.SkipValidation)
				{
					if (!this.Validated)
					{
						this.Validate(AccessTypeEnum.Execute, this.LoginId, false);
					}
					if (!this.HasAccess)
					{
						throw new UnauthorizedException("Access is denied.");
					}
				}
				const string query = "SELECT * FROM office.create_user(@0::integer, @1::integer, @2::integer, @3::text, @4::text, @5::text, @6::boolean);";
				Factory.NonQuery(this.Catalog, query, this.RoleId, this.DepartmentId, this.OfficeId, this.UserName, this.Password, this.FullName, this.Elevated);
			}
			catch (UnauthorizedException ex)
			{
				Log.Error("{Exception} {@Exception}", ex.Message, ex);
                throw new MixERPException(ex.Message, ex);
			}
		} 
	}
}