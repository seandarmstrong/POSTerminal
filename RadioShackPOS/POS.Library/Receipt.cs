using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Library;

namespace POS.Library
{
    class Receipt
    {
        public static void DisplayReceipt()
        {
            Console.WriteLine("Thank you for shopping at RadioShack");
            Order.ReceiptDisplay();
        }
    }
}
