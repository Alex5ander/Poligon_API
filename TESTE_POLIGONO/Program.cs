using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POLIGON_API;

namespace TESTE_POLIGONO
{
    class Program
    {
        static List<Poligono> poligonos = new List<Poligono>();
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;

            poligonos.Add(new Triangulo(new List<double>() { 10, 10, 10 }));
            poligonos.Add(new Triangulo(new List<double>() { 10, 10, 16 }));
            poligonos.Add(new Triangulo(new List<double>() { 6, 7, 8 }));

            poligonos.ForEach(p => {
                Console.WriteLine("Area: {0}, Perimetro: {1}", p.Area(), p.Perimetro());
            });

            Console.ReadKey();
        }
    }
}
