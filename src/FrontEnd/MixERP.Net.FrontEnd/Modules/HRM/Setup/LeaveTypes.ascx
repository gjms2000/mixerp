<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LeaveTypes.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Setup.LeaveTypes" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = "Leave Types";
    scrudFactory.viewPocoName = "LeaveType";
    scrudFactory.formPocoName = "LeaveType";
    scrudFactory.formTableName = "hrm.leave_types";

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;
    scrudFactory.excludedColumns = ["audit_user_id", "audit_ts"];

    scrudFactory.live = "LeaveTypeName";
</script>


<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>