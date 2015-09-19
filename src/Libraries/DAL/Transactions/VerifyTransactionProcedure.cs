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
    /// Prepares, validates, and executes the function "transactions.verify_transaction(_transaction_master_id bigint, _office_id integer, _user_id integer, _login_id bigint, _verification_status_id smallint, _reason character varying)" on the database.
    /// </summary>
    public class VerifyTransactionProcedure : DbAccess
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string ObjectName => "verify_transaction";
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
        /// Maps to "_transaction_master_id" argument of the function "transactions.verify_transaction".
        /// </summary>
        public long TransactionMasterId { get; set; }
        /// <summary>
        /// Maps to "_office_id" argument of the function "transactions.verify_transaction".
        /// </summary>
        public int OfficeId { get; set; }
        /// <summary>
        /// Maps to "_user_id" argument of the function "transactions.verify_transaction".
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Maps to "_login_id" argument of the function "transactions.verify_transaction".
        /// </summary>
        public long LoginIdParameter { get; set; }
        /// <summary>
        /// Maps to "_verification_status_id" argument of the function "transactions.verify_transaction".
        /// </summary>
        public short VerificationStatusId { get; set; }
        /// <summary>
        /// Maps to "_reason" argument of the function "transactions.verify_transaction".
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.verify_transaction(_transaction_master_id bigint, _office_id integer, _user_id integer, _login_id bigint, _verification_status_id smallint, _reason character varying)" on the database.
        /// </summary>
        public VerifyTransactionProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.verify_transaction(_transaction_master_id bigint, _office_id integer, _user_id integer, _login_id bigint, _verification_status_id smallint, _reason character varying)" on the database.
        /// </summary>
        /// <param name="transactionMasterId">Enter argument value for "_transaction_master_id" parameter of the function "transactions.verify_transaction".</param>
        /// <param name="officeId">Enter argument value for "_office_id" parameter of the function "transactions.verify_transaction".</param>
        /// <param name="userId">Enter argument value for "_user_id" parameter of the function "transactions.verify_transaction".</param>
        /// <param name="loginIdParameter">Enter argument value for "_login_id" parameter of the function "transactions.verify_transaction".</param>
        /// <param name="verificationStatusId">Enter argument value for "_verification_status_id" parameter of the function "transactions.verify_transaction".</param>
        /// <param name="reason">Enter argument value for "_reason" parameter of the function "transactions.verify_transaction".</param>
        public VerifyTransactionProcedure(long transactionMasterId, int officeId, int userId, long loginIdParameter, short verificationStatusId, string reason)
        {
            this.TransactionMasterId = transactionMasterId;
            this.OfficeId = officeId;
            this.UserId = userId;
            this.LoginIdParameter = loginIdParameter;
            this.VerificationStatusId = verificationStatusId;
            this.Reason = reason;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.verify_transaction".
        /// </summary>
        public long Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"VerifyTransactionProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            const string query = "SELECT * FROM transactions.verify_transaction(@0::bigint, @1::integer, @2::integer, @3::bigint, @4::smallint, @5::character varying);";
            return Factory.Scalar<long>(this.Catalog, query, this.TransactionMasterId, this.OfficeId, this.UserId, this.LoginIdParameter, this.VerificationStatusId, this.Reason);
        }
    }
}