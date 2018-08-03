using System;
using POS.Library;
<<<<<<< HEAD
=======
using System.Text.RegularExpressions;
>>>>>>> d7a2bcb5aa239343c717da7c627317e00d454725

namespace RadioShackPOS
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            System.Console.WriteLine("Welcome to Radioshack");
            Menu.DisplayMainMenu();
            
=======
            System.Console.WriteLine("put in some test input");
            var answer = Console.ReadLine();
            var validator = new Validator();
            if (validator.ValidExpDate(answer))
            {
                Console.WriteLine("valid");
            }



            Console.ReadKey();
>>>>>>> d7a2bcb5aa239343c717da7c627317e00d454725
        }
    }
}
