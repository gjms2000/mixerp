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
    [PrimaryKey("", autoIncrement=false)]
    [FunctionName("transactions.get_eoy_profit_summary")]
    [ExplicitColumns]
    public sealed class DbGetEoyProfitSummaryResult : PetaPocoDB.Record<DbGetEoyProfitSummaryResult>, IPoco
    {
        [Column("profit_before_tax")]
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal ProfitBeforeTax { get; set; }
    
        [Column("tax_rate")]
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal TaxRate { get; set; }
    
        [Column("tax")]
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal Tax { get; set; }
    }
}