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
using MixERP.Net.Entities.Localization;
using Npgsql;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
namespace MixERP.Net.Schemas.Localization.Data
{
    /// <summary>
    /// Prepares, validates, and executes the function "localization.get_output_for(_culture_code character varying)" on the database.
    /// </summary>
    public class GetOutputForProcedure : DbAccess
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string ObjectNamespace => "localization";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string ObjectName => "get_output_for";
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
        /// Maps to "_culture_code" argument of the function "localization.get_output_for".
        /// </summary>
        public string CultureCode { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "localization.get_output_for(_culture_code character varying)" on the database.
        /// </summary>
        public GetOutputForProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "localization.get_output_for(_culture_code character varying)" on the database.
        /// </summary>
        /// <param name="cultureCode">Enter argument value for "_culture_code" parameter of the function "localization.get_output_for".</param>
        public GetOutputForProcedure(string cultureCode)
        {
            this.CultureCode = cultureCode;
        }
        /// <summary>
        /// Prepares and executes the function "localization.get_output_for".
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
                    Log.Information("Access to the function \"GetOutputForProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            const string query = "SELECT * FROM localization.get_output_for(@0::character varying);";
            return Factory.Scalar<string>(this.Catalog, query, this.CultureCode);
        }
    }
}