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
	/// Prepares, validates, and executes the function "transactions.validate_items_for_return(_transaction_master_id bigint, _details transactions.stock_detail_type[])" on the database.
	/// </summary>
	public class ValidateItemsForReturnProcedure: DbAccess
	{
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
	    public override string ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
	    public override string ObjectName => "validate_items_for_return";
        /// <summary>
        /// Login id of application user accessing this PostgreSQL function.
        /// </summary>
		public long LoginId { get; set; }
        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Maps to "_transaction_master_id" argument of the function "transactions.validate_items_for_return".
		/// </summary>
		public long TransactionMasterId { get; set; }
		/// <summary>
		/// Maps to "_details" argument of the function "transactions.validate_items_for_return".
		/// </summary>
		public MixERP.Net.Entities.Transactions.StockDetailType[][] Details { get; set; }

		/// <summary>
		/// Prepares, validates, and executes the function "transactions.validate_items_for_return(_transaction_master_id bigint, _details transactions.stock_detail_type[])" on the database.
		/// </summary>
		public ValidateItemsForReturnProcedure()
		{
		}

		/// <summary>
		/// Prepares, validates, and executes the function "transactions.validate_items_for_return(_transaction_master_id bigint, _details transactions.stock_detail_type[])" on the database.
		/// </summary>
		/// <param name="transactionMasterId">Enter argument value for "_transaction_master_id" parameter of the function "transactions.validate_items_for_return".</param>
		/// <param name="details">Enter argument value for "_details" parameter of the function "transactions.validate_items_for_return".</param>
		public ValidateItemsForReturnProcedure(long transactionMasterId,MixERP.Net.Entities.Transactions.StockDetailType[][] details)
		{
			this.TransactionMasterId = transactionMasterId;
			this.Details = details;
		}
		/// <summary>
		/// Prepares and executes the function "transactions.validate_items_for_return".
		/// </summary>
		public bool Execute()
		{
			if (!this.SkipValidation)
			{
				if (!this.Validated)
				{
					this.Validate(AccessTypeEnum.Execute, this.LoginId, false);
				}
				if (!this.HasAccess)
				{
                    Log.Information("Access to the function \"ValidateItemsForReturnProcedure\" was denied to the user with Login ID {LoginId}.", this.LoginId);
					throw new UnauthorizedException("Access is denied.");
				}
			}
			const string query = "SELECT * FROM transactions.validate_items_for_return(@0::bigint, @1::transactions.stock_detail_type[]);";
			return Factory.Scalar<bool>(this.Catalog, query, this.TransactionMasterId, this.Details);
		} 
	}
}