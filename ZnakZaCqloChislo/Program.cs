using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZnakZaCqloChislo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedi chislo: ");
            int number = int.Parse(Console.ReadLine());
            PrintSign(number);
        }

        static void PrintSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("-------------");
                Console.WriteLine($"Chislot {number} e polojitelno");
            }
            else if (number < 0)
            {
                Console.WriteLine("-------------");
                Console.WriteLine($"Chisloto {number} e otricatelno");
            }
            else
            {
                Console.WriteLine("-------------");
                Console.WriteLine($"Chisloto {number} e nula");
            }
        }
    }
}
