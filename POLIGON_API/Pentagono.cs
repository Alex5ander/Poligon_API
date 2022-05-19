﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLIGON_API
{
    public class Pentagono : Poligono
    {
        public Pentagono(List<double> Lados) : base(Lados) 
        {
            
        }
        public override double Area()
        {
            return (5 * Lados[0]) / (4 * Math.Tan(36 * Math.PI / 180));
        }
    }
}
