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

namespace MixERP.Net.Schemas.Transactions.Data
{
    /// <summary>
    /// Provides simplified data access features to perform SCRUD operation on the database table "transactions.inventory_transfer_request_details".
    /// </summary>
    public class InventoryTransferRequestDetail : DbAccess
    {
        /// <summary>
        /// The schema of this table. Returns literal "transactions".
        /// </summary>
	    public override string ObjectNamespace => "transactions";

        /// <summary>
        /// The schema unqualified name of this table. Returns literal "inventory_transfer_request_details".
        /// </summary>
	    public override string ObjectName => "inventory_transfer_request_details";

        /// <summary>
        /// Login id of application user accessing this table.
        /// </summary>
		public long LoginId { get; set; }

        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Performs SQL count on the table "transactions.inventory_transfer_request_details".
		/// </summary>
		/// <returns>Returns the number of rows of the table "transactions.inventory_transfer_request_details".</returns>
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
                    Log.Information("Access to count entity \"InventoryTransferRequestDetail\" was denied to the user with Login ID {LoginId}", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT COUNT(*) FROM transactions.inventory_transfer_request_details;";
			return Factory.Scalar<long>(this.Catalog, sql);
		}

		/// <summary>
		/// Executes a select query on the table "transactions.inventory_transfer_request_details" with a where filter on the column "inventory_transfer_request_detail_id" to return a single instance of the "InventoryTransferRequestDetail" class. 
		/// </summary>
		/// <param name="inventoryTransferRequestDetailId">The column "inventory_transfer_request_detail_id" parameter used on where filter.</param>
		/// <returns>Returns a non-live, non-mapped instance of "InventoryTransferRequestDetail" class mapped to the database row.</returns>
		public MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail Get(long inventoryTransferRequestDetailId)
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
                    Log.Information("Access to the get entity \"InventoryTransferRequestDetail\" filtered by \"InventoryTransferRequestDetailId\" with value {InventoryTransferRequestDetailId} was denied to the user with Login ID {LoginId}", inventoryTransferRequestDetailId, this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT * FROM transactions.inventory_transfer_request_details WHERE inventory_transfer_request_detail_id=@0;";
			return Factory.Get<MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail>(this.Catalog, sql, inventoryTransferRequestDetailId).FirstOrDefault();
		}

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding the row collection of transactions.inventory_transfer_request_details.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for the table transactions.inventory_transfer_request_details</returns>
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
                    Log.Information("Access to get display field for entity \"InventoryTransferRequestDetail\" was denied to the user with Login ID {LoginId}", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT inventory_transfer_request_detail_id AS key, inventory_transfer_request_detail_id as value FROM transactions.inventory_transfer_request_details;";
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
		/// Inserts the instance of InventoryTransferRequestDetail class on the database table "transactions.inventory_transfer_request_details".
		/// </summary>
		/// <param name="inventoryTransferRequestDetail">The instance of "InventoryTransferRequestDetail" class to insert.</param>
		public void Add(MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail inventoryTransferRequestDetail)
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
                    Log.Information("Access to add entity \"InventoryTransferRequestDetail\" was denied to the user with Login ID {LoginId}. {InventoryTransferRequestDetail}", this.LoginId, inventoryTransferRequestDetail);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			Factory.Insert(this.Catalog, inventoryTransferRequestDetail);
		}

		/// <summary>
		/// Updates the row of the table "transactions.inventory_transfer_request_details" with an instance of "InventoryTransferRequestDetail" class against the primary key value.
		/// </summary>
		/// <param name="inventoryTransferRequestDetail">The instance of "InventoryTransferRequestDetail" class to update.</param>
		/// <param name="inventoryTransferRequestDetailId">The value of the column "inventory_transfer_request_detail_id" which will be updated.</param>
		public void Update(MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail inventoryTransferRequestDetail, long inventoryTransferRequestDetailId)
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
                    Log.Information("Access to edit entity \"InventoryTransferRequestDetail\" with Primary Key {PrimaryKey} was denied to the user with Login ID {LoginId}. {InventoryTransferRequestDetail}", inventoryTransferRequestDetailId, this.LoginId, inventoryTransferRequestDetail);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			Factory.Update(this.Catalog, inventoryTransferRequestDetail, inventoryTransferRequestDetailId);
		}

		/// <summary>
		/// Deletes the row of the table "transactions.inventory_transfer_request_details" against the primary key value.
		/// </summary>
		/// <param name="inventoryTransferRequestDetailId">The value of the column "inventory_transfer_request_detail_id" which will be deleted.</param>
		public void Delete(long inventoryTransferRequestDetailId)
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
                    Log.Information("Access to delete entity \"InventoryTransferRequestDetail\" with Primary Key {PrimaryKey} was denied to the user with Login ID {LoginId}.", inventoryTransferRequestDetailId, this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "DELETE FROM transactions.inventory_transfer_request_details WHERE inventory_transfer_request_detail_id=@0;";
			Factory.NonQuery(this.Catalog, sql, inventoryTransferRequestDetailId);
		}

		/// <summary>
		/// Performs a select statement on table "transactions.inventory_transfer_request_details" producing a paged result of 25.
		/// </summary>
		/// <returns>Returns the first page of collection of "InventoryTransferRequestDetail" class.</returns>
		public IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail> GetPagedResult()
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
                    Log.Information("Access to the first page of the entity \"InventoryTransferRequestDetail\" was denied to the user with Login ID {LoginId}.", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT * FROM transactions.inventory_transfer_request_details ORDER BY inventory_transfer_request_detail_id LIMIT 25 OFFSET 0;";
			return Factory.Get<MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail>(this.Catalog, sql);
		}

		/// <summary>
		/// Performs a select statement on table "transactions.inventory_transfer_request_details" producing a paged result of 25.
		/// </summary>
		/// <param name="pageNumber">Enter the page number to produce the paged result.</param>
		/// <returns>Returns collection of "InventoryTransferRequestDetail" class.</returns>
		public IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail> GetPagedResult(long pageNumber)
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
                    Log.Information("Access to Page #{Page} of the entity \"InventoryTransferRequestDetail\" was denied to the user with Login ID {LoginId}.", pageNumber, this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			long offset = (pageNumber -1) * 25;
			const string sql = "SELECT * FROM transactions.inventory_transfer_request_details ORDER BY inventory_transfer_request_detail_id LIMIT 25 OFFSET @0;";
				
			return Factory.Get<MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail>(this.Catalog, sql, offset);
		}
	}
}