
using MixERP.Net.Entities.Contracts;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MixERP.Net.Entities.Office
{

    [TableName("office.counter_scrud_view")]
    [ExplicitColumns]
    public class CounterScrudView : PetaPocoDB.Record<CounterScrudView> , IPoco
    {
        [Column("counter_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? CounterId { get; set; }

        [Column("store")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Store { get; set; }

        [Column("cash_repository")] 
        [ColumnDbType("text", 0, true, "")] 
        public string CashRepository { get; set; }

        [Column("counter_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string CounterCode { get; set; }

        [Column("counter_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string CounterName { get; set; }

    }

    [TableName("office.store_scrud_view")]
    [ExplicitColumns]
    public class StoreScrudView : PetaPocoDB.Record<StoreScrudView> , IPoco
    {
        [Column("store_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? StoreId { get; set; }

        [Column("office")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Office { get; set; }

        [Column("store_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string StoreCode { get; set; }

        [Column("store_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string StoreName { get; set; }

        [Column("address")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string Address { get; set; }

        [Column("store_type")] 
        [ColumnDbType("text", 0, true, "")] 
        public string StoreType { get; set; }

        [Column("allow_sales")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? AllowSales { get; set; }

        [Column("sales_tax")] 
        [ColumnDbType("text", 0, true, "")] 
        public string SalesTax { get; set; }

        [Column("default_cash_account")] 
        [ColumnDbType("text", 0, true, "")] 
        public string DefaultCashAccount { get; set; }

        [Column("default_cash_repository")] 
        [ColumnDbType("text", 0, true, "")] 
        public string DefaultCashRepository { get; set; }

    }

    [TableName("office.sign_in_view")]
    [ExplicitColumns]
    public class SignInView : PetaPocoDB.Record<SignInView> , IPoco
    {
        [Column("login_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? LoginId { get; set; }

        [Column("user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? UserId { get; set; }

        [Column("role_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? RoleId { get; set; }

        [Column("role")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Role { get; set; }

        [Column("role_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string RoleCode { get; set; }

        [Column("role_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string RoleName { get; set; }

        [Column("is_admin")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsAdmin { get; set; }

        [Column("is_system")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsSystem { get; set; }

        [Column("browser")] 
        [ColumnDbType("varchar", 500, true, "")] 
        public string Browser { get; set; }

        [Column("ip_address")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string IpAddress { get; set; }

        [Column("login_date_time")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? LoginDateTime { get; set; }

        [Column("remote_user")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string RemoteUser { get; set; }

        [Column("culture")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string Culture { get; set; }

        [Column("user_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string UserName { get; set; }

        [Column("full_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string FullName { get; set; }

        [Column("elevated")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? Elevated { get; set; }

        [Column("office")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Office { get; set; }

        [Column("office_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? OfficeId { get; set; }

        [Column("office_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string OfficeCode { get; set; }

        [Column("office_name")] 
        [ColumnDbType("varchar", 150, true, "")] 
        public string OfficeName { get; set; }

        [Column("nick_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string NickName { get; set; }

        [Column("registration_date")] 
        [ColumnDbType("date", 0, true, "")] 
        public DateTime? RegistrationDate { get; set; }

        [Column("currency_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string CurrencyCode { get; set; }

        [Column("po_box")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string PoBox { get; set; }

        [Column("address_line_1")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string AddressLine1 { get; set; }

        [Column("address_line_2")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string AddressLine2 { get; set; }

        [Column("street")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string Street { get; set; }

        [Column("city")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string City { get; set; }

        [Column("state")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string State { get; set; }

        [Column("zip_code")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string ZipCode { get; set; }

        [Column("country")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string Country { get; set; }

        [Column("phone")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string Phone { get; set; }

        [Column("fax")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string Fax { get; set; }

        [Column("email")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string Email { get; set; }

        [Column("url")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string Url { get; set; }

        [Column("registration_number")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string RegistrationNumber { get; set; }

        [Column("pan_number")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string PanNumber { get; set; }

        [Column("allow_transaction_posting")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? AllowTransactionPosting { get; set; }

        [Column("week_start_day")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? WeekStartDay { get; set; }

        [Column("logo_file")] 
        [ColumnDbType("image", 0, true, "")] 
        public string LogoFile { get; set; }

        [Column("sales_quotation_valid_duration")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? SalesQuotationValidDuration { get; set; }

    }

    [TableName("office.roles")]
    [PrimaryKey("role_id", autoIncrement=true)]
    [ExplicitColumns]
    public class Role : PetaPocoDB.Record<Role> , IPoco
    {
        [Column("role_id")] 
        [ColumnDbType("int4", 0, false, "nextval('office.roles_role_id_seq'::regclass)")] 
        public int RoleId { get; set; }

        [Column("role_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string RoleCode { get; set; }

        [Column("role_name")] 
        [ColumnDbType("varchar", 50, false, "")] 
        public string RoleName { get; set; }

        [Column("is_admin")] 
        [ColumnDbType("bool", 0, false, "false")] 
        public bool IsAdmin { get; set; }

        [Column("is_system")] 
        [ColumnDbType("bool", 0, false, "false")] 
        public bool IsSystem { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("office.week_setup")]
    [PrimaryKey("week_setup_id", autoIncrement=true)]
    [ExplicitColumns]
    public class WeekSetup : PetaPocoDB.Record<WeekSetup> , IPoco
    {
        [Column("week_setup_id")] 
        [ColumnDbType("int4", 0, false, "nextval('office.week_setup_week_setup_id_seq'::regclass)")] 
        public int WeekSetupId { get; set; }

        [Column("office_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int OfficeId { get; set; }

        [Column("week_starts_from")] 
        [ColumnDbType("int2", 0, false, "")] 
        public short WeekStartsFrom { get; set; }

        [Column("week_ends_on")] 
        [ColumnDbType("int2", 0, false, "")] 
        public short WeekEndsOn { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("office.holidays")]
    [PrimaryKey("holiday_id", autoIncrement=false)]
    [ExplicitColumns]
    public class Holiday : PetaPocoDB.Record<Holiday> , IPoco
    {
        [Column("holiday_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long HolidayId { get; set; }

        [Column("office_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int OfficeId { get; set; }

        [Column("occurs_on")] 
        [ColumnDbType("date", 0, true, "")] 
        public DateTime? OccursOn { get; set; }

        [Column("comment")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Comment { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("office.offices")]
    [PrimaryKey("office_id", autoIncrement=true)]
    [ExplicitColumns]
    public class Office : PetaPocoDB.Record<Office> , IPoco
    {
        [Column("office_id")] 
        [ColumnDbType("int4", 0, false, "nextval('office.offices_office_id_seq'::regclass)")] 
        public int OfficeId { get; set; }

        [Column("office_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string OfficeCode { get; set; }

        [Column("office_name")] 
        [ColumnDbType("varchar", 150, false, "")] 
        public string OfficeName { get; set; }

        [Column("nick_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string NickName { get; set; }

        [Column("registration_date")] 
        [ColumnDbType("date", 0, false, "")] 
        public DateTime RegistrationDate { get; set; }

        [Column("currency_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string CurrencyCode { get; set; }

        [Column("po_box")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string PoBox { get; set; }

        [Column("address_line_1")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string AddressLine1 { get; set; }

        [Column("address_line_2")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string AddressLine2 { get; set; }

        [Column("street")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string Street { get; set; }

        [Column("city")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string City { get; set; }

        [Column("state")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string State { get; set; }

        [Column("zip_code")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string ZipCode { get; set; }

        [Column("country")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string Country { get; set; }

        [Column("phone")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string Phone { get; set; }

        [Column("fax")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string Fax { get; set; }

        [Column("email")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string Email { get; set; }

        [Column("url")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string Url { get; set; }

        [Column("registration_number")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string RegistrationNumber { get; set; }

        [Column("pan_number")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string PanNumber { get; set; }

        [Column("allow_transaction_posting")] 
        [ColumnDbType("bool", 0, false, "true")] 
        public bool AllowTransactionPosting { get; set; }

        [Column("parent_office_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? ParentOfficeId { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

        [Column("income_tax_rate")] 
        [ColumnDbType("decimal_strict2", 0, false, "0")] 
        public decimal IncomeTaxRate { get; set; }

        [Column("transaction_start_date")] 
        [ColumnDbType("date", 0, false, "")] 
        public DateTime TransactionStartDate { get; set; }

        [Column("week_start_day")] 
        [ColumnDbType("int4", 0, false, "2")] 
        public int WeekStartDay { get; set; }

        [Column("primary_sales_tax_is_vat")] 
        [ColumnDbType("bool", 0, false, "false")] 
        public bool PrimarySalesTaxIsVat { get; set; }

        [Column("has_state_sales_tax")] 
        [ColumnDbType("bool", 0, false, "false")] 
        public bool HasStateSalesTax { get; set; }

        [Column("has_county_sales_tax")] 
        [ColumnDbType("bool", 0, false, "false")] 
        public bool HasCountySalesTax { get; set; }

        [Column("logo_file")] 
        [ColumnDbType("image", 0, false, "")] 
        public string LogoFile { get; set; }

    }

    [TableName("office.users")]
    [PrimaryKey("user_id", autoIncrement=true)]
    [ExplicitColumns]
    public class User : PetaPocoDB.Record<User> , IPoco
    {
        [Column("user_id")] 
        [ColumnDbType("int4", 0, false, "nextval('office.users_user_id_seq'::regclass)")] 
        public int UserId { get; set; }

        [Column("role_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int RoleId { get; set; }

        [Column("department_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int DepartmentId { get; set; }

        [Column("office_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int OfficeId { get; set; }

        [Column("user_name")] 
        [ColumnDbType("varchar", 50, false, "")] 
        public string UserName { get; set; }

        [Column("full_name")] 
        [ColumnDbType("varchar", 100, false, "")] 
        public string FullName { get; set; }

        [Column("can_change_password")] 
        [ColumnDbType("bool", 0, false, "true")] 
        public bool CanChangePassword { get; set; }

        [Column("password")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Password { get; set; }

        [Column("elevated")] 
        [ColumnDbType("bool", 0, false, "false")] 
        public bool Elevated { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

        [Column("store_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? StoreId { get; set; }

    }

    [TableName("office.departments")]
    [PrimaryKey("department_id", autoIncrement=true)]
    [ExplicitColumns]
    public class Department : PetaPocoDB.Record<Department> , IPoco
    {
        [Column("department_id")] 
        [ColumnDbType("int4", 0, false, "nextval('office.departments_department_id_seq'::regclass)")] 
        public int DepartmentId { get; set; }

        [Column("department_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string DepartmentCode { get; set; }

        [Column("department_name")] 
        [ColumnDbType("varchar", 50, false, "")] 
        public string DepartmentName { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("office.store_types")]
    [PrimaryKey("store_type_id", autoIncrement=true)]
    [ExplicitColumns]
    public class StoreType : PetaPocoDB.Record<StoreType> , IPoco
    {
        [Column("store_type_id")] 
        [ColumnDbType("int4", 0, false, "nextval('office.store_types_store_type_id_seq'::regclass)")] 
        public int StoreTypeId { get; set; }

        [Column("store_type_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string StoreTypeCode { get; set; }

        [Column("store_type_name")] 
        [ColumnDbType("varchar", 50, false, "")] 
        public string StoreTypeName { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("office.counters")]
    [PrimaryKey("counter_id", autoIncrement=true)]
    [ExplicitColumns]
    public class Counter : PetaPocoDB.Record<Counter> , IPoco
    {
        [Column("counter_id")] 
        [ColumnDbType("int4", 0, false, "nextval('office.counters_counter_id_seq'::regclass)")] 
        public int CounterId { get; set; }

        [Column("store_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int StoreId { get; set; }

        [Column("cash_repository_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int CashRepositoryId { get; set; }

        [Column("counter_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string CounterCode { get; set; }

        [Column("counter_name")] 
        [ColumnDbType("varchar", 50, false, "")] 
        public string CounterName { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("office.cashiers")]
    [PrimaryKey("cashier_id", autoIncrement=true)]
    [ExplicitColumns]
    public class Cashier : PetaPocoDB.Record<Cashier> , IPoco
    {
        [Column("cashier_id")] 
        [ColumnDbType("int8", 0, false, "nextval('office.cashiers_cashier_id_seq'::regclass)")] 
        public long CashierId { get; set; }

        [Column("counter_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int CounterId { get; set; }

        [Column("user_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int UserId { get; set; }

        [Column("assigned_by_user_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int AssignedByUserId { get; set; }

        [Column("transaction_date")] 
        [ColumnDbType("date", 0, false, "")] 
        public DateTime TransactionDate { get; set; }

        [Column("closed")] 
        [ColumnDbType("bool", 0, false, "")] 
        public bool Closed { get; set; }

    }

    [TableName("office.cost_centers")]
    [PrimaryKey("cost_center_id", autoIncrement=true)]
    [ExplicitColumns]
    public class CostCenter : PetaPocoDB.Record<CostCenter> , IPoco
    {
        [Column("cost_center_id")] 
        [ColumnDbType("int4", 0, false, "nextval('office.cost_centers_cost_center_id_seq'::regclass)")] 
        public int CostCenterId { get; set; }

        [Column("cost_center_code")] 
        [ColumnDbType("varchar", 24, false, "")] 
        public string CostCenterCode { get; set; }

        [Column("cost_center_name")] 
        [ColumnDbType("varchar", 50, false, "")] 
        public string CostCenterName { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("office.cash_repositories")]
    [PrimaryKey("cash_repository_id", autoIncrement=true)]
    [ExplicitColumns]
    public class CashRepository : PetaPocoDB.Record<CashRepository> , IPoco
    {
        [Column("cash_repository_id")] 
        [ColumnDbType("int4", 0, false, "nextval('office.cash_repositories_cash_repository_id_seq'::regclass)")] 
        public int CashRepositoryId { get; set; }

        [Column("office_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int OfficeId { get; set; }

        [Column("cash_repository_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string CashRepositoryCode { get; set; }

        [Column("cash_repository_name")] 
        [ColumnDbType("varchar", 50, false, "")] 
        public string CashRepositoryName { get; set; }

        [Column("parent_cash_repository_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? ParentCashRepositoryId { get; set; }

        [Column("description")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string Description { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("office.work_centers")]
    [PrimaryKey("work_center_id", autoIncrement=true)]
    [ExplicitColumns]
    public class WorkCenter : PetaPocoDB.Record<WorkCenter> , IPoco
    {
        [Column("work_center_id")] 
        [ColumnDbType("int4", 0, false, "nextval('office.work_centers_work_center_id_seq'::regclass)")] 
        public int WorkCenterId { get; set; }

        [Column("office_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int OfficeId { get; set; }

        [Column("work_center_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string WorkCenterCode { get; set; }

        [Column("work_center_name")] 
        [ColumnDbType("varchar", 128, false, "")] 
        public string WorkCenterName { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("office.configuration")]
    [PrimaryKey("configuration_id", autoIncrement=true)]
    [ExplicitColumns]
    public class Configuration : PetaPocoDB.Record<Configuration> , IPoco
    {
        [Column("configuration_id")] 
        [ColumnDbType("int4", 0, false, "nextval('office.configuration_configuration_id_seq'::regclass)")] 
        public int ConfigurationId { get; set; }

        [Column("config_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? ConfigId { get; set; }

        [Column("office_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int OfficeId { get; set; }

        [Column("value")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Value { get; set; }

        [Column("configuration_details")] 
        [ColumnDbType("text", 0, false, "")] 
        public string ConfigurationDetails { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("office.stores")]
    [PrimaryKey("store_id", autoIncrement=true)]
    [ExplicitColumns]
    public class Store : PetaPocoDB.Record<Store> , IPoco
    {
        [Column("store_id")] 
        [ColumnDbType("int4", 0, false, "nextval('office.stores_store_id_seq'::regclass)")] 
        public int StoreId { get; set; }

        [Column("office_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int OfficeId { get; set; }

        [Column("store_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string StoreCode { get; set; }

        [Column("store_name")] 
        [ColumnDbType("varchar", 50, false, "")] 
        public string StoreName { get; set; }

        [Column("address")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string Address { get; set; }

        [Column("store_type_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int StoreTypeId { get; set; }

        [Column("allow_sales")] 
        [ColumnDbType("bool", 0, false, "true")] 
        public bool AllowSales { get; set; }

        [Column("sales_tax_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int SalesTaxId { get; set; }

        [Column("default_cash_account_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long DefaultCashAccountId { get; set; }

        [Column("default_cash_repository_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int DefaultCashRepositoryId { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("office.cash_repository_scrud_view")]
    [ExplicitColumns]
    public class CashRepositoryScrudView : PetaPocoDB.Record<CashRepositoryScrudView> , IPoco
    {
        [Column("cash_repository_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? CashRepositoryId { get; set; }

        [Column("office")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Office { get; set; }

        [Column("cash_repository_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string CashRepositoryCode { get; set; }

        [Column("cash_repository_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string CashRepositoryName { get; set; }

        [Column("parent_cash_repository")] 
        [ColumnDbType("text", 0, true, "")] 
        public string ParentCashRepository { get; set; }

        [Column("description")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string Description { get; set; }

    }

    [TableName("office.cost_center_scrud_view")]
    [ExplicitColumns]
    public class CostCenterScrudView : PetaPocoDB.Record<CostCenterScrudView> , IPoco
    {
        [Column("cost_center_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? CostCenterId { get; set; }

        [Column("cost_center_code")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string CostCenterCode { get; set; }

        [Column("cost_center_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string CostCenterName { get; set; }

    }

    [TableName("office.department_scrud_view")]
    [ExplicitColumns]
    public class DepartmentScrudView : PetaPocoDB.Record<DepartmentScrudView> , IPoco
    {
        [Column("department_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? DepartmentId { get; set; }

        [Column("department_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string DepartmentCode { get; set; }

        [Column("department_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string DepartmentName { get; set; }

    }

    [TableName("office.office_scrud_view")]
    [ExplicitColumns]
    public class OfficeScrudView : PetaPocoDB.Record<OfficeScrudView> , IPoco
    {
        [Column("office_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? OfficeId { get; set; }

        [Column("office_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string OfficeCode { get; set; }

        [Column("office_name")] 
        [ColumnDbType("varchar", 150, true, "")] 
        public string OfficeName { get; set; }

        [Column("nick_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string NickName { get; set; }

        [Column("registration_date")] 
        [ColumnDbType("date", 0, true, "")] 
        public DateTime? RegistrationDate { get; set; }

        [Column("currency")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Currency { get; set; }

        [Column("po_box")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string PoBox { get; set; }

        [Column("address_line_1")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string AddressLine1 { get; set; }

        [Column("address_line_2")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string AddressLine2 { get; set; }

        [Column("street")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string Street { get; set; }

        [Column("city")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string City { get; set; }

        [Column("state")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string State { get; set; }

        [Column("zip_code")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string ZipCode { get; set; }

        [Column("country")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string Country { get; set; }

        [Column("phone")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string Phone { get; set; }

        [Column("fax")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string Fax { get; set; }

        [Column("email")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string Email { get; set; }

        [Column("url")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string Url { get; set; }

        [Column("registration_number")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string RegistrationNumber { get; set; }

        [Column("parent_office")] 
        [ColumnDbType("text", 0, true, "")] 
        public string ParentOffice { get; set; }

    }

    [TableName("office.role_scrud_view")]
    [ExplicitColumns]
    public class RoleScrudView : PetaPocoDB.Record<RoleScrudView> , IPoco
    {
        [Column("role_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? RoleId { get; set; }

        [Column("role_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string RoleCode { get; set; }

        [Column("role_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string RoleName { get; set; }

        [Column("is_admin")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsAdmin { get; set; }

        [Column("is_system")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsSystem { get; set; }

    }

    [TableName("office.store_type_scrud_view")]
    [ExplicitColumns]
    public class StoreTypeScrudView : PetaPocoDB.Record<StoreTypeScrudView> , IPoco
    {
        [Column("store_type_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? StoreTypeId { get; set; }

        [Column("store_type_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string StoreTypeCode { get; set; }

        [Column("store_type_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string StoreTypeName { get; set; }

    }

    [TableName("office.cash_repository_selector_view")]
    [ExplicitColumns]
    public class CashRepositorySelectorView : PetaPocoDB.Record<CashRepositorySelectorView> , IPoco
    {
        [Column("cash_repository_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? CashRepositoryId { get; set; }

        [Column("cash_repository_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string CashRepositoryCode { get; set; }

        [Column("cash_repository_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string CashRepositoryName { get; set; }

        [Column("parent_cr_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ParentCrCode { get; set; }

        [Column("parent_cr_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string ParentCrName { get; set; }

        [Column("description")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string Description { get; set; }

    }

    [TableName("office.office_selector_view")]
    [ExplicitColumns]
    public class OfficeSelectorView : PetaPocoDB.Record<OfficeSelectorView> , IPoco
    {
        [Column("office_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? OfficeId { get; set; }

        [Column("office_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string OfficeCode { get; set; }

        [Column("office_name")] 
        [ColumnDbType("varchar", 150, true, "")] 
        public string OfficeName { get; set; }

        [Column("nick_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string NickName { get; set; }

        [Column("registration_date")] 
        [ColumnDbType("date", 0, true, "")] 
        public DateTime? RegistrationDate { get; set; }

        [Column("currency_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string CurrencyCode { get; set; }

        [Column("po_box")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string PoBox { get; set; }

        [Column("address_line_1")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string AddressLine1 { get; set; }

        [Column("address_line_2")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string AddressLine2 { get; set; }

        [Column("street")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string Street { get; set; }

        [Column("city")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string City { get; set; }

        [Column("state")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string State { get; set; }

        [Column("zip_code")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string ZipCode { get; set; }

        [Column("country")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string Country { get; set; }

        [Column("phone")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string Phone { get; set; }

        [Column("fax")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string Fax { get; set; }

        [Column("email")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string Email { get; set; }

        [Column("url")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string Url { get; set; }

        [Column("registration_number")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string RegistrationNumber { get; set; }

        [Column("pan_number")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string PanNumber { get; set; }

        [Column("allow_transaction_posting")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? AllowTransactionPosting { get; set; }

        [Column("parent_office_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? ParentOfficeId { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("office.store_selector_view")]
    [ExplicitColumns]
    public class StoreSelectorView : PetaPocoDB.Record<StoreSelectorView> , IPoco
    {
        [Column("store_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? StoreId { get; set; }

        [Column("office_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? OfficeId { get; set; }

        [Column("store_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string StoreCode { get; set; }

        [Column("store_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string StoreName { get; set; }

        [Column("address")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string Address { get; set; }

        [Column("store_type_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? StoreTypeId { get; set; }

        [Column("allow_sales")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? AllowSales { get; set; }

        [Column("sales_tax_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? SalesTaxId { get; set; }

        [Column("default_cash_account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? DefaultCashAccountId { get; set; }

        [Column("default_cash_repository_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? DefaultCashRepositoryId { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("office.store_type_selector_view")]
    [ExplicitColumns]
    public class StoreTypeSelectorView : PetaPocoDB.Record<StoreTypeSelectorView> , IPoco
    {
        [Column("store_type_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? StoreTypeId { get; set; }

        [Column("store_type_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string StoreTypeCode { get; set; }

        [Column("store_type_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string StoreTypeName { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("office.office_view")]
    [ExplicitColumns]
    public class OfficeView : PetaPocoDB.Record<OfficeView> , IPoco
    {
        [Column("office_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? OfficeId { get; set; }

        [Column("office_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string OfficeCode { get; set; }

        [Column("office_name")] 
        [ColumnDbType("varchar", 150, true, "")] 
        public string OfficeName { get; set; }

        [Column("nick_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string NickName { get; set; }

        [Column("registration_date")] 
        [ColumnDbType("date", 0, true, "")] 
        public DateTime? RegistrationDate { get; set; }

        [Column("currency_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string CurrencyCode { get; set; }

        [Column("po_box")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string PoBox { get; set; }

        [Column("address_line_1")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string AddressLine1 { get; set; }

        [Column("address_line_2")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string AddressLine2 { get; set; }

        [Column("street")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string Street { get; set; }

        [Column("city")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string City { get; set; }

        [Column("state")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string State { get; set; }

        [Column("zip_code")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string ZipCode { get; set; }

        [Column("country")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string Country { get; set; }

        [Column("phone")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string Phone { get; set; }

        [Column("fax")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string Fax { get; set; }

        [Column("email")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string Email { get; set; }

        [Column("url")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string Url { get; set; }

        [Column("registration_number")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string RegistrationNumber { get; set; }

        [Column("pan_number")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string PanNumber { get; set; }

        [Column("allow_transaction_posting")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? AllowTransactionPosting { get; set; }

        [Column("parent_office_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? ParentOfficeId { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("office.role_view")]
    [ExplicitColumns]
    public class RoleView : PetaPocoDB.Record<RoleView> , IPoco
    {
        [Column("role_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? RoleId { get; set; }

        [Column("role_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string RoleCode { get; set; }

        [Column("role_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string RoleName { get; set; }

    }

    [TableName("office.store_view")]
    [ExplicitColumns]
    public class StoreView : PetaPocoDB.Record<StoreView> , IPoco
    {
        [Column("store_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? StoreId { get; set; }

        [Column("office_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? OfficeId { get; set; }

        [Column("store_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string StoreCode { get; set; }

        [Column("store_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string StoreName { get; set; }

        [Column("address")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string Address { get; set; }

        [Column("store_type_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? StoreTypeId { get; set; }

        [Column("allow_sales")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? AllowSales { get; set; }

        [Column("sales_tax_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? SalesTaxId { get; set; }

        [Column("default_cash_account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? DefaultCashAccountId { get; set; }

        [Column("default_cash_repository_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? DefaultCashRepositoryId { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("office.user_view")]
    [ExplicitColumns]
    public class UserView : PetaPocoDB.Record<UserView> , IPoco
    {
        [Column("user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? UserId { get; set; }

        [Column("user_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string UserName { get; set; }

        [Column("full_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string FullName { get; set; }

        [Column("role_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string RoleName { get; set; }

        [Column("office_name")] 
        [ColumnDbType("varchar", 150, true, "")] 
        public string OfficeName { get; set; }

    }

    [TableName("office.work_center_view")]
    [ExplicitColumns]
    public class WorkCenterView : PetaPocoDB.Record<WorkCenterView> , IPoco
    {
        [Column("work_center_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? WorkCenterId { get; set; }

        [Column("office")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Office { get; set; }

        [Column("work_center_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string WorkCenterCode { get; set; }

        [Column("work_center_name")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string WorkCenterName { get; set; }

    }

    [TableName("office.user_selector_view")]
    [ExplicitColumns]
    public class UserSelectorView : PetaPocoDB.Record<UserSelectorView> , IPoco
    {
        [Column("user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? UserId { get; set; }

        [Column("user_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string UserName { get; set; }

        [Column("full_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string FullName { get; set; }

        [Column("role_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string RoleName { get; set; }

        [Column("office_name")] 
        [ColumnDbType("varchar", 150, true, "")] 
        public string OfficeName { get; set; }

    }

    [FunctionName("get_offices")]
    [ExplicitColumns]
    public class DbGetOfficesResult : PetaPocoDB.Record<DbGetOfficesResult> , IPoco
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

        [Column("address")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Address { get; set; }

    }

    [FunctionName("sign_in")]
    [ExplicitColumns]
    public class DbSignInResult : PetaPocoDB.Record<DbSignInResult> , IPoco
    {
        [Column("login_id")] 
        [ColumnDbType("bigint", 0, false, "")] 
        public long LoginId { get; set; }

        [Column("message")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Message { get; set; }

    }

    [FunctionName("get_stores")]
    [ExplicitColumns]
    public class DbGetStoresResult : PetaPocoDB.Record<DbGetStoresResult> , IPoco
    {
        [Column("store_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int StoreId { get; set; }

        [Column("office_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int OfficeId { get; set; }

        [Column("store_code")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string StoreCode { get; set; }

        [Column("store_name")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string StoreName { get; set; }

        [Column("address")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string Address { get; set; }

        [Column("store_type_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int StoreTypeId { get; set; }

        [Column("allow_sales")] 
        [ColumnDbType("boolean", 0, false, "")] 
        public bool AllowSales { get; set; }

        [Column("sales_tax_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int SalesTaxId { get; set; }

        [Column("default_cash_account_id")] 
        [ColumnDbType("bigint", 0, false, "")] 
        public long DefaultCashAccountId { get; set; }

        [Column("default_cash_repository_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int DefaultCashRepositoryId { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamp with time zone", 0, false, "")] 
        public DateTime AuditTs { get; set; }

    }

    [FunctionName("can_login")]
    [ExplicitColumns]
    public class DbCanLoginResult : PetaPocoDB.Record<DbCanLoginResult> , IPoco
    {
        [Column("result")] 
        [ColumnDbType("boolean", 0, false, "")] 
        public bool Result { get; set; }

        [Column("message")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Message { get; set; }

    }

    [TableName("office.office_type")]
    [ExplicitColumns]
    public class OfficeType : PetaPocoDB.Record<OfficeType> , IPoco
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

        [Column("address")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Address { get; set; }

    }
}


