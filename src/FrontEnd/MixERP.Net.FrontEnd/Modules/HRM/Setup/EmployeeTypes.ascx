<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EmployeeTypes.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Setup.EmployeeTypes" %>

<script>
    var title = "Employee Types";
    var viewPocoName = "EmployeeType";
    var formPocoName = "EmployeeType";
    var allowDelete = true;
    var allowEdit = true;
    var excludedColumns = ["audit_user_id", "audit_ts"];

    var live = "EmployeeTypeName";
</script>


<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>