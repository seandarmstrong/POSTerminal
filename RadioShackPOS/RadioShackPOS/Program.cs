using System;
using POS.Library;
using System.Text.RegularExpressions;

namespace RadioShackPOS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            ////////// TESTING - MIKE ///////////////////////
            //System.Console.WriteLine("put in some test input");
            //var answer = Console.ReadLine();
            var validator = new Validator();
            var transaction = new POS.Library.Transaction.Transaction();
            //var change = transaction.CashTransaction();
            transaction.CCTransaction();
            
            //if (validator.ValidCVV(answer))
            //{
            //    Console.WriteLine("valid");
            //}
            ///////////////////////////////////////////////


            Console.ReadKey();
        }
    }
}
