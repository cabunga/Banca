using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Banca.Controllers;
using System.Web.Mvc;
using Banca.Models;
using Banca.Bussines;

namespace Banca.Tests
{
    [TestClass]
    public class AutenticarseTest
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        public void login_usuario_valido()
        {
            //Assert
          
            String usuario = "admin";
            String password = "admin";
            var usuarioController = new AdministrarUsuarios();
            Cliente cliente = new Cliente();
            cliente.username = usuario;
            cliente.password = password;
            //Act
            Boolean estado = usuarioController.getCliente(cliente.username);
            //Arrange
            Assert.IsTrue(estado);
            
        }
    }
}
