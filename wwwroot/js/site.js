// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function MostrarActores(idS,nombreSerie)
{
    
    $.ajax(
        {
            type: 'POST',
            dateType: 'JSON',
            url: '/Home/ListarActoresAJAX',
            data: {IdS: idS},
            success:
                function(response)
                {
                    let body = "";
                    response.forEach(element => {
                    body+= element.nombre + "<br>";
                    });
                    $("#Texto").html(body);
                    $("#Titulo").html("Actores de la serie " + nombreSerie)
                }

        }
    );
}
function MostrarTemporada(idS,nombreSerie)
{
    $.ajax(
        {
            type: 'POST',
            dateType: 'JSON',
            url: '/Home/ListarTemporadasAJAX',
            data: {IdS: idS},
            success:
                function(responses)
                {
                    let body = "";
                    responses.forEach(element => {
                    body+= element.tituloTemporada + "<br>";
                    });
                    $("#Texto").html(body);
                    $("#Titulo").html("Temporadas de la serie " + nombreSerie)
                }
    
        }
    );
}

function MostrarSinopsis(idS,nombreSerie)
{
    $.ajax(
        {
            type: 'POST',
            dateType: 'JSON',
            url: '/Home/ListarSinopsisAJAX',
            data: {IdS : idS},
            success:
                function(Response)
                {
                    $("#Texto").html(Response.sinopsis);
                    $("#Titulo").html("Info de la serie " + nombreSerie);
                    $("#fotoSerie").attr("src", Response.imagenSerie);
                }
    
        }
    );
}