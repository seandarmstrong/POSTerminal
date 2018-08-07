using System;

namespace POS.Library
{
    public class CreditCard : ICreditCardModel
    {
        public string CreditCardNumber { get; private set; }
        public string ExpirationDate { get; private set; }
        public string CVV { get; private set; }

        Validator Validator = new Validator();

        // ctor
        public CreditCard()
        {
        }
        // main methood for handling credit card transactions
        public void Transaction(float total)
        {
            AskForCCNumber();
            AskForExpDate();
            AskForCVV();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Your purchase for {total.ToString("C")} has been completed!");
            Console.ForegroundColor = ConsoleColor.White;
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
            /*if (DateTime.TryParse(ExpirationDate, out DateTime validExpDate))
            {
            }*/

            var dateParts = ExpirationDate.ToString().Split('/');
            var year = int.Parse(dateParts[1]);
            var month = int.Parse(dateParts[0]);
            var lastDaysInMonth = DateTime.DaysInMonth(year, month);
            var cardExpire = new DateTime(year, month, lastDaysInMonth, 23, 59, 59);
            if (cardExpire > DateTime.Now)
            {
                return ExpirationDate;
            }
            else
            {
                Console.WriteLine("That credit card is expired. Please enter another date.");
                return AskForExpDate();
            }
            
            

        }
        // if input is invalid display error
        // and call the method recursively
        //if (!Validator.ValidExpDate(ExpirationDate))
        //{
        //    Console.WriteLine("Please enter a valid expiration date");
        //    AskForExpDate();
        //}

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