using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Transporte.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProgramacionViajes()
        {
            return View();
        }

        public ActionResult TerminosCondiciones()
        {
            return View();
        }

        public ActionResult AntesDeViajar()
        {
            return View();
        }

        public ActionResult Contacto()
        {
            return View();
        }

        public ActionResult AcercaDe()
        {
            return View();
        }
    }
}
