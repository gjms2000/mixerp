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
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SalesByOffice.ascx.cs" Inherits="MixERP.Net.Core.Modules.Sales.Reports.SalesByOffice"
    %>
<iframe src="/Modules/Sales/Reports/SalesByOfficeFrame.mix" scrolling="no" seamless="seamless"></iframe>

<script type="text/javascript">
    $(document).ready(function () {
        var iframe = $("iframe");

        iframe.css("width", "100%");
        iframe.css("height", getDocHeight() + "px");
        iframe.css("border", "0");
    })
</script>