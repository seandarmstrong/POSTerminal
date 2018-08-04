using System;
using POS.Library.Transactions;

namespace POS.Library
{
    public class CreditCard : ICreditCardModel
    {
        public float Total { get; set; }
        public string CreditCardNumber { get; private set; }
        public string ExpirationDate { get; private set; }
        public string CVV { get; private set; }

        Validator Validator = new Validator();

        // ctor
        public CreditCard(float total)
        {
            Total = total;
        }
        // main methood for handling credit card transactions
        public void Transaction(float total)
        {
            AskForCCNumber();
            AskForExpDate();
            AskForCVV();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Your purchase has been completed!");
        }
        // method to recursively ask for cc number if it is invalid
        public string AskForCCNumber()
        {
            // ask for and store user input
            Console.Write("Please enter your credit card number ('1234123412341234 or 1234 1234 1234 1234'): ");
            CreditCardNumber = Console.ReadLine();
            // if input is invalid display error
            // and call the method recursively
            if (!Validator.ValidCCNumber(CreditCardNumber))
            {
                Console.WriteLine("Please enter a valid credit card number");
                AskForCCNumber();
            }
            return CreditCardNumber;
        }
        // method to recursively ask for cc expiration date if it is invalid
        public string AskForExpDate()
        {
            // ask for and store user input
            Console.Write("Please enter the expiration date (MM/YY): ");
            ExpirationDate = Console.ReadLine();
            // if input is invalid display error
            // and call the method recursively
            if (!Validator.ValidExpDate(ExpirationDate))
            {
                Console.WriteLine("Please enter a valid expiration date");
                AskForExpDate();
            }
            return ExpirationDate;
        }
        // method to recursively ask for cvv number if it is invalid
        public string AskForCVV()
        {
            // ask for and store user input
            Console.Write("Please enter the 3 digit code on the back of your card: ");
            CVV = Console.ReadLine();
            // if input is invalid display error
            // and call the method recursively
            if (!Validator.ValidCVV(CVV))
            {
                Console.WriteLine("Please enter a valid CVV (3 digit code at the end of the signature line");
                AskForCVV();
            }
            return CVV;
        }
    }
}