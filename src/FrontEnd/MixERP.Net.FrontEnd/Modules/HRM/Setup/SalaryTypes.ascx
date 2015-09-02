<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SalaryTypes.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Setup.SalaryTypes" %>
<script>
    var title = "Salary Types";
    var viewPocoName = "SalaryType";
    var formPocoName = "SalaryType";
    var allowDelete = true;
    var allowEdit = true;
    var excludedColumns = ["audit_user_id", "audit_ts"];

    var live = "SalaryTypeName";
</script>


<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>