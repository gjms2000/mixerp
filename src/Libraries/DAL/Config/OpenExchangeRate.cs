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

namespace MixERP.Net.Schemas.Config.Data
{
    /// <summary>
    /// Provides simplified data access features to perform SCRUD operation on the database table "config.open_exchange_rates".
    /// </summary>
    public class OpenExchangeRate : DbAccess
    {
        /// <summary>
        /// The schema of this table. Returns literal "config".
        /// </summary>
	    public override string ObjectNamespace => "config";

        /// <summary>
        /// The schema unqualified name of this table. Returns literal "open_exchange_rates".
        /// </summary>
	    public override string ObjectName => "open_exchange_rates";

        /// <summary>
        /// Login id of application user accessing this table.
        /// </summary>
		public long LoginId { get; set; }

        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Performs SQL count on the table "config.open_exchange_rates".
		/// </summary>
		/// <returns>Returns the number of rows of the table "config.open_exchange_rates".</returns>
		public long Count()
		{
			if(string.IsNullOrWhiteSpace(this.Catalog))
			{
				return 0;
			}

            try
            {
                if (!this.SkipValidation)
                {
                    if (!this.Validated)
                    {
                        this.Validate(AccessTypeEnum.Read, this.LoginId, false);
                    }
                    if (!this.HasAccess)
                    {
                        throw new UnauthorizedException("Access is denied.");
                    }
                }
	
				const string sql = "SELECT COUNT(*) FROM config.open_exchange_rates;";
				return Factory.Scalar<long>(this.Catalog, sql);
            }
            catch (UnauthorizedException ex)
            {
                Log.Error("{Exception} {@Exception}", ex.Message, ex);
                throw new MixERPException(ex.Message, ex);
            }
		}

		/// <summary>
		/// Executes a select query on the table "config.open_exchange_rates" with a where filter on the column "key" to return a single instance of the "OpenExchangeRate" class. 
		/// </summary>
		/// <param name="key">The column "key" parameter used on where filter.</param>
		/// <returns>Returns a non-live, non-mapped instance of "OpenExchangeRate" class mapped to the database row.</returns>
		public MixERP.Net.Entities.Config.OpenExchangeRate Get(string key)
		{
			if(string.IsNullOrWhiteSpace(this.Catalog))
			{
				return null;
			}

            try
            {
                if (!this.SkipValidation)
                {
                    if (!this.Validated)
                    {
                        this.Validate(AccessTypeEnum.Read, this.LoginId, false);
                    }
                    if (!this.HasAccess)
                    {
                        throw new UnauthorizedException("Access is denied.");
                    }
                }
	
				const string sql = "SELECT * FROM config.open_exchange_rates WHERE key=@0;";
				return Factory.Get<MixERP.Net.Entities.Config.OpenExchangeRate>(this.Catalog, sql, key).FirstOrDefault();
            }
            catch (UnauthorizedException ex)
            {
                Log.Error("{Exception} {@Exception}", ex.Message, ex);
                throw new MixERPException(ex.Message, ex);
            }
		}

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding the row collection of config.open_exchange_rates.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for the table config.open_exchange_rates</returns>
		public IEnumerable<DisplayField> GetDisplayFields()
		{
			List<DisplayField> displayFields = new List<DisplayField>();

			if(string.IsNullOrWhiteSpace(this.Catalog))
			{
				return displayFields;
			}

            try
            {
                if (!this.SkipValidation)
                {
                    if (!this.Validated)
                    {
                        this.Validate(AccessTypeEnum.Read, this.LoginId, false);
                    }
                    if (!this.HasAccess)
                    {
                        throw new UnauthorizedException("Access is denied.");
                    }
                }
	
				const string sql = "SELECT key AS key, key as value FROM config.open_exchange_rates;";
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
            catch (UnauthorizedException ex)
            {
                Log.Error("{Exception} {@Exception}", ex.Message, ex);
                throw new MixERPException(ex.Message, ex);
            }
		}

		/// <summary>
		/// Inserts the instance of OpenExchangeRate class on the database table "config.open_exchange_rates".
		/// </summary>
		/// <param name="openExchangeRate">The instance of "OpenExchangeRate" class to insert.</param>
		public void Add(MixERP.Net.Entities.Config.OpenExchangeRate openExchangeRate)
		{
			if(string.IsNullOrWhiteSpace(this.Catalog))
			{
				return;
			}

            try
            {
                if (!this.SkipValidation)
                {
                    if (!this.Validated)
                    {
                        this.Validate(AccessTypeEnum.Create, this.LoginId, false);
                    }
                    if (!this.HasAccess)
                    {
                        throw new UnauthorizedException("Access is denied.");
                    }
                }
	
				Factory.Insert(this.Catalog, openExchangeRate);
            }
            catch (UnauthorizedException ex)
            {
                Log.Error("{Exception} {@Exception}", ex.Message, ex);
                throw new MixERPException(ex.Message, ex);
            }
		}

		/// <summary>
		/// Updates the row of the table "config.open_exchange_rates" with an instance of "OpenExchangeRate" class against the primary key value.
		/// </summary>
		/// <param name="openExchangeRate">The instance of "OpenExchangeRate" class to update.</param>
		/// <param name="key">The value of the column "key" which will be updated.</param>
		public void Update(MixERP.Net.Entities.Config.OpenExchangeRate openExchangeRate, string key)
		{
			if(string.IsNullOrWhiteSpace(this.Catalog))
			{
				return;
			}

            try
            {
                if (!this.SkipValidation)
                {
                    if (!this.Validated)
                    {
                        this.Validate(AccessTypeEnum.Edit, this.LoginId, false);
                    }
                    if (!this.HasAccess)
                    {
                        throw new UnauthorizedException("Access is denied.");
                    }
                }
	
				Factory.Update(this.Catalog, openExchangeRate, key);
            }
            catch (UnauthorizedException ex)
            {
                Log.Error("{Exception} {@Exception}", ex.Message, ex);
                throw new MixERPException(ex.Message, ex);
            }
		}

		/// <summary>
		/// Deletes the row of the table "config.open_exchange_rates" against the primary key value.
		/// </summary>
		/// <param name="key">The value of the column "key" which will be deleted.</param>
		public void Delete(string key)
		{
			if(string.IsNullOrWhiteSpace(this.Catalog))
			{
				return;
			}

            try
            {
                if (!this.SkipValidation)
                {
                    if (!this.Validated)
                    {
                        this.Validate(AccessTypeEnum.Delete, this.LoginId, false);
                    }
                    if (!this.HasAccess)
                    {
                        throw new UnauthorizedException("Access is denied.");
                    }
                }
	
				const string sql = "DELETE FROM config.open_exchange_rates WHERE key=@0;";
				Factory.NonQuery(this.Catalog, sql, key);
            }
            catch (UnauthorizedException ex)
            {
                Log.Error("{Exception} {@Exception}", ex.Message, ex);
                throw new MixERPException(ex.Message, ex);
            }
		}

		/// <summary>
		/// Performs a select statement on table "config.open_exchange_rates" producing a paged result of 25.
		/// </summary>
		/// <returns>Returns the first page of collection of "OpenExchangeRate" class.</returns>
		public IEnumerable<MixERP.Net.Entities.Config.OpenExchangeRate> GetPagedResult()
		{
			if(string.IsNullOrWhiteSpace(this.Catalog))
			{
				return null;
			}

            try
            {
                if (!this.SkipValidation)
                {
                    if (!this.Validated)
                    {
                        this.Validate(AccessTypeEnum.Read, this.LoginId, false);
                    }
                    if (!this.HasAccess)
                    {
                        throw new UnauthorizedException("Access is denied.");
                    }
                }
	
				const string sql = "SELECT * FROM config.open_exchange_rates ORDER BY key LIMIT 25 OFFSET 0;";
				return Factory.Get<MixERP.Net.Entities.Config.OpenExchangeRate>(this.Catalog, sql);
            }
            catch (UnauthorizedException ex)
            {
                Log.Error("{Exception} {@Exception}", ex.Message, ex);
                throw new MixERPException(ex.Message, ex);
            }
		}

		/// <summary>
		/// Performs a select statement on table "config.open_exchange_rates" producing a paged result of 25.
		/// </summary>
		/// <param name="pageNumber">Enter the page number to produce the paged result.</param>
		/// <returns>Returns collection of "OpenExchangeRate" class.</returns>
		public IEnumerable<MixERP.Net.Entities.Config.OpenExchangeRate> GetPagedResult(long pageNumber)
		{
			if(string.IsNullOrWhiteSpace(this.Catalog))
			{
				return null;
			}

            try
            {
                if (!this.SkipValidation)
                {
                    if (!this.Validated)
                    {
                        this.Validate(AccessTypeEnum.Read, this.LoginId, false);
                    }
                    if (!this.HasAccess)
                    {
                        throw new UnauthorizedException("Access is denied.");
                    }
                }
	
				long offset = (pageNumber -1) * 25;
				const string sql = "SELECT * FROM config.open_exchange_rates ORDER BY key LIMIT 25 OFFSET @0;";
				
				return Factory.Get<MixERP.Net.Entities.Config.OpenExchangeRate>(this.Catalog, sql, offset);
            }
            catch (UnauthorizedException ex)
            {
                Log.Error("{Exception} {@Exception}", ex.Message, ex);
                throw new MixERPException(ex.Message, ex);
            }
		}
	}
}