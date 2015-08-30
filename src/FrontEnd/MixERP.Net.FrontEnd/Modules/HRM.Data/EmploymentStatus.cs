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
    public class EmploymentStatus
    {
		/// <summary>
		/// Performs SQL count on the table "hrm.employment_statuses".
		/// </summary>
        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		/// <returns>Returns the number of rows of the table "hrm.employment_statuses".</returns>
		public long Count(string catalog)
		{
			const string sql = "SELECT COUNT(*) FROM hrm.employment_statuses;";
			return Factory.Scalar<long>(catalog, sql);
		}

		/// <summary>
		/// Executes a select query on the table "hrm.employment_statuses" with a where filter on the column "employment_status_id" to return a single instance of the "EmploymentStatus" class. 
		/// </summary>
        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		/// <param name="employmentStatusId">The column "employment_status_id" parameter used on where filter.</param>
		/// <returns>Returns a non-live, non-mapped instance of "EmploymentStatus" class mapped to the database row.</returns>
		public MixERP.Net.Entities.HRM.EmploymentStatus Get(string catalog, int employmentStatusId)
		{
			const string sql = "SELECT * FROM hrm.employment_statuses WHERE employment_status_id=@0;";
			return Factory.Get<MixERP.Net.Entities.HRM.EmploymentStatus>(catalog, sql, employmentStatusId).FirstOrDefault();
		}

        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		public static IEnumerable<DisplayField> GetDisplayFields(string catalog)
		{
			List<DisplayField> displayFields = new List<DisplayField>();

			const string sql = "SELECT employment_status_id AS key, employment_status_code || ' (' || employment_status_name || ')' as value FROM hrm.employment_statuses;";
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
		/// Inserts the instance of EmploymentStatus class on the database table "hrm.employment_statuses".
		/// </summary>
        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		/// <param name="employmentStatus">The instance of "EmploymentStatus" class to insert.</param>
		public void Add(string catalog, MixERP.Net.Entities.HRM.EmploymentStatus employmentStatus)
		{
			Factory.Insert(catalog, employmentStatus);
		}

		/// <summary>
		/// Updates the row of the table "hrm.employment_statuses" with an instance of "EmploymentStatus" class against the primary key value.
		/// </summary>
        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		/// <param name="employmentStatus">The instance of "EmploymentStatus" class to update.</param>
		/// <param name="employmentStatusId">The value of the column "employment_status_id" which will be updated.</param>
		public void Update(string catalog, MixERP.Net.Entities.HRM.EmploymentStatus employmentStatus, int employmentStatusId)
		{
			Factory.Update(catalog, employmentStatus, employmentStatusId);
		}

		/// <summary>
		/// Deletes the row of the table "hrm.employment_statuses" against the primary key value.
		/// </summary>
        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		/// <param name="employmentStatusId">The value of the column "employment_status_id" which will be deleted.</param>
		public void Delete(string catalog, int employmentStatusId)
		{
			const string sql = "DELETE FROM hrm.employment_statuses WHERE employment_status_id=@0;";
			Factory.NonQuery(catalog, sql, employmentStatusId);
		}

		/// <summary>
		/// Performs a select statement on table "hrm.employment_statuses" producing a paged result of 10.
		/// </summary>
        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		/// <returns>Returns the first page of collection of "EmploymentStatus" class.</returns>
		public IEnumerable<MixERP.Net.Entities.HRM.EmploymentStatus> GetPagedResult(string catalog)
		{
			const string sql = "SELECT * FROM hrm.employment_statuses ORDER BY employment_status_id LIMIT 10 OFFSET 0;";
			return Factory.Get<MixERP.Net.Entities.HRM.EmploymentStatus>(catalog, sql);
		}

		/// <summary>
		/// Performs a select statement on table "hrm.employment_statuses" producing a paged result of 10.
		/// </summary>
        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		/// <param name="pageNumber">Enter the page number to produce the paged result.</param>
		/// <returns>Returns collection of "EmploymentStatus" class.</returns>
		public IEnumerable<MixERP.Net.Entities.HRM.EmploymentStatus> GetPagedResult(string catalog, long pageNumber)
		{
			long offset = (pageNumber -1) * 10;
			const string sql = "SELECT * FROM hrm.employment_statuses ORDER BY employment_status_id LIMIT 10 OFFSET @0;";
				
			return Factory.Get<MixERP.Net.Entities.HRM.EmploymentStatus>(catalog, sql, offset);
		}
	}
}