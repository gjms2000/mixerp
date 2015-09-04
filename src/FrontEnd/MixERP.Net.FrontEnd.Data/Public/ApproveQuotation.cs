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

using System.Linq;
using MixERP.Net.Entities.Public.Meta;
using PetaPoco;

namespace MixERP.Net.FrontEnd.Data.Public
{
    public static class ApproveQuotation
    {
        public static SalesQuotationValidation GetQuotation(string validationId)
        {
            const string sql = "SELECT * FROM public.sales_quotation_validation WHERE validation_id=@0;";
            return Factory.Get<SalesQuotationValidation>(Factory.MetaDatabase, sql, validationId).FirstOrDefault();
        }

        public static void AcceptQuote(string validationId)
        {
            const string sql = @"UPDATE public.sales_quotation_validation
                                SET accepted = true, accepted_on = NOW()
                                WHERE validation_id = @0;";

            Factory.NonQuery(Factory.MetaDatabase, sql, validationId);
        }
    }
}