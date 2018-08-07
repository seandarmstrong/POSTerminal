using System;

namespace POS.Library
{
    public class Menu
    {
        private const string LIST_FORMAT = "{0, -4}{1, -20}{2, -25}{3, -10}{4,-5}";

        private static bool running = true;

        public UserOption userOptions = new UserOption();

        //this function sets the boolean variable to determine if the program continues or exits
        public bool IsRunning()
        {
            return running;
        }

        //this function displays the main menu
        public void DisplayMainMenu()
        {

            var menu = String.Format("\n{0}\n{1}\n{2}\n{3}\n{4}\n{5}",
                "What would you like to do?",
                "1. View products",
                "2. View Cart",
                "3. Checkout",
                "4. Reset Shopping Cart",
                "5. Leave POS Terminal");
            Console.WriteLine(menu);
            running = userOptions.GetMainMenuResponse();
        }

        //this function uses an instance of the ProductList class and displays the product list for user selection
        public void DisplayProductMenu()
        {
            var productList = new ProductList();
            var listOfProducts = productList.GetProducts();
            if (listOfProducts.Count > 0)
            {
                Console.WriteLine(LIST_FORMAT, "", "Category", "Name", "Price", "Description");
                Console.WriteLine("");

                foreach (var item in listOfProducts)
                {
                    Console.WriteLine(LIST_FORMAT, (listOfProducts.IndexOf(item) + 1), item.Category, item.Name,
                        item.Price.ToString("C"), item.Description);
                }
            }

        }

        //this function displays the payment options
        public void DisplayPayment()
        {
            var menu = String.Format("\n{0}\n{1}\n{2}\n{3}",
                "How would you like to pay?",
                "1. Cash",
                "2. Check",
                "3. Card");
            Console.WriteLine(menu);
            userOptions.GetPaymentOptions();

        }
    }
}