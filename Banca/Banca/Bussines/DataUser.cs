using Banca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banca.Bussines
{
    public class DataUser
    {
        public static List<Cliente> ListaUsuario { get; set; }
        private static DataUser dataUser;
        private DataUser()
        {
            
            Cliente cliente = new Cliente();

            cliente.Saldo = 10000;
            cliente.NumeroCuenta = "123456";
            cliente.username = "admin";
            cliente.password = "admin";
            ListaUsuario = new List<Cliente>();
            ListaUsuario.Add(cliente);
        }
        public static List<Cliente> getDataUser()
        {
            if (dataUser == null)
            {
                dataUser= new DataUser();
            }
            return ListaUsuario;
        }
    }
}