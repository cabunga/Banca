function LoguearUsuario() {
    $.ajax({
        url: urlLoginUsuario,
        type: 'POST',
        data: { nombre: $("#idUsuario").val(), Password: $("#idPassword").val() },
        success: function (resultado) {
            if (resultado === "Exitoso") {
                //alert("Bienvenido");
                location.href = "http://localhost/Banca/Transferencias/index";
            } else {
                alert("Datos incorrectos,el usuario no existe");
            }
            
        },
        error: function (resultado) {
            alert("Datos incorrectos,el usuario no existe");
        }

    });
}