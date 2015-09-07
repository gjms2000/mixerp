<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Salaries.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Setup.Salaries" %>
<script>
    var title = "Salaries";
    var viewPocoName = "Salary";
    var formPocoName = "Salary";
    var allowDelete = true;
    var allowEdit = true;
    var excludedColumns = ["audit_user_id", "audit_ts"];
    var keys = [
        {
            property: "EmployeeId",
            url: '/api/hrm/employee/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "SalaryTypeId",
            url: '/api/hrm/salary-type/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "PayGradeId",
            url: '/api/hrm/pay-grade/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "SalaryFrequencyId",
            url: '/api/hrm/salary-frequency/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "CurrencyCode",
            url: '/api/core/currency/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        }
    ];


</script>


<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>
