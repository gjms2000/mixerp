<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DefaultEntityAccess.ascx.cs" Inherits="MixERP.Net.Core.Modules.BackOffice.Policy.DefaultEntityAccess" %>
<script src="/Scripts/underscore/underscore-min.js"></script>
<script>
    var title = "Default Entity Access Policy";
    var description = "Create default entity access policy based on user roles. By default, users have right to access an entity if a menu acesss policy is granted. A negative policy defined here is applicable for all users of the selected role. The explicit <a href='{0}'>entity access policy</a> takes precedence over this policy.";
    description = stringFormat(description, "EntityAccess.mix");
    var viewPocoName = "DefaultEntityAccessScrudView";
    var formPocoName = "DefaultEntityAccess";
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
            property: "RoleId",
            url: '/Modules/BackOffice/Services/Policy/EntityAccess.asmx/GetRoles',
            data: null,
            valueField: "RoleId",
            textField: "RoleName"
        }
    ];
</script>

<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>