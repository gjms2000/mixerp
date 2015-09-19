<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="IdentificationDetails.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Tasks.Employee.IdentificationDetails"
    OverridePath="/Modules/HRM/Tasks/Employees.mix" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = window.Resources.Titles.EmployeeIdentificationDetails();

    scrudFactory.viewAPI = "/api/hrm/employee-identification-detail-scrud-view";
    scrudFactory.viewTableName = "hrm.employee_identification_detail_scrud_view";

    scrudFactory.formAPI = "/api/hrm/employee-identification-detail";
    scrudFactory.formTableName = "hrm.employee_identification_details";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.back = {
        Title: "Employee",
        Url: "/Modules/HRM/Tasks/EmployeeInfo.mix?EmployeeId=" + getQueryStringByName("EmployeeId")
    };
    
    scrudFactory.keys = [
        {
            property: "EmployeeId",
            url: '/api/hrm/employee/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "IdentificationTypeCode",
            url: '/api/core/identification-type/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        }
    ];

</script>


<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>

<script>
    function identificationTypeExpires(filters) {
        var url = "/api/core/identification-type/get-where/1";
        var data = JSON.stringify(filters);
        return window.postAjaxRequest(url, data);
    };

    function checkIfExpires() {
        var value = $("#identification_type_code").getSelectedValue();

        if (!value) {
            return;
        };

        var filters = [];
        filters.push(window.getAjaxColumnFilter("identification_type_code", window.FilterConditions.IsEqualTo, value));

        var ajaxIdentificationTypeExpires = identificationTypeExpires(filters);

        ajaxIdentificationTypeExpires.success(function (msg) {
            var canExpire = msg[0].CanExpire;


            if (!canExpire) {
                $("#expires_on").val("");
            };

            $("#expires_on").prop("disabled", !canExpire);
        });
    };

    $(document).on("formready", function () {
        checkIfExpires();

        $("#identification_type_code").change(function () {
            checkIfExpires();
        });;
    });


    var getParties = function(filters) {
        var url = "/api/core/party-scrud-view/get-where/1";
        var data = JSON.stringify(filters);

        return window.postAjaxRequest(url, data);
    };

    var filters = [];
    filters.push(window.getAjaxColumnFilter("first_name", window.FilterConditions.IsLike, "s"));
    filters.push(window.getAjaxColumnFilter("party_type", window.FilterConditions.IsLike, "Customer"));


    var getPartiesAjax = getParties(filters);

    getPartiesAjax.success(function(msg) {
        console.table(msg);
    });

</script>