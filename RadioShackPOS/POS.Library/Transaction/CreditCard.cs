using System;

namespace POS.Library
{
    public class CreditCard : Transaction.Transaction
    {
        Validator validator = new Validator();

        public CreditCard()
        {
        }
        private static string _creditCardNumber { get; set; }
        private static string _expDate { get; set; }
        private static string _cVV { get; set; }

        public string CCTransaction()
        {

            AskForCCNumber();
            AskForExpDate();
            AskForCVV();
            Console.ForegroundColor = ConsoleColor.Green;
            return "Your purchase has been completed!";
        }

        public void AskForCCNumber()
        {
            Console.Write("Please enter your credit card number ('1234123412341234 or 1234 1234 1234 1234'): ");
            var _creditCardNumber = Console.ReadLine();
            if (!validator.ValidCCNumber(_creditCardNumber))
            {
                Console.WriteLine("Please enter a valid credit card number");
                AskForCCNumber();
            }
        }
        public void AskForExpDate()
        {
            Console.Write("Please enter the expiration date (MM/YYYY): ");
            var _expDate = Console.ReadLine();
            if (!validator.ValidExpDate(_expDate))
            {
                Console.WriteLine("Please enter a valid expiration date");
                CCTransaction();
            }
        }
        public void AskForCVV()
        {
            Console.Write("Please enter the 3 digit code on the back of your card: ");
            var _cVV = Console.ReadLine();
            if (!validator.ValidCVV(_cVV))
            {
                Console.WriteLine("Please enter a valid CVV (3 digit code at the end of the signature line");
                CCTransaction();
            }
        }
    }
}