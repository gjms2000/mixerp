

using MixERP.Net.Entities.Contracts;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MixERP.Net.Entities.Policy
{

    [TableName("policy.default_entity_access_scrud_view")]
    [ExplicitColumns]
    public class DefaultEntityAccessScrudView : PetaPocoDB.Record<DefaultEntityAccessScrudView> , IPoco
    {
        [Column("default_entity_access_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? DefaultEntityAccessId { get; set; }

        [Column("entity_name")] 
        [ColumnDbType("varchar", 0, true, "")] 
        public string EntityName { get; set; }

        [Column("role_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string RoleName { get; set; }

        [Column("access_type_name")] 
        [ColumnDbType("varchar", 0, true, "")] 
        public string AccessTypeName { get; set; }

        [Column("allow_access")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? AllowAccess { get; set; }

    }

    [TableName("policy.default_entity_access")]
    [PrimaryKey("default_entity_access_id", autoIncrement=true)]
    [ExplicitColumns]
    public class DefaultEntityAccess : PetaPocoDB.Record<DefaultEntityAccess> , IPoco
    {
        [Column("default_entity_access_id")] 
        [ColumnDbType("int4", 0, false, "nextval('policy.default_entity_access_default_entity_access_id_seq'::regclass)")] 
        public int DefaultEntityAccessId { get; set; }

        [Column("entity_name")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string EntityName { get; set; }

        [Column("role_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int RoleId { get; set; }

        [Column("access_type_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AccessTypeId { get; set; }

        [Column("allow_access")] 
        [ColumnDbType("bool", 0, false, "")] 
        public bool AllowAccess { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("policy.auto_verification_policy_scrud_view")]
    [ExplicitColumns]
    public class AutoVerificationPolicyScrudView : PetaPocoDB.Record<AutoVerificationPolicyScrudView> , IPoco
    {
        [Column("policy_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? PolicyId { get; set; }

        [Column("user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? UserId { get; set; }

        [Column("user_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string UserName { get; set; }

        [Column("office_name")] 
        [ColumnDbType("varchar", 150, true, "")] 
        public string OfficeName { get; set; }

        [Column("verify_sales_transactions")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? VerifySalesTransactions { get; set; }

        [Column("sales_verification_limit")] 
        [ColumnDbType("money_strict2", 0, true, "")] 
        public decimal? SalesVerificationLimit { get; set; }

        [Column("verify_purchase_transactions")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? VerifyPurchaseTransactions { get; set; }

        [Column("purchase_verification_limit")] 
        [ColumnDbType("money_strict2", 0, true, "")] 
        public decimal? PurchaseVerificationLimit { get; set; }

        [Column("verify_gl_transactions")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? VerifyGlTransactions { get; set; }

        [Column("gl_verification_limit")] 
        [ColumnDbType("money_strict2", 0, true, "")] 
        public decimal? GlVerificationLimit { get; set; }

        [Column("effective_from")] 
        [ColumnDbType("date", 0, true, "")] 
        public DateTime? EffectiveFrom { get; set; }

        [Column("ends_on")] 
        [ColumnDbType("date", 0, true, "")] 
        public DateTime? EndsOn { get; set; }

        [Column("is_active")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsActive { get; set; }

    }

    [TableName("policy.voucher_verification_policy_scrud_view")]
    [ExplicitColumns]
    public class VoucherVerificationPolicyScrudView : PetaPocoDB.Record<VoucherVerificationPolicyScrudView> , IPoco
    {
        [Column("policy_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? PolicyId { get; set; }

        [Column("user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? UserId { get; set; }

        [Column("user_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string UserName { get; set; }

        [Column("can_verify_sales_transactions")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? CanVerifySalesTransactions { get; set; }

        [Column("sales_verification_limit")] 
        [ColumnDbType("money_strict2", 0, true, "")] 
        public decimal? SalesVerificationLimit { get; set; }

        [Column("can_verify_purchase_transactions")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? CanVerifyPurchaseTransactions { get; set; }

        [Column("purchase_verification_limit")] 
        [ColumnDbType("money_strict2", 0, true, "")] 
        public decimal? PurchaseVerificationLimit { get; set; }

        [Column("can_verify_gl_transactions")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? CanVerifyGlTransactions { get; set; }

        [Column("gl_verification_limit")] 
        [ColumnDbType("money_strict2", 0, true, "")] 
        public decimal? GlVerificationLimit { get; set; }

        [Column("can_self_verify")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? CanSelfVerify { get; set; }

        [Column("self_verification_limit")] 
        [ColumnDbType("money_strict2", 0, true, "")] 
        public decimal? SelfVerificationLimit { get; set; }

        [Column("effective_from")] 
        [ColumnDbType("date", 0, true, "")] 
        public DateTime? EffectiveFrom { get; set; }

        [Column("ends_on")] 
        [ColumnDbType("date", 0, true, "")] 
        public DateTime? EndsOn { get; set; }

        [Column("is_active")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsActive { get; set; }

    }

    [TableName("policy.entity_access")]
    [PrimaryKey("entity_access_id", autoIncrement=true)]
    [ExplicitColumns]
    public class EntityAccess : PetaPocoDB.Record<EntityAccess> , IPoco
    {
        [Column("entity_access_id")] 
        [ColumnDbType("int4", 0, false, "nextval('policy.entity_access_entity_access_id_seq'::regclass)")] 
        public int EntityAccessId { get; set; }

        [Column("entity_name")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string EntityName { get; set; }

        [Column("user_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int UserId { get; set; }

        [Column("access_type_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AccessTypeId { get; set; }

        [Column("allow_access")] 
        [ColumnDbType("bool", 0, false, "")] 
        public bool AllowAccess { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("policy.entity_access_scrud_view")]
    [ExplicitColumns]
    public class EntityAccessScrudView : PetaPocoDB.Record<EntityAccessScrudView> , IPoco
    {
        [Column("entity_access_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? EntityAccessId { get; set; }

        [Column("entity_name")] 
        [ColumnDbType("varchar", 0, true, "")] 
        public string EntityName { get; set; }

        [Column("user_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string UserName { get; set; }

        [Column("access_type_name")] 
        [ColumnDbType("varchar", 0, true, "")] 
        public string AccessTypeName { get; set; }

        [Column("allow_access")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? AllowAccess { get; set; }

    }

    [TableName("policy.access_types")]
    [PrimaryKey("access_type_id", autoIncrement=false)]
    [ExplicitColumns]
    public class AccessType : PetaPocoDB.Record<AccessType> , IPoco
    {
        [Column("access_type_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int AccessTypeId { get; set; }

        [Column("access_type_name")] 
        [ColumnDbType("varchar", 48, false, "")] 
        public string AccessTypeName { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("policy.lock_outs")]
    [PrimaryKey("lock_out_id", autoIncrement=true)]
    [ExplicitColumns]
    public class LockOut : PetaPocoDB.Record<LockOut> , IPoco
    {
        [Column("lock_out_id")] 
        [ColumnDbType("int8", 0, false, "nextval('policy.lock_outs_lock_out_id_seq'::regclass)")] 
        public long LockOutId { get; set; }

        [Column("user_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int UserId { get; set; }

        [Column("lock_out_time")] 
        [ColumnDbType("timestamptz", 0, false, "")] 
        public DateTime LockOutTime { get; set; }

        [Column("lock_out_till")] 
        [ColumnDbType("timestamptz", 0, false, "2015-09-02 18:51:03.08+00")] 
        public DateTime LockOutTill { get; set; }

    }

    [TableName("policy.menu_access")]
    [PrimaryKey("access_id", autoIncrement=true)]
    [ExplicitColumns]
    public class MenuAccess : PetaPocoDB.Record<MenuAccess> , IPoco
    {
        [Column("access_id")] 
        [ColumnDbType("int8", 0, false, "nextval('policy.menu_access_access_id_seq'::regclass)")] 
        public long AccessId { get; set; }

        [Column("office_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int OfficeId { get; set; }

        [Column("menu_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int MenuId { get; set; }

        [Column("user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? UserId { get; set; }

    }

    [TableName("policy.store_policies")]
    [PrimaryKey("store_policy_id", autoIncrement=true)]
    [ExplicitColumns]
    public class StorePolicy : PetaPocoDB.Record<StorePolicy> , IPoco
    {
        [Column("store_policy_id")] 
        [ColumnDbType("int8", 0, false, "nextval('policy.store_policies_store_policy_id_seq'::regclass)")] 
        public long StorePolicyId { get; set; }

        [Column("written_by_user_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int WrittenByUserId { get; set; }

        [Column("status")] 
        [ColumnDbType("bool", 0, false, "")] 
        public bool Status { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("policy.store_policy_details")]
    [PrimaryKey("store_policy_detail_id", autoIncrement=true)]
    [ExplicitColumns]
    public class StorePolicyDetail : PetaPocoDB.Record<StorePolicyDetail> , IPoco
    {
        [Column("store_policy_detail_id")] 
        [ColumnDbType("int8", 0, false, "nextval('policy.store_policy_details_store_policy_detail_id_seq'::regclass)")] 
        public long StorePolicyDetailId { get; set; }

        [Column("store_policy_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long StorePolicyId { get; set; }

        [Column("user_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int UserId { get; set; }

        [Column("store_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int StoreId { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("policy.menu_policy")]
    [PrimaryKey("policy_id", autoIncrement=true)]
    [ExplicitColumns]
    public class MenuPolicy : PetaPocoDB.Record<MenuPolicy> , IPoco
    {
        [Column("policy_id")] 
        [ColumnDbType("int4", 0, false, "nextval('policy.menu_policy_policy_id_seq'::regclass)")] 
        public int PolicyId { get; set; }

        [Column("menu_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int MenuId { get; set; }

        [Column("office_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? OfficeId { get; set; }

        [Column("inherit_in_child_offices")] 
        [ColumnDbType("bool", 0, false, "false")] 
        public bool InheritInChildOffices { get; set; }

        [Column("role_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? RoleId { get; set; }

        [Column("user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? UserId { get; set; }

        [Column("scope")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string Scope { get; set; }

    }

    [TableName("policy.http_actions")]
    [PrimaryKey("http_action_code", autoIncrement=false)]
    [ExplicitColumns]
    public class HttpAction : PetaPocoDB.Record<HttpAction> , IPoco
    {
        [Column("http_action_code")] 
        [ColumnDbType("text", 0, false, "")] 
        public string HttpActionCode { get; set; }

    }

    [TableName("policy.api_access_policy")]
    [PrimaryKey("api_access_policy_id", autoIncrement=true)]
    [ExplicitColumns]
    public class ApiAccessPolicy : PetaPocoDB.Record<ApiAccessPolicy> , IPoco
    {
        [Column("api_access_policy_id")] 
        [ColumnDbType("int8", 0, false, "nextval('policy.api_access_policy_api_access_policy_id_seq'::regclass)")] 
        public long ApiAccessPolicyId { get; set; }

        [Column("user_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int UserId { get; set; }

        [Column("office_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int OfficeId { get; set; }

        [Column("poco_type_name")] 
        [ColumnDbType("text", 0, false, "")] 
        public string PocoTypeName { get; set; }

        [Column("http_action_code")] 
        [ColumnDbType("text", 0, false, "")] 
        public string HttpActionCode { get; set; }

        [Column("valid_till")] 
        [ColumnDbType("date", 0, false, "")] 
        public DateTime ValidTill { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("policy.voucher_verification_policy")]
    [PrimaryKey("policy_id", autoIncrement=true)]
    [ExplicitColumns]
    public class VoucherVerificationPolicy : PetaPocoDB.Record<VoucherVerificationPolicy> , IPoco
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

    [TableName("policy.auto_verification_policy")]
    [PrimaryKey("policy_id", autoIncrement=true)]
    [ExplicitColumns]
    public class AutoVerificationPolicy : PetaPocoDB.Record<AutoVerificationPolicy> , IPoco
    {
        [Column("policy_id")] 
        [ColumnDbType("int4", 0, false, "nextval('policy.auto_verification_policy_policy_id_seq'::regclass)")] 
        public int PolicyId { get; set; }

        [Column("user_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int UserId { get; set; }

        [Column("office_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int OfficeId { get; set; }

        [Column("verify_sales_transactions")] 
        [ColumnDbType("bool", 0, false, "false")] 
        public bool VerifySalesTransactions { get; set; }

        [Column("sales_verification_limit")] 
        [ColumnDbType("money_strict2", 0, false, "0")] 
        public decimal SalesVerificationLimit { get; set; }

        [Column("verify_purchase_transactions")] 
        [ColumnDbType("bool", 0, false, "false")] 
        public bool VerifyPurchaseTransactions { get; set; }

        [Column("purchase_verification_limit")] 
        [ColumnDbType("money_strict2", 0, false, "0")] 
        public decimal PurchaseVerificationLimit { get; set; }

        [Column("verify_gl_transactions")] 
        [ColumnDbType("bool", 0, false, "false")] 
        public bool VerifyGlTransactions { get; set; }

        [Column("gl_verification_limit")] 
        [ColumnDbType("money_strict2", 0, false, "0")] 
        public decimal GlVerificationLimit { get; set; }

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

    }

    [FunctionName("get_menu")]
    [ExplicitColumns]
    public class DbGetMenuResult : PetaPocoDB.Record<DbGetMenuResult> , IPoco
    {
        [Column("menu_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int MenuId { get; set; }

        [Column("menu_text")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string MenuText { get; set; }

        [Column("url")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string Url { get; set; }

        [Column("menu_code")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string MenuCode { get; set; }

        [Column("level")] 
        [ColumnDbType("smallint", 0, false, "")] 
        public short Level { get; set; }

        [Column("parent_menu_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int ParentMenuId { get; set; }

    }

    [FunctionName("get_menu_policy")]
    [ExplicitColumns]
    public class DbGetMenuPolicyResult : PetaPocoDB.Record<DbGetMenuPolicyResult> , IPoco
    {
        [Column("row_number")] 
        [ColumnDbType("bigint", 0, false, "")] 
        public long RowNumber { get; set; }

        [Column("access")] 
        [ColumnDbType("boolean", 0, false, "")] 
        public bool Access { get; set; }

        [Column("menu_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int MenuId { get; set; }

        [Column("menu_code")] 
        [ColumnDbType("text", 0, false, "")] 
        public string MenuCode { get; set; }

        [Column("menu_text")] 
        [ColumnDbType("text", 0, false, "")] 
        public string MenuText { get; set; }

        [Column("url")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Url { get; set; }

    }
}

