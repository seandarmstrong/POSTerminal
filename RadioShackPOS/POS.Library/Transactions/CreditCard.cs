using System;

namespace POS.Library
{
    public class CreditCard
    {
        // yup...another validator
        Validator validator = new Validator();
        // ctor
        public CreditCard() { }
        // main methood for handling credit card transactions
        public string Transaction()
        {
            AskForCCNumber();
            AskForExpDate();
            AskForCVV();
            Console.ForegroundColor = ConsoleColor.Green;
            return "Your purchase has been completed!";
        }
        // method to recursively ask for cc number if it is invalid
        public void AskForCCNumber()
        {
            // ask for and store user input
            Console.Write("Please enter your credit card number ('1234123412341234 or 1234 1234 1234 1234'): ");
            var _creditCardNumber = Console.ReadLine();
            // if input is invalid display error
            // and call the method recursively
            if (!validator.ValidCCNumber(_creditCardNumber))
            {
                Console.WriteLine("Please enter a valid credit card number");
                AskForCCNumber();
            }
        }
        // method to recursively ask for cc expiration date if it is invalid
        public void AskForExpDate()
        {
            // ask for and store user input
            Console.Write("Please enter the expiration date (MM/YYYY): ");
            var _expDate = Console.ReadLine();
            // if input is invalid display error
            // and call the method recursively
            if (!validator.ValidExpDate(_expDate))
            {
                Console.WriteLine("Please enter a valid expiration date");
                Transaction();
            }
        }
        // method to recursively ask for cvv number if it is invalid
        public void AskForCVV()
        {
            // ask for and store user input
            Console.Write("Please enter the 3 digit code on the back of your card: ");
            var _cVV = Console.ReadLine();
            // if input is invalid display error
            // and call the method recursively
            if (!validator.ValidCVV(_cVV))
            {
                Console.WriteLine("Please enter a valid CVV (3 digit code at the end of the signature line");
                Transaction();
            }
        }
    }
}