<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EmploymentStatuses.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Setup.EmploymentStatuses" %>
<script>
    var title = "Employment Status Codes";
    var description = "Employement status codes are useful to define various employment statuses later.";
    var viewPocoName = "EmploymentStatusCode";
    var formPocoName = "EmploymentStatusCode";
    var allowDelete = false;
    var allowEdit = true;
    var excludedColumns = ["audit_user_id", "audit_ts"];
</script>

<script>
    var live = "ItemName";

    var layout =
    [
        ["ItemId", "", "", ""],
        ["ItemCode",  "ItemName", "", ""],
        ["Photo", ""],
        ["ItemGroupId", "ItemTypeId", "", ""],
        ["BrandId", "PreferredSupplierId", "", ""],
        ["LeadTimeInDays", "WeightInGrams", "WidthInCentimeters", "HeightInCentimeters", "", "", "", ""]
    ];


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