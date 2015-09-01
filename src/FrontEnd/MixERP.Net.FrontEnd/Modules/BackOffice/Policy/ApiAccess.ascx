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
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ApiAccess.ascx.cs" Inherits="MixERP.Net.Core.Modules.BackOffice.Policy.ApiAccess" %>
<asp:PlaceHolder runat="server" ID="ScrudPlaceholder"></asp:PlaceHolder>

<script>
    var pocos;

    $(document).ready(function () {
        loadPocos(addPocoSelect);
    });

    function loadPocos(callback) {
        var ajaxGetPocos = getPocos();

        ajaxGetPocos.success(function(msg) {
            pocos = msg.d;

            if (typeof (callback) === "function") {
                callback();
            };
        });
    };

    function getPocos() {
        var url = "/Services/Modules/PocoService.asmx/GetPocos";

        return getAjax(url);
    };

    function addPocoSelect() {
        var pocoTypeNameTextbox = $("#poco_type_name_textbox");

        pocoTypeNameTextbox.hide();

        var select = "<select id='poco_type_name_select'><select>";

        pocoTypeNameTextbox.parent().prepend(select);

        var pocoTypeNameSelect = $("#poco_type_name_select");

        for (i = 0; i < pocos.length; i++) {
            pocoTypeNameSelect.append("<option>" + pocos[i] + "</option>");
        };


        pocoTypeNameSelect.blur(function () {
            pocoTypeNameTextbox.val($(this).getSelectedText());
        });
    };

    Sys.WebForms.PageRequestManager.getInstance().add_endRequest(function () {
        //Fired on each ASP.net AJAX request.
        addPocoSelect();
    });

</script>