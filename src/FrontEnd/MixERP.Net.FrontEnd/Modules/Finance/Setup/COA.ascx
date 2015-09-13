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

<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="COA.ascx.cs" Inherits="MixERP.Net.Core.Modules.Finance.Setup.COA" %>
<script src="/Scripts/underscore/underscore-min.js"></script>
<script>
    var title = window.Resources.Titles.ChartOfAccounts();

    var viewPocoName = "AccountScrudView";

    var formPocoName = "Account";
    var formTableName = "core.accounts";

    var allowDelete = true;
    var allowEdit = true;
    var live = "AccountName";
    var queryStringKey = "AccountId";
    var excludedColumns = ["audit_user_id", "audit_ts"];
</script>

<script>
    var keys = [
        {
            property: "AccountMasterId",
            url: '/api/core/account-master/display-fields',
            data: null,
            isArray:false,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "CurrencyCode",
            url: '/api/core/currency/display-fields',
            data: null,
            isArray: false,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "ParentAccountId",
            url: '/api/core/account/display-fields',
            data: null,
            isArray: false,
            valueField: "Key",
            textField: "Value"
        }
    ];
</script>

<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>