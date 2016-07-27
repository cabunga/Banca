function Transferir() {
    $.ajax({
        url: urlTransferencia,
        type: 'POST',
        data: { numerocuenta },
        success: function (resultado) {
            if (resultado === "Exitoso") {                
                location.href = "http://localhost/Banca/Transferencias/index";
            } else {
                alert("No se puedo Realizar Transferencia");
            }
            
        },
        error: function (resultado) {
            alert("No se puedo Realizar Transferencia");
        }

    });
}