<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Employees.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Tasks.Entry.Employees"
    OverridePath="/Modules/HRM/Tasks/Employees.mix"
     %>
<script>
    var title = "Employee";
    var viewPocoName = "Employee";
    var formPocoName = "Employee";
    var excludedColumns = ["audit_user_id", "audit_ts"];
    var readonlyColumns = ["EmployeeName"];
    var live = "EmployeeName";
    var layout = [
        ["Photo", ""],
        ["EmployeeId", "EmployeeName", "", ""],
        ["FirstName", "MiddleName", "LastName", "GenderCode", "", "", "", ""]
    ];
    var returnUrl = window.location.href;
</script>

<script>
    var keys = [
        {
            property: "GenderCode",
            url: '/api/{v}/core/gender/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "OfficeId",
            url: '/api/{v}/office/office/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "UserId",
            url: '/api/{v}/office/user/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "EmployeeTypeId",
            url: '/api/{v}/hrm/employee-type/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "CurrentDepartmentId",
            url: '/api/{v}/office/department/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "CurrentRoleId",
            url: '/api/{v}/office/role/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "CurrentEmploymentStatusId",
            url: '/api/{v}/hrm/employment-status/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "CurrentJobTitleId",
            url: '/api/{v}/hrm/job-title/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "CurrentPayGradeId",
            url: '/api/{v}/hrm/pay-grade/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "CurrentShiftId",
            url: '/api/{v}/hrm/shift/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "NationalityCode",
            url: '/api/{v}/core/nationality/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "CountryId",
            url: '/api/{v}/core/country/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "StateId",
            url: '/api/{v}/core/state/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
    ];
</script>

<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>

<script>
    $(document).ajaxStop(function () {
        initialize();
    });

    function initialize() {
        var firstName = $("#first_name");
        var middleName = $("#middle_name");
        var lastName = $("#last_name");
        var employeeName = $("#employee_name");

        function displayEmployeeName() {
            var f = (firstName.val() || "");
            var m = (middleName.val() || "");
            var l = (lastName.val() || "");

            var name = f + " " + m;
            if (l) {
                name = l.trim() + ", " + f + " " + m;
            };


            employeeName.val(name.trim());

            employeeName.trigger("keyup");
        };


        firstName.keyup(function () { displayEmployeeName(); });
        middleName.keyup(function () { displayEmployeeName(); });
        lastName.keyup(function () { displayEmployeeName(); });

    };



</script>