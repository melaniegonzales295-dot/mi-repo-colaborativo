using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa el radio: ");
            double radio = double.Parse(Console.ReadLine());

            double area = Math.PI * radio * radio;
            double perimetro = 2 * Math.PI * radio;

            Console.WriteLine($"Área del circulo: {area:F2}");
            Console.WriteLine($"Perímetro del circulo: {perimetro:F2}");
        }
    }
}
