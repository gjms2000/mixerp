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
    public class Exit
    {
		/// <summary>
		/// Performs SQL count on the table "hrm.exits".
		/// </summary>
        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		/// <returns>Returns the number of rows of the table "hrm.exits".</returns>
		public long Count(string catalog)
		{
			const string sql = "SELECT COUNT(*) FROM hrm.exits;";
			return Factory.Scalar<long>(catalog, sql);
		}

		/// <summary>
		/// Executes a select query on the table "hrm.exits" with a where filter on the column "exit_id" to return a single instance of the "Exit" class. 
		/// </summary>
        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		/// <param name="exitId">The column "exit_id" parameter used on where filter.</param>
		/// <returns>Returns a non-live, non-mapped instance of "Exit" class mapped to the database row.</returns>
		public MixERP.Net.Entities.HRM.Exit Get(string catalog, long exitId)
		{
			const string sql = "SELECT * FROM hrm.exits WHERE exit_id=@0;";
			return Factory.Get<MixERP.Net.Entities.HRM.Exit>(catalog, sql, exitId).FirstOrDefault();
		}

        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		public static IEnumerable<DisplayField> GetDisplayFields(string catalog)
		{
			List<DisplayField> displayFields = new List<DisplayField>();

			const string sql = "SELECT exit_id AS key, exit_id as value FROM hrm.exits;";
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
		/// Inserts the instance of Exit class on the database table "hrm.exits".
		/// </summary>
        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		/// <param name="exit">The instance of "Exit" class to insert.</param>
		public void Add(string catalog, MixERP.Net.Entities.HRM.Exit exit)
		{
			Factory.Insert(catalog, exit);
		}

		/// <summary>
		/// Updates the row of the table "hrm.exits" with an instance of "Exit" class against the primary key value.
		/// </summary>
        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		/// <param name="exit">The instance of "Exit" class to update.</param>
		/// <param name="exitId">The value of the column "exit_id" which will be updated.</param>
		public void Update(string catalog, MixERP.Net.Entities.HRM.Exit exit, long exitId)
		{
			Factory.Update(catalog, exit, exitId);
		}

		/// <summary>
		/// Deletes the row of the table "hrm.exits" against the primary key value.
		/// </summary>
        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		/// <param name="exitId">The value of the column "exit_id" which will be deleted.</param>
		public void Delete(string catalog, long exitId)
		{
			const string sql = "DELETE FROM hrm.exits WHERE exit_id=@0;";
			Factory.NonQuery(catalog, sql, exitId);
		}

		/// <summary>
		/// Performs a select statement on table "hrm.exits" producing a paged result of 10.
		/// </summary>
        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		/// <returns>Returns the first page of collection of "Exit" class.</returns>
		public IEnumerable<MixERP.Net.Entities.HRM.Exit> GetPagedResult(string catalog)
		{
			const string sql = "SELECT * FROM hrm.exits ORDER BY exit_id LIMIT 10 OFFSET 0;";
			return Factory.Get<MixERP.Net.Entities.HRM.Exit>(catalog, sql);
		}

		/// <summary>
		/// Performs a select statement on table "hrm.exits" producing a paged result of 10.
		/// </summary>
        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		/// <param name="pageNumber">Enter the page number to produce the paged result.</param>
		/// <returns>Returns collection of "Exit" class.</returns>
		public IEnumerable<MixERP.Net.Entities.HRM.Exit> GetPagedResult(string catalog, long pageNumber)
		{
			long offset = (pageNumber -1) * 10;
			const string sql = "SELECT * FROM hrm.exits ORDER BY exit_id LIMIT 10 OFFSET @0;";
				
			return Factory.Get<MixERP.Net.Entities.HRM.Exit>(catalog, sql, offset);
		}
	}
}