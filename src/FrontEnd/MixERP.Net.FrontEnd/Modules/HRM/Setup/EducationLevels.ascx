<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EducationLevels.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Setup.EducationLevels" %>

<script>
	var scrudFactory = new Object();

    scrudFactory.title = "Education Levels";

    scrudFactory.viewAPI = "/api/hrm/education-level";
    scrudFactory.viewTableName = "hrm.education_levels";

    scrudFactory.formAPI = "/api/hrm/education-level";
    scrudFactory.formTableName = "hrm.education_levels";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.live = "EducationLevelName";
</script>


<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>
