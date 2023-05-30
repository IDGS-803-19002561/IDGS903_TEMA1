using Operaciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Operaciones.Controllers
{
    public class CartesianoController : Controller
    {
        // GET: Cartesiano
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Resultado() {
            return View();
        }

        public ActionResult CalcularDistancia (Cartesiano cart)
        {
            cart.resultado = cart.CalcularDistancia();
            return View(cart);
        }
    }
}