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

using PetaPoco;

namespace MixERP.Net.TransactionGovernor.Data.Verification
{
    public static class Stack
    {
        public static int CountItemsInVerificationStack(string catalog, int officeId)
        {
            const string sql =
                "SELECT COUNT(*) FROM transactions.transaction_master WHERE verification_status_id = 0 AND office_id = @0 AND value_date <= transactions.get_value_date(@0);";

            return Factory.Scalar<int>(catalog, sql, officeId);
        }
    }
}