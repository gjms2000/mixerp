<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EmploymentStatusCodes.ascx.cs" 
    Inherits="MixERP.Net.Core.Modules.HRM.EmploymentStatusCodes"
    IsLandingPage="true" %>

<script>
    var title = "Employment Status Codes";
    //var description = "Employement status codes are useful to define various employment status later.";
    var viewPocoName = "EmploymentStatusCode";
    var formPocoName = "EmploymentStatusCode";

    excludedColumnIndices = [];//To exclude by column name
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