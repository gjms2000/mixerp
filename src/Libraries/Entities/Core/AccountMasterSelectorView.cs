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
    [TableName("core.account_master_selector_view")]
    [ExplicitColumns]
    public sealed class AccountMasterSelectorView : PetaPocoDB.Record<AccountMasterSelectorView>, IPoco
    {
        [Column("account_master_id")]
        [ColumnDbType("int2", 0, true, "")] 
        public short? AccountMasterId { get; set; }
    
        [Column("account_master_code")]
        [ColumnDbType("varchar", 3, true, "")] 
        public string AccountMasterCode { get; set; }
    
        [Column("account_master_name")]
        [ColumnDbType("varchar", 40, true, "")] 
        public string AccountMasterName { get; set; }
    
        [Column("normally_debit")]
        [ColumnDbType("bool", 0, true, "")] 
        public bool? NormallyDebit { get; set; }
    
        [Column("parent_account_master_id")]
        [ColumnDbType("int2", 0, true, "")] 
        public short? ParentAccountMasterId { get; set; }
    }
}