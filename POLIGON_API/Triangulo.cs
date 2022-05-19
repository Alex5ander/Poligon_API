using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLIGON_API
{
    public class Triangulo : Poligono
    {
        public Triangulo(List<double> Lados) : base(Lados)
        {

        }

        public override double Area()
        {
            if(Lados[0] == Lados[1] && Lados[1] == Lados[2]) 
            {
                return Math.Pow(Lados[0], 2) * Math.Sqrt(3) / 4;
            }
            else if (Lados[0] != Lados[1] && Lados[1] != Lados[2] && Lados[0] != Lados[2])
            {
                double p = Perimetro() / 2;
                return Math.Sqrt(p * (p - Lados[0]) * (p - Lados[1]) * (p - Lados[2]));
            }
            else 
            {
                double h = Math.Sqrt(Math.Pow(Lados[0], 2) - Math.Pow(Lados[1] / 2, 2));
                return (Lados[2] * h) / 2;
            }
        }
    }
}
