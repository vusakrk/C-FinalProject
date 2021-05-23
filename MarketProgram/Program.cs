using MarketProgram.Data.Services;
using System;

namespace MarketProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = new EasyConsole.Menu()
                .Add("Products", () => MenuService.DisplayProducts())
                .Add("bar", () => Console.WriteLine("bar selected"));
            menu.Display();
        }
    }
}
