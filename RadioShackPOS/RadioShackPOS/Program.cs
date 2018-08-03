using POS.Library;
using System;

namespace RadioShackPOS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            ////////// TESTING - MIKE ///////////////////////
            var transaction = new POS.Library.Transaction.Transaction();
            transaction.CCTransaction();


            Console.ReadKey();
        }
    }
}
