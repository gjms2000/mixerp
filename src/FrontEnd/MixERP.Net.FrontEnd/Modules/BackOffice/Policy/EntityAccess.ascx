<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EntityAccess.ascx.cs" Inherits="MixERP.Net.Core.Modules.BackOffice.Policy.EntityAccess" %>
<script>
    var title = "Entity Access Policy";
    var description = "Create entity access policy for individual users. By default, users have right to access an entity if a menu acesss policy is granted. If a <a href='{0}'>default entity access policy</a> was created to restrict access to a group of users, you can still override that policy and provide access permission to a particular user.";
    description = stringFormat(description, "EntityAccess.mix");
    var viewPocoName = "EntityAccess";
    var formPocoName = "EntityAccess";
    var allowDelete = true;
    var allowEdit = true;
    var excludedColumns = ["audit_user_id", "audit_ts"];
</script>

<script>
    var keys = [
        {
            property: "EntityName",
            url: '/Services/Modules/PocoService.asmx/GetPocos',
            data: null,
            isArray:true,
            valueField: "",
            textField: ""
        },
        {
            property: "AccessTypeId",
            url: '/Modules/BackOffice/Services/Policy/EntityAccess.asmx/GetAccessTypes',
            data: null,
            valueField: "AccessTypeId",
            textField: "AccessTypeName"
        },
        {
            property: "UserId",
            url: '/Modules/BackOffice/Services/Policy/EntityAccess.asmx/GetUsers',
            data: null,
            valueField: "UserId",
            textField: "UserName"
        }
    ];
</script>

<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>
