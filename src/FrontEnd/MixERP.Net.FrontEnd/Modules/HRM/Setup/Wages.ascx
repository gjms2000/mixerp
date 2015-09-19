<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Wages.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Setup.Wages" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = "Wages Setups";
    
    scrudFactory.viewAPI = "/api/hrm/wages-setup";
    scrudFactory.viewTableName = "hrm.wages_setup";

    scrudFactory.formAPI = "/api/hrm/wages-setup";
    scrudFactory.formTableName = "hrm.wages_setup";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.live = "WagesSetupName";

    scrudFactory.keys = [
        {
            property: "CurrencyCode",
            url: '/api/core/currency/display-fields',
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
        $("#overtime_applicable").change(function () {
            var applicable = $(this).val() === "yes";
            var targetEl = $("#overtime_hourly_rate");

            targetEl.prop("disabled", !applicable);

            if (!applicable) {
                targetEl.val("0");
            };
        });
    });
</script>