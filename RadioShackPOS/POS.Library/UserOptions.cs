using System;

namespace POS.Library
{
    public class UserOptions
    {
        public static void GetMainMenuResponse()
        {
            Console.Write("Please select from the main menu: ");
            var userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    Menu.DisplayProductMenu();
                    Order.BuildOrderList(GetProductResponse());
                    break;

                case 2:
                    Order.ViewOrderCart();
                    break;

                case 3:
                    Menu.DisplayPaymentMethods();
                    break;
                case 4:
                    Console.WriteLine("Goodbye");
                    break;
                default:
                    Console.WriteLine("I'm sorry, that is not a valid response.");
                    break;
            }
        }

        public static int GetProductResponse()
        {
            Console.Write("Enter the product number that you would like to add to the order: ");
            return Convert.ToInt32(Console.ReadLine().Trim());
        }
    }
}
