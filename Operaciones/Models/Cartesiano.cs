using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Operaciones.Models
{
    public class Cartesiano
    {
        public int Y1 { get; set; }
        public int X1 { get; set; }
        public int Y2 { get; set; }
        public int X2 { get; set; }
        public double resultado { get; set; }

        public double CalcularDistancia ()
        {
            double difX = Math.Pow(this.X2 - this.X1, 2);
            double difY = Math.Pow(this.Y2 - this.Y1, 2);


            return Math.Sqrt(difX + difY);
        }
    }

}