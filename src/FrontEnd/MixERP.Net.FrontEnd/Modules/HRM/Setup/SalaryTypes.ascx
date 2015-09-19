<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SalaryTypes.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Setup.SalaryTypes" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = "Salary Types";
    
    scrudFactory.viewAPI = "/api/hrm/salary-type";
    scrudFactory.viewTableName = "hrm.salary_types";

    scrudFactory.formAPI = "/api/hrm/salary-type";
    scrudFactory.formTableName = "hrm.salary_types";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.layout = [
    	["SalaryTypeId", ""],
    	["SalaryTypeCode", "SalaryTypeName", "", ""]
    ];

    scrudFactory.live = "SalaryTypeName";
</script>


<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>