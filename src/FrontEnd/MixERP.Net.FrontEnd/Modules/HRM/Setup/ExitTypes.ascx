<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ExitTypes.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Setup.ExitTypes" %>
<script>
    var title = "Exit Types";
    var viewPocoName = "ExitType";
    var formPocoName = "ExitType";
    var allowDelete = true;
    var allowEdit = true;
    var excludedColumns = ["audit_user_id", "audit_ts"];

    var live = "ExitTypeName";
</script>


<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>