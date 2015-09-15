<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Termination.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Tasks.Termination" %>
<script>
    var scrudFactory = new Object();
    
    scrudFactory.title = "Terminations";
    scrudFactory.viewPocoName = "TerminationScrudView";
    scrudFactory.formPocoName = "Termination";
    scrudFactory.formTableName = "hrm.terminations";

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;
    scrudFactory.excludedColumns = ["audit_user_id", "audit_ts", "entered_by"];
    scrudFactory.readonlyColumns = ["EnteredBy"];

    scrudFactory.live = "EmployeeId";

    scrudFactory.layout = [
        ["TerminationId", "EnteredBy", "", ""],
        ["EmployeeId", "Reason", "", ""],
        ["NoticeDate", "EffectiveTerminationDate", "", ""],
        ["ForwardTo", "", "", ""],
        ["Details", ""]
    ];

    scrudFactory.keys = [
        {
            property: "EmployeeId",
            url: '/api/hrm/employee/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "ForwardTo",
            url: '/api/hrm/employee/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        }
    ];
</script>


<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>

<script>
    $(document).on("formready", function() {
        $("#entered_by").val(window.userId);
    });
</script>