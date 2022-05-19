using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLIGON_API
{
    public class Retangulo : Poligono
    {
        public Retangulo(List<double> Lados) : base(Lados) 
        {

        }

        public override double Area()
        {
            return Lados[0] * Lados[1];
        }
    }
}
