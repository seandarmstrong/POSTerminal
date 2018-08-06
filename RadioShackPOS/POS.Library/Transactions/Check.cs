using System;

namespace POS.Library
{
    public class Check : ICheckModel
    {
        
        public string CheckNumber { get;  private set; }

        Validator Validator = new Validator();
        // ctor
        public Check()
        {
        }

        public void Transaction(float total)
        {
            // prompt  user for check number
            GetCheckNumber(total);
            // fancy pants success color and message
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Your check #{ CheckNumber } has been processed!");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public string GetCheckNumber(float total)
        {
            // ask for and store user checknumber
            Console.WriteLine("Please enter a check number (0000): ");
            CheckNumber = Console.ReadLine();
            // validate user input
            if (!Validator.ValidCheckNumber(CheckNumber))
            {
                // call the method recursively if user input is invalid
                Console.WriteLine("Please enter a valid check number in the form of 4 numbers (1234)");
                GetCheckNumber(total);
            }
            return CheckNumber;
        }
    }

}