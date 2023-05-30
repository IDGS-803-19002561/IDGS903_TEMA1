using Operaciones.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace Operaciones.Services
{
    public class TraductorServices
    {
        public void AddTraductor(Traductor trad) {


            var español = trad.Español;
            var ingles = trad.Ingles;
            var datos = español.ToUpper() + "|" + ingles.ToUpper()+ Environment.NewLine; //ENVIRONMENT.NEWLINE es para el salto del linea

            //Crear archivo
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/traductor.txt");
            //Guardar datos sobrescribiendo
            //File.WriteAllText(archivo, datos);
            //Escribir texto sin sobrescribir
            File.AppendAllText(archivo, datos);
        }

        public Array ListTraductor()
        {
            Array traductData = null;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/traductor.txt");

            if (File.Exists(archivo))
            {
                traductData = File.ReadAllLines(archivo);
            }
            return traductData;
        }
    }
}