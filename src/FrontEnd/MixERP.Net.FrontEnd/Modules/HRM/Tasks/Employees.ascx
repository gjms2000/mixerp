<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Employees.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Tasks.Employees" %>
<script>
    var title = "Employees";
    var viewPocoName = "Employee";
    var formPocoName = "Employee";
    var allowDelete = true;
    var allowEdit = true;
    var excludedColumns = ["audit_user_id", "audit_ts"];

    var live = "EmployeeName";
</script>


<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>
