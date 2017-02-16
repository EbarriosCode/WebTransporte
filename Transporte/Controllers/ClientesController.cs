using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Transporte.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        private clientes Clientes = new clientes();
        public ActionResult Index()
        {
            return View(Clientes.ListarClientes());
        }
    }
}