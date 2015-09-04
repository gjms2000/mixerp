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
    /// Provides simplified data access features to perform SCRUD operation on the database table "core.custom_field_data_types".
    /// </summary>
    public class CustomFieldDataType : DbAccess
    {
        /// <summary>
        /// The schema of this table. Returns literal "core".
        /// </summary>
	    public override string ObjectNamespace => "core";

        /// <summary>
        /// The schema unqualified name of this table. Returns literal "custom_field_data_types".
        /// </summary>
	    public override string ObjectName => "custom_field_data_types";

        /// <summary>
        /// Login id of application user accessing this table.
        /// </summary>
		public long LoginId { get; set; }

        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Performs SQL count on the table "core.custom_field_data_types".
		/// </summary>
		/// <returns>Returns the number of rows of the table "core.custom_field_data_types".</returns>
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
                    Log.Information("Access to count entity \"CustomFieldDataType\" was denied to the user with Login ID {LoginId}", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT COUNT(*) FROM core.custom_field_data_types;";
			return Factory.Scalar<long>(this.Catalog, sql);
		}

		/// <summary>
		/// Executes a select query on the table "core.custom_field_data_types" with a where filter on the column "data_type" to return a single instance of the "CustomFieldDataType" class. 
		/// </summary>
		/// <param name="dataType">The column "data_type" parameter used on where filter.</param>
		/// <returns>Returns a non-live, non-mapped instance of "CustomFieldDataType" class mapped to the database row.</returns>
		public MixERP.Net.Entities.Core.CustomFieldDataType Get(string dataType)
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
                    Log.Information("Access to the get entity \"CustomFieldDataType\" filtered by \"DataType\" with value {DataType} was denied to the user with Login ID {LoginId}", dataType, this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT * FROM core.custom_field_data_types WHERE data_type=@0;";
			return Factory.Get<MixERP.Net.Entities.Core.CustomFieldDataType>(this.Catalog, sql, dataType).FirstOrDefault();
		}

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding the row collection of core.custom_field_data_types.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for the table core.custom_field_data_types</returns>
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
                    Log.Information("Access to get display field for entity \"CustomFieldDataType\" was denied to the user with Login ID {LoginId}", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT data_type AS key, data_type as value FROM core.custom_field_data_types;";
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
		/// Inserts the instance of CustomFieldDataType class on the database table "core.custom_field_data_types".
		/// </summary>
		/// <param name="customFieldDataType">The instance of "CustomFieldDataType" class to insert.</param>
		public void Add(MixERP.Net.Entities.Core.CustomFieldDataType customFieldDataType)
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
                    Log.Information("Access to add entity \"CustomFieldDataType\" was denied to the user with Login ID {LoginId}. {CustomFieldDataType}", this.LoginId, customFieldDataType);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			Factory.Insert(this.Catalog, customFieldDataType);
		}

		/// <summary>
		/// Updates the row of the table "core.custom_field_data_types" with an instance of "CustomFieldDataType" class against the primary key value.
		/// </summary>
		/// <param name="customFieldDataType">The instance of "CustomFieldDataType" class to update.</param>
		/// <param name="dataType">The value of the column "data_type" which will be updated.</param>
		public void Update(MixERP.Net.Entities.Core.CustomFieldDataType customFieldDataType, string dataType)
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
                    Log.Information("Access to edit entity \"CustomFieldDataType\" with Primary Key {PrimaryKey} was denied to the user with Login ID {LoginId}. {CustomFieldDataType}", dataType, this.LoginId, customFieldDataType);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			Factory.Update(this.Catalog, customFieldDataType, dataType);
		}

		/// <summary>
		/// Deletes the row of the table "core.custom_field_data_types" against the primary key value.
		/// </summary>
		/// <param name="dataType">The value of the column "data_type" which will be deleted.</param>
		public void Delete(string dataType)
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
                    Log.Information("Access to delete entity \"CustomFieldDataType\" with Primary Key {PrimaryKey} was denied to the user with Login ID {LoginId}.", dataType, this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "DELETE FROM core.custom_field_data_types WHERE data_type=@0;";
			Factory.NonQuery(this.Catalog, sql, dataType);
		}

		/// <summary>
		/// Performs a select statement on table "core.custom_field_data_types" producing a paged result of 25.
		/// </summary>
		/// <returns>Returns the first page of collection of "CustomFieldDataType" class.</returns>
		public IEnumerable<MixERP.Net.Entities.Core.CustomFieldDataType> GetPagedResult()
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
                    Log.Information("Access to the first page of the entity \"CustomFieldDataType\" was denied to the user with Login ID {LoginId}.", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT * FROM core.custom_field_data_types ORDER BY data_type LIMIT 25 OFFSET 0;";
			return Factory.Get<MixERP.Net.Entities.Core.CustomFieldDataType>(this.Catalog, sql);
		}

		/// <summary>
		/// Performs a select statement on table "core.custom_field_data_types" producing a paged result of 25.
		/// </summary>
		/// <param name="pageNumber">Enter the page number to produce the paged result.</param>
		/// <returns>Returns collection of "CustomFieldDataType" class.</returns>
		public IEnumerable<MixERP.Net.Entities.Core.CustomFieldDataType> GetPagedResult(long pageNumber)
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
                    Log.Information("Access to Page #{Page} of the entity \"CustomFieldDataType\" was denied to the user with Login ID {LoginId}.", pageNumber, this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			long offset = (pageNumber -1) * 25;
			const string sql = "SELECT * FROM core.custom_field_data_types ORDER BY data_type LIMIT 25 OFFSET @0;";
				
			return Factory.Get<MixERP.Net.Entities.Core.CustomFieldDataType>(this.Catalog, sql, offset);
		}
	}
}