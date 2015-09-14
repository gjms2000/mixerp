<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EmployeeTypes.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Setup.EmployeeTypes" %>

<script>
	var scrudFactory = new Object();
    scrudFactory.title = "Employee Types";

    scrudFactory.viewPocoName = "EmployeeType";
    scrudFactory.formPocoName = "EmployeeType";
    scrudFactory.formTableName = "hrm.employee_types";

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;
    scrudFactory.excludedColumns = ["audit_user_id", "audit_ts"];

    scrudFactory.live = "EmployeeTypeName";
</script>


<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>