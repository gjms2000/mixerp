<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Employees.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Tasks.Employees" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = "Employee";

    scrudFactory.viewAPI = "/api/hrm/employee";
    scrudFactory.viewTableName = "hrm.employees";

    scrudFactory.formAPI = "/api/hrm/employee";
    scrudFactory.formTableName = "hrm.employees";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];
    scrudFactory.readonlyColumns = ["EmployeeName"];

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

<script>
    $(document).on("formready", function() {
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

