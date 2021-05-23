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
        public static void DisplayProducts()
        {
            var table = new ConsoleTable("Name", "ProductPrice", "Quantity", "Id");
            foreach (var products in marketManage.Product)
            {
                table.AddRow(products.Name, products.ProductPrice.ToString("#.00"), products.Quantity, products.Id);
            }
            table.Write();
            Console.WriteLine();
        }

    }
}
