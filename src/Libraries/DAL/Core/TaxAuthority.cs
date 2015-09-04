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
    /// Provides simplified data access features to perform SCRUD operation on the database table "core.tax_authorities".
    /// </summary>
    public class TaxAuthority : DbAccess
    {
        /// <summary>
        /// The schema of this table. Returns literal "core".
        /// </summary>
	    public override string ObjectNamespace => "core";

        /// <summary>
        /// The schema unqualified name of this table. Returns literal "tax_authorities".
        /// </summary>
	    public override string ObjectName => "tax_authorities";

        /// <summary>
        /// Login id of application user accessing this table.
        /// </summary>
		public long LoginId { get; set; }

        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Performs SQL count on the table "core.tax_authorities".
		/// </summary>
		/// <returns>Returns the number of rows of the table "core.tax_authorities".</returns>
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
                    Log.Information("Access to count entity \"TaxAuthority\" was denied to the user with Login ID {LoginId}", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT COUNT(*) FROM core.tax_authorities;";
			return Factory.Scalar<long>(this.Catalog, sql);
		}

		/// <summary>
		/// Executes a select query on the table "core.tax_authorities" with a where filter on the column "tax_authority_id" to return a single instance of the "TaxAuthority" class. 
		/// </summary>
		/// <param name="taxAuthorityId">The column "tax_authority_id" parameter used on where filter.</param>
		/// <returns>Returns a non-live, non-mapped instance of "TaxAuthority" class mapped to the database row.</returns>
		public MixERP.Net.Entities.Core.TaxAuthority Get(int taxAuthorityId)
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
                    Log.Information("Access to the get entity \"TaxAuthority\" filtered by \"TaxAuthorityId\" with value {TaxAuthorityId} was denied to the user with Login ID {LoginId}", taxAuthorityId, this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT * FROM core.tax_authorities WHERE tax_authority_id=@0;";
			return Factory.Get<MixERP.Net.Entities.Core.TaxAuthority>(this.Catalog, sql, taxAuthorityId).FirstOrDefault();
		}

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding the row collection of core.tax_authorities.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for the table core.tax_authorities</returns>
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
                    Log.Information("Access to get display field for entity \"TaxAuthority\" was denied to the user with Login ID {LoginId}", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT tax_authority_id AS key, tax_authority_code || ' (' || tax_authority_name || ')' as value FROM core.tax_authorities;";
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
		/// Inserts the instance of TaxAuthority class on the database table "core.tax_authorities".
		/// </summary>
		/// <param name="taxAuthority">The instance of "TaxAuthority" class to insert.</param>
		public void Add(MixERP.Net.Entities.Core.TaxAuthority taxAuthority)
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
                    Log.Information("Access to add entity \"TaxAuthority\" was denied to the user with Login ID {LoginId}. {TaxAuthority}", this.LoginId, taxAuthority);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			Factory.Insert(this.Catalog, taxAuthority);
		}

		/// <summary>
		/// Updates the row of the table "core.tax_authorities" with an instance of "TaxAuthority" class against the primary key value.
		/// </summary>
		/// <param name="taxAuthority">The instance of "TaxAuthority" class to update.</param>
		/// <param name="taxAuthorityId">The value of the column "tax_authority_id" which will be updated.</param>
		public void Update(MixERP.Net.Entities.Core.TaxAuthority taxAuthority, int taxAuthorityId)
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
                    Log.Information("Access to edit entity \"TaxAuthority\" with Primary Key {PrimaryKey} was denied to the user with Login ID {LoginId}. {TaxAuthority}", taxAuthorityId, this.LoginId, taxAuthority);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			Factory.Update(this.Catalog, taxAuthority, taxAuthorityId);
		}

		/// <summary>
		/// Deletes the row of the table "core.tax_authorities" against the primary key value.
		/// </summary>
		/// <param name="taxAuthorityId">The value of the column "tax_authority_id" which will be deleted.</param>
		public void Delete(int taxAuthorityId)
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
                    Log.Information("Access to delete entity \"TaxAuthority\" with Primary Key {PrimaryKey} was denied to the user with Login ID {LoginId}.", taxAuthorityId, this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "DELETE FROM core.tax_authorities WHERE tax_authority_id=@0;";
			Factory.NonQuery(this.Catalog, sql, taxAuthorityId);
		}

		/// <summary>
		/// Performs a select statement on table "core.tax_authorities" producing a paged result of 25.
		/// </summary>
		/// <returns>Returns the first page of collection of "TaxAuthority" class.</returns>
		public IEnumerable<MixERP.Net.Entities.Core.TaxAuthority> GetPagedResult()
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
                    Log.Information("Access to the first page of the entity \"TaxAuthority\" was denied to the user with Login ID {LoginId}.", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT * FROM core.tax_authorities ORDER BY tax_authority_id LIMIT 25 OFFSET 0;";
			return Factory.Get<MixERP.Net.Entities.Core.TaxAuthority>(this.Catalog, sql);
		}

		/// <summary>
		/// Performs a select statement on table "core.tax_authorities" producing a paged result of 25.
		/// </summary>
		/// <param name="pageNumber">Enter the page number to produce the paged result.</param>
		/// <returns>Returns collection of "TaxAuthority" class.</returns>
		public IEnumerable<MixERP.Net.Entities.Core.TaxAuthority> GetPagedResult(long pageNumber)
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
                    Log.Information("Access to Page #{Page} of the entity \"TaxAuthority\" was denied to the user with Login ID {LoginId}.", pageNumber, this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			long offset = (pageNumber -1) * 25;
			const string sql = "SELECT * FROM core.tax_authorities ORDER BY tax_authority_id LIMIT 25 OFFSET @0;";
				
			return Factory.Get<MixERP.Net.Entities.Core.TaxAuthority>(this.Catalog, sql, offset);
		}
	}
}