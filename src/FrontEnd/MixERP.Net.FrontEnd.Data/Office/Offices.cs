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

using System;
using System.Collections.Generic;
using MixERP.Net.Entities.Office;
using PetaPoco;

namespace MixERP.Net.FrontEnd.Data.Office
{
    public static class Offices
    {
        public static IEnumerable<DbGetOfficesResult> GetOffices(string catalog)
        {
            return Factory.Get<DbGetOfficesResult>(catalog, "SELECT * FROM office.get_offices();");
        }

        public static void SaveOffice(string catalog, string officeCode, string officeName, string nickName,
            DateTime registrationDate, string currencyCode, string currencySymbol, string currencyName,
            string hundredthName, string fiscalYearCode,
            string fiscalYearName, DateTime startsFrom, DateTime endsOn,
            decimal incomeTaxRate, int weekStartDay, DateTime transactionStartDate,
            string adminName,
            string username, string password)
        {
            const string sql =
                "SELECT * FROM office.add_office(@0::varchar(12), @1::varchar(150), @2::varchar(50), @3::date, @4::varchar(12), @5::varchar(12), @6::varchar(48), @7::varchar(48), @8::varchar(12), @9::varchar(50), @10::date,@11::date, @12::numeric, @13::int, @14::date, @15::varchar(100), @16::varchar(50), @17::varchar(48));";

            Factory.NonQuery(catalog, sql, officeCode, officeName, nickName, registrationDate, currencyCode,
                currencySymbol, currencyName, hundredthName, fiscalYearCode, fiscalYearName, startsFrom, endsOn,
                incomeTaxRate, weekStartDay, transactionStartDate, adminName, username, password);
        }
    }
}