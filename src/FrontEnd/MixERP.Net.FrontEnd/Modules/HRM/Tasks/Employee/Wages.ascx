<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Wages.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Tasks.Employee.Wages"
        OverridePath="/Modules/HRM/Tasks/Employees.mix"%>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = "Setup Wages";

    scrudFactory.viewAPI = "/api/hrm/employee-wage-scrud-view";
    scrudFactory.viewTableName = "hrm.employee_wage_scrud_view";

    scrudFactory.formAPI = "/api/hrm/employee-wage";
    scrudFactory.formTableName = "hrm.employee_wages";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;
    
    scrudFactory.back = {
        Title: "Employee",
        Url: "/Modules/HRM/Tasks/EmployeeInfo.mix?EmployeeId=" + getQueryStringByName("EmployeeId")
    };

    scrudFactory.live = "SocialNetworkId";
    scrudFactory.keys = [
        {
            property: "EmployeeId",
            url: '/api/hrm/employee-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "WagesSetupId",
            url: '/api/hrm/wages-setup/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "CurrencyCode",
            url: '/api/core/currency/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
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
        
        $("#wages_setup_id").change(function(){
            var wagesSetupId = $(this).val();

            var getWagesSetupAajx = getWagesSetup(wagesSetupId);

            getWagesSetupAajx.success(function(response){
                $("#currency_code").dropdown("set selected", response.CurrencyCode);
                $("#max_week_hours").val(response.MaxWeekHours);
                $("#hourly_rate").val(response.HourlyRate);
                $("#overtime_applicable").dropdown("set selected", response.OvertimeApplicable ? "yes": "no");
                $("#valid_till").val(response.ValidTill);
                $("#overtime_applicable").trigger("change");
            });
        });

        function getWagesSetup(wagesSetupId){
            var url = "/api/hrm/wages-setup/" + wagesSetupId;
            return getAjaxRequest(url);
        };

        $("#overtime_applicable").trigger("change");



    });
</script>