using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banca.Models
{
    public class Transferencia
    {
        public Cliente ClienteOrigen { get; set; }
        public Cliente ClienteDestino { get; set; }
        public double Valor { get; set; }
        public bool estadoTransaccion { get; set; }
    }
}