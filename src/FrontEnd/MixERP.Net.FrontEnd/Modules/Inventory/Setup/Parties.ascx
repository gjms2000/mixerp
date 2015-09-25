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
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PartiesPopup.ascx.designer.cs"
    Inherits="MixERP.Net.Core.Modules.Inventory.Setup.PartiesPopup" %>

<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.Parties();

    scrudFactory.viewAPI = "/api/core/party-scrud-view";
    scrudFactory.viewTableName = "core.party_scrud_view";

    scrudFactory.formAPI = "/api/core/party";
    scrudFactory.formTableName = "core.parties";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];
    scrudFactory.readonlyColumns = ["PartyName"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;
    scrudFactory.viewUrl = "EmployeeInfo.mix?EmployeeId={Key}";

    scrudFactory.live = "EmployeeName";
    scrudFactory.layout = [
        ["Photo", ""],
        ["EmployeeId", "EmployeeName", "", ""],
        ["FirstName", "MiddleName", "LastName", "GenderCode", "", "", "", ""]
    ];

    scrudFactory.returnUrl = "../Employees.mix";
    scrudFactory.queryStringKey = "EmployeeId";
    scrudFactory.keys = [
        {
            property: "GenderCode",
            url: '/api/core/gender/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
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
        },
        {
            property: "EmployeeTypeId",
            url: '/api/hrm/employee-type/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "CurrentDepartmentId",
            url: '/api/office/department/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "CurrentRoleId",
            url: '/api/office/role/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "CurrentEmploymentStatusId",
            url: '/api/hrm/employment-status/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "CurrentJobTitleId",
            url: '/api/hrm/job-title/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "CurrentPayGradeId",
            url: '/api/hrm/pay-grade/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "CurrentShiftId",
            url: '/api/hrm/shift/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "NationalityCode",
            url: '/api/core/nationality/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "CountryId",
            url: '/api/core/country/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "StateId",
            url: '/api/core/state/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        }
    ];
</script>

<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>
