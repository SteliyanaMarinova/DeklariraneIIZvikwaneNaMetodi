using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoGolqmaStoinost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedi tip: ");
            string name = Console.ReadLine();

            if (name == "int")
            {
                Console.Write("Vuvedi purvo chislo: ");
                int first = int.Parse(Console.ReadLine());
                Console.Write("Vuvedi vtoro chislo: ");
                int second = int.Parse(Console.ReadLine());
                int max = GetMax(first, second);
                Console.WriteLine($"Po golqmoto chislo e: {max}");
            }
            else if (name == "char")
            {
                Console.Write("Vuvedi purviq simvol: ");
                char first = char.Parse(Console.ReadLine());
                Console.Write("Vuvedi vtoriq simvol: ");
                char second = char.Parse(Console.ReadLine());
                int max = GetMax(first, second);
                Console.WriteLine($"Po golemiq simvol e: {(char)max}");
            }
            else if (name == "string")
            {
                Console.Write("Vuvedi purvi niz ot simvoli: ");
                string first = Console.ReadLine();
                Console.Write("Vuvedi vtori niz ot simvoli: ");
                string second = Console.ReadLine();
                string max = GetMax(first, second);
                Console.WriteLine($"Po golemiq niz e: {max}");
            }
        }
        static string GetMax(string first, string second)
        {
            string result = "";
            if (first.CompareTo(second) >= 0)
            {
                result = first;
                return result;
            }
            else
            {
                result = second;
                return result;
            }
        }


        static int GetMax(char first, char second)
        {
            int result = 0;
            if ((int)first > (int)second)
            {
                result = first;
                return result;
            }
            else
            {
                result = second;
                return result;
            }
        }

        static int GetMax(int first, int second)
        {
            int result = 0;
            if (first > second)
            {
                result = first;
                return result;
            }
            else
            {
                result = second;
                return result;
            }
        }
    }
}
    

