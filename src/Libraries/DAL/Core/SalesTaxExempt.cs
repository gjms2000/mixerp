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
    /// Provides simplified data access features to perform SCRUD operation on the database table "core.sales_tax_exempts".
    /// </summary>
    public class SalesTaxExempt : DbAccess
    {
        /// <summary>
        /// The schema of this table. Returns literal "core".
        /// </summary>
	    public override string ObjectNamespace => "core";

        /// <summary>
        /// The schema unqualified name of this table. Returns literal "sales_tax_exempts".
        /// </summary>
	    public override string ObjectName => "sales_tax_exempts";

        /// <summary>
        /// Login id of application user accessing this table.
        /// </summary>
		public long LoginId { get; set; }

        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Performs SQL count on the table "core.sales_tax_exempts".
		/// </summary>
		/// <returns>Returns the number of rows of the table "core.sales_tax_exempts".</returns>
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
                    Log.Information("Access to count entity \"SalesTaxExempt\" was denied to the user with Login ID {LoginId}", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT COUNT(*) FROM core.sales_tax_exempts;";
			return Factory.Scalar<long>(this.Catalog, sql);
		}

		/// <summary>
		/// Executes a select query on the table "core.sales_tax_exempts" with a where filter on the column "sales_tax_exempt_id" to return a single instance of the "SalesTaxExempt" class. 
		/// </summary>
		/// <param name="salesTaxExemptId">The column "sales_tax_exempt_id" parameter used on where filter.</param>
		/// <returns>Returns a non-live, non-mapped instance of "SalesTaxExempt" class mapped to the database row.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public MixERP.Net.Entities.Core.SalesTaxExempt Get(int salesTaxExemptId)
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
                    Log.Information("Access to the get entity \"SalesTaxExempt\" filtered by \"SalesTaxExemptId\" with value {SalesTaxExemptId} was denied to the user with Login ID {LoginId}", salesTaxExemptId, this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT * FROM core.sales_tax_exempts WHERE sales_tax_exempt_id=@0;";
			return Factory.Get<MixERP.Net.Entities.Core.SalesTaxExempt>(this.Catalog, sql, salesTaxExemptId).FirstOrDefault();
		}

        /// <summary>
        /// Custom fields are user defined form elements for core.sales_tax_exempts.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for the table core.sales_tax_exempts</returns>
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
                    Log.Information("Access to get custom fields for entity \"SalesTaxExempt\" was denied to the user with Login ID {LoginId}", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            string sql;
			if (string.IsNullOrWhiteSpace(resourceId))
            {
				sql = "SELECT * FROM core.custom_field_definition_view WHERE table_name='core.sales_tax_exempts' ORDER BY field_order;";
				return Factory.Get<PetaPoco.CustomField>(this.Catalog, sql);
            }

            sql = "SELECT * from core.get_custom_field_definition('core.sales_tax_exempts'::text, @0::text) ORDER BY field_order;";
			return Factory.Get<PetaPoco.CustomField>(this.Catalog, sql, resourceId);
        }

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding the row collection of core.sales_tax_exempts.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for the table core.sales_tax_exempts</returns>
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
                    Log.Information("Access to get display field for entity \"SalesTaxExempt\" was denied to the user with Login ID {LoginId}", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT sales_tax_exempt_id AS key, sales_tax_exempt_code || ' (' || sales_tax_exempt_name || ')' as value FROM core.sales_tax_exempts;";
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
		/// Inserts or updates the instance of SalesTaxExempt class on the database table "core.sales_tax_exempts".
		/// </summary>
		/// <param name="salesTaxExempt">The instance of "SalesTaxExempt" class to insert or update.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public void AddOrEdit(MixERP.Net.Entities.Core.SalesTaxExempt salesTaxExempt)
		{
			if(string.IsNullOrWhiteSpace(this.Catalog))
			{
				return;
			}

			if(salesTaxExempt.SalesTaxExemptId > 0){
				this.Update(salesTaxExempt, salesTaxExempt.SalesTaxExemptId);
				return;
			}
	
			this.Add(salesTaxExempt);
		}

		/// <summary>
		/// Inserts the instance of SalesTaxExempt class on the database table "core.sales_tax_exempts".
		/// </summary>
		/// <param name="salesTaxExempt">The instance of "SalesTaxExempt" class to insert.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public void Add(MixERP.Net.Entities.Core.SalesTaxExempt salesTaxExempt)
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
                    Log.Information("Access to add entity \"SalesTaxExempt\" was denied to the user with Login ID {LoginId}. {SalesTaxExempt}", this.LoginId, salesTaxExempt);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			Factory.Insert(this.Catalog, salesTaxExempt);
		}

		/// <summary>
		/// Updates the row of the table "core.sales_tax_exempts" with an instance of "SalesTaxExempt" class against the primary key value.
		/// </summary>
		/// <param name="salesTaxExempt">The instance of "SalesTaxExempt" class to update.</param>
		/// <param name="salesTaxExemptId">The value of the column "sales_tax_exempt_id" which will be updated.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public void Update(MixERP.Net.Entities.Core.SalesTaxExempt salesTaxExempt, int salesTaxExemptId)
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
                    Log.Information("Access to edit entity \"SalesTaxExempt\" with Primary Key {PrimaryKey} was denied to the user with Login ID {LoginId}. {SalesTaxExempt}", salesTaxExemptId, this.LoginId, salesTaxExempt);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			Factory.Update(this.Catalog, salesTaxExempt, salesTaxExemptId);
		}

		/// <summary>
		/// Deletes the row of the table "core.sales_tax_exempts" against the primary key value.
		/// </summary>
		/// <param name="salesTaxExemptId">The value of the column "sales_tax_exempt_id" which will be deleted.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public void Delete(int salesTaxExemptId)
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
                    Log.Information("Access to delete entity \"SalesTaxExempt\" with Primary Key {PrimaryKey} was denied to the user with Login ID {LoginId}.", salesTaxExemptId, this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "DELETE FROM core.sales_tax_exempts WHERE sales_tax_exempt_id=@0;";
			Factory.NonQuery(this.Catalog, sql, salesTaxExemptId);
		}

		/// <summary>
		/// Performs a select statement on table "core.sales_tax_exempts" producing a paged result of 25.
		/// </summary>
		/// <returns>Returns the first page of collection of "SalesTaxExempt" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public IEnumerable<MixERP.Net.Entities.Core.SalesTaxExempt> GetPagedResult()
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
                    Log.Information("Access to the first page of the entity \"SalesTaxExempt\" was denied to the user with Login ID {LoginId}.", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT * FROM core.sales_tax_exempts ORDER BY sales_tax_exempt_id LIMIT 25 OFFSET 0;";
			return Factory.Get<MixERP.Net.Entities.Core.SalesTaxExempt>(this.Catalog, sql);
		}

		/// <summary>
		/// Performs a select statement on table "core.sales_tax_exempts" producing a paged result of 25.
		/// </summary>
		/// <param name="pageNumber">Enter the page number to produce the paged result.</param>
		/// <returns>Returns collection of "SalesTaxExempt" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
		public IEnumerable<MixERP.Net.Entities.Core.SalesTaxExempt> GetPagedResult(long pageNumber)
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
                    Log.Information("Access to Page #{Page} of the entity \"SalesTaxExempt\" was denied to the user with Login ID {LoginId}.", pageNumber, this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			long offset = (pageNumber -1) * 25;
			const string sql = "SELECT * FROM core.sales_tax_exempts ORDER BY sales_tax_exempt_id LIMIT 25 OFFSET @0;";
				
			return Factory.Get<MixERP.Net.Entities.Core.SalesTaxExempt>(this.Catalog, sql, offset);
		}

        /// <summary>
		/// Performs a filtered select statement on table "core.sales_tax_exempts" producing a paged result of 25.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paged result.</param>
        /// <param name="filters">The list of filter conditions.</param>
		/// <returns>Returns collection of "SalesTaxExempt" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Core.SalesTaxExempt> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
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
                    Log.Information("Access to Page #{Page} of the filtered entity \"SalesTaxExempt\" was denied to the user with Login ID {LoginId}. Filters: {Filters}.", pageNumber, this.LoginId, filters);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            long offset = (pageNumber - 1) * 25;
            Sql sql = Sql.Builder.Append("SELECT * FROM core.sales_tax_exempts WHERE 1 = 1");

            MixERP.Net.EntityParser.Data.Service.AddFilters(ref sql, new MixERP.Net.Entities.Core.SalesTaxExempt(), filters);

            sql.OrderBy("sales_tax_exempt_id");
            sql.Append("LIMIT @0", 25);
            sql.Append("OFFSET @0", offset);

            return Factory.Get<MixERP.Net.Entities.Core.SalesTaxExempt>(this.Catalog, sql);
        }

        public IEnumerable<MixERP.Net.Entities.Core.SalesTaxExempt> Get(int[] salesTaxExemptIds)
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
                    Log.Information("Access to entity \"SalesTaxExempt\" was denied to the user with Login ID {LoginId}. salesTaxExemptIds: {salesTaxExemptIds}.", this.LoginId, salesTaxExemptIds);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

			const string sql = "SELECT * FROM core.sales_tax_exempts WHERE sales_tax_exempt_id IN (@0);";

            return Factory.Get<MixERP.Net.Entities.Core.SalesTaxExempt>(this.Catalog, sql, salesTaxExemptIds);
        }
	}
}