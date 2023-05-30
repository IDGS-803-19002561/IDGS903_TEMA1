using Operaciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace Operaciones.Controllers
{
    public class EscuelaController : Controller
    {
        // GET: Escuela
        public ActionResult Index()
        {
            var Alumno1 = new Alumnos();
            ViewBag.Alumnos = Alumno1;
            return View();
        }
  
        public ActionResult Registrar(Alumnos alum) {
            var Alumno1 = new Alumnos();
            alum = Alumno1;
            return View(alum);
        }
    

    public ActionResult Registrar2(Alumnos alum)
    {
        /*var Alumno1 = new Alumnos()
        {
            Nombre = "Antonio",
            Edad = 20,
            Activio = true,
            Inscrito = new DateTime(2023, 01, 15)
        };
        alum = Alumno1;*/
        return View(alum);
    }
}


    
}
