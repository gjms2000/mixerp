<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LeaveBenefits.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Setup.LeaveBenefits" %>
<script>
    var title = "Leave Benefits";
    var viewPocoName = "LeaveBenefit";
    var formPocoName = "LeaveBenefit";
    var allowDelete = true;
    var allowEdit = true;
    var excludedColumns = ["audit_user_id", "audit_ts"];

    var live = "LeaveBenefitName";
</script>


<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>