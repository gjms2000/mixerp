
using MixERP.Net.Entities.Contracts;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MixERP.Net.Entities.Transactions
{

    [TableName("transactions.customer_receipts")]
    [PrimaryKey("receipt_id", autoIncrement=false)]
    [ExplicitColumns]
    public class CustomerReceipt : PetaPocoDB.Record<CustomerReceipt> , IPoco
    {
        [Column("receipt_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long ReceiptId { get; set; }

        [Column("transaction_master_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long TransactionMasterId { get; set; }

        [Column("party_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long PartyId { get; set; }

        [Column("currency_code")] 
        [ColumnDbType("varchar", 12, "")] 
        public string CurrencyCode { get; set; }

        [Column("amount")] 
        [ColumnDbType("money_strict", 0, "")] 
        public decimal Amount { get; set; }

        [Column("er_debit")] 
        [ColumnDbType("decimal_strict", 0, "")] 
        public decimal ErDebit { get; set; }

        [Column("er_credit")] 
        [ColumnDbType("decimal_strict", 0, "")] 
        public decimal ErCredit { get; set; }

        [Column("cash_repository_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? CashRepositoryId { get; set; }

        [Column("posted_date")] 
        [ColumnDbType("date", 0, "")] 
        public DateTime? PostedDate { get; set; }

        [Column("bank_account_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long? BankAccountId { get; set; }

        [Column("bank_instrument_code")] 
        [ColumnDbType("varchar", 128, "''::character varying")] 
        public string BankInstrumentCode { get; set; }

        [Column("bank_tran_code")] 
        [ColumnDbType("varchar", 128, "''::character varying")] 
        public string BankTranCode { get; set; }

    }

    [TableName("transactions.stock_tax_details")]
    [ExplicitColumns]
    public class StockTaxDetail : PetaPocoDB.Record<StockTaxDetail> , IPoco
    {
        [Column("stock_detail_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long StockDetailId { get; set; }

        [Column("sales_tax_detail_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int SalesTaxDetailId { get; set; }

        [Column("state_sales_tax_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? StateSalesTaxId { get; set; }

        [Column("county_sales_tax_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? CountySalesTaxId { get; set; }

        [Column("principal")] 
        [ColumnDbType("money_strict", 0, "")] 
        public decimal Principal { get; set; }

        [Column("rate")] 
        [ColumnDbType("decimal_strict", 0, "")] 
        public decimal Rate { get; set; }

        [Column("tax")] 
        [ColumnDbType("money_strict", 0, "")] 
        public decimal Tax { get; set; }

    }

    [TableName("transactions.stock_return")]
    [PrimaryKey("sales_return_id", autoIncrement=false)]
    [ExplicitColumns]
    public class StockReturn : PetaPocoDB.Record<StockReturn> , IPoco
    {
        [Column("sales_return_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long SalesReturnId { get; set; }

        [Column("transaction_master_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long TransactionMasterId { get; set; }

        [Column("return_transaction_master_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long ReturnTransactionMasterId { get; set; }

    }

    [TableName("transactions.non_gl_stock_tax_details")]
    [ExplicitColumns]
    public class NonGlStockTaxDetail : PetaPocoDB.Record<NonGlStockTaxDetail> , IPoco
    {
        [Column("non_gl_stock_detail_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long NonGlStockDetailId { get; set; }

        [Column("sales_tax_detail_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int SalesTaxDetailId { get; set; }

        [Column("state_sales_tax_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? StateSalesTaxId { get; set; }

        [Column("county_sales_tax_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? CountySalesTaxId { get; set; }

        [Column("principal")] 
        [ColumnDbType("money_strict", 0, "")] 
        public decimal Principal { get; set; }

        [Column("rate")] 
        [ColumnDbType("decimal_strict", 0, "")] 
        public decimal Rate { get; set; }

        [Column("tax")] 
        [ColumnDbType("money_strict", 0, "")] 
        public decimal Tax { get; set; }

    }

    [TableName("transactions.non_gl_stock_master_relations")]
    [PrimaryKey("non_gl_stock_master_relation_id", autoIncrement=false)]
    [ExplicitColumns]
    public class NonGlStockMasterRelation : PetaPocoDB.Record<NonGlStockMasterRelation> , IPoco
    {
        [Column("non_gl_stock_master_relation_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long NonGlStockMasterRelationId { get; set; }

        [Column("order_non_gl_stock_master_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long OrderNonGlStockMasterId { get; set; }

        [Column("quotation_non_gl_stock_master_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long QuotationNonGlStockMasterId { get; set; }

    }

    [TableName("transactions.non_gl_stock_master")]
    [PrimaryKey("non_gl_stock_master_id", autoIncrement=false)]
    [ExplicitColumns]
    public class NonGlStockMaster : PetaPocoDB.Record<NonGlStockMaster> , IPoco
    {
        [Column("non_gl_stock_master_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long NonGlStockMasterId { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, "")] 
        public DateTime ValueDate { get; set; }

        [Column("book")] 
        [ColumnDbType("varchar", 48, "")] 
        public string Book { get; set; }

        [Column("party_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long PartyId { get; set; }

        [Column("price_type_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? PriceTypeId { get; set; }

        [Column("transaction_ts")] 
        [ColumnDbType("timestamptz", 0, "now()")] 
        public DateTime TransactionTs { get; set; }

        [Column("login_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long LoginId { get; set; }

        [Column("user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int UserId { get; set; }

        [Column("office_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int OfficeId { get; set; }

        [Column("reference_number")] 
        [ColumnDbType("varchar", 24, "")] 
        public string ReferenceNumber { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("text", 0, "")] 
        public string StatementReference { get; set; }

        [Column("non_taxable")] 
        [ColumnDbType("bool", 0, "false")] 
        public bool NonTaxable { get; set; }

        [Column("salesperson_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? SalespersonId { get; set; }

        [Column("shipper_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? ShipperId { get; set; }

        [Column("shipping_address_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long? ShippingAddressId { get; set; }

        [Column("shipping_charge")] 
        [ColumnDbType("money_strict2", 0, "0")] 
        public decimal ShippingCharge { get; set; }

        [Column("store_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? StoreId { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, "now()")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("transactions.stock_master_non_gl_relations")]
    [PrimaryKey("stock_master_non_gl_relation_id", autoIncrement=false)]
    [ExplicitColumns]
    public class StockMasterNonGlRelation : PetaPocoDB.Record<StockMasterNonGlRelation> , IPoco
    {
        [Column("stock_master_non_gl_relation_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long StockMasterNonGlRelationId { get; set; }

        [Column("stock_master_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long StockMasterId { get; set; }

        [Column("non_gl_stock_master_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long NonGlStockMasterId { get; set; }

    }

    [TableName("transactions.day_operation")]
    [PrimaryKey("day_id", autoIncrement=false)]
    [ExplicitColumns]
    public class DayOperation : PetaPocoDB.Record<DayOperation> , IPoco
    {
        [Column("day_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long DayId { get; set; }

        [Column("office_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int OfficeId { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, "")] 
        public DateTime ValueDate { get; set; }

        [Column("started_on")] 
        [ColumnDbType("timestamptz", 0, "")] 
        public DateTime StartedOn { get; set; }

        [Column("started_by")] 
        [ColumnDbType("int4", 0, "")] 
        public int StartedBy { get; set; }

        [Column("completed_on")] 
        [ColumnDbType("timestamptz", 0, "")] 
        public DateTime? CompletedOn { get; set; }

        [Column("completed_by")] 
        [ColumnDbType("int4", 0, "")] 
        public int? CompletedBy { get; set; }

        [Column("completed")] 
        [ColumnDbType("bool", 0, "false")] 
        public bool Completed { get; set; }

    }

    [TableName("transactions.routines")]
    [PrimaryKey("routine_id", autoIncrement=false)]
    [ExplicitColumns]
    public class Routine : PetaPocoDB.Record<Routine> , IPoco
    {
        [Column("routine_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int RoutineId { get; set; }

        [Column("order")] 
        [ColumnDbType("int4", 0, "")] 
        public int Order { get; set; }

        [Column("routine_code")] 
        [ColumnDbType("varchar", 12, "")] 
        public string RoutineCode { get; set; }

        [Column("routine_name")] 
        [ColumnDbType("regproc", 0, "")] 
        public string RoutineName { get; set; }

        [Column("status")] 
        [ColumnDbType("bool", 0, "true")] 
        public bool Status { get; set; }

    }

    [TableName("transactions.day_operation_routines")]
    [PrimaryKey("day_operation_routine_id", autoIncrement=false)]
    [ExplicitColumns]
    public class DayOperationRoutine : PetaPocoDB.Record<DayOperationRoutine> , IPoco
    {
        [Column("day_operation_routine_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long DayOperationRoutineId { get; set; }

        [Column("day_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long DayId { get; set; }

        [Column("routine_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int RoutineId { get; set; }

        [Column("started_on")] 
        [ColumnDbType("timestamptz", 0, "")] 
        public DateTime StartedOn { get; set; }

        [Column("completed_on")] 
        [ColumnDbType("timestamptz", 0, "")] 
        public DateTime? CompletedOn { get; set; }

    }

    [TableName("transactions.transaction_details")]
    [PrimaryKey("transaction_detail_id", autoIncrement=false)]
    [ExplicitColumns]
    public class TransactionDetail : PetaPocoDB.Record<TransactionDetail> , IPoco
    {
        [Column("transaction_detail_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long TransactionDetailId { get; set; }

        [Column("transaction_master_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long TransactionMasterId { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, "")] 
        public DateTime ValueDate { get; set; }

        [Column("tran_type")] 
        [ColumnDbType("transaction_type", 0, "")] 
        public string TranType { get; set; }

        [Column("account_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long AccountId { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("text", 0, "")] 
        public string StatementReference { get; set; }

        [Column("cash_repository_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? CashRepositoryId { get; set; }

        [Column("currency_code")] 
        [ColumnDbType("varchar", 12, "")] 
        public string CurrencyCode { get; set; }

        [Column("amount_in_currency")] 
        [ColumnDbType("money_strict", 0, "")] 
        public decimal AmountInCurrency { get; set; }

        [Column("local_currency_code")] 
        [ColumnDbType("varchar", 12, "")] 
        public string LocalCurrencyCode { get; set; }

        [Column("er")] 
        [ColumnDbType("decimal_strict", 0, "")] 
        public decimal Er { get; set; }

        [Column("amount_in_local_currency")] 
        [ColumnDbType("money_strict", 0, "")] 
        public decimal AmountInLocalCurrency { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, "now()")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("transactions.stock_details")]
    [PrimaryKey("stock_detail_id", autoIncrement=false)]
    [ExplicitColumns]
    public class StockDetail : PetaPocoDB.Record<StockDetail> , IPoco
    {
        [Column("stock_detail_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long StockDetailId { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, "")] 
        public DateTime ValueDate { get; set; }

        [Column("stock_master_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long StockMasterId { get; set; }

        [Column("tran_type")] 
        [ColumnDbType("transaction_type", 0, "")] 
        public string TranType { get; set; }

        [Column("store_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? StoreId { get; set; }

        [Column("item_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int ItemId { get; set; }

        [Column("quantity")] 
        [ColumnDbType("int4", 0, "")] 
        public int Quantity { get; set; }

        [Column("unit_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int UnitId { get; set; }

        [Column("base_quantity")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal BaseQuantity { get; set; }

        [Column("base_unit_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int BaseUnitId { get; set; }

        [Column("price")] 
        [ColumnDbType("money_strict", 0, "")] 
        public decimal Price { get; set; }

        [Column("cost_of_goods_sold")] 
        [ColumnDbType("money_strict2", 0, "0")] 
        public decimal CostOfGoodsSold { get; set; }

        [Column("discount")] 
        [ColumnDbType("money_strict2", 0, "0")] 
        public decimal Discount { get; set; }

        [Column("shipping_charge")] 
        [ColumnDbType("money_strict2", 0, "0")] 
        public decimal ShippingCharge { get; set; }

        [Column("sales_tax_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? SalesTaxId { get; set; }

        [Column("tax")] 
        [ColumnDbType("money_strict2", 0, "0")] 
        public decimal Tax { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, "now()")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("transactions.non_gl_stock_details")]
    [PrimaryKey("non_gl_stock_detail_id", autoIncrement=false)]
    [ExplicitColumns]
    public class NonGlStockDetail : PetaPocoDB.Record<NonGlStockDetail> , IPoco
    {
        [Column("non_gl_stock_detail_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long NonGlStockDetailId { get; set; }

        [Column("non_gl_stock_master_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long NonGlStockMasterId { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, "")] 
        public DateTime ValueDate { get; set; }

        [Column("item_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int ItemId { get; set; }

        [Column("quantity")] 
        [ColumnDbType("int4", 0, "")] 
        public int Quantity { get; set; }

        [Column("unit_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int UnitId { get; set; }

        [Column("base_quantity")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal BaseQuantity { get; set; }

        [Column("base_unit_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int BaseUnitId { get; set; }

        [Column("price")] 
        [ColumnDbType("money_strict", 0, "")] 
        public decimal Price { get; set; }

        [Column("discount")] 
        [ColumnDbType("money_strict2", 0, "0")] 
        public decimal Discount { get; set; }

        [Column("shipping_charge")] 
        [ColumnDbType("money_strict2", 0, "0")] 
        public decimal ShippingCharge { get; set; }

        [Column("sales_tax_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? SalesTaxId { get; set; }

        [Column("tax")] 
        [ColumnDbType("money_strict2", 0, "0")] 
        public decimal Tax { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, "now()")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("transactions.stock_master")]
    [PrimaryKey("stock_master_id", autoIncrement=false)]
    [ExplicitColumns]
    public class StockMaster : PetaPocoDB.Record<StockMaster> , IPoco
    {
        [Column("stock_master_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long StockMasterId { get; set; }

        [Column("transaction_master_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long TransactionMasterId { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, "")] 
        public DateTime ValueDate { get; set; }

        [Column("party_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long? PartyId { get; set; }

        [Column("salesperson_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? SalespersonId { get; set; }

        [Column("price_type_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? PriceTypeId { get; set; }

        [Column("is_credit")] 
        [ColumnDbType("bool", 0, "false")] 
        public bool IsCredit { get; set; }

        [Column("payment_term_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? PaymentTermId { get; set; }

        [Column("shipper_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? ShipperId { get; set; }

        [Column("shipping_address_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long? ShippingAddressId { get; set; }

        [Column("shipping_charge")] 
        [ColumnDbType("money_strict2", 0, "0")] 
        public decimal ShippingCharge { get; set; }

        [Column("store_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? StoreId { get; set; }

        [Column("non_taxable")] 
        [ColumnDbType("bool", 0, "false")] 
        public bool NonTaxable { get; set; }

        [Column("cash_repository_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? CashRepositoryId { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, "now()")] 
        public DateTime? AuditTs { get; set; }

        [Column("credit_settled")] 
        [ColumnDbType("bool", 0, "false")] 
        public bool? CreditSettled { get; set; }

    }

    [TableName("transactions.late_fee")]
    [PrimaryKey("transaction_master_id", autoIncrement=false)]
    [ExplicitColumns]
    public class LateFee : PetaPocoDB.Record<LateFee> , IPoco
    {
        [Column("transaction_master_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long TransactionMasterId { get; set; }

        [Column("party_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long PartyId { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, "")] 
        public DateTime ValueDate { get; set; }

        [Column("late_fee_tran_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long LateFeeTranId { get; set; }

        [Column("amount")] 
        [ColumnDbType("money_strict", 0, "")] 
        public decimal? Amount { get; set; }

    }

    [TableName("transactions.inventory_transfer_request_details")]
    [PrimaryKey("inventory_transfer_request_detail_id", autoIncrement=false)]
    [ExplicitColumns]
    public class InventoryTransferRequestDetail : PetaPocoDB.Record<InventoryTransferRequestDetail> , IPoco
    {
        [Column("inventory_transfer_request_detail_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long InventoryTransferRequestDetailId { get; set; }

        [Column("inventory_transfer_request_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long InventoryTransferRequestId { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, "")] 
        public DateTime ValueDate { get; set; }

        [Column("item_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int ItemId { get; set; }

        [Column("quantity")] 
        [ColumnDbType("int4", 0, "")] 
        public int Quantity { get; set; }

        [Column("unit_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int UnitId { get; set; }

        [Column("base_quantity")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal BaseQuantity { get; set; }

        [Column("base_unit_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int BaseUnitId { get; set; }

    }

    [TableName("transactions.inventory_transfer_requests")]
    [PrimaryKey("inventory_transfer_request_id", autoIncrement=false)]
    [ExplicitColumns]
    public class InventoryTransferRequest : PetaPocoDB.Record<InventoryTransferRequest> , IPoco
    {
        [Column("inventory_transfer_request_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long InventoryTransferRequestId { get; set; }

        [Column("office_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int OfficeId { get; set; }

        [Column("user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int UserId { get; set; }

        [Column("login_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long LoginId { get; set; }

        [Column("store_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int StoreId { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, "")] 
        public DateTime ValueDate { get; set; }

        [Column("transaction_ts")] 
        [ColumnDbType("timestamptz", 0, "now()")] 
        public DateTime? TransactionTs { get; set; }

        [Column("reference_number")] 
        [ColumnDbType("varchar", 24, "")] 
        public string ReferenceNumber { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("text", 0, "")] 
        public string StatementReference { get; set; }

        [Column("authorization_status_id")] 
        [ColumnDbType("int2", 0, "0")] 
        public short AuthorizationStatusId { get; set; }

        [Column("authorized_by_user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? AuthorizedByUserId { get; set; }

        [Column("authorized_on")] 
        [ColumnDbType("timestamptz", 0, "")] 
        public DateTime? AuthorizedOn { get; set; }

        [Column("authorization_reason")] 
        [ColumnDbType("varchar", 128, "")] 
        public string AuthorizationReason { get; set; }

        [Column("received")] 
        [ColumnDbType("bool", 0, "false")] 
        public bool Received { get; set; }

        [Column("received_by_user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? ReceivedByUserId { get; set; }

        [Column("received_on")] 
        [ColumnDbType("timestamptz", 0, "")] 
        public DateTime? ReceivedOn { get; set; }

        [Column("delivered")] 
        [ColumnDbType("bool", 0, "false")] 
        public bool Delivered { get; set; }

        [Column("delivered_by_user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? DeliveredByUserId { get; set; }

        [Column("delivered_on")] 
        [ColumnDbType("timestamptz", 0, "")] 
        public DateTime? DeliveredOn { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, "now()")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("transactions.inventory_transfer_deliveries")]
    [PrimaryKey("inventory_transfer_delivery_id", autoIncrement=false)]
    [ExplicitColumns]
    public class InventoryTransferDelivery : PetaPocoDB.Record<InventoryTransferDelivery> , IPoco
    {
        [Column("inventory_transfer_delivery_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long InventoryTransferDeliveryId { get; set; }

        [Column("inventory_transfer_request_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long InventoryTransferRequestId { get; set; }

        [Column("office_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int OfficeId { get; set; }

        [Column("user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int UserId { get; set; }

        [Column("login_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long LoginId { get; set; }

        [Column("source_store_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int SourceStoreId { get; set; }

        [Column("destination_store_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int DestinationStoreId { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, "")] 
        public DateTime ValueDate { get; set; }

        [Column("transaction_ts")] 
        [ColumnDbType("timestamptz", 0, "now()")] 
        public DateTime? TransactionTs { get; set; }

        [Column("reference_number")] 
        [ColumnDbType("varchar", 24, "")] 
        public string ReferenceNumber { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("text", 0, "")] 
        public string StatementReference { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, "now()")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("transactions.inventory_transfer_delivery_details")]
    [PrimaryKey("inventory_transfer_delivery_detail_id", autoIncrement=false)]
    [ExplicitColumns]
    public class InventoryTransferDeliveryDetail : PetaPocoDB.Record<InventoryTransferDeliveryDetail> , IPoco
    {
        [Column("inventory_transfer_delivery_detail_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long InventoryTransferDeliveryDetailId { get; set; }

        [Column("inventory_transfer_delivery_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long InventoryTransferDeliveryId { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, "")] 
        public DateTime ValueDate { get; set; }

        [Column("item_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int ItemId { get; set; }

        [Column("quantity")] 
        [ColumnDbType("int4", 0, "")] 
        public int Quantity { get; set; }

        [Column("unit_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int UnitId { get; set; }

        [Column("base_quantity")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal BaseQuantity { get; set; }

        [Column("base_unit_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int BaseUnitId { get; set; }

    }

    [TableName("transactions.transaction_master")]
    [PrimaryKey("transaction_master_id", autoIncrement=false)]
    [ExplicitColumns]
    public class TransactionMaster : PetaPocoDB.Record<TransactionMaster> , IPoco
    {
        [Column("transaction_master_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long TransactionMasterId { get; set; }

        [Column("transaction_counter")] 
        [ColumnDbType("int4", 0, "")] 
        public int TransactionCounter { get; set; }

        [Column("transaction_code")] 
        [ColumnDbType("varchar", 50, "")] 
        public string TransactionCode { get; set; }

        [Column("book")] 
        [ColumnDbType("varchar", 50, "")] 
        public string Book { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, "")] 
        public DateTime ValueDate { get; set; }

        [Column("transaction_ts")] 
        [ColumnDbType("timestamptz", 0, "now()")] 
        public DateTime TransactionTs { get; set; }

        [Column("login_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long? LoginId { get; set; }

        [Column("user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int UserId { get; set; }

        [Column("sys_user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? SysUserId { get; set; }

        [Column("office_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int OfficeId { get; set; }

        [Column("cost_center_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? CostCenterId { get; set; }

        [Column("reference_number")] 
        [ColumnDbType("varchar", 24, "")] 
        public string ReferenceNumber { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("text", 0, "")] 
        public string StatementReference { get; set; }

        [Column("last_verified_on")] 
        [ColumnDbType("timestamptz", 0, "")] 
        public DateTime? LastVerifiedOn { get; set; }

        [Column("verified_by_user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? VerifiedByUserId { get; set; }

        [Column("verification_status_id")] 
        [ColumnDbType("int2", 0, "0")] 
        public short VerificationStatusId { get; set; }

        [Column("verification_reason")] 
        [ColumnDbType("varchar", 128, "''::character varying")] 
        public string VerificationReason { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, "now()")] 
        public DateTime? AuditTs { get; set; }

        [Column("cascading_tran_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long? CascadingTranId { get; set; }

        [Column("book_date")] 
        [ColumnDbType("date", 0, "now()")] 
        public DateTime BookDate { get; set; }

    }

    [TableName("transactions.transaction_view")]
    [ExplicitColumns]
    public class TransactionView : PetaPocoDB.Record<TransactionView> , IPoco
    {
        [Column("transaction_master_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long? TransactionMasterId { get; set; }

        [Column("transaction_counter")] 
        [ColumnDbType("int4", 0, "")] 
        public int? TransactionCounter { get; set; }

        [Column("transaction_code")] 
        [ColumnDbType("varchar", 50, "")] 
        public string TransactionCode { get; set; }

        [Column("book")] 
        [ColumnDbType("varchar", 50, "")] 
        public string Book { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, "")] 
        public DateTime? ValueDate { get; set; }

        [Column("transaction_ts")] 
        [ColumnDbType("timestamptz", 0, "")] 
        public DateTime? TransactionTs { get; set; }

        [Column("login_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long? LoginId { get; set; }

        [Column("user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? UserId { get; set; }

        [Column("sys_user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? SysUserId { get; set; }

        [Column("office_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? OfficeId { get; set; }

        [Column("cost_center_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? CostCenterId { get; set; }

        [Column("reference_number")] 
        [ColumnDbType("varchar", 24, "")] 
        public string ReferenceNumber { get; set; }

        [Column("master_statement_reference")] 
        [ColumnDbType("text", 0, "")] 
        public string MasterStatementReference { get; set; }

        [Column("last_verified_on")] 
        [ColumnDbType("timestamptz", 0, "")] 
        public DateTime? LastVerifiedOn { get; set; }

        [Column("verified_by_user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? VerifiedByUserId { get; set; }

        [Column("verification_status_id")] 
        [ColumnDbType("int2", 0, "")] 
        public short? VerificationStatusId { get; set; }

        [Column("verification_reason")] 
        [ColumnDbType("varchar", 128, "")] 
        public string VerificationReason { get; set; }

        [Column("transaction_detail_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long? TransactionDetailId { get; set; }

        [Column("tran_type")] 
        [ColumnDbType("transaction_type", 0, "")] 
        public string TranType { get; set; }

        [Column("account_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long? AccountId { get; set; }

        [Column("account_number")] 
        [ColumnDbType("varchar", 12, "")] 
        public string AccountNumber { get; set; }

        [Column("account_name")] 
        [ColumnDbType("varchar", 100, "")] 
        public string AccountName { get; set; }

        [Column("normally_debit")] 
        [ColumnDbType("bool", 0, "")] 
        public bool? NormallyDebit { get; set; }

        [Column("account_master_code")] 
        [ColumnDbType("varchar", 3, "")] 
        public string AccountMasterCode { get; set; }

        [Column("account_master_name")] 
        [ColumnDbType("varchar", 40, "")] 
        public string AccountMasterName { get; set; }

        [Column("account_master_id")] 
        [ColumnDbType("int2", 0, "")] 
        public short? AccountMasterId { get; set; }

        [Column("confidential")] 
        [ColumnDbType("bool", 0, "")] 
        public bool? Confidential { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("text", 0, "")] 
        public string StatementReference { get; set; }

        [Column("cash_repository_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? CashRepositoryId { get; set; }

        [Column("currency_code")] 
        [ColumnDbType("varchar", 12, "")] 
        public string CurrencyCode { get; set; }

        [Column("amount_in_currency")] 
        [ColumnDbType("money_strict", 0, "")] 
        public decimal? AmountInCurrency { get; set; }

        [Column("local_currency_code")] 
        [ColumnDbType("varchar", 12, "")] 
        public string LocalCurrencyCode { get; set; }

        [Column("amount_in_local_currency")] 
        [ColumnDbType("money_strict", 0, "")] 
        public decimal? AmountInLocalCurrency { get; set; }

    }

    [TableName("transactions.verified_transaction_view")]
    [ExplicitColumns]
    public class VerifiedTransactionView : PetaPocoDB.Record<VerifiedTransactionView> , IPoco
    {
        [Column("transaction_master_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long? TransactionMasterId { get; set; }

        [Column("transaction_counter")] 
        [ColumnDbType("int4", 0, "")] 
        public int? TransactionCounter { get; set; }

        [Column("transaction_code")] 
        [ColumnDbType("varchar", 50, "")] 
        public string TransactionCode { get; set; }

        [Column("book")] 
        [ColumnDbType("varchar", 50, "")] 
        public string Book { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, "")] 
        public DateTime? ValueDate { get; set; }

        [Column("transaction_ts")] 
        [ColumnDbType("timestamptz", 0, "")] 
        public DateTime? TransactionTs { get; set; }

        [Column("login_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long? LoginId { get; set; }

        [Column("user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? UserId { get; set; }

        [Column("sys_user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? SysUserId { get; set; }

        [Column("office_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? OfficeId { get; set; }

        [Column("cost_center_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? CostCenterId { get; set; }

        [Column("reference_number")] 
        [ColumnDbType("varchar", 24, "")] 
        public string ReferenceNumber { get; set; }

        [Column("master_statement_reference")] 
        [ColumnDbType("text", 0, "")] 
        public string MasterStatementReference { get; set; }

        [Column("last_verified_on")] 
        [ColumnDbType("timestamptz", 0, "")] 
        public DateTime? LastVerifiedOn { get; set; }

        [Column("verified_by_user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? VerifiedByUserId { get; set; }

        [Column("verification_status_id")] 
        [ColumnDbType("int2", 0, "")] 
        public short? VerificationStatusId { get; set; }

        [Column("verification_reason")] 
        [ColumnDbType("varchar", 128, "")] 
        public string VerificationReason { get; set; }

        [Column("transaction_detail_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long? TransactionDetailId { get; set; }

        [Column("tran_type")] 
        [ColumnDbType("transaction_type", 0, "")] 
        public string TranType { get; set; }

        [Column("account_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long? AccountId { get; set; }

        [Column("account_number")] 
        [ColumnDbType("varchar", 12, "")] 
        public string AccountNumber { get; set; }

        [Column("account_name")] 
        [ColumnDbType("varchar", 100, "")] 
        public string AccountName { get; set; }

        [Column("normally_debit")] 
        [ColumnDbType("bool", 0, "")] 
        public bool? NormallyDebit { get; set; }

        [Column("account_master_code")] 
        [ColumnDbType("varchar", 3, "")] 
        public string AccountMasterCode { get; set; }

        [Column("account_master_name")] 
        [ColumnDbType("varchar", 40, "")] 
        public string AccountMasterName { get; set; }

        [Column("account_master_id")] 
        [ColumnDbType("int2", 0, "")] 
        public short? AccountMasterId { get; set; }

        [Column("confidential")] 
        [ColumnDbType("bool", 0, "")] 
        public bool? Confidential { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("text", 0, "")] 
        public string StatementReference { get; set; }

        [Column("cash_repository_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? CashRepositoryId { get; set; }

        [Column("currency_code")] 
        [ColumnDbType("varchar", 12, "")] 
        public string CurrencyCode { get; set; }

        [Column("amount_in_currency")] 
        [ColumnDbType("money_strict", 0, "")] 
        public decimal? AmountInCurrency { get; set; }

        [Column("local_currency_code")] 
        [ColumnDbType("varchar", 12, "")] 
        public string LocalCurrencyCode { get; set; }

        [Column("amount_in_local_currency")] 
        [ColumnDbType("money_strict", 0, "")] 
        public decimal? AmountInLocalCurrency { get; set; }

    }

    [TableName("transactions.stock_transaction_view")]
    [ExplicitColumns]
    public class StockTransactionView : PetaPocoDB.Record<StockTransactionView> , IPoco
    {
        [Column("transaction_master_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long? TransactionMasterId { get; set; }

        [Column("stock_master_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long? StockMasterId { get; set; }

        [Column("stock_detail_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long? StockDetailId { get; set; }

        [Column("book")] 
        [ColumnDbType("varchar", 50, "")] 
        public string Book { get; set; }

        [Column("transaction_counter")] 
        [ColumnDbType("int4", 0, "")] 
        public int? TransactionCounter { get; set; }

        [Column("transaction_code")] 
        [ColumnDbType("varchar", 50, "")] 
        public string TransactionCode { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, "")] 
        public DateTime? ValueDate { get; set; }

        [Column("transaction_ts")] 
        [ColumnDbType("timestamptz", 0, "")] 
        public DateTime? TransactionTs { get; set; }

        [Column("login_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long? LoginId { get; set; }

        [Column("user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? UserId { get; set; }

        [Column("sys_user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? SysUserId { get; set; }

        [Column("office_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? OfficeId { get; set; }

        [Column("cost_center_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? CostCenterId { get; set; }

        [Column("reference_number")] 
        [ColumnDbType("varchar", 24, "")] 
        public string ReferenceNumber { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("text", 0, "")] 
        public string StatementReference { get; set; }

        [Column("last_verified_on")] 
        [ColumnDbType("timestamptz", 0, "")] 
        public DateTime? LastVerifiedOn { get; set; }

        [Column("verified_by_user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? VerifiedByUserId { get; set; }

        [Column("verification_status_id")] 
        [ColumnDbType("int2", 0, "")] 
        public short? VerificationStatusId { get; set; }

        [Column("verification_reason")] 
        [ColumnDbType("varchar", 128, "")] 
        public string VerificationReason { get; set; }

        [Column("party_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long? PartyId { get; set; }

        [Column("country_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? CountryId { get; set; }

        [Column("state_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? StateId { get; set; }

        [Column("salesperson_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? SalespersonId { get; set; }

        [Column("price_type_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? PriceTypeId { get; set; }

        [Column("is_credit")] 
        [ColumnDbType("bool", 0, "")] 
        public bool? IsCredit { get; set; }

        [Column("shipper_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? ShipperId { get; set; }

        [Column("shipping_address_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long? ShippingAddressId { get; set; }

        [Column("shipping_charge")] 
        [ColumnDbType("money_strict2", 0, "")] 
        public decimal? ShippingCharge { get; set; }

        [Column("stock_master_store_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? StockMasterStoreId { get; set; }

        [Column("cash_repository_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? CashRepositoryId { get; set; }

        [Column("tran_type")] 
        [ColumnDbType("transaction_type", 0, "")] 
        public string TranType { get; set; }

        [Column("store_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? StoreId { get; set; }

        [Column("item_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? ItemId { get; set; }

        [Column("quantity")] 
        [ColumnDbType("int4", 0, "")] 
        public int? Quantity { get; set; }

        [Column("unit_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? UnitId { get; set; }

        [Column("base_quantity")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal? BaseQuantity { get; set; }

        [Column("base_unit_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? BaseUnitId { get; set; }

        [Column("price")] 
        [ColumnDbType("money_strict", 0, "")] 
        public decimal? Price { get; set; }

        [Column("discount")] 
        [ColumnDbType("money_strict2", 0, "")] 
        public decimal? Discount { get; set; }

        [Column("sales_tax_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? SalesTaxId { get; set; }

        [Column("tax")] 
        [ColumnDbType("money_strict2", 0, "")] 
        public decimal? Tax { get; set; }

        [Column("amount")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal? Amount { get; set; }

    }

    [TableName("transactions.sales_by_country_view")]
    [ExplicitColumns]
    public class SalesByCountryView : PetaPocoDB.Record<SalesByCountryView> , IPoco
    {
        [Column("country_code")] 
        [ColumnDbType("varchar", 12, "")] 
        public string CountryCode { get; set; }

        [Column("sales")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal? Sales { get; set; }

    }

    [TableName("transactions.verified_stock_details_view")]
    [ExplicitColumns]
    public class VerifiedStockDetailsView : PetaPocoDB.Record<VerifiedStockDetailsView> , IPoco
    {
        [Column("stock_detail_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long? StockDetailId { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, "")] 
        public DateTime? ValueDate { get; set; }

        [Column("stock_master_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long? StockMasterId { get; set; }

        [Column("tran_type")] 
        [ColumnDbType("transaction_type", 0, "")] 
        public string TranType { get; set; }

        [Column("store_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? StoreId { get; set; }

        [Column("item_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? ItemId { get; set; }

        [Column("quantity")] 
        [ColumnDbType("int4", 0, "")] 
        public int? Quantity { get; set; }

        [Column("unit_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? UnitId { get; set; }

        [Column("base_quantity")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal? BaseQuantity { get; set; }

        [Column("base_unit_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? BaseUnitId { get; set; }

        [Column("price")] 
        [ColumnDbType("money_strict", 0, "")] 
        public decimal? Price { get; set; }

        [Column("cost_of_goods_sold")] 
        [ColumnDbType("money_strict2", 0, "")] 
        public decimal? CostOfGoodsSold { get; set; }

        [Column("discount")] 
        [ColumnDbType("money_strict2", 0, "")] 
        public decimal? Discount { get; set; }

        [Column("shipping_charge")] 
        [ColumnDbType("money_strict2", 0, "")] 
        public decimal? ShippingCharge { get; set; }

        [Column("sales_tax_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? SalesTaxId { get; set; }

        [Column("tax")] 
        [ColumnDbType("money_strict2", 0, "")] 
        public decimal? Tax { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("transactions.party_item_chart_view")]
    [ExplicitColumns]
    public class PartyItemChartView : PetaPocoDB.Record<PartyItemChartView> , IPoco
    {
        [Column("party_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long? PartyId { get; set; }

        [Column("item_name")] 
        [ColumnDbType("varchar", 150, "")] 
        public string ItemName { get; set; }

        [Column("total")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal? Total { get; set; }

    }

    [TableName("transactions.party_purchase_chart_view")]
    [ExplicitColumns]
    public class PartyPurchaseChartView : PetaPocoDB.Record<PartyPurchaseChartView> , IPoco
    {
        [Column("row_number")] 
        [ColumnDbType("int8", 0, "")] 
        public long? RowNumber { get; set; }

        [Column("transaction_master_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long? TransactionMasterId { get; set; }

        [Column("party_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long? PartyId { get; set; }

        [Column("book")] 
        [ColumnDbType("varchar", 50, "")] 
        public string Book { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, "")] 
        public DateTime? ValueDate { get; set; }

        [Column("amount")] 
        [ColumnDbType("numeric", 1572868, "")] 
        public decimal? Amount { get; set; }

    }

    [TableName("transactions.party_sales_chart_view")]
    [ExplicitColumns]
    public class PartySalesChartView : PetaPocoDB.Record<PartySalesChartView> , IPoco
    {
        [Column("row_number")] 
        [ColumnDbType("int8", 0, "")] 
        public long? RowNumber { get; set; }

        [Column("transaction_master_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long? TransactionMasterId { get; set; }

        [Column("party_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long? PartyId { get; set; }

        [Column("book")] 
        [ColumnDbType("varchar", 50, "")] 
        public string Book { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, "")] 
        public DateTime? ValueDate { get; set; }

        [Column("amount")] 
        [ColumnDbType("numeric", 1572868, "")] 
        public decimal? Amount { get; set; }

    }

    [TableName("transactions.receipt_view")]
    [ExplicitColumns]
    public class ReceiptView : PetaPocoDB.Record<ReceiptView> , IPoco
    {
        [Column("tran_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long? TranId { get; set; }

        [Column("office_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? OfficeId { get; set; }

        [Column("office_code")] 
        [ColumnDbType("varchar", 12, "")] 
        public string OfficeCode { get; set; }

        [Column("transaction_master_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long? TransactionMasterId { get; set; }

        [Column("transaction_code")] 
        [ColumnDbType("varchar", 50, "")] 
        public string TransactionCode { get; set; }

        [Column("transaction_ts")] 
        [ColumnDbType("timestamptz", 0, "")] 
        public DateTime? TransactionTs { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, "")] 
        public DateTime? ValueDate { get; set; }

        [Column("entered_by")] 
        [ColumnDbType("varchar", 50, "")] 
        public string EnteredBy { get; set; }

        [Column("reference_number")] 
        [ColumnDbType("varchar", 24, "")] 
        public string ReferenceNumber { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("text", 0, "")] 
        public string StatementReference { get; set; }

        [Column("status")] 
        [ColumnDbType("varchar", 128, "")] 
        public string Status { get; set; }

        [Column("verification_reason")] 
        [ColumnDbType("varchar", 128, "")] 
        public string VerificationReason { get; set; }

        [Column("verified_by")] 
        [ColumnDbType("varchar", 50, "")] 
        public string VerifiedBy { get; set; }

        [Column("customer_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long? CustomerId { get; set; }

        [Column("customer_code")] 
        [ColumnDbType("varchar", 12, "")] 
        public string CustomerCode { get; set; }

        [Column("customer_name")] 
        [ColumnDbType("text", 0, "")] 
        public string CustomerName { get; set; }

        [Column("address")] 
        [ColumnDbType("text", 0, "")] 
        public string Address { get; set; }

        [Column("pan_number")] 
        [ColumnDbType("varchar", 50, "")] 
        public string PanNumber { get; set; }

        [Column("sst_number")] 
        [ColumnDbType("varchar", 50, "")] 
        public string SstNumber { get; set; }

        [Column("cst_number")] 
        [ColumnDbType("varchar", 50, "")] 
        public string CstNumber { get; set; }

        [Column("email")] 
        [ColumnDbType("varchar", 128, "")] 
        public string Email { get; set; }

        [Column("currency_code")] 
        [ColumnDbType("varchar", 12, "")] 
        public string CurrencyCode { get; set; }

        [Column("amount")] 
        [ColumnDbType("money_strict", 0, "")] 
        public decimal? Amount { get; set; }

        [Column("er_debit")] 
        [ColumnDbType("decimal_strict", 0, "")] 
        public decimal? ErDebit { get; set; }

        [Column("home_currency_code")] 
        [ColumnDbType("varchar", 12, "")] 
        public string HomeCurrencyCode { get; set; }

        [Column("amount_in_home_currency")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal? AmountInHomeCurrency { get; set; }

        [Column("er_credit")] 
        [ColumnDbType("decimal_strict", 0, "")] 
        public decimal? ErCredit { get; set; }

        [Column("base_currency_code")] 
        [ColumnDbType("varchar", 12, "")] 
        public string BaseCurrencyCode { get; set; }

        [Column("amount_in_base_currency")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal? AmountInBaseCurrency { get; set; }

    }

    [TableName("transactions.sales_delivery_view")]
    [ExplicitColumns]
    public class SalesDeliveryView : PetaPocoDB.Record<SalesDeliveryView> , IPoco
    {
        [Column("tran_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long? TranId { get; set; }

        [Column("transaction_ts")] 
        [ColumnDbType("timestamptz", 0, "")] 
        public DateTime? TransactionTs { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, "")] 
        public DateTime? ValueDate { get; set; }

        [Column("entered_by")] 
        [ColumnDbType("varchar", 50, "")] 
        public string EnteredBy { get; set; }

        [Column("status")] 
        [ColumnDbType("varchar", 128, "")] 
        public string Status { get; set; }

        [Column("due_date")] 
        [ColumnDbType("date", 0, "")] 
        public DateTime? DueDate { get; set; }

        [Column("reference_number")] 
        [ColumnDbType("varchar", 24, "")] 
        public string ReferenceNumber { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("text", 0, "")] 
        public string StatementReference { get; set; }

        [Column("customer_code")] 
        [ColumnDbType("varchar", 12, "")] 
        public string CustomerCode { get; set; }

        [Column("customer_name")] 
        [ColumnDbType("text", 0, "")] 
        public string CustomerName { get; set; }

        [Column("pan_number")] 
        [ColumnDbType("varchar", 50, "")] 
        public string PanNumber { get; set; }

        [Column("sst_number")] 
        [ColumnDbType("varchar", 50, "")] 
        public string SstNumber { get; set; }

        [Column("cst_number")] 
        [ColumnDbType("varchar", 50, "")] 
        public string CstNumber { get; set; }

        [Column("store_name")] 
        [ColumnDbType("varchar", 50, "")] 
        public string StoreName { get; set; }

        [Column("shipping_address")] 
        [ColumnDbType("text", 0, "")] 
        public string ShippingAddress { get; set; }

        [Column("shipper_name")] 
        [ColumnDbType("varchar", 150, "")] 
        public string ShipperName { get; set; }

        [Column("shipping_charge")] 
        [ColumnDbType("money_strict2", 0, "")] 
        public decimal? ShippingCharge { get; set; }

        [Column("invoice_amount")] 
        [ColumnDbType("money_strict2", 0, "")] 
        public decimal? InvoiceAmount { get; set; }

    }

    [TableName("transactions.sales_order_view")]
    [ExplicitColumns]
    public class SalesOrderView : PetaPocoDB.Record<SalesOrderView> , IPoco
    {
        [Column("non_gl_stock_master_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long? NonGlStockMasterId { get; set; }

        [Column("tran_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long? TranId { get; set; }

        [Column("transaction_ts")] 
        [ColumnDbType("timestamptz", 0, "")] 
        public DateTime? TransactionTs { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, "")] 
        public DateTime? ValueDate { get; set; }

        [Column("quotation_valid_duration")] 
        [ColumnDbType("int4", 0, "")] 
        public int? QuotationValidDuration { get; set; }

        [Column("entered_by")] 
        [ColumnDbType("varchar", 50, "")] 
        public string EnteredBy { get; set; }

        [Column("office_name")] 
        [ColumnDbType("varchar", 150, "")] 
        public string OfficeName { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("text", 0, "")] 
        public string StatementReference { get; set; }

        [Column("customer_name")] 
        [ColumnDbType("text", 0, "")] 
        public string CustomerName { get; set; }

        [Column("price_type_name")] 
        [ColumnDbType("varchar", 50, "")] 
        public string PriceTypeName { get; set; }

    }

    [TableName("transactions.sales_quotation_view")]
    [ExplicitColumns]
    public class SalesQuotationView : PetaPocoDB.Record<SalesQuotationView> , IPoco
    {
        [Column("non_gl_stock_master_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long? NonGlStockMasterId { get; set; }

        [Column("tran_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long? TranId { get; set; }

        [Column("transaction_ts")] 
        [ColumnDbType("timestamptz", 0, "")] 
        public DateTime? TransactionTs { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, "")] 
        public DateTime? ValueDate { get; set; }

        [Column("quotation_valid_duration")] 
        [ColumnDbType("int4", 0, "")] 
        public int? QuotationValidDuration { get; set; }

        [Column("entered_by")] 
        [ColumnDbType("varchar", 50, "")] 
        public string EnteredBy { get; set; }

        [Column("office_name")] 
        [ColumnDbType("varchar", 150, "")] 
        public string OfficeName { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("text", 0, "")] 
        public string StatementReference { get; set; }

        [Column("customer_name")] 
        [ColumnDbType("text", 0, "")] 
        public string CustomerName { get; set; }

        [Column("price_type_name")] 
        [ColumnDbType("varchar", 50, "")] 
        public string PriceTypeName { get; set; }

    }

    [FunctionName("get_journal_view")]
    [ExplicitColumns]
    public class DbGetJournalViewResult : PetaPocoDB.Record<DbGetJournalViewResult> , IPoco
    {
        [Column("transaction_master_id")] 
        [ColumnDbType("bigint", 0, "")] 
        public long TransactionMasterId { get; set; }

        [Column("transaction_code")] 
        [ColumnDbType("character varying", 0, "")] 
        public string TransactionCode { get; set; }

        [Column("book")] 
        [ColumnDbType("character varying", 0, "")] 
        public string Book { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, "")] 
        public DateTime ValueDate { get; set; }

        [Column("reference_number")] 
        [ColumnDbType("character varying", 0, "")] 
        public string ReferenceNumber { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("text", 0, "")] 
        public string StatementReference { get; set; }

        [Column("posted_by")] 
        [ColumnDbType("text", 0, "")] 
        public string PostedBy { get; set; }

        [Column("office")] 
        [ColumnDbType("text", 0, "")] 
        public string Office { get; set; }

        [Column("status")] 
        [ColumnDbType("text", 0, "")] 
        public string Status { get; set; }

        [Column("verified_by")] 
        [ColumnDbType("text", 0, "")] 
        public string VerifiedBy { get; set; }

        [Column("verified_on")] 
        [ColumnDbType("timestamp with time zone", 0, "")] 
        public DateTime VerifiedOn { get; set; }

        [Column("reason")] 
        [ColumnDbType("character varying", 0, "")] 
        public string Reason { get; set; }

        [Column("transaction_ts")] 
        [ColumnDbType("timestamp with time zone", 0, "")] 
        public DateTime TransactionTs { get; set; }

        [Column("flag_bg")] 
        [ColumnDbType("text", 0, "")] 
        public string FlagBg { get; set; }

        [Column("flag_fg")] 
        [ColumnDbType("text", 0, "")] 
        public string FlagFg { get; set; }

    }

    [FunctionName("get_stock_account_statement")]
    [ExplicitColumns]
    public class DbGetStockAccountStatementResult : PetaPocoDB.Record<DbGetStockAccountStatementResult> , IPoco
    {
        [Column("id")] 
        [ColumnDbType("integer", 0, "")] 
        public int Id { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, "")] 
        public DateTime ValueDate { get; set; }

        [Column("tran_code")] 
        [ColumnDbType("text", 0, "")] 
        public string TranCode { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("text", 0, "")] 
        public string StatementReference { get; set; }

        [Column("debit")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal Debit { get; set; }

        [Column("credit")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal Credit { get; set; }

        [Column("balance")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal Balance { get; set; }

        [Column("book")] 
        [ColumnDbType("text", 0, "")] 
        public string Book { get; set; }

        [Column("item_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int ItemId { get; set; }

        [Column("item_code")] 
        [ColumnDbType("text", 0, "")] 
        public string ItemCode { get; set; }

        [Column("item_name")] 
        [ColumnDbType("text", 0, "")] 
        public string ItemName { get; set; }

        [Column("posted_on")] 
        [ColumnDbType("timestamp with time zone", 0, "")] 
        public DateTime PostedOn { get; set; }

        [Column("posted_by")] 
        [ColumnDbType("text", 0, "")] 
        public string PostedBy { get; set; }

        [Column("approved_by")] 
        [ColumnDbType("text", 0, "")] 
        public string ApprovedBy { get; set; }

        [Column("verification_status")] 
        [ColumnDbType("integer", 0, "")] 
        public int VerificationStatus { get; set; }

        [Column("flag_bg")] 
        [ColumnDbType("text", 0, "")] 
        public string FlagBg { get; set; }

        [Column("flag_fg")] 
        [ColumnDbType("text", 0, "")] 
        public string FlagFg { get; set; }

    }

    [FunctionName("get_pl_appropriation_data")]
    [ExplicitColumns]
    public class DbGetPlAppropriationDataResult : PetaPocoDB.Record<DbGetPlAppropriationDataResult> , IPoco
    {
        [Column("account_id")] 
        [ColumnDbType("bigint", 0, "")] 
        public long AccountId { get; set; }

        [Column("account_number")] 
        [ColumnDbType("text", 0, "")] 
        public string AccountNumber { get; set; }

        [Column("account_name")] 
        [ColumnDbType("text", 0, "")] 
        public string AccountName { get; set; }

        [Column("debit")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal Debit { get; set; }

        [Column("credit")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal Credit { get; set; }

    }

    [FunctionName("get_sales_by_offices")]
    [ExplicitColumns]
    public class DbGetSalesByOfficesResult : PetaPocoDB.Record<DbGetSalesByOfficesResult> , IPoco
    {
        [Column("office")] 
        [ColumnDbType("text", 0, "")] 
        public string Office { get; set; }

        [Column("jan")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal Jan { get; set; }

        [Column("feb")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal Feb { get; set; }

        [Column("mar")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal Mar { get; set; }

        [Column("apr")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal Apr { get; set; }

        [Column("may")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal May { get; set; }

        [Column("jun")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal Jun { get; set; }

        [Column("jul")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal Jul { get; set; }

        [Column("aug")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal Aug { get; set; }

        [Column("sep")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal Sep { get; set; }

        [Column("oct")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal Oct { get; set; }

        [Column("nov")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal Nov { get; set; }

        [Column("dec")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal Dec { get; set; }

    }

    [FunctionName("get_product_view")]
    [ExplicitColumns]
    public class DbGetProductViewResult : PetaPocoDB.Record<DbGetProductViewResult> , IPoco
    {
        [Column("id")] 
        [ColumnDbType("bigint", 0, "")] 
        public long Id { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, "")] 
        public DateTime ValueDate { get; set; }

        [Column("office")] 
        [ColumnDbType("character varying", 0, "")] 
        public string Office { get; set; }

        [Column("party")] 
        [ColumnDbType("text", 0, "")] 
        public string Party { get; set; }

        [Column("price_type")] 
        [ColumnDbType("text", 0, "")] 
        public string PriceType { get; set; }

        [Column("amount")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal Amount { get; set; }

        [Column("transaction_ts")] 
        [ColumnDbType("timestamp with time zone", 0, "")] 
        public DateTime TransactionTs { get; set; }

        [Column("user")] 
        [ColumnDbType("character varying", 0, "")] 
        public string User { get; set; }

        [Column("reference_number")] 
        [ColumnDbType("character varying", 0, "")] 
        public string ReferenceNumber { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("text", 0, "")] 
        public string StatementReference { get; set; }

        [Column("book")] 
        [ColumnDbType("text", 0, "")] 
        public string Book { get; set; }

        [Column("salesperson")] 
        [ColumnDbType("text", 0, "")] 
        public string Salesperson { get; set; }

        [Column("is_credit")] 
        [ColumnDbType("boolean", 0, "")] 
        public bool IsCredit { get; set; }

        [Column("shipper")] 
        [ColumnDbType("text", 0, "")] 
        public string Shipper { get; set; }

        [Column("shipping_address_code")] 
        [ColumnDbType("text", 0, "")] 
        public string ShippingAddressCode { get; set; }

        [Column("store")] 
        [ColumnDbType("text", 0, "")] 
        public string Store { get; set; }

        [Column("flag_background_color")] 
        [ColumnDbType("text", 0, "")] 
        public string FlagBackgroundColor { get; set; }

        [Column("flag_foreground_color")] 
        [ColumnDbType("text", 0, "")] 
        public string FlagForegroundColor { get; set; }

    }

    [FunctionName("get_trial_balance")]
    [ExplicitColumns]
    public class DbGetTrialBalanceResult : PetaPocoDB.Record<DbGetTrialBalanceResult> , IPoco
    {
        [Column("id")] 
        [ColumnDbType("integer", 0, "")] 
        public int Id { get; set; }

        [Column("account_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int AccountId { get; set; }

        [Column("account_number")] 
        [ColumnDbType("text", 0, "")] 
        public string AccountNumber { get; set; }

        [Column("account")] 
        [ColumnDbType("text", 0, "")] 
        public string Account { get; set; }

        [Column("previous_debit")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal PreviousDebit { get; set; }

        [Column("previous_credit")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal PreviousCredit { get; set; }

        [Column("debit")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal Debit { get; set; }

        [Column("credit")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal Credit { get; set; }

        [Column("closing_debit")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal ClosingDebit { get; set; }

        [Column("closing_credit")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal ClosingCredit { get; set; }

    }

    [FunctionName("get_balance_sheet")]
    [ExplicitColumns]
    public class DbGetBalanceSheetResult : PetaPocoDB.Record<DbGetBalanceSheetResult> , IPoco
    {
        [Column("id")] 
        [ColumnDbType("bigint", 0, "")] 
        public long Id { get; set; }

        [Column("item")] 
        [ColumnDbType("text", 0, "")] 
        public string Item { get; set; }

        [Column("previous_period")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal PreviousPeriod { get; set; }

        [Column("current_period")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal CurrentPeriod { get; set; }

        [Column("account_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int AccountId { get; set; }

        [Column("account_number")] 
        [ColumnDbType("text", 0, "")] 
        public string AccountNumber { get; set; }

        [Column("is_retained_earning")] 
        [ColumnDbType("boolean", 0, "")] 
        public bool IsRetainedEarning { get; set; }

    }

    [FunctionName("get_eoy_profit_summary")]
    [ExplicitColumns]
    public class DbGetEoyProfitSummaryResult : PetaPocoDB.Record<DbGetEoyProfitSummaryResult> , IPoco
    {
        [Column("profit_before_tax")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal ProfitBeforeTax { get; set; }

        [Column("tax_rate")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal TaxRate { get; set; }

        [Column("tax")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal Tax { get; set; }

    }

    [FunctionName("get_reorder_view_function")]
    [ExplicitColumns]
    public class DbGetReorderViewFunctionResult : PetaPocoDB.Record<DbGetReorderViewFunctionResult> , IPoco
    {
        [Column("item_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int ItemId { get; set; }

        [Column("item_code")] 
        [ColumnDbType("character varying", 0, "")] 
        public string ItemCode { get; set; }

        [Column("item_name")] 
        [ColumnDbType("character varying", 0, "")] 
        public string ItemName { get; set; }

        [Column("unit_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int UnitId { get; set; }

        [Column("unit")] 
        [ColumnDbType("text", 0, "")] 
        public string Unit { get; set; }

        [Column("quantity_on_hand")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal QuantityOnHand { get; set; }

        [Column("reorder_level")] 
        [ColumnDbType("integer", 0, "")] 
        public int ReorderLevel { get; set; }

        [Column("reorder_quantity")] 
        [ColumnDbType("integer", 0, "")] 
        public int ReorderQuantity { get; set; }

        [Column("preferred_supplier_id")] 
        [ColumnDbType("bigint", 0, "")] 
        public long PreferredSupplierId { get; set; }

        [Column("preferred_supplier")] 
        [ColumnDbType("text", 0, "")] 
        public string PreferredSupplier { get; set; }

        [Column("price")] 
        [ColumnDbType("money_strict2", 0, "")] 
        public decimal Price { get; set; }

    }

    [FunctionName("list_closing_stock")]
    [ExplicitColumns]
    public class DbListClosingStockResult : PetaPocoDB.Record<DbListClosingStockResult> , IPoco
    {
        [Column("item_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int ItemId { get; set; }

        [Column("item_code")] 
        [ColumnDbType("text", 0, "")] 
        public string ItemCode { get; set; }

        [Column("item_name")] 
        [ColumnDbType("text", 0, "")] 
        public string ItemName { get; set; }

        [Column("unit_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int UnitId { get; set; }

        [Column("unit_name")] 
        [ColumnDbType("text", 0, "")] 
        public string UnitName { get; set; }

        [Column("quantity")] 
        [ColumnDbType("integer", 0, "")] 
        public int Quantity { get; set; }

    }

    [FunctionName("get_retained_earnings_statement")]
    [ExplicitColumns]
    public class DbGetRetainedEarningsStatementResult : PetaPocoDB.Record<DbGetRetainedEarningsStatementResult> , IPoco
    {
        [Column("id")] 
        [ColumnDbType("integer", 0, "")] 
        public int Id { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, "")] 
        public DateTime ValueDate { get; set; }

        [Column("tran_code")] 
        [ColumnDbType("text", 0, "")] 
        public string TranCode { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("text", 0, "")] 
        public string StatementReference { get; set; }

        [Column("debit")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal Debit { get; set; }

        [Column("credit")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal Credit { get; set; }

        [Column("balance")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal Balance { get; set; }

        [Column("office")] 
        [ColumnDbType("text", 0, "")] 
        public string Office { get; set; }

        [Column("book")] 
        [ColumnDbType("text", 0, "")] 
        public string Book { get; set; }

        [Column("account_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int AccountId { get; set; }

        [Column("account_number")] 
        [ColumnDbType("text", 0, "")] 
        public string AccountNumber { get; set; }

        [Column("account")] 
        [ColumnDbType("text", 0, "")] 
        public string Account { get; set; }

        [Column("posted_on")] 
        [ColumnDbType("timestamp with time zone", 0, "")] 
        public DateTime PostedOn { get; set; }

        [Column("posted_by")] 
        [ColumnDbType("text", 0, "")] 
        public string PostedBy { get; set; }

        [Column("approved_by")] 
        [ColumnDbType("text", 0, "")] 
        public string ApprovedBy { get; set; }

        [Column("verification_status")] 
        [ColumnDbType("integer", 0, "")] 
        public int VerificationStatus { get; set; }

    }

    [FunctionName("get_top_selling_products_by_office")]
    [ExplicitColumns]
    public class DbGetTopSellingProductsByOfficeResult : PetaPocoDB.Record<DbGetTopSellingProductsByOfficeResult> , IPoco
    {
        [Column("id")] 
        [ColumnDbType("integer", 0, "")] 
        public int Id { get; set; }

        [Column("office_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int OfficeId { get; set; }

        [Column("office_code")] 
        [ColumnDbType("text", 0, "")] 
        public string OfficeCode { get; set; }

        [Column("office_name")] 
        [ColumnDbType("text", 0, "")] 
        public string OfficeName { get; set; }

        [Column("item_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int ItemId { get; set; }

        [Column("item_code")] 
        [ColumnDbType("text", 0, "")] 
        public string ItemCode { get; set; }

        [Column("item_name")] 
        [ColumnDbType("text", 0, "")] 
        public string ItemName { get; set; }

        [Column("total_sales")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal TotalSales { get; set; }

    }

    [FunctionName("get_top_selling_products_of_all_time")]
    [ExplicitColumns]
    public class DbGetTopSellingProductsOfAllTimeResult : PetaPocoDB.Record<DbGetTopSellingProductsOfAllTimeResult> , IPoco
    {
        [Column("id")] 
        [ColumnDbType("integer", 0, "")] 
        public int Id { get; set; }

        [Column("item_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int ItemId { get; set; }

        [Column("item_code")] 
        [ColumnDbType("text", 0, "")] 
        public string ItemCode { get; set; }

        [Column("item_name")] 
        [ColumnDbType("text", 0, "")] 
        public string ItemName { get; set; }

        [Column("total_sales")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal TotalSales { get; set; }

    }

    [FunctionName("get_account_statement")]
    [ExplicitColumns]
    public class DbGetAccountStatementResult : PetaPocoDB.Record<DbGetAccountStatementResult> , IPoco
    {
        [Column("id")] 
        [ColumnDbType("integer", 0, "")] 
        public int Id { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, "")] 
        public DateTime ValueDate { get; set; }

        [Column("book_date")] 
        [ColumnDbType("date", 0, "")] 
        public DateTime BookDate { get; set; }

        [Column("tran_code")] 
        [ColumnDbType("text", 0, "")] 
        public string TranCode { get; set; }

        [Column("reference_number")] 
        [ColumnDbType("text", 0, "")] 
        public string ReferenceNumber { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("text", 0, "")] 
        public string StatementReference { get; set; }

        [Column("debit")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal Debit { get; set; }

        [Column("credit")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal Credit { get; set; }

        [Column("balance")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal Balance { get; set; }

        [Column("office")] 
        [ColumnDbType("text", 0, "")] 
        public string Office { get; set; }

        [Column("book")] 
        [ColumnDbType("text", 0, "")] 
        public string Book { get; set; }

        [Column("account_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int AccountId { get; set; }

        [Column("account_number")] 
        [ColumnDbType("text", 0, "")] 
        public string AccountNumber { get; set; }

        [Column("account")] 
        [ColumnDbType("text", 0, "")] 
        public string Account { get; set; }

        [Column("posted_on")] 
        [ColumnDbType("timestamp with time zone", 0, "")] 
        public DateTime PostedOn { get; set; }

        [Column("posted_by")] 
        [ColumnDbType("text", 0, "")] 
        public string PostedBy { get; set; }

        [Column("approved_by")] 
        [ColumnDbType("text", 0, "")] 
        public string ApprovedBy { get; set; }

        [Column("verification_status")] 
        [ColumnDbType("integer", 0, "")] 
        public int VerificationStatus { get; set; }

        [Column("flag_bg")] 
        [ColumnDbType("text", 0, "")] 
        public string FlagBg { get; set; }

        [Column("flag_fg")] 
        [ColumnDbType("text", 0, "")] 
        public string FlagFg { get; set; }

    }

    [FunctionName("get_salesperson_report")]
    [ExplicitColumns]
    public class DbGetSalespersonReportResult : PetaPocoDB.Record<DbGetSalespersonReportResult> , IPoco
    {
        [Column("id")] 
        [ColumnDbType("integer", 0, "")] 
        public int Id { get; set; }

        [Column("salesperson_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int SalespersonId { get; set; }

        [Column("salesperson_name")] 
        [ColumnDbType("text", 0, "")] 
        public string SalespersonName { get; set; }

        [Column("total_sales")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal TotalSales { get; set; }

    }

    [FunctionName("get_inventory_transfer_request_view")]
    [ExplicitColumns]
    public class DbGetInventoryTransferRequestViewResult : PetaPocoDB.Record<DbGetInventoryTransferRequestViewResult> , IPoco
    {
        [Column("id")] 
        [ColumnDbType("bigint", 0, "")] 
        public long Id { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, "")] 
        public DateTime ValueDate { get; set; }

        [Column("office")] 
        [ColumnDbType("text", 0, "")] 
        public string Office { get; set; }

        [Column("user_name")] 
        [ColumnDbType("text", 0, "")] 
        public string UserName { get; set; }

        [Column("store")] 
        [ColumnDbType("text", 0, "")] 
        public string Store { get; set; }

        [Column("reference_number")] 
        [ColumnDbType("text", 0, "")] 
        public string ReferenceNumber { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("text", 0, "")] 
        public string StatementReference { get; set; }

        [Column("authorized")] 
        [ColumnDbType("text", 0, "")] 
        public string Authorized { get; set; }

        [Column("delivered")] 
        [ColumnDbType("text", 0, "")] 
        public string Delivered { get; set; }

        [Column("received")] 
        [ColumnDbType("text", 0, "")] 
        public string Received { get; set; }

        [Column("flag_background_color")] 
        [ColumnDbType("text", 0, "")] 
        public string FlagBackgroundColor { get; set; }

        [Column("flag_foreground_color")] 
        [ColumnDbType("text", 0, "")] 
        public string FlagForegroundColor { get; set; }

    }

    [FunctionName("get_sales_tax")]
    [ExplicitColumns]
    public class DbGetSalesTaxResult : PetaPocoDB.Record<DbGetSalesTaxResult> , IPoco
    {
        [Column("id")] 
        [ColumnDbType("integer", 0, "")] 
        public int Id { get; set; }

        [Column("sales_tax_detail_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int SalesTaxDetailId { get; set; }

        [Column("sales_tax_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int SalesTaxId { get; set; }

        [Column("sales_tax_detail_code")] 
        [ColumnDbType("text", 0, "")] 
        public string SalesTaxDetailCode { get; set; }

        [Column("sales_tax_detail_name")] 
        [ColumnDbType("text", 0, "")] 
        public string SalesTaxDetailName { get; set; }

        [Column("is_use_tax")] 
        [ColumnDbType("boolean", 0, "")] 
        public bool IsUseTax { get; set; }

        [Column("account_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int AccountId { get; set; }

        [Column("price")] 
        [ColumnDbType("money_strict", 0, "")] 
        public decimal Price { get; set; }

        [Column("quantity")] 
        [ColumnDbType("integer_strict", 0, "")] 
        public int Quantity { get; set; }

        [Column("discount")] 
        [ColumnDbType("money_strict2", 0, "")] 
        public decimal Discount { get; set; }

        [Column("shipping_charge")] 
        [ColumnDbType("money_strict2", 0, "")] 
        public decimal ShippingCharge { get; set; }

        [Column("taxable_amount")] 
        [ColumnDbType("money_strict2", 0, "")] 
        public decimal TaxableAmount { get; set; }

        [Column("state_sales_tax_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int StateSalesTaxId { get; set; }

        [Column("county_sales_tax_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int CountySalesTaxId { get; set; }

        [Column("rate")] 
        [ColumnDbType("decimal_strict2", 0, "")] 
        public decimal Rate { get; set; }

        [Column("base_amount_type")] 
        [ColumnDbType("text", 0, "")] 
        public string BaseAmountType { get; set; }

        [Column("rate_type")] 
        [ColumnDbType("text", 0, "")] 
        public string RateType { get; set; }

        [Column("rounding_type")] 
        [ColumnDbType("text", 0, "")] 
        public string RoundingType { get; set; }

        [Column("rounding_places")] 
        [ColumnDbType("integer", 0, "")] 
        public int RoundingPlaces { get; set; }

        [Column("tax")] 
        [ColumnDbType("money_strict2", 0, "")] 
        public decimal Tax { get; set; }

    }

    [FunctionName("get_income_expenditure_statement")]
    [ExplicitColumns]
    public class DbGetIncomeExpenditureStatementResult : PetaPocoDB.Record<DbGetIncomeExpenditureStatementResult> , IPoco
    {
        [Column("id")] 
        [ColumnDbType("integer", 0, "")] 
        public int Id { get; set; }

        [Column("account_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int AccountId { get; set; }

        [Column("account_number")] 
        [ColumnDbType("text", 0, "")] 
        public string AccountNumber { get; set; }

        [Column("account")] 
        [ColumnDbType("text", 0, "")] 
        public string Account { get; set; }

        [Column("previous_debit")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal PreviousDebit { get; set; }

        [Column("previous_credit")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal PreviousCredit { get; set; }

        [Column("previous_balance")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal PreviousBalance { get; set; }

        [Column("debit")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal Debit { get; set; }

        [Column("credit")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal Credit { get; set; }

        [Column("balance")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal Balance { get; set; }

        [Column("closing_debit")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal ClosingDebit { get; set; }

        [Column("closing_credit")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal ClosingCredit { get; set; }

        [Column("closing_balance")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal ClosingBalance { get; set; }

    }

    [FunctionName("get_receipt_view")]
    [ExplicitColumns]
    public class DbGetReceiptViewResult : PetaPocoDB.Record<DbGetReceiptViewResult> , IPoco
    {
        [Column("id")] 
        [ColumnDbType("bigint", 0, "")] 
        public long Id { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, "")] 
        public DateTime ValueDate { get; set; }

        [Column("reference_number")] 
        [ColumnDbType("text", 0, "")] 
        public string ReferenceNumber { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("text", 0, "")] 
        public string StatementReference { get; set; }

        [Column("office")] 
        [ColumnDbType("text", 0, "")] 
        public string Office { get; set; }

        [Column("party")] 
        [ColumnDbType("text", 0, "")] 
        public string Party { get; set; }

        [Column("user")] 
        [ColumnDbType("text", 0, "")] 
        public string User { get; set; }

        [Column("currency_code")] 
        [ColumnDbType("text", 0, "")] 
        public string CurrencyCode { get; set; }

        [Column("amount")] 
        [ColumnDbType("money_strict", 0, "")] 
        public decimal Amount { get; set; }

        [Column("transaction_ts")] 
        [ColumnDbType("timestamp with time zone", 0, "")] 
        public DateTime TransactionTs { get; set; }

        [Column("flag_background_color")] 
        [ColumnDbType("text", 0, "")] 
        public string FlagBackgroundColor { get; set; }

        [Column("flag_foreground_color")] 
        [ColumnDbType("text", 0, "")] 
        public string FlagForegroundColor { get; set; }

    }

    [FunctionName("get_party_transaction_summary")]
    [ExplicitColumns]
    public class DbGetPartyTransactionSummaryResult : PetaPocoDB.Record<DbGetPartyTransactionSummaryResult> , IPoco
    {
        [Column("currency_code")] 
        [ColumnDbType("text", 0, "")] 
        public string CurrencyCode { get; set; }

        [Column("currency_symbol")] 
        [ColumnDbType("text", 0, "")] 
        public string CurrencySymbol { get; set; }

        [Column("total_due_amount")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal TotalDueAmount { get; set; }

        [Column("office_due_amount")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal OfficeDueAmount { get; set; }

        [Column("last_receipt_date")] 
        [ColumnDbType("date", 0, "")] 
        public DateTime LastReceiptDate { get; set; }

        [Column("transaction_value")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal TransactionValue { get; set; }

    }

    [FunctionName("get_non_gl_product_view")]
    [ExplicitColumns]
    public class DbGetNonGlProductViewResult : PetaPocoDB.Record<DbGetNonGlProductViewResult> , IPoco
    {
        [Column("id")] 
        [ColumnDbType("bigint", 0, "")] 
        public long Id { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, "")] 
        public DateTime ValueDate { get; set; }

        [Column("office")] 
        [ColumnDbType("character varying", 0, "")] 
        public string Office { get; set; }

        [Column("party")] 
        [ColumnDbType("text", 0, "")] 
        public string Party { get; set; }

        [Column("price_type")] 
        [ColumnDbType("text", 0, "")] 
        public string PriceType { get; set; }

        [Column("amount")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal Amount { get; set; }

        [Column("transaction_ts")] 
        [ColumnDbType("timestamp with time zone", 0, "")] 
        public DateTime TransactionTs { get; set; }

        [Column("user")] 
        [ColumnDbType("character varying", 0, "")] 
        public string User { get; set; }

        [Column("reference_number")] 
        [ColumnDbType("character varying", 0, "")] 
        public string ReferenceNumber { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("text", 0, "")] 
        public string StatementReference { get; set; }

        [Column("book")] 
        [ColumnDbType("text", 0, "")] 
        public string Book { get; set; }

        [Column("flag_background_color")] 
        [ColumnDbType("text", 0, "")] 
        public string FlagBackgroundColor { get; set; }

        [Column("flag_foreground_color")] 
        [ColumnDbType("text", 0, "")] 
        public string FlagForegroundColor { get; set; }

    }

    [FunctionName("get_total_sales_by_office")]
    [ExplicitColumns]
    public class DbGetTotalSalesByOfficeResult : PetaPocoDB.Record<DbGetTotalSalesByOfficeResult> , IPoco
    {
        [Column("office_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int OfficeId { get; set; }

        [Column("office_code")] 
        [ColumnDbType("character varying", 0, "")] 
        public string OfficeCode { get; set; }

        [Column("office_name")] 
        [ColumnDbType("character varying", 0, "")] 
        public string OfficeName { get; set; }

        [Column("total_sales")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal TotalSales { get; set; }

    }

    [TableName("transactions.opening_stock_type")]
    [ExplicitColumns]
    public class OpeningStockType : PetaPocoDB.Record<OpeningStockType> , IPoco
    {
        [Column("store_name")] 
        [ColumnDbType("character varying", 0, "")] 
        public string StoreName { get; set; }

        [Column("item_code")] 
        [ColumnDbType("character varying", 0, "")] 
        public string ItemCode { get; set; }

        [Column("quantity")] 
        [ColumnDbType("integer_strict", 0, "")] 
        public int Quantity { get; set; }

        [Column("unit_name")] 
        [ColumnDbType("character varying", 0, "")] 
        public string UnitName { get; set; }

        [Column("amount")] 
        [ColumnDbType("money_strict", 0, "")] 
        public decimal Amount { get; set; }

    }

    [TableName("transactions.stock_detail_type")]
    [ExplicitColumns]
    public class StockDetailType : PetaPocoDB.Record<StockDetailType> , IPoco
    {
        [Column("store_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int StoreId { get; set; }

        [Column("item_code")] 
        [ColumnDbType("character varying", 0, "")] 
        public string ItemCode { get; set; }

        [Column("quantity")] 
        [ColumnDbType("integer_strict", 0, "")] 
        public int Quantity { get; set; }

        [Column("unit_name")] 
        [ColumnDbType("character varying", 0, "")] 
        public string UnitName { get; set; }

        [Column("price")] 
        [ColumnDbType("money_strict", 0, "")] 
        public decimal Price { get; set; }

        [Column("discount")] 
        [ColumnDbType("money_strict2", 0, "")] 
        public decimal Discount { get; set; }

        [Column("shipping_charge")] 
        [ColumnDbType("money_strict2", 0, "")] 
        public decimal ShippingCharge { get; set; }

        [Column("tax_form")] 
        [ColumnDbType("character varying", 0, "")] 
        public string TaxForm { get; set; }

        [Column("tax")] 
        [ColumnDbType("money_strict2", 0, "")] 
        public decimal Tax { get; set; }

    }

    [TableName("transactions.purchase_reorder_type")]
    [ExplicitColumns]
    public class PurchaseReorderType : PetaPocoDB.Record<PurchaseReorderType> , IPoco
    {
        [Column("item_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int ItemId { get; set; }

        [Column("supplier_code")] 
        [ColumnDbType("character varying", 0, "")] 
        public string SupplierCode { get; set; }

        [Column("unit_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int UnitId { get; set; }

        [Column("price")] 
        [ColumnDbType("decimal_strict", 0, "")] 
        public decimal Price { get; set; }

        [Column("tax_code")] 
        [ColumnDbType("character varying", 0, "")] 
        public string TaxCode { get; set; }

        [Column("order_quantity")] 
        [ColumnDbType("integer_strict", 0, "")] 
        public int OrderQuantity { get; set; }

    }

    [TableName("transactions.stock_adjustment_type")]
    [ExplicitColumns]
    public class StockAdjustmentType : PetaPocoDB.Record<StockAdjustmentType> , IPoco
    {
        [Column("tran_type")] 
        [ColumnDbType("transaction_type", 0, "")] 
        public string TranType { get; set; }

        [Column("store_name")] 
        [ColumnDbType("character varying", 0, "")] 
        public string StoreName { get; set; }

        [Column("item_code")] 
        [ColumnDbType("character varying", 0, "")] 
        public string ItemCode { get; set; }

        [Column("unit_name")] 
        [ColumnDbType("character varying", 0, "")] 
        public string UnitName { get; set; }

        [Column("quantity")] 
        [ColumnDbType("integer_strict", 0, "")] 
        public int Quantity { get; set; }

    }

    [TableName("transactions.sales_tax_type")]
    [ExplicitColumns]
    public class SalesTaxType : PetaPocoDB.Record<SalesTaxType> , IPoco
    {
        [Column("id")] 
        [ColumnDbType("integer", 0, "")] 
        public int Id { get; set; }

        [Column("sales_tax_detail_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int SalesTaxDetailId { get; set; }

        [Column("sales_tax_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int SalesTaxId { get; set; }

        [Column("sales_tax_detail_code")] 
        [ColumnDbType("text", 0, "")] 
        public string SalesTaxDetailCode { get; set; }

        [Column("sales_tax_detail_name")] 
        [ColumnDbType("text", 0, "")] 
        public string SalesTaxDetailName { get; set; }

        [Column("is_use_tax")] 
        [ColumnDbType("boolean", 0, "")] 
        public bool IsUseTax { get; set; }

        [Column("account_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int AccountId { get; set; }

        [Column("price")] 
        [ColumnDbType("money_strict", 0, "")] 
        public decimal Price { get; set; }

        [Column("quantity")] 
        [ColumnDbType("integer_strict", 0, "")] 
        public int Quantity { get; set; }

        [Column("discount")] 
        [ColumnDbType("money_strict2", 0, "")] 
        public decimal Discount { get; set; }

        [Column("shipping_charge")] 
        [ColumnDbType("money_strict2", 0, "")] 
        public decimal ShippingCharge { get; set; }

        [Column("taxable_amount")] 
        [ColumnDbType("money_strict2", 0, "")] 
        public decimal TaxableAmount { get; set; }

        [Column("state_sales_tax_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int StateSalesTaxId { get; set; }

        [Column("county_sales_tax_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int CountySalesTaxId { get; set; }

        [Column("rate")] 
        [ColumnDbType("decimal_strict2", 0, "")] 
        public decimal Rate { get; set; }

        [Column("base_amount_type")] 
        [ColumnDbType("text", 0, "")] 
        public string BaseAmountType { get; set; }

        [Column("rate_type")] 
        [ColumnDbType("text", 0, "")] 
        public string RateType { get; set; }

        [Column("rounding_type")] 
        [ColumnDbType("text", 0, "")] 
        public string RoundingType { get; set; }

        [Column("rounding_places")] 
        [ColumnDbType("integer", 0, "")] 
        public int RoundingPlaces { get; set; }

        [Column("tax")] 
        [ColumnDbType("money_strict2", 0, "")] 
        public decimal Tax { get; set; }

    }

    [TableName("transactions.trial_balance_view")]
    [ExplicitColumns]
    public class TrialBalanceView : PetaPocoDB.Record<TrialBalanceView> , IPoco
    {
        [Column("get_account_name")] 
        [ColumnDbType("text", 0, "")] 
        public string GetAccountName { get; set; }

        [Column("debit")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal Debit { get; set; }

        [Column("credit")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal Credit { get; set; }

    }

    [TableName("transactions.verified_stock_transaction_view")]
    [ExplicitColumns]
    public class VerifiedStockTransactionView : PetaPocoDB.Record<VerifiedStockTransactionView> , IPoco
    {
        [Column("transaction_master_id")] 
        [ColumnDbType("bigint", 0, "")] 
        public long TransactionMasterId { get; set; }

        [Column("stock_master_id")] 
        [ColumnDbType("bigint", 0, "")] 
        public long StockMasterId { get; set; }

        [Column("stock_detail_id")] 
        [ColumnDbType("bigint", 0, "")] 
        public long StockDetailId { get; set; }

        [Column("book")] 
        [ColumnDbType("character varying", 0, "")] 
        public string Book { get; set; }

        [Column("transaction_counter")] 
        [ColumnDbType("integer", 0, "")] 
        public int TransactionCounter { get; set; }

        [Column("transaction_code")] 
        [ColumnDbType("character varying", 0, "")] 
        public string TransactionCode { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, "")] 
        public DateTime ValueDate { get; set; }

        [Column("transaction_ts")] 
        [ColumnDbType("timestamp with time zone", 0, "")] 
        public DateTime TransactionTs { get; set; }

        [Column("login_id")] 
        [ColumnDbType("bigint", 0, "")] 
        public long LoginId { get; set; }

        [Column("user_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int UserId { get; set; }

        [Column("sys_user_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int SysUserId { get; set; }

        [Column("office_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int OfficeId { get; set; }

        [Column("cost_center_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int CostCenterId { get; set; }

        [Column("reference_number")] 
        [ColumnDbType("character varying", 0, "")] 
        public string ReferenceNumber { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("text", 0, "")] 
        public string StatementReference { get; set; }

        [Column("last_verified_on")] 
        [ColumnDbType("timestamp with time zone", 0, "")] 
        public DateTime LastVerifiedOn { get; set; }

        [Column("verified_by_user_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int VerifiedByUserId { get; set; }

        [Column("verification_status_id")] 
        [ColumnDbType("smallint", 0, "")] 
        public short VerificationStatusId { get; set; }

        [Column("verification_reason")] 
        [ColumnDbType("character varying", 0, "")] 
        public string VerificationReason { get; set; }

        [Column("party_id")] 
        [ColumnDbType("bigint", 0, "")] 
        public long PartyId { get; set; }

        [Column("country_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int CountryId { get; set; }

        [Column("state_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int StateId { get; set; }

        [Column("salesperson_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int SalespersonId { get; set; }

        [Column("price_type_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int PriceTypeId { get; set; }

        [Column("is_credit")] 
        [ColumnDbType("boolean", 0, "")] 
        public bool IsCredit { get; set; }

        [Column("shipper_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int ShipperId { get; set; }

        [Column("shipping_address_id")] 
        [ColumnDbType("bigint", 0, "")] 
        public long ShippingAddressId { get; set; }

        [Column("shipping_charge")] 
        [ColumnDbType("money_strict2", 0, "")] 
        public decimal ShippingCharge { get; set; }

        [Column("stock_master_store_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int StockMasterStoreId { get; set; }

        [Column("cash_repository_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int CashRepositoryId { get; set; }

        [Column("tran_type")] 
        [ColumnDbType("transaction_type", 0, "")] 
        public string TranType { get; set; }

        [Column("store_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int StoreId { get; set; }

        [Column("item_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int ItemId { get; set; }

        [Column("quantity")] 
        [ColumnDbType("integer", 0, "")] 
        public int Quantity { get; set; }

        [Column("unit_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int UnitId { get; set; }

        [Column("base_quantity")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal BaseQuantity { get; set; }

        [Column("base_unit_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int BaseUnitId { get; set; }

        [Column("price")] 
        [ColumnDbType("money_strict", 0, "")] 
        public decimal Price { get; set; }

        [Column("discount")] 
        [ColumnDbType("money_strict2", 0, "")] 
        public decimal Discount { get; set; }

        [Column("sales_tax_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int SalesTaxId { get; set; }

        [Column("tax")] 
        [ColumnDbType("money_strict2", 0, "")] 
        public decimal Tax { get; set; }

        [Column("amount")] 
        [ColumnDbType("numeric", 0, "")] 
        public decimal Amount { get; set; }

    }

    [TableName("transactions.verified_transaction_mat_view")]
    [ExplicitColumns]
    public class VerifiedTransactionMatView : PetaPocoDB.Record<VerifiedTransactionMatView> , IPoco
    {
        [Column("transaction_master_id")] 
        [ColumnDbType("bigint", 0, "")] 
        public long TransactionMasterId { get; set; }

        [Column("transaction_counter")] 
        [ColumnDbType("integer", 0, "")] 
        public int TransactionCounter { get; set; }

        [Column("transaction_code")] 
        [ColumnDbType("character varying", 0, "")] 
        public string TransactionCode { get; set; }

        [Column("book")] 
        [ColumnDbType("character varying", 0, "")] 
        public string Book { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, "")] 
        public DateTime ValueDate { get; set; }

        [Column("transaction_ts")] 
        [ColumnDbType("timestamp with time zone", 0, "")] 
        public DateTime TransactionTs { get; set; }

        [Column("login_id")] 
        [ColumnDbType("bigint", 0, "")] 
        public long LoginId { get; set; }

        [Column("user_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int UserId { get; set; }

        [Column("sys_user_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int SysUserId { get; set; }

        [Column("office_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int OfficeId { get; set; }

        [Column("cost_center_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int CostCenterId { get; set; }

        [Column("reference_number")] 
        [ColumnDbType("character varying", 0, "")] 
        public string ReferenceNumber { get; set; }

        [Column("master_statement_reference")] 
        [ColumnDbType("text", 0, "")] 
        public string MasterStatementReference { get; set; }

        [Column("last_verified_on")] 
        [ColumnDbType("timestamp with time zone", 0, "")] 
        public DateTime LastVerifiedOn { get; set; }

        [Column("verified_by_user_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int VerifiedByUserId { get; set; }

        [Column("verification_status_id")] 
        [ColumnDbType("smallint", 0, "")] 
        public short VerificationStatusId { get; set; }

        [Column("verification_reason")] 
        [ColumnDbType("character varying", 0, "")] 
        public string VerificationReason { get; set; }

        [Column("transaction_detail_id")] 
        [ColumnDbType("bigint", 0, "")] 
        public long TransactionDetailId { get; set; }

        [Column("tran_type")] 
        [ColumnDbType("transaction_type", 0, "")] 
        public string TranType { get; set; }

        [Column("account_id")] 
        [ColumnDbType("bigint", 0, "")] 
        public long AccountId { get; set; }

        [Column("account_number")] 
        [ColumnDbType("character varying", 0, "")] 
        public string AccountNumber { get; set; }

        [Column("account_name")] 
        [ColumnDbType("character varying", 0, "")] 
        public string AccountName { get; set; }

        [Column("normally_debit")] 
        [ColumnDbType("boolean", 0, "")] 
        public bool NormallyDebit { get; set; }

        [Column("account_master_code")] 
        [ColumnDbType("character varying", 0, "")] 
        public string AccountMasterCode { get; set; }

        [Column("account_master_name")] 
        [ColumnDbType("character varying", 0, "")] 
        public string AccountMasterName { get; set; }

        [Column("account_master_id")] 
        [ColumnDbType("smallint", 0, "")] 
        public short AccountMasterId { get; set; }

        [Column("confidential")] 
        [ColumnDbType("boolean", 0, "")] 
        public bool Confidential { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("text", 0, "")] 
        public string StatementReference { get; set; }

        [Column("cash_repository_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int CashRepositoryId { get; set; }

        [Column("currency_code")] 
        [ColumnDbType("character varying", 0, "")] 
        public string CurrencyCode { get; set; }

        [Column("amount_in_currency")] 
        [ColumnDbType("money_strict", 0, "")] 
        public decimal AmountInCurrency { get; set; }

        [Column("local_currency_code")] 
        [ColumnDbType("character varying", 0, "")] 
        public string LocalCurrencyCode { get; set; }

        [Column("amount_in_local_currency")] 
        [ColumnDbType("money_strict", 0, "")] 
        public decimal AmountInLocalCurrency { get; set; }

    }

    [TableName("transactions.verified_cash_transaction_mat_view")]
    [ExplicitColumns]
    public class VerifiedCashTransactionMatView : PetaPocoDB.Record<VerifiedCashTransactionMatView> , IPoco
    {
        [Column("transaction_master_id")] 
        [ColumnDbType("bigint", 0, "")] 
        public long TransactionMasterId { get; set; }

        [Column("transaction_counter")] 
        [ColumnDbType("integer", 0, "")] 
        public int TransactionCounter { get; set; }

        [Column("transaction_code")] 
        [ColumnDbType("character varying", 0, "")] 
        public string TransactionCode { get; set; }

        [Column("book")] 
        [ColumnDbType("character varying", 0, "")] 
        public string Book { get; set; }

        [Column("value_date")] 
        [ColumnDbType("date", 0, "")] 
        public DateTime ValueDate { get; set; }

        [Column("transaction_ts")] 
        [ColumnDbType("timestamp with time zone", 0, "")] 
        public DateTime TransactionTs { get; set; }

        [Column("login_id")] 
        [ColumnDbType("bigint", 0, "")] 
        public long LoginId { get; set; }

        [Column("user_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int UserId { get; set; }

        [Column("sys_user_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int SysUserId { get; set; }

        [Column("office_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int OfficeId { get; set; }

        [Column("cost_center_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int CostCenterId { get; set; }

        [Column("reference_number")] 
        [ColumnDbType("character varying", 0, "")] 
        public string ReferenceNumber { get; set; }

        [Column("master_statement_reference")] 
        [ColumnDbType("text", 0, "")] 
        public string MasterStatementReference { get; set; }

        [Column("last_verified_on")] 
        [ColumnDbType("timestamp with time zone", 0, "")] 
        public DateTime LastVerifiedOn { get; set; }

        [Column("verified_by_user_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int VerifiedByUserId { get; set; }

        [Column("verification_status_id")] 
        [ColumnDbType("smallint", 0, "")] 
        public short VerificationStatusId { get; set; }

        [Column("verification_reason")] 
        [ColumnDbType("character varying", 0, "")] 
        public string VerificationReason { get; set; }

        [Column("transaction_detail_id")] 
        [ColumnDbType("bigint", 0, "")] 
        public long TransactionDetailId { get; set; }

        [Column("tran_type")] 
        [ColumnDbType("transaction_type", 0, "")] 
        public string TranType { get; set; }

        [Column("account_id")] 
        [ColumnDbType("bigint", 0, "")] 
        public long AccountId { get; set; }

        [Column("account_number")] 
        [ColumnDbType("character varying", 0, "")] 
        public string AccountNumber { get; set; }

        [Column("account_name")] 
        [ColumnDbType("character varying", 0, "")] 
        public string AccountName { get; set; }

        [Column("normally_debit")] 
        [ColumnDbType("boolean", 0, "")] 
        public bool NormallyDebit { get; set; }

        [Column("account_master_code")] 
        [ColumnDbType("character varying", 0, "")] 
        public string AccountMasterCode { get; set; }

        [Column("account_master_name")] 
        [ColumnDbType("character varying", 0, "")] 
        public string AccountMasterName { get; set; }

        [Column("account_master_id")] 
        [ColumnDbType("smallint", 0, "")] 
        public short AccountMasterId { get; set; }

        [Column("confidential")] 
        [ColumnDbType("boolean", 0, "")] 
        public bool Confidential { get; set; }

        [Column("statement_reference")] 
        [ColumnDbType("text", 0, "")] 
        public string StatementReference { get; set; }

        [Column("cash_repository_id")] 
        [ColumnDbType("integer", 0, "")] 
        public int CashRepositoryId { get; set; }

        [Column("currency_code")] 
        [ColumnDbType("character varying", 0, "")] 
        public string CurrencyCode { get; set; }

        [Column("amount_in_currency")] 
        [ColumnDbType("money_strict", 0, "")] 
        public decimal AmountInCurrency { get; set; }

        [Column("local_currency_code")] 
        [ColumnDbType("character varying", 0, "")] 
        public string LocalCurrencyCode { get; set; }

        [Column("amount_in_local_currency")] 
        [ColumnDbType("money_strict", 0, "")] 
        public decimal AmountInLocalCurrency { get; set; }

    }
}

