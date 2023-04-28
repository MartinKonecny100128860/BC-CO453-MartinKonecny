$(document).ready(function () {
    $(".floatNumberField").change(function () {
        $(this).val(parseFloat($(this).val()).toFixed(2));
    });
});