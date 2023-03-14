using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraznaKasovaBelejka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintReceipt();
        }

        static void PrintReceipt()
        {
            PrintReceiptHeader();
            PrintReceiptBody();
            PrintReceiptFooter();
        }

        static void PrintReceiptFooter()
        {
            Console.WriteLine("\u00A9 SoftUni");
        }

        static void PrintReceiptBody()
        {
            Console.WriteLine("Charget to ______________");
            Console.WriteLine("Received by ______________");
        }

        static void PrintReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("----------------");
        }   
    }
}
