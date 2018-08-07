using System;

namespace POS.Library
{
    public class Check : ICheckModel
    {
        // PROPS
        public string CheckNumber { get; private set; }

        readonly Validator Validator = new Validator();

        // ctor
        public Check() { }

        // main check transaction method
        public void Transaction(float total)
        {
            var receipt = new Receipt();
            var receiptForOrder = new Order();
            // prompt  user for check number
            GetCheckNumber();
            // fancy pants success color and message
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Your check #{ CheckNumber } has been processed!");
            Console.ForegroundColor = ConsoleColor.White;
            // display the receipt and payment method after valid payment completed
            receiptForOrder.GetReceiptDisplay();
            receipt.DisplayReceipt(this);
        }

        public string GetCheckNumber()
        {
            // ask for and store user checknumber
            Console.WriteLine("Please enter a check number (0000): ");
            CheckNumber = Console.ReadLine();
            // validate user input

            if (!Validator.ValidateCheckNumber(CheckNumber))
            {
                // call the method recursively if user input is invalid
                Console.WriteLine("Please enter a valid check number in the form of 4 numbers (1234)");
                GetCheckNumber();
            }
            return CheckNumber;
        }

        public string UseCheckNumber()
        {
            return CheckNumber;
        }
    }

}