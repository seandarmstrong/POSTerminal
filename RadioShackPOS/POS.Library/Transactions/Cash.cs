using System;

namespace POS.Library
{
    public class Cash : Transaction.Transaction
    {
        // omgoodness...it's a validator
        Validator validator = new Validator();
        // ctor
        public Cash() { }
        // PROPS
        private static float _total = 100.00f;
        private static float _tender { get; set; }
        private static float Change { get; set; }
        // handle making change for the customer
        public static string MakeChange()
        {
            return (_tender - _total).ToString("c2");
        }

        public string Transaction()
        {
            // ask for and store user input
            Console.Write("Please enter a dollar amount('100.00'): ");
            var _tender = Console.ReadLine();
            // validate user input to be in the form of 0.00 
            // the last two decimal places matter the most
            if (!validator.VailidCashFormat(_tender))
            {
                // if invalid input call CashTransaction recursively
                Console.WriteLine("A valid dollar amount will end with two decimal places(100.00)");
                Transaction();
            }
            // convert user input to float
            float change = float.Parse(_tender);
            // display the users change
            Console.ForegroundColor = ConsoleColor.Green;
            return String.Format("Your change is {0}", MakeChange());
        }
    }
}