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
    public class Employee
    {
		/// <summary>
		/// Performs SQL count on the table "hrm.employees".
		/// </summary>
        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		/// <returns>Returns the number of rows of the table "hrm.employees".</returns>
		public long Count(string catalog)
		{
			const string sql = "SELECT COUNT(*) FROM hrm.employees;";
			return Factory.Scalar<long>(catalog, sql);
		}

		/// <summary>
		/// Executes a select query on the table "hrm.employees" with a where filter on the column "employee_id" to return a single instance of the "Employee" class. 
		/// </summary>
        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		/// <param name="employeeId">The column "employee_id" parameter used on where filter.</param>
		/// <returns>Returns a non-live, non-mapped instance of "Employee" class mapped to the database row.</returns>
		public MixERP.Net.Entities.HRM.Employee Get(string catalog, int employeeId)
		{
			const string sql = "SELECT * FROM hrm.employees WHERE employee_id=@0;";
			return Factory.Get<MixERP.Net.Entities.HRM.Employee>(catalog, sql, employeeId).FirstOrDefault();
		}

        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		public static IEnumerable<DisplayField> GetDisplayFields(string catalog)
		{
			List<DisplayField> displayFields = new List<DisplayField>();

			const string sql = "SELECT employee_id AS key, first_name as value FROM hrm.employees;";
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
		/// Inserts the instance of Employee class on the database table "hrm.employees".
		/// </summary>
        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		/// <param name="employee">The instance of "Employee" class to insert.</param>
		public void Add(string catalog, MixERP.Net.Entities.HRM.Employee employee)
		{
			Factory.Insert(catalog, employee);
		}

		/// <summary>
		/// Updates the row of the table "hrm.employees" with an instance of "Employee" class against the primary key value.
		/// </summary>
        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		/// <param name="employee">The instance of "Employee" class to update.</param>
		/// <param name="employeeId">The value of the column "employee_id" which will be updated.</param>
		public void Update(string catalog, MixERP.Net.Entities.HRM.Employee employee, int employeeId)
		{
			Factory.Update(catalog, employee, employeeId);
		}

		/// <summary>
		/// Deletes the row of the table "hrm.employees" against the primary key value.
		/// </summary>
        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		/// <param name="employeeId">The value of the column "employee_id" which will be deleted.</param>
		public void Delete(string catalog, int employeeId)
		{
			const string sql = "DELETE FROM hrm.employees WHERE employee_id=@0;";
			Factory.NonQuery(catalog, sql, employeeId);
		}

		/// <summary>
		/// Performs a select statement on table "hrm.employees" producing a paged result of 10.
		/// </summary>
        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		/// <returns>Returns the first page of collection of "Employee" class.</returns>
		public IEnumerable<MixERP.Net.Entities.HRM.Employee> GetPagedResult(string catalog)
		{
			const string sql = "SELECT * FROM hrm.employees ORDER BY employee_id LIMIT 10 OFFSET 0;";
			return Factory.Get<MixERP.Net.Entities.HRM.Employee>(catalog, sql);
		}

		/// <summary>
		/// Performs a select statement on table "hrm.employees" producing a paged result of 10.
		/// </summary>
        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		/// <param name="pageNumber">Enter the page number to produce the paged result.</param>
		/// <returns>Returns collection of "Employee" class.</returns>
		public IEnumerable<MixERP.Net.Entities.HRM.Employee> GetPagedResult(string catalog, long pageNumber)
		{
			long offset = (pageNumber -1) * 10;
			const string sql = "SELECT * FROM hrm.employees ORDER BY employee_id LIMIT 10 OFFSET @0;";
				
			return Factory.Get<MixERP.Net.Entities.HRM.Employee>(catalog, sql, offset);
		}
	}
}