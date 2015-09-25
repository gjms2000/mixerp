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
    /// Prepares, validates, and executes the function "transactions.get_journal_view(_user_id integer, _office_id integer, _from date, _to date, _tran_id bigint, _tran_code character varying, _book character varying, _reference_number character varying, _statement_reference character varying, _posted_by character varying, _office character varying, _status character varying, _verified_by character varying, _reason character varying)" on the database.
    /// </summary>
    public class GetJournalViewProcedure : DbAccess
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_journal_view";
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
        /// Maps to "_user_id" argument of the function "transactions.get_journal_view".
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Maps to "_office_id" argument of the function "transactions.get_journal_view".
        /// </summary>
        public int OfficeId { get; set; }
        /// <summary>
        /// Maps to "_from" argument of the function "transactions.get_journal_view".
        /// </summary>
        public DateTime From { get; set; }
        /// <summary>
        /// Maps to "_to" argument of the function "transactions.get_journal_view".
        /// </summary>
        public DateTime To { get; set; }
        /// <summary>
        /// Maps to "_tran_id" argument of the function "transactions.get_journal_view".
        /// </summary>
        public long TranId { get; set; }
        /// <summary>
        /// Maps to "_tran_code" argument of the function "transactions.get_journal_view".
        /// </summary>
        public string TranCode { get; set; }
        /// <summary>
        /// Maps to "_book" argument of the function "transactions.get_journal_view".
        /// </summary>
        public string Book { get; set; }
        /// <summary>
        /// Maps to "_reference_number" argument of the function "transactions.get_journal_view".
        /// </summary>
        public string ReferenceNumber { get; set; }
        /// <summary>
        /// Maps to "_statement_reference" argument of the function "transactions.get_journal_view".
        /// </summary>
        public string StatementReference { get; set; }
        /// <summary>
        /// Maps to "_posted_by" argument of the function "transactions.get_journal_view".
        /// </summary>
        public string PostedBy { get; set; }
        /// <summary>
        /// Maps to "_office" argument of the function "transactions.get_journal_view".
        /// </summary>
        public string Office { get; set; }
        /// <summary>
        /// Maps to "_status" argument of the function "transactions.get_journal_view".
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// Maps to "_verified_by" argument of the function "transactions.get_journal_view".
        /// </summary>
        public string VerifiedBy { get; set; }
        /// <summary>
        /// Maps to "_reason" argument of the function "transactions.get_journal_view".
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_journal_view(_user_id integer, _office_id integer, _from date, _to date, _tran_id bigint, _tran_code character varying, _book character varying, _reference_number character varying, _statement_reference character varying, _posted_by character varying, _office character varying, _status character varying, _verified_by character varying, _reason character varying)" on the database.
        /// </summary>
        public GetJournalViewProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_journal_view(_user_id integer, _office_id integer, _from date, _to date, _tran_id bigint, _tran_code character varying, _book character varying, _reference_number character varying, _statement_reference character varying, _posted_by character varying, _office character varying, _status character varying, _verified_by character varying, _reason character varying)" on the database.
        /// </summary>
        /// <param name="userId">Enter argument value for "_user_id" parameter of the function "transactions.get_journal_view".</param>
        /// <param name="officeId">Enter argument value for "_office_id" parameter of the function "transactions.get_journal_view".</param>
        /// <param name="from">Enter argument value for "_from" parameter of the function "transactions.get_journal_view".</param>
        /// <param name="to">Enter argument value for "_to" parameter of the function "transactions.get_journal_view".</param>
        /// <param name="tranId">Enter argument value for "_tran_id" parameter of the function "transactions.get_journal_view".</param>
        /// <param name="tranCode">Enter argument value for "_tran_code" parameter of the function "transactions.get_journal_view".</param>
        /// <param name="book">Enter argument value for "_book" parameter of the function "transactions.get_journal_view".</param>
        /// <param name="referenceNumber">Enter argument value for "_reference_number" parameter of the function "transactions.get_journal_view".</param>
        /// <param name="statementReference">Enter argument value for "_statement_reference" parameter of the function "transactions.get_journal_view".</param>
        /// <param name="postedBy">Enter argument value for "_posted_by" parameter of the function "transactions.get_journal_view".</param>
        /// <param name="office">Enter argument value for "_office" parameter of the function "transactions.get_journal_view".</param>
        /// <param name="status">Enter argument value for "_status" parameter of the function "transactions.get_journal_view".</param>
        /// <param name="verifiedBy">Enter argument value for "_verified_by" parameter of the function "transactions.get_journal_view".</param>
        /// <param name="reason">Enter argument value for "_reason" parameter of the function "transactions.get_journal_view".</param>
        public GetJournalViewProcedure(int userId, int officeId, DateTime from, DateTime to, long tranId, string tranCode, string book, string referenceNumber, string statementReference, string postedBy, string office, string status, string verifiedBy, string reason)
        {
            this.UserId = userId;
            this.OfficeId = officeId;
            this.From = from;
            this.To = to;
            this.TranId = tranId;
            this.TranCode = tranCode;
            this.Book = book;
            this.ReferenceNumber = referenceNumber;
            this.StatementReference = statementReference;
            this.PostedBy = postedBy;
            this.Office = office;
            this.Status = status;
            this.VerifiedBy = verifiedBy;
            this.Reason = reason;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.get_journal_view".
        /// </summary>
        public IEnumerable<DbGetJournalViewResult> Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"GetJournalViewProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            const string query = "SELECT * FROM transactions.get_journal_view(@0::integer, @1::integer, @2::date, @3::date, @4::bigint, @5::character varying, @6::character varying, @7::character varying, @8::character varying, @9::character varying, @10::character varying, @11::character varying, @12::character varying, @13::character varying);";
            return Factory.Get<DbGetJournalViewResult>(this._Catalog, query, this.UserId, this.OfficeId, this.From, this.To, this.TranId, this.TranCode, this.Book, this.ReferenceNumber, this.StatementReference, this.PostedBy, this.Office, this.Status, this.VerifiedBy, this.Reason);
        }
    }
}