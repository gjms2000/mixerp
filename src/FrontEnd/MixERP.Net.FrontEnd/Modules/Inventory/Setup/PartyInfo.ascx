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
along with MixERP.  If not, see <http://www.gnu.org/licenses/>.
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PartyInfo.ascx.cs" 
    Inherits="MixERP.Net.Core.Modules.Inventory.Setup.PartyInfo"
        OverridePath="/Modules/Inventory/Setup/Parties.mix" %>

<script src="/Scripts/mixerp/utitlities/countries.js"></script>
<script src="/Scripts/underscore/underscore-min.js"></script>
<script src="PartyInfo/account-statement/ajax.js"></script>
<script src="PartyInfo/general-info/ajax.js"></script>
<script src="PartyInfo/popular-items/ajax.js"></script>
<script src="PartyInfo/shipping-addresses/ajax.js"></script>
<script src="PartyInfo/trend/ajax.js"></script>
<script src="PartyInfo/account-statement/controller.js"></script>
<script src="PartyInfo/general-info/controller.js"></script>
<script src="PartyInfo/popular-items/chart.js"></script>
<script src="PartyInfo/shipping-addresses/controller.js"></script>
<script src="PartyInfo/trend/chart.js"></script>

<asp:Panel runat="server" ID="InfoPanel" data-ng-controller="GeneralInfoController">

    <div class="ui purple header">
        <img src="/Modules/BackOffice/Handlers/PartyImageHandler.ashx?Path={{partyView.Photo}}&H=200&W=200" class="ui circular image" alt="{{partyView.PartyName}}" />
        <div class="content">
            {{partyView.PartyName}}
            <div class="sub header">
                {{partyView.PartyCode}}
            </div>
        </div>
    </div>
    <div data-ng-include src="'/Modules/Inventory/Setup/PartyInfo/buttons.html'"></div>

    <div class="ui attached tabular menu">
        <a class="active item" data-tab="general-info-tab">General Information</a>
        <a class="item" data-tab="trend-tab" onclick="showTrend();">Trend</a>
        <a class="item" data-tab="popular-items-tab" onclick="showPopularItems();">Popular Items</a>
        <a class="item" data-tab="account-statement-tab" onclick="">Account Statement</a>
        <a class="item" data-tab="shipping-addresses-tab">{{getResource('Resources.Titles.ShippingAddresses')}}
        </a>
    </div>

    <div class="ui active tab attached segment" data-tab="general-info-tab">
        <div data-ng-include src="'/Modules/Inventory/Setup/PartyInfo/general-info/index.html'"></div>
    </div>

    <div class="ui tab attached segment" data-tab="popular-items-tab">
        <div data-ng-include src="'/Modules/Inventory/Setup/PartyInfo/popular-items/index.html'"></div>
    </div>

    <div class="ui tab attached segment" data-tab="account-statement-tab" data-ng-controller="AccountStatementController">
        <div data-ng-include src="'/Modules/Inventory/Setup/PartyInfo/account-statement/index.html'"></div>
    </div>
    <div class="ui tab attached segment" data-tab="shipping-addresses-tab" data-ng-controller="ShippingAddressController">
        <div data-ng-include src="'/Modules/Inventory/Setup/PartyInfo/shipping-addresses/index.html'"></div>
    </div>
    <div class="ui tab attached segment" data-tab="trend-tab">
        <div data-ng-include src="'/Modules/Inventory/Setup/PartyInfo/trend/index.html'"></div>
    </div>
</asp:Panel>

<script type="text/javascript">
    $(document).ready(function () {
        $(".tab.segment").css("min-height", $(window).height() - 250 + "px");
    });
</script>
