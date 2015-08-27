<%--
Copyright (C) MixERP Inc. (http://mixof.org).

This file is part of MixERP.

MixERP is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, version 2 of the License.


MixERP is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with MixERP.  If not, see <http://www.gnu.org/licenses />.
--%>

<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Index.ascx.cs" Inherits="MixERP.Net.Core.Modules.BackOffice.Index" %>

<script>
    var title = "Chart of Accounts";
    var description = "Parties collectively refer to your Customers, Suppliers, Dealer, and Agents.";
    var pocoName = "Item";
    excludedColumnIndices = [];//To exclude by column name
</script>

<script>
    var live = "AccountName";

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

<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>
<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>

<script>
    function changeTab(el) {
        el = $(el);
        var tab = el.attr("data-tab");

        $.tab('change tab', tab);

        el.parent().find(".active.item").removeClass("active");
        el.addClass("active");
    };
</script>