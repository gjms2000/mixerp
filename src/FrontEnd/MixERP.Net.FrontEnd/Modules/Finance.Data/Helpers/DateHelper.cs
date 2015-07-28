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

using System.Collections.ObjectModel;
using System.Data;
using MixERP.Net.ApplicationState;
using MixERP.Net.Common;
using MixERP.Net.DbFactory;
using Npgsql;

namespace MixERP.Net.Core.Modules.Finance.Data.Helpers
{
    public static class DateHelper
    {
        public static Collection<FrequencyDates> GetFrequencyDates(string catalog)
        {
            Collection<FrequencyDates> applicationDates = new Collection<FrequencyDates>();

            const string sql =
                "SELECT office_id AS office_id, core.get_date(office_id) AS today, core.get_month_start_date(office_id) AS month_start_date,core.get_month_end_date(office_id) AS month_end_date, core.get_quarter_start_date(office_id) AS quarter_start_date, core.get_quarter_end_date(office_id) AS quarter_end_date, core.get_fiscal_half_start_date(office_id) AS fiscal_half_start_date, core.get_fiscal_half_end_date(office_id) AS fiscal_half_end_date, core.get_fiscal_year_start_date(office_id) AS fiscal_year_start_date, core.get_fiscal_year_end_date(office_id) AS fiscal_year_end_date FROM office.offices;";
            using (NpgsqlCommand command = new NpgsqlCommand(sql))
            {
                using (DataTable table = DbOperation.GetDataTable(catalog, command))
                {
                    if (table != null && table.Rows != null && table.Rows.Count > 0)
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            applicationDates.Add(GetApplicationDateModel(row));
                        }
                    }
                }
            }

            return applicationDates;
        }

        private static FrequencyDates GetApplicationDateModel(DataRow row)
        {
            if (row == null)
            {
                return null;
            }

            FrequencyDates applicationDate = new FrequencyDates();
            applicationDate.OfficeId = Conversion.TryCastInteger(row["office_id"]);
            applicationDate.Today = Conversion.TryCastDate(row["today"]);
            applicationDate.MonthStartDate = Conversion.TryCastDate(row["month_start_date"]);
            applicationDate.MonthEndDate = Conversion.TryCastDate(row["month_end_date"]);
            applicationDate.QuarterStartDate = Conversion.TryCastDate(row["quarter_start_date"]);
            applicationDate.QuarterEndDate = Conversion.TryCastDate(row["quarter_end_date"]);
            applicationDate.FiscalHalfStartDate = Conversion.TryCastDate(row["fiscal_half_start_date"]);
            applicationDate.FiscalHalfEndDate = Conversion.TryCastDate(row["fiscal_half_end_date"]);
            applicationDate.FiscalYearStartDate = Conversion.TryCastDate(row["fiscal_year_start_date"]);
            applicationDate.FiscalYearEndDate = Conversion.TryCastDate(row["fiscal_year_end_date"]);

            return applicationDate;
        }

    }
}