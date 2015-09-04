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
    [PrimaryKey("income_tax_setup_id", autoIncrement=true)]
    [TableName("core.income_tax_setup")]
    [ExplicitColumns]
    public sealed class IncomeTaxSetup : PetaPocoDB.Record<IncomeTaxSetup>, IPoco
    {
        [Column("income_tax_setup_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.income_tax_setup_income_tax_setup_id_seq'::regclass)")] 
        public int IncomeTaxSetupId { get; set; }
    
        [Column("office_id")]
        [ColumnDbType("int4", 0, false, "")] 
        public int OfficeId { get; set; }
    
        [Column("effective_from")]
        [ColumnDbType("date", 0, false, "")] 
        public DateTime EffectiveFrom { get; set; }
    
        [Column("tax_rate")]
        [ColumnDbType("decimal_strict2", 0, false, "")] 
        public decimal TaxRate { get; set; }
    
        [Column("tax_authority_id")]
        [ColumnDbType("int4", 0, false, "")] 
        public int TaxAuthorityId { get; set; }
    
        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }
    
        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }
    }
}