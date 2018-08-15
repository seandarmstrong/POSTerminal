using Microsoft.VisualBasic.FileIO;
using POS.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace POS.Library
{
    public class ProductList
    {
        //constructor
        public ProductList()
        {

        }

        //this function pulls the text file and parses the CSV to build the product list to return it
        public List<IProductModel> GetProducts()
        {
            List<IProductModel> productList = new List<IProductModel>();
            string[] fields;
            var executingPath = Directory.GetCurrentDirectory();
            var filePath = Path.Combine(executingPath, "Content", "products.csv");
            try
            {
                using (TextFieldParser parser = new TextFieldParser(filePath))
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

        //this function returns the list of the product list
        public int GetProductListCount()
        {
            var listOfProducts = this.GetProducts();
            return listOfProducts.Count;
        }
    }
}