using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius, fahrenheit, kelvin;
            
            Console.WriteLine("Ingreso temperatura en celsius:");

            celsius = double.Parse(Console.ReadLine());

            fahrenheit = celsius * (9.0 / 5.0) + 32;
            kelvin = celsius + 273.15;

            Console.WriteLine("Fahrenheit" + fahrenheit);
            Console.WriteLine("kelvin" + kelvin);
        }
    }
}
