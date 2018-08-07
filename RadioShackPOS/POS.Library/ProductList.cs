using Microsoft.VisualBasic.FileIO;
using POS.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace POS.Library
{
    public class ProductList
    {
        // MIKE PATH .txt
        private readonly string mikePath = @"C:\Users\Mozzey\GrandCircus\Midterm\POSTerminal\RadioShackPOS\POS.Library\products.csv";
        readonly string seanPath = @"C:\Users\armst\Documents\Grand_Circus\POS_Terminal\POSTerminal\RadioShackPOS\POS.Library\products.csv";
        readonly string bradPath = @"C:\Users\frees\source\repos\POSTerminal\RadioShackPOS\POS.Library\products.csv";
        public ProductList()
        {

        }

        public List<IProductModel> GetProducts()
        {
            List<IProductModel> productList = new List<IProductModel>();
            string[] fields;
            try
            {
                using (TextFieldParser parser = new TextFieldParser(seanPath))
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
                
            }

            return productList;
        }

        public int GetProductListCount()
        {
            var listOfProducts = this.GetProducts();
            return listOfProducts.Count;
        }
    }
}