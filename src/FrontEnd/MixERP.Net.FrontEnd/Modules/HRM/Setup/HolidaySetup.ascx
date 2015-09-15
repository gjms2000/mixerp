<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HolidaySetup.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Setup.HolidaySetup" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = "Holiday Setup";

    scrudFactory.viewPocoName = "Holiday";
    scrudFactory.formPocoName = "Holiday";
    scrudFactory.formTableName = "hrm.holidays";

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;
    scrudFactory.excludedColumns = ["audit_user_id", "audit_ts"];

    scrudFactory.live = "HolidayName";

    scrudFactory.layout = [
        ["HolidayId", ""],
        ["OfficeId", "HolidayName", "", ""],
        ["OccursOn", "EndsOn", "", ""],
        ["Comment", ""]
    ];

    scrudFactory.keys = [
        {
            property: "OfficeId",
            url: '/api/office/office/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        }
    ];
</script>


<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>