using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresmqtaneNaLice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedi schirina: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Vuvedi visochina: ");
            double heigth = double.Parse(Console.ReadLine());
            double area = GetTraingleArea(width, heigth); 
            Console.WriteLine($"S = {area} sm2");
        }

        static double GetTraingleArea(double width, double heigth)
        {
            return width * heigth / 2;
        }
    }
}
