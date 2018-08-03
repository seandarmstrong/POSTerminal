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
        ///////////////////////////////////////////////////
        //////////// CASH TRANSACTION /////////////////////
        ///////////////////////////////////////////////////
        // calculates change and returns it in a string currency format
        // with the dollar sign and 2 decimal places for change
        //public string MakeChange(float tender)
        //{
        //    string change = (tender - _total).ToString("c2");
        //    return change;
        //}
        // Cash transaction method
        //public string CashTransaction()
        //{
        //    // ask for and store user input
        //    Console.Write("Please enter a dollar amount('100.00'): ");
        //    var payment = Console.ReadLine();
        //    // validate user input to be in the form of 0.00 
        //    // the last two decimal places matter the most
        //    if (!validator.VailidCashFormat(payment))
        //    {
        //        // if invalid input call CashTransaction recursively
        //        Console.WriteLine("A valid dollar amount will end with two decimal places(100.00)");
        //        CashTransaction();
        //    }
        //    // convert user input to float
        //    float change = float.Parse(payment);
        //    // display the users change
        //    return String.Format("Your change is {0}", MakeChange(change));
        //}
        ///////////////////////////////////////////////////////
        /////////////// Credit Card transactions //////////////
        ///////////////////////////////////////////////////////
        // Main credit card transaction method
        //public void CCTransaction()
        //{
        //    AskForCCNumber();
        //    AskForExpDate();
        //    AskForCVV();
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    Console.WriteLine("Your purchase has been completed!");
        //    Console.ForegroundColor = ConsoleColor.White;
        //}
        //// helper method to recursively ask for cc number if it is invalid
        //public void AskForCCNumber()
        //{
        //    Console.Write("Please enter your credit card number ('1234123412341234 or 1234 1234 1234 1234'): ");
        //    var ccNumber = Console.ReadLine();
        //    if (!validator.ValidCCNumber(ccNumber))
        //    {
        //        Console.WriteLine("Please enter a valid credit card number");
        //        AskForCCNumber();
        //    }

        //}
        //// helper method to recursively ask for expiration date if it is invalid
        //public void AskForExpDate()
        //{
        //    Console.Write("Please enter the expiration date (MM/YY): ");
        //    var expirationDate = Console.ReadLine();
        //    if (!validator.ValidExpDate(expirationDate))
        //    {
        //        Console.WriteLine("Please enter a valid expiration date");
        //        AskForExpDate();
        //    }
        //}
        //// helper method to recursively ask for cvv if it is invalid
        //public void AskForCVV()
        //{
        //    Console.Write("Please enter the 3 digit code on the back of your card: ");
        //    var cvvNumber = Console.ReadLine();
        //    if (!validator.ValidCVV(cvvNumber))
        //    {
        //        Console.WriteLine("Please enter a valid CVV (3 digit code at the end of the signature line)");
        //        AskForCVV();
        //    }
        //}
        ///////////////////////////////////////////////////
        //////////// CHECK TRANSACTION ////////////////////
        ///////////////////////////////////////////////////

        // method to handle Check transactions
        public string CheckTransaction()
        {
            throw new NotImplementedException();
        }


    }
}
