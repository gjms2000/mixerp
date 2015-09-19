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
    /// Prepares, validates, and executes the function "transactions.get_transaction_code(value_date date, office_id integer, user_id integer, login_id bigint)" on the database.
    /// </summary>
    public class GetTransactionCodeProcedure : DbAccess
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string ObjectName => "get_transaction_code";
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
        /// Maps to "value_date" argument of the function "transactions.get_transaction_code".
        /// </summary>
        public DateTime ValueDate { get; set; }
        /// <summary>
        /// Maps to "office_id" argument of the function "transactions.get_transaction_code".
        /// </summary>
        public int OfficeId { get; set; }
        /// <summary>
        /// Maps to "user_id" argument of the function "transactions.get_transaction_code".
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Maps to "login_id" argument of the function "transactions.get_transaction_code".
        /// </summary>
        public long LoginIdParameter { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_transaction_code(value_date date, office_id integer, user_id integer, login_id bigint)" on the database.
        /// </summary>
        public GetTransactionCodeProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_transaction_code(value_date date, office_id integer, user_id integer, login_id bigint)" on the database.
        /// </summary>
        /// <param name="valueDate">Enter argument value for "value_date" parameter of the function "transactions.get_transaction_code".</param>
        /// <param name="officeId">Enter argument value for "office_id" parameter of the function "transactions.get_transaction_code".</param>
        /// <param name="userId">Enter argument value for "user_id" parameter of the function "transactions.get_transaction_code".</param>
        /// <param name="loginIdParameter">Enter argument value for "login_id" parameter of the function "transactions.get_transaction_code".</param>
        public GetTransactionCodeProcedure(DateTime valueDate, int officeId, int userId, long loginIdParameter)
        {
            this.ValueDate = valueDate;
            this.OfficeId = officeId;
            this.UserId = userId;
            this.LoginIdParameter = loginIdParameter;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.get_transaction_code".
        /// </summary>
        public string Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"GetTransactionCodeProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            const string query = "SELECT * FROM transactions.get_transaction_code(@0::date, @1::integer, @2::integer, @3::bigint);";
            return Factory.Scalar<string>(this.Catalog, query, this.ValueDate, this.OfficeId, this.UserId, this.LoginIdParameter);
        }
    }
}