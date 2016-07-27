using Banca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banca.Bussines
{
   public  interface IAdministrarCliente
    {
        Transferencia transferir(Transferencia transferencia);
    }
}
