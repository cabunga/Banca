using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banca.Models
{
    public class Cliente
    {
        public string username { get; set; }
        public string password { get; set; }
        public string NumeroCuenta { get; set; }
        public double Saldo { get; set; }
    }
}