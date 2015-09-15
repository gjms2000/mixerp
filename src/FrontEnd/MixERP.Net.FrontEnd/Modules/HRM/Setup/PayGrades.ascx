<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PayGrades.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Setup.PayGrades" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = "Pay Grades";
    
    scrudFactory.viewPocoName = "PayGrade";
    scrudFactory.formPocoName = "PayGrade";
    scrudFactory.formTableName = "hrm.pay_grades";

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;
    scrudFactory.excludedColumns = ["audit_user_id", "audit_ts"];

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