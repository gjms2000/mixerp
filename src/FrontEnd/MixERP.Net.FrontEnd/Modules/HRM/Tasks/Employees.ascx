<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Employees.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Tasks.Employees" %>

<script src="/Scripts/mixerp/utitlities/countries.js"></script>
<script src="/Scripts/underscore/underscore-min.js"></script>

<div id="EmployeeController" class="ui attached segment" style="border: none; max-width: 900px;" data-ng-controller="EmployeeController" data-ng-cloak>
    <div class="ui large purple header">{{getResource('Resources.Titles.Employees')}}</div>
    <div class="ui stackable grid">
        <div class="ten wide column">
            <div class="ui form">
                <div class="fields">
                    <div class="twelve wide field">
                        <div class="ui icon input">
                            <input id="SearchInputText"
                                   placeholder="Search"
                                   data-ng-model="filters.Name" type="text">
                            <i class="search icon"></i>
                        </div>
                    </div>
                    <div class="four wide field">
                        <input class="ui purple button" data-ng-click="search();" value="{{getResource('Resources.Titles.Search')}}" type="button"/>                            
                    </div>
                </div>
            </div>
        </div>
        <div class="six wide right floated right aligned column">
            <div class="ui buttons">
                <a class="ui positive button" target="_parent" href="Employees/Entry.mix">
                    {{getResource('Resources.Titles.AddNew')}}
                </a>
            </div>
        </div>
    </div>
    <div class="ui divider"></div>
    <div class="ui link four doubling stackable cards">
        <div class="card" data-ng-repeat="employee in employees">
            <div class="image">
                <img src="/Modules/BackOffice/Handlers/PartyImageHandler.ashx?Path={{employee.Photo}}&H=300&W=250" 
                    data-value="{{employee.EmployeeId}}" onclick="selectEmployee(this)">
            </div>
            <div class="content">
                <div class="header">{{employee.EmployeeName}}</div>
                <div class="meta">
                    <a>{{employee.EmployeeType}}</a>
                </div>
                <div class="description">
                    <span>
                        {{employee.City}} {{employee.State}}
                    </span>
                    <br />
                    <span>
                        <i class="currency icon"></i>
                        {{employee.CurrencyCode}}
                    </span>
                    <br />

                    <div class="ui icon buttons right floated right aligned">
                        <a data-ng-if="employee.Email.length > 0" class="ui basic green button" href="mailto:{{employee.Email}}">
                            <i class="mail outline icon"></i>
                        </a>
                        <a data-ng-if="employee.Url.length > 0" class="ui basic grey button" href="{{employee.Url}}" target="_blank">
                            <i class="linkify icon"></i>
                        </a>
                        <a data-ng-if="employee.Phone.length > 0" class="ui basic purple button" href="tel:{{employee.Phone}}">
                            <i class="phone icon"></i>
                        </a>
                        <a data-ng-if="employee.Fax.length > 0" class="ui basic grey button" href="tel:{{employee.Fax}}">
                            <i class="fax icon"></i>
                        </a>
                        <a data-ng-if="employee.Cell.length > 0" class="ui basic green button" href="tel:{{employee.Cell}}">
                            <i class="mobile icon"></i>
                        </a>
                    </div>

                    <div class="ui tiny grey header" data-ng-if="employee.CompanyName.length > 0">
                        {{employee.CompanyName}}
                    </div>
                </div>
            </div>
            <div class="extra center content">
                <div class="ui three buttons">
                    <a class="ui basic green button"  target="_parent" href="Employees/Entry.mix?EmployeeId={{employee.EmployeeId}}">
                        {{getResource('Resources.Titles.Edit')}}
                    </a>
                    <a class="ui basic green button"  target="_parent"  href="EmployeeInfo.mix?EmployeeId={{employee.EmployeeId}}">
                        {{getResource('Resources.Titles.View')}}
                    </a>
                    <a class="ui basic red button" data-ng-click="delete(employee);">
                        {{getResource('Resources.Titles.Delete')}}
                    </a>
                </div>
            </div>
            <div class="extra content">
                <span class="right floated">
                    <i class="{{getCountryCode(employee.Country)}} flag"></i>
                    {{employee.Country}}
                </span>
                <span>
                    <i class="user icon"></i>
                    <span>{{employee.EmployeeCode}}</span>

                </span>
            </div>
        </div>
    </div>
    <div class="ui stackable grid">
        <div class="four wide column">
            <div class="ui breadcrumb" style="padding-top: 8px;">
                <a id="CurrentPageAnchor" class="active item">1</a>
                <div class="divider">/ </div>
                <a id="TotalPagesAnchor" class="active item"></a>
            </div>

        </div>
        <div class="twelve wide right aligned right floated column">
            <div class="ui buttons">
                <div class="ui basic purple button" data-ng-click="showFirst()">
                    {{getResource('Resources.Titles.First')}}
                </div>
                <div class="ui basic purple button" data-ng-click="showPrevious()">
                    {{getResource('Resources.Titles.Previous')}}
                </div>
                <div class="ui basic purple button" data-ng-click="showNext()">
                    {{getResource('Resources.Titles.Next')}}
                </div>
                <div class="ui basic purple button" data-ng-click="showLast()">
                    {{getResource('Resources.Titles.Last')}}
                </div>
            </div>
        </div>
    </div>
</div>


<script>

    var url, data;
    var searchInputText = $("#SearchInputText");
    var currentPageAnchor = $("#CurrentPageAnchor");
    var totalPagesAnchor = $("#TotalPagesAnchor");
    var pageQueryStringKey = "Page";

    var count = 0;
    var filter;

    function getCurrentPage() {
        var current = parseInt(getQueryStringByName(pageQueryStringKey) || 0);

        if (!current) {
            current = 1;
        };

        return current;
    };

    function setCurrentPage(page) {
        if (!page) {
            page = getCurrentPage();
        };

        var url = updateQueryString(pageQueryStringKey, page);
        currentPageAnchor.text(page);
        window.history.pushState({ path: url }, '', url);
    };

    function getCount(filter) {
        url = "/api/{v}/hrm/employee/count";
        return getAjaxRequest(url, data);
    };

    function deleteEmployee(employeeId) {
        url = "/api/{v}/hrm/employee/delete";
        data = appendParameter("", "employeeId", employeeId);

        data = getData(data);

        return getAjaxRequest(url, data, "DELETE");
    };


    function getEmployees(filter, page) {
        var filters = [];

        var f = new Object();
        f.ColumnName = "employee_name";
        f.FilterCondition = "8";//Like filter
        f.FilterValue = filter;
        f.FilterAndValue = "";

        filters.push(f);

        var data = JSON.stringify(filters);

        var url = "/api/{v}/hrm/employee-view/get-where/" + page;
        return postAjaxRequest(url, data);
    };

    MixERPApp.controller("EmployeeController", function ($scope, $sce, $window) {
        setCurrentPage();

        $scope.loadCards = function () {
            $("#EmployeeController").addClass("loading");

            filter = searchInputText.val();

            var ajaxGetCount = getCount(filter);

            ajaxGetCount.success(function (msg) {
                count = parseInt(Math.ceil(msg / 25) || 1);
                totalPagesAnchor.text(count);
                var current = getCurrentPage();

                var ajaxGetEmployees = getEmployees(filter, current);

                ajaxGetEmployees.success(function (msg) {
                    $scope.$apply(function () {
                        $scope.employees = msg;
                        $("#EmployeeController").removeClass("loading");
                    });
                });

                ajaxGetEmployees.fail(function (xhr) {
                    $window.logAjaxErrorMessage(xhr);
                    $("#EmployeeController").removeClass("loading");
                });
            });
        };

        $scope.search = function () {
            setCurrentPage("1");
            $scope.loadCards();
        };

        $scope.getCountryCode = function (countryName) {
            return $window._.find(countries, { countryName: countryName }).countryCode.toLowerCase();
        };

        $scope.delete = function (p) {
            if (confirmAction()) {
                var ajaxDeleteEmployee = deleteEmployee(p.EmployeeId);

                ajaxDeleteEmployee.success(function () {
                    $scope.loadCards();
                });

                ajaxDeleteEmployee.fail(function (xhr) {
                    $window.logAjaxErrorMessage(xhr);
                });
            };
        };

        $scope.showNext = function () {
            var nextPage = getCurrentPage() + 1;

            nextPage = Math.min(nextPage, count);

            setCurrentPage(nextPage);
            $scope.loadCards();
        };

        $scope.showPrevious = function () {
            var previousPage = getCurrentPage() - 1;

            previousPage = Math.max(previousPage, 1);

            setCurrentPage(previousPage);
            $scope.loadCards();
        };


        $scope.showFirst = function () {
            setCurrentPage(1);
            $scope.loadCards();
        };

        $scope.showLast = function () {
            setCurrentPage(count);
            $scope.loadCards();
        };

        $scope.loadCards();

        $scope.getResource = function (func) {
            return $window.executeFunctionByName(func, $window);
        };
    });
</script>
<script>
    $(window).on("resize", function() {
        adjustiframe();
    });

    $(document).ajaxStop(function () {
        adjustiframe();
    });


    function selectEmployee(el) {
        if (!isFrame()) {
            return;
        };

        var parent = getParentWindow();

        if (parent) {
            var employeeId = $(el).data("value");
            var associatedControl = parent.$('#' + getQueryStringByName('AssociatedControlId'));
            var callback = getQueryStringByName('CallBackFunctionName');

            if (employeeId > 0) {
                associatedControl.val(employeeId);

                if (callback) {
                    parent[callback]();
                };

                closeWindow();
            };
        };
    };


    function adjustiframe() {
        if (!isFrame()) {
            return;
        };

        var height = $("#EmployeeController").height() + 100;
        var iframe = window.parent.$('iframe');
        iframe.height(height + "px");
    };
</script>