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
    /// Prepares, validates, and executes the function "transactions.get_stock_account_statement(_value_date_from date, _value_date_to date, _user_id integer, _item_id integer, _store_id integer)" on the database.
    /// </summary>
    public class GetStockAccountStatementProcedure : DbAccess
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_stock_account_statement";
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
        /// Maps to "_value_date_from" argument of the function "transactions.get_stock_account_statement".
        /// </summary>
        public DateTime ValueDateFrom { get; set; }
        /// <summary>
        /// Maps to "_value_date_to" argument of the function "transactions.get_stock_account_statement".
        /// </summary>
        public DateTime ValueDateTo { get; set; }
        /// <summary>
        /// Maps to "_user_id" argument of the function "transactions.get_stock_account_statement".
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Maps to "_item_id" argument of the function "transactions.get_stock_account_statement".
        /// </summary>
        public int ItemId { get; set; }
        /// <summary>
        /// Maps to "_store_id" argument of the function "transactions.get_stock_account_statement".
        /// </summary>
        public int StoreId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_stock_account_statement(_value_date_from date, _value_date_to date, _user_id integer, _item_id integer, _store_id integer)" on the database.
        /// </summary>
        public GetStockAccountStatementProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_stock_account_statement(_value_date_from date, _value_date_to date, _user_id integer, _item_id integer, _store_id integer)" on the database.
        /// </summary>
        /// <param name="valueDateFrom">Enter argument value for "_value_date_from" parameter of the function "transactions.get_stock_account_statement".</param>
        /// <param name="valueDateTo">Enter argument value for "_value_date_to" parameter of the function "transactions.get_stock_account_statement".</param>
        /// <param name="userId">Enter argument value for "_user_id" parameter of the function "transactions.get_stock_account_statement".</param>
        /// <param name="itemId">Enter argument value for "_item_id" parameter of the function "transactions.get_stock_account_statement".</param>
        /// <param name="storeId">Enter argument value for "_store_id" parameter of the function "transactions.get_stock_account_statement".</param>
        public GetStockAccountStatementProcedure(DateTime valueDateFrom, DateTime valueDateTo, int userId, int itemId, int storeId)
        {
            this.ValueDateFrom = valueDateFrom;
            this.ValueDateTo = valueDateTo;
            this.UserId = userId;
            this.ItemId = itemId;
            this.StoreId = storeId;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.get_stock_account_statement".
        /// </summary>
        public IEnumerable<DbGetStockAccountStatementResult> Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"GetStockAccountStatementProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            const string query = "SELECT * FROM transactions.get_stock_account_statement(@0::date, @1::date, @2::integer, @3::integer, @4::integer);";
            return Factory.Get<DbGetStockAccountStatementResult>(this._Catalog, query, this.ValueDateFrom, this.ValueDateTo, this.UserId, this.ItemId, this.StoreId);
        }
    }
}