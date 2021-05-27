using ConsoleTables;
using MarketProgram.Data.Entities;
using MarketProgram.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketProgram.Data.Services
{
    public static class MenuService
    {
        #region
        //Product operations
        static MarketManage marketManage = new();
        //public static void AddProduct(Products product)
        //{
        //    Console.WriteLine("Insert Product Name");
        //    string Name = Console.ReadLine();
        //    Console.WriteLine("Insert Product Price");
        //    string PriceStr = Console.ReadLine();
        //    Console.WriteLine("Insert Quantity");
        //    string QuantityStr = Console.ReadLine();
        //    Console.WriteLine("Insert Id");
        //    string IdStr = Console.ReadLine();

        //    try
        //    {
        //        marketManage.AddProduct(Name, double.Parse(PriceStr), int.Parse(QuantityStr), int.Parse(IdStr));
        //        Console.WriteLine("Product Inserted");
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("Please Try Again");
        //        Console.WriteLine(e.Message);
        //    }
        //}

        internal static void AddProductMenu()
        {
            Console.WriteLine("Enter the name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the price");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the quantity");
            int quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Category");
            Enum.TryParse<ProductsCategory>(Console.ReadLine(), true, out ProductsCategory category);
            //Console.WriteLine($"default category {category}");


            try
            {
                marketManage.AddProduct(name, price, quantity, category);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void EditProductMenu()
        {
            Console.WriteLine("Enter ID");
            int Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter ProductPrice");
            double ProductPrice = double.Parse(Console.ReadLine());
            //int newId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Quantity");
            int Quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Category");
            string Category = Console.ReadLine();
            try
            {
                marketManage.EditProduct(Id, name, ProductPrice, Quantity, Category);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

        }
        internal static void DeleteProduct()
        {
            Console.WriteLine("Enter Id ");
            int Id = int.Parse(Console.ReadLine());
            try
            {
                marketManage.DeleteProduct(Id);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }


  
        public static void DisplayAllProduct()
        {
            try
            {
                marketManage.DisplayAllProducts();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            var table = new ConsoleTable("Id", "Name", "ProductPrice", "Quantity", "Category");
            foreach (var products in marketManage.Product)
            {
                table.AddRow(products.No, products.Name, products.ProductPrice.ToString("#.00"), products.Quantity, products.Category);
            }
            table.Write();
            Console.WriteLine();
            
        }
        public static void SearchCategoryForProduct2()
        {
            Console.WriteLine("Enter Category");
            Enum.TryParse(Console.ReadLine(), false, out ProductsCategory category);
            try
            {
                marketManage.SearchCategoryForProduct(category);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            var table = new ConsoleTable("Id", "Name", "ProductPrice", "Quantity", "Category");
            foreach (var products in marketManage.SearchCategoryForProduct(category))
            {
                table.AddRow(products.No, products.Name, products.ProductPrice.ToString("#.00"), products.Quantity, products.Category);
            }
            table.Write();
            Console.WriteLine();


        }
        public static void SearchPriceRangeProduct()
        {
            
            Console.WriteLine("Enter min value");
            int minprice = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter max value");
            int maxprice = int.Parse(Console.ReadLine());
            try
            {
                marketManage.SearchPriceRangeProduct(minprice, maxprice);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
            var table = new ConsoleTable("Id", "Name", "ProductPrice", "Quantity", "Category");
            foreach (var products in marketManage.SearchPriceRangeProduct(minprice,maxprice))
            {
                table.AddRow(products.No, products.Name, products.ProductPrice.ToString("#.00"), products.Quantity, products.Category);
            }
            table.Write();
            Console.WriteLine();

        }
        public static void SearchNameForProduct()
        {
            Console.WriteLine("Plase enter name : ");
            string name = Console.ReadLine();

            try
            {
                marketManage.SearchNameForProduct(name);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            var table = new ConsoleTable("Id", "Name", "ProductPrice", "Quantity", "Category");
            foreach (var products in marketManage.SearchNameForProduct(name))
            {
                table.AddRow(products.No, products.Name, products.ProductPrice.ToString("#.00"), products.Quantity, products.Category);
            }
            table.Write();
            Console.WriteLine();

        }

        #endregion



        #region
        //Sale operations

        public static void AddSale()
        {

        }
        public static void ReturnSale()
        {

        }
        public static void DeleteSale()
        {

        }
        public static void DisplayAllSale()
        {

        }
        public static void DisplayDateRangeSale()
        {

        }
        public static void DisplayMoneyRangeSale()
        {

        }
        public static void DisplayDateSale()
        {

        }
        public static void DisplayNoSale()
        {

        }

        //internal static void AddProduct()
        //{
        //    throw new NotImplementedException();
        //}

        #endregion








        public static void DisplayProductSales()
        {
            var table = new ConsoleTable("No", "Price", "SaleItem", "Date");
            foreach (var productSale in marketManage.ProductSales)
            {
                table.AddRow(productSale.No, productSale.Price.ToString("#.00"), productSale.SaleItems.Sum(i => i.Quantity), productSale.Date);
            }
            table.Write();
            Console.WriteLine();
        }
        //public static void DisplaySaleItem()
        //{
        //    var table = new ConsoleTable("No", "Product", "Quantity");
        //    foreach (var saleItem in marketManage.ProductSales.)
        //    {
        //        table.AddRow(saleItem.No, saleItem.Product, saleItem.Quantity);
        //    }
        //    table.Write();
        //    Console.WriteLine();
        //}

    }
}
