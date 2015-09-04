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

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement=false)]
    [TableName("core.salesperson_selector_view")]
    [ExplicitColumns]
    public sealed class SalespersonSelectorView : PetaPocoDB.Record<SalespersonSelectorView>, IPoco
    {
        [Column("salesperson_id")]
        [ColumnDbType("int4", 0, true, "")] 
        public int? SalespersonId { get; set; }
    
        [Column("salesperson_code")]
        [ColumnDbType("varchar", 12, true, "")] 
        public string SalespersonCode { get; set; }
    
        [Column("salesperson_name")]
        [ColumnDbType("varchar", 100, true, "")] 
        public string SalespersonName { get; set; }
    
        [Column("address")]
        [ColumnDbType("varchar", 100, true, "")] 
        public string Address { get; set; }
    
        [Column("contact_number")]
        [ColumnDbType("varchar", 50, true, "")] 
        public string ContactNumber { get; set; }
    
        [Column("commission_rate")]
        [ColumnDbType("decimal_strict2", 0, true, "")] 
        public decimal? CommissionRate { get; set; }
    
        [Column("account_name")]
        [ColumnDbType("varchar", 100, true, "")] 
        public string AccountName { get; set; }
    }
}