using System;

namespace POS.Library
{
    public class UserOptions
    {
        public static void GetMainMenuResponse()
        {
            Console.Write("Please select from the main menu: ");
            int userInput = Validator.ValidateUserInput(Console.ReadLine());
            

            switch (userInput)
            {
                case 1:
                    Menu.DisplayProductMenu();
                    do
                    {
                        Order.BuildOrderList(GetProductResponse(), GetProductQuantity());
                        Console.Write("Would you like to add another product to the cart?(y/n): ");
                    } while (ContinueAction(Console.ReadLine().Trim().ToLower()));
                    break;

                case 2:

                    if (Order.GetOrderListCount() > 0)
                    {
                        Order.ViewOrderCart();
                    }
                    else
                    {
                        Console.WriteLine("There doesn't appear to anything in the cart. Please add products to view cart.");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                    }
                    break;

                case 3:
                    Menu.DisplayPayment();
                    Order.ResetOrderList();
                    break;
                case 4:
                    Order.ResetOrderList();
                    break;
                case 5:
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
            var selection = Convert.ToInt32(Console.ReadLine().Trim());
            if (selection > 0 && selection <= ProductList.GetProductListCount())
            {
                return selection;
            }
            else
            {
                Console.WriteLine("That product number does not exist. Please try again.\n");
                return GetProductResponse();
            }
        }

        public static int GetProductQuantity()
        {
            Console.Write("Enter the number of this product you would like to add to order: ");
            return Convert.ToInt32(Console.ReadLine().Trim());
        }

        public static bool ContinueAction(string input)
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
                    return ContinueAction(Console.ReadLine().ToLower().Trim());
                }
            }
        }
        public static void GetPaymentOptions()
        {
            var grandTotal = Order.CheckoutDisplay();
            var userInput = int.Parse(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    var cash = new Cash();
                    cash.Transaction(grandTotal);
                    break;
                case 2:
                    var check = new Check();
                    check.Transaction(grandTotal);
                    break;
                case 3:
                    var cc = new CreditCard();
                    cc.Transaction(grandTotal);
                    break;
                default:
                    Console.WriteLine("Sorry but that is not a payment option.");
                    GetPaymentOptions();
                    break;
            }

        }
    }
}
