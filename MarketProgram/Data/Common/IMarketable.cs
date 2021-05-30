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

        public void AddSale(int No, double Price, string SaleItem, DateTime date);
        //public void ReturnSale();
        public void DisplayAllSale();
        //public void DisplayDateRangeSale();
        //public void DisplayDateSale();
        //public void DisplayMoneyRangeSale();
        //public void DisplayNoSale();
        public int AddProduct(string Name, double ProductPrice, int Quantity, ProductsCategory category);
        public void EditProduct(int Id, string name, double ProductPrice, int Quantity, string category);
        public void DeleteProduct(int key);
        public List<Products> DisplayAllProducts();
        public List<Products> SearchCategoryForProduct(ProductsCategory category);
        public List<Products> SearchPriceRangeProduct(int minprice, int maxprice);
        public List<Products> SearchNameForProduct(string productName);

    }
}
