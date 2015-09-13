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

namespace MixERP.Net.Schemas.Transactions.Data
{
    /// <summary>
    /// Provides simplified data access features to perform SCRUD operation on the database table "transactions.non_gl_stock_master_relations".
    /// </summary>
    public class NonGlStockMasterRelation : DbAccess
    {
        /// <summary>
        /// The schema of this table. Returns literal "transactions".
        /// </summary>
	    public override string ObjectNamespace => "transactions";

        /// <summary>
        /// The schema unqualified name of this table. Returns literal "non_gl_stock_master_relations".
        /// </summary>
	    public override string ObjectName => "non_gl_stock_master_relations";

        /// <summary>
        /// Login id of application user accessing this table.
        /// </summary>
		public long LoginId { get; set; }

        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Performs SQL count on the table "transactions.non_gl_stock_master_relations".
		/// </summary>
		/// <returns>Returns the number of rows of the table "transactions.non_gl_stock_master_relations".</returns>
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
                    Log.Information("Access to count entity \"NonGlStockMasterRelation\" was denied to the user with Login ID {LoginId}", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT COUNT(*) FROM transactions.non_gl_stock_master_relations;";
			return Factory.Scalar<long>(this.Catalog, sql);
		}

		/// <summary>
		/// Executes a select query on the table "transactions.non_gl_stock_master_relations" with a where filter on the column "non_gl_stock_master_relation_id" to return a single instance of the "NonGlStockMasterRelation" class. 
		/// </summary>
		/// <param name="nonGlStockMasterRelationId">The column "non_gl_stock_master_relation_id" parameter used on where filter.</param>
		/// <returns>Returns a non-live, non-mapped instance of "NonGlStockMasterRelation" class mapped to the database row.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public MixERP.Net.Entities.Transactions.NonGlStockMasterRelation Get(long nonGlStockMasterRelationId)
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
                    Log.Information("Access to the get entity \"NonGlStockMasterRelation\" filtered by \"NonGlStockMasterRelationId\" with value {NonGlStockMasterRelationId} was denied to the user with Login ID {LoginId}", nonGlStockMasterRelationId, this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT * FROM transactions.non_gl_stock_master_relations WHERE non_gl_stock_master_relation_id=@0;";
			return Factory.Get<MixERP.Net.Entities.Transactions.NonGlStockMasterRelation>(this.Catalog, sql, nonGlStockMasterRelationId).FirstOrDefault();
		}

        /// <summary>
        /// Custom fields are user defined form elements for transactions.non_gl_stock_master_relations.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for the table transactions.non_gl_stock_master_relations</returns>
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
                    Log.Information("Access to get custom fields for entity \"NonGlStockMasterRelation\" was denied to the user with Login ID {LoginId}", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            string sql;
			if (string.IsNullOrWhiteSpace(resourceId))
            {
				sql = "SELECT * FROM core.custom_field_definition_view WHERE table_name='transactions.non_gl_stock_master_relations' ORDER BY field_order;";
				return Factory.Get<PetaPoco.CustomField>(this.Catalog, sql);
            }

            sql = "SELECT * from core.get_custom_field_definition('transactions.non_gl_stock_master_relations'::text, @0::text) ORDER BY field_order;";
			return Factory.Get<PetaPoco.CustomField>(this.Catalog, sql, resourceId);
        }

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding the row collection of transactions.non_gl_stock_master_relations.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for the table transactions.non_gl_stock_master_relations</returns>
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
                    Log.Information("Access to get display field for entity \"NonGlStockMasterRelation\" was denied to the user with Login ID {LoginId}", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT non_gl_stock_master_relation_id AS key, non_gl_stock_master_relation_id as value FROM transactions.non_gl_stock_master_relations;";
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
		/// Inserts or updates the instance of NonGlStockMasterRelation class on the database table "transactions.non_gl_stock_master_relations".
		/// </summary>
		/// <param name="nonGlStockMasterRelation">The instance of "NonGlStockMasterRelation" class to insert or update.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public void AddOrEdit(MixERP.Net.Entities.Transactions.NonGlStockMasterRelation nonGlStockMasterRelation)
		{
			if(string.IsNullOrWhiteSpace(this.Catalog))
			{
				return;
			}

			if(nonGlStockMasterRelation.NonGlStockMasterRelationId > 0){
				this.Update(nonGlStockMasterRelation, nonGlStockMasterRelation.NonGlStockMasterRelationId);
				return;
			}
	
			this.Add(nonGlStockMasterRelation);
		}

		/// <summary>
		/// Inserts the instance of NonGlStockMasterRelation class on the database table "transactions.non_gl_stock_master_relations".
		/// </summary>
		/// <param name="nonGlStockMasterRelation">The instance of "NonGlStockMasterRelation" class to insert.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public void Add(MixERP.Net.Entities.Transactions.NonGlStockMasterRelation nonGlStockMasterRelation)
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
                    Log.Information("Access to add entity \"NonGlStockMasterRelation\" was denied to the user with Login ID {LoginId}. {NonGlStockMasterRelation}", this.LoginId, nonGlStockMasterRelation);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			Factory.Insert(this.Catalog, nonGlStockMasterRelation);
		}

		/// <summary>
		/// Updates the row of the table "transactions.non_gl_stock_master_relations" with an instance of "NonGlStockMasterRelation" class against the primary key value.
		/// </summary>
		/// <param name="nonGlStockMasterRelation">The instance of "NonGlStockMasterRelation" class to update.</param>
		/// <param name="nonGlStockMasterRelationId">The value of the column "non_gl_stock_master_relation_id" which will be updated.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public void Update(MixERP.Net.Entities.Transactions.NonGlStockMasterRelation nonGlStockMasterRelation, long nonGlStockMasterRelationId)
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
                    Log.Information("Access to edit entity \"NonGlStockMasterRelation\" with Primary Key {PrimaryKey} was denied to the user with Login ID {LoginId}. {NonGlStockMasterRelation}", nonGlStockMasterRelationId, this.LoginId, nonGlStockMasterRelation);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			Factory.Update(this.Catalog, nonGlStockMasterRelation, nonGlStockMasterRelationId);
		}

		/// <summary>
		/// Deletes the row of the table "transactions.non_gl_stock_master_relations" against the primary key value.
		/// </summary>
		/// <param name="nonGlStockMasterRelationId">The value of the column "non_gl_stock_master_relation_id" which will be deleted.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public void Delete(long nonGlStockMasterRelationId)
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
                    Log.Information("Access to delete entity \"NonGlStockMasterRelation\" with Primary Key {PrimaryKey} was denied to the user with Login ID {LoginId}.", nonGlStockMasterRelationId, this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "DELETE FROM transactions.non_gl_stock_master_relations WHERE non_gl_stock_master_relation_id=@0;";
			Factory.NonQuery(this.Catalog, sql, nonGlStockMasterRelationId);
		}

		/// <summary>
		/// Performs a select statement on table "transactions.non_gl_stock_master_relations" producing a paged result of 25.
		/// </summary>
		/// <returns>Returns the first page of collection of "NonGlStockMasterRelation" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockMasterRelation> GetPagedResult()
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
                    Log.Information("Access to the first page of the entity \"NonGlStockMasterRelation\" was denied to the user with Login ID {LoginId}.", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT * FROM transactions.non_gl_stock_master_relations ORDER BY non_gl_stock_master_relation_id LIMIT 25 OFFSET 0;";
			return Factory.Get<MixERP.Net.Entities.Transactions.NonGlStockMasterRelation>(this.Catalog, sql);
		}

		/// <summary>
		/// Performs a select statement on table "transactions.non_gl_stock_master_relations" producing a paged result of 25.
		/// </summary>
		/// <param name="pageNumber">Enter the page number to produce the paged result.</param>
		/// <returns>Returns collection of "NonGlStockMasterRelation" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockMasterRelation> GetPagedResult(long pageNumber)
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
                    Log.Information("Access to Page #{Page} of the entity \"NonGlStockMasterRelation\" was denied to the user with Login ID {LoginId}.", pageNumber, this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			long offset = (pageNumber -1) * 25;
			const string sql = "SELECT * FROM transactions.non_gl_stock_master_relations ORDER BY non_gl_stock_master_relation_id LIMIT 25 OFFSET @0;";
				
			return Factory.Get<MixERP.Net.Entities.Transactions.NonGlStockMasterRelation>(this.Catalog, sql, offset);
		}

        /// <summary>
		/// Performs a filtered select statement on table "transactions.non_gl_stock_master_relations" producing a paged result of 25.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paged result.</param>
        /// <param name="filters">The list of filter conditions.</param>
		/// <returns>Returns collection of "NonGlStockMasterRelation" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockMasterRelation> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
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
                    Log.Information("Access to Page #{Page} of the filtered entity \"NonGlStockMasterRelation\" was denied to the user with Login ID {LoginId}. Filters: {Filters}.", pageNumber, this.LoginId, filters);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            long offset = (pageNumber - 1) * 25;
            Sql sql = Sql.Builder.Append("SELECT * FROM transactions.non_gl_stock_master_relations WHERE 1 = 1");

            MixERP.Net.EntityParser.Data.Service.AddFilters(ref sql, new MixERP.Net.Entities.Transactions.NonGlStockMasterRelation(), filters);

            sql.OrderBy("non_gl_stock_master_relation_id");
            sql.Append("LIMIT @0", 25);
            sql.Append("OFFSET @0", offset);

            return Factory.Get<MixERP.Net.Entities.Transactions.NonGlStockMasterRelation>(this.Catalog, sql);
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockMasterRelation> Get(long[] nonGlStockMasterRelationIds)
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
                    Log.Information("Access to entity \"NonGlStockMasterRelation\" was denied to the user with Login ID {LoginId}. nonGlStockMasterRelationIds: {nonGlStockMasterRelationIds}.", this.LoginId, nonGlStockMasterRelationIds);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

			const string sql = "SELECT * FROM transactions.non_gl_stock_master_relations WHERE non_gl_stock_master_relation_id IN (@0);";

            return Factory.Get<MixERP.Net.Entities.Transactions.NonGlStockMasterRelation>(this.Catalog, sql, nonGlStockMasterRelationIds);
        }
	}
}