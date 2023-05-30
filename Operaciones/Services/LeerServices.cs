using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace Operaciones.Services
{
    public class LeerServices
    {
        public Array LeerArchivo()
        {
            Array meesData = null;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");

            if(File.Exists(archivo))
            {
                meesData = File.ReadAllLines(archivo);
            }
            return meesData;
        }
    }
}