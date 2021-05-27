using MarketProgram.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketProgram.Data.Services
{
    public static class SubServiceMenu
    {
        static MarketManage marketManage = new();

        public static void AddSales()
        {
            Console.WriteLine("Insert No");
            string No = Console.ReadLine();
            Console.WriteLine("Insert Price");
            string Price = Console.ReadLine();
            Console.WriteLine("Insert Sale Item");
            string SaleItem = Console.ReadLine();
            Console.WriteLine("Insert Date");
            string date = Console.ReadLine();
            try
            {
                marketManage.AddSales(int.Parse(No), double.Parse(Price), SaleItem, DateTime.Parse(date));
                Console.WriteLine("Add Sale Inserted");

            }
            catch (Exception e)
            {
                Console.WriteLine("Please Try Again");
                Console.WriteLine(e.Message);
            }
        }
        public static void ReturnSales()
        {

        }

        public static void DeleteSales(ProductSales productSale)
        {
            
        }

        public static void DisplayAllSales()
        {

        }

        public static void DisplayForDateRangeSales()
        {

        }

        public static void DisplayForPriceRangeSales()
        {

        }

        public static void DisplayDateSales()
        {

        }

        public static void DisplaySalesForNo()
        {

        }
    }
}
