<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Qualifications.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Tasks.Employee.Qualifications"
    OverridePath="/Modules/HRM/Tasks/Employees.mix" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = window.Resources.Titles.Qualifications();
    scrudFactory.viewPocoName = "EmployeeQualificationScrudView";
    scrudFactory.formPocoName = "EmployeeQualification";
    scrudFactory.formTableName = "hrm.employee_qualifications";

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;
    scrudFactory.excludedColumns = ["audit_user_id", "audit_ts"];
    
    scrudFactory.back = {
        Title: "Employee",
        Url: "/Modules/HRM/Tasks/EmployeeInfo.mix?EmployeeId=" + getQueryStringByName("EmployeeId")
    };

    scrudFactory.layout = [
        ["EmployeeQualificationId", "EmployeeId", "", ""],
        ["EducationLevelId", "Institution", "", ""],
        ["Majors", "TotalYears", "", ""],
        ["Score", "", "", ""],
        ["StartedOn", "CompletedOn", "", ""],
        ["Details", ""]
    ];

    scrudFactory.live = "Majors";
    scrudFactory.keys = [
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
