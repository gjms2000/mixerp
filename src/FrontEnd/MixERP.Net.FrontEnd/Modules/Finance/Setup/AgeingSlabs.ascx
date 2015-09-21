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

<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AgeingSlabs.ascx.cs" Inherits="MixERP.Net.Core.Modules.Finance.Setup.AgeingSlabs" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.AgeingSlabs();

    scrudFactory.viewAPI = "/api/core/ageing-slab-scrud-view";
    scrudFactory.viewTableName = "core.ageing_slab_scrud_view";

    scrudFactory.formAPI = "/api/core/ageing-slab";
    scrudFactory.formTableName = "core.ageing_slabs";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];


    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;


    scrudFactory.live = "AgeingSlabName";
</script>


<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>


<script type="text/javascript">
    function scrudCustomValidator() {
        var fromDaysTextbox = $("#from_days_textbox");
        var toDaysTextbox = $("#to_days_textbox");

        var fromDays = parseInt2(fromDaysTextbox.val());
        var toDays = parseInt2(toDaysTextbox.val());

        if (toDays <= fromDays) {
            displayMessage(Resources.Warnings.CompareDaysErrorMessage());
            return false;
        };
        return true;
    };
</script>