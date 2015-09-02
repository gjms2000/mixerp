<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EducationLevels.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Setup.EducationLevels" %>

<script>
    var title = "Education Levels";
    var viewPocoName = "EducationLevel";
    var formPocoName = "EducationLevel";
    var allowDelete = true;
    var allowEdit = true;
    var excludedColumns = ["audit_user_id", "audit_ts"];

    var live = "EducationLevelName";
</script>


<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>
