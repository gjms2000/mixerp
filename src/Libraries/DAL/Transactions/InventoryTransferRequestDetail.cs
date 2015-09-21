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
        /// User id of application user accessing this table.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

        /// <summary>
        /// Performs SQL count on the table "transactions.inventory_transfer_request_details".
        /// </summary>
        /// <returns>Returns the number of rows of the table "transactions.inventory_transfer_request_details".</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public long Count()
        {
            if (string.IsNullOrWhiteSpace(this.Catalog))
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
        /// Executes a select query on the table "transactions.inventory_transfer_request_details" to return a all instances of the "InventoryTransferRequestDetail" class to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "InventoryTransferRequestDetail" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail> Get()
        {
            if (string.IsNullOrWhiteSpace(this.Catalog))
            {
                return null;
            }

            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.ExportData, this.LoginId, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the export entity \"InventoryTransferRequestDetail\" was denied to the user with Login ID {LoginId}", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM transactions.inventory_transfer_request_details ORDER BY inventory_transfer_request_detail_id;";
            return Factory.Get<MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail>(this.Catalog, sql);
        }

        /// <summary>
        /// Executes a select query on the table "transactions.inventory_transfer_request_details" with a where filter on the column "inventory_transfer_request_detail_id" to return a single instance of the "InventoryTransferRequestDetail" class. 
        /// </summary>
        /// <param name="inventoryTransferRequestDetailId">The column "inventory_transfer_request_detail_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of "InventoryTransferRequestDetail" class mapped to the database row.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail Get(long inventoryTransferRequestDetailId)
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
                    Log.Information("Access to the get entity \"InventoryTransferRequestDetail\" filtered by \"InventoryTransferRequestDetailId\" with value {InventoryTransferRequestDetailId} was denied to the user with Login ID {LoginId}", inventoryTransferRequestDetailId, this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM transactions.inventory_transfer_request_details WHERE inventory_transfer_request_detail_id=@0;";
            return Factory.Get<MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail>(this.Catalog, sql, inventoryTransferRequestDetailId).FirstOrDefault();
        }

        /// <summary>
        /// Executes a select query on the table "transactions.inventory_transfer_request_details" with a where filter on the column "inventory_transfer_request_detail_id" to return a multiple instances of the "InventoryTransferRequestDetail" class. 
        /// </summary>
        /// <param name="inventoryTransferRequestDetailIds">Array of column "inventory_transfer_request_detail_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of "InventoryTransferRequestDetail" class mapped to the database row.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail> Get(long[] inventoryTransferRequestDetailIds)
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
                    Log.Information("Access to entity \"InventoryTransferRequestDetail\" was denied to the user with Login ID {LoginId}. inventoryTransferRequestDetailIds: {inventoryTransferRequestDetailIds}.", this.LoginId, inventoryTransferRequestDetailIds);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM transactions.inventory_transfer_request_details WHERE inventory_transfer_request_detail_id IN (@0);";

            return Factory.Get<MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail>(this.Catalog, sql, inventoryTransferRequestDetailIds);
        }

        /// <summary>
        /// Custom fields are user defined form elements for transactions.inventory_transfer_request_details.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for the table transactions.inventory_transfer_request_details</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
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
                    Log.Information("Access to get custom fields for entity \"InventoryTransferRequestDetail\" was denied to the user with Login ID {LoginId}", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            string sql;
            if (string.IsNullOrWhiteSpace(resourceId))
            {
                sql = "SELECT * FROM core.custom_field_definition_view WHERE table_name='transactions.inventory_transfer_request_details' ORDER BY field_order;";
                return Factory.Get<PetaPoco.CustomField>(this.Catalog, sql);
            }

            sql = "SELECT * from core.get_custom_field_definition('transactions.inventory_transfer_request_details'::text, @0::text) ORDER BY field_order;";
            return Factory.Get<PetaPoco.CustomField>(this.Catalog, sql, resourceId);
        }

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding the row collection of transactions.inventory_transfer_request_details.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for the table transactions.inventory_transfer_request_details</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            List<DisplayField> displayFields = new List<DisplayField>();

            if (string.IsNullOrWhiteSpace(this.Catalog))
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
        /// Inserts or updates the instance of InventoryTransferRequestDetail class on the database table "transactions.inventory_transfer_request_details".
        /// </summary>
        /// <param name="inventoryTransferRequestDetail">The instance of "InventoryTransferRequestDetail" class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public void AddOrEdit(MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail inventoryTransferRequestDetail, List<EntityParser.CustomField> customFields)
        {
            if (string.IsNullOrWhiteSpace(this.Catalog))
            {
                return;
            }

            object primaryKeyValue;



            if (inventoryTransferRequestDetail.InventoryTransferRequestDetailId > 0)
            {
                primaryKeyValue = inventoryTransferRequestDetail.InventoryTransferRequestDetailId;
                this.Update(inventoryTransferRequestDetail, inventoryTransferRequestDetail.InventoryTransferRequestDetailId);
            }
            else
            {
                primaryKeyValue = this.Add(inventoryTransferRequestDetail);
            }

            string sql = "DELETE FROM core.custom_fields WHERE custom_field_setup_id IN(" +
                         "SELECT custom_field_setup_id " +
                         "FROM core.custom_field_setup " +
                         "WHERE form_name=core.get_custom_field_form_name('transactions.inventory_transfer_request_details')" +
                         ");";

            Factory.NonQuery(this.Catalog, sql);

            if (customFields == null)
            {
                return;
            }

            foreach (var field in customFields)
            {
                sql = "INSERT INTO core.custom_fields(custom_field_setup_id, resource_id, value) " +
                      "SELECT core.get_custom_field_setup_id_by_table_name('transactions.inventory_transfer_request_details', @0::character varying(100)), " +
                      "@1, @2;";

                Factory.NonQuery(this.Catalog, sql, field.FieldName, primaryKeyValue, field.Value);
            }
        }

        /// <summary>
        /// Inserts the instance of InventoryTransferRequestDetail class on the database table "transactions.inventory_transfer_request_details".
        /// </summary>
        /// <param name="inventoryTransferRequestDetail">The instance of "InventoryTransferRequestDetail" class to insert.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public object Add(MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail inventoryTransferRequestDetail)
        {
            if (string.IsNullOrWhiteSpace(this.Catalog))
            {
                return null;
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

            return Factory.Insert(this.Catalog, inventoryTransferRequestDetail);
        }

        /// <summary>
        /// Inserts or updates multiple instances of InventoryTransferRequestDetail class on the database table "transactions.inventory_transfer_request_details";
        /// </summary>
        /// <param name="inventoryTransferRequestDetails">List of "InventoryTransferRequestDetail" class to import.</param>
        /// <returns></returns>
        public List<object> BulkImport(List<MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail> inventoryTransferRequestDetails)
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.ImportData, this.LoginId, false);
                }

                if (!this.HasAccess)
                {
                    Log.Information("Access to import entity \"InventoryTransferRequestDetail\" was denied to the user with Login ID {LoginId}. {inventoryTransferRequestDetails}", this.LoginId, inventoryTransferRequestDetails);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            var result = new List<object>();
            int line = 0;
            try
            {
                using (Database db = new Database(Factory.GetConnectionString(this.Catalog), Factory.ProviderName))
                {
                    using (Transaction transaction = db.GetTransaction())
                    {
                        foreach (var inventoryTransferRequestDetail in inventoryTransferRequestDetails)
                        {
                            line++;



                            if (inventoryTransferRequestDetail.InventoryTransferRequestDetailId > 0)
                            {
                                result.Add(inventoryTransferRequestDetail.InventoryTransferRequestDetailId);
                                db.Update(inventoryTransferRequestDetail, inventoryTransferRequestDetail.InventoryTransferRequestDetailId);
                            }
                            else
                            {
                                result.Add(db.Insert(inventoryTransferRequestDetail));
                            }
                        }

                        transaction.Complete();
                    }

                    return result;
                }
            }
            catch (NpgsqlException ex)
            {
                string errorMessage = $"Error on line {line} ";

                if (ex.Code.StartsWith("P"))
                {
                    errorMessage += Factory.GetDBErrorResource(ex);

                    throw new MixERPException(errorMessage, ex);
                }

                errorMessage += ex.Message;
                throw new MixERPException(errorMessage, ex);
            }
            catch (System.Exception ex)
            {
                string errorMessage = $"Error on line {line} ";
                throw new MixERPException(errorMessage, ex);
            }
        }

        /// <summary>
        /// Updates the row of the table "transactions.inventory_transfer_request_details" with an instance of "InventoryTransferRequestDetail" class against the primary key value.
        /// </summary>
        /// <param name="inventoryTransferRequestDetail">The instance of "InventoryTransferRequestDetail" class to update.</param>
        /// <param name="inventoryTransferRequestDetailId">The value of the column "inventory_transfer_request_detail_id" which will be updated.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public void Update(MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail inventoryTransferRequestDetail, long inventoryTransferRequestDetailId)
        {
            if (string.IsNullOrWhiteSpace(this.Catalog))
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
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public void Delete(long inventoryTransferRequestDetailId)
        {
            if (string.IsNullOrWhiteSpace(this.Catalog))
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
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail> GetPagedResult()
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
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail> GetPagedResult(long pageNumber)
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
                    Log.Information("Access to Page #{Page} of the entity \"InventoryTransferRequestDetail\" was denied to the user with Login ID {LoginId}.", pageNumber, this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            long offset = (pageNumber - 1) * 25;
            const string sql = "SELECT * FROM transactions.inventory_transfer_request_details ORDER BY inventory_transfer_request_detail_id LIMIT 25 OFFSET @0;";

            return Factory.Get<MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail>(this.Catalog, sql, offset);
        }

        private List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            const string sql = "SELECT * FROM core.filters WHERE object_name='transactions.inventory_transfer_request_details' AND lower(filter_name)=lower(@0);";
            return Factory.Get<EntityParser.Filter>(catalog, sql, filterName).ToList();
        }

        /// <summary>
        /// Performs a filtered count on table "transactions.inventory_transfer_request_details".
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "InventoryTransferRequestDetail" class using the filter.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public long CountWhere(List<EntityParser.Filter> filters)
        {
            if (string.IsNullOrWhiteSpace(this.Catalog))
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
                    Log.Information("Access to count entity \"InventoryTransferRequestDetail\" was denied to the user with Login ID {LoginId}. Filters: {Filters}.", this.LoginId, filters);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            Sql sql = Sql.Builder.Append("SELECT COUNT(*) FROM transactions.inventory_transfer_request_details WHERE 1 = 1");
            MixERP.Net.EntityParser.Data.Service.AddFilters(ref sql, new MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail(), filters);

            return Factory.Scalar<long>(this.Catalog, sql);
        }

        /// <summary>
        /// Performs a filtered select statement on table "transactions.inventory_transfer_request_details" producing a paged result of 25.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paged result.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "InventoryTransferRequestDetail" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
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
                    Log.Information("Access to Page #{Page} of the filtered entity \"InventoryTransferRequestDetail\" was denied to the user with Login ID {LoginId}. Filters: {Filters}.", pageNumber, this.LoginId, filters);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            long offset = (pageNumber - 1) * 25;
            Sql sql = Sql.Builder.Append("SELECT * FROM transactions.inventory_transfer_request_details WHERE 1 = 1");

            MixERP.Net.EntityParser.Data.Service.AddFilters(ref sql, new MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail(), filters);

            sql.OrderBy("inventory_transfer_request_detail_id");
            sql.Append("LIMIT @0", 25);
            sql.Append("OFFSET @0", offset);

            return Factory.Get<MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail>(this.Catalog, sql);
        }

        /// <summary>
        /// Performs a filtered count on table "transactions.inventory_transfer_request_details".
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "InventoryTransferRequestDetail" class using the filter.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public long CountFiltered(string filterName)
        {
            if (string.IsNullOrWhiteSpace(this.Catalog))
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
                    Log.Information("Access to count entity \"InventoryTransferRequestDetail\" was denied to the user with Login ID {LoginId}. Filter: {Filter}.", this.LoginId, filterName);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            List<EntityParser.Filter> filters = this.GetFilters(this.Catalog, filterName);
            Sql sql = Sql.Builder.Append("SELECT COUNT(*) FROM transactions.inventory_transfer_request_details WHERE 1 = 1");
            MixERP.Net.EntityParser.Data.Service.AddFilters(ref sql, new MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail(), filters);

            return Factory.Scalar<long>(this.Catalog, sql);
        }

        /// <summary>
        /// Performs a filtered select statement on table "transactions.inventory_transfer_request_details" producing a paged result of 25.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paged result.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "InventoryTransferRequestDetail" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail> GetFiltered(long pageNumber, string filterName)
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
                    Log.Information("Access to Page #{Page} of the filtered entity \"InventoryTransferRequestDetail\" was denied to the user with Login ID {LoginId}. Filter: {Filter}.", pageNumber, this.LoginId, filterName);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            List<EntityParser.Filter> filters = this.GetFilters(this.Catalog, filterName);

            long offset = (pageNumber - 1) * 25;
            Sql sql = Sql.Builder.Append("SELECT * FROM transactions.inventory_transfer_request_details WHERE 1 = 1");

            MixERP.Net.EntityParser.Data.Service.AddFilters(ref sql, new MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail(), filters);

            sql.OrderBy("inventory_transfer_request_detail_id");
            sql.Append("LIMIT @0", 25);
            sql.Append("OFFSET @0", offset);

            return Factory.Get<MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail>(this.Catalog, sql);
        }

    }
}