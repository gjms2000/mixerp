<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SalaryTypes.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Setup.SalaryTypes" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = "Salary Types";
    
    scrudFactory.viewPocoName = "SalaryType";
    scrudFactory.formPocoName = "SalaryType";
    scrudFactory.formTableName = "hrm.salary_types";

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;
    scrudFactory.excludedColumns = ["audit_user_id", "audit_ts"];

    scrudFactory.layout = [
    	["SalaryTypeId", ""],
    	["SalaryTypeCode", "SalaryTypeName", "", ""]
    ];

    scrudFactory.live = "SalaryTypeName";
</script>


<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>