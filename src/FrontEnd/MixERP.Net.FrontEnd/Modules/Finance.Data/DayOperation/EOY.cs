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
    }
}