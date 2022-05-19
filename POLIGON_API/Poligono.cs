using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLIGON_API
{
    public abstract class Poligono
    {
        public List<double> Lados { get; set; }
        public Poligono(List<double> Lados)
        {
            this.Lados = Lados;
        }
        public abstract double Area;
        public double Perimetro()
        {
            return Lados.Sum();
        }
    }
}
