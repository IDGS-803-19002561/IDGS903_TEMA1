using Operaciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace Operaciones.Controllers
{
    public class TrianguloController : Controller
    {
        // GET: Triangulo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Calcular(Triangulo tria)
        {
            tria.getData();
            return View(tria);
        }

    }
}
