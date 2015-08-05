--Contributors for this translation:
--https://github.com/nubiancc
DO
$$
BEGIN
    IF NOT EXISTS
    (
        SELECT 1
        FROM localization.cultures
        WHERE culture_code = 'ar'
    ) THEN
        INSERT INTO localization.cultures
        SELECT 'ar', 'Arabic';
    END IF;
END
$$
LANGUAGE plpgsql;

SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SalesByOffice', '');--Sales By Office
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'SalesQuotationEmailSubject', '');--Quotation #{0} from {1}
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'ReceiptEmailSubject', '');--Receipt #{0} confirmation, {1}
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'SalesDeliveryEmailSubject', '');--Sales delivery #{0} confirmation, {1}
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'SalesOrderEmailSubject', '');--We received your PO #{0}, {1}
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EmailAddress', '');--Email Address
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ThankYou', '');--Thank You
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'reference_number', '');--Reference Number
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'SalesQuotationAlreadyAccepted', '');--This quotation was already accepted on {0}.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'compound_item_detail_id', '');--Compound Item Detail Id
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Accept', '');--Accept
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ReturnBack', '');--Return Back
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'compound_item_details_unit_chk', '');--Invalid unit provided.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'compound_item_id', '');--Compound Item Id
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'OfficeCode', '');--Office Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'compound_item_name', '');--Compound Item Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SelectStore', '');--Select Store
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'compound_unit_id', '');--Compound Unit Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_employee', '');--Is Employee
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_exempt', '');--Is Exempt
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_exemption', '');--Is Exemption
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Email', '');--Email
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P9017', '');--Access is denied. You don''t have the right to withdraw the transaction.
SELECT * FROM localization.add_localized_resource('CommonResource', 'ar', 'DateMustBeGreaterThan', '');--Invalid date. Must be greater than "{0}".
SELECT * FROM localization.add_localized_resource('CommonResource', 'ar', 'DateMustBeLessThan', '');--Invalid date. Must be less than "{0}".
SELECT * FROM localization.add_localized_resource('CommonResource', 'ar', 'InvalidDate', '');--Invalid date.
SELECT * FROM localization.add_localized_resource('CommonResource', 'ar', 'NoRecordFound', '');--Sorry, no record found.
SELECT * FROM localization.add_localized_resource('CommonResource', 'ar', 'RequiredField', '');--This is a required field.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P1301', '');--Cannot calculate interest. The number of days in a year was not provided.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3000', '');--Invalid data.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3001', '');--Invalid user name.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3005', '');--Password cannot be empty.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3006', '');--Please provide a new password.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3007', '');--Invalid value date.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3008', '');--Invalid date.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3009', '');--Invalid period specified.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3010', '');--Invalid office id.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3011', '');--Invalid office.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3012', '');--Invalid store.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3013', '');--Invalid cash repository.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3050', '');--Invalid party.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3051', '');--Invalid item.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3052', '');--Invalid unit.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3053', '');--Invalid or incompatible unit.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3054', '');--The reorder unit is incompatible with the base unit.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3055', '');--Invalid exchange rate.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3101', '');--Invalid LoginId.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3105', '');--Your current password is incorrect.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3201', '');--Item/unit mismatch.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3202', '');--Tax form mismatch.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3301', '');--Invalid quantity.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3302', '');--Invalid transaction id.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3501', '');--The column account_id cannot be null.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P4010', '');--Exchange rate between the currencies was not found.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P4020', '');--This item is not associated with this transaction.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P4030', '');--No verification policy found for this user.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P4031', '');--Please ask someone else to verify your transaction.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5000', '');--Referencing sides are not equal.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5001', '');--Negative stock is not allowed.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5002', '');--Posting this transaction would produce a negative cash balance.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5010', '');--Past dated transactions are not allowed.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5100', '');--This establishment does not allow transaction posting.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5101', '');--Cannot post transaction during restricted transaction mode.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5102', '');--End of day operation was already performed.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5103', '');--Past dated transactions in verification queue.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5104', '');--Please verify transactions before performing end of day operation.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5110', '');--You cannot provide sales tax information for non taxable sales.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5111', '');--Invalid bank transaction information provided.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5112', '');--Invalid payment card information.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5113', '');--Could not find an account to post merchant fee expenses.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5201', '');--A stock adjustment entry can not contain debit item(s).
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5202', '');--An item can appear only once in a store.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5203', '');--The returned quantity cannot be greater than actual quantity.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5204', '');--The returned amount cannot be greater than actual amount.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5301', '');--Invalid or rejected transaction.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5500', '');--Insufficient item quantity.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5800', '');--Deleting a transaction is not allowed. Mark the transaction as rejected instead.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5901', '');--Please ask someone else to verify the transaction you posted.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5910', '');--Self verification limit exceeded. The transaction was not verified.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5911', '');--Sales verification limit exceeded. The transaction was not verified.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5912', '');--Purchase verification limit exceeded. The transaction was not verified.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5913', '');--GL verification limit exceeded. The transaction was not verified.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P6010', '');--Invalid configuration: COGS method.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P8001', '');--Cannot produce P/L statement of office(s) having different base currencies.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P8002', '');--Cannot produce trial balance of office(s) having different base currencies.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P8003', '');--You cannot have a different currency on the mapped GL account.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P8101', '');--EOD operation was already initialized.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P8501', '');--Only one column is required.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P8502', '');--Cannot update column.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P8990', '');--You are not allowed to change system accounts.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P8991', '');--You are not allowed to add system accounts.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P8992', '');--A sys user cannot have a password.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P9001', '');--Access is denied.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P9010', '');--Access is denied. You are not authorized to post this transaction.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P9011', '');--Access is denied. Invalid values supplied.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P9012', '');--Access is denied! A stock adjustment transaction cannot references multiple branches.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P9013', '');--Access is denied! A stock journal transaction cannot references multiple branches.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P9014', '');--Access is denied. You cannot verify a transaction of another office.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P9015', '');--Access is denied. You cannot verify past or futuer dated transaction.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P9016', '');--Access is denied. You don''t have the right to verify the transaction.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P9201', '');--Acess is denied. You cannot update the "transaction_details" table.
SELECT * FROM localization.add_localized_resource('DbResource', 'ar', 'actions', '');--Actions
SELECT * FROM localization.add_localized_resource('DbResource', 'ar', 'amount', '');--Amount
SELECT * FROM localization.add_localized_resource('DbResource', 'ar', 'currency', '');--Currency
SELECT * FROM localization.add_localized_resource('DbResource', 'ar', 'flag_background_color', '');--Flag Background Color
SELECT * FROM localization.add_localized_resource('DbResource', 'ar', 'flag_foreground_color', '');--Flag Foreground Color
SELECT * FROM localization.add_localized_resource('DbResource', 'ar', 'id', '');--ID
SELECT * FROM localization.add_localized_resource('DbResource', 'ar', 'office', '');--Office
SELECT * FROM localization.add_localized_resource('DbResource', 'ar', 'party', '');--Party
SELECT * FROM localization.add_localized_resource('DbResource', 'ar', 'reference_number', '');--Reference Number
SELECT * FROM localization.add_localized_resource('DbResource', 'ar', 'statement_reference', '');--Statement Reference
SELECT * FROM localization.add_localized_resource('DbResource', 'ar', 'transaction_ts', '');--Transaction Timestamp
SELECT * FROM localization.add_localized_resource('DbResource', 'ar', 'user', '');--User
SELECT * FROM localization.add_localized_resource('DbResource', 'ar', 'value_date', '');--Value Date
SELECT * FROM localization.add_localized_resource('Errors', 'ar', 'BothSidesCannotHaveValue', '');--Both debit and credit cannot have values.
SELECT * FROM localization.add_localized_resource('Errors', 'ar', 'CompoundUnitOfMeasureErrorMessage', '');--Base unit id and compare unit id cannot be same.
SELECT * FROM localization.add_localized_resource('Errors', 'ar', 'InsufficientStockWarning', '');--Only {0} {1} of {2} left in stock.
SELECT * FROM localization.add_localized_resource('Errors', 'ar', 'InvalidSubTranBookPurchaseDelivery', '');--Invalid SubTranBook 'Purchase Delivery'.
SELECT * FROM localization.add_localized_resource('Errors', 'ar', 'InvalidSubTranBookPurchaseQuotation', '');--Invalid SubTranBook 'Purchase Quotation'.
SELECT * FROM localization.add_localized_resource('Errors', 'ar', 'InvalidSubTranBookPurchaseReceipt', '');--Invalid SubTranBook 'Purchase Receipt'.
SELECT * FROM localization.add_localized_resource('Errors', 'ar', 'InvalidSubTranBookSalesPayment', '');--Invalid SubTranBook 'Sales Payment'.
SELECT * FROM localization.add_localized_resource('Errors', 'ar', 'InvalidUserId', '');--Invalid user id.
SELECT * FROM localization.add_localized_resource('Errors', 'ar', 'KeyValueMismatch', '');--There is a mismatching count of key/value items in this ListControl.
SELECT * FROM localization.add_localized_resource('Errors', 'ar', 'NoTransactionToPost', '');--No transaction to post.
SELECT * FROM localization.add_localized_resource('Errors', 'ar', 'ReferencingSidesNotEqual', '');--The referencing sides are not equal.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'AllFieldsRequired', '');--All fields are required.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'CannotWithdrawNotValidGLTransaction', '');--Cannot withdraw transaction. This is a not a valid GL transaction.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'CannotWithdrawTransaction', '');--Cannot withdraw transaction.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'ClickHereToDownload', '');--Click here to download.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'ConfirmedPasswordDoesNotMatch', '');--The confirmed password does not match.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'DatabaseBackupSuccessful', '');--The database backup was successful.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'DaysLowerCase', '');--days
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'EmailBody', '');--<h2>Hi,</h2><p>Please find the attached document.</p><p>Thank you.<br />MixERP</p>
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'EmailSentConfirmation', '');--An email was sent to {0}.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'FlagLabel', '');--You can mark this transaction with a flag, however you will not be able to see the flags created by other users.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'GoToChecklistWindow', '');--Go to checklist window.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'GoToTop', '');--Go to top.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'JustAMomentPlease', '');--Just a moment, please!
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NumRowsAffected', '');--{0} rows affected.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'OpeningInventoryAlreadyEntered', '');--Opening inventory has already been entered for this office.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'PartyDescription', '');--Parties collectively refer to suppliers, customers, agents, and dealers.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'SelectAFlag', '');--Select a flag.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'TaskCompletedSuccessfully', '');--Task completed successfully.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'ThankYouForYourBusiness', '');--Thank you for your business.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'ThisFieldIsRequired', '');--This field is required.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'TransactionApprovedDetails', '');--This transaction was approved by {0} on {1}.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'TransactionAutoApprovedDetails', '');--This transaction was automatically approved by {0} on {1}.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'TransactionAwaitingVerification', '');--This transaction is awaiting verification from an administrator.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'TransactionClosedDetails', '');--This transaction was closed by {0} on {1}. Reason: "{2}".
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'TransactionPostedSuccessfully', '');--The transaction was posted successfully.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'TransactionRejectedDetails', '');--This transaction was rejected by {0} on {1}. Reason: "{2}".
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'TransactionWithdrawalInformation', '');--When you withdraw a transaction, it won't be forwarded to the workflow module. This means that your withdrawn transactions are rejected and require no further verification. However, you won't be able to unwithdraw this transaction later.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'TransactionWithdrawnDetails', '');--This transaction was withdrawn by {0} on {1}. Reason: "{2}".
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'TransactionWithdrawnMessage', '');--The transaction was withdrawn successfully. Moreover, this action will affect the all the reports produced on and after "{0}".
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'UserGreeting', '');--Hi {0}!
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'YourPasswordWasChanged', '');--Your password was changed.
SELECT * FROM localization.add_localized_resource('Messages', 'ar', 'AreYouSure', '');--Are you sure?
SELECT * FROM localization.add_localized_resource('Messages', 'ar', 'CouldNotDetermineVirtualPathError', '');--Could not determine virtual path to create an image.
SELECT * FROM localization.add_localized_resource('Messages', 'ar', 'DuplicateFile', '');--Duplicate File!
SELECT * FROM localization.add_localized_resource('Messages', 'ar', 'EODDoNotCloseWindow', '');--Please do not close this window or navigate away from this page during initialization.
SELECT * FROM localization.add_localized_resource('Messages', 'ar', 'EODElevatedPriviledgeCanLogIn', '');--During the day-end period, only users having elevated privilege are allowed to log-in.
SELECT * FROM localization.add_localized_resource('Messages', 'ar', 'EODLogsOffUsers', '');--When you initialize day-end operation, the already logged-in application users including you are logged off on 120 seconds.
SELECT * FROM localization.add_localized_resource('Messages', 'ar', 'EODProcessIsIrreversible', '');--This process is irreversible.
SELECT * FROM localization.add_localized_resource('Messages', 'ar', 'EODRoutineTasks', '');--During EOD operation, routine tasks such as interest calculation, settlements, and report generation are performed.
SELECT * FROM localization.add_localized_resource('Messages', 'ar', 'EODTransactionPosting', '');--When you perform EOD operation for a particular date, no transaction on that date or before can be altered, changed, or deleted.
SELECT * FROM localization.add_localized_resource('Messages', 'ar', 'InvalidFile', '');--Invalid file!
SELECT * FROM localization.add_localized_resource('Messages', 'ar', 'TempDirectoryNullError', '');--Cannot create an image when the temp directory is null.
SELECT * FROM localization.add_localized_resource('Messages', 'ar', 'UploadFilesDeleted', '');--The uploaded files were successfully deleted.
SELECT * FROM localization.add_localized_resource('Questions', 'ar', 'AreYouSure', '');--Are you sure?
SELECT * FROM localization.add_localized_resource('Questions', 'ar', 'CannotAccessAccount', '');--Cannot access your account?
SELECT * FROM localization.add_localized_resource('Questions', 'ar', 'ConfirmAnalyze', '');--This will lock client database access during execution. Are you sure you want to execute this action right now?
SELECT * FROM localization.add_localized_resource('Questions', 'ar', 'ConfirmVacuum', '');--This will lock client database access during execution. Are you sure you want to execute this action right now?
SELECT * FROM localization.add_localized_resource('Questions', 'ar', 'ConfirmVacuumFull', '');--This will lock client database access during execution. Are you sure you want to execute this action right now?
SELECT * FROM localization.add_localized_resource('Questions', 'ar', 'WhatIsYourHomeCurrency', '');--What Is Your Home Currency?
SELECT * FROM localization.add_localized_resource('Questions', 'ar', 'WithdrawalReason', '');--Why do you want to withdraw this transaction?
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'Select', '');--Select
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'account', '');--Account
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'account_id', '');--Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'account_master', '');--Account Master
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'account_master_code', '');--Account Master Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'account_master_id', '');--Account Master Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'account_master_name', '');--Account Master Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'account_name', '');--Account Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'account_number', '');--Account Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'address', '');--Address
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'address_line_1', '');--Address Line 1
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'address_line_2', '');--Address Line 2
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ageing_slab_id', '');--Ageing Slab Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ageing_slab_name', '');--Ageing Slab Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'allow_credit', '');--Allow Credit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'allow_sales', '');--Allow Sales
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'allow_transaction_posting', '');--Allow Transaction Posting
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'amount', '');--Amount
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'amount_from', '');--Amount From
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'amount_to', '');--Amount To
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'analyze_count', '');--Analyze Count
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'api_access_policy_id', '');--API Access Policy Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'api_access_policy_uix', '');--Duplicate Entry for API Access Policy
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'applied_on_shipping_charge', '');--Applied on Shipping Charge
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'audit_ts', '');--Audit Timestamp
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'audit_user_id', '');--Audit User Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'auto_trigger_on_sales', '');--Automatically Trigger on Sales
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'autoanalyze_count', '');--Autoanalyze Count
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'autovacuum_count', '');--Autovacuum Count
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'background_color', '');--Background Color
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'balance', '');--Balance
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'bank_account_number', '');--Bank Account Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'bank_account_type', '');--Bank Account Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'bank_accounts_account_id_chk', '');--The selected item is not a valid bank account.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'bank_accounts_pkey', '');--Duplicate bank account.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'bank_address', '');--Bank Address
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'bank_branch', '');--Bank Branch
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'bank_contact_number', '');--Bank Contact Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'bank_name', '');--Bank Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'base_unit_id', '');--Base Unit Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'base_unit_name', '');--Base Unit Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'based_on_shipping_address', '');--Based On Shipping Address
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'bonus_rate', '');--Bonus Rate
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'bonus_slab_code', '');--Bonus Slab Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'bonus_slab_detail_id', '');--Bonus Slab Detail Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'bonus_slab_details_amounts_chk', '');--The field "AmountTo" must be greater than "AmountFrom".
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'bonus_slab_id', '');--Bonus Slab Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'bonus_slab_name', '');--Bonus Slab Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'book', '');--Book
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'brand', '');--Brand
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'brand_code', '');--Brand Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'brand_id', '');--Brand Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'brand_name', '');--Brand Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'can_change_password', '');--Can Change Password
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'can_self_verify', '');--Can Self Verify
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'can_verify_gl_transactions', '');--Can Verify Gl Transactions
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'can_verify_purchase_transactions', '');--Can Verify Purchase Transactions
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'can_verify_sales_transactions', '');--Can Verify Sales Transactions
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'card_type_code', '');--Card Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'card_type_id', '');--Card Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'card_type_name', '');--Card Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cash_flow_heading', '');--Cash Flow Heading
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cash_flow_heading_cash_flow_heading_type_chk', '');--Invalid Cashflow Heading Type. Allowed values: O, I, F.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cash_flow_heading_code', '');--Cash Flow Heading Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cash_flow_heading_id', '');--Cash Flow Heading Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cash_flow_heading_name', '');--Cash Flow Heading Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cash_flow_heading_type', '');--Cashflow Heading Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cash_flow_master_code', '');--Cash Flow Master Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cash_flow_master_id', '');--Cash Flow Master Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cash_flow_master_name', '');--Cash Flow Master Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cash_flow_setup_id', '');--Cashflow Setup Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cash_repositories_cash_repository_code_uix', '');--Duplicate Cash Repository Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cash_repositories_cash_repository_name_uix', '');--Duplicate Cash Repository Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cash_repository', '');--Cash Repository
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cash_repository_code', '');--Cash Repository Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cash_repository_id', '');--Cash Repository Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cash_repository_name', '');--Cash Repository Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cell', '');--Cell
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'charge_interest', '');--Charge Interest
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'check_nexus', '');--Check Nexus
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'checking_frequency', '');--Checking Frequency
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'checking_frequency_id', '');--Checking Frequency Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'city', '');--City
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'collecting_account', '');--Collecting Account
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'collecting_account_id', '');--Collecting Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'collecting_tax_authority', '');--Collecting Tax Authority
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'collecting_tax_authority_id', '');--Collecting Tax Authority Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'commision_rate', '');--Commission Rate
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'commission_rate', '');--Commission Rate
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'company_name', '');--Company Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'compare_unit_id', '');--Compare Unit Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'compare_unit_name', '');--Compare Unit Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'compound_item', '');--Compound Item
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'compound_item_code', '');--Compound Item Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'compound_units_chk', '');--The base unit id cannot same as compare unit id.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'compounding_frequency', '');--Compounding Frequency
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'confidential', '');--Confidential
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'contact_address_line_1', '');--Contact Address Line 1
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'contact_address_line_2', '');--Contact Address Line 2
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'contact_cell', '');--Contact Cell
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'contact_city', '');--Contact City
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'contact_country', '');--Contact Country
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'contact_email', '');--Contact Email
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'contact_number', '');--Contact Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'contact_person', '');--Contact Person
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'contact_phone', '');--Contact Phone
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'contact_po_box', '');--Contact Po Box
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'contact_state', '');--Contact State
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'contact_street', '');--Contact Street
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cost_center_code', '');--Cost Center Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cost_center_id', '');--Cost Center Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cost_center_name', '');--Cost Center Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cost_of_goods_sold_account_id', '');--COGS Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cost_price', '');--Cost Price
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cost_price_includes_tax', '');--Cost Price Includes Tax
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'counter_code', '');--Counter Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'counter_id', '');--Counter Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'counter_name', '');--Counter Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'country', '');--Country
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'country_code', '');--Country Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'country_id', '');--Country Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'country_name', '');--Country Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'county', '');--County
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'county_code', '');--County Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'county_id', '');--County Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'county_name', '');--County Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'county_sales_tax', '');--County Sales Tax
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'county_sales_tax_code', '');--County Sales Tax Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'county_sales_tax_id', '');--County Sales Tax Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'county_sales_tax_name', '');--County Sales Tax Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'credit', '');--Credit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cst_number', '');--CST Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'currency', '');--Currency
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'currency_code', '');--Currency Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'currency_name', '');--Currency Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'currency_symbol', '');--Currency Symbol
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'customer_pays_fee', '');--Customer Pays Fee
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'date_of_birth', '');--Date Of Birth
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'debit', '');--Debit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'default_cash_account_id', '');--Default Cash Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'default_cash_repository_id', '');--Default Cash Repository Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'department_code', '');--Department Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'department_id', '');--Department Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'department_name', '');--Department Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'description', '');--Description
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'discount', '');--Discount
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'due_days', '');--Due Days
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'due_frequency', '');--Due Frequency
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'due_frequency_id', '');--Due Frequency Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'due_on_date', '');--Due on Date
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'effective_from', '');--Effective From
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'elevated', '');--Elevated
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'email', '');--Email
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ends_on', '');--Ends On
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'entity_id', '');--Entity Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'entity_name', '');--Entity Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'entry_ts', '');--Entry Ts
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'er', '');--ER
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'exclude_from_purchase', '');--Exclude From Purchase
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'exclude_from_sales', '');--Exclude From Sales
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'external_code', '');--External Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'factory_address', '');--Factory Address
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'fax', '');--Fax
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'first_name', '');--First Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'fiscal_year_code', '');--Fiscal Year Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'fiscal_year_name', '');--Fiscal Year Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'flag_id', '');--Flag Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'flag_type_id', '');--Flag Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'flag_type_name', '');--Flag Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'flagged_on', '');--Flagged On
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'foreground_color', '');--Foreground Color
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'frequency_code', '');--Frequency Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'frequency_id', '');--Frequency Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'frequency_name', '');--Frequency Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'frequency_setup_code', '');--Frequency Setup Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'frequency_setup_id', '');--Frequency Setup Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'from_days', '');--From Days
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'full_name', '');--Full Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'gl_head', '');--GL Head
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'gl_verification_limit', '');--Gl Verification Limit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'grace_period', '');--Grace Period
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'has_child', '');--Has Child
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'height_in_centimeters', '');--Height In Centimeters
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'hot_item', '');--Hot item
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'http_action_code', '');--HTTP Action Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'hundredth_name', '');--Hundredth Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'id', '');--Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'includes_tax', '');--Includes Tax
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'income_tax_rate', '');--Income Tax Rate
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'industry_id', '');--Industry Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'industry_name', '');--Industry Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'interest_compounding_frequency_id', '');--Interest Compounding Frequency Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'interest_rate', '');--Interest Rate
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'inventory_account_id', '');--Inventory Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_active', '');--Is Active
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_added', '');--Is Added
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_admin', '');--Is Admin
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_cash', '');--Is Cash
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_debit', '');--Is Debit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_flat_amount', '');--Is Flat Amount
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_merchant_account', '');--Is Merchant Account
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_party', '');--Is Party
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_purchase', '');--Is Purchase
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_rectangular', '');--Is Rectangular
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_sales', '');--Is Sales
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_summary', '');--Is Summary
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_supplier', '');--Is Supplier
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_system', '');--Is System
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_transaction_node', '');--Is Transaction Node
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_vat', '');--Is Vat
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'item', '');--Item
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'item_code', '');--Item Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'item_cost_price_id', '');--Item Cost Price Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'item_cost_prices_unit_chk', '');--Invalid unit provided.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'item_group', '');--Item Group
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'item_group_code', '');--Item Group Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'item_group_id', '');--Item Group Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'item_group_name', '');--Item Group Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'item_id', '');--Item Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'item_name', '');--Item Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'item_opening_inventory_unit_chk', '');--Invalid unit provided.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'item_selling_price_id', '');--Item Selling Price Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'item_selling_prices_unit_chk', '');--Invalid unit provided.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'item_type_code', '');--Item Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'item_type_id', '');--Item Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'item_type_name', '');--Item Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'items_item_code_uix', '');--Duplicate item code.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'items_item_name_uix', '');--Duplicate item name.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'items_reorder_quantity_chk', '');--The reorder quantity must be great than or equal to the reorder level.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'last_analyze', '');--Last Analyze On
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'last_autoanalyze', '');--Last Autoanalyze On
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'last_autovacuum', '');--Last Autovacuum On
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'last_name', '');--Last Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'last_vacuum', '');--Last Vacuum On
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'late_fee', '');--Late Fee
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'late_fee_code', '');--Late Fee Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'late_fee_id', '');--Late Fee Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'late_fee_name', '');--Late Fee Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'late_fee_posting_frequency', '');--Late Fee Posting Frequency
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'late_fee_posting_frequency_id', '');--Late Fee Posting Frequency Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'lc_credit', '');--LC Credit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'lc_debit', '');--LC Debit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'lead_source_code', '');--Lead Source Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'lead_source_id', '');--Lead Source Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'lead_source_name', '');--Lead Source Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'lead_status_code', '');--Lead Status Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'lead_status_id', '');--Lead Status Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'lead_status_name', '');--Lead Status Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'lead_time_in_days', '');--Lead Time In Days
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'length_in_centimeters', '');--Length In Centimeters
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'machinable', '');--Machinable
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'maintain_stock', '');--Maintain Stock
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'maintained_by_user_id', '');--Maintained By User Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'maximum_credit_amount', '');--Maximum Credit Amount
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'maximum_credit_period', '');--Maximum Credit Period
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'merchant_account_id', '');--Merchant Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'merchant_fee_setup_id', '');--Merchant Fee Setup Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'middle_name', '');--Middle Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'nick_name', '');--Nick Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'non_gl_stock_details_unit_chk', '');--Invalid unit provided.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'normally_debit', '');--Normally Debit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'office', '');--Office
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'office_code', '');--Office Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'office_id', '');--Office Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'office_name', '');--Office Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'opportunity_stage_code', '');--Opportunity Stage Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'opportunity_stage_id', '');--Opportunity Stage Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'opportunity_stage_name', '');--Opportunity Stage Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'pan_number', '');--Pan Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'parent', '');--Parent
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'parent_account_id', '');--Parent Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'parent_account_master_id', '');--Parent Account Master Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'parent_account_name', '');--Parent Account Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'parent_account_number', '');--Parent Account Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'parent_cash_flow_heading_id', '');--Parent Cash Flow Heading Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'parent_cash_repository', '');--Parent Cash Repository
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'parent_cash_repository_id', '');--Parent Cash Repository Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'parent_cr_code', '');--Parent CR Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'parent_cr_name', '');--Parent CR Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'parent_industry_id', '');--Parent Industry Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'parent_industry_name', '');--Parent Industry Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'parent_item_group_id', '');--Parent Item Group Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'parent_office', '');--Parent Office
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'parent_office_id', '');--Parent Office Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'party', '');--Party
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'party_code', '');--Party Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'party_id', '');--Party Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'party_name', '');--Party Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'party_type', '');--Party Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'party_type_code', '');--Party Tpye Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'party_type_id', '');--Party Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'party_type_name', '');--Party Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'password', '');--Password
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'payment_card_code', '');--Payment Card Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'payment_card_id', '');--Payment Card Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'payment_card_name', '');--Payment Card Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'payment_term', '');--Payment Term
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'payment_term_code', '');--Payment Term Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'payment_term_id', '');--Payment Term Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'payment_term_name', '');--Payment Term Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'phone', '');--Phone
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'po_box', '');--Po Box
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'poco_type_name', '');--Poco Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'policy_id', '');--Policy id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'preferred_shipping_mail_type', '');--Preferred Shipping Mail Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'preferred_shipping_mail_type_id', '');--Preferred Shipping Mail Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'preferred_shipping_package_shape', '');--Preferred Shipping Package Shape
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'preferred_supplier', '');--Preferred Supplier
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'preferred_supplier_id', '');--Preferred Supplier Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'price', '');--Price
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'price_from', '');--Price From
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'price_to', '');--Price To
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'price_type_code', '');--Price Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'price_type_id', '');--Price Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'price_type_name', '');--Price Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'priority', '');--Priority
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'purchase_account_id', '');--Purchase Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'purchase_discount_account_id', '');--Purchase Discount Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'purchase_verification_limit', '');--Purchase Verification Limit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'quantity', '');--Quantity
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'rate', '');--Rate
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'recurrence_type_id', '');--Recurrence Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'recurring_amount', '');--Recurring Amount
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'recurring_duration', '');--Recurring Duration
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'recurring_frequency', '');--Recurring Frequency
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'recurring_frequency_id', '');--Recurring Frequency Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'recurring_invoice', '');--Recurring Invoice
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'recurring_invoice_code', '');--Recurring Invoice Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'recurring_invoice_id', '');--Recurring Invoice Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'recurring_invoice_name', '');--Recurring Invoice Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'recurring_invoice_setup_id', '');--Recurring Invoice Setup Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'recurring_invoices_item_id_auto_trigger_on_sales_uix', '');--You cannot have more than one auto trigger on sales for this item.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'recurs_on_same_calendar_date', '');--Recurs on Same Calendar Date
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'registration_date', '');--Registration Date
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'registration_number', '');--Registration Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'relationship_officer_name', '');--Relationship Officer Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'relname', '');--Relation Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'reorder_level', '');--Reorder Level
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'reorder_quantity', '');--Reorder Quantity
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'reorder_unit', '');--Reorder Unit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'reorder_unit_id', '');--Reorder Unit Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'reporting_tax_authority', '');--Reporting Tax Authority
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'reporting_tax_authority_id', '');--Reporting Tax Authority Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'repository', '');--Repository
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'resource', '');--Resource
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'resource_id', '');--Resource Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'resource_key', '');--Resource Key
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'role_code', '');--Role Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'role_id', '');--Role Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'role_name', '');--Role Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'rounding_decimal_places', '');--Rounding Decimal Places
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'rounding_method', '');--Rounding Method
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'rounding_method_code', '');--Rounding Method Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'rounding_method_name', '');--Rounding Method Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_account_id', '');--Sales Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_discount_account_id', '');--Sales Discount Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_return_account_id', '');--Sales Return Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_tax', '');--Sales Tax
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_tax_code', '');--Sales Tax Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_tax_detail_code', '');--Sales Tax Detail Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_tax_detail_id', '');--Sales Tax Detail Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_tax_detail_name', '');--Sales Tax Detail Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_tax_details_rate_chk', '');--Rate should not be empty unless you have selected state or county tax. Similarly, you cannot provide both rate and choose to have state or county tax.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_tax_exempt', '');--Sales Tax Exempt
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_tax_exempt_code', '');--Sales Tax Exempt Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_tax_exempt_detail_id', '');--Sales Tax Exempt Detail Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_tax_exempt_id', '');--Sales Tax Exempt Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_tax_exempt_name', '');--Sales Tax Exempt Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_tax_exempts_price_to_chk', '');--The field "PriceFrom" must be less than "PriceTo".
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_tax_id', '');--Sales Tax Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_tax_name', '');--Sales Tax Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_tax_type', '');--Sales Tax Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_tax_type_code', '');--Sales Tax Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_tax_type_id', '');--Sales Tax Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_tax_type_name', '');--Sales Tax Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_team_code', '');--Sales Team Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_team_id', '');--Sales Team Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_team_name', '');--Sales Team Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_verification_limit', '');--Sales Verification Limit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'salesperson_bonus_setup_id', '');--Salesperson Bonus Setup Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'salesperson_code', '');--Salesperson Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'salesperson_id', '');--Salesperson Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'salesperson_name', '');--Salesperson Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'self_verification_limit', '');--Self Verification Limit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'selling_price', '');--Selling Price
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'selling_price_includes_tax', '');--Selling Price Includes Tax
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'shipper_code', '');--Shipper Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'shipper_id', '');--Shipper Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'shipper_name', '');--Shipper Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'shipping_address_code', '');--Shipping Address Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'shipping_address_id', '');--Shipping Address Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'shipping_mail_type_code', '');--Shipping Mail Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'shipping_mail_type_id', '');--Shipping Mail Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'shipping_mail_type_name', '');--Shipping Mail Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'shipping_package_shape_code', '');--Shipping Package Shape Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'shipping_package_shape_id', '');--Shipping Package Shape Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'shipping_package_shape_name', '');--Shipping Package Shape Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'slab_name', '');--Slab Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sst_number', '');--SST Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'starts_from', '');--Starts From
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'state', '');--State
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'state_code', '');--State Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'state_id', '');--State Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'state_name', '');--State Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'state_sales_tax', '');--State Sales Tax
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'state_sales_tax_code', '');--State Sales Tax Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'state_sales_tax_id', '');--State Sales Tax Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'state_sales_tax_name', '');--State Sales Tax Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'statement_reference', '');--Statement Reference
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'stock_details_unit_chk', '');--Invalid unit provided.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'store', '');--Store
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'store_code', '');--Store Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'store_id', '');--Store Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'store_name', '');--Store Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'store_type', '');--Store Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'store_type_code', '');--Store Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'store_type_id', '');--Store Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'store_type_name', '');--Store Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'stores_default_cash_account_id_chk', '');--Please select a valid Cash or Bank AccountId.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'stores_sales_tax_id_chk', '');--The chosen SalesTaxId is invalid for this office.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'street', '');--Street
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sub_total', '');--Sub Total
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sys_type', '');--Sys Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax', '');--Tax
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax_authority_code', '');--Tax Authority Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax_authority_id', '');--Tax Authority Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax_authority_name', '');--Tax Authority Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax_base_amount', '');--Tax Base Amount
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax_base_amount_type_code', '');--Tax Base Amount Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax_base_amount_type_name', '');--Tax Base Amount Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax_code', '');--Tax Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax_exempt_type', '');--Tax Exempt Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax_exempt_type_code', '');--Tax Exempt Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax_exempt_type_id', '');--Tax Exempt Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax_exempt_type_name', '');--Tax Exempt Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax_id', '');--Tax Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax_master', '');--Tax Master
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax_master_code', '');--Tax Master Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax_master_id', '');--Tax Master Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax_master_name', '');--Tax Master Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax_name', '');--Tax Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax_rate_type', '');--Tax Rate Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax_rate_type_code', '');--Tax Rate Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax_rate_type_name', '');--Tax Rate Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax_type_code', '');--Tax Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax_type_id', '');--Tax Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax_type_name', '');--Tax Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'to_days', '');--To Days
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'total', '');--Total
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'total_duration', '');--Total Duration
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'total_sales', '');--Total Sales
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tran_code', '');--Tran Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tran_type', '');--Tran Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'unit', '');--Unit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'unit_code', '');--Unit Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'unit_id', '');--Unit Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'unit_name', '');--Unit Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'url', '');--Url
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'use_tax_collecting_account', '');--Use Tax Collecting Account
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'use_tax_collecting_account_id', '');--Use Tax Collecting Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'user_id', '');--User Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'user_name', '');--User Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'vacuum_count', '');--Vacuum Count
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'valid_from', '');--Valid From
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'valid_till', '');--Valid Till
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'value', '');--Value
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'value_date', '');--Value Date
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'verify_gl_transactions', '');--Verify Gl Transactions
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'verify_purchase_transactions', '');--Verify Purchase Transactions
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'verify_sales_transactions', '');--Verify Sales Transactions
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'weight_in_grams', '');--Weight In Grams
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'width_in_centimeters', '');--Width In Centimeters
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'zip_code', '');--Zip Code
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AboutInitializingDayEnd', '');--About Initializing Day End
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AboutYourOffice', '');--About Your Office
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Access', '');--Access
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AccessIsDenied', '');--Access is denied.
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Account', '');--Account
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AccountId', '');--Account Id
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AccountMaster', '');--Account Master
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AccountName', '');--Account Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AccountNumber', '');--Account Number
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AccountOverview', '');--Account Overview
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AccountStatement', '');--Account Statement
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Action', '');--Action
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Actions', '');--Actions
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Actual', '');--Actual
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Add', '');--Add
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AddNew', '');--Add New
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Address', '');--Address
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AddressAndContactInfo', '');--Address & Contact Information
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AgeingSlabs', '');--Ageing Slabs
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AgentBonusSlabAssignment', '');--Bonus Slab Assignment
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AgentBonusSlabs', '');--Bonus Slab for Salespersons
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Alerts', '');--Alerts
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Amount', '');--Amount
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AmountInBaseCurrency', '');--Amount (In Base Currency)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AmountInHomeCurrency', '');--Amount (In Home Currency)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AnalyzeDatabse', '');--Analyze Databse
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Approve', '');--Approve
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ApproveThisTransaction', '');--Approve This Transaction
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ApprovedTransactions', '');--Approved Transactions
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AreYouSure', '');--Are you sure?
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AssignCashier', '');--Assign Cashier
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AttachmentsPlus', '');--Attachments (+)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AutoVerificationPolicy', '');--Autoverification Policy
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AutomaticallyApprovedByWorkflow', '');--Automatically Approved by Workflow
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Back', '');--Back
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'BackToPreviousPage', '');--Back to Previous Page
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'BackupConsole', '');--Backup Console
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'BackupDatabase', '');--Backup Database
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'BackupNow', '');--Backup Now
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Balance', '');--Balance
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'BalanceSheet', '');--Balance Sheet
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'BankAccounts', '');--Bank Accounts
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'BankTransactionCode', '');--Bank Transaction Code
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'BaseCurrency', '');--Base Currency
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'BaseUnitName', '');--Base Unit Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'BonusSlabDetails', '');--Bonus Slab Details for Salespersons
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Book', '');--Book
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Brand', '');--Brand
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Brands', '');--Brands
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Browse', '');--Browse
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CSTNumber', '');--CST Number
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Cancel', '');--Cancel
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CashFlowHeading', '');--Cash Flow Heading
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CashFlowHeadings', '');--Cash Flow Headings
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CashFlowSetup', '');--Cash Flow Setup
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CashRepositories', '');--Cash Repositories
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CashRepository', '');--Cash Repository
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CashRepositoryBalance', '');--Cash Repository Balance
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CashTransaction', '');--Cash Transaction
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ChangePassword', '');--Change Password
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ChangeSideWhenNegative', '');--Change Side When Negative
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ChartOfAccounts', '');--Chart of Accounts
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Check', '');--Check
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CheckAll', '');--Check All
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Checklists', '');--Checklists
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Clear', '');--Clear
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Close', '');--Close
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ClosedTransactions', '');--Closed Transactions
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ClosingBalance', '');--Closing Balance
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ClosingCredit', '');--Closing Credit
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ClosingDebit', '');--Closing Debit
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Comment', '');--Comment
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CompoundItemDetails', '');--Compound Item Details
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CompoundItems', '');--Compound Items
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CompoundUnitsOfMeasure', '');--Compound Units of Measure
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Confidential', '');--Confidential
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ConfirmPassword', '');--Confirm Password
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ConvertedtoBaseCurrency', '');--Converted to Base Currency
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ConvertedtoHomeCurrency', '');--Converted to Home Currency
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CostCenter', '');--Cost Center
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CostCenters', '');--Cost Centers
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Counters', '');--Counters
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Counties', '');--Counties
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Countries', '');--Countries
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CountySalesTaxes', '');--County Sales Taxes
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CreateaUserAccountforYourself', '');--Create a User Account for Yourself
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CreatedOn', '');--Created On
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Credit', '');--Credit
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CreditAllowed', '');--Credit Allowed
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CreditTotal', '');--Credit Total
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CtrlAltA', '');--Ctrl + Alt + A
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CtrlAltC', '');--Ctrl + Alt + C
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CtrlAltD', '');--Ctrl + Alt + D
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CtrlAltS', '');--Ctrl + Alt + S
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CtrlAltT', '');--Ctrl + Alt + T
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CtrlReturn', '');--Ctrl + Return
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Currencies', '');--Currencies
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Currency', '');--Currency
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CurrencyCode', '');--Currency Code
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CurrencyName', '');--Currency Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CurrencySymbol', '');--Currency Symbol
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CurrentIP', '');--Current IP
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CurrentLoginOn', '');--Current Login On
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CurrentPassword', '');--Current Password
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CurrentPeriod', '');--Current Period
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CustomerCode', '');--Customer Code
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CustomerName', '');--Customer Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CustomerPanNumber', '');--Customer PAN #
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CustomerPaysFees', '');--Customer Pays Fees
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DatabaseBackups', '');--Database Backups
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DatabaseStatistics', '');--Database Statistics
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Date', '');--Date
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Days', '');--Days
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Debit', '');--Debit
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DebitTotal', '');--Debit Total
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DefaultAddress', '');--Default Address
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DefaultCurrency', '');--Default Currency
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DefaultReorderQuantityAbbreviated', '');--Default Reorder Qty
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Definition', '');--Definition
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Delete', '');--Delete
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DeleteSelected', '');--Delete Selected
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DeliverTo', '');--Deliver To
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Department', '');--Department
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Departments', '');--Departments
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Difference', '');--Difference
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DirectPurchase', '');--Direct Purchase
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DirectSales', '');--Direct Sales
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Discount', '');--Discount
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Documentation', '');--Documentation
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Download', '');--Download
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DownloadSourceCode', '');--Download Source Code
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DueDate', '');--Due Date
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EODConsole', '');--EOD Console
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ER', '');--ER
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ERToBaseCurrency', '');--Exchange Rate (To Base Currency)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ERToHomeCurrency', '');--Exchange Rate (To Home Currency)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EditSelected', '');--Edit Selected
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EmailThisDelivery', '');--Email This Delivery
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EmailThisInvoice', '');--Email This Invoice
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EmailThisNote', '');--Email This Note
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EmailThisOrder', '');--Email This Order
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EmailThisQuotation', '');--Email This Quotation
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EmailThisReceipt', '');--Email This Receipt
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EmailThisReturn', '');--Email This Return
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EndOfDayOperation', '');--End of Day Operation
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EnterBackupName', '');--Enter Backup Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EnterNewPassword', '');--Enter a New Password
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EnteredBy', '');--Entered By
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Entities', '');--Entities
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ExchangeRate', '');--Exchange Rate
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Execute', '');--Execute
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ExternalCode', '');--External Code
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Factor', '');--Factor
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Fax', '');--Fax
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'FilePath', '');--File Path
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'FinalDueAmountinBaseCurrency', '');--Final Due Amount in Base Currency
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'FirstPage', '');--First Page
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'FiscalYear', '');--Fiscal Year
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Flag', '');--Flag
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'FlagBackgroundColor', '');--Flag Background Color
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'FlagDescription', '');--You can mark this transaction with a flag, however you will not be able to see the flags created by other users.
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'FlagForegroundColor', '');--Flag Foreground Color
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'FlagThisTransaction', '');--Flag This Transaction
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'FlaggedTransactions', '');--Flagged Transactions
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Flags', '');--Flags
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Frequencies', '');--Frequencies
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'From', '');--From
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'GLAdvice', '');--GL Advice
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'GLDetails', '');--GL Details
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'GLHead', '');--GL Head
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Go', '');--Go
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'GoToTop', '');--GoToTop
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'GoodsReceiptNote', '');--Goods Receipt Note
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'GrandTotal', '');--Grand Total
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Home', '');--Home
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'HomeCurrency', '');--Home Currency
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'HundredthName', '');--Hundredth Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Id', '');--Id
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'InVerificationStack', '');--In Verification Stack
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'IncludeZeroBalanceAccounts', '');--Include Zero Balance Accounts
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Industries', '');--Industries
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'InitializeDayEnd', '');--Initialize Day End
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'InstallMixERP', '');--Install MixERP
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'InstrumentCode', '');--Instrument Code
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'InterestApplicable', '');--Interest Applicable
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'InvalidDate', '');--This is not a valid date.
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'InvalidImage', '');--This is not a valid image.
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'InventoryAdvice', '');--Inventory Advice
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'InvoiceAmount', '');--Invoice Amount
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'InvoiceDetails', '');--Invoice Details
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'IsCash', '');--Is Cash
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'IsEmployee', '');--Is Employee
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'IsParty', '');--Is Party
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'IsSystemAccount', '');--Is System Account
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ItemCode', '');--Item Code
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ItemCostPrices', '');--Item Cost Prices
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ItemGroup', '');--Item Group
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ItemGroups', '');--Item Groups
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ItemId', '');--Item Id
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ItemName', '');--Item Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ItemOverview', '');--Item Overview
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ItemSellingPrices', '');--Item Selling Prices
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ItemType', '');--Item Type
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ItemTypes', '');--Item Types
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Items', '');--Items
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ItemsBelowReorderLevel', '');--Items Below Reorder Level
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'JournalVoucher', '');--Journal Voucher
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'JournalVoucherEntry', '');--Journal Voucher Entry
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'KeyColumnEmptyExceptionMessage', '');--The property 'KeyColumn' cannot be left empty.
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'LCCredit', '');--LC Credit
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'LCDebit', '');--LC Debit
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'LastAccessedOn', '');--Last Accessed On
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'LastLoginIP', '');--Last Login IP
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'LastLoginOn', '');--Last Login On
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'LastPage', '');--Last Page
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'LastPaymentDate', '');--Last Payment Date
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'LastWrittenOn', '');--Last Written On
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'LateFees', '');--Late Fees
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'LeadSources', '');--Lead Sources
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'LeadStatuses', '');--Lead Statuses
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'LeadTime', '');--Lead Time
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ListItems', '');--List Items
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Load', '');--Load
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'LoggedInTo', '');--Logged in to
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ManageProfile', '');--Manage Profile
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'MaximumCreditAmount', '');--Maximum Credit Amount
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'MaximumCreditPeriod', '');--Maximum Credit Period
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'MenuAccessPolicy', '');--Menu Access Policy
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'MenuCode', '');--Menu Code
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'MenuId', '');--Menu Id
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'MenuText', '');--Menu Text
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'MerchantFeeInPercent', '');--Merchant Fee (In percent)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'MerchantFeeSetup', '');--Merchant Fee Setup
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'MergeBatchToGRN', '');--Merge Batch to GRN
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'MergeBatchToSalesDelivery', '');--Merge Batch to Sales Delivery
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'MergeBatchToSalesOrder', '');--Merge Batch to Sales Order
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'MixERPDocumentation', '');--MixERP Documentation
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'MixERPLinks', '');--MixERP Links
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'MixERPOnFacebook', '');--MixERP on Facebook
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Name', '');--Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'NewJournalEntry', '');--New Journal Entry
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'NewPassword', '');--New Password
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'NextPage', '');--Next Page
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'No', '');--No
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'NonTaxableSales', '');--Nontaxable Sales
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'None', '');--None
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'NormallyDebit', '');--Normally Debit
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'NothingSelected', '');--Nothing selected!
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Notifications', '');--Notifications
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'OK', '');--OK
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Office', '');--Office
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'OfficeInformation', '');--Office Information
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'OfficeName', '');--Office Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'OfficeNickName', '');--Office Nick Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'OfficeSetup', '');--Office Setup
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'OnlyNumbersAllowed', '');--Please type a valid number.
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'OpeningInventory', '');--Opening Inventory
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'OpportunityStages', '');--Opportunity Stages
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'OtherDetails', '');--Other Details
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PANNumber', '');--PAN Number
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PageN', '');--Page {0}
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ParentAccount', '');--Parent Account
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Parties', '');--Parties
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Party', '');--Party
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PartyCode', '');--Party Code
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PartyName', '');--Party Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PartySummary', '');--Party Summary
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PartyType', '');--Party Type
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PartyTypes', '');--Party Types
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Password', '');--Password
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PasswordUpdated', '');--Password was updated.
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PaymentCards', '');--Payment Cards
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PaymentTerms', '');--Payment Terms
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PerformEODOperation', '');--Perform EOD Operation
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PerformingEODOperation', '');--Performing EOD Operation
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Phone', '');--Phone
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PlaceReorderRequests', '');--Place Reorder Request(s)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PostTransaction', '');--Post Transaction
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PostedBy', '');--Posted By
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PostedDate', '');--Posted Date
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PreferredSupplier', '');--Preferred Supplier
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PreferredSupplierIdAbbreviated', '');--Pref SupId
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Prepare', '');--Prepare
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PreparedOn', '');--Prepared On
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Preview', '');--Preview
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PreviousBalance', '');--Previous Balance
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PreviousCredit', '');--Previous Credit
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PreviousDebit', '');--Previous Debit
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PreviousPage', '');--Previous Page
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PreviousPeriod', '');--Previous Period  
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Price', '');--Price
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PriceType', '');--Price Type
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Print', '');--Print
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PrintGlEntry', '');--Print GL Entry
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PrintReceipt', '');--Print Receipt
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ProfitAndLossStatement', '');--Profit & Loss Statement
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Progress', '');--Progress
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PurchaseInvoice', '');--Purchase Invoice
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PurchaseOrder', '');--Purchase Order
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PurchaseReturn', '');--Purchase Return
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PurchaseType', '');--Purchase Type
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Quantity', '');--Quantity
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'QuantityAbbreviated', '');--Qty
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'QuantityOnHandAbbreviated', '');--Qty (On Hand)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Rate', '');--Rate
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Reason', '');--Reason
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Receipt', '');--Receipt
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ReceiptAmount', '');--Receipt Amount
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ReceiptCurrency', '');--Receipt Currency
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ReceiptType', '');--Receipt Type
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ReceivedAmountInaboveCurrency', '');--Received Amount (In above Currency)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ReceivedCurrency', '');--Received Currency
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'RecurringInvoiceSetup', '');--Recurring Invoice Setup
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'RecurringInvoices', '');--Recurring Invoices
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ReferenceNumber', '');--Reference Number
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ReferenceNumberAbbreviated', '');--Ref#
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'RefererenceNumberAbbreviated', '');--Ref #
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'RegistrationDate', '');--Registration Date
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Reject', '');--Reject
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'RejectThisTransaction', '');--Reject This Transaction
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'RejectedTransactions', '');--Rejected Transactions
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'RememberMe', '');--Remember Me
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ReorderLevel', '');--Reorder Level
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ReorderQuantityAbbreviated', '');--Reorder Qty
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ReorderUnitName', '');--Reorder Unit Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'RequiredField', '');--This is a required field.
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'RequiredFieldDetails', '');--The fields marked with asterisk (*) are required.
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'RequiredFieldIndicator', '');-- *
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Reset', '');--Reset
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'RestrictedTransactionMode', '');--Restricted Transaction Mode
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'RetainedEarnings', '');--Retained Earnings
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Return', '');--Return
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ReturnToView', '');--Return to View
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Role', '');--Role
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Roles', '');--Roles
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'RowNumber', '');--Row Number
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'RunningTotal', '');--Running Total
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SSTNumber', '');--SST Number
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SalesByMonthInThousands', '');--Sales By Month (In Thousands)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SalesByOfficeInThousands', '');--Sales By Office (In Thousands)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SalesDelivery', '');--Sales Delivery
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SalesDeliveryNote', '');--Delivery Note
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SalesInvoice', '');--Sales Invoice
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SalesOrder', '');--Sales Order
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SalesPersons', '');--Salespersons
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SalesQuotation', '');--Sales Quotation
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SalesReceipt', '');--Sales Receipt
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SalesReturn', '');--Sales Return
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SalesTaxDetails', '');--Sales Tax Details
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SalesTaxExemptDetails', '');--Sales Tax Exempt Details
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SalesTaxExempts', '');--Sales Tax Exempts
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SalesTaxTypes', '');--Sales Tax Types
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SalesTaxes', '');--Sales Taxes
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SalesTeams', '');--Sales Teams
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SalesType', '');--Sales Type
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Salesperson', '');--Salesperson
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Save', '');--Save
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Saving', '');--Saving
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Select', '');--Select
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SelectCustomer', '');--Select Customer
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SelectFlag', '');--Select a Flag
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SelectLanguage', '');--Select Language
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SelectOffice', '');--Select Office
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SelectParty', '');--Select Party
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SelectPaymentCard', '');--Select Payment Card
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SelectSupplier', '');--Select Supplier
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SelectUnit', '');--Select Unit
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SelectUser', '');--Select User
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SelectYourBranch', '');--Select Your Branch
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Shipper', '');--Shipper
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Shippers', '');--Shippers
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ShippingAddress', '');--Shipping Address
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ShippingAddressMaintenance', '');--Shipping Address Maintenance
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ShippingAddresses', '');--Shipping Address(es)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ShippingCharge', '');--Shipping Charge
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ShippingCompany', '');--Shipping Company
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Show', '');--Show
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ShowAll', '');--Show All
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ShowCompact', '');--Show Compact
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SignIn', '');--Sign In
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SignOut', '');--Sign Out
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SigningIn', '');--Signing In
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Start', '');--Start
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'StateSalesTaxes', '');--State Sales Taxes
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'StatementOfCashFlows', '');--Statement of Cash Flows
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'StatementReference', '');--Statement Reference
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'States', '');--States
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Status', '');--Status
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'StockAdjustment', '');--Stock Adjustment
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'StockTransaction', '');--Stock Transaction
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'StockTransferJournal', '');--Stock Transfer Journal
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Store', '');--Store
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'StoreName', '');--Store Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'StoreTypes', '');--Store Types
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Stores', '');--Stores
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SubTotal', '');--Sub Total
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SubmitBugs', '');--Submit Bugs
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SupplierName', '');--Supplier Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Support', '');--Support
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TableEmptyExceptionMessage', '');--The property 'Table' cannot be left empty.
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TableSchemaEmptyExceptionMessage', '');--The property 'TableSchema' cannot be left empty.
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TaskCompletedSuccessfully', '');--The task was completed successfully.
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Tax', '');--Tax
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TaxAuthorities', '');--Tax Authorities
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TaxExemptTypes', '');--Tax Exempt Types
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TaxForm', '');--Tax Form
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TaxMaster', '');--Tax Master
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TaxRate', '');--Tax Rate
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TaxSetup', '');--Tax Setup
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TaxTotal', '');--Tax Total
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TaxTypes', '');--Tax Types
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TaxableSales', '');--Taxable Sales
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Tel', '');--Tel
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'To', '');--To
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TopSellingProductsOfAllTime', '');--Top Selling Products of All Time
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Total', '');--Total
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TotalDueAmount', '');--Total Due Amount
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TotalDueAmountCurrentOffice', '');--Total Due Amount (Current Office)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TotalDueAmountInBaseCurrency', '');--Total Due Amount (In Base Currency)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TotalSales', '');--Total Sales :
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TranCode', '');--Tran Code
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TranId', '');--Tran Id
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TranIdParameter', '');--TranId: #{0}
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TransactionDate', '');--Transaction Date
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TransactionDetails', '');--Transaction Details
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TransactionStatement', '');--TransactionStatement
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TransactionStatus', '');--Transaction Status
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TransactionSummary', '');--Transaction Summary
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TransactionTimestamp', '');--Transaction Timestamp
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TransactionType', '');--Transaction Type
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TransactionValue', '');--Transaction Value
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TransferDetails', '');--Transfer Details
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TrialBalance', '');--Trial Balance
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Type', '');--Type
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'UncheckAll', '');--Uncheck All
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Undo', '');--Undo
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Unit', '');--Unit
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'UnitId', '');--Unit Id
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'UnitName', '');--Unit Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'UnitsOfMeasure', '');--Units of Measure
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'UnknownError', '');--Operation failed due to an unknown error.
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Update', '');--Update
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Upload', '');--Upload
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'UploadAttachments', '');--Upload Attachments
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'UploadAttachmentsForThisTransaction', '');--Upload Attachments for This Transaction
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Url', '');--Url
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Use', '');--Use
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'User', '');--User
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'UserId', '');--User Id
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Username', '');--Username
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Users', '');--Users
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'VacuumDatabase', '');--Vacuum Database
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'VacuumFullDatabase', '');--Vacuum Database (Full)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ValueDate', '');--Value Date
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'VerificationReason', '');--Verification Reason
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'VerifiedBy', '');--Verified By
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'VerifiedOn', '');--VerifiedOn
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Verify', '');--Verify
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'View', '');--View
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ViewAttachments', '');--View Attachments
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ViewBackups', '');--View Backups
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ViewCustomerCopy', '');--View Customer Copy
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ViewEmptyExceptionMessage', '');--The property 'View' cannot be left empty.
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ViewSalesInovice', '');--View Sales Invoice
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ViewSchemaEmptyExceptionMessage', '');--The property 'ViewSchema' cannot be left empty.
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ViewThisAdjustment', '');--View This Adjustment
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ViewThisDelivery', '');--View This Delivery
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ViewThisInvoice', '');--View This Invoice
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ViewThisNote', '');--View This Note
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ViewThisOrder', '');--View This Order
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ViewThisQuotation', '');--View This Quotation
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ViewThisReturn', '');--View This Return
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ViewThisTransfer', '');--View This Transfer
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'VoucherVerification', '');--Voucher Verification
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'VoucherVerificationPolicy', '');--Voucher Verification Policy
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Warning', '');--Warning
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'WhichBank', '');--Which Bank?
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'WithdrawTransaction', '');--Withdraw Transaction
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'WithdrawnTransactions', '');--Withdrawn Transactions
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Workflow', '');--Workflow
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'WorldSalesStatistics', '');--World Sales Statistics
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Yes', '');--Yes
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'YourName', '');--Your Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'YourOffice', '');--Your Office
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'AccessIsDenied', '');--Access is denied.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'CannotCreateABackup', '');--Sorry, cannot create a database backup at this time.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'CannotCreateFlagTransactionTableNull', '');--Cannot create or update flag. Transaction table was not provided.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'CannotCreateFlagTransactionTablePrimaryKeyNull', '');--Cannot create or update flag. Transaction table primary key was not provided.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'CannotMergeAlreadyMerged', '');--The selected transactions contain items which have already been merged. Please try again.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'CannotMergeDifferentPartyTransaction', '');--Cannot merge transactions of different parties into a single batch. Please try again.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'CannotMergeIncompatibleTax', '');--Cannot merge transactions having incompatible tax types. Please try again.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'CannotMergeUrlNull', '');--Cannot merge transactions. The merge url was not provided.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'CashTransactionCannotContainBankInfo', '');--A cash transaction cannot contain bank transaction details.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'CompareAmountErrorMessage', '');--The amount to should be greater than the amount from.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'CompareDaysErrorMessage', '');--From days should be less than to days.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'ComparePriceErrorMessage', '');--Price from should be less than price to.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'ConfigurationError', '');--Cannot continue the task. Please correct configuration issues.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'ConfirmationPasswordDoesNotMatch', '');--The confirmation password does not match with the new password.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'CouldNotDetermineEmailImageParserType', '');--Could not determine image parser type for email.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'CouldNotRegisterJavascript', '');--Could not register JavaScript on this page because the page instance was invalid or empty.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'DateErrorMessage', '');--Selected date is invalid.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'DueFrequencyErrorMessage', '');--Due days should be 0 if due frequency id is selected.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'DuplicateEntry', '');--Duplicate entry.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'DuplicateFiles', '');--Duplicate files.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'GridViewEmpty', '');--Gridview is empty.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InsufficientBalanceInCashRepository', '');--There is no sufficient balance in the cash repository to process this transaction.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InsufficientStockWarning', '');--Only {0} {1} of {2} left in stock.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidAccount', '');--Invalid account.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidCashRepository', '');--Invalid cash repository.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidCostCenter', '');--Invalid cost center.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidData', '');--Invalid data.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidDate', '');--Invalid date.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidParameterName', '');--Invalid Npgsql parameter name {0}. . Make sure that the parameter name matches with your command text.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidParty', '');--Invalid party.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidPaymentTerm', '');--Invalid payment term.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidPriceType', '');--Invalid price type.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidReceiptMode', '');--Invalid receipt mode.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidSalesPerson', '');--Invalid salesperson.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidShippingCompany', '');--Invalid shipping company.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidStockTransaction', '');--Invalid stock transaction.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidStore', '');--Invalid store.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidSubTranBookInventoryDelivery', '');--Invalid SubTranBook "Inventory Delivery"
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidSubTranBookInventoryDirect', '');--Invalid SubTranBook "Inventory Direct"
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidSubTranBookInventoryInvoice', '');--Invalid SubTranBook "Inventory Invoice"
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidSubTranBookInventoryOrder', '');--Invalid SubTranBook "Inventory Order"
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidSubTranBookInventoryPayment', '');--Invalid SubTranBook "Inventory Payment"
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidSubTranBookInventoryQuotation', '');--Invalid SubTranBook "Inventory Quotation"
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidSubTranBookInventoryReceipt', '');--Invalid SubTranBook "Inventory Receipt"
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidSubTranBookInventoryReturn', '');--Invalid SubTranBook "Inventory Return"
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidSubTranBookPurchaseDelivery', '');--Invalid SubTranBook "Purchase Delivery"
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidSubTranBookPurchaseQuotation', '');--Invalid SubTranBook "Purchase Quotation"
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidSubTranBookPurchaseSuspense', '');--Invalid SubTranBook "Purchase Suspense"
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidSubTranBookPurchaseTransfer', '');--Invalid SubTranBook "Purchase Transfer"
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidSubTranBookSalesPayment', '');--Invalid SubTranBook "Sales Payment"
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidSubTranBookSalesSuspense', '');--Invalid SubTranBook "Sales Suspense"
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidSubTranBookSalesTransfer', '');--Invalid SubTranBook "Sales Transfer"
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidUser', '');--Invalid user.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'ItemErrorMessage', '');--You have to select either item id or  compound item id.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'LateFeeErrorMessage', '');--Late fee id and late fee posting frequency id both should be either selected or not.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'NegativeValueSupplied', '');--Negative value supplied.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'NewPasswordCannotBeOldPassword', '');--New password can not be old password.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'NoFileSpecified', '');--No file specified.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'NoTransactionToPost', '');--No transaction to post.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'NotAuthorized', '');--You are not authorized to access this resource at this time.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'NothingSelected', '');--Nothing selected.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'PasswordCannotBeEmpty', '');--Password cannot be empty.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'PleaseEnterCurrentPassword', '');--Please enter your current password.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'PleaseEnterNewPassword', '');--Please enter a new password.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'RecurringAmountErrorMessage', '');--Recurring amount should not be less than or equal to 0.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'ReferencingSidesNotEqual', '');--The referencing sides are not equal.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'RestrictedTransactionMode', '');--This establishment does not allow transaction posting.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'ReturnButtonUrlNull', '');--Cannot return this entry. The return url was not provided.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'UserIdOrPasswordIncorrect', '');--User id or password incorrect.
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EODBegun', '');--End of Day Processing Has Begun
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'EODBegunSaveYourWork', '');--Please close this window and save your existing work before you will be signed off automatically.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P1302', '');--Cannot post sales. Invalid cash account mapping on store.
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SelectCompany', '');--Select Company
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'BookDate', '');--Book Date
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'book_date', '');--Book Date
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Reconcile', '');--Reconcile
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CurrentBookDate', '');--Current Book Date
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'NewBookDate', '');--New Book Date
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Year', '');--Year
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Month', '');--Month
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Day', '');--Day
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'LoginView', '');--Login View
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'login_id', '');--Login Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ip_address', '');--IP Address
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'browser', '');--Browser
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'login_date_time', '');--Login Date Time
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'remote_user', '');--Remote User
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'culture', '');--Culture
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'role', '');--Role
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'card_type', '');--Card Type
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5003', '');--Stock transfer request can only contain debit entries.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5004', '');--Stock transfer delivery can only contain credit entries.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5005', '');--Cannot receive a stock transfer because the delivery contains no item.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5105', '');--There are still transactions in verification queue.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5106', '');--You cannot perform PL appropriation on an office group.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5205', '');--You cannot provide more than one store for this transaction.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5206', '');--You cannot provide more than one delivery destination store for this transaction.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5207', '');--The source and the destination stores cannot be the same.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5208', '');--The start date cannot be greater than end date.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P9250', '');--Access is denied. This transaction was rejected by administrator.
SELECT * FROM localization.add_localized_resource('Errors', 'ar', 'CannotDetermineAppDirectoryPath', '');--Cannot determine application directory path.
SELECT * FROM localization.add_localized_resource('Errors', 'ar', 'CannotDetermineFileFromDownloadUrl', '');--Cannot determine filename from the download url.
SELECT * FROM localization.add_localized_resource('Errors', 'ar', 'InvalidFileLocation', '');--Invalid file location.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'AddNewUsersDescription', '');--Create users and define various policies such as menu access policy and verification policy.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'BackingUp', '');--Backing up {0}.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'BackingUpForMigration', '');--Backing up file {0} for migration.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'CreateCashRepositoriesDescription', '');--Cash repository is a place where you store your cash and valuables. Example: Cash in Vault, Cash in Drawers.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'CreateCountySalesTaxDescription', '');--County sales tax is the direct consumption tax imposed by your county government when you make purchase or sales.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'CreateFiscalYearDescription', '');--Fiscal year is an accounting period of 12 months, used to prepare financial statements.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'CreateFrequenciesDescription', '');--The fiscal year is further divided into 12 frequencies, categorized as months, quarters, fiscal half, and fiscal year.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'CreateItemGroupsDescription', '');--An item group allows you to manage similar inventory items into meaningful groups and categories.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'CreateItemOrServiceDescription', '');--Inventory items may refer to the stockable products or nonstockable services that you buy and/or sell.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'CreatePartiesDescription', '');--The term "party" collectively refers to customer, supplier, or agent you have business with.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'CreateSalespersonsDescription', '');--Salespersons are the sales guys who sell your products and bring business to your company.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'CreateSalesTaxFormDescription', '');--Sales tax form is a combination of various entities such as State Tax, County Tax, Exemption, etc.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'CreateShippingCompanyDescription', '');--Shipping companies transfer the goods through land, sea, and/or air to your customers.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'CreateStateSalesTaxDescription', '');--State sales tax is the direct consumption tax imposed by your state government when you make purchase or sales.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'CreateStoresDescription', '');--Store is a place where you keep your goods. Example: Shop, Go-down, Warehouse.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'CreateTaxAuthorityDescription', '');--Tax authority is the government body or agency to whom you file your periodic tax reports to.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'CreateTaxMasterDescription', '');--Tax master is a category to group your taxes logically. Example: [Country] Taxation.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'DeletedApplicationFiles', '');--Existing application files were deleted successfully.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'DeletingApplicationFiles', '');--Deleting application files.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'DeletingApplicationFilesSucessMessage', '');--Existing application files were deleted successfully.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'DirectoryBackupCompletedSuccessfully', '');--Directory backup completed successfully.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'DirectoryRestoreSuccessful', '');--Directory restore completed successfully.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'DownloadingUpdateFrom', '');--Downloading update from {0}.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'DownloadSuccessful', '');--Download was successful.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'ExtractingDownloadedFile', '');--Extracting the downloaded file.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'ExtractionCompleted', '');--Extraction completed.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'FrequencySetupIsComplete', '');--Frequency setup is complete.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'InstanceIsUpToDate', '');--Your instance of MixERP is up to date.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'MenuAccessPolicyDescription', '');--Menu access policy enables you to define permission for a user to access menu item(s).
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NCountySalesTaxesDefined', '');--{0} county sales taxes defined.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NCashRepositoriesInThisOffice', '');--There are {0} cash repositories in this office.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NItemGroupsFound', '');--{0} item group(s) found.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NItemsFound', '');--{0} item(s) found.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NoAdditionalUserFound', '');--No additional user found.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NoCashRepositoryDefnied', '');--No cash repository defined.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NoCountySalesTaxDefined', '');--No county sales tax defined.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NoFiscalYearDefined', '');--No fiscal year defined.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NoPartyFound', '');--No party found.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NoSalespersonFound', '');--No salesperson found.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NoSalesTaxFormDefined', '');--No sales tax form defined.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NoShipperFound', '');--No shipper found.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NoStateSalesTaxDefined', '');--No state sales tax defined.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NoStorePresent', '');--No store present.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NoSupplierFound', '');--No supplier found.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NoTaxAuthorityDefined', '');--No tax authority defined.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NoTaxMasterDefined', '');--No tax master defined.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NotDefinedForNUsers', '');--Not defined for {0} users.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NOutOfNFrequenciesDefined', '');--{0} out of 12 frequencies defined.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NPartiesFound', '');--{0} parties found.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NSalespersonsFound', '');--{0} salespersons found.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NSalesTaxFormsDefined', '');--{0} sales tax forms defined.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NShippersFound', '');--{0} shippers found.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NStateSalesTaxesDefined', '');--{0} state sales taxes defined.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NStoresInThisOffice', '');--There are {0} stores in this office.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NTaxAuthoritiesFound', '');--{0} tax authorities found.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NTaxMasterFound', '');--{0} tax master(s) found.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'PatchedDatabase', '');--Patched the database.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'PatchingDatabase', '');--Patching the database.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'PercentCompleted', '');--{0} percent completed.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'PleaseSelectAFormFirst', '');--Please select a form first.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'ReleaseContainsNoUpdates', '');--This release does not contain any update.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'RestoringDirectory', '');--Restoring directory : {0}.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'RestoringFile', '');--Restoring file : {0}.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'TaskCompletedProgress', '');--{0} out of {1} tasks completed.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'TotalUsersN', '');--Total users : {0}.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'UpdateBackupMessage', '');--Before you perform the update operation, please make sure that you have latest backups handy.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'UpdateOperationCompletedSuccessfully', '');--The update operation completed successfully.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'closing_credit', '');--Closing Credit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'closing_debit', '');--Closing Debit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'current_period', '');--Current Period
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'exchange_rate', '');--Exchange Rate
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'foreign_currency_code', '');--Foreign Currency Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'key', '');--Key
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'merchant_account', '');--Merchant Account
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'payment_card', '');--Payment Card
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'previous_credit', '');--Previous Credit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'previous_debit', '');--Previous Debit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'previous_period', '');--Previous Period
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Acknowledged', '');--Acknowledged
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AcknowledgedBy', '');--Acknowledged By
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AddNewUsers', '');--Add New Users
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AllTasks', '');--All Tasks
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AttachmentParameters', '');--Attachment Parameters
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Authorize', '');--Authorize
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Authorized', '');--Authorized
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AuthorizedBy', '');--Authorized By
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'BackupDirectories', '');--Backup Directories
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CheckForUpdates', '');--Check for Updates
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CompleteTasks', '');--Complete Tasks
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CopyNewApplication', '');--Copy New Application
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CreateBackupFirst', '');--Create a Backup First
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CreateCashRepositories', '');--Create Cash Repositories
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CreateCountySalesTax', '');--Create County Sales Tax
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CreateParties', '');--Create Party
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CreateFiscalYear', '');--Create Fiscal Year
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CreateFrequencies', '');--Create Frequencies
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CreateItemGroups', '');--Create Item Groups
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CreateItemOrService', '');--Create Item or Service
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CreateSalespersons', '');--Create Salespersons
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CreateSalesTaxForm', '');--Create Sales Tax Form
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CreateShippingCompany', '');--Create Shipping Company
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CreateStateSalesTax', '');--Create State Sales Tax
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CreateStores', '');--Create Stores
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CreateTaxAuthority', '');--Create Tax Authority
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CreateTaxMaster', '');--Create Tax Master
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CurrencylayerParameters', '');--Currencylayer Parameters
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CustomFields', '');--Custom Fields
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DatabaseParameters', '');--Database Parameters
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DataType', '');--Data Type
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Deliver', '');--Deliver
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Delivered', '');--Delivered
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DeliveredBy', '');--Delivered By
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DeliveredFrom', '');--Delivered From
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DeliverFrom', '');--Deliver From
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DeliveredOn', '');--Delivered On
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DeliveredTo', '');--Delivered To
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Description', '');--Description
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DestinationStore', '');--Destination Store
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DownloadingFrom', '');--Downloading From
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DownloadingUpdate', '');--Downloading Update
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EditAndSend', '');--Edit & Send
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EditAndReceive', '');--Edit & Receive
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ExchangeRates', '');--Exchange Rates
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Export', '');--Export
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ExportToExcel', '');--Export to Excel
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ExportToDoc', '');--Export to Doc
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ExportToPDF', '');--Export to PDF
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ExtractingDownload', '');--Extracting Download
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'FieldOrder', '');--Field Order
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'FieldLabel', '');--Field Label
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'FieldName', '');--Field Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Filter', '');--Filter
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'FirstSteps', '');--First Steps
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'FirstTasks', '');--First Tasks
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'GoToBottom', '');--GoToBottom
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'HideForNow', '');--Hide for Now
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'IncompleteTasks', '');--Incomplete Tasks
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Message', '');--Message
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'MessagingParameters', '');--Messaging Parameters
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'MigratingFiles', '');--Migrating Files
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'MixERPParameters', '');--MixERP Parameters
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'NewReleaseAvailable', '');--A New Release Is Available
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'OpenExchangeRatesParameters', '');--OpenExchangeRates Parameters
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PublishedOn', '');--Published On
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Receive', '');--Receive
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Received', '');--Received
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ReceivedBy', '');--Received By
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ReceivedOn', '');--Received On
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ReleaseId', '');--Release Id
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'RemovingApplication', '');--Removing Application
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'RestoringDirectories', '');--Restoring Directories
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'RestoringMigrationFiles', '');--Restoring Migration Files
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ReturnHome', '');--Return Home
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'RunningDatabasePatch', '');--Running Database Patch
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ScrudFactoryParameters', '');--ScrudFactory Parameters
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Search', '');--Search
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SelectForm', '');--Select a Form
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Send', '');--Send
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Sent', '');--Sent
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SourceStore', '');--Source Store
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'StockTransferAuthorization', '');--Stock Transfer Authorization
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'StockTransferDelivery', '');--Stock Transfer Delivery
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'StockTransferRequest', '');--Stock Transfer Request
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'StockTransferAcknowledgement', '');--Stock Transfer Acknowledgement
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SuccessfullyUpdated', '');--Successfully Updated
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Switches', '');--Switches
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TagName', '');--Tag Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'UpdatedOn', '');--Updated On
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'UpdateConsole', '');--Update Console
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'UserManagement', '');--User Management
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'VersionName', '');--Version Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ViewThisAuthorization', '');--View This Authorization
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ViewThisAcknowledgement', '');--View This Acknowledgement
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ViewThisRequest', '');--View This Request
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Withdraw', '');--Withdraw
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Withdrawn', '');--Withdrawn
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidRequest', '');--Invalid Request.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidRequestId', '');--Invalid RequestId.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'StartDateGreaterThanEndDate', '');--The start date cannot be greater than end date.