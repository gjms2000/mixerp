<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Termination.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Tasks.Termination" %>

<script>
    var scrudFactory = new Object();

    scrudFactory.title = "Terminations";

    scrudFactory.viewAPI = "/api/hrm/termination-scrud-view";
    scrudFactory.viewTableName = "hrm.termination_scrud_view";

    scrudFactory.formAPI = "/api/hrm/termination";
    scrudFactory.formTableName = "hrm.terminations";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.live = "EmployeeId";

    scrudFactory.readonlyColumns = ["EndedOn"];
    scrudFactory.hiddenColumns = ["VerificationStatusId", "VerifiedByUserId", "VerifiedOn", "VerificationReason"];
    scrudFactory.excludedColumns = ["Photo"];

    scrudFactory.keys = [
        {
            property: "EmployeeId",
            url: '/api/hrm/employee-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "ChangeStatusTo",
            url: '/api/hrm/employment-status/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "ForwardTo",
            url: '/api/hrm/employee-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        }
    ];

    scrudFactory.layout = [
        ["TerminationId", ""],
        ["EmployeeId", "NoticeDate", "", ""],
        ["ForwardTo", "ServiceEndDate", "", ""],
        ["ChangeStatusTo", ""],
        ["Reason", ""],
        ["Details", ""]
    ];

    $(document).on("formready", function () {
        $("#verification_status_id").val("0");
    });
</script>


<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>
