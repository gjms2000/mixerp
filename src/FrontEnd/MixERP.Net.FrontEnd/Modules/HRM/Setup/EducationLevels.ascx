<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EducationLevels.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Setup.EducationLevels" %>

<script>
	var scrudFactory = new Object();

    scrudFactory.title = "Education Levels";
    scrudFactory.viewPocoName = "EducationLevel";
    scrudFactory.formPocoName = "EducationLevel";
    scrudFactory.formTableName = "hrm.education_levels";

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;
    scrudFactory.excludedColumns = ["audit_user_id", "audit_ts"];

    scrudFactory.live = "EducationLevelName";
</script>


<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>
