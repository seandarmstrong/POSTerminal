using POS.Library.Enums;
using System;

namespace POS.Library
{
    public class UserOption
    {
        public Validator validate = new Validator();
        public Order order = new Order();

        public bool GetMainMenuResponse()
        {
            Console.Write("Please select from the main menu: ");

            int userInput = validate.ValidateUserInput(Console.ReadLine());
            switch (userInput)
            {
                case (int)MainMenu.ProductList:
                    HandleAddProduct();
                    break;
                case (int)MainMenu.ShowCart:
                    HandleViewCart();
                    break;
                case (int)MainMenu.Checkout:
                    HandleCheckout();
                    break;
                case (int)MainMenu.EmptyCart:
                    order.ResetOrderList();
                    break;
                case (int)MainMenu.Quit:
                    Console.WriteLine("Goodbye");
                    return false;
                default:
                    Console.WriteLine("I'm sorry, that is not a valid response.");
                    break;
            }
            return true;
        }

        public void HandleAddProduct()
        {
            var menu = new Menu();
            var listCount = order.Catalog.GetProductListCount();
            menu.DisplayProductMenu();
            do
            {
                if (listCount <= 0)
                {
                    Console.WriteLine(
                        "The file was not found at that location. Please call Technical Support @ 012-345-6789.");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.Write("Enter the product number that you would like to add to the order: ");
                    var productNumber = validate.ValidateProductResponse(Console.ReadLine());
                    Console.Write("Enter the number of this product you would like to add to order: ");
                    var quantity = GetProductQuantity(Console.ReadLine());
                    order.BuildOrderList(productNumber, quantity);
                    order.ShowLineTotal(productNumber, quantity);
                    Console.Write("Would you like to add another product to the cart?(y/n): ");
                }
            } while (ContinueAction(Console.ReadLine().Trim().ToLower()));

        }

        public void HandleViewCart()
        {
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
        }

        public void HandleCheckout()
        {
            var menu = new Menu();
            if (order.GetOrderListCount() > 0)
            {
                order.CheckoutDisplay();
                menu.DisplayPayment();
                order.ResetOrderList();
            }
            else
            {
                Console.WriteLine("There doesn't appear to anything in the cart. Please add products to checkout.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }

        public int GetProductQuantity(string input)
        {
            int quantity = validate.ValidateUserInput(input);
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

        public bool ContinueAction(string input)
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
        public void GetPaymentOptions()
        {
            var receipt = new Receipt();
            var receiptForOrder = new Order();
            var order = new Order();
            var grandTotal = order.GetGrandTotal();
            var userInput = validate.ValidateUserInput(Console.ReadLine());
            switch (userInput)
            {
                case (int)PayOptions.Cash:
                    var cash = new Cash();
                    cash.Transaction(grandTotal);
                    break;
                case (int)PayOptions.Check:
                    var check = new Check();
                    check.Transaction(grandTotal);
                    break;
                case (int)PayOptions.CreditCard:
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
