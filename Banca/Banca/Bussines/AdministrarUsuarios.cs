using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Banca.Models;

namespace Banca.Bussines
{
    public class AdministrarUsuarios : IAdministracionUsuarios
    {
        public List<Cliente> getAllUsuarios()
        {
            return DataUser.ListaUsuario;
        }

        public Boolean getCliente(string usuario)
        {
            Boolean existecliente = false;
                       
            foreach (Cliente cliente in DataUser.getDataUser())
            {
                if (usuario.Equals(cliente.username)) {
                    existecliente = true;
                }
                    }
            return existecliente;
        }
    }
}