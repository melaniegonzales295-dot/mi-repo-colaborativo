using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejecicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("monto en soles:");
            double monto = double.Parse(Console.ReadLine());
            double haciaARRIBA = Math.Ceiling(monto);
            double haciaABAJO = Math.Floor(monto);
            int trucando = (int)monto;
            double redondeado = Math.Round(monto);
            Console.WriteLine($"monto original: {monto}");
            Console.WriteLine($"ceiling (haciaARRIBA): {haciaARRIBA}");
            Console.WriteLine($"floor (haciaABAJO): {haciaABAJO}");
            Console.WriteLine($"trucando (casting): {trucando}");
            Console.WriteLine($"redondeado (2 decimales): {redondeado}");
        }
    }
}
