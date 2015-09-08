<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Qualifications.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Tasks.Employee.Qualifications"
    OverridePath="/Modules/HRM/Tasks/Employees.mix" %>
<script>
    var title = window.Resources.Titles.Qualifications();
    var viewPocoName = "EmployeeQualificationScrudView";
    var formPocoName = "EmployeeQualification";
    var allowDelete = true;
    var allowEdit = true;
    var excludedColumns = ["audit_user_id", "audit_ts"];
    var back = {
        Title: "Employee",
        Url: "/Modules/HRM/Tasks/EmployeeInfo.mix?EmployeeId=" + getQueryStringByName("EmployeeId")
    };

    var layout = [
        ["EmployeeQualificationId", "EmployeeId", "", ""],
        ["EducationLevelId", "Institution", "", ""],
        ["Majors", "TotalYears", "", ""],
        ["Score", "", "", ""],
        ["StartedOn", "CompletedOn", "", ""],
        ["Details", ""]
    ];

    var live = "Majors";
    var keys = [
        {
            property: "EmployeeId",
            url: '/api/hrm/employee/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "EducationLevelId",
            url: '/api/hrm/education-level/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        }
    ];

</script>


<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>
