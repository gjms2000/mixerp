var appendParameter = function (data, parameter, value) {
    if (!isNullOrWhiteSpace(data)) {
        data += ",";
    };

    if (value === undefined) {
        value = "";
    };

    data += JSON.stringify(parameter) + ':' + JSON.stringify(value);

    return data;
};

var getData = function (data) {
    if (data) {
        return "{" + data + "}";
    };

    return null;
};

jQuery.fn.bindAjaxData = function (ajaxData, skipSelect, selectedValue, dataValueField, dataTextField, isArray) {
    "use strict";
    var selected;
    var targetControl = $(this);
    targetControl.empty();


    if (ajaxData.length === 0) {
        appendItem(targetControl, "", Resources.Titles.None());
        return;
    };

    if (!skipSelect) {
        appendItem(targetControl, "", Resources.Titles.Select());
    }
   
    if (!dataValueField) {
        dataValueField = "Value";
    };

    if (!dataTextField) {
        dataTextField = "Text";
    };

    $.each(ajaxData, function () {
        var text;
        var value;
        selected = false;

        if (typeof(isArray) === "undefined") {
            isArray = false;
        };

        if (isArray) {
            text = this;
            value = this;
        };
    
        if(!isArray){
            text = this[dataTextField].toString();
            value = this[dataValueField].toString();
        };

        if (selectedValue) {
            if (value === selectedValue.toString()) {
                selected = true;
            };
        };
        appendItem(targetControl, value, text, selected);
    });
};

var appendItem = function (dropDownList, value, text, selected) {
    var option = $("<option></option>");
    option.val(value).html(text).trigger('change');

    if (selected) {
        option.attr("selected", true);
    };

    dropDownList.append(option);
};

var getAjax = function (url, data) {
    var ajax;

    if (data) {
        ajax = $.ajax({
            type: "POST",
            url: url,
            data: data,
            contentType: "application/json; charset=utf-8",
            dataType: "json"
        });
    } else {
        ajax = $.ajax({
            type: "POST",
            url: url,
            data: "{}",
            contentType: "application/json; charset=utf-8",
            dataType: "json"
        });
    };

    ajax.fail(function(xhr) {
        logAjaxErrorMessage(xhr);
    });

    return ajax;
};

var ajaxUpdateVal = function (url, data, targetControls) {
    var ajax;

    if (data) {
        ajax = getAjax(url, data);
    } else {
        ajax = getAjax(url);
    };

    ajax.success(function (msg) {

        targetControls.each(function () {
            $(this).val(msg.d).trigger('change');
        });

        if (typeof ajaxUpdateValCallback == "function") {
            ajaxUpdateValCallback(targetControls);
        };
    });

    ajax.error(function (xhr) {
        logAjaxErrorMessage(xhr);
    });
};

var ajaxDataBind = function (url, targetControl, data, selectedValue, associatedControl, callback, dataValueField, dataTextField, isArray) {
   
    if (!targetControl) {
        return;
    };

    if (targetControl.length === 0) {
        return;
    };

    var ajax;

    if (data) {
        ajax = new getAjax(url, data);
    } else {
        ajax = new getAjax(url);
    };

    ajax.success(function (msg) {
        if (targetControl.length === 1) {
            targetControl.bindAjaxData(msg.d, false, selectedValue, dataValueField, dataTextField, isArray);
        };

        if (targetControl.length > 1) {
            targetControl.each(function () {
                $(this).bindAjaxData(msg.d, false, selectedValue, dataValueField, dataTextField, isArray);
            });
        };

        if (associatedControl && associatedControl.val) {
            associatedControl.val(selectedValue).trigger('change');
        };

        if (typeof ajaxDataBindCallBack === "function") {
            ajaxDataBindCallBack(targetControl);
        };

        if (typeof callback === "function") {
            callback();
        };
    });

    ajax.error(function (xhr) {
        if (typeof callback === "function") {
            callback();
        };

        var err = $.parseJSON(xhr.responseText);
        appendItem(targetControl, 0, err.Message);
    });
};

var getAjaxErrorMessage = function (xhr) {
    if (xhr) {
        var err;

        try {
            err = JSON.parse(xhr.responseText).Message;
        } catch (e) {
            err = xhr.responseText.Message;
        }

        if (err) {
            return err;
        };

        return xhr.responseText;
    }

    return "";
};