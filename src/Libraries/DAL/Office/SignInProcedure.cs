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
using MixERP.Net.Entities.Office;
using Npgsql;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
namespace MixERP.Net.Schemas.Office.Data
{
    /// <summary>
    /// Prepares, validates, and executes the function "office.sign_in(office_id integer_strict, user_name text, password text, browser text, ip_address text, remote_user text, culture text, challenge text)" on the database.
    /// </summary>
    public class SignInProcedure : DbAccess
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "office";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "sign_in";
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
        /// Maps to "office_id" argument of the function "office.sign_in".
        /// </summary>
        public int OfficeId { get; set; }
        /// <summary>
        /// Maps to "user_name" argument of the function "office.sign_in".
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// Maps to "password" argument of the function "office.sign_in".
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Maps to "browser" argument of the function "office.sign_in".
        /// </summary>
        public string Browser { get; set; }
        /// <summary>
        /// Maps to "ip_address" argument of the function "office.sign_in".
        /// </summary>
        public string IpAddress { get; set; }
        /// <summary>
        /// Maps to "remote_user" argument of the function "office.sign_in".
        /// </summary>
        public string RemoteUser { get; set; }
        /// <summary>
        /// Maps to "culture" argument of the function "office.sign_in".
        /// </summary>
        public string Culture { get; set; }
        /// <summary>
        /// Maps to "challenge" argument of the function "office.sign_in".
        /// </summary>
        public string Challenge { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "office.sign_in(office_id integer_strict, user_name text, password text, browser text, ip_address text, remote_user text, culture text, challenge text)" on the database.
        /// </summary>
        public SignInProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "office.sign_in(office_id integer_strict, user_name text, password text, browser text, ip_address text, remote_user text, culture text, challenge text)" on the database.
        /// </summary>
        /// <param name="officeId">Enter argument value for "office_id" parameter of the function "office.sign_in".</param>
        /// <param name="userName">Enter argument value for "user_name" parameter of the function "office.sign_in".</param>
        /// <param name="password">Enter argument value for "password" parameter of the function "office.sign_in".</param>
        /// <param name="browser">Enter argument value for "browser" parameter of the function "office.sign_in".</param>
        /// <param name="ipAddress">Enter argument value for "ip_address" parameter of the function "office.sign_in".</param>
        /// <param name="remoteUser">Enter argument value for "remote_user" parameter of the function "office.sign_in".</param>
        /// <param name="culture">Enter argument value for "culture" parameter of the function "office.sign_in".</param>
        /// <param name="challenge">Enter argument value for "challenge" parameter of the function "office.sign_in".</param>
        public SignInProcedure(int officeId, string userName, string password, string browser, string ipAddress, string remoteUser, string culture, string challenge)
        {
            this.OfficeId = officeId;
            this.UserName = userName;
            this.Password = password;
            this.Browser = browser;
            this.IpAddress = ipAddress;
            this.RemoteUser = remoteUser;
            this.Culture = culture;
            this.Challenge = challenge;
        }
        /// <summary>
        /// Prepares and executes the function "office.sign_in".
        /// </summary>
        public IEnumerable<DbSignInResult> Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"SignInProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            const string query = "SELECT * FROM office.sign_in(@0::integer_strict, @1::text, @2::text, @3::text, @4::text, @5::text, @6::text, @7::text);";
            return Factory.Get<DbSignInResult>(this._Catalog, query, this.OfficeId, this.UserName, this.Password, this.Browser, this.IpAddress, this.RemoteUser, this.Culture, this.Challenge);
        }
    }
}