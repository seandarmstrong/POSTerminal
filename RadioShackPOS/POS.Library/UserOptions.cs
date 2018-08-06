using System;

namespace POS.Library
{
    public class UserOptions
    {
        public bool GetMainMenuResponse()
        {
            Console.Write("Please select from the main menu: ");
            int userInput = Validator.ValidateUserInput(Console.ReadLine());
            var order = new Order();

            switch (userInput)
            {
                case 1:
                    Menu.DisplayProductMenu();
                    do
                    {
                        Console.Write("Enter the product number that you would like to add to the order: ");
                        var productNumber = GetProductResponse(Console.ReadLine());
                        Console.Write("Enter the number of this product you would like to add to order: ");
                        var quantity = GetProductQuantity(Console.ReadLine());
                        order.BuildOrderList(productNumber, quantity);
                        order.ShowLineTotal(productNumber, quantity);
                        Console.Write("Would you like to add another product to the cart?(y/n): ");
                    } while (ContinueAction(Console.ReadLine().Trim().ToLower()));

                    break;

                case 2:

                    if (order.GetOrderListCount() > 0)
                    {
                        order.ViewOrderCart();
                    }
                    else
                    {
                        Console.WriteLine("There doesn't appear to anything in the cart. Please add products to view cart.");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                    }

                    break;

                case 3:
                    if (order.GetOrderListCount() > 0)
                    {
                        order.CheckoutDisplay();
                        Menu.DisplayPayment();
                        order.ResetOrderList();
                    }
                    else
                    {
                        Console.WriteLine("There doesn't appear to anything in the cart. Please add products to checkout.");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                    }

                    break;
                case 4:
                    order.ResetOrderList();
                    break;
                case 5:
                    Console.WriteLine("Goodbye");
                    return false;
                default:
                    Console.WriteLine("I'm sorry, that is not a valid response.");
                    break;
            }

            return true;
        }

        public static int GetProductResponse(string input)
        {
            var product = new ProductList();
            var selection = Validator.ValidateUserInput(input);
            if (selection > 0 && selection <= product.GetProductListCount())
            {
                return selection;
            }
            else
            {
                Console.Write("That product number does not exist. Please try again:");
                return GetProductResponse(Console.ReadLine());
            }
        }

        public static int GetProductQuantity(string input)
        {
            int quantity = Validator.ValidateUserInput(input);
            if (quantity > 0)
            {
                return quantity;
            }
            else
            {
                Console.Write("The quantity must be greater than 0. Please try again: ");
                return GetProductQuantity(Console.ReadLine().Trim());
            }

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
            var order = new Order();
            var grandTotal = order.GetGrandTotal();
            var userInput = Validator.ValidateUserInput(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    var cash = new Cash();
                    cash.Transaction(grandTotal);
                    Receipt.DisplayReceipt();
                    break;
                case 2:
                    var check = new Check();
                    check.Transaction(grandTotal);
                    Receipt.DisplayReceipt();
                    break;
                case 3:
                    var cc = new CreditCard();
                    cc.Transaction(grandTotal);
                    Receipt.DisplayReceipt();
                    break;
                default:
                    Console.WriteLine("Sorry but that is not a payment option.");
                    GetPaymentOptions();
                    break;
            }
        }
    }
}
