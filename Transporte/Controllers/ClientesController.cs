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
        private departamento Departamento = new departamento();

        public ActionResult Index()
        {
            return View(Clientes.ListarClientes());
        }

        // action result con parametros para guardar desde el modal que esta en el index de los clientes
        [HttpPost]
        public ActionResult Guardar(clientes model, int? departamentos)
        {
            ViewBag.inst = model.nombre;
            ViewBag.obj = departamentos.ToString();
            
            return View();
            //model.Guardar();
            //return Redirect("~/Clientes/Index");            
        }

        public ActionResult Crear()
        {
            var deptos = Departamento.ListarDepartamentos();
            SelectList listado = new SelectList(deptos,"id","nombreDepartamento");
            ViewBag.Departamentos = listado;

            return View();
        }

        public ActionResult Detalle(int id)
        {
            return View(Clientes.getCliente(id));
        }
        
    }
}