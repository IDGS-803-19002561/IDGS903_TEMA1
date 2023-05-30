using Operaciones.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Operaciones.Services
{
    public class GuardarServices
    {
        public void GuardarArchivo(Maestro maes)
        {
            var mat = maes.Matricula;
            var nom = maes.Nombre;
            var apa = maes.Apaterno;
            var ama = maes.Amaterno;
            var email = maes.Email;
            var datos = mat + "," + nom + "," + apa + "," + ama + "," + email + Environment.NewLine; //ENVIRONMENT.NEWLINE es para el salto del linea

            //Crear archivo
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");
            //Guardar datos sobrescribiendo
            //File.WriteAllText(archivo, datos);

            //Escribir texto sin sobrescribir
            File.AppendAllText(archivo, datos);
        }

    }
}