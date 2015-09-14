<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="OfficeHours.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Setup.OfficeHours" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = "Office Hours";
    
    scrudFactory.viewPocoName = "OfficeHour";
    scrudFactory.formPocoName = "OfficeHour";
    scrudFactory.formTableName = "hrm.office_hours";

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;
    scrudFactory.excludedColumns = ["audit_user_id", "audit_ts"];

    scrudFactory.live = "OfficeHourName";

    scrudFactory.keys = [
        {
            property: "OfficeId",
            url: '/api/office/office/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "ShiftId",
            url: '/api/hrm/shift/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        }
    ];
</script>


<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>