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
    /// Provides simplified data access features to perform SCRUD operation on the database table "transactions.non_gl_stock_tax_details".
    /// </summary>
    public class NonGlStockTaxDetail : DbAccess
    {
        /// <summary>
        /// The schema of this table. Returns literal "transactions".
        /// </summary>
	    public override string ObjectNamespace => "transactions";

        /// <summary>
        /// The schema unqualified name of this table. Returns literal "non_gl_stock_tax_details".
        /// </summary>
	    public override string ObjectName => "non_gl_stock_tax_details";

        /// <summary>
        /// Login id of application user accessing this table.
        /// </summary>
		public long LoginId { get; set; }

        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Performs SQL count on the table "transactions.non_gl_stock_tax_details".
		/// </summary>
		/// <returns>Returns the number of rows of the table "transactions.non_gl_stock_tax_details".</returns>
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
                    Log.Information("Access to count entity \"NonGlStockTaxDetail\" was denied to the user with Login ID {LoginId}", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT COUNT(*) FROM transactions.non_gl_stock_tax_details;";
			return Factory.Scalar<long>(this.Catalog, sql);
		}

		/// <summary>
		/// Executes a select query on the table "transactions.non_gl_stock_tax_details" with a where filter on the column "non_gl_stock_tax_detail_id" to return a single instance of the "NonGlStockTaxDetail" class. 
		/// </summary>
		/// <param name="nonGlStockTaxDetailId">The column "non_gl_stock_tax_detail_id" parameter used on where filter.</param>
		/// <returns>Returns a non-live, non-mapped instance of "NonGlStockTaxDetail" class mapped to the database row.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public MixERP.Net.Entities.Transactions.NonGlStockTaxDetail Get(long nonGlStockTaxDetailId)
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
                    Log.Information("Access to the get entity \"NonGlStockTaxDetail\" filtered by \"NonGlStockTaxDetailId\" with value {NonGlStockTaxDetailId} was denied to the user with Login ID {LoginId}", nonGlStockTaxDetailId, this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT * FROM transactions.non_gl_stock_tax_details WHERE non_gl_stock_tax_detail_id=@0;";
			return Factory.Get<MixERP.Net.Entities.Transactions.NonGlStockTaxDetail>(this.Catalog, sql, nonGlStockTaxDetailId).FirstOrDefault();
		}

        /// <summary>
        /// Custom fields are user defined form elements for transactions.non_gl_stock_tax_details.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for the table transactions.non_gl_stock_tax_details</returns>
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
                    Log.Information("Access to get custom fields for entity \"NonGlStockTaxDetail\" was denied to the user with Login ID {LoginId}", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            string sql;
			if (string.IsNullOrWhiteSpace(resourceId))
            {
				sql = "SELECT * FROM core.custom_field_definition_view WHERE table_name='transactions.non_gl_stock_tax_details' ORDER BY field_order;";
				return Factory.Get<PetaPoco.CustomField>(this.Catalog, sql);
            }

            sql = "SELECT * from core.get_custom_field_definition('transactions.non_gl_stock_tax_details'::text, @0::text) ORDER BY field_order;";
			return Factory.Get<PetaPoco.CustomField>(this.Catalog, sql, resourceId);
        }

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding the row collection of transactions.non_gl_stock_tax_details.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for the table transactions.non_gl_stock_tax_details</returns>
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
                    Log.Information("Access to get display field for entity \"NonGlStockTaxDetail\" was denied to the user with Login ID {LoginId}", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT non_gl_stock_tax_detail_id AS key, non_gl_stock_tax_detail_id as value FROM transactions.non_gl_stock_tax_details;";
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
		/// Inserts or updates the instance of NonGlStockTaxDetail class on the database table "transactions.non_gl_stock_tax_details".
		/// </summary>
		/// <param name="nonGlStockTaxDetail">The instance of "NonGlStockTaxDetail" class to insert or update.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public void AddOrEdit(MixERP.Net.Entities.Transactions.NonGlStockTaxDetail nonGlStockTaxDetail)
		{
			if(string.IsNullOrWhiteSpace(this.Catalog))
			{
				return;
			}

			if(nonGlStockTaxDetail.NonGlStockTaxDetailId > 0){
				this.Update(nonGlStockTaxDetail, nonGlStockTaxDetail.NonGlStockTaxDetailId);
				return;
			}
	
			this.Add(nonGlStockTaxDetail);
		}

		/// <summary>
		/// Inserts the instance of NonGlStockTaxDetail class on the database table "transactions.non_gl_stock_tax_details".
		/// </summary>
		/// <param name="nonGlStockTaxDetail">The instance of "NonGlStockTaxDetail" class to insert.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public void Add(MixERP.Net.Entities.Transactions.NonGlStockTaxDetail nonGlStockTaxDetail)
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
                    Log.Information("Access to add entity \"NonGlStockTaxDetail\" was denied to the user with Login ID {LoginId}. {NonGlStockTaxDetail}", this.LoginId, nonGlStockTaxDetail);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			Factory.Insert(this.Catalog, nonGlStockTaxDetail);
		}

		/// <summary>
		/// Updates the row of the table "transactions.non_gl_stock_tax_details" with an instance of "NonGlStockTaxDetail" class against the primary key value.
		/// </summary>
		/// <param name="nonGlStockTaxDetail">The instance of "NonGlStockTaxDetail" class to update.</param>
		/// <param name="nonGlStockTaxDetailId">The value of the column "non_gl_stock_tax_detail_id" which will be updated.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public void Update(MixERP.Net.Entities.Transactions.NonGlStockTaxDetail nonGlStockTaxDetail, long nonGlStockTaxDetailId)
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
                    Log.Information("Access to edit entity \"NonGlStockTaxDetail\" with Primary Key {PrimaryKey} was denied to the user with Login ID {LoginId}. {NonGlStockTaxDetail}", nonGlStockTaxDetailId, this.LoginId, nonGlStockTaxDetail);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			Factory.Update(this.Catalog, nonGlStockTaxDetail, nonGlStockTaxDetailId);
		}

		/// <summary>
		/// Deletes the row of the table "transactions.non_gl_stock_tax_details" against the primary key value.
		/// </summary>
		/// <param name="nonGlStockTaxDetailId">The value of the column "non_gl_stock_tax_detail_id" which will be deleted.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public void Delete(long nonGlStockTaxDetailId)
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
                    Log.Information("Access to delete entity \"NonGlStockTaxDetail\" with Primary Key {PrimaryKey} was denied to the user with Login ID {LoginId}.", nonGlStockTaxDetailId, this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "DELETE FROM transactions.non_gl_stock_tax_details WHERE non_gl_stock_tax_detail_id=@0;";
			Factory.NonQuery(this.Catalog, sql, nonGlStockTaxDetailId);
		}

		/// <summary>
		/// Performs a select statement on table "transactions.non_gl_stock_tax_details" producing a paged result of 25.
		/// </summary>
		/// <returns>Returns the first page of collection of "NonGlStockTaxDetail" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockTaxDetail> GetPagedResult()
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
                    Log.Information("Access to the first page of the entity \"NonGlStockTaxDetail\" was denied to the user with Login ID {LoginId}.", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT * FROM transactions.non_gl_stock_tax_details ORDER BY non_gl_stock_tax_detail_id LIMIT 25 OFFSET 0;";
			return Factory.Get<MixERP.Net.Entities.Transactions.NonGlStockTaxDetail>(this.Catalog, sql);
		}

		/// <summary>
		/// Performs a select statement on table "transactions.non_gl_stock_tax_details" producing a paged result of 25.
		/// </summary>
		/// <param name="pageNumber">Enter the page number to produce the paged result.</param>
		/// <returns>Returns collection of "NonGlStockTaxDetail" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockTaxDetail> GetPagedResult(long pageNumber)
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
                    Log.Information("Access to Page #{Page} of the entity \"NonGlStockTaxDetail\" was denied to the user with Login ID {LoginId}.", pageNumber, this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			long offset = (pageNumber -1) * 25;
			const string sql = "SELECT * FROM transactions.non_gl_stock_tax_details ORDER BY non_gl_stock_tax_detail_id LIMIT 25 OFFSET @0;";
				
			return Factory.Get<MixERP.Net.Entities.Transactions.NonGlStockTaxDetail>(this.Catalog, sql, offset);
		}

        /// <summary>
		/// Performs a filtered select statement on table "transactions.non_gl_stock_tax_details" producing a paged result of 25.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paged result.</param>
        /// <param name="filters">The list of filter conditions.</param>
		/// <returns>Returns collection of "NonGlStockTaxDetail" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockTaxDetail> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
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
                    Log.Information("Access to Page #{Page} of the filtered entity \"NonGlStockTaxDetail\" was denied to the user with Login ID {LoginId}. Filters: {Filters}.", pageNumber, this.LoginId, filters);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            long offset = (pageNumber - 1) * 25;
            Sql sql = Sql.Builder.Append("SELECT * FROM transactions.non_gl_stock_tax_details WHERE 1 = 1");

            MixERP.Net.EntityParser.Data.Service.AddFilters(ref sql, new MixERP.Net.Entities.Transactions.NonGlStockTaxDetail(), filters);

            sql.OrderBy("non_gl_stock_tax_detail_id");
            sql.Append("LIMIT @0", 25);
            sql.Append("OFFSET @0", offset);

            return Factory.Get<MixERP.Net.Entities.Transactions.NonGlStockTaxDetail>(this.Catalog, sql);
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockTaxDetail> Get(long[] nonGlStockTaxDetailIds)
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
                    Log.Information("Access to entity \"NonGlStockTaxDetail\" was denied to the user with Login ID {LoginId}. nonGlStockTaxDetailIds: {nonGlStockTaxDetailIds}.", this.LoginId, nonGlStockTaxDetailIds);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

			const string sql = "SELECT * FROM transactions.non_gl_stock_tax_details WHERE non_gl_stock_tax_detail_id IN (@0);";

            return Factory.Get<MixERP.Net.Entities.Transactions.NonGlStockTaxDetail>(this.Catalog, sql, nonGlStockTaxDetailIds);
        }

	}
}