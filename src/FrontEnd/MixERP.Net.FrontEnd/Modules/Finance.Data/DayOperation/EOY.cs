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
using System.Linq;
using MixERP.Net.Entities.Transactions;
using PetaPoco;

namespace MixERP.Net.Core.Modules.Finance.Data.DayOperation
{
    public static class EOY
    {
        public static IEnumerable<DbGetPlAppropriationDataResult> GetPlAppropriationData(string catalog, int officeId)
        {
            const string sql = "SELECT * FROM transactions.get_pl_appropriation_data(@0::integer);";
            return Factory.Get<DbGetPlAppropriationDataResult>(catalog, sql, officeId);
        }

        public static DbGetEoyProfitSummaryResult GetEoyProfitSummary(string catalog, int officeId)
        {
            const string sql = "SELECT * FROM transactions.get_eoy_profit_summary(@0::integer);";
            return Factory.Get<DbGetEoyProfitSummaryResult>(catalog, sql, officeId).FirstOrDefault();
        }

        public static bool IsNewFiscalYearCreated(string catalog, int officeId)
        {
            const string sql = "SELECT * FROM core.is_new_fiscal_year_created(@0::integer);";
            return Factory.Get<bool>(catalog, sql, officeId).FirstOrDefault();
        }

        public static void CreateNewFiscalYear(string catalog, int officeId, int userId, string fiscalYearCode,
            string fiscalYearName)
        {
            const string sql =
                "SELECT * FROM core.create_new_fiscal_year(@0::integer, @1::integer, @2::character varying(12), @3::character varying(50));";
            Factory.NonQuery(catalog, sql, officeId, userId, fiscalYearCode, fiscalYearName);
        }
    }
}