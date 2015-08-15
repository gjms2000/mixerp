function loadDatepicker() {
    $(".date").datepicker(
    {
        dateFormat: datepickerFormat,
        showWeek: datepickerShowWeekNumber,
        firstDay: datepickerWeekStartDay,
        constrainInput: false,
        numberOfMonths: eval(datepickerNumberOfMonths)
    },
    $.datepicker.regional[language]);
};