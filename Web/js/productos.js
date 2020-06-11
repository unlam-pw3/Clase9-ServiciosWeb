$(document).ready(function () {
    var tblProductos = $('#tblProductos');

    $('#btnRefrescar').click(function () {
        $.ajax({
            type: 'GET',
            url: 'https://localhost:44306/api/productos',
            dataType: 'json',
            crossDomain: true,
            success: function (data) {

                tblProductos.empty();
                $.each(data, function (index, val) {
                    tblProductos.append('<tr><td>' + val.Nombre + '</td></tr>');
                });
            }

        });

    });

});  