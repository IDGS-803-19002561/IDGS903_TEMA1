using Operaciones.Models;
using Operaciones.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace Operaciones.Controllers
{
    public class TraductorController : Controller
    {
        // GET: Traductor
        public ActionResult Index()
        {
            var traductor = new TraductorServices();
            ViewBag.validate = true;
            ViewBag.ListTraduc = traductor.ListTraductor();
            return View();
        }

        [HttpPost]
        public ActionResult AddDiccionario(Traductor trad)
        {

            if (trad.Español == null && trad.Ingles == null)
            {
                ViewBag.status = "Ingresa un valor";
            }
            else
            {
                ViewBag.status = "";
                var traductor = new TraductorServices();
                traductor.AddTraductor(trad);
            }

            return RedirectToAction("Index", "Traductor", trad);
        }


        public ActionResult SearchWork(Search search)
        {
            return View(search);
        }

        [HttpPost]
        public ActionResult AddDiccionarioForm(Search search)
        {
            var traductor = new TraductorServices();
            String[] data = new string[2];
            String response = "";
            foreach (string item in traductor.ListTraductor())
            {
                data = item.Split('|');
                if (search.Type == "ingles")
                {
                    response = (data[1] == search.Text.ToUpper()) ? data[0] : "NO EXITE ESE VALOR";
                }
                else if (search.Type == "español")
                {
                    response = (data[0] == search.Text.ToUpper()) ? data[1] : "NO EXITE ESE VALOR";
                }
            }

            ViewBag.SearchText = response;
            return View();
        }


    }
}