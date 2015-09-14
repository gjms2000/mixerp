<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Experiences.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Tasks.Employee.Experiences"
    OverridePath="/Modules/HRM/Tasks/Employees.mix"%>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = window.Resources.Titles.Experiences();
    scrudFactory.viewPocoName = "EmployeeExperienceScrudView";
    scrudFactory.formPocoName = "EmployeeExperience";
    scrudFactory.formTableName = "hrm.employee_experiences";

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;
    scrudFactory.excludedColumns = ["audit_user_id", "audit_ts"];
    scrudFactory.back = {
        Title: "Employee",
        Url: "/Modules/HRM/Tasks/EmployeeInfo.mix?EmployeeId=" + getQueryStringByName("EmployeeId")
    };

    scrudFactory.layout = [
        ["EmployeeExperienceId", "EmployeeId", "", ""],
        ["OrganizationName", "Title", "", ""],
        ["StartedOn", "EndedOn", "", ""],
        ["Details", ""]
    ];

    scrudFactory.live = "Title";
    scrudFactory.keys = [
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
