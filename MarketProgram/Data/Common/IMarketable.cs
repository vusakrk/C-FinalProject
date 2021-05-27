using MarketProgram.Data.Entities;
using MarketProgram.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MarketProgram.Data.Common
{
    public interface IMarketable
    {
        public List<Products> Product { get; set; }
        public List<ProductSales> ProductSales { get; set; }


        //////public List<SaleItem> SaleItems { get; set; }

        //public void AddSale();
        //public void ReturnSale();
        //public void AllReturnSale();
        //public void DisplayDateRangeSale();
        //public void DisplayDateSale();
        //public void DisplayMoneyRangeSale();
        //public void DisplayNoSale();
        public int AddProduct(string Name, double ProductPrice, int Quantity, ProductsCategory category);
        public void EditProduct(int Id, string name, double ProductPrice, int Quantity, string category);
        //public void DisplayCategoryProduct();
        //public void DisplayMoneyRangeProduct();
        //public void DisplaySearchProduct();
    }
}
