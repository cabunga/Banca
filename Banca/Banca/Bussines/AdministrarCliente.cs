using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Banca.Models;

namespace Banca.Bussines
{
    public class AdministrarCliente : IAdministrarCliente
    {
        public Transferencia transferir(Transferencia transferencia)
        {
            
            if (verificarSaldo(transferencia.ClienteOrigen, transferencia.Valor)) {
                double saldoActualCO = transferencia.ClienteOrigen.Saldo;
                transferencia.ClienteOrigen.Saldo = saldoActualCO - transferencia.Valor;
                double saldoActualCD = transferencia.ClienteDestino.Saldo;
                transferencia.ClienteDestino.Saldo = saldoActualCD + transferencia.Valor;
                transferencia.Valor = 0;
                transferencia.estadoTransaccion = true;
            }

            return transferencia;
        }
        
        private bool verificarSaldo(Cliente clienteOrigen, double valor)
        {
            Boolean respuesta = false;
            if (clienteOrigen.Saldo > valor)
            {
                respuesta = true;
            }
            return respuesta;
        }
    }
     

}