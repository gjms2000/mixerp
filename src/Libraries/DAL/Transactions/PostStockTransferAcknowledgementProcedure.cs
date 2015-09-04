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
	/// Prepares, validates, and executes the function "transactions.post_stock_transfer_acknowledgement(_office_id integer, _user_id integer, _login_id bigint, _request_id bigint)" on the database.
	/// </summary>
	public class PostStockTransferAcknowledgementProcedure: DbAccess
	{
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
	    public override string ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
	    public override string ObjectName => "post_stock_transfer_acknowledgement";
        /// <summary>
        /// Login id of application user accessing this PostgreSQL function.
        /// </summary>
		public long LoginId { get; set; }
        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Maps to "_office_id" argument of the function "transactions.post_stock_transfer_acknowledgement".
		/// </summary>
		public int OfficeId { get; set; }
		/// <summary>
		/// Maps to "_user_id" argument of the function "transactions.post_stock_transfer_acknowledgement".
		/// </summary>
		public int UserId { get; set; }
		/// <summary>
		/// Maps to "_login_id" argument of the function "transactions.post_stock_transfer_acknowledgement".
		/// </summary>
		public long LoginIdParameter { get; set; }
		/// <summary>
		/// Maps to "_request_id" argument of the function "transactions.post_stock_transfer_acknowledgement".
		/// </summary>
		public long RequestId { get; set; }

		/// <summary>
		/// Prepares, validates, and executes the function "transactions.post_stock_transfer_acknowledgement(_office_id integer, _user_id integer, _login_id bigint, _request_id bigint)" on the database.
		/// </summary>
		public PostStockTransferAcknowledgementProcedure()
		{
		}

		/// <summary>
		/// Prepares, validates, and executes the function "transactions.post_stock_transfer_acknowledgement(_office_id integer, _user_id integer, _login_id bigint, _request_id bigint)" on the database.
		/// </summary>
		/// <param name="officeId">Enter argument value for "_office_id" parameter of the function "transactions.post_stock_transfer_acknowledgement".</param>
		/// <param name="userId">Enter argument value for "_user_id" parameter of the function "transactions.post_stock_transfer_acknowledgement".</param>
		/// <param name="loginIdParameter">Enter argument value for "_login_id" parameter of the function "transactions.post_stock_transfer_acknowledgement".</param>
		/// <param name="requestId">Enter argument value for "_request_id" parameter of the function "transactions.post_stock_transfer_acknowledgement".</param>
		public PostStockTransferAcknowledgementProcedure(int officeId,int userId,long loginIdParameter,long requestId)
		{
			this.OfficeId = officeId;
			this.UserId = userId;
			this.LoginIdParameter = loginIdParameter;
			this.RequestId = requestId;
		}
		/// <summary>
		/// Prepares and executes the function "transactions.post_stock_transfer_acknowledgement".
		/// </summary>
		public long Execute()
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
				const string query = "SELECT * FROM transactions.post_stock_transfer_acknowledgement(@0::integer, @1::integer, @2::bigint, @3::bigint);";
				return Factory.Scalar<long>(this.Catalog, query, this.OfficeId, this.UserId, this.LoginIdParameter, this.RequestId);
			}
			catch (UnauthorizedException ex)
			{
				Log.Error("{Exception} {@Exception}", ex.Message, ex);
                throw new MixERPException(ex.Message, ex);
			}
		} 
	}
}