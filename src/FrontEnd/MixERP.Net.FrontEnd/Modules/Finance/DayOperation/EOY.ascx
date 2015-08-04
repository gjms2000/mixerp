<%-- 
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
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EOY.ascx.cs" Inherits="MixERP.Net.Core.Modules.Finance.DayOperation.EOY" %>
<%@ Import Namespace="MixERP.Net.i18n.Resources" %>
<div class="ui purple large header">End of Year Processing</div>
<div class="ui divider"></div>

<div class="ui basic buttons">
    <a class="ui button" onclick=" showIncomeTax(); ">Book Income Tax</a>
    <a class="ui button" onclick=" showBackup(); ">Create Backup</a>
    <a class="ui button" onclick=" showPLAppropriation(); ">PL Appropriation</a>
    <a class="ui button" onclick=" showBackup(); ">Create Backup</a>
    <a class="ui button" onclick=" showNewFiscalYear(); ">New Fiscal Year</a>
    <a class="ui button" onclick=" showEOD(); ">Perform EOD</a>
</div>


<div class="ui initially hidden segment" id="IncomeTaxPanel">
    <div class="ui purple header">Book Income Tax</div>
    <div class="ui divider"></div>

    <div class="ui form">
        <div class="fields">
            <div class="three wide field">
                <label for="TaxOfficeAccountSelect">Select Tax Office GL</label>
                <select class="ui search selection dropdown" id="TaxOfficeAccountSelect"></select>
            </div>
            <div class="three wide field">
                <label for="TaxExpenseSelect">Select Expenses GL</label>
                <select class="ui search selection dropdown" id="TaxExpenseSelect"></select>
            </div>
            <div class="three wide field">
                <label for="TaxCostCenterSelect">Cost Center</label>
                <select class="ui search selection dropdown" id="TaxCostCenterSelect"></select>
            </div>
            <div class="two wide field">
                <label for="ProfitBeforeTaxInputText">Profit Before Tax</label>
                <input type="text" id="ProfitBeforeTaxInputText" readonly />
            </div>
            <div class="two wide field">
                <label for="IncomeTaxRateInputText">Tax Rate</label>
                <input type="text" id="IncomeTaxRateInputText" readonly />
            </div>
            <div class="two wide field">
                <label for="IncomeTaxInputText">Income Tax</label>
                <input type="text" id="IncomeTaxInputText" readonly />
            </div>
        </div>
        <div class="fields">
            <div class="four wide field">
                <label for="TaxReferenceNumberInputText">Reference Number</label>
                <input type="text" id="TaxReferenceNumberInputText" />
            </div>
            <div class="twelve wide field">
                <label for="TaxStatementReferenceInputText">Statement Reference</label>
                <input type="text" id="TaxStatementReferenceInputText" />
            </div>
        </div>

        <input type="button" class="ui purple button" id="PostTaxButton" value="Post Transaction" />
    </div>
</div>

<div class="ui initially hidden segment" id="PLAppropriationPanel">
    <div class="ui purple header">PL Appropriation</div>
    <div class="ui divider"></div>

    <table class="ui striped celled table" data-ng-controller="EOYController">
        <thead>
            <tr>
                <th><%= Titles.AccountId %></th>
                <th><%= Titles.AccountNumber %></th>
                <th><%= Titles.Account %></th>
                <th><%= Titles.Debit %></th>
                <th><%= Titles.Credit %></th>
            </tr>
        </thead>
        <tbody>
            <tr data-ng-repeat="item in items">
                <td>{{item.AccountId}}</td>
                <td>{{item.AccountNumber}}</td>
                <td>{{item.AccountName}}</td>
                <td>{{item.Debit}}</td>
                <td>{{item.Credit}}</td>
            </tr>
        </tbody>
        <tfoot>
            <tr>
                <th class="right aligned" colspan="3"><%= Titles.Total %></th>
                <th>{{drTotal}}</th>
                <th>{{crTotal}}</th>
            </tr>
            <tr>
                <th class="right aligned" colspan="4">Profit or Loss</th>
                <td class="{{profit > 0 ? 'positive' : 'warning'}}">{{profit}}</td>
            </tr>
        </tfoot>
    </table>
    <div class="ui form" style="width: 500px;">
        <div class="two fields">
            <div class="field">
                <label><%= Titles.ReferenceNumber %></label>
                <input type="text" value="PL-APPR-2015" maxlength="24" id="ReferenceNumberInputText" />
            </div>
            <div class="field">
                <label><%= Titles.CostCenter %></label>
                <select class="ui dropdown" id="CostCenterSelect"></select>
            </div>
        </div>
        <div class="field">
            <label>Select PL Appropriation A/C</label>
            <select class="ui dropdown" id="PLAppropriationAccountSelect"></select>
        </div>
        <div class="field">
            <label><%= Titles.StatementReference %></label>
            <textarea rows="2" id="StatementReferenceTextArea">To PL Appropriation A/C</textarea>
        </div>


        <input id="PostPLAppropriationInputButton" type="button" class="ui purple button" value="<%= Titles.PostTransaction %>" />
    </div>

</div>


<div class="ui initially hidden segment" id="FiscalYearPanel">
    <div class="ui purple header">New Fiscal Year</div>
    <div class="ui divider"></div>

    <div class="ui form">
        <div class="fields">
            <div class="field">
                <label>Fiscal Year Code</label>
                <input type="text" id="FiscalYearCodeInputText" />
            </div>
            <div class="field">
                <label>Fiscal Year Name</label>
                <input type="text" id="FiscalYearNameInputText" />
            </div>
        </div>

        <input type="button" id="CreateFiscalYearButton" class="ui purple button" value="Create New Fiscal Year" />
    </div>
</div>

<script>
    var referenceNumberInputText = $("#ReferenceNumberInputText");
    var costCenterSelect = $("#CostCenterSelect");
    var pLAppropriationAccountSelect = $("#PLAppropriationAccountSelect");
    var statementReferenceTextArea = $("#StatementReferenceTextArea");
    var postPLAppropriationInputButton = $("#PostPLAppropriationInputButton");
    var taxOfficeSelect = $("#TaxOfficeAccountSelect");
    var taxExpenseSelect = $("#TaxExpenseSelect");
    var profitBeforeTaxInputText = $("#ProfitBeforeTaxInputText");
    var incomeTaxRateInputText = $("#IncomeTaxRateInputText");
    var incomeTaxInputText = $("#IncomeTaxInputText");

    var taxOfficeAccountSelect = $("#TaxOfficeAccountSelect");
    var taxExpenseSelect = $("#TaxExpenseSelect ");
    var taxCostCenterSelect = $("#TaxCostCenterSelect");
    var taxReferenceNumberInputText = $("#TaxReferenceNumberInputText");
    var taxStatementReferenceInputText = $("#TaxStatementReferenceInputText");
    var postTaxButton = $("#PostTaxButton");

    var plAppropriationPanel = $("#PLAppropriationPanel");
    var incomeTaxPanel = $("#IncomeTaxPanel");
    var fiscalYearPanel = $("#FiscalYearPanel");

    var fiscalYearCodeInputText = $("#FiscalYearCodeInputText ");
    var fiscalYearNameInputText = $("#FiscalYearNameInputText");
    var createFiscalYearButton = $("#CreateFiscalYearButton");

    var url;
    var data;


    function showIncomeTax() {
        fiscalYearPanel.addClass("initially hidden");
        plAppropriationPanel.addClass("initially hidden");
        incomeTaxPanel.removeClass("initially hidden");
    };

    function showPLAppropriation() {
        fiscalYearPanel.addClass("initially hidden");
        incomeTaxPanel.addClass("initially hidden");
        plAppropriationPanel.removeClass("initially hidden");
    };

    function showNewFiscalYear() {
        incomeTaxPanel.addClass("initially hidden");
        plAppropriationPanel.addClass("initially hidden");
        fiscalYearPanel.removeClass("initially hidden");
    };

    function showEOD() {
        window.location = 'EOD.mix?EOYCompleted=true';
    };

    MixERPApp.controller("EOYController", function ($scope, $sce) {
        function getAppropriationData() {
            url = "/Modules/Finance/Services/DayOperation/EOY.asmx/GetAppropriationData";
            return getAjax(url);
        };

        var ajaxGetAppropriationData = getAppropriationData();

        ajaxGetAppropriationData.success(function (msg) {
            $scope.$apply(function () {
                $scope.items = msg.d;

                var dr = 0;
                var cr = 0;
                for (var i = 0; i < msg.d.length; i++) {
                    dr += msg.d[i].Debit;
                    cr += msg.d[i].Credit;
                };

                $scope.drTotal = dr;
                $scope.crTotal = cr;
                $scope.profit = dr - cr; //Because the sides are inverted.
            });
        });

        ajaxGetAppropriationData.fail(function (xhr) {
            logAjaxErrorMessage(xhr);
        });
    });

    $(document).ready(function () {
        loadCostCenter();
        loadPLAppropriationAccount();
        loadTaxOfficeAccount();
        loadTaxExpensesAccount();
        loadEoyProfitSummary();
        checkNewFiscalYearExistence();
    });

    function checkNewFiscalYearExistence() {
        var ajaxIsNewFiscalYearCreated = isNewFiscalYearCreated();

        ajaxIsNewFiscalYearCreated.success(function(msg) {
            if (msg.d) {
                fiscalYearPanel.find("input").attr("disabled", "disabled");
            };
        });

        ajaxIsNewFiscalYearCreated.fail(function(xhr) {
            logAjaxErrorMessage(xhr);
        });
    };

    function loadEoyProfitSummary() {
        var ajaxGetEoyProfitSummary = getEoyProfitSummary();

        ajaxGetEoyProfitSummary.success(function (msg) {
            var data = msg.d;

            profitBeforeTaxInputText.val(data.ProfitBeforeTax);
            incomeTaxRateInputText.val(data.TaxRate);
            incomeTaxInputText.val(data.Tax);

        });

        ajaxGetEoyProfitSummary.fail(function (xhr) {
            logAjaxErrorMessage(xhr);
        });
    };


    createFiscalYearButton.click(function () {

        if (isNullOrWhiteSpace(fiscalYearCodeInputText.val())) {
            makeDirty(fiscalYearCodeInputText);
            return;
        };

        removeDirty(fiscalYearCodeInputText);

        if (isNullOrWhiteSpace(fiscalYearNameInputText.val())) {
            makeDirty(fiscalYearNameInputText);
            return;
        };

        removeDirty(fiscalYearNameInputText);

        var ajaxCreateNewFiscalYear = createNewFiscalYear(fiscalYearCodeInputText.val(), fiscalYearNameInputText.val());

        ajaxCreateNewFiscalYear.success(function () {
            displayMessage(Resources.Labels.TaskCompletedSuccessfully(), "success");
            fiscalYearPanel.addClass("initially hidden");
        });

        ajaxCreateNewFiscalYear.fail(function (xhr) {
            logAjaxErrorMessage(xhr);
        });

    });

    function isNewFiscalYearCreated() {
        url = "/Modules/Finance/Services/DayOperation/EOY.asmx/IsNewFiscalYearCreated";

        return getAjax(url);
    };

    function createNewFiscalYear(fiscalYearCode, fiscalYearName) {
        url = "/Modules/Finance/Services/DayOperation/EOY.asmx/CreateNewFiscalYear";
        data = appendParameter("", "fiscalYearCode", fiscalYearCode);
        data = appendParameter(data, "fiscalYearName", fiscalYearName);
        data = getData(data);

        return getAjax(url, data);
    };

    postTaxButton.click(function () {
        if (isNullOrWhiteSpace(taxOfficeAccountSelect.val())) {
            makeDirty(taxOfficeAccountSelect);
            return;
        };

        removeDirty(taxOfficeAccountSelect);

        if (isNullOrWhiteSpace(taxExpenseSelect.val())) {
            makeDirty(taxExpenseSelect);
            return;
        };

        removeDirty(taxExpenseSelect);

        if (parseFloat(taxCostCenterSelect.val() || 0) === 0) {
            makeDirty(taxCostCenterSelect);
            return;
        };

        removeDirty(taxCostCenterSelect);

        var ajaxPostIncomeTax = postIncomeTax
        (
            taxOfficeAccountSelect.val(),
            taxExpenseSelect.val(),
            taxCostCenterSelect.val(),
            taxReferenceNumberInputText.val(),
            taxStatementReferenceInputText.val()
        );


        ajaxPostIncomeTax.success(function () {
            window.location = "/Modules/Finance/VoucherVerification.mix";
        });

        ajaxPostIncomeTax.fail(function (xhr) {
            logAjaxErrorMessage(xhr);
        });
    });

    function postIncomeTax(taxOfficeAccountNumber, taxExpensesAccountNumber, costCenterId, referenceNumber, statementReference) {
        url = "/Modules/Finance/Services/DayOperation/EOY.asmx/PostIncomeTax";
        data = appendParameter("", "taxOfficeAccountNumber", taxOfficeAccountNumber);
        data = appendParameter(data, "taxExpensesAccountNumber", taxExpensesAccountNumber);
        data = appendParameter(data, "costCenterId", costCenterId);
        data = appendParameter(data, "referenceNumber", referenceNumber);
        data = appendParameter(data, "statementReference", statementReference);

        data = getData(data);

        return getAjax(url, data);
    };


    postPLAppropriationInputButton.click(function () {
        var referenceNumber = referenceNumberInputText.val();
        var costCenterId = parseInt(costCenterSelect.getSelectedValue() || 0);
        var accountNumber = pLAppropriationAccountSelect.getSelectedValue();
        var statementReference = statementReferenceTextArea.val();

        if (costCenterId === 0) {
            makeDirty(costCenterSelect);
            displayMessage(Resources.Warnings.InvalidCostCenter(), "error");
            return;
        };

        removeDirty(costCenterSelect);

        if (!accountNumber) {
            makeDirty(pLAppropriationAccountSelect);
            displayMessage(Resources.Warnings.InvalidAccount(), "error");
            return;
        };

        removeDirty(pLAppropriationAccountSelect);

        var ajaxPostPLAppropriation = postPLAppropriation(referenceNumber, costCenterId, accountNumber, statementReference);

        ajaxPostPLAppropriation.success(function () {
            window.location = "/Modules/Finance/VoucherVerification.mix";
        });

        ajaxPostPLAppropriation.fail(function (xhr) {
            logAjaxErrorMessage(xhr);
        });

    });

    function postPLAppropriation(referenceNumber, costCenterId, accountNumber, statementReference) {
        url = "/Modules/Finance/Services/DayOperation/EOY.asmx/PostPLAppropriation";
        data = appendParameter("", "referenceNumber", referenceNumber);
        data = appendParameter(data, "costCenterId", costCenterId);
        data = appendParameter(data, "accountNumber", accountNumber);
        data = appendParameter(data, "statementReference", statementReference);

        data = getData(data);

        return getAjax(url, data);
    };

    function getEoyProfitSummary() {
        url = "/Modules/Finance/Services/DayOperation/EOY.asmx/GetEoyProfitSummary";
        return getAjax(url);
    };

    function loadCostCenter() {
        var costCenters = [];
        costCenters.push(costCenterSelect, taxCostCenterSelect);

        url = "/Modules/Finance/Services/AccountData.asmx/GetCostCenters";
        ajaxDataBind(url, $(costCenters));
    };


    function loadPLAppropriationAccount() {
        url = "/Modules/Finance/Services/DayOperation/EOY.asmx/GetPLAppropriationAccounts";
        ajaxDataBind(url, pLAppropriationAccountSelect);
    };

    function loadPLAppropriationAccount() {
        url = "/Modules/Finance/Services/DayOperation/EOY.asmx/GetPLAppropriationAccounts";
        ajaxDataBind(url, pLAppropriationAccountSelect);
    };

    function loadTaxOfficeAccount() {
        url = "/Modules/Finance/Services/DayOperation/EOY.asmx/GetLiabilityAccounts";
        ajaxDataBind(url, taxOfficeSelect);
    };

    function loadTaxExpensesAccount() {
        url = "/Modules/Finance/Services/DayOperation/EOY.asmx/GetIncomeTaxExpenseAccounts";
        ajaxDataBind(url, taxExpenseSelect);
    };
</script>
