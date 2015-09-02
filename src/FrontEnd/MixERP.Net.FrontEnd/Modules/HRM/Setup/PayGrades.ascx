<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PayGrades.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Setup.PayGrades" %>
<script>
    var title = "Pay Grades";
    var viewPocoName = "PayGrade";
    var formPocoName = "PayGrade";
    var allowDelete = true;
    var allowEdit = true;
    var excludedColumns = ["audit_user_id", "audit_ts"];

    var live = "PayGradeName";
</script>


<div data-ng-include="'/Views/Modules/ViewFactory.html'"></div>
<div data-ng-include="'/Views/Modules/FormFactory.html'"></div>