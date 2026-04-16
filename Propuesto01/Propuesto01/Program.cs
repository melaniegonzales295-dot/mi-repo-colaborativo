using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propuesto01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double hab, bat,pat, tothab, totbat, totpat, montototal;
            Console.WriteLine("Ingresa cantidad de habitaciones: ");
            hab = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa cantidad de baños: ");
            bat = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa cantidad de patios: ");
            pat = double.Parse(Console.ReadLine());

            tothab = hab * 30;
            totbat = bat * 10;
            totpat = pat * 15;

            montototal = tothab + totbat + totpat;

            Console.WriteLine("Monto total:" + montototal);
        }
    }
}
