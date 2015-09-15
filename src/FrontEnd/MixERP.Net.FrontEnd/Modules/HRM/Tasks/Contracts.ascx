<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Contracts.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Tasks.Contracts" %>
<script>
    var scrudFactory = new Object();
    
    scrudFactory.title = "Contracts";
    scrudFactory.viewPocoName = "ContractScrudView";
    scrudFactory.formPocoName = "Contract";
    scrudFactory.formTableName = "hrm.constracts";

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;
    scrudFactory.excludedColumns = ["audit_user_id", "audit_ts"];

    scrudFactory.live = "EmployeeId";

    scrudFactory.layout = [
        ["ContractId", ""],
        ["EmployeeId", "OfficeId", "", ""],
        ["DepartmentId", "RoleId", "", ""],
        ["EmploymentStatusCodeId", "LeaveBenefitId", "", ""],
        ["BeganOn", "EndedOn", "", ""]
    ];

    scrudFactory.readonlyColumns = ["EndedOn"];

    scrudFactory.keys = [
        {
            property: "EmployeeId",
            url: '/api/hrm/employee/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "OfficeId",
            url: '/api/office/office/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "DepartmentId",
            url: '/api/office/department/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "RoleId",
            url: '/api/office/role/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "LeaveBenefitId",
            url: '/api/hrm/leave-benefit/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "EmploymentStatusCodeId",
            url: '/api/hrm/employment-status-code/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        }
    ];
</script>


<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>
