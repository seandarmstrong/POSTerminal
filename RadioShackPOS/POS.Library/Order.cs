using System;
using System.Collections.Generic;
using System.IO;

namespace POS.Library
{
    public class Order
    {
        private float _subTotal { get; set; }
        private float _salesTax = .06f;
        private float _grandTotal { get; set; }

        public List<Products> orderList = new List<Products>();

        public static void ReadList()
        {
            string[] str = System.IO.File.ReadAllText(@"C:\Users\armst\Documents\Grand_Circus\POS_Terminal\POSTerminal\RadioShackPOS\POS.Library.products.txt")
                .Split(new string[] { Environment.NewLine },
                    StringSplitOptions.None);
        }
    }
}