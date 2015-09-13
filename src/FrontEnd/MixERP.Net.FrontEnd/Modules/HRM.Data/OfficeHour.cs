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

namespace MixERP.Net.Core.Modules.HRM.Data
{
    /// <summary>
    /// Provides simplified data access features to perform SCRUD operation on the database table "hrm.office_hours".
    /// </summary>
    public class OfficeHour : DbAccess
    {
        /// <summary>
        /// The schema of this table. Returns literal "hrm".
        /// </summary>
	    public override string ObjectNamespace => "hrm";

        /// <summary>
        /// The schema unqualified name of this table. Returns literal "office_hours".
        /// </summary>
	    public override string ObjectName => "office_hours";

        /// <summary>
        /// Login id of application user accessing this table.
        /// </summary>
		public long LoginId { get; set; }

        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Performs SQL count on the table "hrm.office_hours".
		/// </summary>
		/// <returns>Returns the number of rows of the table "hrm.office_hours".</returns>
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
                    Log.Information("Access to count entity \"OfficeHour\" was denied to the user with Login ID {LoginId}", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT COUNT(*) FROM hrm.office_hours;";
			return Factory.Scalar<long>(this.Catalog, sql);
		}

		/// <summary>
		/// Executes a select query on the table "hrm.office_hours" with a where filter on the column "week_day_id" to return a single instance of the "OfficeHour" class. 
		/// </summary>
		/// <param name="weekDayId">The column "week_day_id" parameter used on where filter.</param>
		/// <returns>Returns a non-live, non-mapped instance of "OfficeHour" class mapped to the database row.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public MixERP.Net.Entities.HRM.OfficeHour Get(int weekDayId)
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
                    Log.Information("Access to the get entity \"OfficeHour\" filtered by \"WeekDayId\" with value {WeekDayId} was denied to the user with Login ID {LoginId}", weekDayId, this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT * FROM hrm.office_hours WHERE week_day_id=@0;";
			return Factory.Get<MixERP.Net.Entities.HRM.OfficeHour>(this.Catalog, sql, weekDayId).FirstOrDefault();
		}

        /// <summary>
        /// Custom fields are user defined form elements for hrm.office_hours.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for the table hrm.office_hours</returns>
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
                    Log.Information("Access to get custom fields for entity \"OfficeHour\" was denied to the user with Login ID {LoginId}", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            string sql;
			if (string.IsNullOrWhiteSpace(resourceId))
            {
				sql = "SELECT * FROM core.custom_field_definition_view WHERE table_name='hrm.office_hours' ORDER BY field_order;";
				return Factory.Get<PetaPoco.CustomField>(this.Catalog, sql);
            }

            sql = "SELECT * from core.get_custom_field_definition('hrm.office_hours'::text, @0::text) ORDER BY field_order;";
			return Factory.Get<PetaPoco.CustomField>(this.Catalog, sql, resourceId);
        }

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding the row collection of hrm.office_hours.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for the table hrm.office_hours</returns>
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
                    Log.Information("Access to get display field for entity \"OfficeHour\" was denied to the user with Login ID {LoginId}", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT week_day_id AS key, week_day_id as value FROM hrm.office_hours;";
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
		/// Inserts or updates the instance of OfficeHour class on the database table "hrm.office_hours".
		/// </summary>
		/// <param name="officeHour">The instance of "OfficeHour" class to insert or update.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public void AddOrEdit(MixERP.Net.Entities.HRM.OfficeHour officeHour)
		{
			if(string.IsNullOrWhiteSpace(this.Catalog))
			{
				return;
			}

			if(officeHour.WeekDayId > 0){
				this.Update(officeHour, officeHour.WeekDayId);
				return;
			}
	
			this.Add(officeHour);
		}

		/// <summary>
		/// Inserts the instance of OfficeHour class on the database table "hrm.office_hours".
		/// </summary>
		/// <param name="officeHour">The instance of "OfficeHour" class to insert.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public void Add(MixERP.Net.Entities.HRM.OfficeHour officeHour)
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
                    Log.Information("Access to add entity \"OfficeHour\" was denied to the user with Login ID {LoginId}. {OfficeHour}", this.LoginId, officeHour);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			Factory.Insert(this.Catalog, officeHour);
		}

		/// <summary>
		/// Updates the row of the table "hrm.office_hours" with an instance of "OfficeHour" class against the primary key value.
		/// </summary>
		/// <param name="officeHour">The instance of "OfficeHour" class to update.</param>
		/// <param name="weekDayId">The value of the column "week_day_id" which will be updated.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public void Update(MixERP.Net.Entities.HRM.OfficeHour officeHour, int weekDayId)
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
                    Log.Information("Access to edit entity \"OfficeHour\" with Primary Key {PrimaryKey} was denied to the user with Login ID {LoginId}. {OfficeHour}", weekDayId, this.LoginId, officeHour);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			Factory.Update(this.Catalog, officeHour, weekDayId);
		}

		/// <summary>
		/// Deletes the row of the table "hrm.office_hours" against the primary key value.
		/// </summary>
		/// <param name="weekDayId">The value of the column "week_day_id" which will be deleted.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public void Delete(int weekDayId)
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
                    Log.Information("Access to delete entity \"OfficeHour\" with Primary Key {PrimaryKey} was denied to the user with Login ID {LoginId}.", weekDayId, this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "DELETE FROM hrm.office_hours WHERE week_day_id=@0;";
			Factory.NonQuery(this.Catalog, sql, weekDayId);
		}

		/// <summary>
		/// Performs a select statement on table "hrm.office_hours" producing a paged result of 25.
		/// </summary>
		/// <returns>Returns the first page of collection of "OfficeHour" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public IEnumerable<MixERP.Net.Entities.HRM.OfficeHour> GetPagedResult()
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
                    Log.Information("Access to the first page of the entity \"OfficeHour\" was denied to the user with Login ID {LoginId}.", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT * FROM hrm.office_hours ORDER BY week_day_id LIMIT 25 OFFSET 0;";
			return Factory.Get<MixERP.Net.Entities.HRM.OfficeHour>(this.Catalog, sql);
		}

		/// <summary>
		/// Performs a select statement on table "hrm.office_hours" producing a paged result of 25.
		/// </summary>
		/// <param name="pageNumber">Enter the page number to produce the paged result.</param>
		/// <returns>Returns collection of "OfficeHour" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public IEnumerable<MixERP.Net.Entities.HRM.OfficeHour> GetPagedResult(long pageNumber)
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
                    Log.Information("Access to Page #{Page} of the entity \"OfficeHour\" was denied to the user with Login ID {LoginId}.", pageNumber, this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			long offset = (pageNumber -1) * 25;
			const string sql = "SELECT * FROM hrm.office_hours ORDER BY week_day_id LIMIT 25 OFFSET @0;";
				
			return Factory.Get<MixERP.Net.Entities.HRM.OfficeHour>(this.Catalog, sql, offset);
		}

        /// <summary>
		/// Performs a filtered select statement on table "hrm.office_hours" producing a paged result of 25.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paged result.</param>
        /// <param name="filters">The list of filter conditions.</param>
		/// <returns>Returns collection of "OfficeHour" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.HRM.OfficeHour> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
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
                    Log.Information("Access to Page #{Page} of the filtered entity \"OfficeHour\" was denied to the user with Login ID {LoginId}. Filters: {Filters}.", pageNumber, this.LoginId, filters);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            long offset = (pageNumber - 1) * 25;
            Sql sql = Sql.Builder.Append("SELECT * FROM hrm.office_hours WHERE 1 = 1");

            MixERP.Net.EntityParser.Data.Service.AddFilters(ref sql, new MixERP.Net.Entities.HRM.OfficeHour(), filters);

            sql.OrderBy("week_day_id");
            sql.Append("LIMIT @0", 25);
            sql.Append("OFFSET @0", offset);

            return Factory.Get<MixERP.Net.Entities.HRM.OfficeHour>(this.Catalog, sql);
        }

        public IEnumerable<MixERP.Net.Entities.HRM.OfficeHour> Get(int[] weekDayIds)
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
                    Log.Information("Access to entity \"OfficeHour\" was denied to the user with Login ID {LoginId}. weekDayIds: {weekDayIds}.", this.LoginId, weekDayIds);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

			const string sql = "SELECT * FROM hrm.office_hours WHERE week_day_id IN (@0);";

            return Factory.Get<MixERP.Net.Entities.HRM.OfficeHour>(this.Catalog, sql, weekDayIds);
        }
	}
}