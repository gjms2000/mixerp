<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PayGrades.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Setup.PayGrades" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = "Pay Grades";
    
    scrudFactory.viewAPI = "/api/hrm/pay-grade";
    scrudFactory.viewTableName = "hrm.pay_grades";

    scrudFactory.formAPI = "/api/hrm/pay-grade";
    scrudFactory.formTableName = "hrm.pay_grades";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.layout = [
    	["PayGradeId", ""],
    	["PayGradeCode", "PayGradeName", "", ""],
    	["MinimumSalary", "MaximumSalary", "", ""],
    	["Description", ""]
    ];

    scrudFactory.live = "PayGradeName";
</script>


<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>