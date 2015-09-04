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

namespace MixERP.Net.Schemas.Localization.Data
{
    /// <summary>
    /// Provides simplified data access features to perform SCRUD operation on the database table "localization.cultures".
    /// </summary>
    public class Culture : DbAccess
    {
        /// <summary>
        /// The schema of this table. Returns literal "localization".
        /// </summary>
	    public override string ObjectNamespace => "localization";

        /// <summary>
        /// The schema unqualified name of this table. Returns literal "cultures".
        /// </summary>
	    public override string ObjectName => "cultures";

        /// <summary>
        /// Login id of application user accessing this table.
        /// </summary>
		public long LoginId { get; set; }

        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Performs SQL count on the table "localization.cultures".
		/// </summary>
		/// <returns>Returns the number of rows of the table "localization.cultures".</returns>
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
	
				const string sql = "SELECT COUNT(*) FROM localization.cultures;";
				return Factory.Scalar<long>(this.Catalog, sql);
            }
            catch (UnauthorizedException ex)
            {
                Log.Error("{Exception} {@Exception}", ex.Message, ex);
                throw new MixERPException(ex.Message, ex);
            }
		}

		/// <summary>
		/// Executes a select query on the table "localization.cultures" with a where filter on the column "culture_code" to return a single instance of the "Culture" class. 
		/// </summary>
		/// <param name="cultureCode">The column "culture_code" parameter used on where filter.</param>
		/// <returns>Returns a non-live, non-mapped instance of "Culture" class mapped to the database row.</returns>
		public MixERP.Net.Entities.Localization.Culture Get(string cultureCode)
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
	
				const string sql = "SELECT * FROM localization.cultures WHERE culture_code=@0;";
				return Factory.Get<MixERP.Net.Entities.Localization.Culture>(this.Catalog, sql, cultureCode).FirstOrDefault();
            }
            catch (UnauthorizedException ex)
            {
                Log.Error("{Exception} {@Exception}", ex.Message, ex);
                throw new MixERPException(ex.Message, ex);
            }
		}

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding the row collection of localization.cultures.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for the table localization.cultures</returns>
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
	
				const string sql = "SELECT culture_code AS key, culture_code || ' (' || culture_name || ')' as value FROM localization.cultures;";
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
		/// Inserts the instance of Culture class on the database table "localization.cultures".
		/// </summary>
		/// <param name="culture">The instance of "Culture" class to insert.</param>
		public void Add(MixERP.Net.Entities.Localization.Culture culture)
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
	
				Factory.Insert(this.Catalog, culture);
            }
            catch (UnauthorizedException ex)
            {
                Log.Error("{Exception} {@Exception}", ex.Message, ex);
                throw new MixERPException(ex.Message, ex);
            }
		}

		/// <summary>
		/// Updates the row of the table "localization.cultures" with an instance of "Culture" class against the primary key value.
		/// </summary>
		/// <param name="culture">The instance of "Culture" class to update.</param>
		/// <param name="cultureCode">The value of the column "culture_code" which will be updated.</param>
		public void Update(MixERP.Net.Entities.Localization.Culture culture, string cultureCode)
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
	
				Factory.Update(this.Catalog, culture, cultureCode);
            }
            catch (UnauthorizedException ex)
            {
                Log.Error("{Exception} {@Exception}", ex.Message, ex);
                throw new MixERPException(ex.Message, ex);
            }
		}

		/// <summary>
		/// Deletes the row of the table "localization.cultures" against the primary key value.
		/// </summary>
		/// <param name="cultureCode">The value of the column "culture_code" which will be deleted.</param>
		public void Delete(string cultureCode)
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
	
				const string sql = "DELETE FROM localization.cultures WHERE culture_code=@0;";
				Factory.NonQuery(this.Catalog, sql, cultureCode);
            }
            catch (UnauthorizedException ex)
            {
                Log.Error("{Exception} {@Exception}", ex.Message, ex);
                throw new MixERPException(ex.Message, ex);
            }
		}

		/// <summary>
		/// Performs a select statement on table "localization.cultures" producing a paged result of 25.
		/// </summary>
		/// <returns>Returns the first page of collection of "Culture" class.</returns>
		public IEnumerable<MixERP.Net.Entities.Localization.Culture> GetPagedResult()
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
	
				const string sql = "SELECT * FROM localization.cultures ORDER BY culture_code LIMIT 25 OFFSET 0;";
				return Factory.Get<MixERP.Net.Entities.Localization.Culture>(this.Catalog, sql);
            }
            catch (UnauthorizedException ex)
            {
                Log.Error("{Exception} {@Exception}", ex.Message, ex);
                throw new MixERPException(ex.Message, ex);
            }
		}

		/// <summary>
		/// Performs a select statement on table "localization.cultures" producing a paged result of 25.
		/// </summary>
		/// <param name="pageNumber">Enter the page number to produce the paged result.</param>
		/// <returns>Returns collection of "Culture" class.</returns>
		public IEnumerable<MixERP.Net.Entities.Localization.Culture> GetPagedResult(long pageNumber)
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
				const string sql = "SELECT * FROM localization.cultures ORDER BY culture_code LIMIT 25 OFFSET @0;";
				
				return Factory.Get<MixERP.Net.Entities.Localization.Culture>(this.Catalog, sql, offset);
            }
            catch (UnauthorizedException ex)
            {
                Log.Error("{Exception} {@Exception}", ex.Message, ex);
                throw new MixERPException(ex.Message, ex);
            }
		}
	}
}