<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ExitTypes.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Setup.ExitTypes" %>
<script>
	var scrudFactory = new Object();

    scrudFactory.title = "Exit Types";

    scrudFactory.viewPocoName = "ExitType";
    scrudFactory.formPocoName = "ExitType";
    scrudFactory.formTableName = "hrm.exit_types";

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;
    scrudFactory.excludedColumns = ["audit_user_id", "audit_ts"];

    scrudFactory.live = "ExitTypeName";
</script>


<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>