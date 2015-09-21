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
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MerchantFeeSetup.ascx.cs" Inherits="MixERP.Net.Core.Modules.Finance.Setup.MerchantFeeSetup" %>
<script src="/Scripts/underscore/underscore-min.js"></script>
<script>
    var scrudFactory = new Object();
    scrudFactory.title = window.Resources.Titles.MerchantFeeSetup();

    scrudFactory.viewAPI = "/api/core/merchant-fee-setup-scrud-view";
    scrudFactory.viewTableName = "core.merchant_fee_setup_scrud_view";

    scrudFactory.formAPI = "/api/core/merchant-fee-setup";
    scrudFactory.formTableName = "core.merchant_fee_setup";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.keys = [
        {
            property: "MerchantAccountId",
            url: '/api/core/merchant-account-selector-view/display-fields',
            data: null,
            isArray:false,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "PaymentCardId",
            url: '/api/core/payment-card-scrud-view/display-fields',
            data: null,
            isArray: false,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "AccountId",
            url: '/api/core/merchant-fee-setup-account-selector-view/display-fields',
            data: null,
            isArray: false,
            valueField: "Key",
            textField: "Value"
        }
    ];


</script>

<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>
