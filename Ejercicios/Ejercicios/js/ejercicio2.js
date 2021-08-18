function Calcular() {

    dataSend =
    {
        NombreCompleto: document.getElementById("campo").value
    }
    $.ajax({
        type: "POST",
        url: '/Home/ValidarNombre',
        data: dataSend,
        success: function (resultado) {
            alert(resultado);
        }
    });







}