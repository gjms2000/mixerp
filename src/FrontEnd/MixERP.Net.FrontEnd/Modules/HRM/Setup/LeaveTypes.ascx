<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LeaveTypes.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Setup.LeaveTypes" %>
<script>
    var title = "Leave Types";
    var viewPocoName = "LeaveType";
    var formPocoName = "LeaveType";
    var allowDelete = true;
    var allowEdit = true;
    var excludedColumns = ["audit_user_id", "audit_ts"];

    var live = "LeaveTypeName";
</script>


<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>