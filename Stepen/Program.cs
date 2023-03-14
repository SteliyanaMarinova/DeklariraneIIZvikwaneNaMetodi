using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stepen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedi chislo: ");
            double number = double.Parse(Console.ReadLine());
            Console.Write("Vuvedi stepen: ");
            double power = double.Parse(Console.ReadLine());
            double result = RaiseToPower(number, power);
            Console.WriteLine($"{number} na stepen {power} = {result}");
        }

        static double RaiseToPower(double number, double power)
        {
            double result = 0d;
            result = Math.Pow(number, power);
            return result;
        }
    }
}
