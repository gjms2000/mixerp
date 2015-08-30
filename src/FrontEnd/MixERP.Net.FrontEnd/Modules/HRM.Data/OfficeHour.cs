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
    public class OfficeHour
    {
		/// <summary>
		/// Performs SQL count on the table "hrm.office_hours".
		/// </summary>
        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		/// <returns>Returns the number of rows of the table "hrm.office_hours".</returns>
		public long Count(string catalog)
		{
			const string sql = "SELECT COUNT(*) FROM hrm.office_hours;";
			return Factory.Scalar<long>(catalog, sql);
		}

		/// <summary>
		/// Executes a select query on the table "hrm.office_hours" with a where filter on the column "week_day_id" to return a single instance of the "OfficeHour" class. 
		/// </summary>
        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		/// <param name="weekDayId">The column "week_day_id" parameter used on where filter.</param>
		/// <returns>Returns a non-live, non-mapped instance of "OfficeHour" class mapped to the database row.</returns>
		public MixERP.Net.Entities.HRM.OfficeHour Get(string catalog, int weekDayId)
		{
			const string sql = "SELECT * FROM hrm.office_hours WHERE week_day_id=@0;";
			return Factory.Get<MixERP.Net.Entities.HRM.OfficeHour>(catalog, sql, weekDayId).FirstOrDefault();
		}

        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		public static IEnumerable<DisplayField> GetDisplayFields(string catalog)
		{
			List<DisplayField> displayFields = new List<DisplayField>();

			const string sql = "SELECT week_day_id AS key, week_day_id as value FROM hrm.office_hours;";
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
		/// Inserts the instance of OfficeHour class on the database table "hrm.office_hours".
		/// </summary>
        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		/// <param name="officeHour">The instance of "OfficeHour" class to insert.</param>
		public void Add(string catalog, MixERP.Net.Entities.HRM.OfficeHour officeHour)
		{
			Factory.Insert(catalog, officeHour);
		}

		/// <summary>
		/// Updates the row of the table "hrm.office_hours" with an instance of "OfficeHour" class against the primary key value.
		/// </summary>
        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		/// <param name="officeHour">The instance of "OfficeHour" class to update.</param>
		/// <param name="weekDayId">The value of the column "week_day_id" which will be updated.</param>
		public void Update(string catalog, MixERP.Net.Entities.HRM.OfficeHour officeHour, int weekDayId)
		{
			Factory.Update(catalog, officeHour, weekDayId);
		}

		/// <summary>
		/// Deletes the row of the table "hrm.office_hours" against the primary key value.
		/// </summary>
        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		/// <param name="weekDayId">The value of the column "week_day_id" which will be deleted.</param>
		public void Delete(string catalog, int weekDayId)
		{
			const string sql = "DELETE FROM hrm.office_hours WHERE week_day_id=@0;";
			Factory.NonQuery(catalog, sql, weekDayId);
		}

		/// <summary>
		/// Performs a select statement on table "hrm.office_hours" producing a paged result of 10.
		/// </summary>
        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		/// <returns>Returns the first page of collection of "OfficeHour" class.</returns>
		public IEnumerable<MixERP.Net.Entities.HRM.OfficeHour> GetPagedResult(string catalog)
		{
			const string sql = "SELECT * FROM hrm.office_hours ORDER BY week_day_id LIMIT 10 OFFSET 0;";
			return Factory.Get<MixERP.Net.Entities.HRM.OfficeHour>(catalog, sql);
		}

		/// <summary>
		/// Performs a select statement on table "hrm.office_hours" producing a paged result of 10.
		/// </summary>
        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		/// <param name="pageNumber">Enter the page number to produce the paged result.</param>
		/// <returns>Returns collection of "OfficeHour" class.</returns>
		public IEnumerable<MixERP.Net.Entities.HRM.OfficeHour> GetPagedResult(string catalog, long pageNumber)
		{
			long offset = (pageNumber -1) * 10;
			const string sql = "SELECT * FROM hrm.office_hours ORDER BY week_day_id LIMIT 10 OFFSET @0;";
				
			return Factory.Get<MixERP.Net.Entities.HRM.OfficeHour>(catalog, sql, offset);
		}
	}
}