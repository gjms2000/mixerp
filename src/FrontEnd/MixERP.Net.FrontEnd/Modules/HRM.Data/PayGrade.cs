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
    public class PayGrade
    {
		/// <summary>
		/// Performs SQL count on the table "hrm.pay_grades".
		/// </summary>
        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		/// <returns>Returns the number of rows of the table "hrm.pay_grades".</returns>
		public long Count(string catalog)
		{
			const string sql = "SELECT COUNT(*) FROM hrm.pay_grades;";
			return Factory.Scalar<long>(catalog, sql);
		}

		/// <summary>
		/// Executes a select query on the table "hrm.pay_grades" with a where filter on the column "pay_grade_id" to return a single instance of the "PayGrade" class. 
		/// </summary>
        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		/// <param name="payGradeId">The column "pay_grade_id" parameter used on where filter.</param>
		/// <returns>Returns a non-live, non-mapped instance of "PayGrade" class mapped to the database row.</returns>
		public MixERP.Net.Entities.HRM.PayGrade Get(string catalog, int payGradeId)
		{
			const string sql = "SELECT * FROM hrm.pay_grades WHERE pay_grade_id=@0;";
			return Factory.Get<MixERP.Net.Entities.HRM.PayGrade>(catalog, sql, payGradeId).FirstOrDefault();
		}

        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		public static IEnumerable<DisplayField> GetDisplayFields(string catalog)
		{
			List<DisplayField> displayFields = new List<DisplayField>();

			const string sql = "SELECT pay_grade_id AS key, pay_grade_code || ' (' || pay_grade_name || ')' as value FROM hrm.pay_grades;";
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
		/// Inserts the instance of PayGrade class on the database table "hrm.pay_grades".
		/// </summary>
        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		/// <param name="payGrade">The instance of "PayGrade" class to insert.</param>
		public void Add(string catalog, MixERP.Net.Entities.HRM.PayGrade payGrade)
		{
			Factory.Insert(catalog, payGrade);
		}

		/// <summary>
		/// Updates the row of the table "hrm.pay_grades" with an instance of "PayGrade" class against the primary key value.
		/// </summary>
        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		/// <param name="payGrade">The instance of "PayGrade" class to update.</param>
		/// <param name="payGradeId">The value of the column "pay_grade_id" which will be updated.</param>
		public void Update(string catalog, MixERP.Net.Entities.HRM.PayGrade payGrade, int payGradeId)
		{
			Factory.Update(catalog, payGrade, payGradeId);
		}

		/// <summary>
		/// Deletes the row of the table "hrm.pay_grades" against the primary key value.
		/// </summary>
        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		/// <param name="payGradeId">The value of the column "pay_grade_id" which will be deleted.</param>
		public void Delete(string catalog, int payGradeId)
		{
			const string sql = "DELETE FROM hrm.pay_grades WHERE pay_grade_id=@0;";
			Factory.NonQuery(catalog, sql, payGradeId);
		}

		/// <summary>
		/// Performs a select statement on table "hrm.pay_grades" producing a paged result of 10.
		/// </summary>
        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		/// <returns>Returns the first page of collection of "PayGrade" class.</returns>
		public IEnumerable<MixERP.Net.Entities.HRM.PayGrade> GetPagedResult(string catalog)
		{
			const string sql = "SELECT * FROM hrm.pay_grades ORDER BY pay_grade_id LIMIT 10 OFFSET 0;";
			return Factory.Get<MixERP.Net.Entities.HRM.PayGrade>(catalog, sql);
		}

		/// <summary>
		/// Performs a select statement on table "hrm.pay_grades" producing a paged result of 10.
		/// </summary>
        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		/// <param name="pageNumber">Enter the page number to produce the paged result.</param>
		/// <returns>Returns collection of "PayGrade" class.</returns>
		public IEnumerable<MixERP.Net.Entities.HRM.PayGrade> GetPagedResult(string catalog, long pageNumber)
		{
			long offset = (pageNumber -1) * 10;
			const string sql = "SELECT * FROM hrm.pay_grades ORDER BY pay_grade_id LIMIT 10 OFFSET @0;";
				
			return Factory.Get<MixERP.Net.Entities.HRM.PayGrade>(catalog, sql, offset);
		}
	}
}