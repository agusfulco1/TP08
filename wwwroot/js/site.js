﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function MostrarActores(idS)
{
    
    $.ajax(
        {
            type: 'POST',
            dateType: 'JSON',
            url: '/Home/ListarActoresAjax',
            data: {IdSeries : idS},
            success:
                function(response)
                {
                    let body = "";
                    response.forEach(element => {
                    body+= response.nombre;
                    });
                    $("#Texto").html(body);
                }

        }
    );
}
function MostrarTemporada(idS)
{
    $.ajax(
        {
            type: 'POST',
            dateType: 'JSON',
            url: '/Home/ListarTemporadasAjax',
            data: {IdSeries : idS},
            success:
                function(response)
                {
                    let body = "";
                    response.forEach(element => {
                    body+= response.NumeroTemporada;
                    });
                    $("#Texto").html(body);
                }
    
        }
    );
}

function MostrarSinopsis(idS)
{
    $.ajax(
        {
            type: 'POST',
            dateType: 'JSON',
            url: '/Home/ListarSinopsisAjax',
            data: {IdSeries : idS},
            success:
                function(response)
                {
                    let body = "";
                    response.forEach(element => {
                    body+= response.Sinopsis;
                    });
                    $("#Texto").html(body);
                }
    
        }
    );
}