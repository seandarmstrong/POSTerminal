using System;

namespace POS.Library
{
    public class Cash : ICashModel
    {

        // PROPS
        public string Tender { get; private set; }

        public float Change { get; private set; }

        // ctor
        public Cash()
        {
        }

        public void Transaction(float total)
        {
            // ask for and store user input
            Console.Write("Please enter a dollar amount('100.00'): ");
            //var tender = Math.Round(float.Parse(Console.ReadLine()), 2);
            Tender = Console.ReadLine();
            // validate user input to be in the form of 0.00 
            // the last two decimal places matter the most
            if (float.TryParse(Tender, out float tender) && tender >= total)
            {
                var receipt = new Receipt();
                var receiptForOrder = new Order();
                Change = tender - total;
                // display the users change
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Your change is ${Math.Round(Change, 2)}");
                Console.ForegroundColor = ConsoleColor.White;
                // display receipt and payment method
                receiptForOrder.GetReceiptDisplay();
                receipt.DisplayReceipt(this);
            }
            else
            {
                // if invalid input call CashTransaction recursively
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A valid dollar amount will end with two decimal places(100.00)");
                Console.ForegroundColor = ConsoleColor.White;
                Transaction(total);
            }
        }
    }
}