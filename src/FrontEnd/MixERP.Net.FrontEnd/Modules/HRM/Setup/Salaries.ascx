<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Salaries.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Setup.Salaries" %>
<script>
    var title = "Salaries";
    var viewPocoName = "Salary";
    var formPocoName = "Salary";
    var allowDelete = true;
    var allowEdit = true;
    var excludedColumns = ["audit_user_id", "audit_ts"];
</script>


<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>