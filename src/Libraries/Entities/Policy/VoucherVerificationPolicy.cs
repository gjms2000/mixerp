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

namespace MixERP.Net.Entities.Policy
{
    [PrimaryKey("policy_id", autoIncrement=true)]
    [TableName("policy.voucher_verification_policy")]
    [ExplicitColumns]
    public sealed class VoucherVerificationPolicy : PetaPocoDB.Record<VoucherVerificationPolicy>, IPoco
    {
        [Column("policy_id")]
        [ColumnDbType("int4", 0, false, "nextval('policy.voucher_verification_policy_policy_id_seq'::regclass)")] 
        public int PolicyId { get; set; }
    
        [Column("user_id")]
        [ColumnDbType("int4", 0, true, "")] 
        public int? UserId { get; set; }
    
        [Column("can_verify_sales_transactions")]
        [ColumnDbType("bool", 0, false, "false")] 
        public bool CanVerifySalesTransactions { get; set; }
    
        [Column("sales_verification_limit")]
        [ColumnDbType("money_strict2", 0, false, "0")] 
        public decimal SalesVerificationLimit { get; set; }
    
        [Column("can_verify_purchase_transactions")]
        [ColumnDbType("bool", 0, false, "false")] 
        public bool CanVerifyPurchaseTransactions { get; set; }
    
        [Column("purchase_verification_limit")]
        [ColumnDbType("money_strict2", 0, false, "0")] 
        public decimal PurchaseVerificationLimit { get; set; }
    
        [Column("can_verify_gl_transactions")]
        [ColumnDbType("bool", 0, false, "false")] 
        public bool CanVerifyGlTransactions { get; set; }
    
        [Column("gl_verification_limit")]
        [ColumnDbType("money_strict2", 0, false, "0")] 
        public decimal GlVerificationLimit { get; set; }
    
        [Column("can_self_verify")]
        [ColumnDbType("bool", 0, false, "false")] 
        public bool CanSelfVerify { get; set; }
    
        [Column("self_verification_limit")]
        [ColumnDbType("money_strict2", 0, false, "0")] 
        public decimal SelfVerificationLimit { get; set; }
    
        [Column("effective_from")]
        [ColumnDbType("date", 0, false, "")] 
        public DateTime EffectiveFrom { get; set; }
    
        [Column("ends_on")]
        [ColumnDbType("date", 0, false, "")] 
        public DateTime EndsOn { get; set; }
    
        [Column("is_active")]
        [ColumnDbType("bool", 0, false, "")] 
        public bool IsActive { get; set; }
    
        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }
    
        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }
    
        [Column("office_id")]
        [ColumnDbType("int4", 0, false, "")] 
        public int OfficeId { get; set; }
    }
}