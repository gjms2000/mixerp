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
along with MixERP.  If not, see <http://www.gnu.org/licenses />.
--%>

<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BankAccounts.ascx.cs" Inherits="MixERP.Net.Core.Modules.Finance.Setup.BankAccounts" %>

<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.BankAccounts();
    scrudFactory.viewAPI = "/api/core/bank-account-scrud-view";
    scrudFactory.viewTableName = "core.bank_accounts";

    scrudFactory.formAPI = "/api/core/bank-account";
    scrudFactory.formTableName = "core.bank_accounts";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.layout = [
        ["AccountId", ""],
        ["BankName", "BankBranch", "", ""],
        ["OfficeId", "MaintainedByUserId", "", ""],
        ["BankAccountNumber", "BankContactNumber", "", ""],
        ["BankAddress", ""]
    ];

    scrudFactory.keys = [
        {
            property: "MaintainedByUserId",
            url: '/api/office/user-selector-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "AccountId",
            url: '/api/core/bank-account-selector-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "OfficeId",
            url: '/api/office/office-scrud-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        }
    ];

    scrudFactory.live = "BankAccountNumber";
</script>


<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>
