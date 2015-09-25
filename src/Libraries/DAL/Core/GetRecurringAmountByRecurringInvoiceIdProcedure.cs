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
using MixERP.Net.Entities.Core;
using Npgsql;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
namespace MixERP.Net.Schemas.Core.Data
{
    /// <summary>
    /// Prepares, validates, and executes the function "core.get_recurring_amount_by_recurring_invoice_id(_recurring_invoice_id integer)" on the database.
    /// </summary>
    public class GetRecurringAmountByRecurringInvoiceIdProcedure : DbAccess
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_recurring_amount_by_recurring_invoice_id";
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
        /// Maps to "_recurring_invoice_id" argument of the function "core.get_recurring_amount_by_recurring_invoice_id".
        /// </summary>
        public int RecurringInvoiceId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_recurring_amount_by_recurring_invoice_id(_recurring_invoice_id integer)" on the database.
        /// </summary>
        public GetRecurringAmountByRecurringInvoiceIdProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_recurring_amount_by_recurring_invoice_id(_recurring_invoice_id integer)" on the database.
        /// </summary>
        /// <param name="recurringInvoiceId">Enter argument value for "_recurring_invoice_id" parameter of the function "core.get_recurring_amount_by_recurring_invoice_id".</param>
        public GetRecurringAmountByRecurringInvoiceIdProcedure(int recurringInvoiceId)
        {
            this.RecurringInvoiceId = recurringInvoiceId;
        }
        /// <summary>
        /// Prepares and executes the function "core.get_recurring_amount_by_recurring_invoice_id".
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
                    Log.Information("Access to the function \"GetRecurringAmountByRecurringInvoiceIdProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            const string query = "SELECT * FROM core.get_recurring_amount_by_recurring_invoice_id(@0::integer);";
            return Factory.Get<decimal>(this._Catalog, query, this.RecurringInvoiceId).FirstOrDefault();
        }
    }
}