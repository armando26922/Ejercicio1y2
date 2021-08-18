function Calcular() {

    dataSend =
    {
        NroDiv: document.getElementById("campo").value 
    }
    $.ajax({
        type: "POST",
        url: '/Home/SimplificarDivision',
        data: dataSend,
        success: function (resultado) {
            alert(resultado);
        }
    });
     






}