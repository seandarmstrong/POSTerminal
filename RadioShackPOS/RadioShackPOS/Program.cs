using System;
using POS.Library;
using System.Text.RegularExpressions;

namespace RadioShackPOS
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////// TESTING - MIKE ///////////////////////
            System.Console.WriteLine("put in some test input");
            var answer = Console.ReadLine();
            var validator = new Validator();
            if (validator.ValidExpDate(answer))
            {
                Console.WriteLine("valid");
            }
            ///////////////////////////////////////////////


            Console.ReadKey();
        }
    }
}
