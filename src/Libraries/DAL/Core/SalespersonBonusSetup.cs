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
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using Npgsql;
using PetaPoco;
using Serilog;

namespace MixERP.Net.Schemas.Core.Data
{
    /// <summary>
    /// Provides simplified data access features to perform SCRUD operation on the database table "core.salesperson_bonus_setups".
    /// </summary>
    public class SalespersonBonusSetup : DbAccess
    {
        /// <summary>
        /// The schema of this table. Returns literal "core".
        /// </summary>
	    public override string ObjectNamespace => "core";

        /// <summary>
        /// The schema unqualified name of this table. Returns literal "salesperson_bonus_setups".
        /// </summary>
	    public override string ObjectName => "salesperson_bonus_setups";

        /// <summary>
        /// Login id of application user accessing this table.
        /// </summary>
		public long LoginId { get; set; }

        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Performs SQL count on the table "core.salesperson_bonus_setups".
		/// </summary>
		/// <returns>Returns the number of rows of the table "core.salesperson_bonus_setups".</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
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
                    Log.Information("Access to count entity \"SalespersonBonusSetup\" was denied to the user with Login ID {LoginId}", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT COUNT(*) FROM core.salesperson_bonus_setups;";
			return Factory.Scalar<long>(this.Catalog, sql);
		}

		/// <summary>
		/// Executes a select query on the table "core.salesperson_bonus_setups" with a where filter on the column "salesperson_bonus_setup_id" to return a single instance of the "SalespersonBonusSetup" class. 
		/// </summary>
		/// <param name="salespersonBonusSetupId">The column "salesperson_bonus_setup_id" parameter used on where filter.</param>
		/// <returns>Returns a non-live, non-mapped instance of "SalespersonBonusSetup" class mapped to the database row.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public MixERP.Net.Entities.Core.SalespersonBonusSetup Get(int salespersonBonusSetupId)
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
                    Log.Information("Access to the get entity \"SalespersonBonusSetup\" filtered by \"SalespersonBonusSetupId\" with value {SalespersonBonusSetupId} was denied to the user with Login ID {LoginId}", salespersonBonusSetupId, this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT * FROM core.salesperson_bonus_setups WHERE salesperson_bonus_setup_id=@0;";
			return Factory.Get<MixERP.Net.Entities.Core.SalespersonBonusSetup>(this.Catalog, sql, salespersonBonusSetupId).FirstOrDefault();
		}

        /// <summary>
        /// Custom fields are user defined form elements for core.salesperson_bonus_setups.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for the table core.salesperson_bonus_setups</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
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
                    Log.Information("Access to get custom fields for entity \"SalespersonBonusSetup\" was denied to the user with Login ID {LoginId}", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            string sql;
			if (string.IsNullOrWhiteSpace(resourceId))
            {
				sql = "SELECT * FROM core.custom_field_definition_view WHERE table_name='core.salesperson_bonus_setups' ORDER BY field_order;";
				return Factory.Get<PetaPoco.CustomField>(this.Catalog, sql);
            }

            sql = "SELECT * from core.get_custom_field_definition('core.salesperson_bonus_setups'::text, @0::text) ORDER BY field_order;";
			return Factory.Get<PetaPoco.CustomField>(this.Catalog, sql, resourceId);
        }

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding the row collection of core.salesperson_bonus_setups.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for the table core.salesperson_bonus_setups</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
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
                    Log.Information("Access to get display field for entity \"SalespersonBonusSetup\" was denied to the user with Login ID {LoginId}", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT salesperson_bonus_setup_id AS key, salesperson_bonus_setup_id as value FROM core.salesperson_bonus_setups;";
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
		/// Inserts or updates the instance of SalespersonBonusSetup class on the database table "core.salesperson_bonus_setups".
		/// </summary>
		/// <param name="salespersonBonusSetup">The instance of "SalespersonBonusSetup" class to insert or update.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public void AddOrEdit(MixERP.Net.Entities.Core.SalespersonBonusSetup salespersonBonusSetup)
		{
			if(string.IsNullOrWhiteSpace(this.Catalog))
			{
				return;
			}

			if(salespersonBonusSetup.SalespersonBonusSetupId > 0){
				this.Update(salespersonBonusSetup, salespersonBonusSetup.SalespersonBonusSetupId);
				return;
			}
	
			this.Add(salespersonBonusSetup);
		}

		/// <summary>
		/// Inserts the instance of SalespersonBonusSetup class on the database table "core.salesperson_bonus_setups".
		/// </summary>
		/// <param name="salespersonBonusSetup">The instance of "SalespersonBonusSetup" class to insert.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public void Add(MixERP.Net.Entities.Core.SalespersonBonusSetup salespersonBonusSetup)
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
                    Log.Information("Access to add entity \"SalespersonBonusSetup\" was denied to the user with Login ID {LoginId}. {SalespersonBonusSetup}", this.LoginId, salespersonBonusSetup);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			Factory.Insert(this.Catalog, salespersonBonusSetup);
		}

		/// <summary>
		/// Updates the row of the table "core.salesperson_bonus_setups" with an instance of "SalespersonBonusSetup" class against the primary key value.
		/// </summary>
		/// <param name="salespersonBonusSetup">The instance of "SalespersonBonusSetup" class to update.</param>
		/// <param name="salespersonBonusSetupId">The value of the column "salesperson_bonus_setup_id" which will be updated.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public void Update(MixERP.Net.Entities.Core.SalespersonBonusSetup salespersonBonusSetup, int salespersonBonusSetupId)
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
                    Log.Information("Access to edit entity \"SalespersonBonusSetup\" with Primary Key {PrimaryKey} was denied to the user with Login ID {LoginId}. {SalespersonBonusSetup}", salespersonBonusSetupId, this.LoginId, salespersonBonusSetup);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			Factory.Update(this.Catalog, salespersonBonusSetup, salespersonBonusSetupId);
		}

		/// <summary>
		/// Deletes the row of the table "core.salesperson_bonus_setups" against the primary key value.
		/// </summary>
		/// <param name="salespersonBonusSetupId">The value of the column "salesperson_bonus_setup_id" which will be deleted.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public void Delete(int salespersonBonusSetupId)
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
                    Log.Information("Access to delete entity \"SalespersonBonusSetup\" with Primary Key {PrimaryKey} was denied to the user with Login ID {LoginId}.", salespersonBonusSetupId, this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "DELETE FROM core.salesperson_bonus_setups WHERE salesperson_bonus_setup_id=@0;";
			Factory.NonQuery(this.Catalog, sql, salespersonBonusSetupId);
		}

		/// <summary>
		/// Performs a select statement on table "core.salesperson_bonus_setups" producing a paged result of 25.
		/// </summary>
		/// <returns>Returns the first page of collection of "SalespersonBonusSetup" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public IEnumerable<MixERP.Net.Entities.Core.SalespersonBonusSetup> GetPagedResult()
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
                    Log.Information("Access to the first page of the entity \"SalespersonBonusSetup\" was denied to the user with Login ID {LoginId}.", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT * FROM core.salesperson_bonus_setups ORDER BY salesperson_bonus_setup_id LIMIT 25 OFFSET 0;";
			return Factory.Get<MixERP.Net.Entities.Core.SalespersonBonusSetup>(this.Catalog, sql);
		}

		/// <summary>
		/// Performs a select statement on table "core.salesperson_bonus_setups" producing a paged result of 25.
		/// </summary>
		/// <param name="pageNumber">Enter the page number to produce the paged result.</param>
		/// <returns>Returns collection of "SalespersonBonusSetup" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public IEnumerable<MixERP.Net.Entities.Core.SalespersonBonusSetup> GetPagedResult(long pageNumber)
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
                    Log.Information("Access to Page #{Page} of the entity \"SalespersonBonusSetup\" was denied to the user with Login ID {LoginId}.", pageNumber, this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			long offset = (pageNumber -1) * 25;
			const string sql = "SELECT * FROM core.salesperson_bonus_setups ORDER BY salesperson_bonus_setup_id LIMIT 25 OFFSET @0;";
				
			return Factory.Get<MixERP.Net.Entities.Core.SalespersonBonusSetup>(this.Catalog, sql, offset);
		}

        /// <summary>
		/// Performs a filtered select statement on table "core.salesperson_bonus_setups" producing a paged result of 25.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paged result.</param>
        /// <param name="filters">The list of filter conditions.</param>
		/// <returns>Returns collection of "SalespersonBonusSetup" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Core.SalespersonBonusSetup> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            if (string.IsNullOrWhiteSpace(this.Catalog))
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
                    Log.Information("Access to Page #{Page} of the filtered entity \"SalespersonBonusSetup\" was denied to the user with Login ID {LoginId}. Filters: {Filters}.", pageNumber, this.LoginId, filters);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            long offset = (pageNumber - 1) * 25;
            Sql sql = Sql.Builder.Append("SELECT * FROM core.salesperson_bonus_setups WHERE 1 = 1");

            MixERP.Net.EntityParser.Data.Service.AddFilters(ref sql, new MixERP.Net.Entities.Core.SalespersonBonusSetup(), filters);

            sql.OrderBy("salesperson_bonus_setup_id");
            sql.Append("LIMIT @0", 25);
            sql.Append("OFFSET @0", offset);

            return Factory.Get<MixERP.Net.Entities.Core.SalespersonBonusSetup>(this.Catalog, sql);
        }

        public IEnumerable<MixERP.Net.Entities.Core.SalespersonBonusSetup> Get(int[] salespersonBonusSetupIds)
        {
            if (string.IsNullOrWhiteSpace(this.Catalog))
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
                    Log.Information("Access to entity \"SalespersonBonusSetup\" was denied to the user with Login ID {LoginId}. salespersonBonusSetupIds: {salespersonBonusSetupIds}.", this.LoginId, salespersonBonusSetupIds);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

			const string sql = "SELECT * FROM core.salesperson_bonus_setups WHERE salesperson_bonus_setup_id IN (@0);";

            return Factory.Get<MixERP.Net.Entities.Core.SalespersonBonusSetup>(this.Catalog, sql, salespersonBonusSetupIds);
        }
	}
}