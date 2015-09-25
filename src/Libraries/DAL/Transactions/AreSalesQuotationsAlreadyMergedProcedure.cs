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
using MixERP.Net.Entities.Transactions;
using Npgsql;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
namespace MixERP.Net.Schemas.Transactions.Data
{
    /// <summary>
    /// Prepares, validates, and executes the function "transactions.are_sales_quotations_already_merged(_stock_master_id bigint[])" on the database.
    /// </summary>
    public class AreSalesQuotationsAlreadyMergedProcedure : DbAccess
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "are_sales_quotations_already_merged";
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
        /// Maps to "_stock_master_id" argument of the function "transactions.are_sales_quotations_already_merged".
        /// </summary>
        public long[] StockMasterId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.are_sales_quotations_already_merged(_stock_master_id bigint[])" on the database.
        /// </summary>
        public AreSalesQuotationsAlreadyMergedProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.are_sales_quotations_already_merged(_stock_master_id bigint[])" on the database.
        /// </summary>
        /// <param name="stockMasterId">Enter argument value for "_stock_master_id" parameter of the function "transactions.are_sales_quotations_already_merged".</param>
        public AreSalesQuotationsAlreadyMergedProcedure(long[] stockMasterId)
        {
            this.StockMasterId = stockMasterId;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.are_sales_quotations_already_merged".
        /// </summary>
        public bool Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"AreSalesQuotationsAlreadyMergedProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            const string query = "SELECT * FROM transactions.are_sales_quotations_already_merged(@0::bigint[]);";
            return Factory.Scalar<bool>(this._Catalog, query, this.StockMasterId);
        }
    }
}