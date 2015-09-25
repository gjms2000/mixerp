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
    /// Prepares, validates, and executes the function "transactions.get_net_profit(_date_from date, _date_to date, _office_id integer, _factor integer, _no_provison boolean)" on the database.
    /// </summary>
    public class GetNetProfitProcedure : DbAccess
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_net_profit";
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
        /// Maps to "_date_from" argument of the function "transactions.get_net_profit".
        /// </summary>
        public DateTime DateFrom { get; set; }
        /// <summary>
        /// Maps to "_date_to" argument of the function "transactions.get_net_profit".
        /// </summary>
        public DateTime DateTo { get; set; }
        /// <summary>
        /// Maps to "_office_id" argument of the function "transactions.get_net_profit".
        /// </summary>
        public int OfficeId { get; set; }
        /// <summary>
        /// Maps to "_factor" argument of the function "transactions.get_net_profit".
        /// </summary>
        public int Factor { get; set; }
        /// <summary>
        /// Maps to "_no_provison" argument of the function "transactions.get_net_profit".
        /// </summary>
        public bool NoProvison { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_net_profit(_date_from date, _date_to date, _office_id integer, _factor integer, _no_provison boolean)" on the database.
        /// </summary>
        public GetNetProfitProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_net_profit(_date_from date, _date_to date, _office_id integer, _factor integer, _no_provison boolean)" on the database.
        /// </summary>
        /// <param name="dateFrom">Enter argument value for "_date_from" parameter of the function "transactions.get_net_profit".</param>
        /// <param name="dateTo">Enter argument value for "_date_to" parameter of the function "transactions.get_net_profit".</param>
        /// <param name="officeId">Enter argument value for "_office_id" parameter of the function "transactions.get_net_profit".</param>
        /// <param name="factor">Enter argument value for "_factor" parameter of the function "transactions.get_net_profit".</param>
        /// <param name="noProvison">Enter argument value for "_no_provison" parameter of the function "transactions.get_net_profit".</param>
        public GetNetProfitProcedure(DateTime dateFrom, DateTime dateTo, int officeId, int factor, bool noProvison)
        {
            this.DateFrom = dateFrom;
            this.DateTo = dateTo;
            this.OfficeId = officeId;
            this.Factor = factor;
            this.NoProvison = noProvison;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.get_net_profit".
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
                    Log.Information("Access to the function \"GetNetProfitProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            const string query = "SELECT * FROM transactions.get_net_profit(@0::date, @1::date, @2::integer, @3::integer, @4::boolean);";
            return Factory.Scalar<decimal>(this._Catalog, query, this.DateFrom, this.DateTo, this.OfficeId, this.Factor, this.NoProvison);
        }
    }
}