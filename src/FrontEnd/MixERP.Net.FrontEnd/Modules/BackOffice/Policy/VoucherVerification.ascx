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

<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="VoucherVerification.ascx.cs" Inherits="MixERP.Net.Core.Modules.BackOffice.Policy.VoucherVerification" %>

<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.VoucherVerificationPolicy();

    scrudFactory.viewAPI = "/api/policy/voucher-verification-policy-scrud-view";
    scrudFactory.viewTableName = "policy.voucher_verification_policy_scrud_view";

    scrudFactory.formAPI = "/api/policy/voucher-verification-policy";
    scrudFactory.formTableName = "policy.voucher_verification_policy";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.live = "ShiftName";

    scrudFactory.keys = [
        {
            property: "OfficeId",
            url: '/api/office/office/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "UserId",
            url: '/api/office/user/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        }
    ];

</script>
<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>

<script type="text/javascript">

    var effectiveFromTextbox = $("#effective_from_textbox");
    var endsOnTextbox = $("#ends_on_textbox");

    $(document).ready(function () {
        scrudCustomValidator();
    });

    function scrudCustomValidator() {
        var effectiveFrom = parseDate(effectiveFromTextbox.val());
        var endsOn = parseDate(endsOnTextbox.val());

        if (endsOn < effectiveFrom) {
            displayMessage(Resources.Warnings.DateErrorMessage());
            return false;
        };
        return true;
    };

</script>
