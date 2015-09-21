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

<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CostCenters.ascx.cs" Inherits="MixERP.Net.Core.Modules.Finance.Setup.CostCenters" %>

<script src="/Scripts/underscore/underscore-min.js"></script>
<script>
    var scrudFactory = new Object();
    scrudFactory.title = window.Resources.Titles.CostCenters();

    scrudFactory.viewAPI = "/api/office/cost-center-scrud-view";
    scrudFactory.viewTableName = "office.cost_center_scrud_view";

    scrudFactory.formAPI = "/api/office/cost-center";
    scrudFactory.formTableName = "office.cost_centers";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.live = "CostCenterName";
    scrudFactory.queryStringKey = "AccountId";
</script>

<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>