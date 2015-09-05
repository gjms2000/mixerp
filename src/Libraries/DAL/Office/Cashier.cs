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

namespace MixERP.Net.Schemas.Office.Data
{
    /// <summary>
    /// Provides simplified data access features to perform SCRUD operation on the database table "office.cashiers".
    /// </summary>
    public class Cashier : DbAccess
    {
        /// <summary>
        /// The schema of this table. Returns literal "office".
        /// </summary>
	    public override string ObjectNamespace => "office";

        /// <summary>
        /// The schema unqualified name of this table. Returns literal "cashiers".
        /// </summary>
	    public override string ObjectName => "cashiers";

        /// <summary>
        /// Login id of application user accessing this table.
        /// </summary>
		public long LoginId { get; set; }

        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Performs SQL count on the table "office.cashiers".
		/// </summary>
		/// <returns>Returns the number of rows of the table "office.cashiers".</returns>
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
                    Log.Information("Access to count entity \"Cashier\" was denied to the user with Login ID {LoginId}", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT COUNT(*) FROM office.cashiers;";
			return Factory.Scalar<long>(this.Catalog, sql);
		}

		/// <summary>
		/// Executes a select query on the table "office.cashiers" with a where filter on the column "cashier_id" to return a single instance of the "Cashier" class. 
		/// </summary>
		/// <param name="cashierId">The column "cashier_id" parameter used on where filter.</param>
		/// <returns>Returns a non-live, non-mapped instance of "Cashier" class mapped to the database row.</returns>
		public MixERP.Net.Entities.Office.Cashier Get(long cashierId)
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
                    Log.Information("Access to the get entity \"Cashier\" filtered by \"CashierId\" with value {CashierId} was denied to the user with Login ID {LoginId}", cashierId, this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT * FROM office.cashiers WHERE cashier_id=@0;";
			return Factory.Get<MixERP.Net.Entities.Office.Cashier>(this.Catalog, sql, cashierId).FirstOrDefault();
		}

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding the row collection of office.cashiers.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for the table office.cashiers</returns>
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
                    Log.Information("Access to get display field for entity \"Cashier\" was denied to the user with Login ID {LoginId}", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT cashier_id AS key, cashier_id as value FROM office.cashiers;";
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
		/// Inserts the instance of Cashier class on the database table "office.cashiers".
		/// </summary>
		/// <param name="cashier">The instance of "Cashier" class to insert.</param>
		public void Add(MixERP.Net.Entities.Office.Cashier cashier)
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
                    Log.Information("Access to add entity \"Cashier\" was denied to the user with Login ID {LoginId}. {Cashier}", this.LoginId, cashier);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			Factory.Insert(this.Catalog, cashier);
		}

		/// <summary>
		/// Updates the row of the table "office.cashiers" with an instance of "Cashier" class against the primary key value.
		/// </summary>
		/// <param name="cashier">The instance of "Cashier" class to update.</param>
		/// <param name="cashierId">The value of the column "cashier_id" which will be updated.</param>
		public void Update(MixERP.Net.Entities.Office.Cashier cashier, long cashierId)
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
                    Log.Information("Access to edit entity \"Cashier\" with Primary Key {PrimaryKey} was denied to the user with Login ID {LoginId}. {Cashier}", cashierId, this.LoginId, cashier);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			Factory.Update(this.Catalog, cashier, cashierId);
		}

		/// <summary>
		/// Deletes the row of the table "office.cashiers" against the primary key value.
		/// </summary>
		/// <param name="cashierId">The value of the column "cashier_id" which will be deleted.</param>
		public void Delete(long cashierId)
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
                    Log.Information("Access to delete entity \"Cashier\" with Primary Key {PrimaryKey} was denied to the user with Login ID {LoginId}.", cashierId, this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "DELETE FROM office.cashiers WHERE cashier_id=@0;";
			Factory.NonQuery(this.Catalog, sql, cashierId);
		}

		/// <summary>
		/// Performs a select statement on table "office.cashiers" producing a paged result of 25.
		/// </summary>
		/// <returns>Returns the first page of collection of "Cashier" class.</returns>
		public IEnumerable<MixERP.Net.Entities.Office.Cashier> GetPagedResult()
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
                    Log.Information("Access to the first page of the entity \"Cashier\" was denied to the user with Login ID {LoginId}.", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT * FROM office.cashiers ORDER BY cashier_id LIMIT 25 OFFSET 0;";
			return Factory.Get<MixERP.Net.Entities.Office.Cashier>(this.Catalog, sql);
		}

		/// <summary>
		/// Performs a select statement on table "office.cashiers" producing a paged result of 25.
		/// </summary>
		/// <param name="pageNumber">Enter the page number to produce the paged result.</param>
		/// <returns>Returns collection of "Cashier" class.</returns>
		public IEnumerable<MixERP.Net.Entities.Office.Cashier> GetPagedResult(long pageNumber)
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
                    Log.Information("Access to Page #{Page} of the entity \"Cashier\" was denied to the user with Login ID {LoginId}.", pageNumber, this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			long offset = (pageNumber -1) * 25;
			const string sql = "SELECT * FROM office.cashiers ORDER BY cashier_id LIMIT 25 OFFSET @0;";
				
			return Factory.Get<MixERP.Net.Entities.Office.Cashier>(this.Catalog, sql, offset);
		}
	}
}