// ReSharper disable All
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
// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("", autoIncrement = false)]
    [FunctionName("transactions.get_total_sales_by_office")]
    [ExplicitColumns]
    public sealed class DbGetTotalSalesByOfficeResult : PetaPocoDB.Record<DbGetTotalSalesByOfficeResult>, IPoco
    {
        [Column("office_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int OfficeId { get; set; }

        [Column("office_code")]
        [ColumnDbType("character varying", 0, false, "")]
        public string OfficeCode { get; set; }

        [Column("office_name")]
        [ColumnDbType("character varying", 0, false, "")]
        public string OfficeName { get; set; }

        [Column("total_sales")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal TotalSales { get; set; }
    }
}