using System;
using POS.Library.Transactions;

namespace POS.Library
{
    public class Check : ITransactionModel
    {

        public float Total { get; set; }
        Validator Validator = new Validator();
        // ctor
        public Check(float total)
        {
            Total = total;
        }

        public void Transaction(float total)
        {
            // ask for and store user checknumber
            Console.WriteLine("Please enter a check number (0000): ");
            var checkNumber = Console.ReadLine();
            // validate user input
            if (!Validator.ValidCheckNumber(checkNumber))
            {
                // call the method recursively if user input is invalid
                Console.WriteLine("Please enter a valid check number in the form of 4 numbers (1234)");
                Transaction(total);
            }
            // fancy pants success color and message
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Your check #{ checkNumber } has been processed!");
        }

        
    }

}