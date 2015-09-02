
using MixERP.Net.Entities.Contracts;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MixERP.Net.Entities.Core
{

    [TableName("core.bank_account_scrud_view")]
    [ExplicitColumns]
    public class BankAccountScrudView : PetaPocoDB.Record<BankAccountScrudView> , IPoco
    {
        [Column("account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? AccountId { get; set; }

        [Column("maintained_by_user_id")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string MaintainedByUserId { get; set; }

        [Column("office")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Office { get; set; }

        [Column("bank_name")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string BankName { get; set; }

        [Column("bank_branch")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string BankBranch { get; set; }

        [Column("bank_contact_number")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string BankContactNumber { get; set; }

        [Column("bank_address")] 
        [ColumnDbType("text", 0, true, "")] 
        public string BankAddress { get; set; }

        [Column("bank_account_number")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string BankAccountNumber { get; set; }

        [Column("bank_account_type")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string BankAccountType { get; set; }

        [Column("relationship_officer_name")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string RelationshipOfficerName { get; set; }

        [Column("is_merchant_account")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsMerchantAccount { get; set; }

    }

    [TableName("core.bonus_slab_detail_scrud_view")]
    [ExplicitColumns]
    public class BonusSlabDetailScrudView : PetaPocoDB.Record<BonusSlabDetailScrudView> , IPoco
    {
        [Column("bonus_slab_detail_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? BonusSlabDetailId { get; set; }

        [Column("bonus_slab")] 
        [ColumnDbType("text", 0, true, "")] 
        public string BonusSlab { get; set; }

        [Column("amount_from")] 
        [ColumnDbType("money_strict", 0, true, "")] 
        public decimal? AmountFrom { get; set; }

        [Column("amount_to")] 
        [ColumnDbType("money_strict", 0, true, "")] 
        public decimal? AmountTo { get; set; }

        [Column("bonus_rate")] 
        [ColumnDbType("decimal_strict", 0, true, "")] 
        public decimal? BonusRate { get; set; }

    }

    [TableName("core.bonus_slab_scrud_view")]
    [ExplicitColumns]
    public class BonusSlabScrudView : PetaPocoDB.Record<BonusSlabScrudView> , IPoco
    {
        [Column("bonus_slab_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? BonusSlabId { get; set; }

        [Column("bonus_slab_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string BonusSlabCode { get; set; }

        [Column("bonus_slab_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string BonusSlabName { get; set; }

        [Column("effective_from")] 
        [ColumnDbType("date", 0, true, "")] 
        public DateTime? EffectiveFrom { get; set; }

        [Column("ends_on")] 
        [ColumnDbType("date", 0, true, "")] 
        public DateTime? EndsOn { get; set; }

        [Column("checking_frequency")] 
        [ColumnDbType("text", 0, true, "")] 
        public string CheckingFrequency { get; set; }

        [Column("account")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Account { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string StatementReference { get; set; }

    }

    [TableName("core.frequency_setup_scrud_view")]
    [ExplicitColumns]
    public class FrequencySetupScrudView : PetaPocoDB.Record<FrequencySetupScrudView> , IPoco
    {
        [Column("frequency_setup_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? FrequencySetupId { get; set; }

        [Column("frequency_setup_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string FrequencySetupCode { get; set; }

        [Column("fiscal_year_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string FiscalYearCode { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, true, "")] 
        public DateTime? ValueDate { get; set; }

        [Column("frequency_code")] 
        [ColumnDbType("text", 0, true, "")] 
        public string FrequencyCode { get; set; }

    }

    [TableName("core.item_scrud_view")]
    [ExplicitColumns]
    public class ItemScrudView : PetaPocoDB.Record<ItemScrudView> , IPoco
    {
        [Column("item_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? ItemId { get; set; }

        [Column("item_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ItemCode { get; set; }

        [Column("item_name")] 
        [ColumnDbType("varchar", 150, true, "")] 
        public string ItemName { get; set; }

        [Column("item_group")] 
        [ColumnDbType("text", 0, true, "")] 
        public string ItemGroup { get; set; }

        [Column("maintain_stock")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? MaintainStock { get; set; }

        [Column("brand")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Brand { get; set; }

        [Column("preferred_supplier")] 
        [ColumnDbType("text", 0, true, "")] 
        public string PreferredSupplier { get; set; }

        [Column("lead_time_in_days")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? LeadTimeInDays { get; set; }

        [Column("weight_in_grams")] 
        [ColumnDbType("float8", 0, true, "")] 
        public double? WeightInGrams { get; set; }

        [Column("width_in_centimeters")] 
        [ColumnDbType("float8", 0, true, "")] 
        public double? WidthInCentimeters { get; set; }

        [Column("height_in_centimeters")] 
        [ColumnDbType("float8", 0, true, "")] 
        public double? HeightInCentimeters { get; set; }

        [Column("length_in_centimeters")] 
        [ColumnDbType("float8", 0, true, "")] 
        public double? LengthInCentimeters { get; set; }

        [Column("machinable")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? Machinable { get; set; }

        [Column("preferred_shipping_mail_type")] 
        [ColumnDbType("text", 0, true, "")] 
        public string PreferredShippingMailType { get; set; }

        [Column("preferred_shipping_package_shape")] 
        [ColumnDbType("text", 0, true, "")] 
        public string PreferredShippingPackageShape { get; set; }

        [Column("unit")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Unit { get; set; }

        [Column("hot_item")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? HotItem { get; set; }

        [Column("cost_price")] 
        [ColumnDbType("money_strict2", 0, true, "")] 
        public decimal? CostPrice { get; set; }

        [Column("selling_price")] 
        [ColumnDbType("money_strict", 0, true, "")] 
        public decimal? SellingPrice { get; set; }

        [Column("selling_price_includes_tax")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? SellingPriceIncludesTax { get; set; }

        [Column("sales_tax")] 
        [ColumnDbType("text", 0, true, "")] 
        public string SalesTax { get; set; }

        [Column("reorder_unit")] 
        [ColumnDbType("text", 0, true, "")] 
        public string ReorderUnit { get; set; }

        [Column("reorder_level")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? ReorderLevel { get; set; }

        [Column("reorder_quantity")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? ReorderQuantity { get; set; }

    }

    [TableName("core.late_fee_scrud_view")]
    [ExplicitColumns]
    public class LateFeeScrudView : PetaPocoDB.Record<LateFeeScrudView> , IPoco
    {
        [Column("late_fee_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? LateFeeId { get; set; }

        [Column("late_fee_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string LateFeeCode { get; set; }

        [Column("late_fee_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string LateFeeName { get; set; }

        [Column("is_flat_amount")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsFlatAmount { get; set; }

        [Column("rate")] 
        [ColumnDbType("numeric", 1572868, true, "")] 
        public decimal? Rate { get; set; }

        [Column("account")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Account { get; set; }

    }

    [TableName("core.merchant_fee_setup_scrud_view")]
    [ExplicitColumns]
    public class MerchantFeeSetupScrudView : PetaPocoDB.Record<MerchantFeeSetupScrudView> , IPoco
    {
        [Column("merchant_fee_setup_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? MerchantFeeSetupId { get; set; }

        [Column("merchant_account")] 
        [ColumnDbType("text", 0, true, "")] 
        public string MerchantAccount { get; set; }

        [Column("payment_card")] 
        [ColumnDbType("text", 0, true, "")] 
        public string PaymentCard { get; set; }

        [Column("rate")] 
        [ColumnDbType("decimal_strict", 0, true, "")] 
        public decimal? Rate { get; set; }

        [Column("customer_pays_fee")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? CustomerPaysFee { get; set; }

        [Column("account")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Account { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string StatementReference { get; set; }

    }

    [TableName("core.party_scrud_view")]
    [ExplicitColumns]
    public class PartyScrudView : PetaPocoDB.Record<PartyScrudView> , IPoco
    {
        [Column("party_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? PartyId { get; set; }

        [Column("party_type_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? PartyTypeId { get; set; }

        [Column("is_supplier")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsSupplier { get; set; }

        [Column("party_type")] 
        [ColumnDbType("text", 0, true, "")] 
        public string PartyType { get; set; }

        [Column("party_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string PartyCode { get; set; }

        [Column("first_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string FirstName { get; set; }

        [Column("middle_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string MiddleName { get; set; }

        [Column("last_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string LastName { get; set; }

        [Column("currency_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string CurrencyCode { get; set; }

        [Column("party_name")] 
        [ColumnDbType("text", 0, true, "")] 
        public string PartyName { get; set; }

        [Column("company_name")] 
        [ColumnDbType("text", 0, true, "")] 
        public string CompanyName { get; set; }

        [Column("zip_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ZipCode { get; set; }

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
        [ColumnDbType("text", 0, true, "")] 
        public string State { get; set; }

        [Column("country")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Country { get; set; }

        [Column("allow_credit")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? AllowCredit { get; set; }

        [Column("maximum_credit_period")] 
        [ColumnDbType("int2", 0, true, "")] 
        public short? MaximumCreditPeriod { get; set; }

        [Column("maximum_credit_amount")] 
        [ColumnDbType("money_strict2", 0, true, "")] 
        public decimal? MaximumCreditAmount { get; set; }

        [Column("pan_number")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string PanNumber { get; set; }

        [Column("sst_number")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string SstNumber { get; set; }

        [Column("cst_number")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string CstNumber { get; set; }

        [Column("phone")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string Phone { get; set; }

        [Column("fax")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string Fax { get; set; }

        [Column("cell")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string Cell { get; set; }

        [Column("email")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string Email { get; set; }

        [Column("url")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string Url { get; set; }

        [Column("account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? AccountId { get; set; }

        [Column("account_number")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string AccountNumber { get; set; }

        [Column("gl_head")] 
        [ColumnDbType("text", 0, true, "")] 
        public string GlHead { get; set; }

        [Column("photo")] 
        [ColumnDbType("image", 0, true, "")] 
        public string Photo { get; set; }

    }

    [TableName("core.party_type_scrud_view")]
    [ExplicitColumns]
    public class PartyTypeScrudView : PetaPocoDB.Record<PartyTypeScrudView> , IPoco
    {
        [Column("party_type_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? PartyTypeId { get; set; }

        [Column("party_type_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string PartyTypeCode { get; set; }

        [Column("party_type_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string PartyTypeName { get; set; }

        [Column("is_supplier")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsSupplier { get; set; }

        [Column("account")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Account { get; set; }

    }

    [TableName("core.payment_term_scrud_view")]
    [ExplicitColumns]
    public class PaymentTermScrudView : PetaPocoDB.Record<PaymentTermScrudView> , IPoco
    {
        [Column("payment_term_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? PaymentTermId { get; set; }

        [Column("payment_term_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string PaymentTermCode { get; set; }

        [Column("payment_term_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string PaymentTermName { get; set; }

        [Column("due_on_date")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? DueOnDate { get; set; }

        [Column("due_days")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? DueDays { get; set; }

        [Column("due_frequency")] 
        [ColumnDbType("text", 0, true, "")] 
        public string DueFrequency { get; set; }

        [Column("grace_period")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? GracePeriod { get; set; }

        [Column("late_fee")] 
        [ColumnDbType("text", 0, true, "")] 
        public string LateFee { get; set; }

        [Column("late_fee_posting_frequency")] 
        [ColumnDbType("text", 0, true, "")] 
        public string LateFeePostingFrequency { get; set; }

    }

    [TableName("core.recurrence_type_scrud_view")]
    [ExplicitColumns]
    public class RecurrenceTypeScrudView : PetaPocoDB.Record<RecurrenceTypeScrudView> , IPoco
    {
        [Column("recurrence_type_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? RecurrenceTypeId { get; set; }

        [Column("recurrence_type_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string RecurrenceTypeCode { get; set; }

        [Column("recurrence_type_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string RecurrenceTypeName { get; set; }

        [Column("is_frequency")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsFrequency { get; set; }

    }

    [TableName("core.recurring_invoice_scrud_view")]
    [ExplicitColumns]
    public class RecurringInvoiceScrudView : PetaPocoDB.Record<RecurringInvoiceScrudView> , IPoco
    {
        [Column("recurring_invoice_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? RecurringInvoiceId { get; set; }

        [Column("recurring_invoice_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string RecurringInvoiceCode { get; set; }

        [Column("recurring_invoice_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string RecurringInvoiceName { get; set; }

        [Column("item")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Item { get; set; }

        [Column("total_duration")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? TotalDuration { get; set; }

        [Column("recurrence_type")] 
        [ColumnDbType("text", 0, true, "")] 
        public string RecurrenceType { get; set; }

        [Column("recurring_frequency")] 
        [ColumnDbType("text", 0, true, "")] 
        public string RecurringFrequency { get; set; }

        [Column("recurring_duration")] 
        [ColumnDbType("integer_strict2", 0, true, "")] 
        public int? RecurringDuration { get; set; }

        [Column("recurs_on_same_calendar_date")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? RecursOnSameCalendarDate { get; set; }

        [Column("recurring_amount")] 
        [ColumnDbType("money_strict", 0, true, "")] 
        public decimal? RecurringAmount { get; set; }

        [Column("account")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Account { get; set; }

        [Column("payment_term")] 
        [ColumnDbType("text", 0, true, "")] 
        public string PaymentTerm { get; set; }

        [Column("auto_trigger_on_sales")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? AutoTriggerOnSales { get; set; }

        [Column("is_active")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsActive { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string StatementReference { get; set; }

    }

    [TableName("core.recurring_invoice_setup_scrud_view")]
    [ExplicitColumns]
    public class RecurringInvoiceSetupScrudView : PetaPocoDB.Record<RecurringInvoiceSetupScrudView> , IPoco
    {
        [Column("recurring_invoice_setup_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? RecurringInvoiceSetupId { get; set; }

        [Column("recurring_invoice")] 
        [ColumnDbType("text", 0, true, "")] 
        public string RecurringInvoice { get; set; }

        [Column("party")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Party { get; set; }

        [Column("starts_from")] 
        [ColumnDbType("date", 0, true, "")] 
        public DateTime? StartsFrom { get; set; }

        [Column("ends_on")] 
        [ColumnDbType("date", 0, true, "")] 
        public DateTime? EndsOn { get; set; }

        [Column("recurrence_type")] 
        [ColumnDbType("text", 0, true, "")] 
        public string RecurrenceType { get; set; }

        [Column("recurring_frequency")] 
        [ColumnDbType("text", 0, true, "")] 
        public string RecurringFrequency { get; set; }

        [Column("recurring_duration")] 
        [ColumnDbType("integer_strict2", 0, true, "")] 
        public int? RecurringDuration { get; set; }

        [Column("recurs_on_same_calendar_date")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? RecursOnSameCalendarDate { get; set; }

        [Column("recurring_amount")] 
        [ColumnDbType("money_strict", 0, true, "")] 
        public decimal? RecurringAmount { get; set; }

        [Column("account")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Account { get; set; }

        [Column("payment_term")] 
        [ColumnDbType("text", 0, true, "")] 
        public string PaymentTerm { get; set; }

        [Column("is_active")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsActive { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string StatementReference { get; set; }

    }

    [TableName("core.salesperson_bonus_setup_scrud_view")]
    [ExplicitColumns]
    public class SalespersonBonusSetupScrudView : PetaPocoDB.Record<SalespersonBonusSetupScrudView> , IPoco
    {
        [Column("salesperson_bonus_setup_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? SalespersonBonusSetupId { get; set; }

        [Column("salesperson")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Salesperson { get; set; }

        [Column("bonus_slab")] 
        [ColumnDbType("text", 0, true, "")] 
        public string BonusSlab { get; set; }

    }

    [TableName("core.salesperson_scrud_view")]
    [ExplicitColumns]
    public class SalespersonScrudView : PetaPocoDB.Record<SalespersonScrudView> , IPoco
    {
        [Column("salesperson_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? SalespersonId { get; set; }

        [Column("sales_team")] 
        [ColumnDbType("text", 0, true, "")] 
        public string SalesTeam { get; set; }

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

        [Column("account")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Account { get; set; }

    }

    [TableName("core.shipping_address_scrud_view")]
    [ExplicitColumns]
    public class ShippingAddressScrudView : PetaPocoDB.Record<ShippingAddressScrudView> , IPoco
    {
        [Column("shipping_address_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? ShippingAddressId { get; set; }

        [Column("shipping_address_code")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string ShippingAddressCode { get; set; }

        [Column("party")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Party { get; set; }

        [Column("state")] 
        [ColumnDbType("text", 0, true, "")] 
        public string State { get; set; }

        [Column("country")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Country { get; set; }

        [Column("zip_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ZipCode { get; set; }

        [Column("address_line_1")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string AddressLine1 { get; set; }

        [Column("address_line_2")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string AddressLine2 { get; set; }

        [Column("street")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string Street { get; set; }

        [Column("city")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string City { get; set; }

    }

    [TableName("core.discount_received_account_selector_view")]
    [ExplicitColumns]
    public class DiscountReceivedAccountSelectorView : PetaPocoDB.Record<DiscountReceivedAccountSelectorView> , IPoco
    {
        [Column("account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? AccountId { get; set; }

        [Column("account_master")] 
        [ColumnDbType("text", 0, true, "")] 
        public string AccountMaster { get; set; }

        [Column("account_number")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string AccountNumber { get; set; }

        [Column("external_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ExternalCode { get; set; }

        [Column("currency")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Currency { get; set; }

        [Column("account_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string AccountName { get; set; }

        [Column("description")] 
        [ColumnDbType("varchar", 200, true, "")] 
        public string Description { get; set; }

        [Column("confidential")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? Confidential { get; set; }

        [Column("is_transaction_node")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsTransactionNode { get; set; }

        [Column("sys_type")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? SysType { get; set; }

        [Column("account_master_id")] 
        [ColumnDbType("int2", 0, true, "")] 
        public short? AccountMasterId { get; set; }

        [Column("parent")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Parent { get; set; }

    }

    [TableName("core.expenses_account_selector_view")]
    [ExplicitColumns]
    public class ExpensesAccountSelectorView : PetaPocoDB.Record<ExpensesAccountSelectorView> , IPoco
    {
        [Column("account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? AccountId { get; set; }

        [Column("account_master")] 
        [ColumnDbType("text", 0, true, "")] 
        public string AccountMaster { get; set; }

        [Column("account_number")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string AccountNumber { get; set; }

        [Column("external_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ExternalCode { get; set; }

        [Column("currency")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Currency { get; set; }

        [Column("account_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string AccountName { get; set; }

        [Column("description")] 
        [ColumnDbType("varchar", 200, true, "")] 
        public string Description { get; set; }

        [Column("confidential")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? Confidential { get; set; }

        [Column("is_transaction_node")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsTransactionNode { get; set; }

        [Column("sys_type")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? SysType { get; set; }

        [Column("account_master_id")] 
        [ColumnDbType("int2", 0, true, "")] 
        public short? AccountMasterId { get; set; }

        [Column("parent")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Parent { get; set; }

    }

    [TableName("core.item_selector_view")]
    [ExplicitColumns]
    public class ItemSelectorView : PetaPocoDB.Record<ItemSelectorView> , IPoco
    {
        [Column("item_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? ItemId { get; set; }

        [Column("item_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ItemCode { get; set; }

        [Column("item_name")] 
        [ColumnDbType("varchar", 150, true, "")] 
        public string ItemName { get; set; }

        [Column("item_group_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? ItemGroupId { get; set; }

        [Column("item_type_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? ItemTypeId { get; set; }

        [Column("brand_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? BrandId { get; set; }

        [Column("preferred_supplier_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? PreferredSupplierId { get; set; }

        [Column("lead_time_in_days")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? LeadTimeInDays { get; set; }

        [Column("weight_in_grams")] 
        [ColumnDbType("float8", 0, true, "")] 
        public double? WeightInGrams { get; set; }

        [Column("width_in_centimeters")] 
        [ColumnDbType("float8", 0, true, "")] 
        public double? WidthInCentimeters { get; set; }

        [Column("height_in_centimeters")] 
        [ColumnDbType("float8", 0, true, "")] 
        public double? HeightInCentimeters { get; set; }

        [Column("length_in_centimeters")] 
        [ColumnDbType("float8", 0, true, "")] 
        public double? LengthInCentimeters { get; set; }

        [Column("machinable")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? Machinable { get; set; }

        [Column("preferred_shipping_mail_type_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? PreferredShippingMailTypeId { get; set; }

        [Column("shipping_package_shape_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? ShippingPackageShapeId { get; set; }

        [Column("unit_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? UnitId { get; set; }

        [Column("hot_item")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? HotItem { get; set; }

        [Column("cost_price")] 
        [ColumnDbType("money_strict2", 0, true, "")] 
        public decimal? CostPrice { get; set; }

        [Column("selling_price")] 
        [ColumnDbType("money_strict", 0, true, "")] 
        public decimal? SellingPrice { get; set; }

        [Column("selling_price_includes_tax")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? SellingPriceIncludesTax { get; set; }

        [Column("sales_tax_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? SalesTaxId { get; set; }

        [Column("reorder_unit_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? ReorderUnitId { get; set; }

        [Column("reorder_level")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? ReorderLevel { get; set; }

        [Column("reorder_quantity")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? ReorderQuantity { get; set; }

        [Column("maintain_stock")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? MaintainStock { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

        [Column("photo")] 
        [ColumnDbType("image", 0, true, "")] 
        public string Photo { get; set; }

    }

    [TableName("core.merchant_account_selector_view")]
    [ExplicitColumns]
    public class MerchantAccountSelectorView : PetaPocoDB.Record<MerchantAccountSelectorView> , IPoco
    {
        [Column("account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? AccountId { get; set; }

        [Column("maintained_by_user_id")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string MaintainedByUserId { get; set; }

        [Column("office")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Office { get; set; }

        [Column("bank_name")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string BankName { get; set; }

        [Column("bank_branch")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string BankBranch { get; set; }

        [Column("bank_contact_number")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string BankContactNumber { get; set; }

        [Column("bank_address")] 
        [ColumnDbType("text", 0, true, "")] 
        public string BankAddress { get; set; }

        [Column("bank_account_number")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string BankAccountNumber { get; set; }

        [Column("bank_account_type")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string BankAccountType { get; set; }

        [Column("relationship_officer_name")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string RelationshipOfficerName { get; set; }

        [Column("is_merchant_account")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsMerchantAccount { get; set; }

    }

    [TableName("core.purchase_account_selector_view")]
    [ExplicitColumns]
    public class PurchaseAccountSelectorView : PetaPocoDB.Record<PurchaseAccountSelectorView> , IPoco
    {
        [Column("account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? AccountId { get; set; }

        [Column("account_master")] 
        [ColumnDbType("text", 0, true, "")] 
        public string AccountMaster { get; set; }

        [Column("account_number")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string AccountNumber { get; set; }

        [Column("external_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ExternalCode { get; set; }

        [Column("currency")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Currency { get; set; }

        [Column("account_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string AccountName { get; set; }

        [Column("description")] 
        [ColumnDbType("varchar", 200, true, "")] 
        public string Description { get; set; }

        [Column("confidential")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? Confidential { get; set; }

        [Column("is_transaction_node")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsTransactionNode { get; set; }

        [Column("sys_type")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? SysType { get; set; }

        [Column("account_master_id")] 
        [ColumnDbType("int2", 0, true, "")] 
        public short? AccountMasterId { get; set; }

        [Column("parent")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Parent { get; set; }

    }

    [TableName("core.sales_return_account_selector_view")]
    [ExplicitColumns]
    public class SalesReturnAccountSelectorView : PetaPocoDB.Record<SalesReturnAccountSelectorView> , IPoco
    {
        [Column("account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? AccountId { get; set; }

        [Column("account_master")] 
        [ColumnDbType("text", 0, true, "")] 
        public string AccountMaster { get; set; }

        [Column("account_number")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string AccountNumber { get; set; }

        [Column("external_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ExternalCode { get; set; }

        [Column("currency")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Currency { get; set; }

        [Column("account_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string AccountName { get; set; }

        [Column("description")] 
        [ColumnDbType("varchar", 200, true, "")] 
        public string Description { get; set; }

        [Column("confidential")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? Confidential { get; set; }

        [Column("is_transaction_node")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsTransactionNode { get; set; }

        [Column("sys_type")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? SysType { get; set; }

        [Column("account_master_id")] 
        [ColumnDbType("int2", 0, true, "")] 
        public short? AccountMasterId { get; set; }

        [Column("parent")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Parent { get; set; }

    }

    [TableName("core.supplier_selector_view")]
    [ExplicitColumns]
    public class SupplierSelectorView : PetaPocoDB.Record<SupplierSelectorView> , IPoco
    {
        [Column("party_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? PartyId { get; set; }

        [Column("party_type_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? PartyTypeId { get; set; }

        [Column("is_supplier")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsSupplier { get; set; }

        [Column("party_type")] 
        [ColumnDbType("text", 0, true, "")] 
        public string PartyType { get; set; }

        [Column("party_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string PartyCode { get; set; }

        [Column("first_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string FirstName { get; set; }

        [Column("middle_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string MiddleName { get; set; }

        [Column("last_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string LastName { get; set; }

        [Column("party_name")] 
        [ColumnDbType("text", 0, true, "")] 
        public string PartyName { get; set; }

        [Column("zip_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ZipCode { get; set; }

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
        [ColumnDbType("text", 0, true, "")] 
        public string State { get; set; }

        [Column("country")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Country { get; set; }

        [Column("allow_credit")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? AllowCredit { get; set; }

        [Column("maximum_credit_period")] 
        [ColumnDbType("int2", 0, true, "")] 
        public short? MaximumCreditPeriod { get; set; }

        [Column("maximum_credit_amount")] 
        [ColumnDbType("money_strict2", 0, true, "")] 
        public decimal? MaximumCreditAmount { get; set; }

        [Column("pan_number")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string PanNumber { get; set; }

        [Column("sst_number")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string SstNumber { get; set; }

        [Column("cst_number")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string CstNumber { get; set; }

        [Column("phone")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string Phone { get; set; }

        [Column("fax")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string Fax { get; set; }

        [Column("cell")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string Cell { get; set; }

        [Column("email")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string Email { get; set; }

        [Column("url")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string Url { get; set; }

        [Column("account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? AccountId { get; set; }

        [Column("account_number")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string AccountNumber { get; set; }

        [Column("gl_head")] 
        [ColumnDbType("text", 0, true, "")] 
        public string GlHead { get; set; }

    }

    [TableName("core.default_widget_setup_view")]
    [ExplicitColumns]
    public class DefaultWidgetSetupView : PetaPocoDB.Record<DefaultWidgetSetupView> , IPoco
    {
        [Column("widget_setup_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? WidgetSetupId { get; set; }

        [Column("widget_order")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? WidgetOrder { get; set; }

        [Column("widget_group_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string WidgetGroupName { get; set; }

        [Column("widget_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string WidgetName { get; set; }

        [Column("widget_source")] 
        [ColumnDbType("text", 0, true, "")] 
        public string WidgetSource { get; set; }

    }

    [TableName("core.item_view")]
    [ExplicitColumns]
    public class ItemView : PetaPocoDB.Record<ItemView> , IPoco
    {
        [Column("item_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? ItemId { get; set; }

        [Column("item_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ItemCode { get; set; }

        [Column("item_name")] 
        [ColumnDbType("varchar", 150, true, "")] 
        public string ItemName { get; set; }

        [Column("item_group")] 
        [ColumnDbType("text", 0, true, "")] 
        public string ItemGroup { get; set; }

        [Column("item_type")] 
        [ColumnDbType("text", 0, true, "")] 
        public string ItemType { get; set; }

        [Column("maintain_stock")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? MaintainStock { get; set; }

        [Column("brand")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Brand { get; set; }

        [Column("preferred_supplier")] 
        [ColumnDbType("text", 0, true, "")] 
        public string PreferredSupplier { get; set; }

        [Column("lead_time_in_days")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? LeadTimeInDays { get; set; }

        [Column("weight_in_grams")] 
        [ColumnDbType("float8", 0, true, "")] 
        public double? WeightInGrams { get; set; }

        [Column("width_in_centimeters")] 
        [ColumnDbType("float8", 0, true, "")] 
        public double? WidthInCentimeters { get; set; }

        [Column("height_in_centimeters")] 
        [ColumnDbType("float8", 0, true, "")] 
        public double? HeightInCentimeters { get; set; }

        [Column("length_in_centimeters")] 
        [ColumnDbType("float8", 0, true, "")] 
        public double? LengthInCentimeters { get; set; }

        [Column("machinable")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? Machinable { get; set; }

        [Column("preferred_shipping_mail_type")] 
        [ColumnDbType("text", 0, true, "")] 
        public string PreferredShippingMailType { get; set; }

        [Column("preferred_shipping_package_shape")] 
        [ColumnDbType("text", 0, true, "")] 
        public string PreferredShippingPackageShape { get; set; }

        [Column("unit")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Unit { get; set; }

        [Column("base_unit")] 
        [ColumnDbType("text", 0, true, "")] 
        public string BaseUnit { get; set; }

        [Column("hot_item")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? HotItem { get; set; }

        [Column("cost_price")] 
        [ColumnDbType("money_strict2", 0, true, "")] 
        public decimal? CostPrice { get; set; }

        [Column("selling_price")] 
        [ColumnDbType("money_strict", 0, true, "")] 
        public decimal? SellingPrice { get; set; }

        [Column("selling_price_includes_tax")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? SellingPriceIncludesTax { get; set; }

        [Column("sales_tax")] 
        [ColumnDbType("text", 0, true, "")] 
        public string SalesTax { get; set; }

        [Column("reorder_unit")] 
        [ColumnDbType("text", 0, true, "")] 
        public string ReorderUnit { get; set; }

        [Column("reorder_level")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? ReorderLevel { get; set; }

        [Column("reorder_quantity")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? ReorderQuantity { get; set; }

    }

    [TableName("core.party_view")]
    [ExplicitColumns]
    public class PartyView : PetaPocoDB.Record<PartyView> , IPoco
    {
        [Column("party_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? PartyId { get; set; }

        [Column("party_type_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? PartyTypeId { get; set; }

        [Column("is_supplier")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsSupplier { get; set; }

        [Column("party_type")] 
        [ColumnDbType("text", 0, true, "")] 
        public string PartyType { get; set; }

        [Column("party_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string PartyCode { get; set; }

        [Column("first_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string FirstName { get; set; }

        [Column("middle_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string MiddleName { get; set; }

        [Column("last_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string LastName { get; set; }

        [Column("party_name")] 
        [ColumnDbType("text", 0, true, "")] 
        public string PartyName { get; set; }

        [Column("zip_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ZipCode { get; set; }

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
        [ColumnDbType("text", 0, true, "")] 
        public string State { get; set; }

        [Column("country")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Country { get; set; }

        [Column("allow_credit")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? AllowCredit { get; set; }

        [Column("maximum_credit_period")] 
        [ColumnDbType("int2", 0, true, "")] 
        public short? MaximumCreditPeriod { get; set; }

        [Column("maximum_credit_amount")] 
        [ColumnDbType("money_strict2", 0, true, "")] 
        public decimal? MaximumCreditAmount { get; set; }

        [Column("pan_number")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string PanNumber { get; set; }

        [Column("sst_number")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string SstNumber { get; set; }

        [Column("cst_number")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string CstNumber { get; set; }

        [Column("phone")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string Phone { get; set; }

        [Column("fax")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string Fax { get; set; }

        [Column("cell")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string Cell { get; set; }

        [Column("email")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string Email { get; set; }

        [Column("url")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string Url { get; set; }

        [Column("photo")] 
        [ColumnDbType("image", 0, true, "")] 
        public string Photo { get; set; }

        [Column("account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? AccountId { get; set; }

        [Column("account_number")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string AccountNumber { get; set; }

        [Column("gl_head")] 
        [ColumnDbType("text", 0, true, "")] 
        public string GlHead { get; set; }

    }

    [TableName("core.shipping_address_view")]
    [ExplicitColumns]
    public class ShippingAddressView : PetaPocoDB.Record<ShippingAddressView> , IPoco
    {
        [Column("shipping_address_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? ShippingAddressId { get; set; }

        [Column("shipping_address_code")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string ShippingAddressCode { get; set; }

        [Column("zip_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ZipCode { get; set; }

        [Column("party_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? PartyId { get; set; }

        [Column("country_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? CountryId { get; set; }

        [Column("state_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? StateId { get; set; }

        [Column("country_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string CountryName { get; set; }

        [Column("state_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string StateName { get; set; }

        [Column("address_line_1")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string AddressLine1 { get; set; }

        [Column("address_line_2")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string AddressLine2 { get; set; }

        [Column("street")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string Street { get; set; }

        [Column("city")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string City { get; set; }

    }

    [TableName("core.widget_setup_view")]
    [ExplicitColumns]
    public class WidgetSetupView : PetaPocoDB.Record<WidgetSetupView> , IPoco
    {
        [Column("widget_setup_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? WidgetSetupId { get; set; }

        [Column("widget_order")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? WidgetOrder { get; set; }

        [Column("widget_group_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string WidgetGroupName { get; set; }

        [Column("widget_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string WidgetName { get; set; }

        [Column("widget_source")] 
        [ColumnDbType("text", 0, true, "")] 
        public string WidgetSource { get; set; }

    }

    [TableName("core.nationalities")]
    [PrimaryKey("nationality_code", autoIncrement=false)]
    [ExplicitColumns]
    public class Nationality : PetaPocoDB.Record<Nationality> , IPoco
    {
        [Column("nationality_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string NationalityCode { get; set; }

        [Column("nationality_name")] 
        [ColumnDbType("varchar", 100, false, "")] 
        public string NationalityName { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.genders")]
    [PrimaryKey("gender_code", autoIncrement=false)]
    [ExplicitColumns]
    public class Gender : PetaPocoDB.Record<Gender> , IPoco
    {
        [Column("gender_code")] 
        [ColumnDbType("bpchar", 2, false, "")] 
        public string GenderCode { get; set; }

        [Column("gender_name")] 
        [ColumnDbType("varchar", 50, false, "")] 
        public string GenderName { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.filters")]
    [PrimaryKey("filter_id", autoIncrement=true)]
    [ExplicitColumns]
    public class Filter : PetaPocoDB.Record<Filter> , IPoco
    {
        [Column("filter_id")] 
        [ColumnDbType("int8", 0, false, "nextval('core.filters_filter_id_seq'::regclass)")] 
        public long FilterId { get; set; }

        [Column("object_name")] 
        [ColumnDbType("text", 0, false, "")] 
        public string ObjectName { get; set; }

        [Column("filter_name")] 
        [ColumnDbType("text", 0, false, "")] 
        public string FilterName { get; set; }

        [Column("is_default")] 
        [ColumnDbType("bool", 0, false, "false")] 
        public bool IsDefault { get; set; }

        [Column("is_default_admin")] 
        [ColumnDbType("bool", 0, false, "false")] 
        public bool IsDefaultAdmin { get; set; }

        [Column("column_name")] 
        [ColumnDbType("text", 0, false, "")] 
        public string ColumnName { get; set; }

        [Column("filter_condition")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int FilterCondition { get; set; }

        [Column("filter_value")] 
        [ColumnDbType("text", 0, true, "")] 
        public string FilterValue { get; set; }

        [Column("filter_and_value")] 
        [ColumnDbType("text", 0, true, "")] 
        public string FilterAndValue { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.identification_types")]
    [PrimaryKey("identification_type_code", autoIncrement=false)]
    [ExplicitColumns]
    public class IdentificationType : PetaPocoDB.Record<IdentificationType> , IPoco
    {
        [Column("identification_type_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string IdentificationTypeCode { get; set; }

        [Column("identification_type_name")] 
        [ColumnDbType("varchar", 100, false, "")] 
        public string IdentificationTypeName { get; set; }

        [Column("can_expire")] 
        [ColumnDbType("bool", 0, false, "false")] 
        public bool CanExpire { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.social_networks")]
    [PrimaryKey("social_network_name", autoIncrement=false)]
    [ExplicitColumns]
    public class SocialNetwork : PetaPocoDB.Record<SocialNetwork> , IPoco
    {
        [Column("social_network_name")] 
        [ColumnDbType("varchar", 128, false, "")] 
        public string SocialNetworkName { get; set; }

        [Column("semantic_css_class")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string SemanticCssClass { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.education_levels")]
    [PrimaryKey("education_level_id", autoIncrement=true)]
    [ExplicitColumns]
    public class EducationLevel : PetaPocoDB.Record<EducationLevel> , IPoco
    {
        [Column("education_level_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.education_levels_education_level_id_seq'::regclass)")] 
        public int EducationLevelId { get; set; }

        [Column("education_level_name")] 
        [ColumnDbType("varchar", 50, false, "")] 
        public string EducationLevelName { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.countries")]
    [PrimaryKey("country_id", autoIncrement=true)]
    [ExplicitColumns]
    public class Country : PetaPocoDB.Record<Country> , IPoco
    {
        [Column("country_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.countries_country_id_seq'::regclass)")] 
        public int CountryId { get; set; }

        [Column("country_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string CountryCode { get; set; }

        [Column("country_name")] 
        [ColumnDbType("varchar", 100, false, "")] 
        public string CountryName { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.currencies")]
    [PrimaryKey("currency_code", autoIncrement=false)]
    [ExplicitColumns]
    public class Currency : PetaPocoDB.Record<Currency> , IPoco
    {
        [Column("currency_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string CurrencyCode { get; set; }

        [Column("currency_symbol")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string CurrencySymbol { get; set; }

        [Column("currency_name")] 
        [ColumnDbType("varchar", 48, false, "")] 
        public string CurrencyName { get; set; }

        [Column("hundredth_name")] 
        [ColumnDbType("varchar", 48, false, "")] 
        public string HundredthName { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.flag_types")]
    [PrimaryKey("flag_type_id", autoIncrement=true)]
    [ExplicitColumns]
    public class FlagType : PetaPocoDB.Record<FlagType> , IPoco
    {
        [Column("flag_type_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.flag_types_flag_type_id_seq'::regclass)")] 
        public int FlagTypeId { get; set; }

        [Column("flag_type_name")] 
        [ColumnDbType("varchar", 24, false, "")] 
        public string FlagTypeName { get; set; }

        [Column("background_color")] 
        [ColumnDbType("color", 0, false, "")] 
        public string BackgroundColor { get; set; }

        [Column("foreground_color")] 
        [ColumnDbType("color", 0, false, "")] 
        public string ForegroundColor { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.flags")]
    [PrimaryKey("flag_id", autoIncrement=true)]
    [ExplicitColumns]
    public class Flag : PetaPocoDB.Record<Flag> , IPoco
    {
        [Column("flag_id")] 
        [ColumnDbType("int8", 0, false, "nextval('core.flags_flag_id_seq'::regclass)")] 
        public long FlagId { get; set; }

        [Column("user_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int UserId { get; set; }

        [Column("flag_type_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int FlagTypeId { get; set; }

        [Column("resource")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Resource { get; set; }

        [Column("resource_key")] 
        [ColumnDbType("text", 0, true, "")] 
        public string ResourceKey { get; set; }

        [Column("resource_id")] 
        [ColumnDbType("text", 0, true, "")] 
        public string ResourceId { get; set; }

        [Column("flagged_on")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? FlaggedOn { get; set; }

    }

    [TableName("core.zip_code_types")]
    [PrimaryKey("zip_code_type_id", autoIncrement=true)]
    [ExplicitColumns]
    public class ZipCodeType : PetaPocoDB.Record<ZipCodeType> , IPoco
    {
        [Column("zip_code_type_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.zip_code_types_zip_code_type_id_seq'::regclass)")] 
        public int ZipCodeTypeId { get; set; }

        [Column("type")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string Type { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.zip_codes")]
    [PrimaryKey("zip_code_id", autoIncrement=true)]
    [ExplicitColumns]
    public class ZipCode : PetaPocoDB.Record<ZipCode> , IPoco
    {
        [Column("zip_code_id")] 
        [ColumnDbType("int8", 0, false, "nextval('core.zip_codes_zip_code_id_seq'::regclass)")] 
        public long ZipCodeId { get; set; }

        [Column("state_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int StateId { get; set; }

        [Column("code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string Code { get; set; }

        [Column("zip_code_type_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int ZipCodeTypeId { get; set; }

        [Column("city")] 
        [ColumnDbType("varchar", 100, false, "")] 
        public string City { get; set; }

        [Column("lat")] 
        [ColumnDbType("numeric", 0, true, "")] 
        public decimal? Lat { get; set; }

        [Column("lon")] 
        [ColumnDbType("numeric", 0, true, "")] 
        public decimal? Lon { get; set; }

        [Column("x_axis")] 
        [ColumnDbType("numeric", 0, true, "")] 
        public decimal? XAxis { get; set; }

        [Column("y_axis")] 
        [ColumnDbType("numeric", 0, true, "")] 
        public decimal? YAxis { get; set; }

        [Column("z_axis")] 
        [ColumnDbType("numeric", 0, true, "")] 
        public decimal? ZAxis { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.attachment_lookup")]
    [PrimaryKey("attachment_lookup_id", autoIncrement=true)]
    [ExplicitColumns]
    public class AttachmentLookup : PetaPocoDB.Record<AttachmentLookup> , IPoco
    {
        [Column("attachment_lookup_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.attachment_lookup_attachment_lookup_id_seq'::regclass)")] 
        public int AttachmentLookupId { get; set; }

        [Column("book")] 
        [ColumnDbType("varchar", 50, false, "")] 
        public string Book { get; set; }

        [Column("resource")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Resource { get; set; }

        [Column("resource_key")] 
        [ColumnDbType("text", 0, false, "")] 
        public string ResourceKey { get; set; }

    }

    [TableName("core.attachments")]
    [PrimaryKey("attachment_id", autoIncrement=true)]
    [ExplicitColumns]
    public class Attachment : PetaPocoDB.Record<Attachment> , IPoco
    {
        [Column("attachment_id")] 
        [ColumnDbType("int8", 0, false, "nextval('core.attachments_attachment_id_seq'::regclass)")] 
        public long AttachmentId { get; set; }

        [Column("user_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int UserId { get; set; }

        [Column("resource")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Resource { get; set; }

        [Column("resource_key")] 
        [ColumnDbType("text", 0, false, "")] 
        public string ResourceKey { get; set; }

        [Column("resource_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long ResourceId { get; set; }

        [Column("original_file_name")] 
        [ColumnDbType("text", 0, false, "")] 
        public string OriginalFileName { get; set; }

        [Column("file_extension")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string FileExtension { get; set; }

        [Column("file_path")] 
        [ColumnDbType("text", 0, false, "")] 
        public string FilePath { get; set; }

        [Column("comment")] 
        [ColumnDbType("varchar", 96, false, "")] 
        public string Comment { get; set; }

        [Column("added_on")] 
        [ColumnDbType("timestamptz", 0, false, "")] 
        public DateTime AddedOn { get; set; }

    }

    [TableName("core.exchange_rates")]
    [PrimaryKey("exchange_rate_id", autoIncrement=true)]
    [ExplicitColumns]
    public class ExchangeRate : PetaPocoDB.Record<ExchangeRate> , IPoco
    {
        [Column("exchange_rate_id")] 
        [ColumnDbType("int8", 0, false, "nextval('core.exchange_rates_exchange_rate_id_seq'::regclass)")] 
        public long ExchangeRateId { get; set; }

        [Column("updated_on")] 
        [ColumnDbType("timestamptz", 0, false, "")] 
        public DateTime UpdatedOn { get; set; }

        [Column("office_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int OfficeId { get; set; }

        [Column("status")] 
        [ColumnDbType("bool", 0, false, "true")] 
        public bool Status { get; set; }

    }

    [TableName("core.exchange_rate_details")]
    [PrimaryKey("exchange_rate_detail_id", autoIncrement=true)]
    [ExplicitColumns]
    public class ExchangeRateDetail : PetaPocoDB.Record<ExchangeRateDetail> , IPoco
    {
        [Column("exchange_rate_detail_id")] 
        [ColumnDbType("int8", 0, false, "nextval('core.exchange_rate_details_exchange_rate_detail_id_seq'::regclass)")] 
        public long ExchangeRateDetailId { get; set; }

        [Column("exchange_rate_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long ExchangeRateId { get; set; }

        [Column("local_currency_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string LocalCurrencyCode { get; set; }

        [Column("foreign_currency_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string ForeignCurrencyCode { get; set; }

        [Column("unit")] 
        [ColumnDbType("integer_strict", 0, false, "")] 
        public int Unit { get; set; }

        [Column("exchange_rate")] 
        [ColumnDbType("decimal_strict", 0, false, "")] 
        public decimal ExchangeRate { get; set; }

    }

    [TableName("core.menu_locale")]
    [PrimaryKey("menu_locale_id", autoIncrement=true)]
    [ExplicitColumns]
    public class MenuLocale : PetaPocoDB.Record<MenuLocale> , IPoco
    {
        [Column("menu_locale_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.menu_locale_menu_locale_id_seq'::regclass)")] 
        public int MenuLocaleId { get; set; }

        [Column("menu_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int MenuId { get; set; }

        [Column("culture")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string Culture { get; set; }

        [Column("menu_text")] 
        [ColumnDbType("varchar", 250, false, "")] 
        public string MenuText { get; set; }

    }

    [TableName("core.menus")]
    [PrimaryKey("menu_id", autoIncrement=true)]
    [ExplicitColumns]
    public class Menu : PetaPocoDB.Record<Menu> , IPoco
    {
        [Column("menu_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.menus_menu_id_seq'::regclass)")] 
        public int MenuId { get; set; }

        [Column("menu_text")] 
        [ColumnDbType("varchar", 250, false, "")] 
        public string MenuText { get; set; }

        [Column("url")] 
        [ColumnDbType("varchar", 250, true, "")] 
        public string Url { get; set; }

        [Column("menu_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string MenuCode { get; set; }

        [Column("level")] 
        [ColumnDbType("int2", 0, false, "")] 
        public short Level { get; set; }

        [Column("parent_menu_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? ParentMenuId { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.fiscal_year")]
    [PrimaryKey("fiscal_year_code", autoIncrement=false)]
    [ExplicitColumns]
    public class FiscalYear : PetaPocoDB.Record<FiscalYear> , IPoco
    {
        [Column("fiscal_year_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string FiscalYearCode { get; set; }

        [Column("fiscal_year_name")] 
        [ColumnDbType("varchar", 50, false, "")] 
        public string FiscalYearName { get; set; }

        [Column("starts_from")] 
        [ColumnDbType("date", 0, false, "")] 
        public DateTime StartsFrom { get; set; }

        [Column("ends_on")] 
        [ColumnDbType("date", 0, false, "")] 
        public DateTime EndsOn { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.frequency_setups")]
    [PrimaryKey("frequency_setup_id", autoIncrement=true)]
    [ExplicitColumns]
    public class FrequencySetup : PetaPocoDB.Record<FrequencySetup> , IPoco
    {
        [Column("frequency_setup_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.frequency_setups_frequency_setup_id_seq'::regclass)")] 
        public int FrequencySetupId { get; set; }

        [Column("fiscal_year_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string FiscalYearCode { get; set; }

        [Column("frequency_setup_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string FrequencySetupCode { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, false, "")] 
        public DateTime ValueDate { get; set; }

        [Column("frequency_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int FrequencyId { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.compound_units")]
    [PrimaryKey("compound_unit_id", autoIncrement=true)]
    [ExplicitColumns]
    public class CompoundUnit : PetaPocoDB.Record<CompoundUnit> , IPoco
    {
        [Column("compound_unit_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.compound_units_compound_unit_id_seq'::regclass)")] 
        public int CompoundUnitId { get; set; }

        [Column("base_unit_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int BaseUnitId { get; set; }

        [Column("value")] 
        [ColumnDbType("int2", 0, false, "")] 
        public short Value { get; set; }

        [Column("compare_unit_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int CompareUnitId { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.transaction_types")]
    [PrimaryKey("transaction_type_id", autoIncrement=false)]
    [ExplicitColumns]
    public class TransactionType : PetaPocoDB.Record<TransactionType> , IPoco
    {
        [Column("transaction_type_id")] 
        [ColumnDbType("int2", 0, false, "")] 
        public short TransactionTypeId { get; set; }

        [Column("transaction_type_code")] 
        [ColumnDbType("varchar", 4, true, "")] 
        public string TransactionTypeCode { get; set; }

        [Column("transaction_type_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string TransactionTypeName { get; set; }

    }

    [TableName("core.cash_flow_headings")]
    [PrimaryKey("cash_flow_heading_id", autoIncrement=false)]
    [ExplicitColumns]
    public class CashFlowHeading : PetaPocoDB.Record<CashFlowHeading> , IPoco
    {
        [Column("cash_flow_heading_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int CashFlowHeadingId { get; set; }

        [Column("cash_flow_heading_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string CashFlowHeadingCode { get; set; }

        [Column("cash_flow_heading_name")] 
        [ColumnDbType("varchar", 100, false, "")] 
        public string CashFlowHeadingName { get; set; }

        [Column("cash_flow_heading_type")] 
        [ColumnDbType("bpchar", 1, false, "")] 
        public string CashFlowHeadingType { get; set; }

        [Column("is_debit")] 
        [ColumnDbType("bool", 0, false, "false")] 
        public bool IsDebit { get; set; }

        [Column("is_sales")] 
        [ColumnDbType("bool", 0, false, "false")] 
        public bool IsSales { get; set; }

        [Column("is_purchase")] 
        [ColumnDbType("bool", 0, false, "false")] 
        public bool IsPurchase { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.account_masters")]
    [PrimaryKey("account_master_id", autoIncrement=false)]
    [ExplicitColumns]
    public class AccountMaster : PetaPocoDB.Record<AccountMaster> , IPoco
    {
        [Column("account_master_id")] 
        [ColumnDbType("int2", 0, false, "")] 
        public short AccountMasterId { get; set; }

        [Column("account_master_code")] 
        [ColumnDbType("varchar", 3, false, "")] 
        public string AccountMasterCode { get; set; }

        [Column("account_master_name")] 
        [ColumnDbType("varchar", 40, false, "")] 
        public string AccountMasterName { get; set; }

        [Column("normally_debit")] 
        [ColumnDbType("bool", 0, false, "false")] 
        public bool NormallyDebit { get; set; }

        [Column("parent_account_master_id")] 
        [ColumnDbType("int2", 0, true, "")] 
        public short? ParentAccountMasterId { get; set; }

    }

    [TableName("core.cash_flow_setup")]
    [PrimaryKey("cash_flow_setup_id", autoIncrement=true)]
    [ExplicitColumns]
    public class CashFlowSetup : PetaPocoDB.Record<CashFlowSetup> , IPoco
    {
        [Column("cash_flow_setup_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.cash_flow_setup_cash_flow_setup_id_seq'::regclass)")] 
        public int CashFlowSetupId { get; set; }

        [Column("cash_flow_heading_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int CashFlowHeadingId { get; set; }

        [Column("account_master_id")] 
        [ColumnDbType("int2", 0, false, "")] 
        public short AccountMasterId { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.sales_teams")]
    [PrimaryKey("sales_team_id", autoIncrement=true)]
    [ExplicitColumns]
    public class SalesTeam : PetaPocoDB.Record<SalesTeam> , IPoco
    {
        [Column("sales_team_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.sales_teams_sales_team_id_seq'::regclass)")] 
        public int SalesTeamId { get; set; }

        [Column("sales_team_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string SalesTeamCode { get; set; }

        [Column("sales_team_name")] 
        [ColumnDbType("varchar", 50, false, "")] 
        public string SalesTeamName { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.bonus_slab_details")]
    [PrimaryKey("bonus_slab_detail_id", autoIncrement=true)]
    [ExplicitColumns]
    public class BonusSlabDetail : PetaPocoDB.Record<BonusSlabDetail> , IPoco
    {
        [Column("bonus_slab_detail_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.bonus_slab_details_bonus_slab_detail_id_seq'::regclass)")] 
        public int BonusSlabDetailId { get; set; }

        [Column("bonus_slab_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int BonusSlabId { get; set; }

        [Column("amount_from")] 
        [ColumnDbType("money_strict", 0, false, "")] 
        public decimal AmountFrom { get; set; }

        [Column("amount_to")] 
        [ColumnDbType("money_strict", 0, false, "")] 
        public decimal AmountTo { get; set; }

        [Column("bonus_rate")] 
        [ColumnDbType("decimal_strict", 0, false, "")] 
        public decimal BonusRate { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.salesperson_bonus_setups")]
    [PrimaryKey("salesperson_bonus_setup_id", autoIncrement=true)]
    [ExplicitColumns]
    public class SalespersonBonusSetup : PetaPocoDB.Record<SalespersonBonusSetup> , IPoco
    {
        [Column("salesperson_bonus_setup_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.salesperson_bonus_setups_salesperson_bonus_setup_id_seq'::regclass)")] 
        public int SalespersonBonusSetupId { get; set; }

        [Column("salesperson_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int SalespersonId { get; set; }

        [Column("bonus_slab_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int BonusSlabId { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.income_tax_setup")]
    [PrimaryKey("income_tax_setup_id", autoIncrement=true)]
    [ExplicitColumns]
    public class IncomeTaxSetup : PetaPocoDB.Record<IncomeTaxSetup> , IPoco
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

    [TableName("core.states")]
    [PrimaryKey("state_id", autoIncrement=true)]
    [ExplicitColumns]
    public class State : PetaPocoDB.Record<State> , IPoco
    {
        [Column("state_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.states_state_id_seq'::regclass)")] 
        public int StateId { get; set; }

        [Column("country_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int CountryId { get; set; }

        [Column("state_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string StateCode { get; set; }

        [Column("state_name")] 
        [ColumnDbType("varchar", 100, false, "")] 
        public string StateName { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.counties")]
    [PrimaryKey("county_id", autoIncrement=true)]
    [ExplicitColumns]
    public class County : PetaPocoDB.Record<County> , IPoco
    {
        [Column("county_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.counties_county_id_seq'::regclass)")] 
        public int CountyId { get; set; }

        [Column("county_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string CountyCode { get; set; }

        [Column("county_name")] 
        [ColumnDbType("varchar", 100, false, "")] 
        public string CountyName { get; set; }

        [Column("state_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int StateId { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.tax_base_amount_types")]
    [PrimaryKey("tax_base_amount_type_code", autoIncrement=false)]
    [ExplicitColumns]
    public class TaxBaseAmountType : PetaPocoDB.Record<TaxBaseAmountType> , IPoco
    {
        [Column("tax_base_amount_type_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string TaxBaseAmountTypeCode { get; set; }

        [Column("tax_base_amount_type_name")] 
        [ColumnDbType("varchar", 50, false, "")] 
        public string TaxBaseAmountTypeName { get; set; }

    }

    [TableName("core.sales_tax_types")]
    [PrimaryKey("sales_tax_type_id", autoIncrement=true)]
    [ExplicitColumns]
    public class SalesTaxType : PetaPocoDB.Record<SalesTaxType> , IPoco
    {
        [Column("sales_tax_type_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.sales_tax_types_sales_tax_type_id_seq'::regclass)")] 
        public int SalesTaxTypeId { get; set; }

        [Column("sales_tax_type_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string SalesTaxTypeCode { get; set; }

        [Column("sales_tax_type_name")] 
        [ColumnDbType("varchar", 50, false, "")] 
        public string SalesTaxTypeName { get; set; }

        [Column("is_vat")] 
        [ColumnDbType("bool", 0, false, "false")] 
        public bool IsVat { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.tax_rate_types")]
    [PrimaryKey("tax_rate_type_code", autoIncrement=false)]
    [ExplicitColumns]
    public class TaxRateType : PetaPocoDB.Record<TaxRateType> , IPoco
    {
        [Column("tax_rate_type_code")] 
        [ColumnDbType("varchar", 4, false, "")] 
        public string TaxRateTypeCode { get; set; }

        [Column("tax_rate_type_name")] 
        [ColumnDbType("varchar", 50, false, "")] 
        public string TaxRateTypeName { get; set; }

    }

    [TableName("core.tax_authorities")]
    [PrimaryKey("tax_authority_id", autoIncrement=true)]
    [ExplicitColumns]
    public class TaxAuthority : PetaPocoDB.Record<TaxAuthority> , IPoco
    {
        [Column("tax_authority_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.tax_authorities_tax_authority_id_seq'::regclass)")] 
        public int TaxAuthorityId { get; set; }

        [Column("tax_master_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int TaxMasterId { get; set; }

        [Column("tax_authority_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string TaxAuthorityCode { get; set; }

        [Column("tax_authority_name")] 
        [ColumnDbType("varchar", 100, false, "")] 
        public string TaxAuthorityName { get; set; }

        [Column("country_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int CountryId { get; set; }

        [Column("state_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? StateId { get; set; }

        [Column("zip_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ZipCode { get; set; }

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

        [Column("phone")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string Phone { get; set; }

        [Column("fax")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string Fax { get; set; }

        [Column("cell")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string Cell { get; set; }

        [Column("email")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string Email { get; set; }

        [Column("url")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string Url { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.rounding_methods")]
    [PrimaryKey("rounding_method_code", autoIncrement=false)]
    [ExplicitColumns]
    public class RoundingMethod : PetaPocoDB.Record<RoundingMethod> , IPoco
    {
        [Column("rounding_method_code")] 
        [ColumnDbType("varchar", 4, false, "")] 
        public string RoundingMethodCode { get; set; }

        [Column("rounding_method_name")] 
        [ColumnDbType("varchar", 50, false, "")] 
        public string RoundingMethodName { get; set; }

    }

    [TableName("core.tax_master")]
    [PrimaryKey("tax_master_id", autoIncrement=true)]
    [ExplicitColumns]
    public class TaxMaster : PetaPocoDB.Record<TaxMaster> , IPoco
    {
        [Column("tax_master_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.tax_master_tax_master_id_seq'::regclass)")] 
        public int TaxMasterId { get; set; }

        [Column("tax_master_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string TaxMasterCode { get; set; }

        [Column("tax_master_name")] 
        [ColumnDbType("varchar", 50, false, "")] 
        public string TaxMasterName { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.tax_exempt_types")]
    [PrimaryKey("tax_exempt_type_id", autoIncrement=true)]
    [ExplicitColumns]
    public class TaxExemptType : PetaPocoDB.Record<TaxExemptType> , IPoco
    {
        [Column("tax_exempt_type_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.tax_exempt_types_tax_exempt_type_id_seq'::regclass)")] 
        public int TaxExemptTypeId { get; set; }

        [Column("tax_exempt_type_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string TaxExemptTypeCode { get; set; }

        [Column("tax_exempt_type_name")] 
        [ColumnDbType("varchar", 50, false, "")] 
        public string TaxExemptTypeName { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.entities")]
    [PrimaryKey("entity_id", autoIncrement=true)]
    [ExplicitColumns]
    public class Entity : PetaPocoDB.Record<Entity> , IPoco
    {
        [Column("entity_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.entities_entity_id_seq'::regclass)")] 
        public int EntityId { get; set; }

        [Column("entity_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string EntityName { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.industries")]
    [PrimaryKey("industry_id", autoIncrement=true)]
    [ExplicitColumns]
    public class Industry : PetaPocoDB.Record<Industry> , IPoco
    {
        [Column("industry_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.industries_industry_id_seq'::regclass)")] 
        public int IndustryId { get; set; }

        [Column("industry_name")] 
        [ColumnDbType("varchar", 100, false, "")] 
        public string IndustryName { get; set; }

        [Column("parent_industry_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? ParentIndustryId { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.item_groups")]
    [PrimaryKey("item_group_id", autoIncrement=true)]
    [ExplicitColumns]
    public class ItemGroup : PetaPocoDB.Record<ItemGroup> , IPoco
    {
        [Column("item_group_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.item_groups_item_group_id_seq'::regclass)")] 
        public int ItemGroupId { get; set; }

        [Column("item_group_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string ItemGroupCode { get; set; }

        [Column("item_group_name")] 
        [ColumnDbType("varchar", 50, false, "")] 
        public string ItemGroupName { get; set; }

        [Column("exclude_from_purchase")] 
        [ColumnDbType("bool", 0, false, "false")] 
        public bool ExcludeFromPurchase { get; set; }

        [Column("exclude_from_sales")] 
        [ColumnDbType("bool", 0, false, "false")] 
        public bool ExcludeFromSales { get; set; }

        [Column("sales_tax_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int SalesTaxId { get; set; }

        [Column("sales_account_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long SalesAccountId { get; set; }

        [Column("sales_discount_account_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long SalesDiscountAccountId { get; set; }

        [Column("sales_return_account_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long SalesReturnAccountId { get; set; }

        [Column("purchase_account_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long PurchaseAccountId { get; set; }

        [Column("purchase_discount_account_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long PurchaseDiscountAccountId { get; set; }

        [Column("inventory_account_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long InventoryAccountId { get; set; }

        [Column("cost_of_goods_sold_account_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long CostOfGoodsSoldAccountId { get; set; }

        [Column("parent_item_group_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? ParentItemGroupId { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.item_types")]
    [PrimaryKey("item_type_id", autoIncrement=true)]
    [ExplicitColumns]
    public class ItemType : PetaPocoDB.Record<ItemType> , IPoco
    {
        [Column("item_type_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.item_types_item_type_id_seq'::regclass)")] 
        public int ItemTypeId { get; set; }

        [Column("item_type_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string ItemTypeCode { get; set; }

        [Column("item_type_name")] 
        [ColumnDbType("varchar", 50, false, "")] 
        public string ItemTypeName { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.brands")]
    [PrimaryKey("brand_id", autoIncrement=true)]
    [ExplicitColumns]
    public class Brand : PetaPocoDB.Record<Brand> , IPoco
    {
        [Column("brand_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.brands_brand_id_seq'::regclass)")] 
        public int BrandId { get; set; }

        [Column("brand_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string BrandCode { get; set; }

        [Column("brand_name")] 
        [ColumnDbType("varchar", 150, false, "")] 
        public string BrandName { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.shipping_mail_types")]
    [PrimaryKey("shipping_mail_type_id", autoIncrement=true)]
    [ExplicitColumns]
    public class ShippingMailType : PetaPocoDB.Record<ShippingMailType> , IPoco
    {
        [Column("shipping_mail_type_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.shipping_mail_types_shipping_mail_type_id_seq'::regclass)")] 
        public int ShippingMailTypeId { get; set; }

        [Column("shipping_mail_type_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string ShippingMailTypeCode { get; set; }

        [Column("shipping_mail_type_name")] 
        [ColumnDbType("varchar", 64, false, "")] 
        public string ShippingMailTypeName { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.shipping_package_shapes")]
    [PrimaryKey("shipping_package_shape_id", autoIncrement=true)]
    [ExplicitColumns]
    public class ShippingPackageShape : PetaPocoDB.Record<ShippingPackageShape> , IPoco
    {
        [Column("shipping_package_shape_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.shipping_package_shapes_shipping_package_shape_id_seq'::regclass)")] 
        public int ShippingPackageShapeId { get; set; }

        [Column("shipping_package_shape_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string ShippingPackageShapeCode { get; set; }

        [Column("shipping_package_shape_name")] 
        [ColumnDbType("varchar", 64, false, "")] 
        public string ShippingPackageShapeName { get; set; }

        [Column("is_rectangular")] 
        [ColumnDbType("bool", 0, false, "false")] 
        public bool IsRectangular { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.sales_tax_exempt_details")]
    [PrimaryKey("sales_tax_exempt_detail_id", autoIncrement=true)]
    [ExplicitColumns]
    public class SalesTaxExemptDetail : PetaPocoDB.Record<SalesTaxExemptDetail> , IPoco
    {
        [Column("sales_tax_exempt_detail_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.sales_tax_exempt_details_sales_tax_exempt_detail_id_seq'::regclass)")] 
        public int SalesTaxExemptDetailId { get; set; }

        [Column("sales_tax_exempt_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int SalesTaxExemptId { get; set; }

        [Column("entity_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? EntityId { get; set; }

        [Column("industry_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? IndustryId { get; set; }

        [Column("party_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? PartyId { get; set; }

        [Column("party_type_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? PartyTypeId { get; set; }

        [Column("item_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? ItemId { get; set; }

        [Column("item_group_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? ItemGroupId { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.compound_items")]
    [PrimaryKey("compound_item_id", autoIncrement=true)]
    [ExplicitColumns]
    public class CompoundItem : PetaPocoDB.Record<CompoundItem> , IPoco
    {
        [Column("compound_item_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.compound_items_compound_item_id_seq'::regclass)")] 
        public int CompoundItemId { get; set; }

        [Column("compound_item_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string CompoundItemCode { get; set; }

        [Column("compound_item_name")] 
        [ColumnDbType("varchar", 150, false, "")] 
        public string CompoundItemName { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.party_types")]
    [PrimaryKey("party_type_id", autoIncrement=true)]
    [ExplicitColumns]
    public class PartyType : PetaPocoDB.Record<PartyType> , IPoco
    {
        [Column("party_type_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.party_types_party_type_id_seq'::regclass)")] 
        public int PartyTypeId { get; set; }

        [Column("party_type_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string PartyTypeCode { get; set; }

        [Column("party_type_name")] 
        [ColumnDbType("varchar", 50, false, "")] 
        public string PartyTypeName { get; set; }

        [Column("is_supplier")] 
        [ColumnDbType("bool", 0, false, "false")] 
        public bool IsSupplier { get; set; }

        [Column("account_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long AccountId { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.sales_tax_exempts")]
    [PrimaryKey("sales_tax_exempt_id", autoIncrement=true)]
    [ExplicitColumns]
    public class SalesTaxExempt : PetaPocoDB.Record<SalesTaxExempt> , IPoco
    {
        [Column("sales_tax_exempt_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.sales_tax_exempts_sales_tax_exempt_id_seq'::regclass)")] 
        public int SalesTaxExemptId { get; set; }

        [Column("tax_master_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int TaxMasterId { get; set; }

        [Column("sales_tax_exempt_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string SalesTaxExemptCode { get; set; }

        [Column("sales_tax_exempt_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string SalesTaxExemptName { get; set; }

        [Column("tax_exempt_type_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int TaxExemptTypeId { get; set; }

        [Column("store_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int StoreId { get; set; }

        [Column("sales_tax_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int SalesTaxId { get; set; }

        [Column("valid_from")] 
        [ColumnDbType("date", 0, false, "")] 
        public DateTime ValidFrom { get; set; }

        [Column("valid_till")] 
        [ColumnDbType("date", 0, false, "")] 
        public DateTime ValidTill { get; set; }

        [Column("price_from")] 
        [ColumnDbType("money_strict2", 0, false, "0")] 
        public decimal PriceFrom { get; set; }

        [Column("price_to")] 
        [ColumnDbType("money_strict2", 0, false, "0")] 
        public decimal PriceTo { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.price_types")]
    [PrimaryKey("price_type_id", autoIncrement=true)]
    [ExplicitColumns]
    public class PriceType : PetaPocoDB.Record<PriceType> , IPoco
    {
        [Column("price_type_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.price_types_price_type_id_seq'::regclass)")] 
        public int PriceTypeId { get; set; }

        [Column("price_type_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string PriceTypeCode { get; set; }

        [Column("price_type_name")] 
        [ColumnDbType("varchar", 50, false, "")] 
        public string PriceTypeName { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.salespersons")]
    [PrimaryKey("salesperson_id", autoIncrement=true)]
    [ExplicitColumns]
    public class Salesperson : PetaPocoDB.Record<Salesperson> , IPoco
    {
        [Column("salesperson_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.salespersons_salesperson_id_seq'::regclass)")] 
        public int SalespersonId { get; set; }

        [Column("sales_team_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int SalesTeamId { get; set; }

        [Column("salesperson_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string SalespersonCode { get; set; }

        [Column("salesperson_name")] 
        [ColumnDbType("varchar", 100, false, "")] 
        public string SalespersonName { get; set; }

        [Column("address")] 
        [ColumnDbType("varchar", 100, false, "")] 
        public string Address { get; set; }

        [Column("contact_number")] 
        [ColumnDbType("varchar", 50, false, "")] 
        public string ContactNumber { get; set; }

        [Column("commission_rate")] 
        [ColumnDbType("decimal_strict2", 0, false, "0")] 
        public decimal CommissionRate { get; set; }

        [Column("account_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long AccountId { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.sales_taxes")]
    [PrimaryKey("sales_tax_id", autoIncrement=true)]
    [ExplicitColumns]
    public class SalesTax : PetaPocoDB.Record<SalesTax> , IPoco
    {
        [Column("sales_tax_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.sales_taxes_sales_tax_id_seq'::regclass)")] 
        public int SalesTaxId { get; set; }

        [Column("tax_master_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int TaxMasterId { get; set; }

        [Column("office_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int OfficeId { get; set; }

        [Column("sales_tax_code")] 
        [ColumnDbType("varchar", 24, false, "")] 
        public string SalesTaxCode { get; set; }

        [Column("sales_tax_name")] 
        [ColumnDbType("varchar", 50, false, "")] 
        public string SalesTaxName { get; set; }

        [Column("is_exemption")] 
        [ColumnDbType("bool", 0, false, "false")] 
        public bool IsExemption { get; set; }

        [Column("tax_base_amount_type_code")] 
        [ColumnDbType("varchar", 12, false, "P")] 
        public string TaxBaseAmountTypeCode { get; set; }

        [Column("rate")] 
        [ColumnDbType("decimal_strict2", 0, false, "0")] 
        public decimal Rate { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.sales_tax_details")]
    [PrimaryKey("sales_tax_detail_id", autoIncrement=true)]
    [ExplicitColumns]
    public class SalesTaxDetail : PetaPocoDB.Record<SalesTaxDetail> , IPoco
    {
        [Column("sales_tax_detail_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.sales_tax_details_sales_tax_detail_id_seq'::regclass)")] 
        public int SalesTaxDetailId { get; set; }

        [Column("sales_tax_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int SalesTaxId { get; set; }

        [Column("sales_tax_type_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int SalesTaxTypeId { get; set; }

        [Column("priority")] 
        [ColumnDbType("int2", 0, false, "0")] 
        public short Priority { get; set; }

        [Column("sales_tax_detail_code")] 
        [ColumnDbType("varchar", 24, false, "")] 
        public string SalesTaxDetailCode { get; set; }

        [Column("sales_tax_detail_name")] 
        [ColumnDbType("varchar", 50, false, "")] 
        public string SalesTaxDetailName { get; set; }

        [Column("based_on_shipping_address")] 
        [ColumnDbType("bool", 0, false, "true")] 
        public bool BasedOnShippingAddress { get; set; }

        [Column("check_nexus")] 
        [ColumnDbType("bool", 0, false, "true")] 
        public bool CheckNexus { get; set; }

        [Column("applied_on_shipping_charge")] 
        [ColumnDbType("bool", 0, false, "true")] 
        public bool AppliedOnShippingCharge { get; set; }

        [Column("state_sales_tax_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? StateSalesTaxId { get; set; }

        [Column("county_sales_tax_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? CountySalesTaxId { get; set; }

        [Column("tax_rate_type_code")] 
        [ColumnDbType("varchar", 12, false, "P")] 
        public string TaxRateTypeCode { get; set; }

        [Column("rate")] 
        [ColumnDbType("decimal_strict2", 0, false, "")] 
        public decimal Rate { get; set; }

        [Column("reporting_tax_authority_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int ReportingTaxAuthorityId { get; set; }

        [Column("collecting_tax_authority_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int CollectingTaxAuthorityId { get; set; }

        [Column("collecting_account_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long CollectingAccountId { get; set; }

        [Column("use_tax_collecting_account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? UseTaxCollectingAccountId { get; set; }

        [Column("rounding_method_code")] 
        [ColumnDbType("varchar", 4, true, "")] 
        public string RoundingMethodCode { get; set; }

        [Column("rounding_decimal_places")] 
        [ColumnDbType("integer_strict2", 0, false, "2")] 
        public int RoundingDecimalPlaces { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.state_sales_taxes")]
    [PrimaryKey("state_sales_tax_id", autoIncrement=true)]
    [ExplicitColumns]
    public class StateSalesTax : PetaPocoDB.Record<StateSalesTax> , IPoco
    {
        [Column("state_sales_tax_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.state_sales_taxes_state_sales_tax_id_seq'::regclass)")] 
        public int StateSalesTaxId { get; set; }

        [Column("state_sales_tax_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string StateSalesTaxCode { get; set; }

        [Column("state_sales_tax_name")] 
        [ColumnDbType("varchar", 100, false, "")] 
        public string StateSalesTaxName { get; set; }

        [Column("state_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int StateId { get; set; }

        [Column("entity_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? EntityId { get; set; }

        [Column("industry_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? IndustryId { get; set; }

        [Column("item_group_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? ItemGroupId { get; set; }

        [Column("rate")] 
        [ColumnDbType("decimal_strict2", 0, false, "0")] 
        public decimal Rate { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.county_sales_taxes")]
    [PrimaryKey("county_sales_tax_id", autoIncrement=true)]
    [ExplicitColumns]
    public class CountySalesTax : PetaPocoDB.Record<CountySalesTax> , IPoco
    {
        [Column("county_sales_tax_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.county_sales_taxes_county_sales_tax_id_seq'::regclass)")] 
        public int CountySalesTaxId { get; set; }

        [Column("county_sales_tax_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string CountySalesTaxCode { get; set; }

        [Column("county_sales_tax_name")] 
        [ColumnDbType("varchar", 100, false, "")] 
        public string CountySalesTaxName { get; set; }

        [Column("county_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? CountyId { get; set; }

        [Column("entity_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? EntityId { get; set; }

        [Column("industry_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? IndustryId { get; set; }

        [Column("item_group_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? ItemGroupId { get; set; }

        [Column("rate")] 
        [ColumnDbType("decimal_strict2", 0, false, "0")] 
        public decimal Rate { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.config")]
    [PrimaryKey("config_id", autoIncrement=false)]
    [ExplicitColumns]
    public class Config : PetaPocoDB.Record<Config> , IPoco
    {
        [Column("config_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int ConfigId { get; set; }

        [Column("config_name")] 
        [ColumnDbType("varchar", 50, false, "")] 
        public string ConfigName { get; set; }

    }

    [TableName("core.shippers")]
    [PrimaryKey("shipper_id", autoIncrement=true)]
    [ExplicitColumns]
    public class Shipper : PetaPocoDB.Record<Shipper> , IPoco
    {
        [Column("shipper_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.shippers_shipper_id_seq'::regclass)")] 
        public int ShipperId { get; set; }

        [Column("shipper_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ShipperCode { get; set; }

        [Column("company_name")] 
        [ColumnDbType("varchar", 128, false, "")] 
        public string CompanyName { get; set; }

        [Column("shipper_name")] 
        [ColumnDbType("varchar", 150, true, "")] 
        public string ShipperName { get; set; }

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

        [Column("country")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string Country { get; set; }

        [Column("phone")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string Phone { get; set; }

        [Column("fax")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string Fax { get; set; }

        [Column("cell")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string Cell { get; set; }

        [Column("email")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string Email { get; set; }

        [Column("url")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string Url { get; set; }

        [Column("contact_person")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string ContactPerson { get; set; }

        [Column("contact_po_box")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string ContactPoBox { get; set; }

        [Column("contact_address_line_1")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string ContactAddressLine1 { get; set; }

        [Column("contact_address_line_2")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string ContactAddressLine2 { get; set; }

        [Column("contact_street")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string ContactStreet { get; set; }

        [Column("contact_city")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string ContactCity { get; set; }

        [Column("contact_state")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string ContactState { get; set; }

        [Column("contact_country")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string ContactCountry { get; set; }

        [Column("contact_email")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string ContactEmail { get; set; }

        [Column("contact_phone")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string ContactPhone { get; set; }

        [Column("contact_cell")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string ContactCell { get; set; }

        [Column("factory_address")] 
        [ColumnDbType("varchar", 250, true, "")] 
        public string FactoryAddress { get; set; }

        [Column("pan_number")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string PanNumber { get; set; }

        [Column("sst_number")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string SstNumber { get; set; }

        [Column("cst_number")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string CstNumber { get; set; }

        [Column("account_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long AccountId { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.shipping_addresses")]
    [PrimaryKey("shipping_address_id", autoIncrement=true)]
    [ExplicitColumns]
    public class ShippingAddress : PetaPocoDB.Record<ShippingAddress> , IPoco
    {
        [Column("shipping_address_id")] 
        [ColumnDbType("int8", 0, false, "nextval('core.shipping_addresses_shipping_address_id_seq'::regclass)")] 
        public long ShippingAddressId { get; set; }

        [Column("shipping_address_code")] 
        [ColumnDbType("varchar", 24, false, "")] 
        public string ShippingAddressCode { get; set; }

        [Column("party_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long PartyId { get; set; }

        [Column("country_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int CountryId { get; set; }

        [Column("state_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int StateId { get; set; }

        [Column("zip_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ZipCode { get; set; }

        [Column("address_line_1")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string AddressLine1 { get; set; }

        [Column("address_line_2")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string AddressLine2 { get; set; }

        [Column("street")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string Street { get; set; }

        [Column("city")] 
        [ColumnDbType("varchar", 128, false, "")] 
        public string City { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.item_cost_prices")]
    [PrimaryKey("item_cost_price_id", autoIncrement=true)]
    [ExplicitColumns]
    public class ItemCostPrice : PetaPocoDB.Record<ItemCostPrice> , IPoco
    {
        [Column("item_cost_price_id")] 
        [ColumnDbType("int8", 0, false, "nextval('core.item_cost_prices_item_cost_price_id_seq'::regclass)")] 
        public long ItemCostPriceId { get; set; }

        [Column("item_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int ItemId { get; set; }

        [Column("entry_ts")] 
        [ColumnDbType("timestamptz", 0, false, "")] 
        public DateTime EntryTs { get; set; }

        [Column("unit_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int UnitId { get; set; }

        [Column("party_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? PartyId { get; set; }

        [Column("lead_time_in_days")] 
        [ColumnDbType("int4", 0, false, "0")] 
        public int LeadTimeInDays { get; set; }

        [Column("price")] 
        [ColumnDbType("money_strict", 0, false, "")] 
        public decimal Price { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.item_selling_prices")]
    [PrimaryKey("item_selling_price_id", autoIncrement=true)]
    [ExplicitColumns]
    public class ItemSellingPrice : PetaPocoDB.Record<ItemSellingPrice> , IPoco
    {
        [Column("item_selling_price_id")] 
        [ColumnDbType("int8", 0, false, "nextval('core.item_selling_prices_item_selling_price_id_seq'::regclass)")] 
        public long ItemSellingPriceId { get; set; }

        [Column("item_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int ItemId { get; set; }

        [Column("unit_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int UnitId { get; set; }

        [Column("party_type_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? PartyTypeId { get; set; }

        [Column("price_type_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? PriceTypeId { get; set; }

        [Column("includes_tax")] 
        [ColumnDbType("bool", 0, false, "false")] 
        public bool IncludesTax { get; set; }

        [Column("price")] 
        [ColumnDbType("money_strict", 0, false, "")] 
        public decimal Price { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.recurring_invoices")]
    [PrimaryKey("recurring_invoice_id", autoIncrement=true)]
    [ExplicitColumns]
    public class RecurringInvoice : PetaPocoDB.Record<RecurringInvoice> , IPoco
    {
        [Column("recurring_invoice_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.recurring_invoices_recurring_invoice_id_seq'::regclass)")] 
        public int RecurringInvoiceId { get; set; }

        [Column("recurring_invoice_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string RecurringInvoiceCode { get; set; }

        [Column("recurring_invoice_name")] 
        [ColumnDbType("varchar", 50, false, "")] 
        public string RecurringInvoiceName { get; set; }

        [Column("item_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? ItemId { get; set; }

        [Column("total_duration")] 
        [ColumnDbType("int4", 0, false, "365")] 
        public int TotalDuration { get; set; }

        [Column("recurrence_type_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int RecurrenceTypeId { get; set; }

        [Column("recurring_frequency_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? RecurringFrequencyId { get; set; }

        [Column("recurring_duration")] 
        [ColumnDbType("integer_strict2", 0, false, "30")] 
        public int RecurringDuration { get; set; }

        [Column("recurs_on_same_calendar_date")] 
        [ColumnDbType("bool", 0, false, "true")] 
        public bool RecursOnSameCalendarDate { get; set; }

        [Column("recurring_amount")] 
        [ColumnDbType("money_strict", 0, false, "")] 
        public decimal RecurringAmount { get; set; }

        [Column("account_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long AccountId { get; set; }

        [Column("payment_term_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int PaymentTermId { get; set; }

        [Column("auto_trigger_on_sales")] 
        [ColumnDbType("bool", 0, false, "")] 
        public bool AutoTriggerOnSales { get; set; }

        [Column("is_active")] 
        [ColumnDbType("bool", 0, false, "true")] 
        public bool IsActive { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("varchar", 100, false, "")] 
        public string StatementReference { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.recurrence_types")]
    [PrimaryKey("recurrence_type_id", autoIncrement=true)]
    [ExplicitColumns]
    public class RecurrenceType : PetaPocoDB.Record<RecurrenceType> , IPoco
    {
        [Column("recurrence_type_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.recurrence_types_recurrence_type_id_seq'::regclass)")] 
        public int RecurrenceTypeId { get; set; }

        [Column("recurrence_type_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string RecurrenceTypeCode { get; set; }

        [Column("recurrence_type_name")] 
        [ColumnDbType("varchar", 50, false, "")] 
        public string RecurrenceTypeName { get; set; }

        [Column("is_frequency")] 
        [ColumnDbType("bool", 0, false, "")] 
        public bool IsFrequency { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.frequencies")]
    [PrimaryKey("frequency_id", autoIncrement=true)]
    [ExplicitColumns]
    public class Frequency : PetaPocoDB.Record<Frequency> , IPoco
    {
        [Column("frequency_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.frequencies_frequency_id_seq'::regclass)")] 
        public int FrequencyId { get; set; }

        [Column("frequency_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string FrequencyCode { get; set; }

        [Column("frequency_name")] 
        [ColumnDbType("varchar", 50, false, "")] 
        public string FrequencyName { get; set; }

    }

    [TableName("core.recurring_invoice_setup")]
    [PrimaryKey("recurring_invoice_setup_id", autoIncrement=true)]
    [ExplicitColumns]
    public class RecurringInvoiceSetup : PetaPocoDB.Record<RecurringInvoiceSetup> , IPoco
    {
        [Column("recurring_invoice_setup_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.recurring_invoice_setup_recurring_invoice_setup_id_seq'::regclass)")] 
        public int RecurringInvoiceSetupId { get; set; }

        [Column("recurring_invoice_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int RecurringInvoiceId { get; set; }

        [Column("party_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long PartyId { get; set; }

        [Column("starts_from")] 
        [ColumnDbType("date", 0, false, "")] 
        public DateTime StartsFrom { get; set; }

        [Column("ends_on")] 
        [ColumnDbType("date", 0, false, "")] 
        public DateTime EndsOn { get; set; }

        [Column("recurrence_type_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int RecurrenceTypeId { get; set; }

        [Column("recurring_frequency_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? RecurringFrequencyId { get; set; }

        [Column("recurring_duration")] 
        [ColumnDbType("integer_strict2", 0, false, "0")] 
        public int RecurringDuration { get; set; }

        [Column("recurs_on_same_calendar_date")] 
        [ColumnDbType("bool", 0, false, "true")] 
        public bool RecursOnSameCalendarDate { get; set; }

        [Column("recurring_amount")] 
        [ColumnDbType("money_strict", 0, false, "")] 
        public decimal RecurringAmount { get; set; }

        [Column("account_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long AccountId { get; set; }

        [Column("payment_term_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int PaymentTermId { get; set; }

        [Column("is_active")] 
        [ColumnDbType("bool", 0, false, "true")] 
        public bool IsActive { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("varchar", 100, false, "")] 
        public string StatementReference { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.bonus_slabs")]
    [PrimaryKey("bonus_slab_id", autoIncrement=true)]
    [ExplicitColumns]
    public class BonusSlab : PetaPocoDB.Record<BonusSlab> , IPoco
    {
        [Column("bonus_slab_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.bonus_slabs_bonus_slab_id_seq'::regclass)")] 
        public int BonusSlabId { get; set; }

        [Column("bonus_slab_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string BonusSlabCode { get; set; }

        [Column("bonus_slab_name")] 
        [ColumnDbType("varchar", 50, false, "")] 
        public string BonusSlabName { get; set; }

        [Column("effective_from")] 
        [ColumnDbType("date", 0, false, "")] 
        public DateTime EffectiveFrom { get; set; }

        [Column("ends_on")] 
        [ColumnDbType("date", 0, false, "")] 
        public DateTime EndsOn { get; set; }

        [Column("checking_frequency_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int CheckingFrequencyId { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

        [Column("account_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long AccountId { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("varchar", 100, false, "")] 
        public string StatementReference { get; set; }

    }

    [TableName("core.payment_terms")]
    [PrimaryKey("payment_term_id", autoIncrement=true)]
    [ExplicitColumns]
    public class PaymentTerm : PetaPocoDB.Record<PaymentTerm> , IPoco
    {
        [Column("payment_term_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.payment_terms_payment_term_id_seq'::regclass)")] 
        public int PaymentTermId { get; set; }

        [Column("payment_term_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string PaymentTermCode { get; set; }

        [Column("payment_term_name")] 
        [ColumnDbType("varchar", 50, false, "")] 
        public string PaymentTermName { get; set; }

        [Column("due_on_date")] 
        [ColumnDbType("bool", 0, false, "false")] 
        public bool DueOnDate { get; set; }

        [Column("due_days")] 
        [ColumnDbType("int4", 0, false, "0")] 
        public int DueDays { get; set; }

        [Column("due_frequency_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? DueFrequencyId { get; set; }

        [Column("grace_period")] 
        [ColumnDbType("int4", 0, false, "0")] 
        public int GracePeriod { get; set; }

        [Column("late_fee_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? LateFeeId { get; set; }

        [Column("late_fee_posting_frequency_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? LateFeePostingFrequencyId { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.late_fee")]
    [ExplicitColumns]
    public class LateFee : PetaPocoDB.Record<LateFee> , IPoco
    {
        [Column("late_fee_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.late_fee_late_fee_id_seq'::regclass)")] 
        public int LateFeeId { get; set; }

        [Column("late_fee_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string LateFeeCode { get; set; }

        [Column("late_fee_name")] 
        [ColumnDbType("varchar", 50, false, "")] 
        public string LateFeeName { get; set; }

        [Column("is_flat_amount")] 
        [ColumnDbType("bool", 0, false, "false")] 
        public bool IsFlatAmount { get; set; }

        [Column("rate")] 
        [ColumnDbType("numeric", 1572868, false, "")] 
        public decimal Rate { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

        [Column("account_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long AccountId { get; set; }

    }

    [TableName("core.card_types")]
    [PrimaryKey("card_type_id", autoIncrement=false)]
    [ExplicitColumns]
    public class CardType : PetaPocoDB.Record<CardType> , IPoco
    {
        [Column("card_type_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int CardTypeId { get; set; }

        [Column("card_type_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string CardTypeCode { get; set; }

        [Column("card_type_name")] 
        [ColumnDbType("varchar", 100, false, "")] 
        public string CardTypeName { get; set; }

    }

    [TableName("core.payment_cards")]
    [PrimaryKey("payment_card_id", autoIncrement=true)]
    [ExplicitColumns]
    public class PaymentCard : PetaPocoDB.Record<PaymentCard> , IPoco
    {
        [Column("payment_card_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.payment_cards_payment_card_id_seq'::regclass)")] 
        public int PaymentCardId { get; set; }

        [Column("payment_card_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string PaymentCardCode { get; set; }

        [Column("payment_card_name")] 
        [ColumnDbType("varchar", 100, false, "")] 
        public string PaymentCardName { get; set; }

        [Column("card_type_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int CardTypeId { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.merchant_fee_setup")]
    [PrimaryKey("merchant_fee_setup_id", autoIncrement=true)]
    [ExplicitColumns]
    public class MerchantFeeSetup : PetaPocoDB.Record<MerchantFeeSetup> , IPoco
    {
        [Column("merchant_fee_setup_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.merchant_fee_setup_merchant_fee_setup_id_seq'::regclass)")] 
        public int MerchantFeeSetupId { get; set; }

        [Column("merchant_account_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long MerchantAccountId { get; set; }

        [Column("payment_card_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int PaymentCardId { get; set; }

        [Column("rate")] 
        [ColumnDbType("decimal_strict", 0, false, "")] 
        public decimal Rate { get; set; }

        [Column("customer_pays_fee")] 
        [ColumnDbType("bool", 0, false, "false")] 
        public bool CustomerPaysFee { get; set; }

        [Column("account_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long AccountId { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("varchar", 128, false, "")] 
        public string StatementReference { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.ageing_slabs")]
    [PrimaryKey("ageing_slab_id", autoIncrement=true)]
    [ExplicitColumns]
    public class AgeingSlab : PetaPocoDB.Record<AgeingSlab> , IPoco
    {
        [Column("ageing_slab_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.ageing_slabs_ageing_slab_id_seq'::regclass)")] 
        public int AgeingSlabId { get; set; }

        [Column("ageing_slab_name")] 
        [ColumnDbType("varchar", 24, false, "")] 
        public string AgeingSlabName { get; set; }

        [Column("from_days")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int FromDays { get; set; }

        [Column("to_days")] 
        [ColumnDbType("integer_strict2", 0, false, "")] 
        public int ToDays { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.compound_item_details")]
    [PrimaryKey("compound_item_detail_id", autoIncrement=true)]
    [ExplicitColumns]
    public class CompoundItemDetail : PetaPocoDB.Record<CompoundItemDetail> , IPoco
    {
        [Column("compound_item_detail_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.compound_item_details_compound_item_detail_id_seq'::regclass)")] 
        public int CompoundItemDetailId { get; set; }

        [Column("compound_item_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int CompoundItemId { get; set; }

        [Column("item_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int ItemId { get; set; }

        [Column("unit_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int UnitId { get; set; }

        [Column("quantity")] 
        [ColumnDbType("integer_strict", 0, false, "")] 
        public int Quantity { get; set; }

        [Column("price")] 
        [ColumnDbType("money_strict", 0, false, "")] 
        public decimal Price { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

        [Column("discount")] 
        [ColumnDbType("money_strict2", 0, false, "0")] 
        public decimal Discount { get; set; }

    }

    [TableName("core.bank_accounts")]
    [PrimaryKey("account_id", autoIncrement=false)]
    [ExplicitColumns]
    public class BankAccount : PetaPocoDB.Record<BankAccount> , IPoco
    {
        [Column("account_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long AccountId { get; set; }

        [Column("maintained_by_user_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int MaintainedByUserId { get; set; }

        [Column("office_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int OfficeId { get; set; }

        [Column("bank_name")] 
        [ColumnDbType("varchar", 128, false, "")] 
        public string BankName { get; set; }

        [Column("bank_branch")] 
        [ColumnDbType("varchar", 128, false, "")] 
        public string BankBranch { get; set; }

        [Column("bank_contact_number")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string BankContactNumber { get; set; }

        [Column("bank_address")] 
        [ColumnDbType("text", 0, true, "")] 
        public string BankAddress { get; set; }

        [Column("bank_account_number")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string BankAccountNumber { get; set; }

        [Column("bank_account_type")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string BankAccountType { get; set; }

        [Column("relationship_officer_name")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string RelationshipOfficerName { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

        [Column("is_merchant_account")] 
        [ColumnDbType("bool", 0, false, "false")] 
        public bool IsMerchantAccount { get; set; }

    }

    [TableName("core.verification_statuses")]
    [PrimaryKey("verification_status_id", autoIncrement=false)]
    [ExplicitColumns]
    public class VerificationStatus : PetaPocoDB.Record<VerificationStatus> , IPoco
    {
        [Column("verification_status_id")] 
        [ColumnDbType("int2", 0, false, "")] 
        public short VerificationStatusId { get; set; }

        [Column("verification_status_name")] 
        [ColumnDbType("varchar", 128, false, "")] 
        public string VerificationStatusName { get; set; }

    }

    [TableName("core.units")]
    [PrimaryKey("unit_id", autoIncrement=true)]
    [ExplicitColumns]
    public class Unit : PetaPocoDB.Record<Unit> , IPoco
    {
        [Column("unit_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.units_unit_id_seq'::regclass)")] 
        public int UnitId { get; set; }

        [Column("unit_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string UnitCode { get; set; }

        [Column("unit_name")] 
        [ColumnDbType("varchar", 50, false, "")] 
        public string UnitName { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.custom_field_forms")]
    [PrimaryKey("form_name", autoIncrement=false)]
    [ExplicitColumns]
    public class CustomFieldForm : PetaPocoDB.Record<CustomFieldForm> , IPoco
    {
        [Column("form_name")] 
        [ColumnDbType("varchar", 100, false, "")] 
        public string FormName { get; set; }

        [Column("table_name")] 
        [ColumnDbType("varchar", 100, false, "")] 
        public string TableName { get; set; }

        [Column("key_name")] 
        [ColumnDbType("varchar", 100, false, "")] 
        public string KeyName { get; set; }

    }

    [TableName("core.custom_field_data_types")]
    [PrimaryKey("data_type", autoIncrement=false)]
    [ExplicitColumns]
    public class CustomFieldDataType : PetaPocoDB.Record<CustomFieldDataType> , IPoco
    {
        [Column("data_type")] 
        [ColumnDbType("varchar", 50, false, "")] 
        public string DataType { get; set; }

        [Column("is_number")] 
        [ColumnDbType("bool", 0, true, "false")] 
        public bool? IsNumber { get; set; }

        [Column("is_date")] 
        [ColumnDbType("bool", 0, true, "false")] 
        public bool? IsDate { get; set; }

        [Column("is_boolean")] 
        [ColumnDbType("bool", 0, true, "false")] 
        public bool? IsBoolean { get; set; }

        [Column("is_long_text")] 
        [ColumnDbType("bool", 0, true, "false")] 
        public bool? IsLongText { get; set; }

    }

    [TableName("core.custom_field_setup")]
    [PrimaryKey("custom_field_setup_id", autoIncrement=true)]
    [ExplicitColumns]
    public class CustomFieldSetup : PetaPocoDB.Record<CustomFieldSetup> , IPoco
    {
        [Column("custom_field_setup_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.custom_field_setup_custom_field_setup_id_seq'::regclass)")] 
        public int CustomFieldSetupId { get; set; }

        [Column("form_name")] 
        [ColumnDbType("varchar", 100, false, "")] 
        public string FormName { get; set; }

        [Column("field_order")] 
        [ColumnDbType("int4", 0, false, "0")] 
        public int FieldOrder { get; set; }

        [Column("field_name")] 
        [ColumnDbType("varchar", 100, false, "")] 
        public string FieldName { get; set; }

        [Column("field_label")] 
        [ColumnDbType("varchar", 100, false, "")] 
        public string FieldLabel { get; set; }

        [Column("data_type")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string DataType { get; set; }

        [Column("description")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Description { get; set; }

    }

    [TableName("core.custom_fields")]
    [PrimaryKey("custom_field_id", autoIncrement=true)]
    [ExplicitColumns]
    public class CustomField : PetaPocoDB.Record<CustomField> , IPoco
    {
        [Column("custom_field_id")] 
        [ColumnDbType("int8", 0, false, "nextval('core.custom_fields_custom_field_id_seq'::regclass)")] 
        public long CustomFieldId { get; set; }

        [Column("custom_field_setup_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int CustomFieldSetupId { get; set; }

        [Column("resource_id")] 
        [ColumnDbType("text", 0, false, "")] 
        public string ResourceId { get; set; }

        [Column("value")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Value { get; set; }

    }

    [TableName("core.widget_groups")]
    [PrimaryKey("widget_group_name", autoIncrement=false)]
    [ExplicitColumns]
    public class WidgetGroup : PetaPocoDB.Record<WidgetGroup> , IPoco
    {
        [Column("widget_group_name")] 
        [ColumnDbType("varchar", 100, false, "")] 
        public string WidgetGroupName { get; set; }

        [Column("is_default")] 
        [ColumnDbType("bool", 0, false, "false")] 
        public bool IsDefault { get; set; }

    }

    [TableName("core.widgets")]
    [PrimaryKey("widget_name", autoIncrement=false)]
    [ExplicitColumns]
    public class Widget : PetaPocoDB.Record<Widget> , IPoco
    {
        [Column("widget_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.widgets_widget_id_seq'::regclass)")] 
        public int WidgetId { get; set; }

        [Column("widget_name")] 
        [ColumnDbType("text", 0, false, "")] 
        public string WidgetName { get; set; }

        [Column("widget_source")] 
        [ColumnDbType("text", 0, false, "")] 
        public string WidgetSource { get; set; }

    }

    [TableName("core.widget_setup")]
    [PrimaryKey("widget_setup_id", autoIncrement=true)]
    [ExplicitColumns]
    public class WidgetSetup : PetaPocoDB.Record<WidgetSetup> , IPoco
    {
        [Column("widget_setup_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.widget_setup_widget_setup_id_seq'::regclass)")] 
        public int WidgetSetupId { get; set; }

        [Column("widget_order")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int WidgetOrder { get; set; }

        [Column("widget_group_name")] 
        [ColumnDbType("varchar", 100, false, "")] 
        public string WidgetGroupName { get; set; }

        [Column("widget_name")] 
        [ColumnDbType("varchar", 100, false, "")] 
        public string WidgetName { get; set; }

    }

    [TableName("core.email_queue")]
    [PrimaryKey("queue_id", autoIncrement=true)]
    [ExplicitColumns]
    public class EmailQueue : PetaPocoDB.Record<EmailQueue> , IPoco
    {
        [Column("queue_id")] 
        [ColumnDbType("int8", 0, false, "nextval('core.email_queue_queue_id_seq'::regclass)")] 
        public long QueueId { get; set; }

        [Column("subject")] 
        [ColumnDbType("varchar", 256, false, "")] 
        public string Subject { get; set; }

        [Column("send_to")] 
        [ColumnDbType("varchar", 256, false, "")] 
        public string SendTo { get; set; }

        [Column("attachments")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Attachments { get; set; }

        [Column("message")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Message { get; set; }

        [Column("added_on")] 
        [ColumnDbType("timestamptz", 0, false, "")] 
        public DateTime AddedOn { get; set; }

        [Column("delivered")] 
        [ColumnDbType("bool", 0, false, "false")] 
        public bool Delivered { get; set; }

        [Column("delivered_on")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? DeliveredOn { get; set; }

        [Column("transaction_master_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? TransactionMasterId { get; set; }

        [Column("canceled")] 
        [ColumnDbType("bool", 0, false, "false")] 
        public bool Canceled { get; set; }

    }

    [TableName("core.items")]
    [PrimaryKey("item_id", autoIncrement=true)]
    [ExplicitColumns]
    public class Item : PetaPocoDB.Record<Item> , IPoco
    {
        [Column("item_id")] 
        [ColumnDbType("int4", 0, false, "nextval('core.items_item_id_seq'::regclass)")] 
        public int ItemId { get; set; }

        [Column("item_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string ItemCode { get; set; }

        [Column("item_name")] 
        [ColumnDbType("varchar", 150, false, "")] 
        public string ItemName { get; set; }

        [Column("item_group_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int ItemGroupId { get; set; }

        [Column("item_type_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int ItemTypeId { get; set; }

        [Column("brand_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int BrandId { get; set; }

        [Column("preferred_supplier_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long PreferredSupplierId { get; set; }

        [Column("lead_time_in_days")] 
        [ColumnDbType("int4", 0, false, "0")] 
        public int LeadTimeInDays { get; set; }

        [Column("weight_in_grams")] 
        [ColumnDbType("float8", 0, false, "0")] 
        public double WeightInGrams { get; set; }

        [Column("width_in_centimeters")] 
        [ColumnDbType("float8", 0, false, "0")] 
        public double WidthInCentimeters { get; set; }

        [Column("height_in_centimeters")] 
        [ColumnDbType("float8", 0, false, "0")] 
        public double HeightInCentimeters { get; set; }

        [Column("length_in_centimeters")] 
        [ColumnDbType("float8", 0, false, "0")] 
        public double LengthInCentimeters { get; set; }

        [Column("machinable")] 
        [ColumnDbType("bool", 0, false, "false")] 
        public bool Machinable { get; set; }

        [Column("preferred_shipping_mail_type_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? PreferredShippingMailTypeId { get; set; }

        [Column("shipping_package_shape_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? ShippingPackageShapeId { get; set; }

        [Column("unit_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int UnitId { get; set; }

        [Column("hot_item")] 
        [ColumnDbType("bool", 0, false, "")] 
        public bool HotItem { get; set; }

        [Column("cost_price")] 
        [ColumnDbType("money_strict2", 0, false, "")] 
        public decimal CostPrice { get; set; }

        [Column("selling_price")] 
        [ColumnDbType("money_strict", 0, false, "")] 
        public decimal SellingPrice { get; set; }

        [Column("selling_price_includes_tax")] 
        [ColumnDbType("bool", 0, false, "false")] 
        public bool SellingPriceIncludesTax { get; set; }

        [Column("sales_tax_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int SalesTaxId { get; set; }

        [Column("reorder_unit_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int ReorderUnitId { get; set; }

        [Column("reorder_level")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int ReorderLevel { get; set; }

        [Column("reorder_quantity")] 
        [ColumnDbType("int4", 0, false, "0")] 
        public int ReorderQuantity { get; set; }

        [Column("maintain_stock")] 
        [ColumnDbType("bool", 0, false, "true")] 
        public bool MaintainStock { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

        [Column("photo")] 
        [ColumnDbType("image", 0, true, "")] 
        public string Photo { get; set; }

    }

    [TableName("core.bank_accounts_scrud_view")]
    [ExplicitColumns]
    public class BankAccountsScrudView : PetaPocoDB.Record<BankAccountsScrudView> , IPoco
    {
        [Column("account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? AccountId { get; set; }

        [Column("user_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string UserName { get; set; }

        [Column("office_name")] 
        [ColumnDbType("text", 0, true, "")] 
        public string OfficeName { get; set; }

        [Column("bank_name")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string BankName { get; set; }

        [Column("bank_branch")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string BankBranch { get; set; }

        [Column("bank_contact_number")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string BankContactNumber { get; set; }

        [Column("bank_address")] 
        [ColumnDbType("text", 0, true, "")] 
        public string BankAddress { get; set; }

        [Column("bank_account_number")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string BankAccountNumber { get; set; }

        [Column("bank_account_type")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string BankAccountType { get; set; }

        [Column("relationship_officer_name")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string RelationshipOfficerName { get; set; }

    }

    [TableName("core.brand_scrud_view")]
    [ExplicitColumns]
    public class BrandScrudView : PetaPocoDB.Record<BrandScrudView> , IPoco
    {
        [Column("brand_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? BrandId { get; set; }

        [Column("brand_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string BrandCode { get; set; }

        [Column("brand_name")] 
        [ColumnDbType("varchar", 150, true, "")] 
        public string BrandName { get; set; }

    }

    [TableName("core.cash_flow_heading_scrud_view")]
    [ExplicitColumns]
    public class CashFlowHeadingScrudView : PetaPocoDB.Record<CashFlowHeadingScrudView> , IPoco
    {
        [Column("cash_flow_heading_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? CashFlowHeadingId { get; set; }

        [Column("cash_flow_heading_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string CashFlowHeadingCode { get; set; }

        [Column("cash_flow_heading_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string CashFlowHeadingName { get; set; }

        [Column("cash_flow_heading_type")] 
        [ColumnDbType("bpchar", 1, true, "")] 
        public string CashFlowHeadingType { get; set; }

        [Column("is_debit")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsDebit { get; set; }

        [Column("is_sales")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsSales { get; set; }

        [Column("is_purchase")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsPurchase { get; set; }

    }

    [TableName("core.cash_flow_setup_scrud_view")]
    [ExplicitColumns]
    public class CashFlowSetupScrudView : PetaPocoDB.Record<CashFlowSetupScrudView> , IPoco
    {
        [Column("cash_flow_setup_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? CashFlowSetupId { get; set; }

        [Column("cash_flow_heading")] 
        [ColumnDbType("text", 0, true, "")] 
        public string CashFlowHeading { get; set; }

        [Column("account_master")] 
        [ColumnDbType("text", 0, true, "")] 
        public string AccountMaster { get; set; }

    }

    [TableName("core.compound_item_detail_scrud_view")]
    [ExplicitColumns]
    public class CompoundItemDetailScrudView : PetaPocoDB.Record<CompoundItemDetailScrudView> , IPoco
    {
        [Column("compound_item_detail_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? CompoundItemDetailId { get; set; }

        [Column("compound_item_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? CompoundItemId { get; set; }

        [Column("compound_item_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string CompoundItemCode { get; set; }

        [Column("compound_item_name")] 
        [ColumnDbType("varchar", 150, true, "")] 
        public string CompoundItemName { get; set; }

        [Column("item_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? ItemId { get; set; }

        [Column("item")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Item { get; set; }

        [Column("unit")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Unit { get; set; }

        [Column("quantity")] 
        [ColumnDbType("integer_strict", 0, true, "")] 
        public int? Quantity { get; set; }

    }

    [TableName("core.compound_item_scrud_view")]
    [ExplicitColumns]
    public class CompoundItemScrudView : PetaPocoDB.Record<CompoundItemScrudView> , IPoco
    {
        [Column("compound_item_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? CompoundItemId { get; set; }

        [Column("compound_item_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string CompoundItemCode { get; set; }

        [Column("compound_item_name")] 
        [ColumnDbType("varchar", 150, true, "")] 
        public string CompoundItemName { get; set; }

    }

    [TableName("core.compound_unit_scrud_view")]
    [ExplicitColumns]
    public class CompoundUnitScrudView : PetaPocoDB.Record<CompoundUnitScrudView> , IPoco
    {
        [Column("compound_unit_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? CompoundUnitId { get; set; }

        [Column("base_unit_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string BaseUnitName { get; set; }

        [Column("value")] 
        [ColumnDbType("int2", 0, true, "")] 
        public short? Value { get; set; }

        [Column("compare_unit_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string CompareUnitName { get; set; }

    }

    [TableName("core.country_scrud_view")]
    [ExplicitColumns]
    public class CountryScrudView : PetaPocoDB.Record<CountryScrudView> , IPoco
    {
        [Column("country_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? CountryId { get; set; }

        [Column("country_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string CountryCode { get; set; }

        [Column("country_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string CountryName { get; set; }

    }

    [TableName("core.county_sales_tax_scrud_view")]
    [ExplicitColumns]
    public class CountySalesTaxScrudView : PetaPocoDB.Record<CountySalesTaxScrudView> , IPoco
    {
        [Column("county_sales_tax_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? CountySalesTaxId { get; set; }

        [Column("county_sales_tax_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string CountySalesTaxCode { get; set; }

        [Column("county_sales_tax_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string CountySalesTaxName { get; set; }

        [Column("county")] 
        [ColumnDbType("text", 0, true, "")] 
        public string County { get; set; }

        [Column("entity_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string EntityName { get; set; }

        [Column("industry_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string IndustryName { get; set; }

        [Column("item_group")] 
        [ColumnDbType("text", 0, true, "")] 
        public string ItemGroup { get; set; }

        [Column("rate")] 
        [ColumnDbType("decimal_strict2", 0, true, "")] 
        public decimal? Rate { get; set; }

    }

    [TableName("core.county_scrud_view")]
    [ExplicitColumns]
    public class CountyScrudView : PetaPocoDB.Record<CountyScrudView> , IPoco
    {
        [Column("county_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? CountyId { get; set; }

        [Column("county_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string CountyCode { get; set; }

        [Column("county_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string CountyName { get; set; }

        [Column("state")] 
        [ColumnDbType("text", 0, true, "")] 
        public string State { get; set; }

    }

    [TableName("core.currency_scrud_view")]
    [ExplicitColumns]
    public class CurrencyScrudView : PetaPocoDB.Record<CurrencyScrudView> , IPoco
    {
        [Column("currency_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string CurrencyCode { get; set; }

        [Column("currency_symbol")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string CurrencySymbol { get; set; }

        [Column("currency_name")] 
        [ColumnDbType("varchar", 48, true, "")] 
        public string CurrencyName { get; set; }

        [Column("hundredth_name")] 
        [ColumnDbType("varchar", 48, true, "")] 
        public string HundredthName { get; set; }

    }

    [TableName("core.entity_scrud_view")]
    [ExplicitColumns]
    public class EntityScrudView : PetaPocoDB.Record<EntityScrudView> , IPoco
    {
        [Column("entity_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? EntityId { get; set; }

        [Column("entity_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string EntityName { get; set; }

    }

    [TableName("core.fiscal_year_scrud_view")]
    [ExplicitColumns]
    public class FiscalYearScrudView : PetaPocoDB.Record<FiscalYearScrudView> , IPoco
    {
        [Column("fiscal_year_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string FiscalYearCode { get; set; }

        [Column("fiscal_year_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string FiscalYearName { get; set; }

        [Column("starts_from")] 
        [ColumnDbType("date", 0, true, "")] 
        public DateTime? StartsFrom { get; set; }

        [Column("ends_on")] 
        [ColumnDbType("date", 0, true, "")] 
        public DateTime? EndsOn { get; set; }

    }

    [TableName("core.flag_type_scrud_view")]
    [ExplicitColumns]
    public class FlagTypeScrudView : PetaPocoDB.Record<FlagTypeScrudView> , IPoco
    {
        [Column("flag_type_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? FlagTypeId { get; set; }

        [Column("flag_type_name")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string FlagTypeName { get; set; }

        [Column("background_color")] 
        [ColumnDbType("color", 0, true, "")] 
        public string BackgroundColor { get; set; }

        [Column("foreground_color")] 
        [ColumnDbType("color", 0, true, "")] 
        public string ForegroundColor { get; set; }

    }

    [TableName("core.industry_scrud_view")]
    [ExplicitColumns]
    public class IndustryScrudView : PetaPocoDB.Record<IndustryScrudView> , IPoco
    {
        [Column("industry_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? IndustryId { get; set; }

        [Column("industry_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string IndustryName { get; set; }

        [Column("parent_industry_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string ParentIndustryName { get; set; }

    }

    [TableName("core.item_cost_price_scrud_view")]
    [ExplicitColumns]
    public class ItemCostPriceScrudView : PetaPocoDB.Record<ItemCostPriceScrudView> , IPoco
    {
        [Column("item_cost_price_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? ItemCostPriceId { get; set; }

        [Column("item_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ItemCode { get; set; }

        [Column("item_name")] 
        [ColumnDbType("varchar", 150, true, "")] 
        public string ItemName { get; set; }

        [Column("party_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string PartyCode { get; set; }

        [Column("party_name")] 
        [ColumnDbType("text", 0, true, "")] 
        public string PartyName { get; set; }

        [Column("unit")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Unit { get; set; }

        [Column("price")] 
        [ColumnDbType("money_strict", 0, true, "")] 
        public decimal? Price { get; set; }

    }

    [TableName("core.item_group_scrud_view")]
    [ExplicitColumns]
    public class ItemGroupScrudView : PetaPocoDB.Record<ItemGroupScrudView> , IPoco
    {
        [Column("item_group_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? ItemGroupId { get; set; }

        [Column("item_group_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ItemGroupCode { get; set; }

        [Column("item_group_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string ItemGroupName { get; set; }

        [Column("exclude_from_purchase")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? ExcludeFromPurchase { get; set; }

        [Column("exclude_from_sales")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? ExcludeFromSales { get; set; }

        [Column("sales_tax")] 
        [ColumnDbType("text", 0, true, "")] 
        public string SalesTax { get; set; }

        [Column("parent")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Parent { get; set; }

    }

    [TableName("core.item_selling_price_scrud_view")]
    [ExplicitColumns]
    public class ItemSellingPriceScrudView : PetaPocoDB.Record<ItemSellingPriceScrudView> , IPoco
    {
        [Column("item_selling_price_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? ItemSellingPriceId { get; set; }

        [Column("item_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ItemCode { get; set; }

        [Column("item_name")] 
        [ColumnDbType("varchar", 150, true, "")] 
        public string ItemName { get; set; }

        [Column("party_type_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string PartyTypeCode { get; set; }

        [Column("party_type_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string PartyTypeName { get; set; }

        [Column("unit")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Unit { get; set; }

        [Column("price")] 
        [ColumnDbType("money_strict", 0, true, "")] 
        public decimal? Price { get; set; }

    }

    [TableName("core.item_type_scrud_view")]
    [ExplicitColumns]
    public class ItemTypeScrudView : PetaPocoDB.Record<ItemTypeScrudView> , IPoco
    {
        [Column("item_type_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? ItemTypeId { get; set; }

        [Column("item_type_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ItemTypeCode { get; set; }

        [Column("item_type_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string ItemTypeName { get; set; }

    }

    [TableName("core.sales_tax_detail_scrud_view")]
    [ExplicitColumns]
    public class SalesTaxDetailScrudView : PetaPocoDB.Record<SalesTaxDetailScrudView> , IPoco
    {
        [Column("sales_tax_detail_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? SalesTaxDetailId { get; set; }

        [Column("sales_tax")] 
        [ColumnDbType("text", 0, true, "")] 
        public string SalesTax { get; set; }

        [Column("sales_tax_type")] 
        [ColumnDbType("text", 0, true, "")] 
        public string SalesTaxType { get; set; }

        [Column("priority")] 
        [ColumnDbType("int2", 0, true, "")] 
        public short? Priority { get; set; }

        [Column("sales_tax_detail_code")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string SalesTaxDetailCode { get; set; }

        [Column("sales_tax_detail_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string SalesTaxDetailName { get; set; }

        [Column("based_on_shipping_address")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? BasedOnShippingAddress { get; set; }

        [Column("check_nexus")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? CheckNexus { get; set; }

        [Column("applied_on_shipping_charge")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? AppliedOnShippingCharge { get; set; }

        [Column("state_sales_tax")] 
        [ColumnDbType("text", 0, true, "")] 
        public string StateSalesTax { get; set; }

        [Column("county_sales_tax")] 
        [ColumnDbType("text", 0, true, "")] 
        public string CountySalesTax { get; set; }

        [Column("tax_rate_type")] 
        [ColumnDbType("text", 0, true, "")] 
        public string TaxRateType { get; set; }

        [Column("rate")] 
        [ColumnDbType("decimal_strict2", 0, true, "")] 
        public decimal? Rate { get; set; }

        [Column("reporting_tax_authority")] 
        [ColumnDbType("text", 0, true, "")] 
        public string ReportingTaxAuthority { get; set; }

        [Column("collecting_tax_authority")] 
        [ColumnDbType("text", 0, true, "")] 
        public string CollectingTaxAuthority { get; set; }

        [Column("collecting_account")] 
        [ColumnDbType("text", 0, true, "")] 
        public string CollectingAccount { get; set; }

        [Column("use_tax_collecting_account")] 
        [ColumnDbType("text", 0, true, "")] 
        public string UseTaxCollectingAccount { get; set; }

        [Column("rounding_method")] 
        [ColumnDbType("text", 0, true, "")] 
        public string RoundingMethod { get; set; }

        [Column("rounding_decimal_places")] 
        [ColumnDbType("integer_strict2", 0, true, "")] 
        public int? RoundingDecimalPlaces { get; set; }

    }

    [TableName("core.sales_tax_exempt_detail_scrud_view")]
    [ExplicitColumns]
    public class SalesTaxExemptDetailScrudView : PetaPocoDB.Record<SalesTaxExemptDetailScrudView> , IPoco
    {
        [Column("sales_tax_exempt_detail_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? SalesTaxExemptDetailId { get; set; }

        [Column("sales_tax_exempt")] 
        [ColumnDbType("text", 0, true, "")] 
        public string SalesTaxExempt { get; set; }

        [Column("entity_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string EntityName { get; set; }

        [Column("industry_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string IndustryName { get; set; }

        [Column("party")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Party { get; set; }

        [Column("party_type")] 
        [ColumnDbType("text", 0, true, "")] 
        public string PartyType { get; set; }

        [Column("item")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Item { get; set; }

        [Column("item_group")] 
        [ColumnDbType("text", 0, true, "")] 
        public string ItemGroup { get; set; }

    }

    [TableName("core.sales_tax_exempt_scrud_view")]
    [ExplicitColumns]
    public class SalesTaxExemptScrudView : PetaPocoDB.Record<SalesTaxExemptScrudView> , IPoco
    {
        [Column("sales_tax_exempt_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? SalesTaxExemptId { get; set; }

        [Column("tax_master")] 
        [ColumnDbType("text", 0, true, "")] 
        public string TaxMaster { get; set; }

        [Column("sales_tax_exempt_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string SalesTaxExemptCode { get; set; }

        [Column("sales_tax_exempt_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string SalesTaxExemptName { get; set; }

        [Column("tax_exempt_type")] 
        [ColumnDbType("text", 0, true, "")] 
        public string TaxExemptType { get; set; }

        [Column("store")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Store { get; set; }

        [Column("sales_tax")] 
        [ColumnDbType("text", 0, true, "")] 
        public string SalesTax { get; set; }

        [Column("valid_from")] 
        [ColumnDbType("date", 0, true, "")] 
        public DateTime? ValidFrom { get; set; }

        [Column("valid_till")] 
        [ColumnDbType("date", 0, true, "")] 
        public DateTime? ValidTill { get; set; }

        [Column("price_from")] 
        [ColumnDbType("money_strict2", 0, true, "")] 
        public decimal? PriceFrom { get; set; }

        [Column("price_to")] 
        [ColumnDbType("money_strict2", 0, true, "")] 
        public decimal? PriceTo { get; set; }

    }

    [TableName("core.sales_tax_scrud_view")]
    [ExplicitColumns]
    public class SalesTaxScrudView : PetaPocoDB.Record<SalesTaxScrudView> , IPoco
    {
        [Column("sales_tax_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? SalesTaxId { get; set; }

        [Column("tax_master")] 
        [ColumnDbType("text", 0, true, "")] 
        public string TaxMaster { get; set; }

        [Column("office")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Office { get; set; }

        [Column("sales_tax_code")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string SalesTaxCode { get; set; }

        [Column("sales_tax_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string SalesTaxName { get; set; }

        [Column("is_exemption")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsExemption { get; set; }

        [Column("tax_base_amount")] 
        [ColumnDbType("text", 0, true, "")] 
        public string TaxBaseAmount { get; set; }

        [Column("rate")] 
        [ColumnDbType("decimal_strict2", 0, true, "")] 
        public decimal? Rate { get; set; }

    }

    [TableName("core.sales_tax_type_scrud_view")]
    [ExplicitColumns]
    public class SalesTaxTypeScrudView : PetaPocoDB.Record<SalesTaxTypeScrudView> , IPoco
    {
        [Column("sales_tax_type_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? SalesTaxTypeId { get; set; }

        [Column("sales_tax_type_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string SalesTaxTypeCode { get; set; }

        [Column("sales_tax_type_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string SalesTaxTypeName { get; set; }

        [Column("is_vat")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsVat { get; set; }

    }

    [TableName("core.sales_team_scrud_view")]
    [ExplicitColumns]
    public class SalesTeamScrudView : PetaPocoDB.Record<SalesTeamScrudView> , IPoco
    {
        [Column("sales_team_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? SalesTeamId { get; set; }

        [Column("sales_team_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string SalesTeamCode { get; set; }

        [Column("sales_team_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string SalesTeamName { get; set; }

    }

    [TableName("core.shipper_scrud_view")]
    [ExplicitColumns]
    public class ShipperScrudView : PetaPocoDB.Record<ShipperScrudView> , IPoco
    {
        [Column("shipper_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? ShipperId { get; set; }

        [Column("shipper_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ShipperCode { get; set; }

        [Column("company_name")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string CompanyName { get; set; }

        [Column("shipper_name")] 
        [ColumnDbType("varchar", 150, true, "")] 
        public string ShipperName { get; set; }

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

        [Column("country")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string Country { get; set; }

        [Column("phone")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string Phone { get; set; }

        [Column("fax")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string Fax { get; set; }

        [Column("cell")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string Cell { get; set; }

        [Column("email")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string Email { get; set; }

        [Column("url")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string Url { get; set; }

        [Column("contact_person")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string ContactPerson { get; set; }

        [Column("contact_po_box")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string ContactPoBox { get; set; }

        [Column("contact_address_line_1")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string ContactAddressLine1 { get; set; }

        [Column("contact_address_line_2")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string ContactAddressLine2 { get; set; }

        [Column("contact_street")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string ContactStreet { get; set; }

        [Column("contact_city")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string ContactCity { get; set; }

        [Column("contact_state")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string ContactState { get; set; }

        [Column("contact_country")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string ContactCountry { get; set; }

        [Column("contact_email")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string ContactEmail { get; set; }

        [Column("contact_phone")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string ContactPhone { get; set; }

        [Column("contact_cell")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string ContactCell { get; set; }

        [Column("factory_address")] 
        [ColumnDbType("varchar", 250, true, "")] 
        public string FactoryAddress { get; set; }

        [Column("pan_number")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string PanNumber { get; set; }

        [Column("sst_number")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string SstNumber { get; set; }

        [Column("cst_number")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string CstNumber { get; set; }

        [Column("account")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Account { get; set; }

    }

    [TableName("core.state_sales_tax_scrud_view")]
    [ExplicitColumns]
    public class StateSalesTaxScrudView : PetaPocoDB.Record<StateSalesTaxScrudView> , IPoco
    {
        [Column("state_sales_tax_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? StateSalesTaxId { get; set; }

        [Column("state_sales_tax_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string StateSalesTaxCode { get; set; }

        [Column("state_sales_tax_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string StateSalesTaxName { get; set; }

        [Column("state")] 
        [ColumnDbType("text", 0, true, "")] 
        public string State { get; set; }

        [Column("entity_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string EntityName { get; set; }

        [Column("industry_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string IndustryName { get; set; }

        [Column("item_group")] 
        [ColumnDbType("text", 0, true, "")] 
        public string ItemGroup { get; set; }

        [Column("rate")] 
        [ColumnDbType("decimal_strict2", 0, true, "")] 
        public decimal? Rate { get; set; }

    }

    [TableName("core.state_scrud_view")]
    [ExplicitColumns]
    public class StateScrudView : PetaPocoDB.Record<StateScrudView> , IPoco
    {
        [Column("state_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? StateId { get; set; }

        [Column("country_name")] 
        [ColumnDbType("text", 0, true, "")] 
        public string CountryName { get; set; }

        [Column("state_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string StateCode { get; set; }

        [Column("state_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string StateName { get; set; }

    }

    [TableName("core.tax_authority_scrud_view")]
    [ExplicitColumns]
    public class TaxAuthorityScrudView : PetaPocoDB.Record<TaxAuthorityScrudView> , IPoco
    {
        [Column("tax_authority_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? TaxAuthorityId { get; set; }

        [Column("tax_master")] 
        [ColumnDbType("text", 0, true, "")] 
        public string TaxMaster { get; set; }

        [Column("tax_authority_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string TaxAuthorityCode { get; set; }

        [Column("tax_authority_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string TaxAuthorityName { get; set; }

        [Column("country")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Country { get; set; }

        [Column("county")] 
        [ColumnDbType("text", 0, true, "")] 
        public string County { get; set; }

        [Column("zip_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ZipCode { get; set; }

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

        [Column("phone")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string Phone { get; set; }

        [Column("fax")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string Fax { get; set; }

        [Column("cell")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string Cell { get; set; }

        [Column("email")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string Email { get; set; }

        [Column("url")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string Url { get; set; }

    }

    [TableName("core.tax_exempt_type_scrud_view")]
    [ExplicitColumns]
    public class TaxExemptTypeScrudView : PetaPocoDB.Record<TaxExemptTypeScrudView> , IPoco
    {
        [Column("tax_exempt_type_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? TaxExemptTypeId { get; set; }

        [Column("tax_exempt_type_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string TaxExemptTypeCode { get; set; }

        [Column("tax_exempt_type_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string TaxExemptTypeName { get; set; }

    }

    [TableName("core.tax_master_scrud_view")]
    [ExplicitColumns]
    public class TaxMasterScrudView : PetaPocoDB.Record<TaxMasterScrudView> , IPoco
    {
        [Column("tax_master_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? TaxMasterId { get; set; }

        [Column("tax_master_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string TaxMasterCode { get; set; }

        [Column("tax_master_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string TaxMasterName { get; set; }

    }

    [TableName("core.unit_scrud_view")]
    [ExplicitColumns]
    public class UnitScrudView : PetaPocoDB.Record<UnitScrudView> , IPoco
    {
        [Column("unit_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? UnitId { get; set; }

        [Column("unit_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string UnitCode { get; set; }

        [Column("unit_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string UnitName { get; set; }

    }

    [TableName("core.account_master_selector_view")]
    [ExplicitColumns]
    public class AccountMasterSelectorView : PetaPocoDB.Record<AccountMasterSelectorView> , IPoco
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

    [TableName("core.account_selector_view")]
    [ExplicitColumns]
    public class AccountSelectorView : PetaPocoDB.Record<AccountSelectorView> , IPoco
    {
        [Column("account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? AccountId { get; set; }

        [Column("account_number")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string AccountNumber { get; set; }

        [Column("account_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string AccountName { get; set; }

        [Column("description")] 
        [ColumnDbType("varchar", 200, true, "")] 
        public string Description { get; set; }

        [Column("sys_type")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? SysType { get; set; }

        [Column("parent_account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? ParentAccountId { get; set; }

        [Column("parent_account_number")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ParentAccountNumber { get; set; }

        [Column("parent_account_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string ParentAccountName { get; set; }

        [Column("account_master_id")] 
        [ColumnDbType("int2", 0, true, "")] 
        public short? AccountMasterId { get; set; }

        [Column("account_master_code")] 
        [ColumnDbType("varchar", 3, true, "")] 
        public string AccountMasterCode { get; set; }

        [Column("account_master_name")] 
        [ColumnDbType("varchar", 40, true, "")] 
        public string AccountMasterName { get; set; }

    }

    [TableName("core.bonus_slab_selector_view")]
    [ExplicitColumns]
    public class BonusSlabSelectorView : PetaPocoDB.Record<BonusSlabSelectorView> , IPoco
    {
        [Column("bonus_slab_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? BonusSlabId { get; set; }

        [Column("bonus_slab_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string BonusSlabCode { get; set; }

        [Column("bonus_slab_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string BonusSlabName { get; set; }

        [Column("effective_from")] 
        [ColumnDbType("date", 0, true, "")] 
        public DateTime? EffectiveFrom { get; set; }

        [Column("ends_on")] 
        [ColumnDbType("date", 0, true, "")] 
        public DateTime? EndsOn { get; set; }

        [Column("checking_frequency_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? CheckingFrequencyId { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.brand_selector_view")]
    [ExplicitColumns]
    public class BrandSelectorView : PetaPocoDB.Record<BrandSelectorView> , IPoco
    {
        [Column("brand_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? BrandId { get; set; }

        [Column("brand_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string BrandCode { get; set; }

        [Column("brand_name")] 
        [ColumnDbType("varchar", 150, true, "")] 
        public string BrandName { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.compound_item_selector_view")]
    [ExplicitColumns]
    public class CompoundItemSelectorView : PetaPocoDB.Record<CompoundItemSelectorView> , IPoco
    {
        [Column("compound_item_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? CompoundItemId { get; set; }

        [Column("compound_item_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string CompoundItemCode { get; set; }

        [Column("compound_item_name")] 
        [ColumnDbType("varchar", 150, true, "")] 
        public string CompoundItemName { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.currency_selector_view")]
    [ExplicitColumns]
    public class CurrencySelectorView : PetaPocoDB.Record<CurrencySelectorView> , IPoco
    {
        [Column("currency_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string CurrencyCode { get; set; }

        [Column("currency_symbol")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string CurrencySymbol { get; set; }

        [Column("currency_name")] 
        [ColumnDbType("varchar", 48, true, "")] 
        public string CurrencyName { get; set; }

        [Column("hundredth_name")] 
        [ColumnDbType("varchar", 48, true, "")] 
        public string HundredthName { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.fiscal_year_selector_view")]
    [ExplicitColumns]
    public class FiscalYearSelectorView : PetaPocoDB.Record<FiscalYearSelectorView> , IPoco
    {
        [Column("fiscal_year_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string FiscalYearCode { get; set; }

        [Column("fiscal_year_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string FiscalYearName { get; set; }

        [Column("starts_from")] 
        [ColumnDbType("date", 0, true, "")] 
        public DateTime? StartsFrom { get; set; }

        [Column("ends_on")] 
        [ColumnDbType("date", 0, true, "")] 
        public DateTime? EndsOn { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.frequency_selector_view")]
    [ExplicitColumns]
    public class FrequencySelectorView : PetaPocoDB.Record<FrequencySelectorView> , IPoco
    {
        [Column("frequency_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? FrequencyId { get; set; }

        [Column("frequency_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string FrequencyCode { get; set; }

        [Column("frequency_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string FrequencyName { get; set; }

    }

    [TableName("core.item_group_selector_view")]
    [ExplicitColumns]
    public class ItemGroupSelectorView : PetaPocoDB.Record<ItemGroupSelectorView> , IPoco
    {
        [Column("item_group_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? ItemGroupId { get; set; }

        [Column("item_group_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ItemGroupCode { get; set; }

        [Column("item_group_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string ItemGroupName { get; set; }

        [Column("exclude_from_purchase")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? ExcludeFromPurchase { get; set; }

        [Column("exclude_from_sales")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? ExcludeFromSales { get; set; }

        [Column("sales_tax_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? SalesTaxId { get; set; }

        [Column("sales_account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? SalesAccountId { get; set; }

        [Column("sales_discount_account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? SalesDiscountAccountId { get; set; }

        [Column("sales_return_account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? SalesReturnAccountId { get; set; }

        [Column("purchase_account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? PurchaseAccountId { get; set; }

        [Column("purchase_discount_account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? PurchaseDiscountAccountId { get; set; }

        [Column("inventory_account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? InventoryAccountId { get; set; }

        [Column("cost_of_goods_sold_account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? CostOfGoodsSoldAccountId { get; set; }

        [Column("parent_item_group_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? ParentItemGroupId { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.party_selector_view")]
    [ExplicitColumns]
    public class PartySelectorView : PetaPocoDB.Record<PartySelectorView> , IPoco
    {
        [Column("party_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? PartyId { get; set; }

        [Column("party_type_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? PartyTypeId { get; set; }

        [Column("is_supplier")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsSupplier { get; set; }

        [Column("party_type")] 
        [ColumnDbType("text", 0, true, "")] 
        public string PartyType { get; set; }

        [Column("party_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string PartyCode { get; set; }

        [Column("first_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string FirstName { get; set; }

        [Column("middle_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string MiddleName { get; set; }

        [Column("last_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string LastName { get; set; }

        [Column("party_name")] 
        [ColumnDbType("text", 0, true, "")] 
        public string PartyName { get; set; }

        [Column("zip_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ZipCode { get; set; }

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
        [ColumnDbType("text", 0, true, "")] 
        public string State { get; set; }

        [Column("country")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Country { get; set; }

        [Column("allow_credit")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? AllowCredit { get; set; }

        [Column("maximum_credit_period")] 
        [ColumnDbType("int2", 0, true, "")] 
        public short? MaximumCreditPeriod { get; set; }

        [Column("maximum_credit_amount")] 
        [ColumnDbType("money_strict2", 0, true, "")] 
        public decimal? MaximumCreditAmount { get; set; }

        [Column("pan_number")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string PanNumber { get; set; }

        [Column("sst_number")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string SstNumber { get; set; }

        [Column("cst_number")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string CstNumber { get; set; }

        [Column("phone")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string Phone { get; set; }

        [Column("fax")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string Fax { get; set; }

        [Column("cell")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string Cell { get; set; }

        [Column("email")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string Email { get; set; }

        [Column("url")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string Url { get; set; }

        [Column("account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? AccountId { get; set; }

        [Column("account_number")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string AccountNumber { get; set; }

        [Column("gl_head")] 
        [ColumnDbType("text", 0, true, "")] 
        public string GlHead { get; set; }

    }

    [TableName("core.party_type_selector_view")]
    [ExplicitColumns]
    public class PartyTypeSelectorView : PetaPocoDB.Record<PartyTypeSelectorView> , IPoco
    {
        [Column("party_type_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? PartyTypeId { get; set; }

        [Column("party_type_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string PartyTypeCode { get; set; }

        [Column("party_type_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string PartyTypeName { get; set; }

        [Column("is_supplier")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsSupplier { get; set; }

        [Column("account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? AccountId { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.price_type_selector_view")]
    [ExplicitColumns]
    public class PriceTypeSelectorView : PetaPocoDB.Record<PriceTypeSelectorView> , IPoco
    {
        [Column("price_type_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? PriceTypeId { get; set; }

        [Column("price_type_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string PriceTypeCode { get; set; }

        [Column("price_type_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string PriceTypeName { get; set; }

    }

    [TableName("core.rounding_method_selector_view")]
    [ExplicitColumns]
    public class RoundingMethodSelectorView : PetaPocoDB.Record<RoundingMethodSelectorView> , IPoco
    {
        [Column("rounding_method_code")] 
        [ColumnDbType("varchar", 4, true, "")] 
        public string RoundingMethodCode { get; set; }

        [Column("rounding_method_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string RoundingMethodName { get; set; }

    }

    [TableName("core.sales_tax_selector_view")]
    [ExplicitColumns]
    public class SalesTaxSelectorView : PetaPocoDB.Record<SalesTaxSelectorView> , IPoco
    {
        [Column("sales_tax_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? SalesTaxId { get; set; }

        [Column("tax_master_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? TaxMasterId { get; set; }

        [Column("office_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? OfficeId { get; set; }

        [Column("sales_tax_code")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string SalesTaxCode { get; set; }

        [Column("sales_tax_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string SalesTaxName { get; set; }

        [Column("is_exemption")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsExemption { get; set; }

        [Column("tax_base_amount_type_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string TaxBaseAmountTypeCode { get; set; }

        [Column("rate")] 
        [ColumnDbType("decimal_strict2", 0, true, "")] 
        public decimal? Rate { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.sales_team_selector_view")]
    [ExplicitColumns]
    public class SalesTeamSelectorView : PetaPocoDB.Record<SalesTeamSelectorView> , IPoco
    {
        [Column("sales_team_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? SalesTeamId { get; set; }

        [Column("sales_team_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string SalesTeamCode { get; set; }

        [Column("sales_team_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string SalesTeamName { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.salesperson_selector_view")]
    [ExplicitColumns]
    public class SalespersonSelectorView : PetaPocoDB.Record<SalespersonSelectorView> , IPoco
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

    [TableName("core.shipping_mail_type_selector_view")]
    [ExplicitColumns]
    public class ShippingMailTypeSelectorView : PetaPocoDB.Record<ShippingMailTypeSelectorView> , IPoco
    {
        [Column("shipping_mail_type_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? ShippingMailTypeId { get; set; }

        [Column("shipping_mail_type_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ShippingMailTypeCode { get; set; }

        [Column("shipping_mail_type_name")] 
        [ColumnDbType("varchar", 64, true, "")] 
        public string ShippingMailTypeName { get; set; }

    }

    [TableName("core.shipping_package_shape_selector_view")]
    [ExplicitColumns]
    public class ShippingPackageShapeSelectorView : PetaPocoDB.Record<ShippingPackageShapeSelectorView> , IPoco
    {
        [Column("shipping_package_shape_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? ShippingPackageShapeId { get; set; }

        [Column("shipping_package_shape_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ShippingPackageShapeCode { get; set; }

        [Column("shipping_package_shape_name")] 
        [ColumnDbType("varchar", 64, true, "")] 
        public string ShippingPackageShapeName { get; set; }

        [Column("is_rectangular")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsRectangular { get; set; }

    }

    [TableName("core.tax_base_amount_type_selector_view")]
    [ExplicitColumns]
    public class TaxBaseAmountTypeSelectorView : PetaPocoDB.Record<TaxBaseAmountTypeSelectorView> , IPoco
    {
        [Column("tax_base_amount_type_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string TaxBaseAmountTypeCode { get; set; }

        [Column("tax_base_amount_type_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string TaxBaseAmountTypeName { get; set; }

    }

    [TableName("core.tax_rate_type_selector_view")]
    [ExplicitColumns]
    public class TaxRateTypeSelectorView : PetaPocoDB.Record<TaxRateTypeSelectorView> , IPoco
    {
        [Column("tax_rate_type_code")] 
        [ColumnDbType("varchar", 4, true, "")] 
        public string TaxRateTypeCode { get; set; }

        [Column("tax_rate_type_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string TaxRateTypeName { get; set; }

    }

    [TableName("core.unit_selector_view")]
    [ExplicitColumns]
    public class UnitSelectorView : PetaPocoDB.Record<UnitSelectorView> , IPoco
    {
        [Column("unit_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? UnitId { get; set; }

        [Column("unit_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string UnitCode { get; set; }

        [Column("unit_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string UnitName { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.account_view")]
    [ExplicitColumns]
    public class AccountView : PetaPocoDB.Record<AccountView> , IPoco
    {
        [Column("account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? AccountId { get; set; }

        [Column("account")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Account { get; set; }

        [Column("account_number")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string AccountNumber { get; set; }

        [Column("account_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string AccountName { get; set; }

        [Column("description")] 
        [ColumnDbType("varchar", 200, true, "")] 
        public string Description { get; set; }

        [Column("external_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ExternalCode { get; set; }

        [Column("currency_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string CurrencyCode { get; set; }

        [Column("confidential")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? Confidential { get; set; }

        [Column("normally_debit")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? NormallyDebit { get; set; }

        [Column("is_transaction_node")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsTransactionNode { get; set; }

        [Column("sys_type")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? SysType { get; set; }

        [Column("parent_account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? ParentAccountId { get; set; }

        [Column("parent_account_number")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ParentAccountNumber { get; set; }

        [Column("parent_account_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string ParentAccountName { get; set; }

        [Column("parent_account")] 
        [ColumnDbType("text", 0, true, "")] 
        public string ParentAccount { get; set; }

        [Column("account_master_id")] 
        [ColumnDbType("int2", 0, true, "")] 
        public short? AccountMasterId { get; set; }

        [Column("account_master_code")] 
        [ColumnDbType("varchar", 3, true, "")] 
        public string AccountMasterCode { get; set; }

        [Column("account_master_name")] 
        [ColumnDbType("varchar", 40, true, "")] 
        public string AccountMasterName { get; set; }

        [Column("has_child")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? HasChild { get; set; }

    }

    [TableName("core.bank_account_view")]
    [ExplicitColumns]
    public class BankAccountView : PetaPocoDB.Record<BankAccountView> , IPoco
    {
        [Column("account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? AccountId { get; set; }

        [Column("account_number")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string AccountNumber { get; set; }

        [Column("account_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string AccountName { get; set; }

        [Column("maintained_by")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string MaintainedBy { get; set; }

        [Column("bank_name")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string BankName { get; set; }

        [Column("bank_branch")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string BankBranch { get; set; }

        [Column("bank_contact_number")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string BankContactNumber { get; set; }

        [Column("bank_address")] 
        [ColumnDbType("text", 0, true, "")] 
        public string BankAddress { get; set; }

        [Column("bank_account_number")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string BankAccountNumber { get; set; }

        [Column("bank_account_type")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string BankAccountType { get; set; }

        [Column("relation_officer")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string RelationOfficer { get; set; }

    }

    [TableName("core.party_user_control_view")]
    [ExplicitColumns]
    public class PartyUserControlView : PetaPocoDB.Record<PartyUserControlView> , IPoco
    {
        [Column("party_type_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string PartyTypeCode { get; set; }

        [Column("party_type_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string PartyTypeName { get; set; }

        [Column("email")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string Email { get; set; }

        [Column("url")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string Url { get; set; }

        [Column("pan_number")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string PanNumber { get; set; }

        [Column("sst_number")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string SstNumber { get; set; }

        [Column("cst_number")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string CstNumber { get; set; }

        [Column("allow_credit")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? AllowCredit { get; set; }

        [Column("maximum_credit_period")] 
        [ColumnDbType("int2", 0, true, "")] 
        public short? MaximumCreditPeriod { get; set; }

        [Column("maximum_credit_amount")] 
        [ColumnDbType("money_strict2", 0, true, "")] 
        public decimal? MaximumCreditAmount { get; set; }

        [Column("account_number")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string AccountNumber { get; set; }

        [Column("account_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string AccountName { get; set; }

        [Column("zip_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ZipCode { get; set; }

        [Column("address_line_1")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string AddressLine1 { get; set; }

        [Column("address_line_2")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string AddressLine2 { get; set; }

        [Column("street")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string Street { get; set; }

        [Column("state")] 
        [ColumnDbType("text", 0, true, "")] 
        public string State { get; set; }

        [Column("country")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Country { get; set; }

    }

    [TableName("core.supplier_view")]
    [ExplicitColumns]
    public class SupplierView : PetaPocoDB.Record<SupplierView> , IPoco
    {
        [Column("party_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? PartyId { get; set; }

        [Column("party_type_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? PartyTypeId { get; set; }

        [Column("party_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string PartyCode { get; set; }

        [Column("first_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string FirstName { get; set; }

        [Column("middle_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string MiddleName { get; set; }

        [Column("last_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string LastName { get; set; }

        [Column("party_name")] 
        [ColumnDbType("text", 0, true, "")] 
        public string PartyName { get; set; }

        [Column("date_of_birth")] 
        [ColumnDbType("date", 0, true, "")] 
        public DateTime? DateOfBirth { get; set; }

        [Column("entity_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? EntityId { get; set; }

        [Column("industry_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? IndustryId { get; set; }

        [Column("country_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? CountryId { get; set; }

        [Column("state_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? StateId { get; set; }

        [Column("zip_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ZipCode { get; set; }

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

        [Column("phone")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string Phone { get; set; }

        [Column("fax")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string Fax { get; set; }

        [Column("cell")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string Cell { get; set; }

        [Column("email")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string Email { get; set; }

        [Column("url")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string Url { get; set; }

        [Column("pan_number")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string PanNumber { get; set; }

        [Column("sst_number")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string SstNumber { get; set; }

        [Column("cst_number")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string CstNumber { get; set; }

        [Column("currency_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string CurrencyCode { get; set; }

        [Column("allow_credit")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? AllowCredit { get; set; }

        [Column("maximum_credit_period")] 
        [ColumnDbType("int2", 0, true, "")] 
        public short? MaximumCreditPeriod { get; set; }

        [Column("maximum_credit_amount")] 
        [ColumnDbType("money_strict2", 0, true, "")] 
        public decimal? MaximumCreditAmount { get; set; }

        [Column("account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? AccountId { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.unit_view")]
    [ExplicitColumns]
    public class UnitView : PetaPocoDB.Record<UnitView> , IPoco
    {
        [Column("unit_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? UnitId { get; set; }

        [Column("unit_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string UnitCode { get; set; }

        [Column("unit_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string UnitName { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.account_scrud_view")]
    [ExplicitColumns]
    public class AccountScrudView : PetaPocoDB.Record<AccountScrudView> , IPoco
    {
        [Column("account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? AccountId { get; set; }

        [Column("account_master")] 
        [ColumnDbType("text", 0, true, "")] 
        public string AccountMaster { get; set; }

        [Column("account_number")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string AccountNumber { get; set; }

        [Column("external_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ExternalCode { get; set; }

        [Column("currency")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Currency { get; set; }

        [Column("account_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string AccountName { get; set; }

        [Column("description")] 
        [ColumnDbType("varchar", 200, true, "")] 
        public string Description { get; set; }

        [Column("confidential")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? Confidential { get; set; }

        [Column("is_transaction_node")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsTransactionNode { get; set; }

        [Column("sys_type")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? SysType { get; set; }

        [Column("account_master_id")] 
        [ColumnDbType("int2", 0, true, "")] 
        public short? AccountMasterId { get; set; }

        [Column("parent")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Parent { get; set; }

    }

    [TableName("core.ageing_slab_scrud_view")]
    [ExplicitColumns]
    public class AgeingSlabScrudView : PetaPocoDB.Record<AgeingSlabScrudView> , IPoco
    {
        [Column("ageing_slab_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AgeingSlabId { get; set; }

        [Column("ageing_slab_name")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string AgeingSlabName { get; set; }

        [Column("from_days")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? FromDays { get; set; }

        [Column("to_days")] 
        [ColumnDbType("integer_strict2", 0, true, "")] 
        public int? ToDays { get; set; }

    }

    [TableName("core.payment_card_scrud_view")]
    [ExplicitColumns]
    public class PaymentCardScrudView : PetaPocoDB.Record<PaymentCardScrudView> , IPoco
    {
        [Column("payment_card_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? PaymentCardId { get; set; }

        [Column("payment_card_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string PaymentCardCode { get; set; }

        [Column("payment_card_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string PaymentCardName { get; set; }

        [Column("card_type")] 
        [ColumnDbType("text", 0, true, "")] 
        public string CardType { get; set; }

    }

    [TableName("core.bank_account_selector_view")]
    [ExplicitColumns]
    public class BankAccountSelectorView : PetaPocoDB.Record<BankAccountSelectorView> , IPoco
    {
        [Column("account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? AccountId { get; set; }

        [Column("account_master")] 
        [ColumnDbType("text", 0, true, "")] 
        public string AccountMaster { get; set; }

        [Column("account_number")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string AccountNumber { get; set; }

        [Column("external_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ExternalCode { get; set; }

        [Column("currency")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Currency { get; set; }

        [Column("account_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string AccountName { get; set; }

        [Column("description")] 
        [ColumnDbType("varchar", 200, true, "")] 
        public string Description { get; set; }

        [Column("confidential")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? Confidential { get; set; }

        [Column("is_transaction_node")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsTransactionNode { get; set; }

        [Column("sys_type")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? SysType { get; set; }

        [Column("account_master_id")] 
        [ColumnDbType("int2", 0, true, "")] 
        public short? AccountMasterId { get; set; }

        [Column("parent")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Parent { get; set; }

    }

    [TableName("core.bonus_slab_account_selector_view")]
    [ExplicitColumns]
    public class BonusSlabAccountSelectorView : PetaPocoDB.Record<BonusSlabAccountSelectorView> , IPoco
    {
        [Column("account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? AccountId { get; set; }

        [Column("account_master")] 
        [ColumnDbType("text", 0, true, "")] 
        public string AccountMaster { get; set; }

        [Column("account_number")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string AccountNumber { get; set; }

        [Column("external_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ExternalCode { get; set; }

        [Column("currency")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Currency { get; set; }

        [Column("account_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string AccountName { get; set; }

        [Column("description")] 
        [ColumnDbType("varchar", 200, true, "")] 
        public string Description { get; set; }

        [Column("confidential")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? Confidential { get; set; }

        [Column("is_transaction_node")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsTransactionNode { get; set; }

        [Column("sys_type")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? SysType { get; set; }

        [Column("account_master_id")] 
        [ColumnDbType("int2", 0, true, "")] 
        public short? AccountMasterId { get; set; }

        [Column("parent")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Parent { get; set; }

    }

    [TableName("core.cash_account_selector_view")]
    [ExplicitColumns]
    public class CashAccountSelectorView : PetaPocoDB.Record<CashAccountSelectorView> , IPoco
    {
        [Column("account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? AccountId { get; set; }

        [Column("account_master")] 
        [ColumnDbType("text", 0, true, "")] 
        public string AccountMaster { get; set; }

        [Column("account_number")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string AccountNumber { get; set; }

        [Column("external_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ExternalCode { get; set; }

        [Column("currency")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Currency { get; set; }

        [Column("account_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string AccountName { get; set; }

        [Column("description")] 
        [ColumnDbType("varchar", 200, true, "")] 
        public string Description { get; set; }

        [Column("confidential")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? Confidential { get; set; }

        [Column("is_transaction_node")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsTransactionNode { get; set; }

        [Column("sys_type")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? SysType { get; set; }

        [Column("account_master_id")] 
        [ColumnDbType("int2", 0, true, "")] 
        public short? AccountMasterId { get; set; }

        [Column("parent")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Parent { get; set; }

    }

    [TableName("core.cost_of_sales_account_selector_view")]
    [ExplicitColumns]
    public class CostOfSalesAccountSelectorView : PetaPocoDB.Record<CostOfSalesAccountSelectorView> , IPoco
    {
        [Column("account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? AccountId { get; set; }

        [Column("account_master")] 
        [ColumnDbType("text", 0, true, "")] 
        public string AccountMaster { get; set; }

        [Column("account_number")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string AccountNumber { get; set; }

        [Column("external_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ExternalCode { get; set; }

        [Column("currency")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Currency { get; set; }

        [Column("account_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string AccountName { get; set; }

        [Column("description")] 
        [ColumnDbType("varchar", 200, true, "")] 
        public string Description { get; set; }

        [Column("confidential")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? Confidential { get; set; }

        [Column("is_transaction_node")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsTransactionNode { get; set; }

        [Column("sys_type")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? SysType { get; set; }

        [Column("account_master_id")] 
        [ColumnDbType("int2", 0, true, "")] 
        public short? AccountMasterId { get; set; }

        [Column("parent")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Parent { get; set; }

    }

    [TableName("core.inventory_account_selector_view")]
    [ExplicitColumns]
    public class InventoryAccountSelectorView : PetaPocoDB.Record<InventoryAccountSelectorView> , IPoco
    {
        [Column("account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? AccountId { get; set; }

        [Column("account_master")] 
        [ColumnDbType("text", 0, true, "")] 
        public string AccountMaster { get; set; }

        [Column("account_number")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string AccountNumber { get; set; }

        [Column("external_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ExternalCode { get; set; }

        [Column("currency")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Currency { get; set; }

        [Column("account_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string AccountName { get; set; }

        [Column("description")] 
        [ColumnDbType("varchar", 200, true, "")] 
        public string Description { get; set; }

        [Column("confidential")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? Confidential { get; set; }

        [Column("is_transaction_node")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsTransactionNode { get; set; }

        [Column("sys_type")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? SysType { get; set; }

        [Column("account_master_id")] 
        [ColumnDbType("int2", 0, true, "")] 
        public short? AccountMasterId { get; set; }

        [Column("parent")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Parent { get; set; }

    }

    [TableName("core.late_fee_account_selector_view")]
    [ExplicitColumns]
    public class LateFeeAccountSelectorView : PetaPocoDB.Record<LateFeeAccountSelectorView> , IPoco
    {
        [Column("account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? AccountId { get; set; }

        [Column("account_master")] 
        [ColumnDbType("text", 0, true, "")] 
        public string AccountMaster { get; set; }

        [Column("account_number")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string AccountNumber { get; set; }

        [Column("external_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ExternalCode { get; set; }

        [Column("currency")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Currency { get; set; }

        [Column("account_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string AccountName { get; set; }

        [Column("description")] 
        [ColumnDbType("varchar", 200, true, "")] 
        public string Description { get; set; }

        [Column("confidential")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? Confidential { get; set; }

        [Column("is_transaction_node")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsTransactionNode { get; set; }

        [Column("sys_type")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? SysType { get; set; }

        [Column("account_master_id")] 
        [ColumnDbType("int2", 0, true, "")] 
        public short? AccountMasterId { get; set; }

        [Column("parent")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Parent { get; set; }

    }

    [TableName("core.merchant_fee_setup_account_selector_view")]
    [ExplicitColumns]
    public class MerchantFeeSetupAccountSelectorView : PetaPocoDB.Record<MerchantFeeSetupAccountSelectorView> , IPoco
    {
        [Column("account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? AccountId { get; set; }

        [Column("account_master")] 
        [ColumnDbType("text", 0, true, "")] 
        public string AccountMaster { get; set; }

        [Column("account_number")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string AccountNumber { get; set; }

        [Column("external_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ExternalCode { get; set; }

        [Column("currency")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Currency { get; set; }

        [Column("account_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string AccountName { get; set; }

        [Column("description")] 
        [ColumnDbType("varchar", 200, true, "")] 
        public string Description { get; set; }

        [Column("confidential")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? Confidential { get; set; }

        [Column("is_transaction_node")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsTransactionNode { get; set; }

        [Column("sys_type")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? SysType { get; set; }

        [Column("account_master_id")] 
        [ColumnDbType("int2", 0, true, "")] 
        public short? AccountMasterId { get; set; }

        [Column("parent")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Parent { get; set; }

    }

    [TableName("core.party_type_account_selector_view")]
    [ExplicitColumns]
    public class PartyTypeAccountSelectorView : PetaPocoDB.Record<PartyTypeAccountSelectorView> , IPoco
    {
        [Column("account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? AccountId { get; set; }

        [Column("account_master")] 
        [ColumnDbType("text", 0, true, "")] 
        public string AccountMaster { get; set; }

        [Column("account_number")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string AccountNumber { get; set; }

        [Column("external_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ExternalCode { get; set; }

        [Column("currency")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Currency { get; set; }

        [Column("account_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string AccountName { get; set; }

        [Column("description")] 
        [ColumnDbType("varchar", 200, true, "")] 
        public string Description { get; set; }

        [Column("confidential")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? Confidential { get; set; }

        [Column("is_transaction_node")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsTransactionNode { get; set; }

        [Column("sys_type")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? SysType { get; set; }

        [Column("account_master_id")] 
        [ColumnDbType("int2", 0, true, "")] 
        public short? AccountMasterId { get; set; }

        [Column("parent")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Parent { get; set; }

    }

    [TableName("core.purcahse_account_selector_view")]
    [ExplicitColumns]
    public class PurcahseAccountSelectorView : PetaPocoDB.Record<PurcahseAccountSelectorView> , IPoco
    {
        [Column("account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? AccountId { get; set; }

        [Column("account_master")] 
        [ColumnDbType("text", 0, true, "")] 
        public string AccountMaster { get; set; }

        [Column("account_number")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string AccountNumber { get; set; }

        [Column("external_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ExternalCode { get; set; }

        [Column("currency")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Currency { get; set; }

        [Column("account_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string AccountName { get; set; }

        [Column("description")] 
        [ColumnDbType("varchar", 200, true, "")] 
        public string Description { get; set; }

        [Column("confidential")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? Confidential { get; set; }

        [Column("is_transaction_node")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsTransactionNode { get; set; }

        [Column("sys_type")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? SysType { get; set; }

        [Column("account_master_id")] 
        [ColumnDbType("int2", 0, true, "")] 
        public short? AccountMasterId { get; set; }

        [Column("parent")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Parent { get; set; }

    }

    [TableName("core.purchase_discount_account_selector_view")]
    [ExplicitColumns]
    public class PurchaseDiscountAccountSelectorView : PetaPocoDB.Record<PurchaseDiscountAccountSelectorView> , IPoco
    {
        [Column("account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? AccountId { get; set; }

        [Column("account_master")] 
        [ColumnDbType("text", 0, true, "")] 
        public string AccountMaster { get; set; }

        [Column("account_number")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string AccountNumber { get; set; }

        [Column("external_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ExternalCode { get; set; }

        [Column("currency")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Currency { get; set; }

        [Column("account_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string AccountName { get; set; }

        [Column("description")] 
        [ColumnDbType("varchar", 200, true, "")] 
        public string Description { get; set; }

        [Column("confidential")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? Confidential { get; set; }

        [Column("is_transaction_node")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsTransactionNode { get; set; }

        [Column("sys_type")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? SysType { get; set; }

        [Column("account_master_id")] 
        [ColumnDbType("int2", 0, true, "")] 
        public short? AccountMasterId { get; set; }

        [Column("parent")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Parent { get; set; }

    }

    [TableName("core.recurring_invoice_account_selector_view")]
    [ExplicitColumns]
    public class RecurringInvoiceAccountSelectorView : PetaPocoDB.Record<RecurringInvoiceAccountSelectorView> , IPoco
    {
        [Column("account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? AccountId { get; set; }

        [Column("account_master")] 
        [ColumnDbType("text", 0, true, "")] 
        public string AccountMaster { get; set; }

        [Column("account_number")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string AccountNumber { get; set; }

        [Column("external_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ExternalCode { get; set; }

        [Column("currency")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Currency { get; set; }

        [Column("account_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string AccountName { get; set; }

        [Column("description")] 
        [ColumnDbType("varchar", 200, true, "")] 
        public string Description { get; set; }

        [Column("confidential")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? Confidential { get; set; }

        [Column("is_transaction_node")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsTransactionNode { get; set; }

        [Column("sys_type")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? SysType { get; set; }

        [Column("account_master_id")] 
        [ColumnDbType("int2", 0, true, "")] 
        public short? AccountMasterId { get; set; }

        [Column("parent")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Parent { get; set; }

    }

    [TableName("core.revenue_account_selector_view")]
    [ExplicitColumns]
    public class RevenueAccountSelectorView : PetaPocoDB.Record<RevenueAccountSelectorView> , IPoco
    {
        [Column("account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? AccountId { get; set; }

        [Column("account_master")] 
        [ColumnDbType("text", 0, true, "")] 
        public string AccountMaster { get; set; }

        [Column("account_number")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string AccountNumber { get; set; }

        [Column("external_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ExternalCode { get; set; }

        [Column("currency")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Currency { get; set; }

        [Column("account_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string AccountName { get; set; }

        [Column("description")] 
        [ColumnDbType("varchar", 200, true, "")] 
        public string Description { get; set; }

        [Column("confidential")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? Confidential { get; set; }

        [Column("is_transaction_node")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsTransactionNode { get; set; }

        [Column("sys_type")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? SysType { get; set; }

        [Column("account_master_id")] 
        [ColumnDbType("int2", 0, true, "")] 
        public short? AccountMasterId { get; set; }

        [Column("parent")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Parent { get; set; }

    }

    [TableName("core.sales_discount_account_selector_view")]
    [ExplicitColumns]
    public class SalesDiscountAccountSelectorView : PetaPocoDB.Record<SalesDiscountAccountSelectorView> , IPoco
    {
        [Column("account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? AccountId { get; set; }

        [Column("account_master")] 
        [ColumnDbType("text", 0, true, "")] 
        public string AccountMaster { get; set; }

        [Column("account_number")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string AccountNumber { get; set; }

        [Column("external_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ExternalCode { get; set; }

        [Column("currency")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Currency { get; set; }

        [Column("account_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string AccountName { get; set; }

        [Column("description")] 
        [ColumnDbType("varchar", 200, true, "")] 
        public string Description { get; set; }

        [Column("confidential")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? Confidential { get; set; }

        [Column("is_transaction_node")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsTransactionNode { get; set; }

        [Column("sys_type")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? SysType { get; set; }

        [Column("account_master_id")] 
        [ColumnDbType("int2", 0, true, "")] 
        public short? AccountMasterId { get; set; }

        [Column("parent")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Parent { get; set; }

    }

    [TableName("core.salesperson_account_selector_view")]
    [ExplicitColumns]
    public class SalespersonAccountSelectorView : PetaPocoDB.Record<SalespersonAccountSelectorView> , IPoco
    {
        [Column("account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? AccountId { get; set; }

        [Column("account_master")] 
        [ColumnDbType("text", 0, true, "")] 
        public string AccountMaster { get; set; }

        [Column("account_number")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string AccountNumber { get; set; }

        [Column("external_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ExternalCode { get; set; }

        [Column("currency")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Currency { get; set; }

        [Column("account_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string AccountName { get; set; }

        [Column("description")] 
        [ColumnDbType("varchar", 200, true, "")] 
        public string Description { get; set; }

        [Column("confidential")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? Confidential { get; set; }

        [Column("is_transaction_node")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsTransactionNode { get; set; }

        [Column("sys_type")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? SysType { get; set; }

        [Column("account_master_id")] 
        [ColumnDbType("int2", 0, true, "")] 
        public short? AccountMasterId { get; set; }

        [Column("parent")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Parent { get; set; }

    }

    [TableName("core.accounts")]
    [PrimaryKey("account_id", autoIncrement=true)]
    [ExplicitColumns]
    public class Account : PetaPocoDB.Record<Account> , IPoco
    {
        [Column("account_id")] 
        [ColumnDbType("int8", 0, false, "nextval('core.accounts_account_id_seq'::regclass)")] 
        public long AccountId { get; set; }

        [Column("account_master_id")] 
        [ColumnDbType("int2", 0, false, "")] 
        public short AccountMasterId { get; set; }

        [Column("account_number")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string AccountNumber { get; set; }

        [Column("external_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ExternalCode { get; set; }

        [Column("currency_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string CurrencyCode { get; set; }

        [Column("account_name")] 
        [ColumnDbType("varchar", 100, false, "")] 
        public string AccountName { get; set; }

        [Column("description")] 
        [ColumnDbType("varchar", 200, true, "")] 
        public string Description { get; set; }

        [Column("confidential")] 
        [ColumnDbType("bool", 0, false, "false")] 
        public bool Confidential { get; set; }

        [Column("is_transaction_node")] 
        [ColumnDbType("bool", 0, false, "true")] 
        public bool IsTransactionNode { get; set; }

        [Column("sys_type")] 
        [ColumnDbType("bool", 0, false, "false")] 
        public bool SysType { get; set; }

        [Column("parent_account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? ParentAccountId { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("core.parties")]
    [PrimaryKey("party_id", autoIncrement=true)]
    [ExplicitColumns]
    public class Party : PetaPocoDB.Record<Party> , IPoco
    {
        [Column("party_id")] 
        [ColumnDbType("int8", 0, false, "nextval('core.parties_party_id_seq'::regclass)")] 
        public long PartyId { get; set; }

        [Column("party_type_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int PartyTypeId { get; set; }

        [Column("party_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string PartyCode { get; set; }

        [Column("first_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string FirstName { get; set; }

        [Column("middle_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string MiddleName { get; set; }

        [Column("last_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string LastName { get; set; }

        [Column("company_name")] 
        [ColumnDbType("text", 0, true, "")] 
        public string CompanyName { get; set; }

        [Column("date_of_birth")] 
        [ColumnDbType("date", 0, true, "")] 
        public DateTime? DateOfBirth { get; set; }

        [Column("entity_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? EntityId { get; set; }

        [Column("industry_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? IndustryId { get; set; }

        [Column("country_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int CountryId { get; set; }

        [Column("state_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? StateId { get; set; }

        [Column("zip_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string ZipCode { get; set; }

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

        [Column("phone")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string Phone { get; set; }

        [Column("fax")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string Fax { get; set; }

        [Column("cell")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string Cell { get; set; }

        [Column("email")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string Email { get; set; }

        [Column("url")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string Url { get; set; }

        [Column("pan_number")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string PanNumber { get; set; }

        [Column("sst_number")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string SstNumber { get; set; }

        [Column("cst_number")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string CstNumber { get; set; }

        [Column("currency_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string CurrencyCode { get; set; }

        [Column("allow_credit")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? AllowCredit { get; set; }

        [Column("maximum_credit_period")] 
        [ColumnDbType("int2", 0, true, "")] 
        public short? MaximumCreditPeriod { get; set; }

        [Column("maximum_credit_amount")] 
        [ColumnDbType("money_strict2", 0, true, "")] 
        public decimal? MaximumCreditAmount { get; set; }

        [Column("account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? AccountId { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

        [Column("party_name")] 
        [ColumnDbType("text", 0, true, "")] 
        public string PartyName { get; set; }

        [Column("photo")] 
        [ColumnDbType("image", 0, true, "")] 
        public string Photo { get; set; }

    }

    [FunctionName("get_workflow_model")]
    [ExplicitColumns]
    public class DbGetWorkflowModelResult : PetaPocoDB.Record<DbGetWorkflowModelResult> , IPoco
    {
        [Column("flagged_transactions")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int FlaggedTransactions { get; set; }

        [Column("in_verification_stack")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int InVerificationStack { get; set; }

        [Column("auto_approved")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int AutoApproved { get; set; }

        [Column("approved")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int Approved { get; set; }

        [Column("rejected")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int Rejected { get; set; }

        [Column("closed")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int Closed { get; set; }

        [Column("withdrawn")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int Withdrawn { get; set; }

    }

    [FunctionName("get_account_view_by_account_master_id")]
    [ExplicitColumns]
    public class DbGetAccountViewByAccountMasterIdResult : PetaPocoDB.Record<DbGetAccountViewByAccountMasterIdResult> , IPoco
    {
        [Column("id")] 
        [ColumnDbType("bigint", 0, false, "")] 
        public long Id { get; set; }

        [Column("account_id")] 
        [ColumnDbType("bigint", 0, false, "")] 
        public long AccountId { get; set; }

        [Column("account_name")] 
        [ColumnDbType("text", 0, false, "")] 
        public string AccountName { get; set; }

    }

    [FunctionName("get_associated_units_from_item_id")]
    [ExplicitColumns]
    public class DbGetAssociatedUnitsFromItemIdResult : PetaPocoDB.Record<DbGetAssociatedUnitsFromItemIdResult> , IPoco
    {
        [Column("unit_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int UnitId { get; set; }

        [Column("unit_code")] 
        [ColumnDbType("text", 0, false, "")] 
        public string UnitCode { get; set; }

        [Column("unit_name")] 
        [ColumnDbType("text", 0, false, "")] 
        public string UnitName { get; set; }

    }

    [FunctionName("get_associated_units")]
    [ExplicitColumns]
    public class DbGetAssociatedUnitsResult : PetaPocoDB.Record<DbGetAssociatedUnitsResult> , IPoco
    {
        [Column("unit_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int UnitId { get; set; }

        [Column("unit_code")] 
        [ColumnDbType("text", 0, false, "")] 
        public string UnitCode { get; set; }

        [Column("unit_name")] 
        [ColumnDbType("text", 0, false, "")] 
        public string UnitName { get; set; }

    }

    [FunctionName("get_compound_item_details")]
    [ExplicitColumns]
    public class DbGetCompoundItemDetailsResult : PetaPocoDB.Record<DbGetCompoundItemDetailsResult> , IPoco
    {
        [Column("id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int Id { get; set; }

        [Column("item_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int ItemId { get; set; }

        [Column("item_code")] 
        [ColumnDbType("text", 0, false, "")] 
        public string ItemCode { get; set; }

        [Column("item_name")] 
        [ColumnDbType("text", 0, false, "")] 
        public string ItemName { get; set; }

        [Column("quantity")] 
        [ColumnDbType("integer_strict", 0, false, "")] 
        public int Quantity { get; set; }

        [Column("unit_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int UnitId { get; set; }

        [Column("unit_name")] 
        [ColumnDbType("text", 0, false, "")] 
        public string UnitName { get; set; }

        [Column("price")] 
        [ColumnDbType("money_strict2", 0, false, "")] 
        public decimal Price { get; set; }

        [Column("discount")] 
        [ColumnDbType("money_strict2", 0, false, "")] 
        public decimal Discount { get; set; }

        [Column("sales_tax_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int SalesTaxId { get; set; }

        [Column("sales_tax_code")] 
        [ColumnDbType("text", 0, false, "")] 
        public string SalesTaxCode { get; set; }

        [Column("computed_tax")] 
        [ColumnDbType("money_strict2", 0, false, "")] 
        public decimal ComputedTax { get; set; }

    }

    [FunctionName("get_associated_units_from_item_code")]
    [ExplicitColumns]
    public class DbGetAssociatedUnitsFromItemCodeResult : PetaPocoDB.Record<DbGetAssociatedUnitsFromItemCodeResult> , IPoco
    {
        [Column("unit_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int UnitId { get; set; }

        [Column("unit_code")] 
        [ColumnDbType("text", 0, false, "")] 
        public string UnitCode { get; set; }

        [Column("unit_name")] 
        [ColumnDbType("text", 0, false, "")] 
        public string UnitName { get; set; }

    }

    [TableName("core.attachment_type")]
    [ExplicitColumns]
    public class AttachmentType : PetaPocoDB.Record<AttachmentType> , IPoco
    {
        [Column("comment")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string Comment { get; set; }

        [Column("file_path")] 
        [ColumnDbType("text", 0, false, "")] 
        public string FilePath { get; set; }

        [Column("original_file_name")] 
        [ColumnDbType("text", 0, false, "")] 
        public string OriginalFileName { get; set; }

        [Column("file_extension")] 
        [ColumnDbType("text", 0, false, "")] 
        public string FileExtension { get; set; }

    }

    [TableName("core.period")]
    [ExplicitColumns]
    public class Period : PetaPocoDB.Record<Period> , IPoco
    {
        [Column("period_name")] 
        [ColumnDbType("text", 0, false, "")] 
        public string PeriodName { get; set; }

        [Column("date_from")] 
        [ColumnDbType("date", 0, false, "")] 
        public DateTime DateFrom { get; set; }

        [Column("date_to")] 
        [ColumnDbType("date", 0, false, "")] 
        public DateTime DateTo { get; set; }

    }
}

