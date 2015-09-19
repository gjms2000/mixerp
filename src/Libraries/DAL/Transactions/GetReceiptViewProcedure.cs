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
    /// Prepares, validates, and executes the function "transactions.get_receipt_view(_user_id integer, _office_id integer, _date_from date, _date_to date, _office character varying, _party text, _user character varying, _reference_number character varying, _statement_reference text)" on the database.
    /// </summary>
    public class GetReceiptViewProcedure : DbAccess
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string ObjectName => "get_receipt_view";
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
        /// Maps to "_user_id" argument of the function "transactions.get_receipt_view".
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Maps to "_office_id" argument of the function "transactions.get_receipt_view".
        /// </summary>
        public int OfficeId { get; set; }
        /// <summary>
        /// Maps to "_date_from" argument of the function "transactions.get_receipt_view".
        /// </summary>
        public DateTime DateFrom { get; set; }
        /// <summary>
        /// Maps to "_date_to" argument of the function "transactions.get_receipt_view".
        /// </summary>
        public DateTime DateTo { get; set; }
        /// <summary>
        /// Maps to "_office" argument of the function "transactions.get_receipt_view".
        /// </summary>
        public string Office { get; set; }
        /// <summary>
        /// Maps to "_party" argument of the function "transactions.get_receipt_view".
        /// </summary>
        public string Party { get; set; }
        /// <summary>
        /// Maps to "_user" argument of the function "transactions.get_receipt_view".
        /// </summary>
        public string User { get; set; }
        /// <summary>
        /// Maps to "_reference_number" argument of the function "transactions.get_receipt_view".
        /// </summary>
        public string ReferenceNumber { get; set; }
        /// <summary>
        /// Maps to "_statement_reference" argument of the function "transactions.get_receipt_view".
        /// </summary>
        public string StatementReference { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_receipt_view(_user_id integer, _office_id integer, _date_from date, _date_to date, _office character varying, _party text, _user character varying, _reference_number character varying, _statement_reference text)" on the database.
        /// </summary>
        public GetReceiptViewProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_receipt_view(_user_id integer, _office_id integer, _date_from date, _date_to date, _office character varying, _party text, _user character varying, _reference_number character varying, _statement_reference text)" on the database.
        /// </summary>
        /// <param name="userId">Enter argument value for "_user_id" parameter of the function "transactions.get_receipt_view".</param>
        /// <param name="officeId">Enter argument value for "_office_id" parameter of the function "transactions.get_receipt_view".</param>
        /// <param name="dateFrom">Enter argument value for "_date_from" parameter of the function "transactions.get_receipt_view".</param>
        /// <param name="dateTo">Enter argument value for "_date_to" parameter of the function "transactions.get_receipt_view".</param>
        /// <param name="office">Enter argument value for "_office" parameter of the function "transactions.get_receipt_view".</param>
        /// <param name="party">Enter argument value for "_party" parameter of the function "transactions.get_receipt_view".</param>
        /// <param name="user">Enter argument value for "_user" parameter of the function "transactions.get_receipt_view".</param>
        /// <param name="referenceNumber">Enter argument value for "_reference_number" parameter of the function "transactions.get_receipt_view".</param>
        /// <param name="statementReference">Enter argument value for "_statement_reference" parameter of the function "transactions.get_receipt_view".</param>
        public GetReceiptViewProcedure(int userId, int officeId, DateTime dateFrom, DateTime dateTo, string office, string party, string user, string referenceNumber, string statementReference)
        {
            this.UserId = userId;
            this.OfficeId = officeId;
            this.DateFrom = dateFrom;
            this.DateTo = dateTo;
            this.Office = office;
            this.Party = party;
            this.User = user;
            this.ReferenceNumber = referenceNumber;
            this.StatementReference = statementReference;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.get_receipt_view".
        /// </summary>
        public IEnumerable<DbGetReceiptViewResult> Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"GetReceiptViewProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            const string query = "SELECT * FROM transactions.get_receipt_view(@0::integer, @1::integer, @2::date, @3::date, @4::character varying, @5::text, @6::character varying, @7::character varying, @8::text);";
            return Factory.Get<DbGetReceiptViewResult>(this.Catalog, query, this.UserId, this.OfficeId, this.DateFrom, this.DateTo, this.Office, this.Party, this.User, this.ReferenceNumber, this.StatementReference);
        }
    }
}