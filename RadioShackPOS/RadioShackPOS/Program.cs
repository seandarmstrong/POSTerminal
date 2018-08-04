using POS.Library;
using POS.Library.Transactions;
using POS.Library.Products;
using System;

namespace RadioShackPOS
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine("Welcome to Radioshack");
            //Menu.DisplayMainMenu();
            //System.Console.WriteLine("put in some test input");
            //var answer = Console.ReadLine();
            //var validator = new Validator();
            //if (validator.ValidExpDate(answer))
            //{
            //    Console.WriteLine("valid");
            //}
            //Console.ForegroundColor = ConsoleColor.White;
            ////////// TESTING - MIKE ///////////////////////////
            // CASH METHOD IS HERE IF YOU WANT TO TEST IT - hard coded total for testing
            //float total = 100.00f;
            //var cash = new Cash(total);
            //cash.Transaction(total);
            //CREDIT CARD METHOD IS HERE IF YOU WANT TO TEST IT
            //var creditCard = new CreditCard(total);
            //creditCard.Transaction(total);
            //CHECK METHOD IS HERE IF YOU WANT TO TEST IT
            //var check = new Check(total);
            //check.Transaction(total);
            var GalaxyS9 = new Phone("Galaxy S9", "To infinity and beyond!!", 999.99f);
            Console.WriteLine($"{GalaxyS9.Name} - {GalaxyS9.Description} - ${GalaxyS9.Price} Department: {GalaxyS9.Category}-{GalaxyS9.SubCategory}");

            var cart = new ProductList();
            var test = cart.BuildList();
            foreach (var product in test)
            {
                Console.WriteLine($"{product.Name} - {product.Category} - {product.Price} - {product.Description}");

            }
            Console.ReadKey();

            /////////////// END TESTING //////////////////////////

        }
    }
}
