using POS.Library;
using POS.Library.Transactions;
using POS.Library.Products;
using System;

namespace RadioShackPOS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Welcome to RadioShack - the best for cables and batteries since 1970");
            do
            {
                Menu.DisplayMainMenu();
            } while (true);

            
        }
    }
}
