<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Shifts.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Setup.Shifts" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = "Shifts";
    scrudFactory.viewPocoName = "Shift";
    scrudFactory.formPocoName = "Shift";
    scrudFactory.formTableName = "hrm.shifts";

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;
    scrudFactory.excludedColumns = ["audit_user_id", "audit_ts"];

    scrudFactory.layout = [
    	["ShiftId", ""],
    	["ShiftCode", "ShiftName", "", ""],
    	["BeginsFrom", "EndsOn", "", ""],
    	["Description", ""]
    ];

    scrudFactory.live = "ShiftName";
</script>


<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>