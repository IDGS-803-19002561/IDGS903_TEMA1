using Operaciones.Models;
using Operaciones.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace Operaciones.Controllers
{
    public class ArchivosController : Controller
    {
        // GET: Archivos
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public void Registrar (Maestro maes)
        {
            var add = new GuardarServices();
            add.GuardarArchivo(maes);
        }

        public ActionResult LeerDAtos()
        {
            var maes = new LeerServices();
            ViewBag.Maestros = maes.LeerArchivo();
            return View();
        }
    }
}
