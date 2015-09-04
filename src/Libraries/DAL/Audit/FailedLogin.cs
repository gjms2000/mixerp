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
using System.Collections.Generic;
using System.Data;
using System.Linq;
using MixERP.Net.DbFactory;
using MixERP.Net.Framework;
using Npgsql;
using PetaPoco;
using Serilog;

namespace MixERP.Net.Schemas.Audit.Data
{
    /// <summary>
    /// Provides simplified data access features to perform SCRUD operation on the database table "audit.failed_logins".
    /// </summary>
    public class FailedLogin : DbAccess
    {
        /// <summary>
        /// The schema of this table. Returns literal "audit".
        /// </summary>
	    public override string ObjectNamespace => "audit";

        /// <summary>
        /// The schema unqualified name of this table. Returns literal "failed_logins".
        /// </summary>
	    public override string ObjectName => "failed_logins";

        /// <summary>
        /// Login id of application user accessing this table.
        /// </summary>
		public long LoginId { get; set; }

        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Performs SQL count on the table "audit.failed_logins".
		/// </summary>
		/// <returns>Returns the number of rows of the table "audit.failed_logins".</returns>
		public long Count()
		{
			if(string.IsNullOrWhiteSpace(this.Catalog))
			{
				return 0;
			}

            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Read, this.LoginId, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to count entity \"FailedLogin\" was denied to the user with Login ID {LoginId}", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT COUNT(*) FROM audit.failed_logins;";
			return Factory.Scalar<long>(this.Catalog, sql);
		}

		/// <summary>
		/// Executes a select query on the table "audit.failed_logins" with a where filter on the column "failed_login_id" to return a single instance of the "FailedLogin" class. 
		/// </summary>
		/// <param name="failedLoginId">The column "failed_login_id" parameter used on where filter.</param>
		/// <returns>Returns a non-live, non-mapped instance of "FailedLogin" class mapped to the database row.</returns>
		public MixERP.Net.Entities.Audit.FailedLogin Get(long failedLoginId)
		{
			if(string.IsNullOrWhiteSpace(this.Catalog))
			{
				return null;
			}

            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Read, this.LoginId, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the get entity \"FailedLogin\" filtered by \"FailedLoginId\" with value {FailedLoginId} was denied to the user with Login ID {LoginId}", failedLoginId, this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT * FROM audit.failed_logins WHERE failed_login_id=@0;";
			return Factory.Get<MixERP.Net.Entities.Audit.FailedLogin>(this.Catalog, sql, failedLoginId).FirstOrDefault();
		}

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding the row collection of audit.failed_logins.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for the table audit.failed_logins</returns>
		public IEnumerable<DisplayField> GetDisplayFields()
		{
			List<DisplayField> displayFields = new List<DisplayField>();

			if(string.IsNullOrWhiteSpace(this.Catalog))
			{
				return displayFields;
			}

            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Read, this.LoginId, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to get display field for entity \"FailedLogin\" was denied to the user with Login ID {LoginId}", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT failed_login_id AS key, user_name as value FROM audit.failed_logins;";
			using (NpgsqlCommand command = new NpgsqlCommand(sql))
			{
				using (DataTable table = DbOperation.GetDataTable(this.Catalog, command))
				{
					if (table?.Rows == null || table.Rows.Count == 0)
					{
						return displayFields;
					}

					foreach (DataRow row in table.Rows)
					{
						if (row != null)
						{
							DisplayField displayField = new DisplayField
							{
								Key = row["key"].ToString(),
								Value = row["value"].ToString()
							};

							displayFields.Add(displayField);
						}
					}
				}
			}

			return displayFields;
		}

		/// <summary>
		/// Inserts the instance of FailedLogin class on the database table "audit.failed_logins".
		/// </summary>
		/// <param name="failedLogin">The instance of "FailedLogin" class to insert.</param>
		public void Add(MixERP.Net.Entities.Audit.FailedLogin failedLogin)
		{
			if(string.IsNullOrWhiteSpace(this.Catalog))
			{
				return;
			}

            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Create, this.LoginId, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to add entity \"FailedLogin\" was denied to the user with Login ID {LoginId}. {FailedLogin}", this.LoginId, failedLogin);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			Factory.Insert(this.Catalog, failedLogin);
		}

		/// <summary>
		/// Updates the row of the table "audit.failed_logins" with an instance of "FailedLogin" class against the primary key value.
		/// </summary>
		/// <param name="failedLogin">The instance of "FailedLogin" class to update.</param>
		/// <param name="failedLoginId">The value of the column "failed_login_id" which will be updated.</param>
		public void Update(MixERP.Net.Entities.Audit.FailedLogin failedLogin, long failedLoginId)
		{
			if(string.IsNullOrWhiteSpace(this.Catalog))
			{
				return;
			}

            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Edit, this.LoginId, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to edit entity \"FailedLogin\" with Primary Key {PrimaryKey} was denied to the user with Login ID {LoginId}. {FailedLogin}", failedLoginId, this.LoginId, failedLogin);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			Factory.Update(this.Catalog, failedLogin, failedLoginId);
		}

		/// <summary>
		/// Deletes the row of the table "audit.failed_logins" against the primary key value.
		/// </summary>
		/// <param name="failedLoginId">The value of the column "failed_login_id" which will be deleted.</param>
		public void Delete(long failedLoginId)
		{
			if(string.IsNullOrWhiteSpace(this.Catalog))
			{
				return;
			}

            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Delete, this.LoginId, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to delete entity \"FailedLogin\" with Primary Key {PrimaryKey} was denied to the user with Login ID {LoginId}.", failedLoginId, this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "DELETE FROM audit.failed_logins WHERE failed_login_id=@0;";
			Factory.NonQuery(this.Catalog, sql, failedLoginId);
		}

		/// <summary>
		/// Performs a select statement on table "audit.failed_logins" producing a paged result of 25.
		/// </summary>
		/// <returns>Returns the first page of collection of "FailedLogin" class.</returns>
		public IEnumerable<MixERP.Net.Entities.Audit.FailedLogin> GetPagedResult()
		{
			if(string.IsNullOrWhiteSpace(this.Catalog))
			{
				return null;
			}

            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Read, this.LoginId, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the first page of the entity \"FailedLogin\" was denied to the user with Login ID {LoginId}.", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT * FROM audit.failed_logins ORDER BY failed_login_id LIMIT 25 OFFSET 0;";
			return Factory.Get<MixERP.Net.Entities.Audit.FailedLogin>(this.Catalog, sql);
		}

		/// <summary>
		/// Performs a select statement on table "audit.failed_logins" producing a paged result of 25.
		/// </summary>
		/// <param name="pageNumber">Enter the page number to produce the paged result.</param>
		/// <returns>Returns collection of "FailedLogin" class.</returns>
		public IEnumerable<MixERP.Net.Entities.Audit.FailedLogin> GetPagedResult(long pageNumber)
		{
			if(string.IsNullOrWhiteSpace(this.Catalog))
			{
				return null;
			}

            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Read, this.LoginId, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to Page #{Page} of the entity \"FailedLogin\" was denied to the user with Login ID {LoginId}.", pageNumber, this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			long offset = (pageNumber -1) * 25;
			const string sql = "SELECT * FROM audit.failed_logins ORDER BY failed_login_id LIMIT 25 OFFSET @0;";
				
			return Factory.Get<MixERP.Net.Entities.Audit.FailedLogin>(this.Catalog, sql, offset);
		}
	}
}