using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Web;

namespace Operaciones.Models
{
    public class Triangulo
    {
        public double a1 { get; set; }
        public double a2 { get; set; }
        public double b1 { get; set; }
        public double b2 { get; set; }
        public double c1 { get; set; }
        public double c2 { get; set; }
        public double ab { get; set; }
        public double bc { get; set; }
        public double ac { get; set; }
        public double area { get; set; }
        public double perimetro { get; set; }
        public string tipo { get; set; }
            
        public void getData()
        {
            this.ab = Math.Sqrt(Math.Pow(this.b1 - this.a1, 2) + Math.Pow(this.b2 - this.a2, 2));
            this.bc = Math.Sqrt(Math.Pow(this.c1 - this.b1, 2) + Math.Pow(this.c2 - this.b2, 2));
            this.ac = Math.Sqrt(Math.Pow(this.c1 - this.a1, 2) + Math.Pow(this.c2 - this.a2, 2));

            this.ab = Math.Round(this.ab, MidpointRounding.AwayFromZero);
            this.bc = Math.Round(this.bc, MidpointRounding.AwayFromZero);
            this.ac = Math.Round(this.ac, MidpointRounding.AwayFromZero);

            this.perimetro = ab + bc + bc;
            this.tipo = getTipo();
            this.area = Math.Round(getArea(), MidpointRounding.AwayFromZero);
        }

        public bool isTringulo()
        {
            double mayor = 0;
            double sumalados = 0;

            if (this.ab > this.bc && this.ab > this.ac)
            {
                mayor = this.ab;
                sumalados = this.bc + this.ac;
            }
            else if (this.bc > this.ab && this.bc > this.ac)
            {
                mayor = this.bc;
                sumalados = this.ab + this.ac;
            }
            else
            {
                mayor = this.ac;
                sumalados = this.ab + this.bc;
            }
            return (mayor < sumalados);
        }

        public string getTipo()
        {
            if (ab == bc && bc == ac)
            {
                return "Equilatero";
            }
            else if (ab == bc || ab == ac || bc == ac)
            {
                return "Isósceles";
            }
            else
            {
                return "Escaleno";
            }
        }
        //Fórmula de Herón
        public double getArea()
        {
            //
            //semiperimetro = (ab + bc + ac) / 2 
            double semipe = (this.ab + this.bc + this.ac) / 2;
            //√ [s(s – a)(s – b)(s – c)]
            return Math.Sqrt(semipe * ((semipe - this.ab) * (semipe - this.bc) * (semipe - this.ac)));
        }

    }
}

