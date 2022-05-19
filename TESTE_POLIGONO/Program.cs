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

            poligonos.Add(new Hexagono(new List<double>() { 10, 10, 10, 10, 10, 10 }));
            poligonos.Add(new Hexagono(new List<double>() { 20, 20, 20, 20, 20, 20 }));
            poligonos.Add(new Hexagono(new List<double>() { 30, 30, 30, 30, 30, 30 }));

            poligonos.Add(new Pentagono(new List<double>() { 10, 10, 10, 10, 10 }));
            poligonos.Add(new Pentagono(new List<double>() { 20, 20, 20, 20, 20 }));
            poligonos.Add(new Pentagono(new List<double>() { 30, 30, 30, 30, 30 }));

            poligonos.Add(new Retangulo(new List<double>() { 10, 10, 20, 20 }));
            poligonos.Add(new Retangulo(new List<double>() { 20, 20, 30, 30 }));
            poligonos.Add(new Retangulo(new List<double>() { 30, 30, 40, 40}));

            poligonos.ForEach(p => {
                Console.WriteLine("Type: {0}, Area: {1}, Perimetro: {2}", p.GetType().Name, p.Area(), p.Perimetro());
            });

            Console.ReadKey();
        }
    }
}
