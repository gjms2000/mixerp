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

namespace MixERP.Net.Schemas.Office.Data
{
    /// <summary>
    /// Provides simplified data access features to perform SCRUD operation on the database table "office.configuration".
    /// </summary>
    public class Configuration : DbAccess
    {
        /// <summary>
        /// The schema of this table. Returns literal "office".
        /// </summary>
	    public override string ObjectNamespace => "office";

        /// <summary>
        /// The schema unqualified name of this table. Returns literal "configuration".
        /// </summary>
	    public override string ObjectName => "configuration";

        /// <summary>
        /// Login id of application user accessing this table.
        /// </summary>
		public long LoginId { get; set; }

        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Performs SQL count on the table "office.configuration".
		/// </summary>
		/// <returns>Returns the number of rows of the table "office.configuration".</returns>
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
                    Log.Information("Access to count entity \"Configuration\" was denied to the user with Login ID {LoginId}", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT COUNT(*) FROM office.configuration;";
			return Factory.Scalar<long>(this.Catalog, sql);
		}

		/// <summary>
		/// Executes a select query on the table "office.configuration" with a where filter on the column "configuration_id" to return a single instance of the "Configuration" class. 
		/// </summary>
		/// <param name="configurationId">The column "configuration_id" parameter used on where filter.</param>
		/// <returns>Returns a non-live, non-mapped instance of "Configuration" class mapped to the database row.</returns>
		public MixERP.Net.Entities.Office.Configuration Get(int configurationId)
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
                    Log.Information("Access to the get entity \"Configuration\" filtered by \"ConfigurationId\" with value {ConfigurationId} was denied to the user with Login ID {LoginId}", configurationId, this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT * FROM office.configuration WHERE configuration_id=@0;";
			return Factory.Get<MixERP.Net.Entities.Office.Configuration>(this.Catalog, sql, configurationId).FirstOrDefault();
		}

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding the row collection of office.configuration.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for the table office.configuration</returns>
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
                    Log.Information("Access to get display field for entity \"Configuration\" was denied to the user with Login ID {LoginId}", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT configuration_id AS key, configuration_id as value FROM office.configuration;";
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
		/// Inserts the instance of Configuration class on the database table "office.configuration".
		/// </summary>
		/// <param name="configuration">The instance of "Configuration" class to insert.</param>
		public void Add(MixERP.Net.Entities.Office.Configuration configuration)
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
                    Log.Information("Access to add entity \"Configuration\" was denied to the user with Login ID {LoginId}. {Configuration}", this.LoginId, configuration);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			Factory.Insert(this.Catalog, configuration);
		}

		/// <summary>
		/// Updates the row of the table "office.configuration" with an instance of "Configuration" class against the primary key value.
		/// </summary>
		/// <param name="configuration">The instance of "Configuration" class to update.</param>
		/// <param name="configurationId">The value of the column "configuration_id" which will be updated.</param>
		public void Update(MixERP.Net.Entities.Office.Configuration configuration, int configurationId)
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
                    Log.Information("Access to edit entity \"Configuration\" with Primary Key {PrimaryKey} was denied to the user with Login ID {LoginId}. {Configuration}", configurationId, this.LoginId, configuration);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			Factory.Update(this.Catalog, configuration, configurationId);
		}

		/// <summary>
		/// Deletes the row of the table "office.configuration" against the primary key value.
		/// </summary>
		/// <param name="configurationId">The value of the column "configuration_id" which will be deleted.</param>
		public void Delete(int configurationId)
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
                    Log.Information("Access to delete entity \"Configuration\" with Primary Key {PrimaryKey} was denied to the user with Login ID {LoginId}.", configurationId, this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "DELETE FROM office.configuration WHERE configuration_id=@0;";
			Factory.NonQuery(this.Catalog, sql, configurationId);
		}

		/// <summary>
		/// Performs a select statement on table "office.configuration" producing a paged result of 25.
		/// </summary>
		/// <returns>Returns the first page of collection of "Configuration" class.</returns>
		public IEnumerable<MixERP.Net.Entities.Office.Configuration> GetPagedResult()
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
                    Log.Information("Access to the first page of the entity \"Configuration\" was denied to the user with Login ID {LoginId}.", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT * FROM office.configuration ORDER BY configuration_id LIMIT 25 OFFSET 0;";
			return Factory.Get<MixERP.Net.Entities.Office.Configuration>(this.Catalog, sql);
		}

		/// <summary>
		/// Performs a select statement on table "office.configuration" producing a paged result of 25.
		/// </summary>
		/// <param name="pageNumber">Enter the page number to produce the paged result.</param>
		/// <returns>Returns collection of "Configuration" class.</returns>
		public IEnumerable<MixERP.Net.Entities.Office.Configuration> GetPagedResult(long pageNumber)
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
                    Log.Information("Access to Page #{Page} of the entity \"Configuration\" was denied to the user with Login ID {LoginId}.", pageNumber, this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			long offset = (pageNumber -1) * 25;
			const string sql = "SELECT * FROM office.configuration ORDER BY configuration_id LIMIT 25 OFFSET @0;";
				
			return Factory.Get<MixERP.Net.Entities.Office.Configuration>(this.Catalog, sql, offset);
		}
	}
}