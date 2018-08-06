using System;

namespace POS.Library
{
    public class Cash : ICashModel
    {
        
        // PROPS
        public float Tender { get; private set; }
        public float Change { get; private set; }
        public float Total { get; set; }
        // ctor
        public Cash()
        {
        }
        public void Transaction(float total)
        {
            // ask for and store user input
            Console.Write("Please enter a dollar amount('100.00'): ");
            //var tender = Math.Round(float.Parse(Console.ReadLine()), 2);
            var tender = Console.ReadLine();
            // validate user input to be in the form of 0.00 
            // the last two decimal places matter the most
            if (float.TryParse(tender, out float validTender) && validTender >= total)
            {
                var change = validTender - total;
                // display the users change
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(String.Format("Your change is ${0}", Math.Round(change, 2)));
                Console.ForegroundColor = ConsoleColor.White;
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