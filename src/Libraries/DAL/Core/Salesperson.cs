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
    /// Provides simplified data access features to perform SCRUD operation on the database table "core.salespersons".
    /// </summary>
    public class Salesperson : DbAccess
    {
        /// <summary>
        /// The schema of this table. Returns literal "core".
        /// </summary>
	    public override string ObjectNamespace => "core";

        /// <summary>
        /// The schema unqualified name of this table. Returns literal "salespersons".
        /// </summary>
	    public override string ObjectName => "salespersons";

        /// <summary>
        /// Login id of application user accessing this table.
        /// </summary>
		public long LoginId { get; set; }

        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Performs SQL count on the table "core.salespersons".
		/// </summary>
		/// <returns>Returns the number of rows of the table "core.salespersons".</returns>
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
                    Log.Information("Access to count entity \"Salesperson\" was denied to the user with Login ID {LoginId}", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT COUNT(*) FROM core.salespersons;";
			return Factory.Scalar<long>(this.Catalog, sql);
		}

		/// <summary>
		/// Executes a select query on the table "core.salespersons" with a where filter on the column "salesperson_id" to return a single instance of the "Salesperson" class. 
		/// </summary>
		/// <param name="salespersonId">The column "salesperson_id" parameter used on where filter.</param>
		/// <returns>Returns a non-live, non-mapped instance of "Salesperson" class mapped to the database row.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public MixERP.Net.Entities.Core.Salesperson Get(int salespersonId)
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
                    Log.Information("Access to the get entity \"Salesperson\" filtered by \"SalespersonId\" with value {SalespersonId} was denied to the user with Login ID {LoginId}", salespersonId, this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT * FROM core.salespersons WHERE salesperson_id=@0;";
			return Factory.Get<MixERP.Net.Entities.Core.Salesperson>(this.Catalog, sql, salespersonId).FirstOrDefault();
		}

        /// <summary>
        /// Custom fields are user defined form elements for core.salespersons.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for the table core.salespersons</returns>
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
                    Log.Information("Access to get custom fields for entity \"Salesperson\" was denied to the user with Login ID {LoginId}", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            string sql;
			if (string.IsNullOrWhiteSpace(resourceId))
            {
				sql = "SELECT * FROM core.custom_field_definition_view WHERE table_name='core.salespersons' ORDER BY field_order;";
				return Factory.Get<PetaPoco.CustomField>(this.Catalog, sql);
            }

            sql = "SELECT * from core.get_custom_field_definition('core.salespersons'::text, @0::text) ORDER BY field_order;";
			return Factory.Get<PetaPoco.CustomField>(this.Catalog, sql, resourceId);
        }

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding the row collection of core.salespersons.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for the table core.salespersons</returns>
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
                    Log.Information("Access to get display field for entity \"Salesperson\" was denied to the user with Login ID {LoginId}", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT salesperson_id AS key, salesperson_code || ' (' || salesperson_name || ')' as value FROM core.salespersons;";
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
		/// Inserts or updates the instance of Salesperson class on the database table "core.salespersons".
		/// </summary>
		/// <param name="salesperson">The instance of "Salesperson" class to insert or update.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public void AddOrEdit(MixERP.Net.Entities.Core.Salesperson salesperson)
		{
			if(string.IsNullOrWhiteSpace(this.Catalog))
			{
				return;
			}

			if(salesperson.SalespersonId > 0){
				this.Update(salesperson, salesperson.SalespersonId);
				return;
			}
	
			this.Add(salesperson);
		}

		/// <summary>
		/// Inserts the instance of Salesperson class on the database table "core.salespersons".
		/// </summary>
		/// <param name="salesperson">The instance of "Salesperson" class to insert.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public void Add(MixERP.Net.Entities.Core.Salesperson salesperson)
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
                    Log.Information("Access to add entity \"Salesperson\" was denied to the user with Login ID {LoginId}. {Salesperson}", this.LoginId, salesperson);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			Factory.Insert(this.Catalog, salesperson);
		}

		/// <summary>
		/// Updates the row of the table "core.salespersons" with an instance of "Salesperson" class against the primary key value.
		/// </summary>
		/// <param name="salesperson">The instance of "Salesperson" class to update.</param>
		/// <param name="salespersonId">The value of the column "salesperson_id" which will be updated.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public void Update(MixERP.Net.Entities.Core.Salesperson salesperson, int salespersonId)
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
                    Log.Information("Access to edit entity \"Salesperson\" with Primary Key {PrimaryKey} was denied to the user with Login ID {LoginId}. {Salesperson}", salespersonId, this.LoginId, salesperson);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			Factory.Update(this.Catalog, salesperson, salespersonId);
		}

		/// <summary>
		/// Deletes the row of the table "core.salespersons" against the primary key value.
		/// </summary>
		/// <param name="salespersonId">The value of the column "salesperson_id" which will be deleted.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public void Delete(int salespersonId)
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
                    Log.Information("Access to delete entity \"Salesperson\" with Primary Key {PrimaryKey} was denied to the user with Login ID {LoginId}.", salespersonId, this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "DELETE FROM core.salespersons WHERE salesperson_id=@0;";
			Factory.NonQuery(this.Catalog, sql, salespersonId);
		}

		/// <summary>
		/// Performs a select statement on table "core.salespersons" producing a paged result of 25.
		/// </summary>
		/// <returns>Returns the first page of collection of "Salesperson" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public IEnumerable<MixERP.Net.Entities.Core.Salesperson> GetPagedResult()
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
                    Log.Information("Access to the first page of the entity \"Salesperson\" was denied to the user with Login ID {LoginId}.", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT * FROM core.salespersons ORDER BY salesperson_id LIMIT 25 OFFSET 0;";
			return Factory.Get<MixERP.Net.Entities.Core.Salesperson>(this.Catalog, sql);
		}

		/// <summary>
		/// Performs a select statement on table "core.salespersons" producing a paged result of 25.
		/// </summary>
		/// <param name="pageNumber">Enter the page number to produce the paged result.</param>
		/// <returns>Returns collection of "Salesperson" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public IEnumerable<MixERP.Net.Entities.Core.Salesperson> GetPagedResult(long pageNumber)
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
                    Log.Information("Access to Page #{Page} of the entity \"Salesperson\" was denied to the user with Login ID {LoginId}.", pageNumber, this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			long offset = (pageNumber -1) * 25;
			const string sql = "SELECT * FROM core.salespersons ORDER BY salesperson_id LIMIT 25 OFFSET @0;";
				
			return Factory.Get<MixERP.Net.Entities.Core.Salesperson>(this.Catalog, sql, offset);
		}

        /// <summary>
		/// Performs a filtered select statement on table "core.salespersons" producing a paged result of 25.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paged result.</param>
        /// <param name="filters">The list of filter conditions.</param>
		/// <returns>Returns collection of "Salesperson" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Core.Salesperson> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
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
                    Log.Information("Access to Page #{Page} of the filtered entity \"Salesperson\" was denied to the user with Login ID {LoginId}. Filters: {Filters}.", pageNumber, this.LoginId, filters);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            long offset = (pageNumber - 1) * 25;
            Sql sql = Sql.Builder.Append("SELECT * FROM core.salespersons WHERE 1 = 1");

            MixERP.Net.EntityParser.Data.Service.AddFilters(ref sql, new MixERP.Net.Entities.Core.Salesperson(), filters);

            sql.OrderBy("salesperson_id");
            sql.Append("LIMIT @0", 25);
            sql.Append("OFFSET @0", offset);

            return Factory.Get<MixERP.Net.Entities.Core.Salesperson>(this.Catalog, sql);
        }

        public IEnumerable<MixERP.Net.Entities.Core.Salesperson> Get(int[] salespersonIds)
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
                    Log.Information("Access to entity \"Salesperson\" was denied to the user with Login ID {LoginId}. salespersonIds: {salespersonIds}.", this.LoginId, salespersonIds);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

			const string sql = "SELECT * FROM core.salespersons WHERE salesperson_id IN (@0);";

            return Factory.Get<MixERP.Net.Entities.Core.Salesperson>(this.Catalog, sql, salespersonIds);
        }
	}
}