using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;

namespace Operaciones.Models
{
    public class Alumnos
    {
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public string Inscrito { get; set; }
        public bool Activio { get; set; }
        public int Edad { get; set; }
    }
}