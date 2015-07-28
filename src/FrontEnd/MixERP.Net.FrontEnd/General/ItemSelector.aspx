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

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ItemSelector.aspx.cs" Inherits="MixERP.Net.FrontEnd.General.ItemSelector" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Scrud Item Selector</title>

    <script src="/Scripts/jquery-1.9.1.js"></script>
    <link href='/Scripts/semantic-ui/semantic.min.css' rel='stylesheet' type='text/css' />

    <style type="text/css">
        html, body, form {
            height: 100%;
            background-color: white !important;
            font-family: "Titillium Web", "Open Sans","Segoe UI", Helvetica,Arial,sans-serif !important;
            font-size:12px;
        }

        form {
            padding: 12px;
        }

        .grid td, .grid th {
            white-space: nowrap;
        }

        .filter {
            width: 172px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager runat="server" ID="ScriptManager1" />
        <asp:PlaceHolder runat="server" ID="SelectorPlaceholder"></asp:PlaceHolder>
    </form>
</body>
</html>
