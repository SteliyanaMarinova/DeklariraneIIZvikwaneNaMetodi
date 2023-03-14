using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konvektor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedi gradusi po faranhait: ");
            double faranheit = double.Parse(Console.ReadLine());
            double celsius = FaranheitToCelsium(faranheit);
            Console.WriteLine("{0:F2}", celsius);
        }

        static double FaranheitToCelsium(double faranheit)
        {
            return (faranheit - 32) * 5 / 9;
        }
    }
}
