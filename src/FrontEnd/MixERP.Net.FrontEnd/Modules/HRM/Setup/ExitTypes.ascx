<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ExitTypes.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Setup.ExitTypes" %>
<script>
	var scrudFactory = new Object();

    scrudFactory.title = "Exit Types";

    scrudFactory.viewAPI = "/api/hrm/exit-type";
    scrudFactory.viewTableName = "hrm.exit_types";

    scrudFactory.formAPI = "/api/hrm/exit-type";
    scrudFactory.formTableName = "hrm.exit_types";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.live = "ExitTypeName";
</script>


<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>