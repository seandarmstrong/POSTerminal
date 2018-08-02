using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Library;
using System.IO;

namespace POS.Library
{
    public class Menu
    {
        public static void DisplayMainMenu()
        {
            
            var menu = String.Format("{0}\n{1}\n{2}\n{3}",
                "What would you like to do?",
                "1. View wares",
                "2. Check out",
                "3. Leave store");
            Console.WriteLine(menu);
            var userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    DisplayProductMenu();
                    break;

            }

        }

        public static void DisplayProductMenu()
        {
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