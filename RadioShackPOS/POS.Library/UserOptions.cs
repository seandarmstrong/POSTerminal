using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Library
{
    public class UserOptions
    {
        public static void MainMenueOptions()
        {
            Console.WriteLine(":>");
            var userInput = int.Parse(Console.ReadLine()); //add validation for integer check and/or exception handling

            switch (userInput)
            {
                case 1:
                    Menu.DisplayProductMenu();
                    break;

                case 2:
                    //Checkout();
                    break;

                case 3:
                    Console.WriteLine("Goodbye");
                    break;
            }
        }
}
}
