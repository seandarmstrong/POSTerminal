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
                    do
                    {
                        Order.BuildOrderList(GetProductResponse(), GetProductQuantity());
                        Console.Write("Would you like to add another product to the cart?(y/n): ");
                    } while (AddAnother(Console.ReadLine().Trim().ToLower()));
                    break;

                case 2:

                    Order.ViewOrderCart();
                    break;

                case 3:
                    Menu.DisplayPayment();
                    //Console.WriteLine("Payment options will go here");
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

        public static int GetProductQuantity()
        {
            Console.Write("Enter the number of this product you would like to add to order: ");
            return Convert.ToInt32(Console.ReadLine().Trim());
        }

        public static bool AddAnother(string input)
        {
            if (input == "yes" || input == "y")
            {
                return true;
            }
            else if (input == "no" || input == "n")
            {
                return false;
            }
            else
            {
                {
                    Console.WriteLine("That is not a valid response. Please try again.");
                    return AddAnother(Console.ReadLine().ToLower().Trim());
                }
            }
        }
        public static void GetPaymentOptions()
        {
            var userInput = int.Parse(Console.ReadLine());
            switch(userInput)
            {
                case 1:
                    var grandTotal = Order.CheckoutDisplay();
                    var cash = new Cash();
                    cash.Transaction(grandTotal);
                    break;
                default:
                    break;
            }

        }
    }
}
