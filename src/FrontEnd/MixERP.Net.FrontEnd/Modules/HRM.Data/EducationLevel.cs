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
using Npgsql;
using PetaPoco;

namespace MixERP.Net.Core.Modules.HRM.Data
{
    public class EducationLevel
    {
		/// <summary>
		/// Performs SQL count on the table "hrm.education_levels".
		/// </summary>
        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		/// <returns>Returns the number of rows of the table "hrm.education_levels".</returns>
		public long Count(string catalog)
		{
			const string sql = "SELECT COUNT(*) FROM hrm.education_levels;";
			return Factory.Scalar<long>(catalog, sql);
		}

		/// <summary>
		/// Executes a select query on the table "hrm.education_levels" with a where filter on the column "education_level_id" to return a single instance of the "EducationLevel" class. 
		/// </summary>
        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		/// <param name="educationLevelId">The column "education_level_id" parameter used on where filter.</param>
		/// <returns>Returns a non-live, non-mapped instance of "EducationLevel" class mapped to the database row.</returns>
		public MixERP.Net.Entities.HRM.EducationLevel Get(string catalog, int educationLevelId)
		{
			const string sql = "SELECT * FROM hrm.education_levels WHERE education_level_id=@0;";
			return Factory.Get<MixERP.Net.Entities.HRM.EducationLevel>(catalog, sql, educationLevelId).FirstOrDefault();
		}

        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		public static IEnumerable<DisplayField> GetDisplayFields(string catalog)
		{
			List<DisplayField> displayFields = new List<DisplayField>();

			const string sql = "SELECT education_level_id AS key, education_level_name as value FROM hrm.education_levels;";
			using (NpgsqlCommand command = new NpgsqlCommand(sql))
			{
				using (DataTable table = DbOperation.GetDataTable(catalog, command))
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
		/// Inserts the instance of EducationLevel class on the database table "hrm.education_levels".
		/// </summary>
        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		/// <param name="educationLevel">The instance of "EducationLevel" class to insert.</param>
		public void Add(string catalog, MixERP.Net.Entities.HRM.EducationLevel educationLevel)
		{
			Factory.Insert(catalog, educationLevel);
		}

		/// <summary>
		/// Updates the row of the table "hrm.education_levels" with an instance of "EducationLevel" class against the primary key value.
		/// </summary>
        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		/// <param name="educationLevel">The instance of "EducationLevel" class to update.</param>
		/// <param name="educationLevelId">The value of the column "education_level_id" which will be updated.</param>
		public void Update(string catalog, MixERP.Net.Entities.HRM.EducationLevel educationLevel, int educationLevelId)
		{
			Factory.Update(catalog, educationLevel, educationLevelId);
		}

		/// <summary>
		/// Deletes the row of the table "hrm.education_levels" against the primary key value.
		/// </summary>
        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		/// <param name="educationLevelId">The value of the column "education_level_id" which will be deleted.</param>
		public void Delete(string catalog, int educationLevelId)
		{
			const string sql = "DELETE FROM hrm.education_levels WHERE education_level_id=@0;";
			Factory.NonQuery(catalog, sql, educationLevelId);
		}

		/// <summary>
		/// Performs a select statement on table "hrm.education_levels" producing a paged result of 10.
		/// </summary>
        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		/// <returns>Returns the first page of collection of "EducationLevel" class.</returns>
		public IEnumerable<MixERP.Net.Entities.HRM.EducationLevel> GetPagedResult(string catalog)
		{
			const string sql = "SELECT * FROM hrm.education_levels ORDER BY education_level_id LIMIT 10 OFFSET 0;";
			return Factory.Get<MixERP.Net.Entities.HRM.EducationLevel>(catalog, sql);
		}

		/// <summary>
		/// Performs a select statement on table "hrm.education_levels" producing a paged result of 10.
		/// </summary>
        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		/// <param name="pageNumber">Enter the page number to produce the paged result.</param>
		/// <returns>Returns collection of "EducationLevel" class.</returns>
		public IEnumerable<MixERP.Net.Entities.HRM.EducationLevel> GetPagedResult(string catalog, long pageNumber)
		{
			long offset = (pageNumber -1) * 10;
			const string sql = "SELECT * FROM hrm.education_levels ORDER BY education_level_id LIMIT 10 OFFSET @0;";
				
			return Factory.Get<MixERP.Net.Entities.HRM.EducationLevel>(catalog, sql, offset);
		}
	}
}