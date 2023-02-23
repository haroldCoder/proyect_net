using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tallerPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Figura figura = new Triangulo();
            Figura figura2 = new Rectangulo();
            Figura figura3 = new Circulo();
            figura.Dibujar();
            figura2.Dibujar();
            figura3.Dibujar();

            Console.ReadKey();
        }
    }
}
