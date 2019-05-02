// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $("#cardNumber").inputmask("mask", { "mask": "9999 9999 9999 9999" });
});

$(document).ready(function () {
    var text_max = 16;
    $('#cardNumber').html(text_max + ' characters remaining');

    $('#cardNumber').keyup(function () {
        var text_length = $('#cardNumber').val().length;
        var text_remaining = text_max - text_length;

        $('#cardNumber').html(text_remaining + ' characters remaining');
    });
});

