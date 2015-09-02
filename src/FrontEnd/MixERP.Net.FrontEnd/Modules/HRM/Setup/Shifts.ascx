<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Shifts.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Setup.Shifts" %>
<script>
    var title = "Shifts";
    var viewPocoName = "Shift";
    var formPocoName = "Shift";
    var allowDelete = true;
    var allowEdit = true;
    var excludedColumns = ["audit_user_id", "audit_ts"];

    var live = "ShiftName";
</script>


<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>