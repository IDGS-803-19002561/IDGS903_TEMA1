using Operaciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Operaciones.Controllers
{
    public class OperaBasController : Controller
    {
        // GET: OperaBas
        public ActionResult Index(OperasBas op)
        {
            op.Operaciones();
            var model = new OperasBas();
            model.Res = op.Res;
            return View(model);
        }
    }
}