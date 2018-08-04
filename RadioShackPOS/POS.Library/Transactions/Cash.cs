using System;
using POS.Library.Transactions;

namespace POS.Library
{
    public class Cash : ITransactionModel
    {
        
        // PROPS
        private static float _tender { get; set; }
        private static float _change { get; set; }
        public float Total { get; set; }
        Validator Validator = new Validator();
        // ctor
        public Cash(float total)
        {
            Total = total;
        }

        //handle making change for the customer
        public string MakeChange(float total)
        {
            var change = total - _tender;
            return change.ToString("c2");
        }

        public void Transaction(float total)
        {
            // ask for and store user input
            Console.Write("Please enter a dollar amount('100.00'): ");
            var _tender = Console.ReadLine();
            // validate user input to be in the form of 0.00 
            // the last two decimal places matter the most
            if (!Validator.VailidCashFormat(_tender))
            {
                // if invalid input call CashTransaction recursively
                Console.WriteLine("A valid dollar amount will end with two decimal places(100.00)");
                Transaction(total);
            }
            // convert user input to float
            float change = float.Parse(_tender) - total;
            // display the users change
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(String.Format("Your change is {0}", MakeChange(change)));
        }
    }
}