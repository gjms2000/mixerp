
using MixERP.Net.Entities.Contracts;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MixERP.Net.Entities.Transactions
{

    [TableName("transactions.party_item_chart_view")]
    [ExplicitColumns]
    public class PartyItemChartView : PetaPocoDB.Record<PartyItemChartView> , IPoco
    {
        [Column("party_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? PartyId { get; set; }

        [Column("item_name")] 
        [ColumnDbType("varchar", 150, true, "")] 
        public string ItemName { get; set; }

        [Column("total")] 
        [ColumnDbType("numeric", 0, true, "")] 
        public decimal? Total { get; set; }

    }

    [TableName("transactions.party_purchase_chart_view")]
    [ExplicitColumns]
    public class PartyPurchaseChartView : PetaPocoDB.Record<PartyPurchaseChartView> , IPoco
    {
        [Column("row_number")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? RowNumber { get; set; }

        [Column("transaction_master_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? TransactionMasterId { get; set; }

        [Column("party_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? PartyId { get; set; }

        [Column("book")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string Book { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, true, "")] 
        public DateTime? ValueDate { get; set; }

        [Column("amount")] 
        [ColumnDbType("numeric", 1572868, true, "")] 
        public decimal? Amount { get; set; }

    }

    [TableName("transactions.party_sales_chart_view")]
    [ExplicitColumns]
    public class PartySalesChartView : PetaPocoDB.Record<PartySalesChartView> , IPoco
    {
        [Column("row_number")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? RowNumber { get; set; }

        [Column("transaction_master_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? TransactionMasterId { get; set; }

        [Column("party_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? PartyId { get; set; }

        [Column("book")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string Book { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, true, "")] 
        public DateTime? ValueDate { get; set; }

        [Column("amount")] 
        [ColumnDbType("numeric", 1572868, true, "")] 
        public decimal? Amount { get; set; }

    }

    [TableName("transactions.receipt_view")]
    [ExplicitColumns]
    public class ReceiptView : PetaPocoDB.Record<ReceiptView> , IPoco
    {
        [Column("tran_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? TranId { get; set; }

        [Column("office_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? OfficeId { get; set; }

        [Column("office_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string OfficeCode { get; set; }

        [Column("transaction_master_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? TransactionMasterId { get; set; }

        [Column("transaction_code")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string TransactionCode { get; set; }

        [Column("transaction_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? TransactionTs { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, true, "")] 
        public DateTime? ValueDate { get; set; }

        [Column("entered_by")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string EnteredBy { get; set; }

        [Column("reference_number")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string ReferenceNumber { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("text", 0, true, "")] 
        public string StatementReference { get; set; }

        [Column("status")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string Status { get; set; }

        [Column("verification_reason")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string VerificationReason { get; set; }

        [Column("verified_by")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string VerifiedBy { get; set; }

        [Column("customer_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? CustomerId { get; set; }

        [Column("customer_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string CustomerCode { get; set; }

        [Column("customer_name")] 
        [ColumnDbType("text", 0, true, "")] 
        public string CustomerName { get; set; }

        [Column("address")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Address { get; set; }

        [Column("pan_number")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string PanNumber { get; set; }

        [Column("sst_number")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string SstNumber { get; set; }

        [Column("cst_number")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string CstNumber { get; set; }

        [Column("email")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string Email { get; set; }

        [Column("currency_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string CurrencyCode { get; set; }

        [Column("amount")] 
        [ColumnDbType("money_strict", 0, true, "")] 
        public decimal? Amount { get; set; }

        [Column("er_debit")] 
        [ColumnDbType("decimal_strict", 0, true, "")] 
        public decimal? ErDebit { get; set; }

        [Column("home_currency_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string HomeCurrencyCode { get; set; }

        [Column("amount_in_home_currency")] 
        [ColumnDbType("numeric", 0, true, "")] 
        public decimal? AmountInHomeCurrency { get; set; }

        [Column("er_credit")] 
        [ColumnDbType("decimal_strict", 0, true, "")] 
        public decimal? ErCredit { get; set; }

        [Column("base_currency_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string BaseCurrencyCode { get; set; }

        [Column("amount_in_base_currency")] 
        [ColumnDbType("numeric", 0, true, "")] 
        public decimal? AmountInBaseCurrency { get; set; }

    }

    [TableName("transactions.sales_delivery_view")]
    [ExplicitColumns]
    public class SalesDeliveryView : PetaPocoDB.Record<SalesDeliveryView> , IPoco
    {
        [Column("tran_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? TranId { get; set; }

        [Column("transaction_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? TransactionTs { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, true, "")] 
        public DateTime? ValueDate { get; set; }

        [Column("entered_by")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string EnteredBy { get; set; }

        [Column("status")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string Status { get; set; }

        [Column("due_date")] 
        [ColumnDbType("date", 0, true, "")] 
        public DateTime? DueDate { get; set; }

        [Column("reference_number")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string ReferenceNumber { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("text", 0, true, "")] 
        public string StatementReference { get; set; }

        [Column("customer_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string CustomerCode { get; set; }

        [Column("customer_name")] 
        [ColumnDbType("text", 0, true, "")] 
        public string CustomerName { get; set; }

        [Column("pan_number")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string PanNumber { get; set; }

        [Column("sst_number")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string SstNumber { get; set; }

        [Column("cst_number")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string CstNumber { get; set; }

        [Column("store_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string StoreName { get; set; }

        [Column("shipping_address")] 
        [ColumnDbType("text", 0, true, "")] 
        public string ShippingAddress { get; set; }

        [Column("shipper_name")] 
        [ColumnDbType("varchar", 150, true, "")] 
        public string ShipperName { get; set; }

        [Column("shipping_charge")] 
        [ColumnDbType("money_strict2", 0, true, "")] 
        public decimal? ShippingCharge { get; set; }

        [Column("invoice_amount")] 
        [ColumnDbType("money_strict2", 0, true, "")] 
        public decimal? InvoiceAmount { get; set; }

    }

    [TableName("transactions.sales_order_view")]
    [ExplicitColumns]
    public class SalesOrderView : PetaPocoDB.Record<SalesOrderView> , IPoco
    {
        [Column("non_gl_stock_master_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? NonGlStockMasterId { get; set; }

        [Column("tran_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? TranId { get; set; }

        [Column("transaction_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? TransactionTs { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, true, "")] 
        public DateTime? ValueDate { get; set; }

        [Column("quotation_valid_duration")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? QuotationValidDuration { get; set; }

        [Column("entered_by")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string EnteredBy { get; set; }

        [Column("office_name")] 
        [ColumnDbType("varchar", 150, true, "")] 
        public string OfficeName { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("text", 0, true, "")] 
        public string StatementReference { get; set; }

        [Column("customer_name")] 
        [ColumnDbType("text", 0, true, "")] 
        public string CustomerName { get; set; }

        [Column("price_type_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string PriceTypeName { get; set; }

    }

    [TableName("transactions.sales_quotation_view")]
    [ExplicitColumns]
    public class SalesQuotationView : PetaPocoDB.Record<SalesQuotationView> , IPoco
    {
        [Column("non_gl_stock_master_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? NonGlStockMasterId { get; set; }

        [Column("tran_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? TranId { get; set; }

        [Column("transaction_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? TransactionTs { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, true, "")] 
        public DateTime? ValueDate { get; set; }

        [Column("quotation_valid_duration")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? QuotationValidDuration { get; set; }

        [Column("entered_by")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string EnteredBy { get; set; }

        [Column("office_name")] 
        [ColumnDbType("varchar", 150, true, "")] 
        public string OfficeName { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("text", 0, true, "")] 
        public string StatementReference { get; set; }

        [Column("customer_name")] 
        [ColumnDbType("text", 0, true, "")] 
        public string CustomerName { get; set; }

        [Column("price_type_name")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string PriceTypeName { get; set; }

    }

    [TableName("transactions.customer_receipts")]
    [PrimaryKey("receipt_id", autoIncrement=true)]
    [ExplicitColumns]
    public class CustomerReceipt : PetaPocoDB.Record<CustomerReceipt> , IPoco
    {
        [Column("receipt_id")] 
        [ColumnDbType("int8", 0, false, "nextval('transactions.customer_receipts_receipt_id_seq'::regclass)")] 
        public long ReceiptId { get; set; }

        [Column("transaction_master_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long TransactionMasterId { get; set; }

        [Column("party_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long PartyId { get; set; }

        [Column("currency_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string CurrencyCode { get; set; }

        [Column("amount")] 
        [ColumnDbType("money_strict", 0, false, "")] 
        public decimal Amount { get; set; }

        [Column("er_debit")] 
        [ColumnDbType("decimal_strict", 0, false, "")] 
        public decimal ErDebit { get; set; }

        [Column("er_credit")] 
        [ColumnDbType("decimal_strict", 0, false, "")] 
        public decimal ErCredit { get; set; }

        [Column("cash_repository_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? CashRepositoryId { get; set; }

        [Column("posted_date")] 
        [ColumnDbType("date", 0, true, "")] 
        public DateTime? PostedDate { get; set; }

        [Column("bank_account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? BankAccountId { get; set; }

        [Column("bank_instrument_code")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string BankInstrumentCode { get; set; }

        [Column("bank_tran_code")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string BankTranCode { get; set; }

    }

    [TableName("transactions.stock_tax_details")]
    [ExplicitColumns]
    public class StockTaxDetail : PetaPocoDB.Record<StockTaxDetail> , IPoco
    {
        [Column("stock_detail_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long StockDetailId { get; set; }

        [Column("sales_tax_detail_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int SalesTaxDetailId { get; set; }

        [Column("state_sales_tax_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? StateSalesTaxId { get; set; }

        [Column("county_sales_tax_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? CountySalesTaxId { get; set; }

        [Column("principal")] 
        [ColumnDbType("money_strict", 0, false, "")] 
        public decimal Principal { get; set; }

        [Column("rate")] 
        [ColumnDbType("decimal_strict", 0, false, "")] 
        public decimal Rate { get; set; }

        [Column("tax")] 
        [ColumnDbType("money_strict", 0, false, "")] 
        public decimal Tax { get; set; }

    }

    [TableName("transactions.stock_return")]
    [PrimaryKey("sales_return_id", autoIncrement=true)]
    [ExplicitColumns]
    public class StockReturn : PetaPocoDB.Record<StockReturn> , IPoco
    {
        [Column("sales_return_id")] 
        [ColumnDbType("int8", 0, false, "nextval('transactions.stock_return_sales_return_id_seq'::regclass)")] 
        public long SalesReturnId { get; set; }

        [Column("transaction_master_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long TransactionMasterId { get; set; }

        [Column("return_transaction_master_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long ReturnTransactionMasterId { get; set; }

    }

    [TableName("transactions.non_gl_stock_tax_details")]
    [ExplicitColumns]
    public class NonGlStockTaxDetail : PetaPocoDB.Record<NonGlStockTaxDetail> , IPoco
    {
        [Column("non_gl_stock_detail_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long NonGlStockDetailId { get; set; }

        [Column("sales_tax_detail_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int SalesTaxDetailId { get; set; }

        [Column("state_sales_tax_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? StateSalesTaxId { get; set; }

        [Column("county_sales_tax_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? CountySalesTaxId { get; set; }

        [Column("principal")] 
        [ColumnDbType("money_strict", 0, false, "")] 
        public decimal Principal { get; set; }

        [Column("rate")] 
        [ColumnDbType("decimal_strict", 0, false, "")] 
        public decimal Rate { get; set; }

        [Column("tax")] 
        [ColumnDbType("money_strict", 0, false, "")] 
        public decimal Tax { get; set; }

    }

    [TableName("transactions.non_gl_stock_master_relations")]
    [PrimaryKey("non_gl_stock_master_relation_id", autoIncrement=true)]
    [ExplicitColumns]
    public class NonGlStockMasterRelation : PetaPocoDB.Record<NonGlStockMasterRelation> , IPoco
    {
        [Column("non_gl_stock_master_relation_id")] 
        [ColumnDbType("int8", 0, false, "nextval('transactions.non_gl_stock_master_relations_non_gl_stock_master_relation__seq'::regclass)")] 
        public long NonGlStockMasterRelationId { get; set; }

        [Column("order_non_gl_stock_master_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long OrderNonGlStockMasterId { get; set; }

        [Column("quotation_non_gl_stock_master_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long QuotationNonGlStockMasterId { get; set; }

    }

    [TableName("transactions.non_gl_stock_master")]
    [PrimaryKey("non_gl_stock_master_id", autoIncrement=true)]
    [ExplicitColumns]
    public class NonGlStockMaster : PetaPocoDB.Record<NonGlStockMaster> , IPoco
    {
        [Column("non_gl_stock_master_id")] 
        [ColumnDbType("int8", 0, false, "nextval('transactions.non_gl_stock_master_non_gl_stock_master_id_seq'::regclass)")] 
        public long NonGlStockMasterId { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, false, "")] 
        public DateTime ValueDate { get; set; }

        [Column("book")] 
        [ColumnDbType("varchar", 48, false, "")] 
        public string Book { get; set; }

        [Column("party_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long PartyId { get; set; }

        [Column("price_type_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? PriceTypeId { get; set; }

        [Column("transaction_ts")] 
        [ColumnDbType("timestamptz", 0, false, "")] 
        public DateTime TransactionTs { get; set; }

        [Column("login_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long LoginId { get; set; }

        [Column("user_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int UserId { get; set; }

        [Column("office_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int OfficeId { get; set; }

        [Column("reference_number")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string ReferenceNumber { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("text", 0, true, "")] 
        public string StatementReference { get; set; }

        [Column("non_taxable")] 
        [ColumnDbType("bool", 0, false, "false")] 
        public bool NonTaxable { get; set; }

        [Column("salesperson_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? SalespersonId { get; set; }

        [Column("shipper_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? ShipperId { get; set; }

        [Column("shipping_address_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? ShippingAddressId { get; set; }

        [Column("shipping_charge")] 
        [ColumnDbType("money_strict2", 0, false, "0")] 
        public decimal ShippingCharge { get; set; }

        [Column("store_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? StoreId { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("transactions.stock_master_non_gl_relations")]
    [PrimaryKey("stock_master_non_gl_relation_id", autoIncrement=true)]
    [ExplicitColumns]
    public class StockMasterNonGlRelation : PetaPocoDB.Record<StockMasterNonGlRelation> , IPoco
    {
        [Column("stock_master_non_gl_relation_id")] 
        [ColumnDbType("int8", 0, false, "nextval('transactions.stock_master_non_gl_relations_stock_master_non_gl_relation__seq'::regclass)")] 
        public long StockMasterNonGlRelationId { get; set; }

        [Column("stock_master_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long StockMasterId { get; set; }

        [Column("non_gl_stock_master_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long NonGlStockMasterId { get; set; }

    }

    [TableName("transactions.day_operation")]
    [PrimaryKey("day_id", autoIncrement=true)]
    [ExplicitColumns]
    public class DayOperation : PetaPocoDB.Record<DayOperation> , IPoco
    {
        [Column("day_id")] 
        [ColumnDbType("int8", 0, false, "nextval('transactions.day_operation_day_id_seq'::regclass)")] 
        public long DayId { get; set; }

        [Column("office_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int OfficeId { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, false, "")] 
        public DateTime ValueDate { get; set; }

        [Column("started_on")] 
        [ColumnDbType("timestamptz", 0, false, "")] 
        public DateTime StartedOn { get; set; }

        [Column("started_by")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int StartedBy { get; set; }

        [Column("completed_on")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? CompletedOn { get; set; }

        [Column("completed_by")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? CompletedBy { get; set; }

        [Column("completed")] 
        [ColumnDbType("bool", 0, false, "false")] 
        public bool Completed { get; set; }

    }

    [TableName("transactions.routines")]
    [PrimaryKey("routine_id", autoIncrement=true)]
    [ExplicitColumns]
    public class Routine : PetaPocoDB.Record<Routine> , IPoco
    {
        [Column("routine_id")] 
        [ColumnDbType("int4", 0, false, "nextval('transactions.routines_routine_id_seq'::regclass)")] 
        public int RoutineId { get; set; }

        [Column("order")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int Order { get; set; }

        [Column("routine_code")] 
        [ColumnDbType("varchar", 12, false, "")] 
        public string RoutineCode { get; set; }

        [Column("routine_name")] 
        [ColumnDbType("regproc", 0, false, "")] 
        public string RoutineName { get; set; }

        [Column("status")] 
        [ColumnDbType("bool", 0, false, "true")] 
        public bool Status { get; set; }

    }

    [TableName("transactions.day_operation_routines")]
    [PrimaryKey("day_operation_routine_id", autoIncrement=true)]
    [ExplicitColumns]
    public class DayOperationRoutine : PetaPocoDB.Record<DayOperationRoutine> , IPoco
    {
        [Column("day_operation_routine_id")] 
        [ColumnDbType("int8", 0, false, "nextval('transactions.day_operation_routines_day_operation_routine_id_seq'::regclass)")] 
        public long DayOperationRoutineId { get; set; }

        [Column("day_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long DayId { get; set; }

        [Column("routine_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int RoutineId { get; set; }

        [Column("started_on")] 
        [ColumnDbType("timestamptz", 0, false, "")] 
        public DateTime StartedOn { get; set; }

        [Column("completed_on")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? CompletedOn { get; set; }

    }

    [TableName("transactions.transaction_details")]
    [PrimaryKey("transaction_detail_id", autoIncrement=true)]
    [ExplicitColumns]
    public class TransactionDetail : PetaPocoDB.Record<TransactionDetail> , IPoco
    {
        [Column("transaction_detail_id")] 
        [ColumnDbType("int8", 0, false, "nextval('transactions.transaction_details_transaction_detail_id_seq'::regclass)")] 
        public long TransactionDetailId { get; set; }

        [Column("transaction_master_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long TransactionMasterId { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, false, "")] 
        public DateTime ValueDate { get; set; }

        [Column("tran_type")] 
        [ColumnDbType("transaction_type", 0, false, "")] 
        public string TranType { get; set; }

        [Column("account_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long AccountId { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("text", 0, true, "")] 
        public string StatementReference { get; set; }

        [Column("cash_repository_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? CashRepositoryId { get; set; }

        [Column("currency_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string CurrencyCode { get; set; }

        [Column("amount_in_currency")] 
        [ColumnDbType("money_strict", 0, false, "")] 
        public decimal AmountInCurrency { get; set; }

        [Column("local_currency_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string LocalCurrencyCode { get; set; }

        [Column("er")] 
        [ColumnDbType("decimal_strict", 0, false, "")] 
        public decimal Er { get; set; }

        [Column("amount_in_local_currency")] 
        [ColumnDbType("money_strict", 0, false, "")] 
        public decimal AmountInLocalCurrency { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("transactions.stock_details")]
    [PrimaryKey("stock_detail_id", autoIncrement=true)]
    [ExplicitColumns]
    public class StockDetail : PetaPocoDB.Record<StockDetail> , IPoco
    {
        [Column("stock_detail_id")] 
        [ColumnDbType("int8", 0, false, "nextval('transactions.stock_details_stock_detail_id_seq'::regclass)")] 
        public long StockDetailId { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, false, "")] 
        public DateTime ValueDate { get; set; }

        [Column("stock_master_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long StockMasterId { get; set; }

        [Column("tran_type")] 
        [ColumnDbType("transaction_type", 0, false, "")] 
        public string TranType { get; set; }

        [Column("store_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? StoreId { get; set; }

        [Column("item_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int ItemId { get; set; }

        [Column("quantity")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int Quantity { get; set; }

        [Column("unit_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int UnitId { get; set; }

        [Column("base_quantity")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal BaseQuantity { get; set; }

        [Column("base_unit_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int BaseUnitId { get; set; }

        [Column("price")] 
        [ColumnDbType("money_strict", 0, false, "")] 
        public decimal Price { get; set; }

        [Column("cost_of_goods_sold")] 
        [ColumnDbType("money_strict2", 0, false, "0")] 
        public decimal CostOfGoodsSold { get; set; }

        [Column("discount")] 
        [ColumnDbType("money_strict2", 0, false, "0")] 
        public decimal Discount { get; set; }

        [Column("shipping_charge")] 
        [ColumnDbType("money_strict2", 0, false, "0")] 
        public decimal ShippingCharge { get; set; }

        [Column("sales_tax_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? SalesTaxId { get; set; }

        [Column("tax")] 
        [ColumnDbType("money_strict2", 0, false, "0")] 
        public decimal Tax { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("transactions.non_gl_stock_details")]
    [PrimaryKey("non_gl_stock_detail_id", autoIncrement=true)]
    [ExplicitColumns]
    public class NonGlStockDetail : PetaPocoDB.Record<NonGlStockDetail> , IPoco
    {
        [Column("non_gl_stock_detail_id")] 
        [ColumnDbType("int8", 0, false, "nextval('transactions.non_gl_stock_details_non_gl_stock_detail_id_seq'::regclass)")] 
        public long NonGlStockDetailId { get; set; }

        [Column("non_gl_stock_master_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long NonGlStockMasterId { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, false, "")] 
        public DateTime ValueDate { get; set; }

        [Column("item_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int ItemId { get; set; }

        [Column("quantity")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int Quantity { get; set; }

        [Column("unit_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int UnitId { get; set; }

        [Column("base_quantity")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal BaseQuantity { get; set; }

        [Column("base_unit_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int BaseUnitId { get; set; }

        [Column("price")] 
        [ColumnDbType("money_strict", 0, false, "")] 
        public decimal Price { get; set; }

        [Column("discount")] 
        [ColumnDbType("money_strict2", 0, false, "0")] 
        public decimal Discount { get; set; }

        [Column("shipping_charge")] 
        [ColumnDbType("money_strict2", 0, false, "0")] 
        public decimal ShippingCharge { get; set; }

        [Column("sales_tax_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? SalesTaxId { get; set; }

        [Column("tax")] 
        [ColumnDbType("money_strict2", 0, false, "0")] 
        public decimal Tax { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("transactions.stock_master")]
    [PrimaryKey("stock_master_id", autoIncrement=true)]
    [ExplicitColumns]
    public class StockMaster : PetaPocoDB.Record<StockMaster> , IPoco
    {
        [Column("stock_master_id")] 
        [ColumnDbType("int8", 0, false, "nextval('transactions.stock_master_stock_master_id_seq'::regclass)")] 
        public long StockMasterId { get; set; }

        [Column("transaction_master_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long TransactionMasterId { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, false, "")] 
        public DateTime ValueDate { get; set; }

        [Column("party_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? PartyId { get; set; }

        [Column("salesperson_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? SalespersonId { get; set; }

        [Column("price_type_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? PriceTypeId { get; set; }

        [Column("is_credit")] 
        [ColumnDbType("bool", 0, false, "false")] 
        public bool IsCredit { get; set; }

        [Column("payment_term_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? PaymentTermId { get; set; }

        [Column("shipper_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? ShipperId { get; set; }

        [Column("shipping_address_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? ShippingAddressId { get; set; }

        [Column("shipping_charge")] 
        [ColumnDbType("money_strict2", 0, false, "0")] 
        public decimal ShippingCharge { get; set; }

        [Column("store_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? StoreId { get; set; }

        [Column("non_taxable")] 
        [ColumnDbType("bool", 0, false, "false")] 
        public bool NonTaxable { get; set; }

        [Column("cash_repository_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? CashRepositoryId { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

        [Column("credit_settled")] 
        [ColumnDbType("bool", 0, true, "false")] 
        public bool? CreditSettled { get; set; }

    }

    [TableName("transactions.late_fee")]
    [PrimaryKey("transaction_master_id", autoIncrement=false)]
    [ExplicitColumns]
    public class LateFee : PetaPocoDB.Record<LateFee> , IPoco
    {
        [Column("transaction_master_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long TransactionMasterId { get; set; }

        [Column("party_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long PartyId { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, false, "")] 
        public DateTime ValueDate { get; set; }

        [Column("late_fee_tran_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long LateFeeTranId { get; set; }

        [Column("amount")] 
        [ColumnDbType("money_strict", 0, true, "")] 
        public decimal? Amount { get; set; }

    }

    [TableName("transactions.inventory_transfer_request_details")]
    [PrimaryKey("inventory_transfer_request_detail_id", autoIncrement=true)]
    [ExplicitColumns]
    public class InventoryTransferRequestDetail : PetaPocoDB.Record<InventoryTransferRequestDetail> , IPoco
    {
        [Column("inventory_transfer_request_detail_id")] 
        [ColumnDbType("int8", 0, false, "nextval('inventory_transfer_request_de_inventory_transfer_request_de_seq'::regclass)")] 
        public long InventoryTransferRequestDetailId { get; set; }

        [Column("inventory_transfer_request_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long InventoryTransferRequestId { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, false, "")] 
        public DateTime ValueDate { get; set; }

        [Column("item_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int ItemId { get; set; }

        [Column("quantity")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int Quantity { get; set; }

        [Column("unit_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int UnitId { get; set; }

        [Column("base_quantity")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal BaseQuantity { get; set; }

        [Column("base_unit_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int BaseUnitId { get; set; }

    }

    [TableName("transactions.inventory_transfer_requests")]
    [PrimaryKey("inventory_transfer_request_id", autoIncrement=true)]
    [ExplicitColumns]
    public class InventoryTransferRequest : PetaPocoDB.Record<InventoryTransferRequest> , IPoco
    {
        [Column("inventory_transfer_request_id")] 
        [ColumnDbType("int8", 0, false, "nextval('inventory_transfer_requests_inventory_transfer_request_id_seq'::regclass)")] 
        public long InventoryTransferRequestId { get; set; }

        [Column("office_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int OfficeId { get; set; }

        [Column("user_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int UserId { get; set; }

        [Column("login_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long LoginId { get; set; }

        [Column("store_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int StoreId { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, false, "")] 
        public DateTime ValueDate { get; set; }

        [Column("transaction_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? TransactionTs { get; set; }

        [Column("reference_number")] 
        [ColumnDbType("varchar", 24, false, "")] 
        public string ReferenceNumber { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("text", 0, true, "")] 
        public string StatementReference { get; set; }

        [Column("authorization_status_id")] 
        [ColumnDbType("int2", 0, false, "0")] 
        public short AuthorizationStatusId { get; set; }

        [Column("authorized_by_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuthorizedByUserId { get; set; }

        [Column("authorized_on")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuthorizedOn { get; set; }

        [Column("authorization_reason")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string AuthorizationReason { get; set; }

        [Column("received")] 
        [ColumnDbType("bool", 0, false, "false")] 
        public bool Received { get; set; }

        [Column("received_by_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? ReceivedByUserId { get; set; }

        [Column("received_on")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? ReceivedOn { get; set; }

        [Column("delivered")] 
        [ColumnDbType("bool", 0, false, "false")] 
        public bool Delivered { get; set; }

        [Column("delivered_by_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? DeliveredByUserId { get; set; }

        [Column("delivered_on")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? DeliveredOn { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("transactions.inventory_transfer_deliveries")]
    [PrimaryKey("inventory_transfer_delivery_id", autoIncrement=true)]
    [ExplicitColumns]
    public class InventoryTransferDelivery : PetaPocoDB.Record<InventoryTransferDelivery> , IPoco
    {
        [Column("inventory_transfer_delivery_id")] 
        [ColumnDbType("int8", 0, false, "nextval('inventory_transfer_deliveries_inventory_transfer_delivery_i_seq'::regclass)")] 
        public long InventoryTransferDeliveryId { get; set; }

        [Column("inventory_transfer_request_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long InventoryTransferRequestId { get; set; }

        [Column("office_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int OfficeId { get; set; }

        [Column("user_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int UserId { get; set; }

        [Column("login_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long LoginId { get; set; }

        [Column("source_store_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int SourceStoreId { get; set; }

        [Column("destination_store_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int DestinationStoreId { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, false, "")] 
        public DateTime ValueDate { get; set; }

        [Column("transaction_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? TransactionTs { get; set; }

        [Column("reference_number")] 
        [ColumnDbType("varchar", 24, false, "")] 
        public string ReferenceNumber { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("text", 0, true, "")] 
        public string StatementReference { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("transactions.inventory_transfer_delivery_details")]
    [PrimaryKey("inventory_transfer_delivery_detail_id", autoIncrement=true)]
    [ExplicitColumns]
    public class InventoryTransferDeliveryDetail : PetaPocoDB.Record<InventoryTransferDeliveryDetail> , IPoco
    {
        [Column("inventory_transfer_delivery_detail_id")] 
        [ColumnDbType("int8", 0, false, "nextval('inventory_transfer_delivery_d_inventory_transfer_delivery_d_seq'::regclass)")] 
        public long InventoryTransferDeliveryDetailId { get; set; }

        [Column("inventory_transfer_delivery_id")] 
        [ColumnDbType("int8", 0, false, "")] 
        public long InventoryTransferDeliveryId { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, false, "")] 
        public DateTime ValueDate { get; set; }

        [Column("item_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int ItemId { get; set; }

        [Column("quantity")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int Quantity { get; set; }

        [Column("unit_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int UnitId { get; set; }

        [Column("base_quantity")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal BaseQuantity { get; set; }

        [Column("base_unit_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int BaseUnitId { get; set; }

    }

    [TableName("transactions.transaction_view")]
    [ExplicitColumns]
    public class TransactionView : PetaPocoDB.Record<TransactionView> , IPoco
    {
        [Column("transaction_master_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? TransactionMasterId { get; set; }

        [Column("transaction_counter")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? TransactionCounter { get; set; }

        [Column("transaction_code")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string TransactionCode { get; set; }

        [Column("book")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string Book { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, true, "")] 
        public DateTime? ValueDate { get; set; }

        [Column("transaction_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? TransactionTs { get; set; }

        [Column("login_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? LoginId { get; set; }

        [Column("user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? UserId { get; set; }

        [Column("sys_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? SysUserId { get; set; }

        [Column("office_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? OfficeId { get; set; }

        [Column("cost_center_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? CostCenterId { get; set; }

        [Column("reference_number")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string ReferenceNumber { get; set; }

        [Column("master_statement_reference")] 
        [ColumnDbType("text", 0, true, "")] 
        public string MasterStatementReference { get; set; }

        [Column("last_verified_on")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? LastVerifiedOn { get; set; }

        [Column("verified_by_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? VerifiedByUserId { get; set; }

        [Column("verification_status_id")] 
        [ColumnDbType("int2", 0, true, "")] 
        public short? VerificationStatusId { get; set; }

        [Column("verification_reason")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string VerificationReason { get; set; }

        [Column("transaction_detail_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? TransactionDetailId { get; set; }

        [Column("tran_type")] 
        [ColumnDbType("transaction_type", 0, true, "")] 
        public string TranType { get; set; }

        [Column("account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? AccountId { get; set; }

        [Column("account_number")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string AccountNumber { get; set; }

        [Column("account_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string AccountName { get; set; }

        [Column("normally_debit")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? NormallyDebit { get; set; }

        [Column("account_master_code")] 
        [ColumnDbType("varchar", 3, true, "")] 
        public string AccountMasterCode { get; set; }

        [Column("account_master_name")] 
        [ColumnDbType("varchar", 40, true, "")] 
        public string AccountMasterName { get; set; }

        [Column("account_master_id")] 
        [ColumnDbType("int2", 0, true, "")] 
        public short? AccountMasterId { get; set; }

        [Column("confidential")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? Confidential { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("text", 0, true, "")] 
        public string StatementReference { get; set; }

        [Column("cash_repository_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? CashRepositoryId { get; set; }

        [Column("currency_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string CurrencyCode { get; set; }

        [Column("amount_in_currency")] 
        [ColumnDbType("money_strict", 0, true, "")] 
        public decimal? AmountInCurrency { get; set; }

        [Column("local_currency_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string LocalCurrencyCode { get; set; }

        [Column("amount_in_local_currency")] 
        [ColumnDbType("money_strict", 0, true, "")] 
        public decimal? AmountInLocalCurrency { get; set; }

    }

    [TableName("transactions.verified_transaction_view")]
    [ExplicitColumns]
    public class VerifiedTransactionView : PetaPocoDB.Record<VerifiedTransactionView> , IPoco
    {
        [Column("transaction_master_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? TransactionMasterId { get; set; }

        [Column("transaction_counter")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? TransactionCounter { get; set; }

        [Column("transaction_code")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string TransactionCode { get; set; }

        [Column("book")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string Book { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, true, "")] 
        public DateTime? ValueDate { get; set; }

        [Column("transaction_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? TransactionTs { get; set; }

        [Column("login_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? LoginId { get; set; }

        [Column("user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? UserId { get; set; }

        [Column("sys_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? SysUserId { get; set; }

        [Column("office_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? OfficeId { get; set; }

        [Column("cost_center_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? CostCenterId { get; set; }

        [Column("reference_number")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string ReferenceNumber { get; set; }

        [Column("master_statement_reference")] 
        [ColumnDbType("text", 0, true, "")] 
        public string MasterStatementReference { get; set; }

        [Column("last_verified_on")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? LastVerifiedOn { get; set; }

        [Column("verified_by_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? VerifiedByUserId { get; set; }

        [Column("verification_status_id")] 
        [ColumnDbType("int2", 0, true, "")] 
        public short? VerificationStatusId { get; set; }

        [Column("verification_reason")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string VerificationReason { get; set; }

        [Column("transaction_detail_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? TransactionDetailId { get; set; }

        [Column("tran_type")] 
        [ColumnDbType("transaction_type", 0, true, "")] 
        public string TranType { get; set; }

        [Column("account_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? AccountId { get; set; }

        [Column("account_number")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string AccountNumber { get; set; }

        [Column("account_name")] 
        [ColumnDbType("varchar", 100, true, "")] 
        public string AccountName { get; set; }

        [Column("normally_debit")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? NormallyDebit { get; set; }

        [Column("account_master_code")] 
        [ColumnDbType("varchar", 3, true, "")] 
        public string AccountMasterCode { get; set; }

        [Column("account_master_name")] 
        [ColumnDbType("varchar", 40, true, "")] 
        public string AccountMasterName { get; set; }

        [Column("account_master_id")] 
        [ColumnDbType("int2", 0, true, "")] 
        public short? AccountMasterId { get; set; }

        [Column("confidential")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? Confidential { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("text", 0, true, "")] 
        public string StatementReference { get; set; }

        [Column("cash_repository_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? CashRepositoryId { get; set; }

        [Column("currency_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string CurrencyCode { get; set; }

        [Column("amount_in_currency")] 
        [ColumnDbType("money_strict", 0, true, "")] 
        public decimal? AmountInCurrency { get; set; }

        [Column("local_currency_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string LocalCurrencyCode { get; set; }

        [Column("amount_in_local_currency")] 
        [ColumnDbType("money_strict", 0, true, "")] 
        public decimal? AmountInLocalCurrency { get; set; }

    }

    [TableName("transactions.stock_transaction_view")]
    [ExplicitColumns]
    public class StockTransactionView : PetaPocoDB.Record<StockTransactionView> , IPoco
    {
        [Column("transaction_master_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? TransactionMasterId { get; set; }

        [Column("stock_master_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? StockMasterId { get; set; }

        [Column("stock_detail_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? StockDetailId { get; set; }

        [Column("book")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string Book { get; set; }

        [Column("transaction_counter")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? TransactionCounter { get; set; }

        [Column("transaction_code")] 
        [ColumnDbType("varchar", 50, true, "")] 
        public string TransactionCode { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, true, "")] 
        public DateTime? ValueDate { get; set; }

        [Column("transaction_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? TransactionTs { get; set; }

        [Column("login_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? LoginId { get; set; }

        [Column("user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? UserId { get; set; }

        [Column("sys_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? SysUserId { get; set; }

        [Column("office_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? OfficeId { get; set; }

        [Column("cost_center_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? CostCenterId { get; set; }

        [Column("reference_number")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string ReferenceNumber { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("text", 0, true, "")] 
        public string StatementReference { get; set; }

        [Column("last_verified_on")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? LastVerifiedOn { get; set; }

        [Column("verified_by_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? VerifiedByUserId { get; set; }

        [Column("verification_status_id")] 
        [ColumnDbType("int2", 0, true, "")] 
        public short? VerificationStatusId { get; set; }

        [Column("verification_reason")] 
        [ColumnDbType("varchar", 128, true, "")] 
        public string VerificationReason { get; set; }

        [Column("party_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? PartyId { get; set; }

        [Column("country_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? CountryId { get; set; }

        [Column("state_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? StateId { get; set; }

        [Column("salesperson_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? SalespersonId { get; set; }

        [Column("price_type_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? PriceTypeId { get; set; }

        [Column("is_credit")] 
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsCredit { get; set; }

        [Column("shipper_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? ShipperId { get; set; }

        [Column("shipping_address_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? ShippingAddressId { get; set; }

        [Column("shipping_charge")] 
        [ColumnDbType("money_strict2", 0, true, "")] 
        public decimal? ShippingCharge { get; set; }

        [Column("stock_master_store_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? StockMasterStoreId { get; set; }

        [Column("cash_repository_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? CashRepositoryId { get; set; }

        [Column("tran_type")] 
        [ColumnDbType("transaction_type", 0, true, "")] 
        public string TranType { get; set; }

        [Column("store_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? StoreId { get; set; }

        [Column("item_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? ItemId { get; set; }

        [Column("quantity")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? Quantity { get; set; }

        [Column("unit_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? UnitId { get; set; }

        [Column("base_quantity")] 
        [ColumnDbType("numeric", 0, true, "")] 
        public decimal? BaseQuantity { get; set; }

        [Column("base_unit_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? BaseUnitId { get; set; }

        [Column("price")] 
        [ColumnDbType("money_strict", 0, true, "")] 
        public decimal? Price { get; set; }

        [Column("discount")] 
        [ColumnDbType("money_strict2", 0, true, "")] 
        public decimal? Discount { get; set; }

        [Column("sales_tax_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? SalesTaxId { get; set; }

        [Column("tax")] 
        [ColumnDbType("money_strict2", 0, true, "")] 
        public decimal? Tax { get; set; }

        [Column("amount")] 
        [ColumnDbType("numeric", 0, true, "")] 
        public decimal? Amount { get; set; }

    }

    [TableName("transactions.sales_by_country_view")]
    [ExplicitColumns]
    public class SalesByCountryView : PetaPocoDB.Record<SalesByCountryView> , IPoco
    {
        [Column("country_code")] 
        [ColumnDbType("varchar", 12, true, "")] 
        public string CountryCode { get; set; }

        [Column("sales")] 
        [ColumnDbType("numeric", 0, true, "")] 
        public decimal? Sales { get; set; }

    }

    [TableName("transactions.verified_stock_details_view")]
    [ExplicitColumns]
    public class VerifiedStockDetailsView : PetaPocoDB.Record<VerifiedStockDetailsView> , IPoco
    {
        [Column("stock_detail_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? StockDetailId { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, true, "")] 
        public DateTime? ValueDate { get; set; }

        [Column("stock_master_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? StockMasterId { get; set; }

        [Column("tran_type")] 
        [ColumnDbType("transaction_type", 0, true, "")] 
        public string TranType { get; set; }

        [Column("store_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? StoreId { get; set; }

        [Column("item_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? ItemId { get; set; }

        [Column("quantity")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? Quantity { get; set; }

        [Column("unit_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? UnitId { get; set; }

        [Column("base_quantity")] 
        [ColumnDbType("numeric", 0, true, "")] 
        public decimal? BaseQuantity { get; set; }

        [Column("base_unit_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? BaseUnitId { get; set; }

        [Column("price")] 
        [ColumnDbType("money_strict", 0, true, "")] 
        public decimal? Price { get; set; }

        [Column("cost_of_goods_sold")] 
        [ColumnDbType("money_strict2", 0, true, "")] 
        public decimal? CostOfGoodsSold { get; set; }

        [Column("discount")] 
        [ColumnDbType("money_strict2", 0, true, "")] 
        public decimal? Discount { get; set; }

        [Column("shipping_charge")] 
        [ColumnDbType("money_strict2", 0, true, "")] 
        public decimal? ShippingCharge { get; set; }

        [Column("sales_tax_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? SalesTaxId { get; set; }

        [Column("tax")] 
        [ColumnDbType("money_strict2", 0, true, "")] 
        public decimal? Tax { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("transactions.transaction_master")]
    [PrimaryKey("transaction_master_id", autoIncrement=true)]
    [ExplicitColumns]
    public class TransactionMaster : PetaPocoDB.Record<TransactionMaster> , IPoco
    {
        [Column("transaction_master_id")] 
        [ColumnDbType("int8", 0, false, "nextval('transactions.transaction_master_transaction_master_id_seq'::regclass)")] 
        public long TransactionMasterId { get; set; }

        [Column("transaction_counter")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int TransactionCounter { get; set; }

        [Column("transaction_code")] 
        [ColumnDbType("varchar", 50, false, "")] 
        public string TransactionCode { get; set; }

        [Column("book")] 
        [ColumnDbType("varchar", 50, false, "")] 
        public string Book { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, false, "")] 
        public DateTime ValueDate { get; set; }

        [Column("transaction_ts")] 
        [ColumnDbType("timestamptz", 0, false, "")] 
        public DateTime TransactionTs { get; set; }

        [Column("login_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? LoginId { get; set; }

        [Column("user_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int UserId { get; set; }

        [Column("sys_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? SysUserId { get; set; }

        [Column("office_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int OfficeId { get; set; }

        [Column("cost_center_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? CostCenterId { get; set; }

        [Column("reference_number")] 
        [ColumnDbType("varchar", 24, true, "")] 
        public string ReferenceNumber { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("text", 0, true, "")] 
        public string StatementReference { get; set; }

        [Column("last_verified_on")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? LastVerifiedOn { get; set; }

        [Column("verified_by_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? VerifiedByUserId { get; set; }

        [Column("verification_status_id")] 
        [ColumnDbType("int2", 0, false, "0")] 
        public short VerificationStatusId { get; set; }

        [Column("verification_reason")] 
        [ColumnDbType("varchar", 128, false, "")] 
        public string VerificationReason { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }

        [Column("cascading_tran_id")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? CascadingTranId { get; set; }

        [Column("book_date")] 
        [ColumnDbType("date", 0, false, "")] 
        public DateTime BookDate { get; set; }

    }

    [FunctionName("get_pl_appropriation_data")]
    [ExplicitColumns]
    public class DbGetPlAppropriationDataResult : PetaPocoDB.Record<DbGetPlAppropriationDataResult> , IPoco
    {
        [Column("account_id")] 
        [ColumnDbType("bigint", 0, false, "")] 
        public long AccountId { get; set; }

        [Column("account_number")] 
        [ColumnDbType("text", 0, false, "")] 
        public string AccountNumber { get; set; }

        [Column("account_name")] 
        [ColumnDbType("text", 0, false, "")] 
        public string AccountName { get; set; }

        [Column("debit")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal Debit { get; set; }

        [Column("credit")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal Credit { get; set; }

    }

    [FunctionName("get_journal_view")]
    [ExplicitColumns]
    public class DbGetJournalViewResult : PetaPocoDB.Record<DbGetJournalViewResult> , IPoco
    {
        [Column("transaction_master_id")] 
        [ColumnDbType("bigint", 0, false, "")] 
        public long TransactionMasterId { get; set; }

        [Column("transaction_code")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string TransactionCode { get; set; }

        [Column("book")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string Book { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, false, "")] 
        public DateTime ValueDate { get; set; }

        [Column("reference_number")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string ReferenceNumber { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("text", 0, false, "")] 
        public string StatementReference { get; set; }

        [Column("posted_by")] 
        [ColumnDbType("text", 0, false, "")] 
        public string PostedBy { get; set; }

        [Column("office")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Office { get; set; }

        [Column("status")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Status { get; set; }

        [Column("verified_by")] 
        [ColumnDbType("text", 0, false, "")] 
        public string VerifiedBy { get; set; }

        [Column("verified_on")] 
        [ColumnDbType("timestamp with time zone", 0, false, "")] 
        public DateTime VerifiedOn { get; set; }

        [Column("reason")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string Reason { get; set; }

        [Column("transaction_ts")] 
        [ColumnDbType("timestamp with time zone", 0, false, "")] 
        public DateTime TransactionTs { get; set; }

        [Column("flag_bg")] 
        [ColumnDbType("text", 0, false, "")] 
        public string FlagBg { get; set; }

        [Column("flag_fg")] 
        [ColumnDbType("text", 0, false, "")] 
        public string FlagFg { get; set; }

    }

    [FunctionName("get_stock_account_statement")]
    [ExplicitColumns]
    public class DbGetStockAccountStatementResult : PetaPocoDB.Record<DbGetStockAccountStatementResult> , IPoco
    {
        [Column("id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int Id { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, false, "")] 
        public DateTime ValueDate { get; set; }

        [Column("tran_code")] 
        [ColumnDbType("text", 0, false, "")] 
        public string TranCode { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("text", 0, false, "")] 
        public string StatementReference { get; set; }

        [Column("debit")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal Debit { get; set; }

        [Column("credit")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal Credit { get; set; }

        [Column("balance")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal Balance { get; set; }

        [Column("book")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Book { get; set; }

        [Column("item_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int ItemId { get; set; }

        [Column("item_code")] 
        [ColumnDbType("text", 0, false, "")] 
        public string ItemCode { get; set; }

        [Column("item_name")] 
        [ColumnDbType("text", 0, false, "")] 
        public string ItemName { get; set; }

        [Column("posted_on")] 
        [ColumnDbType("timestamp with time zone", 0, false, "")] 
        public DateTime PostedOn { get; set; }

        [Column("posted_by")] 
        [ColumnDbType("text", 0, false, "")] 
        public string PostedBy { get; set; }

        [Column("approved_by")] 
        [ColumnDbType("text", 0, false, "")] 
        public string ApprovedBy { get; set; }

        [Column("verification_status")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int VerificationStatus { get; set; }

        [Column("flag_bg")] 
        [ColumnDbType("text", 0, false, "")] 
        public string FlagBg { get; set; }

        [Column("flag_fg")] 
        [ColumnDbType("text", 0, false, "")] 
        public string FlagFg { get; set; }

    }

    [FunctionName("get_sales_by_offices")]
    [ExplicitColumns]
    public class DbGetSalesByOfficesResult : PetaPocoDB.Record<DbGetSalesByOfficesResult> , IPoco
    {
        [Column("office")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Office { get; set; }

        [Column("jan")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal Jan { get; set; }

        [Column("feb")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal Feb { get; set; }

        [Column("mar")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal Mar { get; set; }

        [Column("apr")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal Apr { get; set; }

        [Column("may")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal May { get; set; }

        [Column("jun")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal Jun { get; set; }

        [Column("jul")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal Jul { get; set; }

        [Column("aug")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal Aug { get; set; }

        [Column("sep")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal Sep { get; set; }

        [Column("oct")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal Oct { get; set; }

        [Column("nov")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal Nov { get; set; }

        [Column("dec")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal Dec { get; set; }

    }

    [FunctionName("get_product_view")]
    [ExplicitColumns]
    public class DbGetProductViewResult : PetaPocoDB.Record<DbGetProductViewResult> , IPoco
    {
        [Column("id")] 
        [ColumnDbType("bigint", 0, false, "")] 
        public long Id { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, false, "")] 
        public DateTime ValueDate { get; set; }

        [Column("office")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string Office { get; set; }

        [Column("party")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Party { get; set; }

        [Column("price_type")] 
        [ColumnDbType("text", 0, false, "")] 
        public string PriceType { get; set; }

        [Column("amount")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal Amount { get; set; }

        [Column("transaction_ts")] 
        [ColumnDbType("timestamp with time zone", 0, false, "")] 
        public DateTime TransactionTs { get; set; }

        [Column("user")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string User { get; set; }

        [Column("reference_number")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string ReferenceNumber { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("text", 0, false, "")] 
        public string StatementReference { get; set; }

        [Column("book")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Book { get; set; }

        [Column("salesperson")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Salesperson { get; set; }

        [Column("is_credit")] 
        [ColumnDbType("boolean", 0, false, "")] 
        public bool IsCredit { get; set; }

        [Column("shipper")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Shipper { get; set; }

        [Column("shipping_address_code")] 
        [ColumnDbType("text", 0, false, "")] 
        public string ShippingAddressCode { get; set; }

        [Column("store")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Store { get; set; }

        [Column("flag_background_color")] 
        [ColumnDbType("text", 0, false, "")] 
        public string FlagBackgroundColor { get; set; }

        [Column("flag_foreground_color")] 
        [ColumnDbType("text", 0, false, "")] 
        public string FlagForegroundColor { get; set; }

    }

    [FunctionName("get_trial_balance")]
    [ExplicitColumns]
    public class DbGetTrialBalanceResult : PetaPocoDB.Record<DbGetTrialBalanceResult> , IPoco
    {
        [Column("id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int Id { get; set; }

        [Column("account_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int AccountId { get; set; }

        [Column("account_number")] 
        [ColumnDbType("text", 0, false, "")] 
        public string AccountNumber { get; set; }

        [Column("account")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Account { get; set; }

        [Column("previous_debit")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal PreviousDebit { get; set; }

        [Column("previous_credit")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal PreviousCredit { get; set; }

        [Column("debit")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal Debit { get; set; }

        [Column("credit")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal Credit { get; set; }

        [Column("closing_debit")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal ClosingDebit { get; set; }

        [Column("closing_credit")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal ClosingCredit { get; set; }

    }

    [FunctionName("get_eoy_profit_summary")]
    [ExplicitColumns]
    public class DbGetEoyProfitSummaryResult : PetaPocoDB.Record<DbGetEoyProfitSummaryResult> , IPoco
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

    [FunctionName("get_balance_sheet")]
    [ExplicitColumns]
    public class DbGetBalanceSheetResult : PetaPocoDB.Record<DbGetBalanceSheetResult> , IPoco
    {
        [Column("id")] 
        [ColumnDbType("bigint", 0, false, "")] 
        public long Id { get; set; }

        [Column("item")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Item { get; set; }

        [Column("previous_period")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal PreviousPeriod { get; set; }

        [Column("current_period")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal CurrentPeriod { get; set; }

        [Column("account_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int AccountId { get; set; }

        [Column("account_number")] 
        [ColumnDbType("text", 0, false, "")] 
        public string AccountNumber { get; set; }

        [Column("is_retained_earning")] 
        [ColumnDbType("boolean", 0, false, "")] 
        public bool IsRetainedEarning { get; set; }

    }

    [FunctionName("get_reorder_view_function")]
    [ExplicitColumns]
    public class DbGetReorderViewFunctionResult : PetaPocoDB.Record<DbGetReorderViewFunctionResult> , IPoco
    {
        [Column("item_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int ItemId { get; set; }

        [Column("item_code")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string ItemCode { get; set; }

        [Column("item_name")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string ItemName { get; set; }

        [Column("unit_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int UnitId { get; set; }

        [Column("unit")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Unit { get; set; }

        [Column("quantity_on_hand")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal QuantityOnHand { get; set; }

        [Column("reorder_level")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int ReorderLevel { get; set; }

        [Column("reorder_quantity")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int ReorderQuantity { get; set; }

        [Column("preferred_supplier_id")] 
        [ColumnDbType("bigint", 0, false, "")] 
        public long PreferredSupplierId { get; set; }

        [Column("preferred_supplier")] 
        [ColumnDbType("text", 0, false, "")] 
        public string PreferredSupplier { get; set; }

        [Column("price")] 
        [ColumnDbType("money_strict2", 0, false, "")] 
        public decimal Price { get; set; }

    }

    [FunctionName("list_closing_stock")]
    [ExplicitColumns]
    public class DbListClosingStockResult : PetaPocoDB.Record<DbListClosingStockResult> , IPoco
    {
        [Column("item_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int ItemId { get; set; }

        [Column("item_code")] 
        [ColumnDbType("text", 0, false, "")] 
        public string ItemCode { get; set; }

        [Column("item_name")] 
        [ColumnDbType("text", 0, false, "")] 
        public string ItemName { get; set; }

        [Column("unit_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int UnitId { get; set; }

        [Column("unit_name")] 
        [ColumnDbType("text", 0, false, "")] 
        public string UnitName { get; set; }

        [Column("quantity")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int Quantity { get; set; }

    }

    [FunctionName("get_retained_earnings_statement")]
    [ExplicitColumns]
    public class DbGetRetainedEarningsStatementResult : PetaPocoDB.Record<DbGetRetainedEarningsStatementResult> , IPoco
    {
        [Column("id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int Id { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, false, "")] 
        public DateTime ValueDate { get; set; }

        [Column("tran_code")] 
        [ColumnDbType("text", 0, false, "")] 
        public string TranCode { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("text", 0, false, "")] 
        public string StatementReference { get; set; }

        [Column("debit")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal Debit { get; set; }

        [Column("credit")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal Credit { get; set; }

        [Column("balance")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal Balance { get; set; }

        [Column("office")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Office { get; set; }

        [Column("book")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Book { get; set; }

        [Column("account_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int AccountId { get; set; }

        [Column("account_number")] 
        [ColumnDbType("text", 0, false, "")] 
        public string AccountNumber { get; set; }

        [Column("account")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Account { get; set; }

        [Column("posted_on")] 
        [ColumnDbType("timestamp with time zone", 0, false, "")] 
        public DateTime PostedOn { get; set; }

        [Column("posted_by")] 
        [ColumnDbType("text", 0, false, "")] 
        public string PostedBy { get; set; }

        [Column("approved_by")] 
        [ColumnDbType("text", 0, false, "")] 
        public string ApprovedBy { get; set; }

        [Column("verification_status")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int VerificationStatus { get; set; }

    }

    [FunctionName("get_top_selling_products_by_office")]
    [ExplicitColumns]
    public class DbGetTopSellingProductsByOfficeResult : PetaPocoDB.Record<DbGetTopSellingProductsByOfficeResult> , IPoco
    {
        [Column("id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int Id { get; set; }

        [Column("office_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int OfficeId { get; set; }

        [Column("office_code")] 
        [ColumnDbType("text", 0, false, "")] 
        public string OfficeCode { get; set; }

        [Column("office_name")] 
        [ColumnDbType("text", 0, false, "")] 
        public string OfficeName { get; set; }

        [Column("item_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int ItemId { get; set; }

        [Column("item_code")] 
        [ColumnDbType("text", 0, false, "")] 
        public string ItemCode { get; set; }

        [Column("item_name")] 
        [ColumnDbType("text", 0, false, "")] 
        public string ItemName { get; set; }

        [Column("total_sales")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal TotalSales { get; set; }

    }

    [FunctionName("get_top_selling_products_of_all_time")]
    [ExplicitColumns]
    public class DbGetTopSellingProductsOfAllTimeResult : PetaPocoDB.Record<DbGetTopSellingProductsOfAllTimeResult> , IPoco
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

        [Column("total_sales")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal TotalSales { get; set; }

    }

    [FunctionName("get_account_statement")]
    [ExplicitColumns]
    public class DbGetAccountStatementResult : PetaPocoDB.Record<DbGetAccountStatementResult> , IPoco
    {
        [Column("id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int Id { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, false, "")] 
        public DateTime ValueDate { get; set; }

        [Column("book_date")] 
        [ColumnDbType("date", 0, false, "")] 
        public DateTime BookDate { get; set; }

        [Column("tran_code")] 
        [ColumnDbType("text", 0, false, "")] 
        public string TranCode { get; set; }

        [Column("reference_number")] 
        [ColumnDbType("text", 0, false, "")] 
        public string ReferenceNumber { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("text", 0, false, "")] 
        public string StatementReference { get; set; }

        [Column("debit")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal Debit { get; set; }

        [Column("credit")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal Credit { get; set; }

        [Column("balance")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal Balance { get; set; }

        [Column("office")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Office { get; set; }

        [Column("book")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Book { get; set; }

        [Column("account_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int AccountId { get; set; }

        [Column("account_number")] 
        [ColumnDbType("text", 0, false, "")] 
        public string AccountNumber { get; set; }

        [Column("account")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Account { get; set; }

        [Column("posted_on")] 
        [ColumnDbType("timestamp with time zone", 0, false, "")] 
        public DateTime PostedOn { get; set; }

        [Column("posted_by")] 
        [ColumnDbType("text", 0, false, "")] 
        public string PostedBy { get; set; }

        [Column("approved_by")] 
        [ColumnDbType("text", 0, false, "")] 
        public string ApprovedBy { get; set; }

        [Column("verification_status")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int VerificationStatus { get; set; }

        [Column("flag_bg")] 
        [ColumnDbType("text", 0, false, "")] 
        public string FlagBg { get; set; }

        [Column("flag_fg")] 
        [ColumnDbType("text", 0, false, "")] 
        public string FlagFg { get; set; }

    }

    [FunctionName("get_salesperson_report")]
    [ExplicitColumns]
    public class DbGetSalespersonReportResult : PetaPocoDB.Record<DbGetSalespersonReportResult> , IPoco
    {
        [Column("id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int Id { get; set; }

        [Column("salesperson_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int SalespersonId { get; set; }

        [Column("salesperson_name")] 
        [ColumnDbType("text", 0, false, "")] 
        public string SalespersonName { get; set; }

        [Column("total_sales")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal TotalSales { get; set; }

    }

    [FunctionName("get_inventory_transfer_request_view")]
    [ExplicitColumns]
    public class DbGetInventoryTransferRequestViewResult : PetaPocoDB.Record<DbGetInventoryTransferRequestViewResult> , IPoco
    {
        [Column("id")] 
        [ColumnDbType("bigint", 0, false, "")] 
        public long Id { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, false, "")] 
        public DateTime ValueDate { get; set; }

        [Column("office")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Office { get; set; }

        [Column("user_name")] 
        [ColumnDbType("text", 0, false, "")] 
        public string UserName { get; set; }

        [Column("store")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Store { get; set; }

        [Column("reference_number")] 
        [ColumnDbType("text", 0, false, "")] 
        public string ReferenceNumber { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("text", 0, false, "")] 
        public string StatementReference { get; set; }

        [Column("authorized")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Authorized { get; set; }

        [Column("delivered")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Delivered { get; set; }

        [Column("received")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Received { get; set; }

        [Column("flag_background_color")] 
        [ColumnDbType("text", 0, false, "")] 
        public string FlagBackgroundColor { get; set; }

        [Column("flag_foreground_color")] 
        [ColumnDbType("text", 0, false, "")] 
        public string FlagForegroundColor { get; set; }

    }

    [FunctionName("get_income_expenditure_statement")]
    [ExplicitColumns]
    public class DbGetIncomeExpenditureStatementResult : PetaPocoDB.Record<DbGetIncomeExpenditureStatementResult> , IPoco
    {
        [Column("id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int Id { get; set; }

        [Column("account_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int AccountId { get; set; }

        [Column("account_number")] 
        [ColumnDbType("text", 0, false, "")] 
        public string AccountNumber { get; set; }

        [Column("account")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Account { get; set; }

        [Column("previous_debit")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal PreviousDebit { get; set; }

        [Column("previous_credit")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal PreviousCredit { get; set; }

        [Column("previous_balance")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal PreviousBalance { get; set; }

        [Column("debit")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal Debit { get; set; }

        [Column("credit")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal Credit { get; set; }

        [Column("balance")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal Balance { get; set; }

        [Column("closing_debit")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal ClosingDebit { get; set; }

        [Column("closing_credit")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal ClosingCredit { get; set; }

        [Column("closing_balance")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal ClosingBalance { get; set; }

    }

    [FunctionName("get_sales_tax")]
    [ExplicitColumns]
    public class DbGetSalesTaxResult : PetaPocoDB.Record<DbGetSalesTaxResult> , IPoco
    {
        [Column("id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int Id { get; set; }

        [Column("sales_tax_detail_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int SalesTaxDetailId { get; set; }

        [Column("sales_tax_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int SalesTaxId { get; set; }

        [Column("sales_tax_detail_code")] 
        [ColumnDbType("text", 0, false, "")] 
        public string SalesTaxDetailCode { get; set; }

        [Column("sales_tax_detail_name")] 
        [ColumnDbType("text", 0, false, "")] 
        public string SalesTaxDetailName { get; set; }

        [Column("is_use_tax")] 
        [ColumnDbType("boolean", 0, false, "")] 
        public bool IsUseTax { get; set; }

        [Column("account_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int AccountId { get; set; }

        [Column("price")] 
        [ColumnDbType("money_strict", 0, false, "")] 
        public decimal Price { get; set; }

        [Column("quantity")] 
        [ColumnDbType("integer_strict", 0, false, "")] 
        public int Quantity { get; set; }

        [Column("discount")] 
        [ColumnDbType("money_strict2", 0, false, "")] 
        public decimal Discount { get; set; }

        [Column("shipping_charge")] 
        [ColumnDbType("money_strict2", 0, false, "")] 
        public decimal ShippingCharge { get; set; }

        [Column("taxable_amount")] 
        [ColumnDbType("money_strict2", 0, false, "")] 
        public decimal TaxableAmount { get; set; }

        [Column("state_sales_tax_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int StateSalesTaxId { get; set; }

        [Column("county_sales_tax_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int CountySalesTaxId { get; set; }

        [Column("rate")] 
        [ColumnDbType("decimal_strict2", 0, false, "")] 
        public decimal Rate { get; set; }

        [Column("base_amount_type")] 
        [ColumnDbType("text", 0, false, "")] 
        public string BaseAmountType { get; set; }

        [Column("rate_type")] 
        [ColumnDbType("text", 0, false, "")] 
        public string RateType { get; set; }

        [Column("rounding_type")] 
        [ColumnDbType("text", 0, false, "")] 
        public string RoundingType { get; set; }

        [Column("rounding_places")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int RoundingPlaces { get; set; }

        [Column("tax")] 
        [ColumnDbType("money_strict2", 0, false, "")] 
        public decimal Tax { get; set; }

    }

    [FunctionName("get_receipt_view")]
    [ExplicitColumns]
    public class DbGetReceiptViewResult : PetaPocoDB.Record<DbGetReceiptViewResult> , IPoco
    {
        [Column("id")] 
        [ColumnDbType("bigint", 0, false, "")] 
        public long Id { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, false, "")] 
        public DateTime ValueDate { get; set; }

        [Column("reference_number")] 
        [ColumnDbType("text", 0, false, "")] 
        public string ReferenceNumber { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("text", 0, false, "")] 
        public string StatementReference { get; set; }

        [Column("office")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Office { get; set; }

        [Column("party")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Party { get; set; }

        [Column("user")] 
        [ColumnDbType("text", 0, false, "")] 
        public string User { get; set; }

        [Column("currency_code")] 
        [ColumnDbType("text", 0, false, "")] 
        public string CurrencyCode { get; set; }

        [Column("amount")] 
        [ColumnDbType("money_strict", 0, false, "")] 
        public decimal Amount { get; set; }

        [Column("transaction_ts")] 
        [ColumnDbType("timestamp with time zone", 0, false, "")] 
        public DateTime TransactionTs { get; set; }

        [Column("flag_background_color")] 
        [ColumnDbType("text", 0, false, "")] 
        public string FlagBackgroundColor { get; set; }

        [Column("flag_foreground_color")] 
        [ColumnDbType("text", 0, false, "")] 
        public string FlagForegroundColor { get; set; }

    }

    [FunctionName("get_party_transaction_summary")]
    [ExplicitColumns]
    public class DbGetPartyTransactionSummaryResult : PetaPocoDB.Record<DbGetPartyTransactionSummaryResult> , IPoco
    {
        [Column("currency_code")] 
        [ColumnDbType("text", 0, false, "")] 
        public string CurrencyCode { get; set; }

        [Column("currency_symbol")] 
        [ColumnDbType("text", 0, false, "")] 
        public string CurrencySymbol { get; set; }

        [Column("total_due_amount")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal TotalDueAmount { get; set; }

        [Column("office_due_amount")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal OfficeDueAmount { get; set; }

        [Column("last_receipt_date")] 
        [ColumnDbType("date", 0, false, "")] 
        public DateTime LastReceiptDate { get; set; }

        [Column("transaction_value")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal TransactionValue { get; set; }

    }

    [FunctionName("get_total_sales_by_office")]
    [ExplicitColumns]
    public class DbGetTotalSalesByOfficeResult : PetaPocoDB.Record<DbGetTotalSalesByOfficeResult> , IPoco
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

    [FunctionName("get_non_gl_product_view")]
    [ExplicitColumns]
    public class DbGetNonGlProductViewResult : PetaPocoDB.Record<DbGetNonGlProductViewResult> , IPoco
    {
        [Column("id")] 
        [ColumnDbType("bigint", 0, false, "")] 
        public long Id { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, false, "")] 
        public DateTime ValueDate { get; set; }

        [Column("office")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string Office { get; set; }

        [Column("party")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Party { get; set; }

        [Column("price_type")] 
        [ColumnDbType("text", 0, false, "")] 
        public string PriceType { get; set; }

        [Column("amount")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal Amount { get; set; }

        [Column("transaction_ts")] 
        [ColumnDbType("timestamp with time zone", 0, false, "")] 
        public DateTime TransactionTs { get; set; }

        [Column("user")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string User { get; set; }

        [Column("reference_number")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string ReferenceNumber { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("text", 0, false, "")] 
        public string StatementReference { get; set; }

        [Column("book")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Book { get; set; }

        [Column("flag_background_color")] 
        [ColumnDbType("text", 0, false, "")] 
        public string FlagBackgroundColor { get; set; }

        [Column("flag_foreground_color")] 
        [ColumnDbType("text", 0, false, "")] 
        public string FlagForegroundColor { get; set; }

    }

    [TableName("transactions.opening_stock_type")]
    [ExplicitColumns]
    public class OpeningStockType : PetaPocoDB.Record<OpeningStockType> , IPoco
    {
        [Column("store_name")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string StoreName { get; set; }

        [Column("item_code")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string ItemCode { get; set; }

        [Column("quantity")] 
        [ColumnDbType("integer_strict", 0, false, "")] 
        public int Quantity { get; set; }

        [Column("unit_name")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string UnitName { get; set; }

        [Column("amount")] 
        [ColumnDbType("money_strict", 0, false, "")] 
        public decimal Amount { get; set; }

    }

    [TableName("transactions.stock_detail_type")]
    [ExplicitColumns]
    public class StockDetailType : PetaPocoDB.Record<StockDetailType> , IPoco
    {
        [Column("store_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int StoreId { get; set; }

        [Column("item_code")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string ItemCode { get; set; }

        [Column("quantity")] 
        [ColumnDbType("integer_strict", 0, false, "")] 
        public int Quantity { get; set; }

        [Column("unit_name")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string UnitName { get; set; }

        [Column("price")] 
        [ColumnDbType("money_strict", 0, false, "")] 
        public decimal Price { get; set; }

        [Column("discount")] 
        [ColumnDbType("money_strict2", 0, false, "")] 
        public decimal Discount { get; set; }

        [Column("shipping_charge")] 
        [ColumnDbType("money_strict2", 0, false, "")] 
        public decimal ShippingCharge { get; set; }

        [Column("tax_form")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string TaxForm { get; set; }

        [Column("tax")] 
        [ColumnDbType("money_strict2", 0, false, "")] 
        public decimal Tax { get; set; }

    }

    [TableName("transactions.purchase_reorder_type")]
    [ExplicitColumns]
    public class PurchaseReorderType : PetaPocoDB.Record<PurchaseReorderType> , IPoco
    {
        [Column("item_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int ItemId { get; set; }

        [Column("supplier_code")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string SupplierCode { get; set; }

        [Column("unit_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int UnitId { get; set; }

        [Column("price")] 
        [ColumnDbType("decimal_strict", 0, false, "")] 
        public decimal Price { get; set; }

        [Column("tax_code")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string TaxCode { get; set; }

        [Column("order_quantity")] 
        [ColumnDbType("integer_strict", 0, false, "")] 
        public int OrderQuantity { get; set; }

    }

    [TableName("transactions.stock_adjustment_type")]
    [ExplicitColumns]
    public class StockAdjustmentType : PetaPocoDB.Record<StockAdjustmentType> , IPoco
    {
        [Column("tran_type")] 
        [ColumnDbType("transaction_type", 0, false, "")] 
        public string TranType { get; set; }

        [Column("store_name")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string StoreName { get; set; }

        [Column("item_code")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string ItemCode { get; set; }

        [Column("unit_name")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string UnitName { get; set; }

        [Column("quantity")] 
        [ColumnDbType("integer_strict", 0, false, "")] 
        public int Quantity { get; set; }

    }

    [TableName("transactions.sales_tax_type")]
    [ExplicitColumns]
    public class SalesTaxType : PetaPocoDB.Record<SalesTaxType> , IPoco
    {
        [Column("id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int Id { get; set; }

        [Column("sales_tax_detail_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int SalesTaxDetailId { get; set; }

        [Column("sales_tax_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int SalesTaxId { get; set; }

        [Column("sales_tax_detail_code")] 
        [ColumnDbType("text", 0, false, "")] 
        public string SalesTaxDetailCode { get; set; }

        [Column("sales_tax_detail_name")] 
        [ColumnDbType("text", 0, false, "")] 
        public string SalesTaxDetailName { get; set; }

        [Column("is_use_tax")] 
        [ColumnDbType("boolean", 0, false, "")] 
        public bool IsUseTax { get; set; }

        [Column("account_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int AccountId { get; set; }

        [Column("price")] 
        [ColumnDbType("money_strict", 0, false, "")] 
        public decimal Price { get; set; }

        [Column("quantity")] 
        [ColumnDbType("integer_strict", 0, false, "")] 
        public int Quantity { get; set; }

        [Column("discount")] 
        [ColumnDbType("money_strict2", 0, false, "")] 
        public decimal Discount { get; set; }

        [Column("shipping_charge")] 
        [ColumnDbType("money_strict2", 0, false, "")] 
        public decimal ShippingCharge { get; set; }

        [Column("taxable_amount")] 
        [ColumnDbType("money_strict2", 0, false, "")] 
        public decimal TaxableAmount { get; set; }

        [Column("state_sales_tax_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int StateSalesTaxId { get; set; }

        [Column("county_sales_tax_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int CountySalesTaxId { get; set; }

        [Column("rate")] 
        [ColumnDbType("decimal_strict2", 0, false, "")] 
        public decimal Rate { get; set; }

        [Column("base_amount_type")] 
        [ColumnDbType("text", 0, false, "")] 
        public string BaseAmountType { get; set; }

        [Column("rate_type")] 
        [ColumnDbType("text", 0, false, "")] 
        public string RateType { get; set; }

        [Column("rounding_type")] 
        [ColumnDbType("text", 0, false, "")] 
        public string RoundingType { get; set; }

        [Column("rounding_places")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int RoundingPlaces { get; set; }

        [Column("tax")] 
        [ColumnDbType("money_strict2", 0, false, "")] 
        public decimal Tax { get; set; }

    }

    [TableName("transactions.trial_balance_view")]
    [ExplicitColumns]
    public class TrialBalanceView : PetaPocoDB.Record<TrialBalanceView> , IPoco
    {
        [Column("get_account_name")] 
        [ColumnDbType("text", 0, false, "")] 
        public string GetAccountName { get; set; }

        [Column("debit")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal Debit { get; set; }

        [Column("credit")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal Credit { get; set; }

    }

    [TableName("transactions.verified_stock_transaction_view")]
    [ExplicitColumns]
    public class VerifiedStockTransactionView : PetaPocoDB.Record<VerifiedStockTransactionView> , IPoco
    {
        [Column("transaction_master_id")] 
        [ColumnDbType("bigint", 0, false, "")] 
        public long TransactionMasterId { get; set; }

        [Column("stock_master_id")] 
        [ColumnDbType("bigint", 0, false, "")] 
        public long StockMasterId { get; set; }

        [Column("stock_detail_id")] 
        [ColumnDbType("bigint", 0, false, "")] 
        public long StockDetailId { get; set; }

        [Column("book")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string Book { get; set; }

        [Column("transaction_counter")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int TransactionCounter { get; set; }

        [Column("transaction_code")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string TransactionCode { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, false, "")] 
        public DateTime ValueDate { get; set; }

        [Column("transaction_ts")] 
        [ColumnDbType("timestamp with time zone", 0, false, "")] 
        public DateTime TransactionTs { get; set; }

        [Column("login_id")] 
        [ColumnDbType("bigint", 0, false, "")] 
        public long LoginId { get; set; }

        [Column("user_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int UserId { get; set; }

        [Column("sys_user_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int SysUserId { get; set; }

        [Column("office_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int OfficeId { get; set; }

        [Column("cost_center_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int CostCenterId { get; set; }

        [Column("reference_number")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string ReferenceNumber { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("text", 0, false, "")] 
        public string StatementReference { get; set; }

        [Column("last_verified_on")] 
        [ColumnDbType("timestamp with time zone", 0, false, "")] 
        public DateTime LastVerifiedOn { get; set; }

        [Column("verified_by_user_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int VerifiedByUserId { get; set; }

        [Column("verification_status_id")] 
        [ColumnDbType("smallint", 0, false, "")] 
        public short VerificationStatusId { get; set; }

        [Column("verification_reason")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string VerificationReason { get; set; }

        [Column("party_id")] 
        [ColumnDbType("bigint", 0, false, "")] 
        public long PartyId { get; set; }

        [Column("country_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int CountryId { get; set; }

        [Column("state_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int StateId { get; set; }

        [Column("salesperson_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int SalespersonId { get; set; }

        [Column("price_type_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int PriceTypeId { get; set; }

        [Column("is_credit")] 
        [ColumnDbType("boolean", 0, false, "")] 
        public bool IsCredit { get; set; }

        [Column("shipper_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int ShipperId { get; set; }

        [Column("shipping_address_id")] 
        [ColumnDbType("bigint", 0, false, "")] 
        public long ShippingAddressId { get; set; }

        [Column("shipping_charge")] 
        [ColumnDbType("money_strict2", 0, false, "")] 
        public decimal ShippingCharge { get; set; }

        [Column("stock_master_store_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int StockMasterStoreId { get; set; }

        [Column("cash_repository_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int CashRepositoryId { get; set; }

        [Column("tran_type")] 
        [ColumnDbType("transaction_type", 0, false, "")] 
        public string TranType { get; set; }

        [Column("store_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int StoreId { get; set; }

        [Column("item_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int ItemId { get; set; }

        [Column("quantity")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int Quantity { get; set; }

        [Column("unit_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int UnitId { get; set; }

        [Column("base_quantity")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal BaseQuantity { get; set; }

        [Column("base_unit_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int BaseUnitId { get; set; }

        [Column("price")] 
        [ColumnDbType("money_strict", 0, false, "")] 
        public decimal Price { get; set; }

        [Column("discount")] 
        [ColumnDbType("money_strict2", 0, false, "")] 
        public decimal Discount { get; set; }

        [Column("sales_tax_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int SalesTaxId { get; set; }

        [Column("tax")] 
        [ColumnDbType("money_strict2", 0, false, "")] 
        public decimal Tax { get; set; }

        [Column("amount")] 
        [ColumnDbType("numeric", 0, false, "")] 
        public decimal Amount { get; set; }

    }

    [TableName("transactions.verified_transaction_mat_view")]
    [ExplicitColumns]
    public class VerifiedTransactionMatView : PetaPocoDB.Record<VerifiedTransactionMatView> , IPoco
    {
        [Column("transaction_master_id")] 
        [ColumnDbType("bigint", 0, false, "")] 
        public long TransactionMasterId { get; set; }

        [Column("transaction_counter")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int TransactionCounter { get; set; }

        [Column("transaction_code")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string TransactionCode { get; set; }

        [Column("book")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string Book { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, false, "")] 
        public DateTime ValueDate { get; set; }

        [Column("transaction_ts")] 
        [ColumnDbType("timestamp with time zone", 0, false, "")] 
        public DateTime TransactionTs { get; set; }

        [Column("login_id")] 
        [ColumnDbType("bigint", 0, false, "")] 
        public long LoginId { get; set; }

        [Column("user_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int UserId { get; set; }

        [Column("sys_user_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int SysUserId { get; set; }

        [Column("office_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int OfficeId { get; set; }

        [Column("cost_center_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int CostCenterId { get; set; }

        [Column("reference_number")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string ReferenceNumber { get; set; }

        [Column("master_statement_reference")] 
        [ColumnDbType("text", 0, false, "")] 
        public string MasterStatementReference { get; set; }

        [Column("last_verified_on")] 
        [ColumnDbType("timestamp with time zone", 0, false, "")] 
        public DateTime LastVerifiedOn { get; set; }

        [Column("verified_by_user_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int VerifiedByUserId { get; set; }

        [Column("verification_status_id")] 
        [ColumnDbType("smallint", 0, false, "")] 
        public short VerificationStatusId { get; set; }

        [Column("verification_reason")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string VerificationReason { get; set; }

        [Column("transaction_detail_id")] 
        [ColumnDbType("bigint", 0, false, "")] 
        public long TransactionDetailId { get; set; }

        [Column("tran_type")] 
        [ColumnDbType("transaction_type", 0, false, "")] 
        public string TranType { get; set; }

        [Column("account_id")] 
        [ColumnDbType("bigint", 0, false, "")] 
        public long AccountId { get; set; }

        [Column("account_number")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string AccountNumber { get; set; }

        [Column("account_name")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string AccountName { get; set; }

        [Column("normally_debit")] 
        [ColumnDbType("boolean", 0, false, "")] 
        public bool NormallyDebit { get; set; }

        [Column("account_master_code")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string AccountMasterCode { get; set; }

        [Column("account_master_name")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string AccountMasterName { get; set; }

        [Column("account_master_id")] 
        [ColumnDbType("smallint", 0, false, "")] 
        public short AccountMasterId { get; set; }

        [Column("confidential")] 
        [ColumnDbType("boolean", 0, false, "")] 
        public bool Confidential { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("text", 0, false, "")] 
        public string StatementReference { get; set; }

        [Column("cash_repository_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int CashRepositoryId { get; set; }

        [Column("currency_code")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string CurrencyCode { get; set; }

        [Column("amount_in_currency")] 
        [ColumnDbType("money_strict", 0, false, "")] 
        public decimal AmountInCurrency { get; set; }

        [Column("local_currency_code")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string LocalCurrencyCode { get; set; }

        [Column("amount_in_local_currency")] 
        [ColumnDbType("money_strict", 0, false, "")] 
        public decimal AmountInLocalCurrency { get; set; }

    }

    [TableName("transactions.verified_cash_transaction_mat_view")]
    [ExplicitColumns]
    public class VerifiedCashTransactionMatView : PetaPocoDB.Record<VerifiedCashTransactionMatView> , IPoco
    {
        [Column("transaction_master_id")] 
        [ColumnDbType("bigint", 0, false, "")] 
        public long TransactionMasterId { get; set; }

        [Column("transaction_counter")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int TransactionCounter { get; set; }

        [Column("transaction_code")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string TransactionCode { get; set; }

        [Column("book")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string Book { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, false, "")] 
        public DateTime ValueDate { get; set; }

        [Column("transaction_ts")] 
        [ColumnDbType("timestamp with time zone", 0, false, "")] 
        public DateTime TransactionTs { get; set; }

        [Column("login_id")] 
        [ColumnDbType("bigint", 0, false, "")] 
        public long LoginId { get; set; }

        [Column("user_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int UserId { get; set; }

        [Column("sys_user_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int SysUserId { get; set; }

        [Column("office_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int OfficeId { get; set; }

        [Column("cost_center_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int CostCenterId { get; set; }

        [Column("reference_number")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string ReferenceNumber { get; set; }

        [Column("master_statement_reference")] 
        [ColumnDbType("text", 0, false, "")] 
        public string MasterStatementReference { get; set; }

        [Column("last_verified_on")] 
        [ColumnDbType("timestamp with time zone", 0, false, "")] 
        public DateTime LastVerifiedOn { get; set; }

        [Column("verified_by_user_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int VerifiedByUserId { get; set; }

        [Column("verification_status_id")] 
        [ColumnDbType("smallint", 0, false, "")] 
        public short VerificationStatusId { get; set; }

        [Column("verification_reason")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string VerificationReason { get; set; }

        [Column("transaction_detail_id")] 
        [ColumnDbType("bigint", 0, false, "")] 
        public long TransactionDetailId { get; set; }

        [Column("tran_type")] 
        [ColumnDbType("transaction_type", 0, false, "")] 
        public string TranType { get; set; }

        [Column("account_id")] 
        [ColumnDbType("bigint", 0, false, "")] 
        public long AccountId { get; set; }

        [Column("account_number")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string AccountNumber { get; set; }

        [Column("account_name")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string AccountName { get; set; }

        [Column("normally_debit")] 
        [ColumnDbType("boolean", 0, false, "")] 
        public bool NormallyDebit { get; set; }

        [Column("account_master_code")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string AccountMasterCode { get; set; }

        [Column("account_master_name")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string AccountMasterName { get; set; }

        [Column("account_master_id")] 
        [ColumnDbType("smallint", 0, false, "")] 
        public short AccountMasterId { get; set; }

        [Column("confidential")] 
        [ColumnDbType("boolean", 0, false, "")] 
        public bool Confidential { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("text", 0, false, "")] 
        public string StatementReference { get; set; }

        [Column("cash_repository_id")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int CashRepositoryId { get; set; }

        [Column("currency_code")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string CurrencyCode { get; set; }

        [Column("amount_in_currency")] 
        [ColumnDbType("money_strict", 0, false, "")] 
        public decimal AmountInCurrency { get; set; }

        [Column("local_currency_code")] 
        [ColumnDbType("character varying", 0, false, "")] 
        public string LocalCurrencyCode { get; set; }

        [Column("amount_in_local_currency")] 
        [ColumnDbType("money_strict", 0, false, "")] 
        public decimal AmountInLocalCurrency { get; set; }

    }
}

