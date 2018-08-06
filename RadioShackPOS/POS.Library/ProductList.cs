using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using POS.Library.Interfaces;

namespace POS.Library
{
    public class ProductList
    {
        // MIKE PATH .txt
        private readonly string mikePath = @"C:\Users\Mozzey\GrandCircus\Midterm\POSTerminal\RadioShackPOS\POS.Library\products.csv";
        readonly string seanPath = @"C:\Users\armst\Documents\Grand_Circus\POS_Terminal\POSTerminal\RadioShackPOS\POS.Library\products.csv";
        readonly string bradPath = @"C:\Users\frees\source\repos\POSTerminal\RadioShackPOS\POS.Library\products.csv";

        public static List<IProductModel> productList = new List<IProductModel>();

        public List<IProductModel> BuildList()
        {
            string[] fields;
            try
            {

<<<<<<< HEAD
                using (TextFieldParser parser = new TextFieldParser(bradPath))
=======
                using (TextFieldParser parser = new TextFieldParser(mikePath))
>>>>>>> master


                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");
                    while (!parser.EndOfData)
                    {
                        fields = parser.ReadFields();
                        productList.Add(new Product(fields[0], fields[1], Convert.ToSingle(fields[2]), fields[3]));
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file was not found at that location. Please specify another location.");
            }

            return productList;
        }

        public static int GetProductListCount()
        {
            return productList.Count;
        }
    }
}