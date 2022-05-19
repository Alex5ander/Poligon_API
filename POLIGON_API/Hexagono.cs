using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLIGON_API
{
    public class Hexagono : Poligono
    {
        public Hexagono(List<double> Lados) : base(Lados)
        {

        }
        public override double Area()
        {
            return ((3 * Math.Sqrt(3)) * Math.Pow(Lados[0], 2)) / 2;
        }
    }
}
