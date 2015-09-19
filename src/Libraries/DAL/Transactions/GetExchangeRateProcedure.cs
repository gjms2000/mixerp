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
    /// Prepares, validates, and executes the function "transactions.get_exchange_rate(office_id integer, source_currency_code character varying, destination_currency_code character varying)" on the database.
    /// </summary>
    public class GetExchangeRateProcedure : DbAccess
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string ObjectName => "get_exchange_rate";
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
        public string Catalog { get; set; }

        /// <summary>
        /// Maps to "office_id" argument of the function "transactions.get_exchange_rate".
        /// </summary>
        public int OfficeId { get; set; }
        /// <summary>
        /// Maps to "source_currency_code" argument of the function "transactions.get_exchange_rate".
        /// </summary>
        public string SourceCurrencyCode { get; set; }
        /// <summary>
        /// Maps to "destination_currency_code" argument of the function "transactions.get_exchange_rate".
        /// </summary>
        public string DestinationCurrencyCode { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_exchange_rate(office_id integer, source_currency_code character varying, destination_currency_code character varying)" on the database.
        /// </summary>
        public GetExchangeRateProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_exchange_rate(office_id integer, source_currency_code character varying, destination_currency_code character varying)" on the database.
        /// </summary>
        /// <param name="officeId">Enter argument value for "office_id" parameter of the function "transactions.get_exchange_rate".</param>
        /// <param name="sourceCurrencyCode">Enter argument value for "source_currency_code" parameter of the function "transactions.get_exchange_rate".</param>
        /// <param name="destinationCurrencyCode">Enter argument value for "destination_currency_code" parameter of the function "transactions.get_exchange_rate".</param>
        public GetExchangeRateProcedure(int officeId, string sourceCurrencyCode, string destinationCurrencyCode)
        {
            this.OfficeId = officeId;
            this.SourceCurrencyCode = sourceCurrencyCode;
            this.DestinationCurrencyCode = destinationCurrencyCode;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.get_exchange_rate".
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
                    Log.Information("Access to the function \"GetExchangeRateProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            const string query = "SELECT * FROM transactions.get_exchange_rate(@0::integer, @1::character varying, @2::character varying);";
            return Factory.Get<decimal>(this.Catalog, query, this.OfficeId, this.SourceCurrencyCode, this.DestinationCurrencyCode).FirstOrDefault();
        }
    }
}