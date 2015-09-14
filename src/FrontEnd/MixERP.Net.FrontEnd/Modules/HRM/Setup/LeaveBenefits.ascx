<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LeaveBenefits.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Setup.LeaveBenefits" %>
<script>
    var scrudFactory = new Object();
    
    scrudFactory.title = "Leave Benefits";
    
    scrudFactory.viewPocoName = "LeaveBenefit";
    scrudFactory.formPocoName = "LeaveBenefit";
    scrudFactory.formTableName = "hrm.leave_benefits";

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;
    scrudFactory.excludedColumns = ["audit_user_id", "audit_ts"];

    scrudFactory.live = "LeaveBenefitName";
</script>


<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>