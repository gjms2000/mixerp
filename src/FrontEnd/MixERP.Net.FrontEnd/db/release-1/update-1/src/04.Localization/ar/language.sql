/********************************************************************************************************************************************************
Contributors for this translation:
Nubiancc https://github.com/nubiancc

Arabic   ar  العربية
********************************************************************************************************************************************************/
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



SELECT * FROM localization.add_localized_resource('CommonResource', 'ar', 'CommonResource', 'تاريخ غير صحيح. يجب أن تكون أكبر من "{0}".');--Invalid date. Must be greater than "{0}".
SELECT * FROM localization.add_localized_resource('CommonResource', 'ar', 'CommonResource', 'تاريخ غير صحيح. يجب أن تكون أقل من "{0}".');--Invalid date. Must be less than "{0}".
SELECT * FROM localization.add_localized_resource('CommonResource', 'ar', 'CommonResource', 'تاريخ غير صحيح.');--Invalid date.
SELECT * FROM localization.add_localized_resource('CommonResource', 'ar', 'CommonResource', 'عذراً، لا توجد سجلات.');--Sorry, no record found.
SELECT * FROM localization.add_localized_resource('CommonResource', 'ar', 'CommonResource', 'هذا حقل مطلوب.');--This is a required field.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'لا يمكن حساب الفائدة. لم يتم توفير عدد الأيام في سنة.');--Cannot calculate interest. The number of days in a year was not provided.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'لا يمكن ترحيل المبيعات. تعيين الحساب النقدي غير صالح في المخزن.');--Cannot post sales. Invalid cash account mapping on store.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'بيانات غير صحيحة.');--Invalid data.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'اسم المستخدم غير صحيح.');--Invalid user name.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'لا يمكن أن تكون كلمة المرور فارغة.');--Password cannot be empty.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'يرجى كتابة كلمة مرور جديدة.');--Please provide a new password.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'قيمة تاريخ غير صالح.');--Invalid value date.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'تاريخ غير صالح.');--Invalid date.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'الفترة المحدد غير صالحة.');--Invalid period specified.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', ' معرف الشركة غير صالح.');--Invalid office id.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'شركة غير صالحة.');--Invalid office.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'مخزن غير صالح.');--Invalid store.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'خزينة غير صالحة.');--Invalid cash repository.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'الطرف غير صالح.');--Invalid party.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'صنف غير صالح.');--Invalid item.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'وحدة غير صالحة.');--Invalid unit.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'وحدة غير صالح أو غير متناسقة.');--Invalid or incompatible unit.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'وحدة اعادة الطلب غير متوافق مع وحدة الأساس.');--The reorder unit is incompatible with the base unit.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'سعر الصرف غير صالح.');--Invalid exchange rate.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'معرف المستخدم غير صالح.');--Invalid LoginId.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'كلمة المرور الحالية غير صحيحة.');--Your current password is incorrect.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'صنف/وحدة غير متطابق.');--Item/unit mismatch.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'نموذج ضريبة غير متطابق.');--Tax form mismatch.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'الكمية غير صالحة.');--Invalid quantity.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'معرف المعاملة غير صالح.');--Invalid transaction id.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'عمود معرف _ الحساب لا يمكن أن يكون فارغ.');--The column account_id cannot be null.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'لم يتم العثور على سعر الصرف بين العملات.');--Exchange rate between the currencies was not found.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'لا يرتبط هذا الصنف مع هذه المعاملة.');--This item is not associated with this transaction.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'لا توجد سياسة التدقيق لهذا المستخدم.');--No verification policy found for this user.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', ' يرجى الطلب من شخص ما للتحقق من المعاملات الخاصة بك.');--Please ask someone else to verify your transaction.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'مراجع الجانبين ليست متساوية.');--Referencing sides are not equal.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'غير مسموح بمخزون سالب.');--Negative stock is not allowed.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'يؤدي عرض هذه المعاملة رصيداً نقديا سلبيا.');--Posting this transaction would produce a negative cash balance.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'يمكن أن يتضمن طلب تحويل المخزون فقط إدخالات المدين.');--Stock transfer request can only contain debit entries.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'يمكن أن يتضمن طلب تحويل المخزون فقط إدخالات الدائن.');--Stock transfer delivery can only contain credit entries.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'لا يمكن تلقي تحويل المخزون لان التسليم لا يحتوي على أي صنف.');--Cannot receive a stock transfer because the delivery contains no item.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'غير مسموح بمعاملات بتاريخ سابق.');--Past dated transactions are not allowed.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'لا يسمح بترحيل الحركات في هذه الشركة.');--This establishment does not allow transaction posting.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'لا يمكن ترحيل حركة أثناء وضع الحركة مقيدة.');--Cannot post transaction during restricted transaction mode.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'عملية نهاية اليوم تم تنفيذها بالفعل.');--End of day operation was already performed.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'المعاملات بتاريخ سابق في انتظار التحقق.');--Past dated transactions in verification queue.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'الرجاء التحقق من المعاملات قبل القيام بعملية نهاية اليوم.');--Please verify transactions before performing end of day operation.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'لا تزال هناك حركات في انتظار التحقق.');--There are still transactions in verification queue.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'لا يمكنك القيام بتخصيص الربح والخسارة في مجموعة الشركة');--You cannot perform PL appropriation on an office group.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'لا يمكن توفير معلومات ضريبة المبيعات للمبيعات غير الخاضعة للضريبة.');--You cannot provide sales tax information for non taxable sales.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'المعلومات المقدمة للمعاملة البنكية غير صالحة.');--Invalid bank transaction information provided.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'معلومات بطاقة الدفع غير صالحة.');--Invalid payment card information.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'تعذر العثور على حساب رسوم تاخير تاجر.');--Could not find an account to post merchant fee expenses.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'لا يمكن أن يحتوي على إدخال تسوية المخزون علي صنف مدين (اصناف).');--A stock adjustment entry can not contain debit item(s).
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'يمكن أن يظهر الصنف مرة واحدة فقط في المخزن.');--An item can appear only once in a store.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'لا يمكن أن تكون الكمية التي تم إرجاعها أكبر من الكمية الفعلية.');--The returned quantity cannot be greater than actual quantity.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'لا يمكن أن يكون المبلغ الذي تم إرجاعه أكبر من المبلغ الفعلي.');--The returned amount cannot be greater than actual amount.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'لا يمكن توفير  أكثر من مخزن واحد لهذه الحركة.');--You cannot provide more than one store for this transaction.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'لا يمكن اختيار أكثر من مخزن واحد لهذه الحركة.');--You cannot provide more than one delivery destination store for this transaction.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'المخزن المصدر والمخزن والوجهة لا يمكن أن تكون هي نفسها.');--The source and the destination stores cannot be the same.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'لا يمكن أن يكون تاريخ البدء أكبر من تاريخ الانتهاء.');--The start date cannot be greater than end date.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'المعاملات غير صالحة أو المرفوضة.');--Invalid or rejected transaction.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'كمية الصنف غير كافية.');--Insufficient item quantity.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'غير مسموح بحذف حركة. اجعل الحركة مرفوضة بدلاً من ذلك.');--Deleting a transaction is not allowed. Mark the transaction as rejected instead.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'الرجاء أطلب من شخص آخر للتحقق من المعاملات التي قمت بنشرها.');--Please ask someone else to verify the transaction you posted.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'تم تجاوز حد التحقق الذاتي. عدم التحقق من المعاملة.');--Self verification limit exceeded. The transaction was not verified.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'تم تجاوز حد تحقق المبيعات. عدم التحقق من المعاملة.');--Sales verification limit exceeded. The transaction was not verified.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'تم تجاوز حد تحقق الشراء. عدم التحقق من المعاملة.');--Purchase verification limit exceeded. The transaction was not verified.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'تم تجاوز حد تحقق الاستذ العام. عدم التحقق من المعاملة.');--GL verification limit exceeded. The transaction was not verified.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'اعدادات غير صالحة: أسلوب COGS.');--Invalid configuration: COGS method.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'لا يمكن إصدار بيان الارباح والخسائر للشركة (الشركات) التي لها قاعدة بيانات مختلفة.');--Cannot produce P/L statement of office(s) having different base currencies.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'لا يمكن اصدار ميزان المراجعة للشركة (الشركات) التي لها قاعدة بيانات مختلفة.');--Cannot produce trial balance of office(s) having different base currencies.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'لا يمكن أن يكون هناك عمله مختلفة عن عملة حساب الاستاذ العام المعينة.');--You cannot have a different currency on the mapped GL account.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'تم بالفعل تهيئة عملية نهاية اليوم.');--EOD operation was already initialized.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'مطلوب عمود واحد فقط.');--Only one column is required.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'لا يمكن تحديث عمود.');--Cannot update column.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'غير مسموح لك بتغيير حساب النظام Sys.');--You are not allowed to change system accounts.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'غير مسموح لك إضافة حساب النظام Sys.');--You are not allowed to add system accounts.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'لا يمكن أن يكون للمستخدم sys كلمة مرور.');--A sys user cannot have a password.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'تم رفض الوصول.');--Access is denied.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'تم رفض الوصول. غير مسموح لك بترحيل هذه الحركة.');--Access is denied. You are not authorized to post this transaction.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'تم رفض الوصول. قمت بادخال قيم غير صالحة.');--Access is denied. Invalid values supplied.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'تم رفض الوصول! حركة تسوية مخزون لا يمكن مراجعتها لفروع متعددة.');--Access is denied! A stock adjustment transaction cannot references multiple branches.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'تم رفض الوصول! حركة دفتر يومية المخزون لا يمكن مراجعتها لفروع متعددة..');--Access is denied! A stock journal transaction cannot references multiple branches.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'تم رفض الوصول. لا يمكنك التحقق من صفقة شركة او فرع آخر.');--Access is denied. You cannot verify a transaction of another office.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'تم رفض الوصول. لا يمكنك تحقق الحركات بتاريخ سابق او لاحق.');--Access is denied. You cannot verify past or futuer dated transaction.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'تم رفض الوصول. ليس لك صلاحيات لتحقق هذه الحركة.');--Access is denied. You don''t have the right to verify the transaction.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'تم رفض الوصول. ليس لك صلاحيات لسحب هذه الحركة.');--Access is denied. You don''t have the right to withdraw the transaction.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'وصول مرفوض. لا يمكنك تحديث الجدول "transaction_details".');--Acess is denied. You cannot update the "transaction_details" table.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'DbErrors', 'تم رفض الوصول. تم رفض هذه الحركة بواسطة المسؤول .');--Access is denied. This transaction was rejected by administrator.
SELECT * FROM localization.add_localized_resource('DbResource', 'ar', 'DbResource', 'الإجراءات');--Actions
SELECT * FROM localization.add_localized_resource('DbResource', 'ar', 'DbResource', 'المبلغ');--Amount
SELECT * FROM localization.add_localized_resource('DbResource', 'ar', 'DbResource', 'عملة');--Currency
SELECT * FROM localization.add_localized_resource('DbResource', 'ar', 'DbResource', 'لون خلفية العلامة');--Flag Background Color
SELECT * FROM localization.add_localized_resource('DbResource', 'ar', 'DbResource', ' اللون الأمامي للعلامة');--Flag Foreground Color
SELECT * FROM localization.add_localized_resource('DbResource', 'ar', 'DbResource', 'معرف');--ID
SELECT * FROM localization.add_localized_resource('DbResource', 'ar', 'DbResource', 'شركة');--Office
SELECT * FROM localization.add_localized_resource('DbResource', 'ar', 'DbResource', 'الطرف');--Party
SELECT * FROM localization.add_localized_resource('DbResource', 'ar', 'DbResource', 'رقم مرجعي');--Reference Number
SELECT * FROM localization.add_localized_resource('DbResource', 'ar', 'DbResource', 'مرجع البيان');--Statement Reference
SELECT * FROM localization.add_localized_resource('DbResource', 'ar', 'DbResource', 'الطابع الزمني للحركة');--Transaction Timestamp
SELECT * FROM localization.add_localized_resource('DbResource', 'ar', 'DbResource', 'المستخدم');--User
SELECT * FROM localization.add_localized_resource('DbResource', 'ar', 'DbResource', 'قيمة التاريخ');--Value Date
SELECT * FROM localization.add_localized_resource('Errors', 'ar', 'Errors', 'كلا الدائن والمدين ليس له قيمة.');--Both debit and credit cannot have values.
SELECT * FROM localization.add_localized_resource('Errors', 'ar', 'Errors', 'لا يمكن تحديد مسار دليل التطبيق.');--Cannot determine application directory path.
SELECT * FROM localization.add_localized_resource('Errors', 'ar', 'Errors', 'لا يمكن تحديد اسم الملف من عنوان url التحميل.');--Cannot determine filename from the download url.
SELECT * FROM localization.add_localized_resource('Errors', 'ar', 'Errors', 'لا يمكن أن يكون معرف وحدة الأساس هو معرف وحدة المقارنة.');--Base unit id and compare unit id cannot be same.
SELECT * FROM localization.add_localized_resource('Errors', 'ar', 'Errors', 'فقط {0} {1} من {2} متبقي في المخزن.');--Only {0} {1} of {2} left in stock.
SELECT * FROM localization.add_localized_resource('Errors', 'ar', 'Errors', 'موقع ملف غير صالح.');--Invalid file location.
SELECT * FROM localization.add_localized_resource('Errors', 'ar', 'Errors', 'دفتر حركة فرعي غير صالح "تسليم المشتريات".');--Invalid SubTranBook 'Purchase Delivery'.
SELECT * FROM localization.add_localized_resource('Errors', 'ar', 'Errors', 'دفتر حركة فرعي غير صالح "تسعير المشتريات".');--Invalid SubTranBook 'Purchase Quotation'.
SELECT * FROM localization.add_localized_resource('Errors', 'ar', 'Errors', 'دفتر حركة فرعي غير صالح "استلام الشراء".');--Invalid SubTranBook 'Purchase Receipt'.
SELECT * FROM localization.add_localized_resource('Errors', 'ar', 'Errors', 'دفتر حركة فرعي غير صالح "ايراد المبيعات".');--Invalid SubTranBook 'Sales Payment'.
SELECT * FROM localization.add_localized_resource('Errors', 'ar', 'Errors', 'معرف المستخدم غير صالح.');--Invalid user id.
SELECT * FROM localization.add_localized_resource('Errors', 'ar', 'Errors', 'يوجد عدم تطابق من مفتاح/قيمة للاصناف في ListControl.');--There is a mismatching count of key/value items in this ListControl.
SELECT * FROM localization.add_localized_resource('Errors', 'ar', 'Errors', 'لا توجد حركات للترحيل.');--No transaction to post.
SELECT * FROM localization.add_localized_resource('Errors', 'ar', 'Errors', 'كلا مراجع الجانبين ليست متساوية.');--The referencing sides are not equal.
SELECT * FROM localization.add_localized_resource('Errors', 'ar', 'Errors', 'تعذر تحديد موقع ملف البيانات الإقليمي.');--The regional data file could not be located.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'إنشاء المستخدمين وتحديد سياسات مختلفة مثل سياسة الوصول إلى القائمة وسياسة التحقق.');--Create users and define various policies such as menu access policy and verification policy.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'جميع الحقول مطلوبة.');--All fields are required.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'النسخ الاحتياطي {0}.');--Backing up {0}.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'إجراء النسخ الاحتياطي للملف {0} للترحيل.');--Backing up file {0} for migration.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'لا يمكن سحب الحركة. هذه ليست حركة استاذ عام صالحة.');--Cannot withdraw transaction. This is a not a valid GL transaction.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'لا يمكن سحب الحركة.');--Cannot withdraw transaction.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'اضغط هنا لتحميل.');--Click here to download.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'تأكيد كلمة المرور غير متطابق.');--The confirmed password does not match.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'الخزينة هو مكان حيث يمكنك تخزين الخاص بك النقدية والأشياء الثمينة. على سبيل المثال: النقدية بالخزينة،النقدية في الصندوق.');--Cash repository is a place where you store your cash a (...)
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', ' ضريبة المبيعات المقاطعة او الولاية هي ضريبة الاستهلاك المباشر تفرضها حكومة المحافظة الخاصة بك عندما تقوم بالشراء أوالتوريد.');--County sales tax is the direct consumption tax imp (...)
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'السنة المالية فترة محاسبية لمدة 12 شهرا، المستخدمة في إعداد البيانات المالية.');--Fiscal year is an accounting period of 12 months, used to prepare financial statements.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'كذلك تنقسم السنة المالية  12 فترة، مصنفة حسب الأشهر وارباع ونصف المالية والسنة المالية.');--The fiscal year is further divided into 12 frequencies, categorized as months, quarters (...)
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'مجموعة الصنف يسمح لك لإدارة مماثلة من أصناف المخزون إلى مجموعات ذات مغزى والفئات.');--An item group allows you to manage similar inventory items into meaningful groups and categor (...)
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'أصناف المخزون قد تشير إلى المنتجات قابلة للتخزين أو اصناف غير قابلة للتخزين كالخدمات التي يمكنك شرائها و/أو بيعها.');--Inventory items may refer to the stockable products or nonst (...)
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'يشير مصطلح "الطرف" للعملاء والموردين والوكلاء التجاريين الذين يتعاملوا معك في الأعمال التجارية.');--The term "party" collectively refers to customer, supplier, or agent you have b (...)
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'نموذج ضريبة المبيعات مزيج من مختلف الكيانات مثل ضريبة العامة للدولة، ضريبة مقاطعة، الإعفاء، إلخ.');--Sales tax form is a combination of various entities such as State Tax, County  (...)
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'مندوبي المبيعات هم رجال  المبيعات الذين يقومون ببيع المنتجات الخاصة بك ويجلبوا الأعمال التجارية للشركة الخاصة بك.');--Salespersons are the sales guys who sell your products and br (...)
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'شركات الشحن  تقوم بنقل البضائع عبر البر والبحر، و/أو الجو إلى عملائك.');--Shipping companies transfer the goods through land, sea, and/or air to your customers.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'ضريبة المبيعات هي ضريبة الاستهلاك المباشر تفرضها حكومة الدولة الخاص بك عندما تقوم بالشراء أوالتوريد.');--State sales tax is the direct consumption tax imposed by your state govern (...)
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'المخزن هو مكان حيث يمكنك الاحتفاظ بالبضائع الخاصة بك. على سبيل المثال: متجر، بدروم، او مخازن.');--Store is a place where you keep your goods. Example: Shop, Go-down, Warehouse.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'مصلحة الضرائب هو الهيئة الحكومية التي تقدم لها تقرير بالاعمال من ربح او خسارة سنويا.');--Tax authority is the government body or agency to whom you file your periodic tax reports  (...)
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'الضرائب الرئيسية فئة لمجموعة الضرائب الخاصة بك منطقياً. على سبيل المثال: الضريبة العامة للدولة.');--Tax master is a category to group your taxes logically. Example: [Country] Taxa (...)
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'النسخ الاحتياطي قاعدة بيانات تمت بنجاح.');--The database backup was successful.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'يوم/شهر/سنة');--yyyy-mm-dd
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'أيام');--days
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'تم حذف ملفات التطبيق بنجاح.');--Existing application files were deleted successfully.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'حذف ملفات التطبيق.');--Deleting application files.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'تم حذف ملفات التطبيق بنجاح.');--Existing application files were deleted successfully.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'النسخ الاحتياطي للدليل تم بنجاح.');--Directory backup completed successfully.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'استعادة النسخ الاحتياطي للدليل تم بنجاح.');--Directory restore completed successfully.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'تم التحميل بنجاح.');--Download was successful.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'جاري تحميل التحديث من {0}.');--Downloading update from {0}.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'الرجاء إغلاق هذه النافذة وحفظ العمل الحالي الخاص بك قبل ان يتم خروجك تلقائياً.');--Please close this window and save your existing work before you will be signed off automatically (...)
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', '<h2>مرحبا،</h2> <p>الرجاء الاطلاع علي الوثيقة المرفقة.</p> <p>شكرا لك. < br/> MixERP</p>');--<h2>Hi,</h2><p>Please find the attached document.</p><p>Thank you.<br />MixERP</p>
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'تم إرسال بريد إلكتروني إلى {0}.');--An email was sent to {0}.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'فك ضغط الملف الذي تم تنزيله.');--Extracting the downloaded file.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'فك ضغط الملف اكتمل بنجاح.');--Extraction completed.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'يمكنك وضع علامة على هذه الصفقة، ولكن سوف لا تكون قادراً على رؤية العلامات التي تم إنشاؤها بواسطة مستخدمين آخرين.');--You can mark this transaction with a flag, however you will no (...)
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'يتم إكمال اعداد الفترات المالية.');--Frequency setup is complete.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'انتقل إلى نافذة قائمة الاختيار.');--Go to checklist window.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'الانتقال إلى أعلى.');--Go to top.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'نسختك من MixERP محدث باخر تحديث.');--Your instance of MixERP is up to date.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'لحظةمن فضلك جاري تسجيل الدخول!');--Just a moment, please!
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'سياسة الوصول إلى قائمة تمكنك من تعريف الصلاحيات لمستخدم للوصول إلى عناصر القائمة.');--Menu access policy enables you to define permission for a user to access menu item(s).
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'هناك {0} خزينة نقدية في هذه الشركة.');--There are {0} cash repositories in this office.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'هناك {0}  ضرائب المبيعات المقاطعات في هذه الشركة.');--{0} county sales taxes defined.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'هناك {0} مجموعة اصناف في هذه الشركة.');--{0} item group(s) found.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'هناك {0} اصناف في هذه الشركة.');--{0} item(s) found.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', '  هناك {0} من أصل 12فترة محددة في هذه الشركة.');--{0} out of 12 frequencies defined.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'هناك {0} اطراف في هذه الشركة.');--{0} parties found.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'هناك {0} من نماذج ضريبة المبيعات محددة في هذه الشركة.');--{0} sales tax forms defined.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'هناك {0} من رجال البيع هذه الشركة.');--{0} salespersons found.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'هناك {0} من شركات الشحن هذه الشركة.');--{0} shippers found.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'هناك {0} من نماذج ضريبة المبيعات المقاطعات محددة في هذه الشركة.');--{0} state sales taxes defined.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'هناك {0} من المخازن هذه في الشركة.');--There are {0} stores in this office.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'هناك {0} من مصالح الضرائب في هذه الشركة.');--{0} tax authorities found.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'هناك {0} من الضرائب العامة ( الرئيسية) في هذه الشركة.');--{0} tax master(s) found.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'لم يتم اعداد مستخدم إضافي.');--No additional user found.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'لم يتم اعداد  خزينة النقدية.');--No cash repository defined.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'لم يتم اعداد  ضريبة المبيعات للمقاطعة.');--No county sales tax defined.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'لم يتم اعداد  سنة مالية.');--No fiscal year defined.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'لم يتم اعداد الاطراف.');--No party found.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'لم يتم اعداد  نموذج ضريبة المبيعات.');--No sales tax form defined.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'لم يتم اعداد مندوبي مبيعات.');--No salesperson found.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'لم يتم اعداد شركات الشحن.');--No shipper found.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'لم يتم اعداد ضريبة المبيعات الدولة.');--No state sales tax defined.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'لم يتم اعداد المخزن الحالي.');--No store present.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'لم يتم اعداد الموردين.');--No supplier found.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'لم يتم اعداد مصلحة الضرائب.');--No tax authority defined.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'لم يتم اعداد  الضريبة العامة.');--No tax master defined.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'لا توجد ادوات');--No widget found.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'غير معرف لعدد {0} مستخدم.');--Not defined for {0} users.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', '{0} الصفوف المتأثرة.');--{0} rows affected.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'الارصدة الافتتاحية للمخزون تم ادخالها من قبل لهذه الشركة.');--Opening inventory has already been entered for this office.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'الأطراف مجتمعة تشير إلى الموردين والعملاء والوكلاء وتجار.');--Parties collectively refer to suppliers, customers, agents, and dealers.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'تصحيح قاعدة البيانات.');--Patched the database.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'جاري التصحيح في قاعدة البيانات.');--Patching the database.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', ' %{0}تم اكتمال ');--{0} percent completed.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', '%');--%
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'الرجاء اختيار نموذج أولاً.');--Please select a form first.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'تم تسليم #{0} اشعار , {1}');--Receipt #{0} notification, {1}
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'لا يحتوي هذا الإصدار على أي تحديث.');--This release does not contain any update.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'استعادة الدليل: {0}.');--Restoring directory : {0}.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'استعادة الملف: {0}.');--Restoring file : {0}.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'SMTP غير مفعل.');--SMTP is disabled.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'تسليم المبيعات #{0} تأكيد , {1}');--Sales delivery #{0} confirmation, {1}
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'تم استلام امر الشراء #{0}, {1}');--We received your PO #{0}, {1}
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'التسعير تم قبوله بالفعل في {0}.');--This quotation was already accepted on {0}.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'التسعير #{0} من {1}');--Quotation #{0} from {1}
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'حدد علامة.');--Select a flag.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', ' اعدادات البريد الصادر غير مفعل. قم بضبط اعدادات البريد الصادر SMTP لارسال التنبيهات الي عملائك.');--Your outgoing email configuration is disabled. Configure the SMTP parameters f (...)
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', '{0} من {1} المهام المكتملة.');--{0} out of {1} tasks completed.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'تمت المهمة بنجاح.');--Task completed successfully.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'شكرا لجهودك.');--Thank you for your business.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'هذا الحقل مطلوب.');--This field is required.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'إجمالي المستخدمين: {0}.');--Total users : {0}.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'هذه الحركة تم الموافقة بواسطة {0} في {1}.');--This transaction was approved by {0} on {1}.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'هذه الحركة تمت الموافقة تلقائياً {0} في {1}.');--This transaction was automatically approved by {0} on {1}.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', '. هذه المعاملات تنتظر التحقق من مسؤول.');--This transaction is awaiting verification from an administrator.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'هذه الحركة اقفلت بواسطة {0} فى {1}. والسبب: "{2}".');--This transaction was closed by {0} on {1}. Reason: "{2}".
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'تم ترحيل الحركة بنجاح.');--The transaction was posted successfully.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'تم رفض هذه الحركة من قبل {0} في {1}. والسبب: "{2}".');--This transaction was rejected by {0} on {1}. Reason: "{2}".
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', ' ادخل التاريخ الذي تريد بدء تسجيل المعاملات به في نظام MixERP.');--Enter the exact date from when you want to record transactions in MixERP.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'عندما سحب معاملة، لن يحال إلى الوحدة النمطية لسير العمل. وهذا يعني أن سحب معاملتك مرفوضة، وتتطلب مزيد من التحقق. ومع ذلك، لن تتمكن من الغاء سحب هذه الحركة في وقت لاحق.');--When yo (...)
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'هذه الحركة سحبت بواسطة {0} فى {1}. والسبب: "{2}".');--This transaction was withdrawn by {0} on {1}. Reason: "{2}".
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'هذه الحركة سحبت بنجاح. وعلاوة على ذلك، هذا الإجراء سوف يؤثر على جميع التقارير التي تنتجها في وبعد "{0}".');--The transaction was withdrawn successfully. Moreover, this action will (...)
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'قبل القيام بعملية التحديث، الرجاء التأكد من أن لديك أحدث النسخ الاحتياطي.');--Before you perform the update operation, please make sure that you have latest backups handy.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'عملية التحديث تمت بنجاح.');--The update operation completed successfully.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', ' تحميل الشعار.');--Upload logo.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', '   jpeg, gif, png, او bmp. هذا الشعار سيظهرعلي التقارير والمستندات الخاصة بالشركة.');--Upload your office logo in jpeg, gif, png, or bmp format. This logo will be displayed in rep (...)
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'مرحبا {0}!');--Hi {0}!
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'تعيين السياسات تحقق القسيمة للمسؤولين عن الموافقة أو رفض صفقة.');--Assisgn voucher verification policies to administrators for approving or rejecting transactions.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'Labels', 'تم تغيير كلمة المرور الخاصة بك.');--Your password was changed.
SELECT * FROM localization.add_localized_resource('Messages', 'ar', 'Messages', 'هل أنت متأكد؟');--Are you sure?
SELECT * FROM localization.add_localized_resource('Messages', 'ar', 'Messages', 'لا يمكن تحديد المسار الظاهري لإنشاء صورة.');--Could not determine virtual path to create an image.
SELECT * FROM localization.add_localized_resource('Messages', 'ar', 'Messages', 'ملفات مكررة!');--Duplicate File!
SELECT * FROM localization.add_localized_resource('Messages', 'ar', 'Messages', 'الرجاء عدم إغلاق هذه النافذة أو التنقل بعيداً عن هذه الصفحة أثناء التهيئة.');--Please do not close this window or navigate away from this page during initialization.
SELECT * FROM localization.add_localized_resource('Messages', 'ar', 'Messages', 'خلال فترة نهاية اليوم، يسمح فقط للمستخدمين المصرح لهم فقط لتسجيل الدخول.');--During the day-end period, only users having elevated privilege are allowed to log-in.
SELECT * FROM localization.add_localized_resource('Messages', 'ar', 'Messages', 'عند تهيئة عملية نهاية اليوم، يتم تسجيل خروج المستخدمين الذين تم تسجيل دخولهم في النظام خلال 120 ثانية.');--When you initialize day-end operation, the already logged-in applica (...)
SELECT * FROM localization.add_localized_resource('Messages', 'ar', 'Messages', 'هذه العملية لا رجعة فيها.');--This process is irreversible.
SELECT * FROM localization.add_localized_resource('Messages', 'ar', 'Messages', 'خلال عملية نهاية اليوم، يتم تنفيذ المهام الروتينية مثل حساب الفائدة، والتسويات، واستخراج التقارير.');--During EOD operation, routine tasks such as interest calculation, settle (...)
SELECT * FROM localization.add_localized_resource('Messages', 'ar', 'Messages', 'عند تنفيذ عملية نهاية اليوم  لتاريخ معين،الحركات في ذلك التاريخ أو قبله لا يمكنك تحديثها، تغييرها، أوحذفها.');--When you perform EOD operation for a particular date, no transa (...)
SELECT * FROM localization.add_localized_resource('Messages', 'ar', 'Messages', 'ملف غير صالح!');--Invalid file!
SELECT * FROM localization.add_localized_resource('Messages', 'ar', 'Messages', 'لا يمكن إنشاء صورة عندما يكون الدليل temp فارغة.');--Cannot create an image when the temp directory is null.
SELECT * FROM localization.add_localized_resource('Messages', 'ar', 'Messages', 'تم حذف الملفات التي تم تحميلها بنجاح.');--The uploaded files were successfully deleted.
SELECT * FROM localization.add_localized_resource('Questions', 'ar', 'Questions', 'هل أنت متأكد؟');--Are you sure?
SELECT * FROM localization.add_localized_resource('Questions', 'ar', 'Questions', 'لا يمكن الوصول إلى الحساب الخاص بك؟');--Cannot access your account?
SELECT * FROM localization.add_localized_resource('Questions', 'ar', 'Questions', 'سيتم تأمين الوصول إلى قاعدة بيانات العمل أثناء التنفيذ. هل أنت متأكد من أنك تريد تنفيذ هذا الإجراء الآن؟');--This will lock client database access during execution. Are you  (...)
SELECT * FROM localization.add_localized_resource('Questions', 'ar', 'Questions', 'سيتم تأمين الوصول إلى قاعدة بيانات العمل أثناء التنفيذ. هل أنت متأكد من أنك تريد تنفيذ هذا الإجراء الآن؟');--This will lock client database access during execution. Are you  (...)
SELECT * FROM localization.add_localized_resource('Questions', 'ar', 'Questions', 'سيتم تأمين الوصول إلى قاعدة بيانات العمل أثناء التنفيذ. هل أنت متأكد من أنك تريد تنفيذ هذا الإجراء الآن؟');--This will lock client database access during execution. Are you  (...)
SELECT * FROM localization.add_localized_resource('Questions', 'ar', 'Questions', 'ما هي العملة الرئيسية الخاصة بك؟');--What Is Your Home Currency?
SELECT * FROM localization.add_localized_resource('Questions', 'ar', 'Questions', 'لماذا تريد أن تسحب هذه المعاملة؟');--Why do you want to withdraw this transaction?
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'حدد');--Select
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'حساب');--Account
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف الحساب');--Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'الحساب الرئيسي');--Account Master
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كود الحساب الرئيسي');--Account Master Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف الحساب الرئيسي');--Account Master Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم الحساب الرئيسي');--Account Master Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم الحساب');--Account Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'رقم الحساب');--Account Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'العنوان');--Address
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'سطر العنوان 1');--Address Line 1
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'سطر العنوان 2');--Address Line 2
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف الشريحة التصاعدية');--Ageing Slab Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم الشريحة التصاعدية');--Ageing Slab Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'السماح للائتمان');--Allow Credit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'السماح بالبيع');--Allow Sales
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'السماح بترحيل المعاملات');--Allow Transaction Posting
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'المبلغ');--Amount
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'قيمة من');--Amount From
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'تصل إلى');--Amount To
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'تحليل العدد لقاعدة البيانات');--Analyze Count
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف سياسة الوصول إلى API');--API Access Policy Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'إدخال مكرر لسياسة الوصول إلى API');--Duplicate Entry for API Access Policy
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'تطبق على رسوم الشحن');--Applied on Shipping Charge
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'مراجع الطابع الزمني');--Audit Timestamp
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف المراجع');--Audit User Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'المشغل تلقائياً على المبيعات');--Automatically Trigger on Sales
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'تحليل العدد تلقائي لقاعدة البيانات');--Autoanalyze Count
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'تفريغ تلقائي لقاعدة البيانات');--Autovacuum Count
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'لون الخلفية');--Background Color
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'الرصيد');--Balance
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'رقم الحساب البنكي');--Bank Account Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'نوع الحساب البنكي');--Bank Account Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'الصنف المحدد غير صالح كحساب بنكي.');--The selected item is not a valid bank account.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'تكرار الحساب البنكي.');--Duplicate bank account.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'عنوان البنك');--Bank Address
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'فرع البنك');--Bank Branch
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'رقم الاتصال بالبنك');--Bank Contact Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم البنك');--Bank Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف الوحدة الأساسية');--Base Unit Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم الوحدة الأساسية');--Base Unit Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'استناداً إلى عنوان الشحن');--Based On Shipping Address
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معدل مكافأة');--Bonus Rate
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'رمز شريحة المكافأة');--Bonus Slab Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف تفاصيل شريحة مكافأة');--Bonus Slab Detail Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'يجب أن يكون الحقل "القيمة من" أكبر من "الي القيمة".');--The field "AmountTo" must be greater than "AmountFrom".
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف شريحة مكافأة');--Bonus Slab Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم شريحة مكافأة');--Bonus Slab Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'دفتر');--Book
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'تاريخ الدفتر');--Book Date
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'العلامة التجارية');--Brand
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'رمز العلامة التجارية');--Brand Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف العلامة التجارية');--Brand Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم العلامة التجارية');--Brand Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'المتصفح');--Browser
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'يمكن تغيير كلمة المرور');--Can Change Password
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'يمكنك التحقق من النفس');--Can Self Verify
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'يمكن التحقق من المعاملات الاستاذ العام');--Can Verify Gl Transactions
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'يمكن التحقق من معاملات المشتريات');--Can Verify Purchase Transactions
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'يمكن التحقق من معاملات المبيعات');--Can Verify Sales Transactions
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'نوع البطاقة');--Card Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'رمز نوع البطاقة');--Card Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف نوع البطاقة');--Card Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم نوع البطاقة');--Card Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'عنوان التدفق النقدي');--Cash Flow Heading
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'نوع عنوان التدفق النقدي غير صالح. يسمح بالقيم: O,I,F.');--Invalid Cashflow Heading Type. Allowed values: O, I, F.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'رمز العنوان التدفق النقدي');--Cash Flow Heading Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف عنوان التدفق النقدي');--Cash Flow Heading Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم العنوان التدفق النقدي');--Cash Flow Heading Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'نوع عنوان التدفق النقدي');--Cashflow Heading Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كود التدفق النقدي الرئيسي');--Cash Flow Master Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف التدفق النقدي الرئيسي');--Cash Flow Master Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم التدفق النقدي الرئيسي');--Cash Flow Master Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف إعداد التدفق النقدي');--Cashflow Setup Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كود الخزينة النقدية مكرر.');--Duplicate Cash Repository Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم الخزينة النقدية مكرر.');--Duplicate Cash Repository Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'خزينة النقدية');--Cash Repository
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كود الخزينة النقدية');--Cash Repository Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف الخزينة النقدية');--Cash Repository Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم الخزينة النقدية');--Cash Repository Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'خلية');--Cell
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'رسوم الفائدة');--Charge Interest
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'فحص الترابط');--Check Nexus
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'مراجعة الفترة');--Checking Frequency
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف مراجعة الفترة');--Checking Frequency Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'مدينة');--City
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'إغلاق الدائن');--Closing Credit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'إغلاق المدين');--Closing Debit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'مجمع الحساب');--Collecting Account
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', ' معرف مجمع الحساب');--Collecting Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'مجمع مصلحة الضرائب');--Collecting Tax Authority
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف مجمع مصلحة الضرائب');--Collecting Tax Authority Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معدل العمولة');--Commission Rate
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معدل العمولة');--Commission Rate
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم الشركة');--Company Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف وحدة المقارنة');--Compare Unit Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم وحدة المقارنة');--Compare Unit Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', ' مجمع الصنف');--Compound Item
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كود مجمع الصنف');--Compound Item Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف تفاصيل مجمع الصنف');--Compound Item Detail Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'ادخلت وحدة غير صالحة.');--Invalid unit provided.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف مجمع الصنف');--Compound Item Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم  مجمع الصنف');--Compound Item Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف مجمع الوحدة ');--Compound Unit Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف الوحدة الاساس لايجب ان تكون نفس وحدة المقارنة.');--The base unit id cannot same as compare unit id.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'مجمع الفترات المالية');--Compounding Frequency
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'سري');--Confidential
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم الاعدادات');--ConfigurationName
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'الاتصال سطر العنوان 1');--Contact Address Line 1
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'الاتصال سطر العنوان 2');--Contact Address Line 2
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'موبايل');--Contact Cell
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'المدينة');--Contact City
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'الدولة');--Contact Country
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'البريد الإلكتروني ');--Contact Email
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'رقم');--Contact Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'الشخص المسئول');--Contact Person
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'رقم التليفون');--Contact Phone
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'صندوق البريد');--Contact Po Box
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'الحالة');--Contact State
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'الشارع');--Contact Street
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'رمز مركز التكلفة');--Cost Center Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف مركز تكلفة');--Cost Center Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم مركز التكلفة');--Cost Center Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف الحساب COGS');--COGS Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'سعر التكلفة');--Cost Price
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'سعر التكلفة تشمل الضرائب');--Cost Price Includes Tax
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كود منفذ البيع');--Counter Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف منفذ البيع');--Counter Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم منفذ البيع');--Counter Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'الدولة');--Country
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'رمز الدولة');--Country Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف الدولة');--Country Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم الدولة');--Country Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'مقاطعة');--County
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'رمز مقاطعة');--County Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف مقاطعة');--County Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم مقاطعة');--County Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'مقاطعة ضريبة المبيعات');--County Sales Tax
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كود ضريبة المبيعات في مقاطعة');--County Sales Tax Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف ضريبة المبيعات في مقاطعة');--County Sales Tax Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم مقاطعة ضريبة المبيعات');--County Sales Tax Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'دائن');--Credit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'رقم CST');--CST Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'الثقافة');--Culture
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'العملة');--Currency
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كود العملة');--Currency Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم العملة');--Currency Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'رمز العملة');--Currency Symbol
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'الفترة الحالية');--Current Period
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'يدفع العميل رسوم');--Customer Pays Fee
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'تاريخ الميلاد');--Date Of Birth
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'مدين');--Debit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف الحساب النقدي الافتراضي');--Default Cash Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف الخزينة النقدية الافتراضي');--Default Cash Repository Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كود الادارة');--Department Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف إدارة');--Department Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم الإدارة');--Department Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'الوصف');--Description
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'خصم');--Discount
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'أيام الاستحقاق');--Due Days
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'فترة الاستحقاق');--Due Frequency
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف فترة الاستحقاق');--Due Frequency Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'المستحقة في تاريخ');--Due on Date
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اعتبارا من');--Effective From
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'مؤثر');--Elevated
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'البريد الإلكتروني');--Email
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'مفعل');--Enabled
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'وينتهي في');--Ends On
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف الكيان');--Entity Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم الكيان');--Entity Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'الطابع الزمني للادخال');--Entry Ts
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'سعر الصرف');--ER
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'سعر الصرف');--Exchange Rate
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'استبعاد من الشراء');--Exclude From Purchase
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'استبعاد من المبيعات');--Exclude From Sales
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'الكود الخارجي');--External Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'عنوان المصنع');--Factory Address
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'فاكس');--Fax
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'الاسم الأول');--First Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'رمز السنة المالية');--Fiscal Year Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم السنة المالية');--Fiscal Year Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف العلامة');--Flag Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف نوع العلامة');--Flag Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم نوع العلامة');--Flag Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'تم وضع علامة على');--Flagged On
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اللون الأمامي');--Foreground Color
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'رمز العملة الأجنبية');--Foreign Currency Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كود الفترة');--Frequency Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف الفترة');--Frequency Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم الفترة');--Frequency Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'رمز الإعداد الفترة');--Frequency Setup Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف الإعداد الفترة');--Frequency Setup Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'من أيام');--From Days
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم المرسل');--FromDisplayName
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'البريد الالكتروني للمرسل');--FromEmailAddress
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'الاسم الكامل');--Full Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'عنوان الاستاذ العام');--GL Head
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'حد التحقق للاستاذ العام');--Gl Verification Limit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'فترة سماح');--Grace Period
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'له فرعي');--Has Child
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'هل يوجد ضريبة مبيعات المقاطعة؟');--Has County Sales Tax?
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'هل يوجد ضريبة مبيعات عامة (دولة)؟');--Has State Sales Tax?
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'الطول بالسنتيمتر');--Height In Centimeters
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'البند رائج');--Hot item
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'رمز عمل HTTP');--HTTP Action Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم المائتين');--Hundredth Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف');--Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'تشمل الضرائب');--Includes Tax
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معدل ضريبة الدخل');--Income Tax Rate
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف الصناعة');--Industry Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم الصناعة');--Industry Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف فائدة مجمع الفترات');--Interest Compounding Frequency Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معدل الفائدة');--Interest Rate
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف حساب المخزون');--Inventory Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'عنوان IP');--IP Address
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'نشط');--Is Active
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'يتم إضافة');--Is Added
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'مشرف');--Is Admin
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'نقدي');--Is Cash
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'مدين');--Is Debit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'هو افتراضي؟');--Is Default
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'موظف');--Is Employee
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معفي');--Is Exempt
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اعفاء');--Is Exemption
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'مبلغ ثابت');--Is Flat Amount
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'حساب التاجر');--Is Merchant Account
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'هو طرف');--Is Party
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'مشتريات');--Is Purchase
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'متعامد');--Is Rectangular
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'مبيعات');--Is Sales
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'موجز');--Is Summary
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'مورد');--Is Supplier
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'نظام');--Is System
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'عنصر معاملة');--Is Transaction Node
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'ضريبة القيمة المضافة');--Is Vat
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'الصنف');--Item
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كود الصنف');--Item Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف سعر تكلفة الصنف');--Item Cost Price Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'ادخلت وحدة غير صالحة.');--Invalid unit provided.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'مجموعة الأصناف');--Item Group
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كود مجموعة الأصناف');--Item Group Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف مجموعة الصنف');--Item Group Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم مجموعة الصنف');--Item Group Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف الصنف');--Item Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم الصنف');--Item Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'قدمت وحدة غير صالحة.');--Invalid unit provided.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف سعر بيع الصنف');--Item Selling Price Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'قدمت وحدة غير صالحة.');--Invalid unit provided.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'رمز نوع الصنف');--Item Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف نوع الصنف');--Item Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم نوع الصنف');--Item Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', ' كود الصنف مكرر');--Duplicate item code.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', ' اسم الصنف مكرر');--Duplicate item name.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'يجب أن تكون كمية اعادة الطلب اكبر من أو مساوية لمستوى إعادة الطلب.');--The reorder quantity must be great than or equal to the reorder level.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'مفتاح');--Key
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اخر تحليل لقاعدة البيانات في');--Last Analyze On
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اخر تحليل تلقائي لقاعدة البيانات في');--Last Autoanalyze On
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اخر تفريغ تلقائي لقاعدة البيانات في');--Last Autovacuum On
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'الاسم الأخير');--Last Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اخر تفريغ لقاعدة البيانات في');--Last Vacuum On
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'الرسوم المتأخرة');--Late Fee
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كود الرسوم المتأخرة');--Late Fee Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف الرسوم المتأخرة');--Late Fee Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم الرسوم المتأخرة');--Late Fee Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'فترة ترحيل الرسوم المتأخرة');--Late Fee Posting Frequency
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف فترة ترحيل الرسوم المتأخرة');--Late Fee Posting Frequency Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'الدائن بالعملة المحلية');--LC Credit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'المدين بالعملة المحلية');--LC Debit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كود مصدر العملاء المحتملين');--Lead Source Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف مصدر العملاء المحتملين');--Lead Source Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم مصدر العملاء المحتملين');--Lead Source Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كود حالة العميل المحتمل');--Lead Status Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف حالة العميل المحتمل');--Lead Status Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم حالة العميل المحتمل');--Lead Status Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'المهلة الزمنية في الأيام');--Lead Time In Days
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'الطول بالسنتيمتر');--Length In Centimeters
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'تاريخ ووقت الدخول');--Login Date Time
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم المستخدم');--Login Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'ملف الشعار');--Logo File
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'ألي');--Machinable
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'صيانة المخزون');--Maintain Stock
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'تمت الصيانة بواسطة');--Maintained By User Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'المبلغ الأقصى للائتمان');--Maximum Credit Amount
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'فترة الائتمان كحد أقصى');--Maximum Credit Period
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'حساب التاجر');--Merchant Account
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف حساب التاجر');--Merchant Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف الإعداد الرسوم  لحساب التاجر');--Merchant Fee Setup Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'الاسم الأوسط');--Middle Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'الكنية');--Nick Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'قدمت وحدة غير صالحة.');--Invalid unit provided.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'عادة مدين');--Normally Debit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'شركة');--Office
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كود الشركة');--Office Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف الشركة');--Office Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم الشركة');--Office Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'رمز المرحلة الفرصة');--Opportunity Stage Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف المرحلة الفرصة');--Opportunity Stage Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم المرحلة الفرصة');--Opportunity Stage Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'رقم PAN');--Pan Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'الأصل');--Parent
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف الحساب الرئيسي');--Parent Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'المعرف  الحساب الرئيسي');--Parent Account Master Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم الحساب الرئيسي');--Parent Account Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'رقم الحساب الرئيسي');--Parent Account Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف عنوان التدفق النقدي الرئيسي');--Parent Cash Flow Heading Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'الخزينة النقدية الرئيسية');--Parent Cash Repository
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف الخزينة النقدية الرئيسية ');--Parent Cash Repository Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كود السجل التحاري الرئيسي');--Parent CR Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم السجل التحاري الرئيسي');--Parent CR Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف الصناعة الرئيسي');--Parent Industry Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم  للصناعة الرئيسية');--Parent Industry Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف المجموعة الصنف الرئيسي');--Parent Item Group Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'الشركة الرئيسية');--Parent Office
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف الشركة الرئيسية');--Parent Office Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'الطرف');--Party
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كود الطرف');--Party Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف الطرف');--Party Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم الطرف');--Party Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'نوع الطرف');--Party Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كود نوع الطرف');--Party Tpye Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف نوع الطرف');--Party Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم نوع الطرف');--Party Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كلمة المرور');--Password
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'بطاقة الدفع');--Payment Card
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كود بطاقة الدفع');--Payment Card Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف بطاقة الدفع');--Payment Card Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم بطاقة الدفع');--Payment Card Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'مصطلح الدفع');--Payment Term
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كود مصطلح الدفع');--Payment Term Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف مصطلح الدفع');--Payment Term Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم مصطلح الدفع');--Payment Term Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'التليفون');--Phone
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'الصورة');--Photo
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'ص. ب.');--Po Box
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم نوع Poco');--Poco Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف السياسة');--Policy id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'نوع الشحن بالبريد المفضل');--Preferred Shipping Mail Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف نوع الشحن بالبريد المفضل');--Preferred Shipping Mail Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'شكل التغليف المفضل');--Preferred Shipping Package Shape
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'المورد المفضل');--Preferred Supplier
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف المورد المفضل');--Preferred Supplier Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'الدائن السابق');--Previous Credit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'المدين السابق');--Previous Debit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'الفترة السابقة');--Previous Period
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'الأسعار');--Price
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'السعر من');--Price From
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'السعر إلى');--Price To
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'رمز نوع السعر');--Price Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف نوع السعر');--Price Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم نوع السعر');--Price Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'ضريبة المبيعات الرئيسية ( ضريبة القيمة المضافة)؟');--Primary Sales Tax Is Vat?
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'الأولوية');--Priority
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف حساب المشتريات');--Purchase Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف حساب خصم المشتريات');--Purchase Discount Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'حد تحقق المشتريات');--Purchase Verification Limit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'الكمية');--Quantity
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معدل');--Rate
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف نوع التكرار');--Recurrence Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'مبلغ متكرر');--Recurring Amount
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'المدة المتكررة');--Recurring Duration
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'الفترة المتكرر');--Recurring Frequency
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف الفترة المتكرر');--Recurring Frequency Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'فاتورة المتكررة');--Recurring Invoice
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كود الفاتورة المتكررة');--Recurring Invoice Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف الفاتورة المتكررة');--Recurring Invoice Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم الفاتورة المتكررة');--Recurring Invoice Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف إعداد فاتورة المتكررة');--Recurring Invoice Setup Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'لا يمكن أن يكون هناك Triger الي  على المبيعات لهذا الصنف.');--You cannot have more than one auto trigger on sales for this item.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'يتكرر في نفس التاريخ');--Recurs on Same Calendar Date
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'الرقم المرجعي');--Reference Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'تاريخ التسجيل');--Registration Date
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'رقم التسجيل');--Registration Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم موظف العلاقات العامة');--Relationship Officer Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم العلاقة');--Relation Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'المستخدم  عن بعد');--Remote User
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'مستوى اعادة الطلب');--Reorder Level
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كمية اعادة الطلب');--Reorder Quantity
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'وحدة إعادة الطلب');--Reorder Unit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف وحدة إعادة الطلب');--Reorder Unit Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'إبلاغ مصلحة الضرائب');--Reporting Tax Authority
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف الإبلاغ مصلحة الضرائب');--Reporting Tax Authority Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'خزينة');--Repository
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'مورد');--Resource
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف المورد');--Resource Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'مفتاح الموارد');--Resource Key
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'وظيفة');--Role
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كود الوظيفة');--Role Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرفالوظيفة');--Role Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم الوظيفة');--Role Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'تقريب المنازل العشرية');--Rounding Decimal Places
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'طريقة التقريب');--Rounding Method
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كود طريقة التقريب');--Rounding Method Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم طريقة التقريب');--Rounding Method Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف حساب المبيعات');--Sales Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف حساب خصم المبيعات');--Sales Discount Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'تسعير المبيعات ساري المدة');--Sales Quotation Valid Duration
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف حساب مردودات المبيعات');--Sales Return Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'ضريبة المبيعات');--Sales Tax
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كود ضريبة المبيعات');--Sales Tax Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كود تفاصيل ضريبة المبيعات');--Sales Tax Detail Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف تفاصيل ضريبة المبيعات');--Sales Tax Detail Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم تفاصيل ضريبة المبيعات');--Sales Tax Detail Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معدل الضريبة لا ينبغي أن يكون فارغا إذا قمت بتحديد  ضريبة الولاية أو المقاطعة . وبالمثل، لا تستطيع ادخال معدل واخترت ضريبة الدولة أو المقاطعة .');--Rate should not b (...)
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اعفاء ضريبة المبيعات');--Sales Tax Exempt
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كود اعفاء ضريبة المبيعات');--Sales Tax Exempt Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف تفاصيل اعفاء ضريبة المبيعات');--Sales Tax Exempt Detail Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف اعفاء ضريبة المبيعات');--Sales Tax Exempt Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم اعفاء ضريبة المبيعات');--Sales Tax Exempt Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'يجب أن يكون حقل "PriceFrom" أقل من "PriceTo".');--The field "PriceFrom" must be less than "PriceTo".
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف ضريبة المبيعات');--Sales Tax Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم ضريبة المبيعات');--Sales Tax Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'نوع ضريبة المبيعات');--Sales Tax Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كود نوع ضريبة المبيعات');--Sales Tax Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف نوع ضريبة المبيعات');--Sales Tax Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم نوع ضريبة المبيعات');--Sales Tax Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كود فريق المبيعات');--Sales Team Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف فريق المبيعات');--Sales Team Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم فريق المبيعات');--Sales Team Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'حد تحقق المبيعات');--Sales Verification Limit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف إعداد مكافأة مندوب المبيعات');--Salesperson Bonus Setup Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كود مندوب المبيعات');--Salesperson Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف مندوب المبيعات');--Salesperson Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم مندوب المبيعات');--Salesperson Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'حد التحقق للنفس');--Self Verification Limit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'سعر البيع');--Selling Price
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'سعر البيع يشمل الضرائب');--Selling Price Includes Tax
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كود شركة الشحن');--Shipper Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف شركة الشحن');--Shipper Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم شركة الشحن');--Shipper Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كود عنوان الشحن');--Shipping Address Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف عنوان الشحن');--Shipping Address Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كود نوع الشحن بالبريد');--Shipping Mail Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف نوع الشحن بالبريد');--Shipping Mail Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم نوع الشحن بالبريد');--Shipping Mail Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كود شكل التغليف الشحن');--Shipping Package Shape Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف شكل التغليف');--Shipping Package Shape Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم شكل التغليف');--Shipping Package Shape Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم الشريحة');--Slab Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'SMTP Host');--SmpHost
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'SMTP Enable SSL');--SmtpEnableSsl
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'SMTP ID');--SmtpId
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'SMTP Password');--SmtpPassword
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'SMTP Port');--SmtpPort
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'SMTP Username');--SmtpUsername
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'رقم SST');--SST Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'يبدأ من');--Starts From
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'الدولة');--State
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كود الدولة');--State Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'رقم الدولة');--State Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم الدولة');--State Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'ضريبة المبيعات الدولة');--State Sales Tax
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كود ضريبة المبيعات الدولة');--State Sales Tax Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف ضريبة المبيعات الدولة');--State Sales Tax Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم ضريبة المبيعات الدولة');--State Sales Tax Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'مرجع البيان');--Statement Reference
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'ادخلت وحدة غير صالحة.');--Invalid unit provided.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'مخزن');--Store
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كود المخزن');--Store Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف المخزن');--Store Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم المخزن');--Store Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'نوع المخزن');--Store Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كود نوع المخزن');--Store Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف نوع المخزن');--Store Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم نوع المخزن');--Store Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'يرجى اختيار معرف حساب نقدية أو  بنك صالح.');--Please select a valid Cash or Bank AccountId.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف ضريبة المبيعات المختارة غيراصالحة لهذه الشركة.');--The chosen SalesTaxId is invalid for this office.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'شارع');--Street
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اجمالي فرعي');--Sub Total
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'SYS نوع');--Sys Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'الضريبة');--Tax
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كود مصلحة الضرائب');--Tax Authority Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف مصلحة الضرائب');--Tax Authority Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم مصلحة الضرائب');--Tax Authority Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'المبلغ الاساسي للضريبة');--Tax Base Amount
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كود نوع المبلغ الاساسي للضريبة');--Tax Base Amount Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم نوع المبلغ الاساسي للضريبة');--Tax Base Amount Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كود الضريبة');--Tax Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'نوع الاعفاء الضريبي');--Tax Exempt Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كود نوع الاعفاء الضريبي');--Tax Exempt Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف نوع الاعفاء الضريبي');--Tax Exempt Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم نوع الاعفاء الضريبي');--Tax Exempt Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف الضريبة');--Tax Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'الضريبة الرئيسية');--Tax Master
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كود الضريبة الرئيسية');--Tax Master Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف الضريبة الرئيسية');--Tax Master Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم الضريبة الرئيسية');--Tax Master Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم الضريبة');--Tax Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'نوع معدل الضريبة');--Tax Rate Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كود نوع معدل الضريبة');--Tax Rate Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم نوع معدل الضريبة');--Tax Rate Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كود نوع الضريبة');--Tax Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف نوع الضريبة');--Tax Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم نوع الضريبة');--Tax Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'لايام');--To Days
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'الاجمالي');--Total
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اجمالي المدة');--Total Duration
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'إجمالي المبيعات');--Total Sales
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كود الحركة');--Tran Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'نوع الحركة');--Tran Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'تاريخ بدأ تسجيل المعاملات');--Transaction Start Date
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'وحدة');--Unit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'كود الوحدة');--Unit Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف الوحدة');--Unit Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم الوحدة');--Unit Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'رابط');--Url
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'استخدام حساب الضريبة المجمع');--Use Tax Collecting Account
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'استخدام معرف حساب الضريبة المجمع');--Use Tax Collecting Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'معرف المستخدم');--User Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'اسم المستخدم');--User Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'عدد الفراغات في قاعدة البيانات');--Vacuum Count
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'صالحة من');--Valid From
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'سارية حتى');--Valid Till
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'القيمة');--Value
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'تاريخ القيمة');--Value Date
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'التحقق من معاملاتالاستاذ العام');--Verify Gl Transactions
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'تحقق معاملات المشتريات');--Verify Purchase Transactions
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'التحقق من معاملات المبيعات');--Verify Sales Transactions
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'يبدأ الاسبوع في');--Week Start Day
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'الوزن بالجرام');--Weight In Grams
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'عرض في السنتيمتر');--Width In Centimeters
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ScrudResource', 'الرمز البريدي');--Zip Code
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'حول تهيئة نهاية اليوم');--About Initializing Day End
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'حول شركتك');--About Your Office
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'قبول');--Accept
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'وصول');--Access
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تم رفض الوصول.');--Access is denied.
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'حساب');--Account
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'رقم الحساب');--Account Id
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'حساب رئيسي');--Account Master
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'أسم الحساب');--Account Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'رقم الحساب');--Account Number
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'نظرة عامة على الحساب');--Account Overview
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'كشف حساب');--Account Statement
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تم العلم');--Acknowledged
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تم العلم بواسطة');--Acknowledged By
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تاثير');--Action
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تأثيرات');--Actions
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'فعلي');--Actual
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'إضافة');--Add
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اضف جديد');--Add New
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'إضافة مستخدمين جدد');--Add New Users
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'عنوان');--Address
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'العنوان ومعلومات الاتصال');--Address & Contact Information
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'شرائح تصاعدية');--Ageing Slabs
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تعيين شرائح المكأفاة');--Bonus Slab Assignment
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'شرائح المكافأة لمندوبي المبيعات');--Bonus Slab for Salespersons
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'التنبيهات');--Alerts
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'كافة المهام');--All Tasks
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'قيمة');--Amount
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'المبلغ (العملة الأساسية)');--Amount (In Base Currency)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'المبلغ (بالعملة المحلية)');--Amount (In Home Currency)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تحليل قاعدة البيانات');--Analyze Databse
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'موافق');--Approve
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الموافقة على هذه الصفقة');--Approve This Transaction
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'المعاملات التي تم الموافقة عليها');--Approved Transactions
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'هل أنت متأكد؟');--Are you sure?
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تعيين أمين الصندوق');--Assign Cashier
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'معلمات المرفقات');--Attachment Parameters
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'المرفقات (+)');--Attachments (+)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'فوض');--Authorize
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'مفوض');--Authorized
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'مفوض من');--Authorized By
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'سياسة التحقق التلقائي');--Autoverification Policy
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'وافق تلقائيا بواسطة سير العمل');--Automatically Approved by Workflow
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'رجوع');--Back
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'العودة إلى الصفحة السابقة');--Back to Previous Page
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'وحدة التحكم النسخ الاحتياطي');--Backup Console
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'النسخ الاحتياطي لقاعدة بيانات');--Backup Database
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'النسخ الاحتياطي للدليل');--Backup Directories
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'ابدأ النسخ الاحتياطي الآن');--Backup Now
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الرصيد');--Balance
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'ميزان المراجعة');--Balance Sheet
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'حسابات بنكية');--Bank Accounts
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'كود المعاملة البنكية');--Bank Transaction Code
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'العملة الأساسية');--Base Currency
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اسم الوحدة الاساسية');--Base Unit Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'متفاصيل شرائح المكافأة لمندوبي المبيعات ');--Bonus Slab Details for Salespersons
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'دفتر');--Book
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تاريخ الدفتر');--Book Date
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'دفتر ضريبة الدخل');--Book Income Tax
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'علامة تجارية');--Brand
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'العلامات التجارية');--Brands
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تصفح');--Browse
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'رقم CST');--CST Number
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'إلغاء');--Cancel
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'عنوان التدفق النقدي');--Cash Flow Heading
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'عناوين التدفق النقدي');--Cash Flow Headings
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'إعداد التدفقات النقدية');--Cash Flow Setup
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الخزائن النقدية');--Cash Repositories
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الخزينة النقدية');--Cash Repository
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'رصيد الخزينة النقدية');--Cash Repository Balance
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'عملية نقدية');--Cash Transaction
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تغيير كلمة المرور');--Change Password
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تغيير جانب عندما يكون القيمة سالبة');--Change Side When Negative
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'شجرة الحسابات');--Chart of Accounts
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اختر');--Check
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اختيار الكل');--Check All
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تحقق من التحديثات');--Check for Updates
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'قوائم الاختيار');--Checklists
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'مسح');--Clear
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'غلق');--Close
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'المعاملات المغلقة');--Closed Transactions
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الرصيد الختامي');--Closing Balance
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اغلاق الدائن');--Closing Credit
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اغلاق المدين');--Closing Debit
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تعليق');--Comment
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اكمل المهام');--Complete Tasks
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تفاصيل الصنف المركب');--Compound Item Details
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الاصناف المركبة');--Compound Items
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'وحدة قياس الاصناف المركبة');--Compound Units of Measure
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'سري');--Confidential
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تأكيد كلمة السر');--Confirm Password
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تم تحويله إلى العملة الرئيسية');--Converted to Base Currency
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تم تحويله إلى العملة المحلية');--Converted to Home Currency
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'نسخة تطبيق جديد');--Copy New Application
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'مركز التكلفة');--Cost Center
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'مراكز التكلفة');--Cost Centers
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'منافذ البيع');--Counters
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'المقاطعات');--Counties
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الدول');--Countries
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'ضريبة مبيعات المقاطعة');--County Sales Tax
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'ضرائب مبيعات الدولة');--County Sales Taxes
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'انشاء نسخة احتياطية');--Create Backup
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'إنشاء نسخة احتياطية من قاعدة البيانات اولا');--Create a Backup First
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'إنشاء الخزينة النقدية');--Create Cash Repositories
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'إنشاء ضرائب مبيعات المقاطعة');--Create County Sales Tax
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'إنشاء السنة المالية');--Create Fiscal Year
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'إنشاء الفترات المالية');--Create Frequencies
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'إنشاء مجموعات الاصناف');--Create Item Groups
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'إنشاء الصنف أو الخدمة');--Create Item or Service
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'انشاء سنة مالية جديدة');--Create New Fiscal Year
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'إنشاء الاطراف');--Create Party
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'إنشاء نموذج ضريبة المبيعات');--Create Sales Tax Form
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'إنشاء مندوبي المبيعات');--Create Salespersons
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'إنشاء شركة الشحن');--Create Shipping Company
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'إنشاء ضريبة المبيعات العامة');--Create State Sales Tax
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'إنشاء المخازن');--Create Stores
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'إنشاء مصلحة الضرائب');--Create Tax Authority
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'إنشاء الضرائب الرئيسية');--Create Tax Master
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'إنشاء حساب مستخدم لنفسك');--Create a User Account for Yourself
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تم إنشاؤها في');--Created On
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'دائن');--Credit
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'مسموح الائتمان');--Credit Allowed
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'إجمالي الدائن');--Credit Total
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'Ctrl + Alt + A');--Ctrl + Alt + A
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'Ctrl + Alt + C');--Ctrl + Alt + C
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'Ctrl + Alt + D');--Ctrl + Alt + D
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'Ctrl + Alt + S');--Ctrl + Alt + S
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'Ctrl + Alt + T');--Ctrl + Alt + T
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'Ctrl + Return');--Ctrl + Return
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'العملات');--Currencies
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'عملة');--Currency
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'معرف العملة');--Currency Code
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اسم العملة');--Currency Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'رمز العملة');--Currency Symbol
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'Currencylayer معلمات');--Currencylayer Parameters
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'التاريخ الحالي للدفتر');--Current Book Date
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'العنوان IP الحالي');--Current IP
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الدخول الحالي في');--Current Login On
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'كلمة السر الحالية');--Current Password
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الفترة الحالية');--Current Period
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الحقول المخصصة');--Custom Fields
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'كود العميل');--Customer Code
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اسم العميل');--Customer Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'رقم PAN للعميل');--Customer PAN #
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'يدفع العميل رسوم');--Customer Pays Fees
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'نوع البيانات');--Data Type
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'النسخ الاحتياطي لقاعدة بيانات ');--Database Backups
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'معلمات قاعدة البيانات');--Database Parameters
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'احصائيات قاعدة البيانات');--Database Statistics
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تاريخ');--Date
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'يوم');--Day
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'أيام');--Days
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'مدين');--Debit
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'إجمالي المدين');--Debit Total
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'العنوان الاافتراضي ');--Default Address
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'العملة الاافتراضية ');--Default Currency
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'كمية اعادة الطلب الاافتراضية ');--Default Reorder Qty
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تعريف');--Definition
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'حذف');--Delete
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'حذف الاختيار');--Delete Selected
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تسليم');--Deliver
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تسليم من');--Deliver From
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تسليم الي ');--Deliver To
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تم التسليم');--Delivered
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'سلمت بواسطة');--Delivered By
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'سلمت من');--Delivered From
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تم التسليم في');--Delivered On
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'سلمت الي');--Delivered To
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'ادارة');--Department
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الإدارات');--Departments
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'وصف');--Description
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', ' الي مخزن');--Destination Store
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'فرق');--Difference
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الشراء المباشر');--Direct Purchase
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'مبيعات مباشرة');--Direct Sales
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'خصم');--Discount
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'توثيق');--Documentation
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تحميل');--Download
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تحميل برنامج اكود المصدر');--Download Source Code
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تحميل من');--Downloading From
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تحميل التحديث');--Downloading Update
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تاريخ الاستحقاق');--Due Date
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'عملية نهاية يوم قد بدأت');--End of Day Processing Has Begun
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'وحدة التحكم عملية نهاية اليوم ');--EOD Console
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'ER');--ER
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'سعر الصرف (العملة الاساسية)');--Exchange Rate (To Base Currency)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'سعر الصرف (العملة المحلية)');--Exchange Rate (To Home Currency)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تحرير');--Edit
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تعديل واستقبال');--Edit & Receive
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تعديل وإرسال');--Edit & Send
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تحرير الاختيار');--Edit Selected
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'البريد الإلكتروني');--Email
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'عنوان البريد الإلكتروني');--Email Address
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'أرسل هذا التسليم');--Email This Delivery
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'أرسل هذه الفاتورة');--Email This Invoice
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'أرسل هذه المذكرة');--Email This Note
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'أرسل هذا الأمر');--Email This Order
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'أرسل هذا التسعير');--Email This Quotation
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'أرسل هذه المدفعات');--Email This Receipt
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'أرسل هذه المردودات');--Email This Return
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'عملية نهاية اليوم ');--End of Day Operation
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'معالجة نهاية السنة المالية');--End of Year Processing
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'أدخل اسم النسخ الاحتياطي');--Enter Backup Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'ادخل كلمة مرور جديدة');--Enter a New Password
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تم إدخاله من قبل');--Entered By
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الكيانات');--Entities
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'سعر الصرف');--Exchange Rate
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اسعار العملات');--Exchange Rates
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تنفيذ');--Execute
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تصدير');--Export
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'التصدير إلى Word');--Export to Doc
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تصدير إلى Excel');--Export to Excel
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تصدير إلى PDF');--Export to PDF
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الكود الخارجي');--External Code
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'استخراج تحميل');--Extracting Download
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', ' طريقة الوارد أولاَ صادر أولاَ  (FIFO)');--First In, First Out (FIFO)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'عامل');--Factor
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'فاكس');--Fax
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تسمية الحقل');--Field Label
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اسم الحقل');--Field Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'ترتيب الحقول');--Field Order
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'مسار الملف');--File Path
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تصفية');--Filter
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'المبلغ المستحق النهائي باعلملة الاساسية');--Final Due Amount in Base Currency
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الاول');--First
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الصفحة الاولى');--First Page
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الخطوات الأولى');--First Steps
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'المهام الأولى');--First Tasks
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'السنة المالية');--Fiscal Year
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'كود السنة المالية');--Fiscal Year Code
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اسم السنة المالية');--Fiscal Year Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'علامة');--Flag
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'لون الخلفية للعلامة');--Flag Background Color
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'يمكنك وضع علامة هذه الصفقة مع العلم، ومع ذلك فلن تكون قادرا على رؤية الأعلام إنشاؤها من قبل المستخدمين الآخرين.');--You can mark this transaction with a flag, however you will not (...)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اللون الامامي للعلامة');--Flag Foreground Color
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'ضع علامة لهذا عملية');--Flag This Transaction
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'المعاملات التي تم تعليمها');--Flagged Transactions
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'العلامات');--Flags
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الفترات');--Frequencies
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', ' الجمعة');--Friday
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'من');--From
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'نصيحة الاستاذ العام');--GL Advice
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تفاصيل الاستاذ العام');--GL Details
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'عنوان الاستاذ العام');--GL Head
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', ' اعدادات عامة');--Global Parameters
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اذهب');--Go
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اذهب للاسفل');--GoToBottom
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اذهب للاعلي');--GoToTop
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'مذكرة استلام البضائع');--Goods Receipt Note
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'المجموع الإجمالي');--Grand Total
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'إخفاء الآن');--Hide for Now
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الصفحة الرئيسية');--Home
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'العملة المحلية');--Home Currency
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اسم المئة');--Hundredth Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'معرف');--Id
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'في انتظام التحقق');--In Verification Stack
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تشمل رصيد الحسابات صفر');--Include Zero Balance Accounts
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'ضريبة الدخل');--Income Tax
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', ' معدل ضريبة الدخل');--Income Tax Rate
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'مهام غير مكتملة');--Incomplete Tasks
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الصناعات');--Industries
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تهيئة نهاية اليوم');--Initialize Day End
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تثبيت MixERP');--Install MixERP
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'كود الأداة');--Instrument Code
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الفائدة المطبقة');--Interest Applicable
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'هذا ليس تاريخا صالحا.');--This is not a valid date.
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'هذه ليست صورة صالحة.');--This is not a valid image.
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', ' المعالجة المحاسبية للمخزون');--Inventory Accounting System
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'نصيحة المخزون');--Inventory Advice
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', ' طريقة تقييم المخزون');--Inventory Valuation Method
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'قيمة الفاتورة');--Invoice Amount
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تفاصيل الفاتورة');--Invoice Details
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'نقدي');--Is Cash
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'موظف');--Is Employee
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'طرف');--Is Party
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'حساب النظام');--Is System Account
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'كود الصنف');--Item Code
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'أسعار التكلفة للصنف');--Item Cost Prices
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'مجموعة الصنف');--Item Group
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'مجموعات الصنف');--Item Groups
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'معرف الصنف');--Item Id
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اسم الصنف');--Item Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'نظرة عامة على الصنف');--Item Overview
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اسعار بيع الصنف');--Item Selling Prices
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'نوع الصنف');--Item Type
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'انواع الصنف');--Item Types
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الاصناف');--Items
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الاصناف التالية وصلت لمستوي اعادة الطلب');--Items Below Reorder Level
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'قسيمة يومية');--Journal Voucher
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'ادخال قسيمة بومية');--Journal Voucher Entry
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الخاصية "KeyColumn" لا يمكن أن تترك فارغة.');--The property 'KeyColumn' cannot be left empty.
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'دائن ( بالعملة المحلية )');--LC Credit
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'مدين ( بالعملة المحلية )');--LC Debit
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', ' طريقة الوارد أخيراَ صادر أولاَ (LIFO)');--Last In, First Out (LIFO)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الاخير');--Last
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اخر وصول في');--Last Accessed On
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'آخر تسجيل دخول عنوان IP');--Last Login IP
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'آخر تسجيل دخول في');--Last Login On
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'آخر صفحة');--Last Page
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اخر تاريخ دفع');--Last Payment Date
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اخر كتابة في');--Last Written On
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الرسوم المتأخرة');--Late Fees
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'مصدر العملاء المحتملين');--Lead Sources
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'مصادر العملاء المحتملين');--Lead Statuses
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'مهلة العملاء المحتملين');--Lead Time
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'قائمة الاصناف');--List Items
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'حمل');--Load
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تسجيل الدخول إلى حسابك');--Logged in to
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'عرض تسجيل الدخول');--Login View
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', ' طريقة متوسط التكلفة (MAVCO)');--Moving Average Cost (MAVCO)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'إدارة الملف الشخصي');--Manage Profile
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الحد الأقصى لمبلغ الائتمان');--Maximum Credit Amount
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الحد الاقصيأ لفترة الائتمان');--Maximum Credit Period
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'سياسة الوصول القائمة');--Menu Access Policy
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'كود القائمة');--Menu Code
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'معرف القائمة');--Menu Id
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'نص القائمة');--Menu Text
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'رسوم التاجر (في المائة)');--Merchant Fee (In percent)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'إعداد الرسوم التاجر');--Merchant Fee Setup
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'دمج دفعة لGRN');--Merge Batch to GRN
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'دمج دفعة لتسليم المبيعات');--Merge Batch to Sales Delivery
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'دمج دفعة لاوامر المبيعات');--Merge Batch to Sales Order
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'رسالة');--Message
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تحديث الملفات');--Migrating Files
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'MixERP وثائق');--MixERP Documentation
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'MixERP روابط سريعة');--MixERP Links
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'MixERP في الفيسبوك');--MixERP on Facebook
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'MixERP معلمات');--MixERP Parameters
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', ' الاثنين');--Monday
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'شهر');--Month
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اسم');--Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تاريخ دفتر جديد');--New Book Date
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'سنة مالية جديدة');--New Fiscal Year
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'إدخال دفتر اليومية جديد');--New Journal Entry
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'كلمة المرور الجديدة');--New Password
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الإصدار الجديد متوفر الان');--A New Release Is Available
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'التالي');--Next
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الصفحة التالية');--Next Page
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'لا');--No
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'مبيعات غير خاضع للضريبة');--Nontaxable Sales
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', ' لا يخضع لضريبة القيمة المضافة');--Non VAT
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'لا شيء');--None
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'عادة مدين');--Normally Debit
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'لم يتم اختيار شي!');--Nothing selected!
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'التنويهات');--Notifications
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'موافق');--OK
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'شركة');--Office
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'معرف الشركة');--Office Code
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'معلومات عن الشركة');--Office Information
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', ' شعار الشركة');--Office Logo
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اسم الشركة');--Office Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'كنية الشركة');--Office Nick Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اعدادات الشركة');--Office Setup
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'يرجى كتابة رقم صالح.');--Please type a valid number.
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'OpenExchangeRates معلمات');--OpenExchangeRates Parameters
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الارصدة الافتتاحية للمخزون');--Opening Inventory
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'مراحل فرصة');--Opportunity Stages
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تفاصيل أخرى');--Other Details
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'ادوات اخري');--Other Widgets
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'PAN رقم');--PAN Number
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'مخصص الارباح والخسائر');--PL Appropriation
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الصفحة {0}');--Page {0}
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'حساب الأصل');--Parent Account
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الأطراف');--Parties
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'طرف');--Party
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'طود الطرف');--Party Code
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اسم الطرف');--Party Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'ملخص الطرف');--Party Summary
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'نوع الطرف');--Party Type
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'أنواع الاطراف');--Party Types
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'كلمة السر');--Password
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تم تحديث كلمة السر.');--Password was updated.
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'بطاقات الدفع');--Payment Cards
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'شروط الدفع');--Payment Terms
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اداء عملية نهاية اليوم');--Perform EOD
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تنفيذ عملية نهاية اليوم ');--Perform EOD Operation
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'جاري تنفيذ عملية نهاية اليوم ');--Performing EOD Operation
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', ' الجرد الدوري');--Periodic Inventory
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', ' الجرد المستمر');--Perpetual Inventory
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تليفون');--Phone
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'ضع طلبات اعادة الطلب');--Place Reorder Request(s)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'ترحيل حركة');--Post Transaction
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'رحلت بواسطة');--Posted By
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تاريخ الترحيل');--Posted Date
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'المورد المفضل');--Preferred Supplier
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'المفضل SupId');--Pref SupId
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'إعداد');--Prepare
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'أعد في');--Prepared On
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'معاينة');--Preview
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'السابق');--Previous
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الرصيد السابق');--Previous Balance
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'دائن سابق');--Previous Credit
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'مدين السابق');--Previous Debit
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الصفحة السابقة');--Previous Page
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الفترة السابقة');--Previous Period  
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'السعر');--Price
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'نوع سعر');--Price Type
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', ' نوع ضريبة المبيعات الرئيسية');--Primary Sales Tax Type
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'طباعة');--Print
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'طباعة قيود يومية الاستاذ العام');--Print GL Entry
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'طباعة الإيصال');--Print Receipt
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'بيان الربح والخسارة');--Profit & Loss Statement
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الارباح قبل الضريبة');--Profit Before Tax
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'ربح او خسارة');--Profit or Loss
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تقدم');--Progress
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'نشرت في يوم');--Published On
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'فاتورة الشراء');--Purchase Invoice
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'أمر شراء');--Purchase Order
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'مردودات المشتريات');--Purchase Return
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'نوع شراء');--Purchase Type
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'كمية');--Quantity
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الكمية');--Qty
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الكمية (الفعلية)');--Qty (On Hand)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تفاصيل التسعير');--Quotation Details
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', ' مهلة طلب التسعير');--Quotation Valid Days
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'معدل');--Rate
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'سبب');--Reason
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'إيصال');--Receipt
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'مبلغ الايصال');--Receipt Amount
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'عملة الايصال');--Receipt Currency
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'نوع الايصال');--Receipt Type
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تسليم');--Receive
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تم التسليم');--Received
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'المبلغ المستلم (بالعملة المذكورة أعلاه)');--Received Amount (In above Currency)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تم التسليم بواسطة');--Received By
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'عملة التسليم');--Received Currency
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تم السليم في');--Received On
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'توفيق');--Reconcile
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'إعداد فاتورة متكررة');--Recurring Invoice Setup
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الفواتير المتكررة');--Recurring Invoices
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الرقم المرجعي');--Reference Number
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'المرجع #');--Ref#
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'المرجع #');--Ref #
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'البيانات الإقليمية (بما في ذلك شجرة الحسابات)');--Regional Data (Including Chart of Accouts)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تاريخ التسجيل');--Registration Date
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'رفض');--Reject
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'رفض هذه الحركة');--Reject This Transaction
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الحركات المرفوضة');--Rejected Transactions
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'معرف الاصدار');--Release Id
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تذكر بياناتي');--Remember Me
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'إزالة التطبيق');--Removing Application
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'مستوي اعادة الطلب');--Reorder Level
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'كمية اعادة الطلب');--Reorder Qty
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اسم وحدة إعادة الطلب');--Reorder Unit Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'هذا الحقل مطلوب.');--This is a required field.
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', ' الحقول التي تحمل علامة النجمة (*) مطلوبة.');--The fields marked with asterisk (*) are required.
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', ' *');-- *
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'إعادة تعيين');--Reset
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'استعادة الملفات');--Restoring Directories
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'استعادة الملفات المحدثة');--Restoring Migration Files
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'وضع الحركات مقيدة');--Restricted Transaction Mode
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الأرباح المحتجزة');--Retained Earnings
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'عودة');--Return
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'العودة للخلف');--Return Back
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'العودة للصفحة الرئيسية');--Return Home
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'العودة للعرض');--Return to View
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'وظيفة');--Role
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'وظائف');--Roles
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'عدد الصفوف');--Row Number
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تشغيل تصحيح قاعدة البيانات');--Running Database Patch
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الاجمالي التشغيلي');--Running Total
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'SMTP اعدادات');--SMTP Configuration
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'رقم SST');--SST Number
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'مبيعات حسب الشهر (بالآلاف)');--Sales By Month (In Thousands)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'المبيعات حسب الشركة');--Sales By Office
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'المبيعات حسب شركة (بالآلاف)');--Sales By Office (In Thousands)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تلسليم المبيعات');--Sales Delivery
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'مذكرة تسليم المبيعات');--Delivery Note
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'فاتورة المبيعات');--Sales Invoice
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'طلب المبيعات');--Sales Order
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'مندوبي المبيعات');--Salespersons
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تسعير المبيعات');--Sales Quotation
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تسليم المبيعات');--Sales Receipt
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'مردودات المبيعات');--Sales Return
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تفاصيل ضريبة المبيعات');--Sales Tax Details
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تفاصيل اعفاء ضريبة المبيعات');--Sales Tax Exempt Details
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اعفاءات ضريبة المبيعات');--Sales Tax Exempts
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'أنواع ضريبة المبيعات');--Sales Tax Types
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الضرائب على المبيعات');--Sales Taxes
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'فرق المبيعات');--Sales Teams
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'نوع المبيعات');--Sales Type
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'مندوب مبيعات');--Salesperson
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'السبت');--Saturday
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'حفظ');--Save
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'احفظ الطلب');--Save Order
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'جاري الحفظ');--Saving
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'ScrudFactory معلمات');--ScrudFactory Parameters
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'بحث');--Search
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اختيار');--Select
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اختار شركة');--Select Company
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اختار العميل');--Select Customer
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اختر المصروفات للاستاذ العام');--Select Expenses GL
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اختار العلامة');--Select a Flag
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اختار النموذج');--Select a Form
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اختار المجموعة');--Select a Group
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اختار اللغة');--Select Language
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اختار شركة');--Select Office
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اختر حساب مخصص الارباح والخسائر');--Select PL Appropriation A/C
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'احتار الطرف');--Select Party
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اختار بطاقات الدفع');--Select Payment Card
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اختار المخزن');--Select Store
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اختار المورد');--Select Supplier
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اختار الاستاذ العام لضرائب الشركة');--Select Tax Office GL
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اختار الوحدة');--Select Unit
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اختار المستخدم');--Select User
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اختار الفرع');--Select Your Branch
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'احتار الاداوات');--Selected Widgets
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'إرسال');--Send
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'أرسلت');--Sent
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اعداد البريد الالكتروني');--Setup Email
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'شركة الشحم');--Shipper
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'شركات الشحن');--Shippers
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'عنوان الشحن');--Shipping Address
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اعدادات عنوان الشحن');--Shipping Address Maintenance
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'عنوان الشحن (العناوين)');--Shipping Address(es)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'مصاريف الشحن');--Shipping Charge
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'شركة الشحن');--Shipping Company
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'عرض');--Show
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'عرض الكل');--Show All
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'عرض مختصر');--Show Compact
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تسجيل الدخول');--Sign In
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تسجيل الخروج');--Sign Out
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'جاري تسجيل الدخول');--Signing In
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'مصدر المخزن');--Source Store
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'ابدا');--Start
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'ضريبة مبيعات العامة (الدولة)');--State Sales Tax
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الضرائب على المبيعات الدولة ( العامة)');--State Sales Taxes
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'قائمة التدفقات النقدية');--Statement of Cash Flows
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'مرجع كشف الحساب');--Statement Reference
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الدول');--States
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الحالة');--Status
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تسوية المخزون');--Stock Adjustment
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'حركات المخزون');--Stock Transaction
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اشعار تحويل المخزون');--Stock Transfer Acknowledgement
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تفويض تحويل المخزون');--Stock Transfer Authorization
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تسليم تحويل المخزون');--Stock Transfer Delivery
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'يومية تحويل المخزون');--Stock Transfer Journal
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'طلب تحويل المخزون');--Stock Transfer Request
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'مخزن');--Store
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اسم المخزن');--Store Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'نوع المخزن');--Store Types
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'مخازن');--Stores
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اجمالي فرعي');--Sub Total
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'إرسال الاخطاء');--Submit Bugs
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تم التحديث بنجاح');--Successfully Updated
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الاحد');--Sunday
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اسم المورد');--Supplier Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الدعم الفني');--Support
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'مفاتيح');--Switches
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الخاصية "Table" لا يمكن أن تترك فارغة.');--The property 'Table' cannot be left empty.
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الخاصية  "TableSchema"  لا يمكن أن تترك فارغة.');--The property 'TableSchema' cannot be left empty.
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اسم العلامة');--Tag Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تم الانتهاء من المهمة بنجاح.');--The task was completed successfully.
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'ضريبة');--Tax
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'مصلحة الضرائب');--Tax Authorities
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'انواع الضريبة المعفاة');--Tax Exempt Types
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'نموذج الضريبة');--Tax Form
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الضريبة الرئيسية');--Tax Master
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'معدل الضريبة');--Tax Rate
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'إعداد الضرائب');--Tax Setup
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'إجمالي الضريبة');--Tax Total
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'أنواع الضرائب');--Tax Types
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'المبيعات الخاضعة للضريبة');--Taxable Sales
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'التليفون');--Tel
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'شكرا لك');--Thank You
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الخميس');--Thursday
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'إلى');--To
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الي حساب مخصص الارباح والخسائر');--To PL Appropriation A/C
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'أعلى مبيعات في كل الاوقات');--Top Selling Products of All Time
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'مجموع');--Total
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'إجمالي المبلغ المستحق');--Total Due Amount
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'إجمالي المبلغ المستحق (شركة الحالية)');--Total Due Amount (Current Office)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'إجمالي المبلغ المستحق (العملة الأساسية)');--Total Due Amount (In Base Currency)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'إجمالي المبيعات :');--Total Sales :
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'كود المعاملة');--Tran Code
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'معرف المعاملة');--Tran Id
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'TranId: # {0}');--TranId: #{0}
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تاريخ المعاملة');--Transaction Date
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تفاصيل المعاملة');--Transaction Details
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تاريخ بداية تسجيل المعاملات');--Transaction Start Date
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'بيان المعاملة');--TransactionStatement
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'حالة المعاملة');--Transaction Status
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'ملخص المعاملة');--Transaction Summary
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الطابع الزمني للمعاملة');--Transaction Timestamp
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'نوع المعاملة');--Transaction Type
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'قيمة المعاملة');--Transaction Value
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تفاصيل التحويل');--Transfer Details
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'ميزان المراجعة');--Trial Balance
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الثلاثاء');--Tuesday
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'نوع');--Type
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الغاء الكل');--Uncheck All
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تراجع');--Undo
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'وحدة');--Unit
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'معرف الوحدة');--Unit Id
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اسم الوحدة');--Unit Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'وحدات القياس');--Units of Measure
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'فشلت العملية بسبب خطأ غير معروف.');--Operation failed due to an unknown error.
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'التحديث');--Update
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'وحدة التحكم التحديث');--Update Console
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تم التحديث في');--Updated On
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تحميل');--Upload
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تحميل المرفقات');--Upload Attachments
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تحميل المرفقات لهذه المعاملة');--Upload Attachments for This Transaction
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تحميل الشعار');--Upload Logo
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'رابط');--Url
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'استعمال');--Use
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'المستخدم');--User
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'معرف المستخدم');--User Id
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'إدارة المستخدمين');--User Management
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اسم المستخدم');--Username
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'المستخدمين');--Users
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'ضريبة القيمة المضافة (VAT)');--VAT
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'VAT/GST');--VAT/GST
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تفريغ قاعدة البيانات');--Vacuum Database
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تفريغ قاعدة البيانات (كاملة)');--Vacuum Database (Full)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'قيمة التاريخ');--Value Date
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'سبب التحقق');--Verification Reason
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تم التحقق بواسطة');--Verified By
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تم التحقق في');--VerifiedOn
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تحقق من');--Verify
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اسم الإصدار');--Version Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'عرض');--View
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'مشاهدة المرفقات');--View Attachments
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'عرض النسخ الاحتياطية');--View Backups
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'عرض نسخة العميل');--View Customer Copy
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'خاصية "View" لا يمكن أن يترك فارغا.');--The property 'View' cannot be left empty.
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'عرض فاتورة المبيعات');--View Sales Invoice
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الخاصية "ViewSchema" لا يمكن أن تترك فارغة.');--The property 'ViewSchema' cannot be left empty.
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'عرض هذا الاشعار');--View This Acknowledgement
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'عرض هذه التسوية');--View This Adjustment
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'عرض هذا التفويض');--View This Authorization
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'عرض هذا التسليم');--View This Delivery
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'عرض هذه الفاتورة');--View This Invoice
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'عرض هذه المذكرة');--View This Note
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'عرض هذا الأمر');--View This Order
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'عرض هذا التسعير');--View This Quotation
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'عرض هذا الطلب');--View This Request
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'عرض هذه المردودات');--View This Return
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'عرض هذا التحويل');--View This Transfer
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تحقق القسيمة');--Voucher Verification
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'سياسة تحقق القسيمة');--Voucher Verification Policy
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'تحذير');--Warning
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الاربعاء');--Wednesday
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'يبدأ الاسبوع في');--Week Starts On
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اي بنك؟');--Which Bank?
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الاداة');--Widget
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'مدير الادوات');--Widget Manager
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'الادوات');--Widgets
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'سحب');--Withdraw
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'سحب معاملة');--Withdraw Transaction
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'سحب');--Withdrawn
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'سحب المعاملات');--Withdrawn Transactions
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'سير العمل');--Workflow
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'احصائيات مبيعات الشركة العالمية');--World Sales Statistics
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'سنة');--Year
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'نعم');--Yes
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'اسمك');--Your Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Titles', 'شركتك');--Your Office
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'تم رفض الوصول.');--Access is denied.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'دليل النسخ الاحتياطي غير موجود');--Backup directory was not found.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'عذرا، لا يمكن إنشاء نسخة احتياطية قاعدة البيانات في هذا الوقت.');--Sorry, cannot create a database backup at this time.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'لا يمكن إنشاء أو تحديث العلامة، لم تدخل جدول المعاملة.');--Cannot create or update flag. Transaction table was not provided.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'لا يمكن إنشاء أو تحديث العلامة، لم تدخل المفتاح الرئيسي جدول المعاملة.');--Cannot create or update flag. Transaction table primary key was not provided.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'المعاملات المحددة تحتوي علي اصناف تم دمجها. حاول مرة اخرى.');--The selected transactions contain items which have already been merged. Please try again.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'لا يمكن دمج معاملات اطراف مختلفة دفعة واحدة. حاول مرة اخرى.');--Cannot merge transactions of different parties into a single batch. Please try again.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'لا يمكن دمج معاملات تحتوي علي أنواع ضرائب غير متوافقة. حاول مرة اخرى.');--Cannot merge transactions having incompatible tax types. Please try again.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'لا يمكن دمج المعاملات. لم يتم توفير رابط الدمج.');--Cannot merge transactions. The merge url was not provided.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'لا يمكن أن يحتوي المعاملات النقدية تفاصيل المعاملة البنكية.');--A cash transaction cannot contain bank transaction details.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', '(المبلغ من)  يجب أن تكون أكبر من (المبلغ الي)');--The amount to should be greater than the amount from.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', '(الي ايام) يجب أن تكون أقل من (من ايام)');--From days should be less than to days.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', '(السعر الي) يجب أن يكون أقل من (السعر من)');--Price from should be less than price to.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'لا يمكن الاستمرار في المهمة. يرجى تصحيح مشكلات الاعدادات.');--Cannot continue the task. Please correct configuration issues.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'تأكيد كلمة السر غير متطابقة مع كلمة السر');--The confirmation password does not match with the new password.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'لا يمكن تحديد نوع صورة محلل للبريد الإلكتروني.');--Could not determine image parser type for email.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'لا يمكن تسجيل جافا سكريبت في هذه الصفحة لأن  الصفحة غير صالحة أو فارغة.');--Could not register JavaScript on this page because the page instance was invalid or empty.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'التاريخ المحدد غير صالح.');--Selected date is invalid.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'ايام الاستحقاق بسبب يجب أن تكون صفر إذا تم اختيار فترة الاستحقاق.');--Due days should be 0 if due frequency id is selected.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'تكرار الادخال.');--Duplicate entry.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'الملفات مكررة.');--Duplicate files.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'Gridview فارغ.');--Gridview is empty.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'لا يوجد رصيد كاف في الخزينة النقدية لمعالجة هذه المعاملة.');--There is no sufficient balance in the cash repository to process this transaction.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'فقط {0} {1} من {2} متبقي من المخزون.');--Only {0} {1} of {2} left in stock.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'الحساب غير صالح.');--Invalid account.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'الخزينة النقدية صالح.');--Invalid cash repository.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'مركز تكلفة غير صالح.');--Invalid cost center.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'بيانات غير صالحة.');--Invalid data.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'التاريخ غير صالح.');--Invalid date.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'امتداد الملف غير صالح.');--Invalid file extension.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'Npgsql اسم المعلمة غير صالح {0}. . تأكد من أن اسم المعلمة متشابه مع نص الأمر.');--Invalid Npgsql parameter name {0}. . Make sure that the parameter name matches with your comm (...)
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'طرف غير صالح');--Invalid party.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'مصطلح الدفع غير صالحة.');--Invalid payment term.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'نوع السعر غير صالح.');--Invalid price type.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'ضع الايصال غير صالح.');--Invalid receipt mode.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'طلب غير صالح.');--Invalid Request.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'RequestId غيرصالح.');--Invalid RequestId.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'مندوب مبيعات غير صالح.');--Invalid salesperson.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'شركة الشحن غير صالحة.');--Invalid shipping company.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'معاملة المخزون غير صالحة.');--Invalid stock transaction.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'مخزن غير صالح.');--Invalid store.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'SubTranBook "تسليم المخزون" غير صالح');--Invalid SubTranBook "Inventory Delivery"
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'SubTranBook "المخزون المباشر" غير صالح');--Invalid SubTranBook "Inventory Direct"
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'SubTranBook "فاتورة المخزون" غير صالحة');--Invalid SubTranBook "Inventory Invoice"
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'SubTranBook "طلب المخزون" غير صالح');--Invalid SubTranBook "Inventory Order"
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'SubTranBook "مدفوعات المخزون" غير صالحة');--Invalid SubTranBook "Inventory Payment"
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'SubTranBook "تسعير المخزون" غير صالح');--Invalid SubTranBook "Inventory Quotation"
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'SubTranBook "استلام المخزون" غير صالح');--Invalid SubTranBook "Inventory Receipt"
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'SubTranBook "مرتجع المخزون" غير صالح');--Invalid SubTranBook "Inventory Return"
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'SubTranBook "تسليم المشتريات" غير صالح');--Invalid SubTranBook "Purchase Delivery"
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'SubTranBook "تسعير المشتريات" غير صالح');--Invalid SubTranBook "Purchase Quotation"
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'SubTranBook "ارجاء المشتريات" غير صاالح');--Invalid SubTranBook "Purchase Suspense"
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'SubTranBook "تحويل المشتريات" غير صالح');--Invalid SubTranBook "Purchase Transfer"
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'SubTranBook "مدفوعات المبيعات" غير صالحة');--Invalid SubTranBook "Sales Payment"
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'SubTranBook "ارجاء المبيعات" غير صالحة');--Invalid SubTranBook "Sales Suspense"
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'SubTranBook "نقل مبيعات" غير صالح');--Invalid SubTranBook "Sales Transfer"
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'مستخدم غير صالح.');--Invalid user.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'لديك اختيار إما معرف الصنف أو مركب معرف الصنف.');--You have to select either item id or  compound item id.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'يجب اختيار معرف رسوم التأخير ومعرف فترة ترحيل رسوم التاخير او عدم الاختيار.');--Late fee id and late fee posting frequency id both should be either selected or not.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'تم ادخال قيمة سالية.');--Negative value supplied.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'كلمة المرور الجديدة لا يمكن أن تكون كلمة السر القديمة.');--New password can not be old password.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'لا يوجد ملف محدد.');--No file specified.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'لا توجد معاملات للترحيل.');--No transaction to post.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'غير مصرح لك بالوصول إلى هذه الموارد في الوقت الحالي.');--You are not authorized to access this resource at this time.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'لم يتم اختيار شئ.');--Nothing selected.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'كلمة السر لا يمكن أن يكون فارغة.');--Password cannot be empty.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'الرجاء إدخال كلمة المرور الحالية.');--Please enter your current password.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'يرجى إدخال كلمة مرور جديدة.');--Please enter a new password.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'لا ينبغي أن يكون المبلغ المتكرر أقل من أو يساوي 0.');--Recurring amount should not be less than or equal to 0.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'كلا مرجع الجانبين ليست متساوية.');--The referencing sides are not equal.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'هذه الشركة لا تسمح بترحيل المعاملة.');--This establishment does not allow transaction posting.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'لا يمكن العودة . لم يتم توفير رابط العودة.');--Cannot return this entry. The return url was not provided.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'تاريخ البدء لا يمكن أن يكون أكبر من تاريخ انتهاء.');--The start date cannot be greater than end date.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'Warnings', 'اسم المستخدم أو كلمة المرور غير صحيحة.');--User id or password incorrect.


