<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EmploymentStatusCodes.ascx.cs" 
    Inherits="MixERP.Net.Core.Modules.HRM.EmploymentStatusCodes"
    IsLandingPage="true" %>

<script>
    var title = "Parties";
    //var description = "Parties collectively refer to your Customers, Suppliers, Dealer, and Agents.";
    var pocoName = "Party";
    var importTemplatePoco = "Party";
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
            property: "ItemGroupId",
            url: '/Modules/Inventory/Services/ItemData.asmx/GetItemGroups',
            data: null,
            valueField: "Value",
            textField: "Text"
        },
        {
            property: "PreferredSupplierId",
            url: '/Modules/Inventory/Services/PartyData.asmx/GetParties',
            data: null,
            valueField: "Value",
            textField: "Text"
        }
    ];
</script>


<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>