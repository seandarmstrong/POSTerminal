using POS.Library;
using System;

namespace RadioShackPOS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            ////////// TESTING - MIKE ///////////////////////
            //var transaction = new POS.Library.Transaction.Transaction();
            //transaction.CCTransaction();
            //var cash = new POS.Library.Cash();
            //var cashTransaction = cash.CashTransaction();
            var creditCard = new POS.Library.CreditCard();
            var ccTransaction = creditCard.CCTransaction();
            Console.WriteLine(ccTransaction);


            Console.ReadKey();
        }
    }
}
