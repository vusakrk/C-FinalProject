using EasyConsole;
using MarketProgram.Data.Services;
using System;

namespace MarketProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = new Menu()
                .Add("Products", () => MenuService.DisplayForProduct())
                .Add("Add Products", () => MenuService.AddProductMenu())
                .Add("AddSales", () => SubServiceMenu.AddSales())
                .Add("EditProduct", () => MenuService.EditProduct())
                .Add("DeleteProduct", () => MenuService.DeleteProduct())
                .Add("DisplayAllProduct", () => MenuService.DisplayAllProduct())
                .Add("DisplayForProduct", () => MenuService.DisplayPriceRangeProduct())
                .Add("DisplayPriceRangeProduct", () => MenuService.SearchProduct());
                //.Add("bar", () => Console.WriteLine("bar selected"));
            menu.Display();
        }
    }
}
