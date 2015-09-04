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

namespace MixERP.Net.Schemas.Core.Data
{
    /// <summary>
    /// Provides simplified data access features to perform SCRUD operation on the database table "core.compound_units".
    /// </summary>
    public class CompoundUnit : DbAccess
    {
        /// <summary>
        /// The schema of this table. Returns literal "core".
        /// </summary>
	    public override string ObjectNamespace => "core";

        /// <summary>
        /// The schema unqualified name of this table. Returns literal "compound_units".
        /// </summary>
	    public override string ObjectName => "compound_units";

        /// <summary>
        /// Login id of application user accessing this table.
        /// </summary>
		public long LoginId { get; set; }

        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Performs SQL count on the table "core.compound_units".
		/// </summary>
		/// <returns>Returns the number of rows of the table "core.compound_units".</returns>
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
                    Log.Information("Access to count entity \"CompoundUnit\" was denied to the user with Login ID {LoginId}", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT COUNT(*) FROM core.compound_units;";
			return Factory.Scalar<long>(this.Catalog, sql);
		}

		/// <summary>
		/// Executes a select query on the table "core.compound_units" with a where filter on the column "compound_unit_id" to return a single instance of the "CompoundUnit" class. 
		/// </summary>
		/// <param name="compoundUnitId">The column "compound_unit_id" parameter used on where filter.</param>
		/// <returns>Returns a non-live, non-mapped instance of "CompoundUnit" class mapped to the database row.</returns>
		public MixERP.Net.Entities.Core.CompoundUnit Get(int compoundUnitId)
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
                    Log.Information("Access to the get entity \"CompoundUnit\" filtered by \"CompoundUnitId\" with value {CompoundUnitId} was denied to the user with Login ID {LoginId}", compoundUnitId, this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT * FROM core.compound_units WHERE compound_unit_id=@0;";
			return Factory.Get<MixERP.Net.Entities.Core.CompoundUnit>(this.Catalog, sql, compoundUnitId).FirstOrDefault();
		}

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding the row collection of core.compound_units.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for the table core.compound_units</returns>
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
                    Log.Information("Access to get display field for entity \"CompoundUnit\" was denied to the user with Login ID {LoginId}", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT compound_unit_id AS key, compound_unit_id as value FROM core.compound_units;";
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
		/// Inserts the instance of CompoundUnit class on the database table "core.compound_units".
		/// </summary>
		/// <param name="compoundUnit">The instance of "CompoundUnit" class to insert.</param>
		public void Add(MixERP.Net.Entities.Core.CompoundUnit compoundUnit)
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
                    Log.Information("Access to add entity \"CompoundUnit\" was denied to the user with Login ID {LoginId}. {CompoundUnit}", this.LoginId, compoundUnit);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			Factory.Insert(this.Catalog, compoundUnit);
		}

		/// <summary>
		/// Updates the row of the table "core.compound_units" with an instance of "CompoundUnit" class against the primary key value.
		/// </summary>
		/// <param name="compoundUnit">The instance of "CompoundUnit" class to update.</param>
		/// <param name="compoundUnitId">The value of the column "compound_unit_id" which will be updated.</param>
		public void Update(MixERP.Net.Entities.Core.CompoundUnit compoundUnit, int compoundUnitId)
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
                    Log.Information("Access to edit entity \"CompoundUnit\" with Primary Key {PrimaryKey} was denied to the user with Login ID {LoginId}. {CompoundUnit}", compoundUnitId, this.LoginId, compoundUnit);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			Factory.Update(this.Catalog, compoundUnit, compoundUnitId);
		}

		/// <summary>
		/// Deletes the row of the table "core.compound_units" against the primary key value.
		/// </summary>
		/// <param name="compoundUnitId">The value of the column "compound_unit_id" which will be deleted.</param>
		public void Delete(int compoundUnitId)
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
                    Log.Information("Access to delete entity \"CompoundUnit\" with Primary Key {PrimaryKey} was denied to the user with Login ID {LoginId}.", compoundUnitId, this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "DELETE FROM core.compound_units WHERE compound_unit_id=@0;";
			Factory.NonQuery(this.Catalog, sql, compoundUnitId);
		}

		/// <summary>
		/// Performs a select statement on table "core.compound_units" producing a paged result of 25.
		/// </summary>
		/// <returns>Returns the first page of collection of "CompoundUnit" class.</returns>
		public IEnumerable<MixERP.Net.Entities.Core.CompoundUnit> GetPagedResult()
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
                    Log.Information("Access to the first page of the entity \"CompoundUnit\" was denied to the user with Login ID {LoginId}.", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT * FROM core.compound_units ORDER BY compound_unit_id LIMIT 25 OFFSET 0;";
			return Factory.Get<MixERP.Net.Entities.Core.CompoundUnit>(this.Catalog, sql);
		}

		/// <summary>
		/// Performs a select statement on table "core.compound_units" producing a paged result of 25.
		/// </summary>
		/// <param name="pageNumber">Enter the page number to produce the paged result.</param>
		/// <returns>Returns collection of "CompoundUnit" class.</returns>
		public IEnumerable<MixERP.Net.Entities.Core.CompoundUnit> GetPagedResult(long pageNumber)
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
                    Log.Information("Access to Page #{Page} of the entity \"CompoundUnit\" was denied to the user with Login ID {LoginId}.", pageNumber, this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			long offset = (pageNumber -1) * 25;
			const string sql = "SELECT * FROM core.compound_units ORDER BY compound_unit_id LIMIT 25 OFFSET @0;";
				
			return Factory.Get<MixERP.Net.Entities.Core.CompoundUnit>(this.Catalog, sql, offset);
		}
	}
}