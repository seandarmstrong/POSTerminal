using System;

namespace POS.Library
{
    public class Check
    {
        // ctor
        public Check() { }
        // you guessed it......its a validator!
        Validator validaor = new Validator();
        public string Transaction()
        {
            // ask for and store user checknumber
            Console.WriteLine("Please enter a check number (0000): ");
            var checkNumber = Console.ReadLine();
            // validate user input
            if (!validaor.ValidCheckNumber(checkNumber))
            {
                // call the method recursively if user input is invalid
                Console.WriteLine("Please enter a valid check number in the form of 4 numbers (1234)");
                Transaction();
            }
            // fancy pants success color and message
            Console.ForegroundColor = ConsoleColor.Green;
            return "Your check has been processed!";
        }
    }

}