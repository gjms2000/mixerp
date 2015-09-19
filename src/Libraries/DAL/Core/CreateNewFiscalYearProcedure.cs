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
    /// Prepares, validates, and executes the function "core.create_new_fiscal_year(_office_id integer, _user_id integer, _fiscal_year_code character varying, _fiscal_year_name character varying)" on the database.
    /// </summary>
    public class CreateNewFiscalYearProcedure : DbAccess
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string ObjectName => "create_new_fiscal_year";
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
        /// Maps to "_office_id" argument of the function "core.create_new_fiscal_year".
        /// </summary>
        public int OfficeId { get; set; }
        /// <summary>
        /// Maps to "_user_id" argument of the function "core.create_new_fiscal_year".
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Maps to "_fiscal_year_code" argument of the function "core.create_new_fiscal_year".
        /// </summary>
        public string FiscalYearCode { get; set; }
        /// <summary>
        /// Maps to "_fiscal_year_name" argument of the function "core.create_new_fiscal_year".
        /// </summary>
        public string FiscalYearName { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.create_new_fiscal_year(_office_id integer, _user_id integer, _fiscal_year_code character varying, _fiscal_year_name character varying)" on the database.
        /// </summary>
        public CreateNewFiscalYearProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.create_new_fiscal_year(_office_id integer, _user_id integer, _fiscal_year_code character varying, _fiscal_year_name character varying)" on the database.
        /// </summary>
        /// <param name="officeId">Enter argument value for "_office_id" parameter of the function "core.create_new_fiscal_year".</param>
        /// <param name="userId">Enter argument value for "_user_id" parameter of the function "core.create_new_fiscal_year".</param>
        /// <param name="fiscalYearCode">Enter argument value for "_fiscal_year_code" parameter of the function "core.create_new_fiscal_year".</param>
        /// <param name="fiscalYearName">Enter argument value for "_fiscal_year_name" parameter of the function "core.create_new_fiscal_year".</param>
        public CreateNewFiscalYearProcedure(int officeId, int userId, string fiscalYearCode, string fiscalYearName)
        {
            this.OfficeId = officeId;
            this.UserId = userId;
            this.FiscalYearCode = fiscalYearCode;
            this.FiscalYearName = fiscalYearName;
        }
        /// <summary>
        /// Prepares and executes the function "core.create_new_fiscal_year".
        /// </summary>
        public void Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"CreateNewFiscalYearProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            const string query = "SELECT * FROM core.create_new_fiscal_year(@0::integer, @1::integer, @2::character varying, @3::character varying);";
            Factory.NonQuery(this.Catalog, query, this.OfficeId, this.UserId, this.FiscalYearCode, this.FiscalYearName);
        }
    }
}