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

namespace MixERP.Net.Schemas.Policy.Data
{
    /// <summary>
    /// Provides simplified data access features to perform SCRUD operation on the database table "policy.store_policy_details".
    /// </summary>
    public class StorePolicyDetail : DbAccess
    {
        /// <summary>
        /// The schema of this table. Returns literal "policy".
        /// </summary>
	    public override string ObjectNamespace => "policy";

        /// <summary>
        /// The schema unqualified name of this table. Returns literal "store_policy_details".
        /// </summary>
	    public override string ObjectName => "store_policy_details";

        /// <summary>
        /// Login id of application user accessing this table.
        /// </summary>
		public long LoginId { get; set; }

        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Performs SQL count on the table "policy.store_policy_details".
		/// </summary>
		/// <returns>Returns the number of rows of the table "policy.store_policy_details".</returns>
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
                    Log.Information("Access to count entity \"StorePolicyDetail\" was denied to the user with Login ID {LoginId}", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT COUNT(*) FROM policy.store_policy_details;";
			return Factory.Scalar<long>(this.Catalog, sql);
		}

		/// <summary>
		/// Executes a select query on the table "policy.store_policy_details" with a where filter on the column "store_policy_detail_id" to return a single instance of the "StorePolicyDetail" class. 
		/// </summary>
		/// <param name="storePolicyDetailId">The column "store_policy_detail_id" parameter used on where filter.</param>
		/// <returns>Returns a non-live, non-mapped instance of "StorePolicyDetail" class mapped to the database row.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public MixERP.Net.Entities.Policy.StorePolicyDetail Get(long storePolicyDetailId)
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
                    Log.Information("Access to the get entity \"StorePolicyDetail\" filtered by \"StorePolicyDetailId\" with value {StorePolicyDetailId} was denied to the user with Login ID {LoginId}", storePolicyDetailId, this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT * FROM policy.store_policy_details WHERE store_policy_detail_id=@0;";
			return Factory.Get<MixERP.Net.Entities.Policy.StorePolicyDetail>(this.Catalog, sql, storePolicyDetailId).FirstOrDefault();
		}

        /// <summary>
        /// Custom fields are user defined form elements for policy.store_policy_details.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for the table policy.store_policy_details</returns>
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
                    Log.Information("Access to get custom fields for entity \"StorePolicyDetail\" was denied to the user with Login ID {LoginId}", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            string sql;
			if (string.IsNullOrWhiteSpace(resourceId))
            {
				sql = "SELECT * FROM core.custom_field_definition_view WHERE table_name='policy.store_policy_details' ORDER BY field_order;";
				return Factory.Get<PetaPoco.CustomField>(this.Catalog, sql);
            }

            sql = "SELECT * from core.get_custom_field_definition('policy.store_policy_details'::text, @0::text) ORDER BY field_order;";
			return Factory.Get<PetaPoco.CustomField>(this.Catalog, sql, resourceId);
        }

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding the row collection of policy.store_policy_details.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for the table policy.store_policy_details</returns>
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
                    Log.Information("Access to get display field for entity \"StorePolicyDetail\" was denied to the user with Login ID {LoginId}", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT store_policy_detail_id AS key, store_policy_detail_id as value FROM policy.store_policy_details;";
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
		/// Inserts or updates the instance of StorePolicyDetail class on the database table "policy.store_policy_details".
		/// </summary>
		/// <param name="storePolicyDetail">The instance of "StorePolicyDetail" class to insert or update.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public void AddOrEdit(MixERP.Net.Entities.Policy.StorePolicyDetail storePolicyDetail)
		{
			if(string.IsNullOrWhiteSpace(this.Catalog))
			{
				return;
			}

			if(storePolicyDetail.StorePolicyDetailId > 0){
				this.Update(storePolicyDetail, storePolicyDetail.StorePolicyDetailId);
				return;
			}
	
			this.Add(storePolicyDetail);
		}

		/// <summary>
		/// Inserts the instance of StorePolicyDetail class on the database table "policy.store_policy_details".
		/// </summary>
		/// <param name="storePolicyDetail">The instance of "StorePolicyDetail" class to insert.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public void Add(MixERP.Net.Entities.Policy.StorePolicyDetail storePolicyDetail)
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
                    Log.Information("Access to add entity \"StorePolicyDetail\" was denied to the user with Login ID {LoginId}. {StorePolicyDetail}", this.LoginId, storePolicyDetail);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			Factory.Insert(this.Catalog, storePolicyDetail);
		}

		/// <summary>
		/// Updates the row of the table "policy.store_policy_details" with an instance of "StorePolicyDetail" class against the primary key value.
		/// </summary>
		/// <param name="storePolicyDetail">The instance of "StorePolicyDetail" class to update.</param>
		/// <param name="storePolicyDetailId">The value of the column "store_policy_detail_id" which will be updated.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public void Update(MixERP.Net.Entities.Policy.StorePolicyDetail storePolicyDetail, long storePolicyDetailId)
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
                    Log.Information("Access to edit entity \"StorePolicyDetail\" with Primary Key {PrimaryKey} was denied to the user with Login ID {LoginId}. {StorePolicyDetail}", storePolicyDetailId, this.LoginId, storePolicyDetail);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			Factory.Update(this.Catalog, storePolicyDetail, storePolicyDetailId);
		}

		/// <summary>
		/// Deletes the row of the table "policy.store_policy_details" against the primary key value.
		/// </summary>
		/// <param name="storePolicyDetailId">The value of the column "store_policy_detail_id" which will be deleted.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public void Delete(long storePolicyDetailId)
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
                    Log.Information("Access to delete entity \"StorePolicyDetail\" with Primary Key {PrimaryKey} was denied to the user with Login ID {LoginId}.", storePolicyDetailId, this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "DELETE FROM policy.store_policy_details WHERE store_policy_detail_id=@0;";
			Factory.NonQuery(this.Catalog, sql, storePolicyDetailId);
		}

		/// <summary>
		/// Performs a select statement on table "policy.store_policy_details" producing a paged result of 25.
		/// </summary>
		/// <returns>Returns the first page of collection of "StorePolicyDetail" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public IEnumerable<MixERP.Net.Entities.Policy.StorePolicyDetail> GetPagedResult()
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
                    Log.Information("Access to the first page of the entity \"StorePolicyDetail\" was denied to the user with Login ID {LoginId}.", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT * FROM policy.store_policy_details ORDER BY store_policy_detail_id LIMIT 25 OFFSET 0;";
			return Factory.Get<MixERP.Net.Entities.Policy.StorePolicyDetail>(this.Catalog, sql);
		}

		/// <summary>
		/// Performs a select statement on table "policy.store_policy_details" producing a paged result of 25.
		/// </summary>
		/// <param name="pageNumber">Enter the page number to produce the paged result.</param>
		/// <returns>Returns collection of "StorePolicyDetail" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public IEnumerable<MixERP.Net.Entities.Policy.StorePolicyDetail> GetPagedResult(long pageNumber)
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
                    Log.Information("Access to Page #{Page} of the entity \"StorePolicyDetail\" was denied to the user with Login ID {LoginId}.", pageNumber, this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			long offset = (pageNumber -1) * 25;
			const string sql = "SELECT * FROM policy.store_policy_details ORDER BY store_policy_detail_id LIMIT 25 OFFSET @0;";
				
			return Factory.Get<MixERP.Net.Entities.Policy.StorePolicyDetail>(this.Catalog, sql, offset);
		}

        /// <summary>
		/// Performs a filtered select statement on table "policy.store_policy_details" producing a paged result of 25.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paged result.</param>
        /// <param name="filters">The list of filter conditions.</param>
		/// <returns>Returns collection of "StorePolicyDetail" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Policy.StorePolicyDetail> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
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
                    Log.Information("Access to Page #{Page} of the filtered entity \"StorePolicyDetail\" was denied to the user with Login ID {LoginId}. Filters: {Filters}.", pageNumber, this.LoginId, filters);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            long offset = (pageNumber - 1) * 25;
            Sql sql = Sql.Builder.Append("SELECT * FROM policy.store_policy_details WHERE 1 = 1");

            MixERP.Net.EntityParser.Data.Service.AddFilters(ref sql, new MixERP.Net.Entities.Policy.StorePolicyDetail(), filters);

            sql.OrderBy("store_policy_detail_id");
            sql.Append("LIMIT @0", 25);
            sql.Append("OFFSET @0", offset);

            return Factory.Get<MixERP.Net.Entities.Policy.StorePolicyDetail>(this.Catalog, sql);
        }

        public IEnumerable<MixERP.Net.Entities.Policy.StorePolicyDetail> Get(long[] storePolicyDetailIds)
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
                    Log.Information("Access to entity \"StorePolicyDetail\" was denied to the user with Login ID {LoginId}. storePolicyDetailIds: {storePolicyDetailIds}.", this.LoginId, storePolicyDetailIds);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

			const string sql = "SELECT * FROM policy.store_policy_details WHERE store_policy_detail_id IN (@0);";

            return Factory.Get<MixERP.Net.Entities.Policy.StorePolicyDetail>(this.Catalog, sql, storePolicyDetailIds);
        }

	}
}