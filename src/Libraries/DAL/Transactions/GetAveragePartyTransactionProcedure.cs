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
    /// Prepares, validates, and executes the function "transactions.get_average_party_transaction(party_id bigint, office_id integer)" on the database.
    /// </summary>
    public class GetAveragePartyTransactionProcedure : DbAccess
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string ObjectName => "get_average_party_transaction";
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
        /// Maps to "party_id" argument of the function "transactions.get_average_party_transaction".
        /// </summary>
        public long PartyId { get; set; }
        /// <summary>
        /// Maps to "office_id" argument of the function "transactions.get_average_party_transaction".
        /// </summary>
        public int OfficeId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_average_party_transaction(party_id bigint, office_id integer)" on the database.
        /// </summary>
        public GetAveragePartyTransactionProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_average_party_transaction(party_id bigint, office_id integer)" on the database.
        /// </summary>
        /// <param name="partyId">Enter argument value for "party_id" parameter of the function "transactions.get_average_party_transaction".</param>
        /// <param name="officeId">Enter argument value for "office_id" parameter of the function "transactions.get_average_party_transaction".</param>
        public GetAveragePartyTransactionProcedure(long partyId, int officeId)
        {
            this.PartyId = partyId;
            this.OfficeId = officeId;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.get_average_party_transaction".
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
                    Log.Information("Access to the function \"GetAveragePartyTransactionProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            const string query = "SELECT * FROM transactions.get_average_party_transaction(@0::bigint, @1::integer);";
            return Factory.Get<decimal>(this.Catalog, query, this.PartyId, this.OfficeId).FirstOrDefault();
        }
    }
}