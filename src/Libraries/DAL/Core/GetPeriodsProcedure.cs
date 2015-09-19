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
using MixERP.Net.Entities.Core;
using Npgsql;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
namespace MixERP.Net.Schemas.Core.Data
{
    /// <summary>
    /// Prepares, validates, and executes the function "core.get_periods(_date_from date, _date_to date)" on the database.
    /// </summary>
    public class GetPeriodsProcedure : DbAccess
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string ObjectName => "get_periods";
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
        /// Maps to "_date_from" argument of the function "core.get_periods".
        /// </summary>
        public DateTime DateFrom { get; set; }
        /// <summary>
        /// Maps to "_date_to" argument of the function "core.get_periods".
        /// </summary>
        public DateTime DateTo { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_periods(_date_from date, _date_to date)" on the database.
        /// </summary>
        public GetPeriodsProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_periods(_date_from date, _date_to date)" on the database.
        /// </summary>
        /// <param name="dateFrom">Enter argument value for "_date_from" parameter of the function "core.get_periods".</param>
        /// <param name="dateTo">Enter argument value for "_date_to" parameter of the function "core.get_periods".</param>
        public GetPeriodsProcedure(DateTime dateFrom, DateTime dateTo)
        {
            this.DateFrom = dateFrom;
            this.DateTo = dateTo;
        }
        /// <summary>
        /// Prepares and executes the function "core.get_periods".
        /// </summary>
        public IEnumerable<MixERP.Net.Entities.Core.Period[]> Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"GetPeriodsProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            const string query = "SELECT * FROM core.get_periods(@0::date, @1::date);";
            return Factory.Get<MixERP.Net.Entities.Core.Period[]>(this.Catalog, query, this.DateFrom, this.DateTo);
        }
    }
}