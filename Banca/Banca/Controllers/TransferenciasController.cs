using Banca.Bussines;
using Banca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Banca.Controllers
{
    public class TransferenciasController : Controller
    {
     
        Transferencia transferenciaObj;
        private Cliente clienteOrigen
        {
            get;
            set;
        }
        public ActionResult Index()
        {           
            return View();
        }
        public ActionResult cliente(Cliente cliente)
        {
            clienteOrigen = cliente;    
            return RedirectToAction("Index", clienteOrigen);
        }
        [HttpPost]
        public ActionResult administrar(Transferencia transferencia)
        {
            //ViewData["transferencia"] = transferencia;
            //return RedirectToAction("Index",transferencia);
            AdministrarCliente administrar = new AdministrarCliente();
            transferencia = administrar.transferir(transferencia);

            return RedirectToAction("Index", transferencia);
        }
    }
}