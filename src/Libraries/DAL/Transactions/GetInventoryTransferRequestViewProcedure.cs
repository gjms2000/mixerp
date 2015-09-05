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
	/// Prepares, validates, and executes the function "transactions.get_inventory_transfer_request_view(_user_id integer, _login_id bigint, _office_id integer, _from date, _to date, _office text, _store text, _authorized text, _delivered text, _received text, _user text, _reference_number text, _statement_reference text)" on the database.
	/// </summary>
	public class GetInventoryTransferRequestViewProcedure: DbAccess
	{
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
	    public override string ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
	    public override string ObjectName => "get_inventory_transfer_request_view";
        /// <summary>
        /// Login id of application user accessing this PostgreSQL function.
        /// </summary>
		public long LoginId { get; set; }
        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Maps to "_user_id" argument of the function "transactions.get_inventory_transfer_request_view".
		/// </summary>
		public int UserId { get; set; }
		/// <summary>
		/// Maps to "_login_id" argument of the function "transactions.get_inventory_transfer_request_view".
		/// </summary>
		public long LoginIdParameter { get; set; }
		/// <summary>
		/// Maps to "_office_id" argument of the function "transactions.get_inventory_transfer_request_view".
		/// </summary>
		public int OfficeId { get; set; }
		/// <summary>
		/// Maps to "_from" argument of the function "transactions.get_inventory_transfer_request_view".
		/// </summary>
		public DateTime From { get; set; }
		/// <summary>
		/// Maps to "_to" argument of the function "transactions.get_inventory_transfer_request_view".
		/// </summary>
		public DateTime To { get; set; }
		/// <summary>
		/// Maps to "_office" argument of the function "transactions.get_inventory_transfer_request_view".
		/// </summary>
		public string Office { get; set; }
		/// <summary>
		/// Maps to "_store" argument of the function "transactions.get_inventory_transfer_request_view".
		/// </summary>
		public string Store { get; set; }
		/// <summary>
		/// Maps to "_authorized" argument of the function "transactions.get_inventory_transfer_request_view".
		/// </summary>
		public string Authorized { get; set; }
		/// <summary>
		/// Maps to "_delivered" argument of the function "transactions.get_inventory_transfer_request_view".
		/// </summary>
		public string Delivered { get; set; }
		/// <summary>
		/// Maps to "_received" argument of the function "transactions.get_inventory_transfer_request_view".
		/// </summary>
		public string Received { get; set; }
		/// <summary>
		/// Maps to "_user" argument of the function "transactions.get_inventory_transfer_request_view".
		/// </summary>
		public string User { get; set; }
		/// <summary>
		/// Maps to "_reference_number" argument of the function "transactions.get_inventory_transfer_request_view".
		/// </summary>
		public string ReferenceNumber { get; set; }
		/// <summary>
		/// Maps to "_statement_reference" argument of the function "transactions.get_inventory_transfer_request_view".
		/// </summary>
		public string StatementReference { get; set; }

		/// <summary>
		/// Prepares, validates, and executes the function "transactions.get_inventory_transfer_request_view(_user_id integer, _login_id bigint, _office_id integer, _from date, _to date, _office text, _store text, _authorized text, _delivered text, _received text, _user text, _reference_number text, _statement_reference text)" on the database.
		/// </summary>
		public GetInventoryTransferRequestViewProcedure()
		{
		}

		/// <summary>
		/// Prepares, validates, and executes the function "transactions.get_inventory_transfer_request_view(_user_id integer, _login_id bigint, _office_id integer, _from date, _to date, _office text, _store text, _authorized text, _delivered text, _received text, _user text, _reference_number text, _statement_reference text)" on the database.
		/// </summary>
		/// <param name="userId">Enter argument value for "_user_id" parameter of the function "transactions.get_inventory_transfer_request_view".</param>
		/// <param name="loginIdParameter">Enter argument value for "_login_id" parameter of the function "transactions.get_inventory_transfer_request_view".</param>
		/// <param name="officeId">Enter argument value for "_office_id" parameter of the function "transactions.get_inventory_transfer_request_view".</param>
		/// <param name="from">Enter argument value for "_from" parameter of the function "transactions.get_inventory_transfer_request_view".</param>
		/// <param name="to">Enter argument value for "_to" parameter of the function "transactions.get_inventory_transfer_request_view".</param>
		/// <param name="office">Enter argument value for "_office" parameter of the function "transactions.get_inventory_transfer_request_view".</param>
		/// <param name="store">Enter argument value for "_store" parameter of the function "transactions.get_inventory_transfer_request_view".</param>
		/// <param name="authorized">Enter argument value for "_authorized" parameter of the function "transactions.get_inventory_transfer_request_view".</param>
		/// <param name="delivered">Enter argument value for "_delivered" parameter of the function "transactions.get_inventory_transfer_request_view".</param>
		/// <param name="received">Enter argument value for "_received" parameter of the function "transactions.get_inventory_transfer_request_view".</param>
		/// <param name="user">Enter argument value for "_user" parameter of the function "transactions.get_inventory_transfer_request_view".</param>
		/// <param name="referenceNumber">Enter argument value for "_reference_number" parameter of the function "transactions.get_inventory_transfer_request_view".</param>
		/// <param name="statementReference">Enter argument value for "_statement_reference" parameter of the function "transactions.get_inventory_transfer_request_view".</param>
		public GetInventoryTransferRequestViewProcedure(int userId,long loginIdParameter,int officeId,DateTime from,DateTime to,string office,string store,string authorized,string delivered,string received,string user,string referenceNumber,string statementReference)
		{
			this.UserId = userId;
			this.LoginIdParameter = loginIdParameter;
			this.OfficeId = officeId;
			this.From = from;
			this.To = to;
			this.Office = office;
			this.Store = store;
			this.Authorized = authorized;
			this.Delivered = delivered;
			this.Received = received;
			this.User = user;
			this.ReferenceNumber = referenceNumber;
			this.StatementReference = statementReference;
		}
		/// <summary>
		/// Prepares and executes the function "transactions.get_inventory_transfer_request_view".
		/// </summary>
		public IEnumerable<DbGetInventoryTransferRequestViewResult> Execute()
		{
			if (!this.SkipValidation)
			{
				if (!this.Validated)
				{
					this.Validate(AccessTypeEnum.Execute, this.LoginId, false);
				}
				if (!this.HasAccess)
				{
                    Log.Information("Access to the function \"GetInventoryTransferRequestViewProcedure\" was denied to the user with Login ID {LoginId}.", this.LoginId);
					throw new UnauthorizedException("Access is denied.");
				}
			}
			const string query = "SELECT * FROM transactions.get_inventory_transfer_request_view(@0::integer, @1::bigint, @2::integer, @3::date, @4::date, @5::text, @6::text, @7::text, @8::text, @9::text, @10::text, @11::text, @12::text);";
			return Factory.Get<DbGetInventoryTransferRequestViewResult>(this.Catalog, query, this.UserId, this.LoginIdParameter, this.OfficeId, this.From, this.To, this.Office, this.Store, this.Authorized, this.Delivered, this.Received, this.User, this.ReferenceNumber, this.StatementReference);
		} 
	}
}