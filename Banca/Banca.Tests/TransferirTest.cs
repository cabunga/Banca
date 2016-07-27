using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Banca.Bussines;
using Banca.Models;

namespace Banca.Tests
{
    [TestClass]
    public class TransferirTest
    {

        [TestMethod]
        public void Transferir()
        {
            //Arrange
            AdministrarCliente administrarCliente = new AdministrarCliente();
            Cliente clienteOrigen = new Cliente();
            clienteOrigen.NumeroCuenta = "1122333";
            clienteOrigen.Saldo = 10000;

            Transferencia transferencia = new Transferencia();
            transferencia.ClienteOrigen = clienteOrigen;
            transferencia.ClienteDestino = new Cliente();
            transferencia.ClienteDestino.NumeroCuenta = "334455";
            transferencia.Valor = 2000;
            
            //Act
            transferencia = administrarCliente.transferir(transferencia);
            //Assert
            
            Assert.AreEqual(8000, transferencia.ClienteOrigen.Saldo);
        }
    }
}
