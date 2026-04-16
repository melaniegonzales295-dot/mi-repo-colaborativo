using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejecicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresa el radio del circulo");
            double radio = double.Parse(Console.ReadLine());

            double area = Math.PI * radio * radio;
            double perimetro = 2 * Math.PI * radio;
            Console.WriteLine($"área del circulo : {area:F2}");
            Console.WriteLine($"perimetro del circulo : {perimetro:F2}");
        }
    }
}
