// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    $('.infoCard').click(function () {
        $('#modalBakeryInfo').modal();
    });
    $('.btn').click(function () {
        $('#newBakeryModal').modal();
    });

    
    $('.btn-close').click(function () {
        $('#modalBakeryInfo').modal();
});
})
