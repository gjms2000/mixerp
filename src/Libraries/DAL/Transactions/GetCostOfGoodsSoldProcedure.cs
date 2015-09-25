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
    /// Prepares, validates, and executes the function "transactions.get_cost_of_goods_sold(_item_id integer, _unit_id integer, _store_id integer, _quantity integer)" on the database.
    /// </summary>
    public class GetCostOfGoodsSoldProcedure : DbAccess
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_cost_of_goods_sold";
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
        /// Maps to "_item_id" argument of the function "transactions.get_cost_of_goods_sold".
        /// </summary>
        public int ItemId { get; set; }
        /// <summary>
        /// Maps to "_unit_id" argument of the function "transactions.get_cost_of_goods_sold".
        /// </summary>
        public int UnitId { get; set; }
        /// <summary>
        /// Maps to "_store_id" argument of the function "transactions.get_cost_of_goods_sold".
        /// </summary>
        public int StoreId { get; set; }
        /// <summary>
        /// Maps to "_quantity" argument of the function "transactions.get_cost_of_goods_sold".
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_cost_of_goods_sold(_item_id integer, _unit_id integer, _store_id integer, _quantity integer)" on the database.
        /// </summary>
        public GetCostOfGoodsSoldProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_cost_of_goods_sold(_item_id integer, _unit_id integer, _store_id integer, _quantity integer)" on the database.
        /// </summary>
        /// <param name="itemId">Enter argument value for "_item_id" parameter of the function "transactions.get_cost_of_goods_sold".</param>
        /// <param name="unitId">Enter argument value for "_unit_id" parameter of the function "transactions.get_cost_of_goods_sold".</param>
        /// <param name="storeId">Enter argument value for "_store_id" parameter of the function "transactions.get_cost_of_goods_sold".</param>
        /// <param name="quantity">Enter argument value for "_quantity" parameter of the function "transactions.get_cost_of_goods_sold".</param>
        public GetCostOfGoodsSoldProcedure(int itemId, int unitId, int storeId, int quantity)
        {
            this.ItemId = itemId;
            this.UnitId = unitId;
            this.StoreId = storeId;
            this.Quantity = quantity;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.get_cost_of_goods_sold".
        /// </summary>
        public decimal Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"GetCostOfGoodsSoldProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            const string query = "SELECT * FROM transactions.get_cost_of_goods_sold(@0::integer, @1::integer, @2::integer, @3::integer);";
            return Factory.Get<decimal>(this._Catalog, query, this.ItemId, this.UnitId, this.StoreId, this.Quantity).FirstOrDefault();
        }
    }
}