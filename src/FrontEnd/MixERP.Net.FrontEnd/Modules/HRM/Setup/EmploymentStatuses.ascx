<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EmploymentStatuses.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Setup.EmploymentStatuses" %>

<script>
    var title = "Employment Statuses";
    var viewPocoName = "EmploymentStatus";
    var formPocoName = "EmploymentStatus";
    var allowDelete = true;
    var allowEdit = true;
    var excludedColumns = ["audit_user_id", "audit_ts"];

    var live = "EmploymentStatusName";

    var keys = [
        {
            property: "DefaultEmploymentStatusCodeId",
            url: '/Modules/HRM/Services/DisplayFields/EmploymentStatusCode.asmx/GetDisplayField',
            data: null,
            valueField: "Key",
            textField: "Value"
        }
    ];
</script>


<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>
