<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Experiences.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Tasks.Employee.Experiences"
    OverridePath="/Modules/HRM/Tasks/Employees.mix"%>
<script>
    var title = window.Resources.Titles.Experiences();
    var viewPocoName = "EmployeeExperienceScrudView";
    var formPocoName = "EmployeeExperience";
    var allowDelete = true;
    var allowEdit = true;
    var excludedColumns = ["audit_user_id", "audit_ts"];
    var back = {
        Title: "Employee",
        Url: "/Modules/HRM/Tasks/EmployeeInfo.mix?EmployeeId=" + getQueryStringByName("EmployeeId")
    };

    var layout = [
        ["EmployeeExperienceId", "EmployeeId", "", ""],
        ["OrganizationName", "Title", "", ""],
        ["StartedOn", "EndedOn", "", ""],
        ["Details", ""]
    ];

    var live = "Title";
    var keys = [
        {
            property: "EmployeeId",
            url: '/api/hrm/employee/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        }
    ];

</script>


<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>
