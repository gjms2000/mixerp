var isValid = true;
var officeNameInputText = $("#OfficeNameInputText");
var officeCodeInputText = $("#OfficeCodeInputText");
var nickNameInputText = $("#NickNameInputText");
var registrationDateInputText = $("#RegistrationDateInputText");
var currencyCodeInputText = $("#CurrencyCodeInputText");
var currencySymbolInputText = $("#CurrencySymbolInputText");
var currencyNameInputText = $("#CurrencyNameInputText");
var hundredthNameInputText = $("#HundredthNameInputText");
var fiscalYearCodeInputText = $("#FiscalYearCodeInputText");
var fiscalYearNameInputText = $("#FiscalYearNameInputText");
var startsFromInputText = $("#StartsFromInputText");
var endsOnInputText = $("#EndsOnInputText");
var incomeTaxRateInputText = $("#IncomeTaxRateInputText");
var weekStartDaySelect = $("#WeekStartDaySelect");
var transactionStartDateInputText = $("#TransactionStartDateInputText");
var inventoryAccountingSystemSelect = $("#InventoryAccountingSystemSelect");
var inventoryValuationMethodSelect = $("#InventoryValuationMethodSelect");
var adminNameInputText = $("#AdminNameInputText");
var usernameInputText = $("#UsernameInputText");
var passwordInputPassword = $("#PasswordInputPassword");
var confirmPasswordInputPassword = $("#ConfirmPasswordInputPassword");
var saveButton = $("#SaveButton");
var file = $("#file");
var logo = "";
var allowed = [".jpg", ".jpeg", ".bmp", ".gif", ".png"];

$(document).ready(function () {
    initializeUI();
    var year = new Date().getYear() + 1900;

    fiscalYearCodeInputText.val("FY-" + year.toString().slice(-2));
    fiscalYearNameInputText.val("FY-" + year);
});

function initializeUI() {
    $(".ui.dropdown").dropdown();
    $('.activating.element').popup();
    $('.checkbox').checkbox();
};

var validateFields = function() {
    if (isNullOrWhiteSpace(officeNameInputText.val()) ||
        isNullOrWhiteSpace(officeCodeInputText.val()) ||
        isNullOrWhiteSpace(nickNameInputText.val()) ||
        isNullOrWhiteSpace(registrationDateInputText.val()) ||
        isNullOrWhiteSpace(currencyCodeInputText.val()) ||
        isNullOrWhiteSpace(currencySymbolInputText.val()) ||
        isNullOrWhiteSpace(currencyNameInputText.val()) ||
        isNullOrWhiteSpace(hundredthNameInputText.val()) ||
        isNullOrWhiteSpace(fiscalYearCodeInputText.val()) ||
        isNullOrWhiteSpace(fiscalYearNameInputText.val()) ||
        isNullOrWhiteSpace(startsFromInputText.val()) ||
        isNullOrWhiteSpace(endsOnInputText.val()) ||
        !parseFloat(incomeTaxRateInputText.val()) ||
        isNullOrWhiteSpace(weekStartDaySelect.val()) ||
        isNullOrWhiteSpace(transactionStartDateInputText.val()) ||
        isNullOrWhiteSpace(adminNameInputText.val()) ||
        isNullOrWhiteSpace(usernameInputText.val()) ||
        isNullOrWhiteSpace(passwordInputPassword.val()) ||
        isNullOrWhiteSpace(confirmPasswordInputPassword.val())) {
        isValid = false;
        alert(allFieldsRequiredLocalized);
    } else {
        isValid = true;
    };

    if (isValid) {
        validatePassword();
    };
};

var validatePassword = function() {
    if (passwordInputPassword.val() !== confirmPasswordInputPassword.val()) {
        isValid = false;
        alert(confirmedPasswordDoesNotMatch);
    } else {
        isValid = true;
    };
};

saveButton.click(function() {

    validateFields();

    if (isValid) {
        $(".form").addClass("loading");
        $(".dimmer").dimmer("show");

        var salesTaxIsVat = $("input[name=salestax]:checked").val();
        var hasstateTax = $("input[name=statetax]:checked").val();
        var hascountyTax = $("input[name=countytax]:checked").val();

        var ajaxSaveOffice = saveOffice
            (
                officeCodeInputText.val(),
                officeNameInputText.val(),
                nickNameInputText.val(),
                registrationDateInputText.val(),
                currencyCodeInputText.val(),
                currencySymbolInputText.val(),
                currencyNameInputText.val(),
                hundredthNameInputText.val(),
                fiscalYearCodeInputText.val(),
                fiscalYearNameInputText.val(),
                startsFromInputText.val(),
                endsOnInputText.val(),
                salesTaxIsVat,
                hasstateTax,
                hascountyTax,
                parseFloat(incomeTaxRateInputText.val() || 0),
                weekStartDaySelect.val(),
                transactionStartDateInputText.val(),
                inventoryAccountingSystemSelect.getSelectedValue(),
                inventoryValuationMethodSelect.getSelectedValue(),
                logo,
                adminNameInputText.val(),
                usernameInputText.val(),
                passwordInputPassword.val(),
                confirmPasswordInputPassword.val()
            );

        ajaxSaveOffice.success(function(msg) {
            if (msg.d) {
                window.location = "/SignIn.aspx";
            } else {
                alert(msg.d);
            };
        });

        ajaxSaveOffice.error(function(xhr) {
            $(".form").removeClass("loading");
            $(".dimmer").dimmer("hide");
            alert(xhr.responseText);
        });
    };
});

function saveOffice(officeCode, officeName, nickName, registrationDate, currencyCode, currencySymbol, currencyName, hundredthName, fiscalYearCode, fiscalYearName, startsFrom, endsOn, salesTaxIsVat, hasStateSalesTax, hasCountySalesTax, incomeTaxRate, weekStartDay, transactionStartDate, isPerpetual, valuationMethod, logo, adminName, username, password, confirmPassword) {
    var url = "/Services/Install.asmx/SaveOffice";

    var data = appendParameter("", "officeCode", officeCode);
    data = appendParameter(data, "officeName", officeName);
    data = appendParameter(data, "nickName", nickName);
    data = appendParameter(data, "registrationDate", registrationDate);
    data = appendParameter(data, "currencyCode", currencyCode);
    data = appendParameter(data, "currencySymbol", currencySymbol);
    data = appendParameter(data, "currencyName", currencyName);
    data = appendParameter(data, "hundredthName", hundredthName);
    data = appendParameter(data, "fiscalYearCode", fiscalYearCode);
    data = appendParameter(data, "fiscalYearName", fiscalYearName);
    data = appendParameter(data, "startsFrom", startsFrom);
    data = appendParameter(data, "endsOn", endsOn);
    data = appendParameter(data, "salesTaxIsVat", salesTaxIsVat);
    data = appendParameter(data, "hasStateSalesTax", hasStateSalesTax);
    data = appendParameter(data, "hasCountySalesTax", hasCountySalesTax);
    data = appendParameter(data, "incomeTaxRate", incomeTaxRate);
    data = appendParameter(data, "weekStartDay", weekStartDay);
    data = appendParameter(data, "transactionStartDate", transactionStartDate);
    data = appendParameter(data, "isPerpetual", isPerpetual);
    data = appendParameter(data, "valuationMethod", valuationMethod);
    data = appendParameter(data, "logo", logo);
    data = appendParameter(data, "adminName", adminName);
    data = appendParameter(data, "username", username);
    data = appendParameter(data, "password", password);
    data = appendParameter(data, "confirmPassword", confirmPassword);
    data = getData(data);

    return getAjax(url, data);
};


function isValidExtension(el) {

    if (el.type === "file") {
        var fileName = el.value;

        if (fileName.length > 0) {

            var valid = false;

            for (var i = 0; i < allowed.length; i++) {
                var extension = allowed[i];

                if (fileName.substr(fileName.length - extension.length, extension.length).toLowerCase() === extension.toLowerCase()) {
                    valid = true;
                    break;
                };
            };

            if (!valid) {
                alert("Invalid file extension.");
                el.value = "";
                return false;
            };
        };
    };

    return true;
};



file.change(function () {
    if (isValidExtension(this)) {
        readURL(this);
        $('#logo').parent().addClass("loading");
        $(this).upload("/FileUploadHanlder.ashx", function (uploadedFileName) {
            logo = uploadedFileName;
            $('#logo').parent().removeClass("loading");
        }, function (progress, value) {
            //not implemented yet.
        });
    };
});

function readURL(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {
            $('#logo').attr('src', e.target.result);
            $('#logo').attr('style', "max-height:160px;max-width:250;");
        };

        reader.readAsDataURL(input.files[0]);
    };
};



