<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DefaultEntityAccess.ascx.cs" Inherits="MixERP.Net.Core.Modules.BackOffice.Policy.DefaultEntityAccess" %>
<script src="/Scripts/underscore/underscore-min.js"></script>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = "Default Entity Access Policy";
    scrudFactory.description = "Create default entity access policy based on user roles. By default, users have right to access an entity if a menu acesss policy is granted. A negative policy defined here is applicable for all users of the selected role. The explicit <a href='{0}'>entity access policy</a> takes precedence over this policy.";
    scrudFactory.description = stringFormat(scrudFactory.description, "EntityAccess.mix");

    scrudFactory.viewPocoName = "DefaultEntityAccessScrudView";
    scrudFactory.formPocoName = "DefaultEntityAccess";
    scrudFactory.formTableName = "policy.default_entity_access";

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;
    scrudFactory.excludedColumns = ["audit_user_id", "audit_ts"];

    scrudFactory.keys = [
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