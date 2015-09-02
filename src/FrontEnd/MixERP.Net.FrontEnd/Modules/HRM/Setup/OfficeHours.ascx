<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="OfficeHours.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Setup.OfficeHours" %>
<script>
    var title = "Office Hours";
    var viewPocoName = "OfficeHour";
    var formPocoName = "OfficeHour";
    var allowDelete = true;
    var allowEdit = true;
    var excludedColumns = ["audit_user_id", "audit_ts"];

    var live = "OfficeHourName";
</script>


<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>