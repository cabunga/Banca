using Banca.Bussines;
using Banca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Banca.Controllers
{
    public class LoginController : Controller
    {
        private static String EXITO = "Exitoso";
        private static String FALLIDO = "Fallido";

        public IAdministracionUsuarios AdminUsuarios { get; set; }

        public LoginController() {
            AdminUsuarios = new AdministrarUsuarios();
        }
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Autenticarse(Cliente cliente)
        {
            Boolean respuesta = AdminUsuarios.getCliente(cliente.username.ToString());
            if (respuesta)
            {
                cliente.NumeroCuenta = "10001";
                cliente.Saldo = 10000;
                TempData["Cliente"] = cliente;
                return RedirectToAction("cliente", "Transferencias", cliente);
            }
            else
            {
                return RedirectToAction("Index");
                //return FALLIDO;
            }
           
        }
    }
}