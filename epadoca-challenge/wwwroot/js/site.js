// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    $('.infoCard').click(function () {
        var bakeryId = $(this).attr('bakery-id');

        $.ajax({
            type: 'GET',
            url: '/Bakery/ListAllBakeries/' + bakeryId,
            success: function (result) {
                $("#listBakery").html(result);
                $('#modalBakeryInfo').modal();
            }
        });
    });

    
    $('.btn-close').click(function () {
        $('#modalBakeryInfo').modal();
});
})
