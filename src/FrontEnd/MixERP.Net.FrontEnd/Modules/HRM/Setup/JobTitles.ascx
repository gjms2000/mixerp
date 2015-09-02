<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="JobTitles.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Setup.JobTitles" %>
<script>
    var title = "Job Titles";
    var viewPocoName = "JobTitle";
    var formPocoName = "JobTitle";
    var allowDelete = true;
    var allowEdit = true;
    var excludedColumns = ["audit_user_id", "audit_ts"];

    var live = "JobTitleName";
</script>


<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>