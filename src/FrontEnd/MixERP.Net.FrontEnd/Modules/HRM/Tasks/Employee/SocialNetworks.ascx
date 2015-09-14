<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SocialNetworks.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Tasks.Employee.SocialNetworks"
    OverridePath="/Modules/HRM/Tasks/Employees.mix" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = window.Resources.Titles.SocialNetworks();
    scrudFactory.viewPocoName = "EmployeeSocialNetworkDetailScrudView";
    scrudFactory.formPocoName = "EmployeeSocialNetworkDetail";
    scrudFactory.formTableName = "hrm.employee_social_network_details";

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;
    scrudFactory.excludedColumns = ["audit_user_id", "audit_ts"];
    
    scrudFactory.back = {
        Title: "Employee",
        Url: "/Modules/HRM/Tasks/EmployeeInfo.mix?EmployeeId=" + getQueryStringByName("EmployeeId")
    };

    scrudFactory.live = "SocialNetworkId";
    scrudFactory.keys = [
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
