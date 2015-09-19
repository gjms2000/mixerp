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
    /// Prepares, validates, and executes the function "core.calculate_interest(principal numeric, rate numeric, days integer, round_up integer, num_of_days_in_year integer)" on the database.
    /// </summary>
    public class CalculateInterestProcedure : DbAccess
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string ObjectName => "calculate_interest";
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
        /// Maps to "principal" argument of the function "core.calculate_interest".
        /// </summary>
        public decimal Principal { get; set; }
        /// <summary>
        /// Maps to "rate" argument of the function "core.calculate_interest".
        /// </summary>
        public decimal Rate { get; set; }
        /// <summary>
        /// Maps to "days" argument of the function "core.calculate_interest".
        /// </summary>
        public int Days { get; set; }
        /// <summary>
        /// Maps to "round_up" argument of the function "core.calculate_interest".
        /// </summary>
        public int RoundUp { get; set; }
        /// <summary>
        /// Maps to "num_of_days_in_year" argument of the function "core.calculate_interest".
        /// </summary>
        public int NumOfDaysInYear { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.calculate_interest(principal numeric, rate numeric, days integer, round_up integer, num_of_days_in_year integer)" on the database.
        /// </summary>
        public CalculateInterestProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.calculate_interest(principal numeric, rate numeric, days integer, round_up integer, num_of_days_in_year integer)" on the database.
        /// </summary>
        /// <param name="principal">Enter argument value for "principal" parameter of the function "core.calculate_interest".</param>
        /// <param name="rate">Enter argument value for "rate" parameter of the function "core.calculate_interest".</param>
        /// <param name="days">Enter argument value for "days" parameter of the function "core.calculate_interest".</param>
        /// <param name="roundUp">Enter argument value for "round_up" parameter of the function "core.calculate_interest".</param>
        /// <param name="numOfDaysInYear">Enter argument value for "num_of_days_in_year" parameter of the function "core.calculate_interest".</param>
        public CalculateInterestProcedure(decimal principal, decimal rate, int days, int roundUp, int numOfDaysInYear)
        {
            this.Principal = principal;
            this.Rate = rate;
            this.Days = days;
            this.RoundUp = roundUp;
            this.NumOfDaysInYear = numOfDaysInYear;
        }
        /// <summary>
        /// Prepares and executes the function "core.calculate_interest".
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
                    Log.Information("Access to the function \"CalculateInterestProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            const string query = "SELECT * FROM core.calculate_interest(@0::numeric, @1::numeric, @2::integer, @3::integer, @4::integer);";
            return Factory.Scalar<decimal>(this.Catalog, query, this.Principal, this.Rate, this.Days, this.RoundUp, this.NumOfDaysInYear);
        }
    }
}