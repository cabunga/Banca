using Banca.Bussines;
using Banca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

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
            var data = (Cliente)TempData["Cliente"];
            var transfer= (Transferencia)TempData["Transferencia"];
            
            if (data != null) {
                transferenciaObj = new Transferencia();
                transferenciaObj.ClienteOrigen = data;                
            } else
            {
                transferenciaObj= transfer;
            }
            return View(transferenciaObj);

        }
        public ActionResult cliente(Cliente cliente)
        {
            clienteOrigen = cliente;    
            return RedirectToAction("Index", clienteOrigen);
        }
        [HttpPost]
        public ActionResult administrar(Transferencia transferencia)
        {          
            AdministrarCliente administrar = new AdministrarCliente();
            transferencia = administrar.transferir(transferencia);                        
            TempData["Transferencia"] = transferencia;           
            return RedirectToAction("Index", transferencia);
        }
    }
}