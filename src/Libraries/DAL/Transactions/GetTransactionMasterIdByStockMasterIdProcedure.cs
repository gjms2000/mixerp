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
	/// Prepares, validates, and executes the function "transactions.get_transaction_master_id_by_stock_master_id(_stock_master_id bigint)" on the database.
	/// </summary>
	public class GetTransactionMasterIdByStockMasterIdProcedure: DbAccess
	{
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
	    public override string ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
	    public override string ObjectName => "get_transaction_master_id_by_stock_master_id";
        /// <summary>
        /// Login id of application user accessing this PostgreSQL function.
        /// </summary>
		public long LoginId { get; set; }
        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Maps to "_stock_master_id" argument of the function "transactions.get_transaction_master_id_by_stock_master_id".
		/// </summary>
		public long StockMasterId { get; set; }

		/// <summary>
		/// Prepares, validates, and executes the function "transactions.get_transaction_master_id_by_stock_master_id(_stock_master_id bigint)" on the database.
		/// </summary>
		public GetTransactionMasterIdByStockMasterIdProcedure()
		{
		}

		/// <summary>
		/// Prepares, validates, and executes the function "transactions.get_transaction_master_id_by_stock_master_id(_stock_master_id bigint)" on the database.
		/// </summary>
		/// <param name="stockMasterId">Enter argument value for "_stock_master_id" parameter of the function "transactions.get_transaction_master_id_by_stock_master_id".</param>
		public GetTransactionMasterIdByStockMasterIdProcedure(long stockMasterId)
		{
			this.StockMasterId = stockMasterId;
		}
		/// <summary>
		/// Prepares and executes the function "transactions.get_transaction_master_id_by_stock_master_id".
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
				const string query = "SELECT * FROM transactions.get_transaction_master_id_by_stock_master_id(@0::bigint);";
				return Factory.Scalar<long>(this.Catalog, query, this.StockMasterId);
			}
			catch (UnauthorizedException ex)
			{
				Log.Error("{Exception} {@Exception}", ex.Message, ex);
                throw new MixERPException(ex.Message, ex);
			}
		} 
	}
}