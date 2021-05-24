using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketProgram.Data.Services
{
    public static class MenuService
    {
        static MarketManage marketManage = new();
        public static void AddProductMenu()
        {
            Console.WriteLine("Insert Product Name");
            string Name = Console.ReadLine();
            Console.WriteLine("Insert Product Price");
            string PriceStr = Console.ReadLine();
            Console.WriteLine("Insert Quantity");
            string QuantityStr = Console.ReadLine();
            Console.WriteLine("Insert Id");
            string IdStr = Console.ReadLine();

            try
            {
                marketManage.AddProduct(Name, double.Parse(PriceStr), int.Parse(QuantityStr), int.Parse(IdStr));
                Console.WriteLine("Product Inserted");
            }
            catch (Exception e)
            {
                Console.WriteLine("Please Try Again");
                Console.WriteLine(e.Message);
            }
        }
        public static void EditProduct()
        {

        }
        public static void DeleteProduct()
        {

        }
        public static void DisplayAllProduct()
        {

        }               
        public static void SearchCategoryForProduct()
        {

        }
        public static void SearchPriceRangeProduct()
        {


        }
        public static void SearchNameForProduct()
        {

        }
        public static void DisplayForProduct()
        {

        }
        public static void DisplayPriceRangeProduct()
        {

        }
        public static void SearchProduct()
        {

        }

        //public static void DisplayProductSales()
        //{
        //    var table = new ConsoleTable("No", "Price", "SaleItem", "Date");
        //    foreach (var productSale in marketManage.ProductSales)
        //    {
        //        table.AddRow(productSale.No, productSale.Price.ToString("#.00"), productSale.SaleItem, productSale.Date);
        //    }
        //    table.Write();
        //    Console.WriteLine();
        //}
        //public static void DisplaySaleItem()
        //{
        //    var table = new ConsoleTable("No", "Product", "Quantity");
        //    foreach (var saleItem in marketManage.SaleItems)
        //    {
        //        table.AddRow(saleItem.No, saleItem.Product, saleItem.Quantity);
        //    }
        //    table.Write();
        //    Console.WriteLine();
        //}

    }
}
