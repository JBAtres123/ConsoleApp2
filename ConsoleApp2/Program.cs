using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el valor de a");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de b");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de c");
            double c = Convert.ToDouble(Console.ReadLine());

           double  S = (a + b + c) / 2;

            double AreaHeron = Math.Sqrt(S * ((S - a) * (S - b) * (S - c)));

            Console.WriteLine(" El Perimetro es:" + S);
            Console.WriteLine("El Área de la formula de Heron es:" + AreaHeron);

            Console.ReadKey();

        }
    }
}
