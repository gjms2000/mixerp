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
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CashFlowSetup.ascx.cs" Inherits="MixERP.Net.Core.Modules.Finance.Setup.CashFlowSetup" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.CashFlowSetup();

    scrudFactory.viewAPI = "/api/core/cash-flow-setup-scrud-view";
    scrudFactory.viewTableName = "core.cash_flow_setup_scrud_view";

    scrudFactory.formAPI = "/api/core/cash-flow-setup";
    scrudFactory.formTableName = "core.cash_flow_setups";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.keys = [
        {
            property: "CashFlowHeadingId",
            url: '/api/core/cash-flow-heading/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "AccountMasterId",
            url: '/api/core/account-master/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        }
    ];
</script>


<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>
