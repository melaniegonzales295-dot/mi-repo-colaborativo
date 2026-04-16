using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
           
            Console.WriteLine("Ingrese el consume Kwh:");
            double Kwh = double.Parse(Console.ReadLine());

            double Subtotal = 5 + (Kwh * 0.55);
            double IGV = Subtotal * 0.18;
            double total = Subtotal * IGV;

            Console.WriteLine("Subtotal: S/" + Subtotal);
            Console.WriteLine("IGV: S/" + IGV);
            Console.WriteLine("total: S/" + total);
        }
    }
}
