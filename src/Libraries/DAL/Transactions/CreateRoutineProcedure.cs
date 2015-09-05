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
using MixERP.Net.Entities.Transactions;
using Npgsql;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
namespace MixERP.Net.Schemas.Transactions.Data
{
	/// <summary>
	/// Prepares, validates, and executes the function "transactions.create_routine(_routine_code character varying, _routine regproc, _order integer)" on the database.
	/// </summary>
	public class CreateRoutineProcedure: DbAccess
	{
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
	    public override string ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
	    public override string ObjectName => "create_routine";
        /// <summary>
        /// Login id of application user accessing this PostgreSQL function.
        /// </summary>
		public long LoginId { get; set; }
        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Maps to "_routine_code" argument of the function "transactions.create_routine".
		/// </summary>
		public string RoutineCode { get; set; }
		/// <summary>
		/// Maps to "_routine" argument of the function "transactions.create_routine".
		/// </summary>
		public string Routine { get; set; }
		/// <summary>
		/// Maps to "_order" argument of the function "transactions.create_routine".
		/// </summary>
		public int Order { get; set; }

		/// <summary>
		/// Prepares, validates, and executes the function "transactions.create_routine(_routine_code character varying, _routine regproc, _order integer)" on the database.
		/// </summary>
		public CreateRoutineProcedure()
		{
		}

		/// <summary>
		/// Prepares, validates, and executes the function "transactions.create_routine(_routine_code character varying, _routine regproc, _order integer)" on the database.
		/// </summary>
		/// <param name="routineCode">Enter argument value for "_routine_code" parameter of the function "transactions.create_routine".</param>
		/// <param name="routine">Enter argument value for "_routine" parameter of the function "transactions.create_routine".</param>
		/// <param name="order">Enter argument value for "_order" parameter of the function "transactions.create_routine".</param>
		public CreateRoutineProcedure(string routineCode,string routine,int order)
		{
			this.RoutineCode = routineCode;
			this.Routine = routine;
			this.Order = order;
		}
		/// <summary>
		/// Prepares and executes the function "transactions.create_routine".
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
                    Log.Information("Access to the function \"CreateRoutineProcedure\" was denied to the user with Login ID {LoginId}.", this.LoginId);
					throw new UnauthorizedException("Access is denied.");
				}
			}
			const string query = "SELECT * FROM transactions.create_routine(@0::character varying, @1::regproc, @2::integer);";
			Factory.NonQuery(this.Catalog, query, this.RoutineCode, this.Routine, this.Order);
		} 
	}
}