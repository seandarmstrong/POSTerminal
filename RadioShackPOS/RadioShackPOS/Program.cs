using POS.Library;
using POS.Library.Transactions;
using System;

namespace RadioShackPOS
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Welcome to Radioshack");
            Menu.DisplayMainMenu();
            System.Console.WriteLine("put in some test input");
            var answer = Console.ReadLine();
            var validator = new Validator();
            if (validator.ValidExpDate(answer))
            {
                Console.WriteLine("valid");
            }
            //Console.ForegroundColor = ConsoleColor.White;
            ////////// TESTING - MIKE ///////////////////////////
            // CASH METHOD IS HERE IF YOU WANT TO TEST IT - hard coded total for testing
            //float total = 100.00f;
            //var cash = new Cash(total);
            //cash.Transaction(total);
            //CREDIT CARD METHOD IS HERE IF YOU WANT TO TEST IT
            //var creditCard = new CreditCard(total);
            //creditCard.Transaction(total);
            //CHECK METHOD IS HERE IF YOU WANT TO TEST IT
            //var check = new Check(total);
            //check.Transaction(total);
            Console.ReadKey();
            /////////////// END TESTING //////////////////////////

        }
    }
}
