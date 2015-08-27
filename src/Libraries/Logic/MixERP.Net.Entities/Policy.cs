

using MixERP.Net.Entities.Contracts;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MixERP.Net.Entities.Policy
{

    [TableName("policy.lock_outs")]
    [PrimaryKey("lock_out_id", autoIncrement=false)]
    [ExplicitColumns]
    public class LockOut : PetaPocoDB.Record<LockOut> , IPoco
    {
        [Column("lock_out_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long LockOutId { get; set; }

        [Column("user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int UserId { get; set; }

        [Column("lock_out_time")] 
        [ColumnDbType("timestamptz", 0, "now()")] 
        public DateTime LockOutTime { get; set; }

        [Column("lock_out_till")] 
        [ColumnDbType("timestamptz", 0, "(now() + '00:05:00'::interval)")] 
        public DateTime LockOutTill { get; set; }

    }

    [TableName("policy.menu_access")]
    [PrimaryKey("access_id", autoIncrement=false)]
    [ExplicitColumns]
    public class MenuAccess : PetaPocoDB.Record<MenuAccess> , IPoco
    {
        [Column("access_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long AccessId { get; set; }

        [Column("office_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int OfficeId { get; set; }

        [Column("menu_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int MenuId { get; set; }

        [Column("user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? UserId { get; set; }

    }

    [TableName("policy.store_policies")]
    [PrimaryKey("store_policy_id", autoIncrement=false)]
    [ExplicitColumns]
    public class StorePolicy : PetaPocoDB.Record<StorePolicy> , IPoco
    {
        [Column("store_policy_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long StorePolicyId { get; set; }

        [Column("written_by_user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int WrittenByUserId { get; set; }

        [Column("status")] 
        [ColumnDbType("bool", 0, "")] 
        public bool Status { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, "now()")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("policy.store_policy_details")]
    [PrimaryKey("store_policy_detail_id", autoIncrement=false)]
    [ExplicitColumns]
    public class StorePolicyDetail : PetaPocoDB.Record<StorePolicyDetail> , IPoco
    {
        [Column("store_policy_detail_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long StorePolicyDetailId { get; set; }

        [Column("store_policy_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long StorePolicyId { get; set; }

        [Column("user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int UserId { get; set; }

        [Column("store_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int StoreId { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, "now()")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("policy.menu_policy")]
    [PrimaryKey("policy_id", autoIncrement=false)]
    [ExplicitColumns]
    public class MenuPolicy : PetaPocoDB.Record<MenuPolicy> , IPoco
    {
        [Column("policy_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int PolicyId { get; set; }

        [Column("menu_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int MenuId { get; set; }

        [Column("office_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? OfficeId { get; set; }

        [Column("inherit_in_child_offices")] 
        [ColumnDbType("bool", 0, "false")] 
        public bool InheritInChildOffices { get; set; }

        [Column("role_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? RoleId { get; set; }

        [Column("user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? UserId { get; set; }

        [Column("scope")] 
        [ColumnDbType("varchar", 12, "")] 
        public string Scope { get; set; }

    }

    [TableName("policy.http_actions")]
    [PrimaryKey("http_action_code", autoIncrement=false)]
    [ExplicitColumns]
    public class HttpAction : PetaPocoDB.Record<HttpAction> , IPoco
    {
        [Column("http_action_code")] 
        [ColumnDbType("text", 0, "")] 
        public string HttpActionCode { get; set; }

    }

    [TableName("policy.api_access_policy")]
    [PrimaryKey("api_access_policy_id", autoIncrement=false)]
    [ExplicitColumns]
    public class ApiAccessPolicy : PetaPocoDB.Record<ApiAccessPolicy> , IPoco
    {
        [Column("api_access_policy_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long ApiAccessPolicyId { get; set; }

        [Column("user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int UserId { get; set; }

        [Column("office_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int OfficeId { get; set; }

        [Column("poco_type_name")] 
        [ColumnDbType("text", 0, "")] 
        public string PocoTypeName { get; set; }

        [Column("http_action_code")] 
        [ColumnDbType("text", 0, "")] 
        public string HttpActionCode { get; set; }

        [Column("valid_till")] 
        [ColumnDbType("date", 0, "")] 
        public DateTime ValidTill { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, "now()")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("policy.voucher_verification_policy")]
    [PrimaryKey("policy_id", autoIncrement=false)]
    [ExplicitColumns]
    public class VoucherVerificationPolicy : PetaPocoDB.Record<VoucherVerificationPolicy> , IPoco
    {
        [Column("policy_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int PolicyId { get; set; }

        [Column("user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? UserId { get; set; }

        [Column("can_verify_sales_transactions")] 
        [ColumnDbType("bool", 0, "false")] 
        public bool CanVerifySalesTransactions { get; set; }

        [Column("sales_verification_limit")] 
        [ColumnDbType("money_strict2", 0, "0")] 
        public decimal SalesVerificationLimit { get; set; }

        [Column("can_verify_purchase_transactions")] 
        [ColumnDbType("bool", 0, "false")] 
        public bool CanVerifyPurchaseTransactions { get; set; }

        [Column("purchase_verification_limit")] 
        [ColumnDbType("money_strict2", 0, "0")] 
        public decimal PurchaseVerificationLimit { get; set; }

        [Column("can_verify_gl_transactions")] 
        [ColumnDbType("bool", 0, "false")] 
        public bool CanVerifyGlTransactions { get; set; }

        [Column("gl_verification_limit")] 
        [ColumnDbType("money_strict2", 0, "0")] 
        public decimal GlVerificationLimit { get; set; }

        [Column("can_self_verify")] 
        [ColumnDbType("bool", 0, "false")] 
        public bool CanSelfVerify { get; set; }

        [Column("self_verification_limit")] 
        [ColumnDbType("money_strict2", 0, "0")] 
        public decimal SelfVerificationLimit { get; set; }

        [Column("effective_from")] 
        [ColumnDbType("date", 0, "")] 
        public DateTime EffectiveFrom { get; set; }

        [Column("ends_on")] 
        [ColumnDbType("date", 0, "")] 
        public DateTime EndsOn { get; set; }

        [Column("is_active")] 
        [ColumnDbType("bool", 0, "")] 
        public bool IsActive { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, "now()")] 
        public DateTime? AuditTs { get; set; }

        [Column("office_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int OfficeId { get; set; }

    }

    [TableName("policy.auto_verification_policy")]
    [PrimaryKey("policy_id", autoIncrement=false)]
    [ExplicitColumns]
    public class AutoVerificationPolicy : PetaPocoDB.Record<AutoVerificationPolicy> , IPoco
    {
        [Column("policy_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int PolicyId { get; set; }

        [Column("user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int UserId { get; set; }

        [Column("office_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int OfficeId { get; set; }

        [Column("verify_sales_transactions")] 
        [ColumnDbType("bool", 0, "false")] 
        public bool VerifySalesTransactions { get; set; }

        [Column("sales_verification_limit")] 
        [ColumnDbType("money_strict2", 0, "0")] 
        public decimal SalesVerificationLimit { get; set; }

        [Column("verify_purchase_transactions")] 
        [ColumnDbType("bool", 0, "false")] 
        public bool VerifyPurchaseTransactions { get; set; }

        [Column("purchase_verification_limit")] 
        [ColumnDbType("money_strict2", 0, "0")] 
        public decimal PurchaseVerificationLimit { get; set; }

        [Column("verify_gl_transactions")] 
        [ColumnDbType("bool", 0, "false")] 
        public bool VerifyGlTransactions { get; set; }

        [Column("gl_verification_limit")] 
        [ColumnDbType("money_strict2", 0, "0")] 
        public decimal GlVerificationLimit { get; set; }

        [Column("effective_from")] 
        [ColumnDbType("date", 0, "")] 
        public DateTime EffectiveFrom { get; set; }

        [Column("ends_on")] 
        [ColumnDbType("date", 0, "")] 
        public DateTime EndsOn { get; set; }

        [Column("is_active")] 
        [ColumnDbType("bool", 0, "")] 
        public bool IsActive { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, "now()")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("policy.auto_verification_policy_scrud_view")]
    [ExplicitColumns]
    public class AutoVerificationPolicyScrudView : PetaPocoDB.Record<AutoVerificationPolicyScrudView> , IPoco
    {
        [Column("policy_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? PolicyId { get; set; }

        [Column("user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? UserId { get; set; }

        [Column("user_name")] 
        [ColumnDbType("varchar", 50, "")] 
        public string UserName { get; set; }

        [Column("office_name")] 
        [ColumnDbType("varchar", 150, "")] 
        public string OfficeName { get; set; }

        [Column("verify_sales_transactions")] 
        [ColumnDbType("bool", 0, "")] 
        public bool? VerifySalesTransactions { get; set; }

        [Column("sales_verification_limit")] 
        [ColumnDbType("money_strict2", 0, "")] 
        public decimal? SalesVerificationLimit { get; set; }

        [Column("verify_purchase_transactions")] 
        [ColumnDbType("bool", 0, "")] 
        public bool? VerifyPurchaseTransactions { get; set; }

        [Column("purchase_verification_limit")] 
        [ColumnDbType("money_strict2", 0, "")] 
        public decimal? PurchaseVerificationLimit { get; set; }

        [Column("verify_gl_transactions")] 
        [ColumnDbType("bool", 0, "")] 
        public bool? VerifyGlTransactions { get; set; }

        [Column("gl_verification_limit")] 
        [ColumnDbType("money_strict2", 0, "")] 
        public decimal? GlVerificationLimit { get; set; }

        [Column("effective_from")] 
        [ColumnDbType("date", 0, "")] 
        public DateTime? EffectiveFrom { get; set; }

        [Column("ends_on")] 
        [ColumnDbType("date", 0, "")] 
        public DateTime? EndsOn { get; set; }

        [Column("is_active")] 
        [ColumnDbType("bool", 0, "")] 
        public bool? IsActive { get; set; }

    }

    [TableName("policy.voucher_verification_policy_scrud_view")]
    [ExplicitColumns]
    public class VoucherVerificationPolicyScrudView : PetaPocoDB.Record<VoucherVerificationPolicyScrudView> , IPoco
    {
        [Column("policy_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? PolicyId { get; set; }

        [Column("user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? UserId { get; set; }

        [Column("user_name")] 
        [ColumnDbType("varchar", 50, "")] 
        public string UserName { get; set; }

        [Column("can_verify_sales_transactions")] 
        [ColumnDbType("bool", 0, "")] 
        public bool? CanVerifySalesTransactions { get; set; }

        [Column("sales_verification_limit")] 
        [ColumnDbType("money_strict2", 0, "")] 
        public decimal? SalesVerificationLimit { get; set; }

        [Column("can_verify_purchase_transactions")] 
        [ColumnDbType("bool", 0, "")] 
        public bool? CanVerifyPurchaseTransactions { get; set; }

        [Column("purchase_verification_limit")] 
        [ColumnDbType("money_strict2", 0, "")] 
        public decimal? PurchaseVerificationLimit { get; set; }

        [Column("can_verify_gl_transactions")] 
        [ColumnDbType("bool", 0, "")] 
        public bool? CanVerifyGlTransactions { get; set; }

        [Column("gl_verification_limit")] 
        [ColumnDbType("money_strict2", 0, "")] 
        public decimal? GlVerificationLimit { get; set; }

        [Column("can_self_verify")] 
        [ColumnDbType("bool", 0, "")] 
        public bool? CanSelfVerify { get; set; }

        [Column("self_verification_limit")] 
        [ColumnDbType("money_strict2", 0, "")] 
        public decimal? SelfVerificationLimit { get; set; }

        [Column("effective_from")] 
        [ColumnDbType("date", 0, "")] 
        public DateTime? EffectiveFrom { get; set; }

        [Column("ends_on")] 
        [ColumnDbType("date", 0, "")] 
        public DateTime? EndsOn { get; set; }

        [Column("is_active")] 
        [ColumnDbType("bool", 0, "")] 
        public bool? IsActive { get; set; }

    }

    [FunctionName("get_menu")]
    [ExplicitColumns]
    public class DbGetMenuResult : PetaPocoDB.Record<DbGetMenuResult> , IPoco
    {
        [Column("menu_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int MenuId { get; set; }

        [Column("menu_text")] 
        [ColumnDbType("character varying", 0, "")] 
        public string MenuText { get; set; }

        [Column("url")] 
        [ColumnDbType("character varying", 0, "")] 
        public string Url { get; set; }

        [Column("menu_code")] 
        [ColumnDbType("character varying", 0, "")] 
        public string MenuCode { get; set; }

        [Column("level")] 
        [ColumnDbType("smallint", 0, "")] 
        public short Level { get; set; }

        [Column("parent_menu_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int ParentMenuId { get; set; }

    }

    [FunctionName("get_menu_policy")]
    [ExplicitColumns]
    public class DbGetMenuPolicyResult : PetaPocoDB.Record<DbGetMenuPolicyResult> , IPoco
    {
        [Column("row_number")] 
        [ColumnDbType("bigint", 0, "")] 
        public long RowNumber { get; set; }

        [Column("access")] 
        [ColumnDbType("boolean", 0, "")] 
        public bool Access { get; set; }

        [Column("menu_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int MenuId { get; set; }

        [Column("menu_code")] 
        [ColumnDbType("text", 0, "")] 
        public string MenuCode { get; set; }

        [Column("menu_text")] 
        [ColumnDbType("text", 0, "")] 
        public string MenuText { get; set; }

        [Column("url")] 
        [ColumnDbType("text", 0, "")] 
        public string Url { get; set; }

    }
}

