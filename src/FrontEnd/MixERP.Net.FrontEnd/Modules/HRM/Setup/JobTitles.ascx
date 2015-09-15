<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="JobTitles.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Setup.JobTitles" %>
<script>
	var scrudFactory = new Object();
    
    scrudFactory.title = "Job Titles";

    scrudFactory.viewPocoName = "JobTitle";
    scrudFactory.formPocoName = "JobTitle";
    scrudFactory.formTableName = "hrm.job_titles";

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;
    scrudFactory.excludedColumns = ["audit_user_id", "audit_ts"];

    scrudFactory.layout = [
    	["JobTitleId", ""],
    	["JobTitleCode", "JobTitleName", "", ""],
    	["Description", ""]
    ];

    scrudFactory.live = "JobTitleName";
</script>


<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>