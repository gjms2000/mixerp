<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EmploymentStatuses.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Setup.EmploymentStatuses" %>

<script>
    var scrudFactory = new Object();
    
    scrudFactory.title = "Employment Statuses";

    scrudFactory.viewAPI = "/api/hrm/employment-status";
    scrudFactory.viewTableName = "hrm.employment_statuses";

    scrudFactory.formAPI = "/api/hrm/employment-status";
    scrudFactory.formTableName = "hrm.employment_statuses";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.live = "EmploymentStatusName";

    scrudFactory.layout = [
        ["EmploymentStatusId", ""],
        ["EmploymentStatusCode", "EmploymentStatusName", "", ""],
        ["IsContract", "DefaultEmploymentStatusCodeId", "", ""],
        ["Description", ""]
    ];

    scrudFactory.keys = [
        {
            property: "DefaultEmploymentStatusCodeId",
            url: '/api/hrm/employment-status-code/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        }
    ];
</script>


<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>
