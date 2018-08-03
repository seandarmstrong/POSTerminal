﻿using System;
using System.IO;

namespace POS.Library
{
    public class Menu
    {
        public static void DisplayMainMenu()
        {

            var menu = String.Format("{0}\n{1}\n{2}\n{3}",
                "What would you like to do?",
                "1. View products",
                "2. Check out",
                "3. Leave store");
            Console.WriteLine(menu);
            var userInput = int.Parse(Console.ReadLine()); //add validation for integer check and/or exception handling

            switch (userInput)
            {
                case 1:
                    DisplayProductMenu();
                    break;

            }

        }

        public static void DisplayProductMenu()
        {
            //delete
            StreamReader readProducts = new StreamReader(@"C: \Users\frees\source\repos\POSTerminal\RadioShackPOS\POS.Library\products.txt");
            while (true)
            {
                string line = readProducts.ReadLine();
                if (line == null)
                {
                    break;
                }
                Console.WriteLine(line);
                Console.ReadLine();
            }
        }

        public static void DisplayPaymentMethods()
        {

        }
    }
}