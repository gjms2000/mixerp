<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SocialNetworks.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Tasks.Employee.SocialNetworks"
    OverridePath="/Modules/HRM/Tasks/Employees.mix" %>
<script>
    var title = window.Resources.Titles.SocialNetworks();
    var viewPocoName = "EmployeeSocialNetworkDetailScrudView";
    var formPocoName = "EmployeeSocialNetworkDetail";
    var allowDelete = true;
    var allowEdit = true;
    var excludedColumns = ["audit_user_id", "audit_ts"];
    var back = {
        Title: "Employee",
        Url: "/Modules/HRM/Tasks/EmployeeInfo.mix?EmployeeId=" + getQueryStringByName("EmployeeId")
    };

    var live = "SocialNetworkId";
    var keys = [
        {
            property: "EmployeeId",
            url: '/api/hrm/employee/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "SocialNetworkName",
            url: '/api/core/social-network/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        }
    ];

</script>


<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>
