using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Library.Transaction
{
    public class Transaction
    {
        // Shared
        private static float _total = 100.00f;
        // For cash
        private static float _tender { get; set; }
        // For CC
        private static string _creditCardNumber { get; set; }
        // For CC
        private static string _expDate { get; set; }
        // For CC
        private static string _cVV { get; set; }
        // For Check
        private static int _checkNumber { get; set; }
        // Validation methods for transactions
        Validator validator = new Validator();
        // ctor
        public Transaction()
        {
            
        }

        // calculates change and returns it in a string currency format
        // with the dollar sign and 2 decimal places for change
        public string MakeChange(float tender)
        {
            string change = (tender - _total).ToString("c2");
            return change;
        }
        // Cash transaction method
        public string CashTransaction()
        {
            // ask for and store user input
            Console.WriteLine("Please enter a dollar amount('100.00'): ");
            var payment = Console.ReadLine();
            // validate user input to be in the form of 0.00 
            // the last two decimal places matter the most
            if (!validator.VailidCashFormat(payment))
            {
                // if invalid input call CashTransaction recursively
                Console.WriteLine("A valid dollar amount will end with two decimal places(100.00)");
                CashTransaction();
            }
            // convert user input to float
            float change = float.Parse(payment);
            // display the users change
            return String.Format("Your change is {0}", MakeChange(change));
        }



    }
}
