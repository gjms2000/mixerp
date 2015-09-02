<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HolidaySetup.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Setup.HolidaySetup" %>
<script>
    var title = "Holiday Setup";
    var viewPocoName = "Holiday";
    var formPocoName = "Holiday";
    var allowDelete = true;
    var allowEdit = true;
    var excludedColumns = ["audit_user_id", "audit_ts"];

    var live = "Comment";
</script>


<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>