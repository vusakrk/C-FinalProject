using MarketProgram.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketProgram.Data.Common;
using MarketProgram.Data.Enums;

namespace MarketProgram.Data.Services
{
    public class MarketManage : IMarketable
    {
        public List<Products> Product { get; set; }
        public List<ProductSales> ProductSales { get; set; }
        //public List<SaleItem> SaleItems { get;  set; }

        public MarketManage()
        {
            Product = new();
            ProductSales = new();
            //SaleItems = new();
        }

        public int AddProduct(string Name, double ProductPrice, int Quantity,ProductsCategory category)
        {
            if (string.IsNullOrEmpty(Name))
                throw new ArgumentNullException("Name","product's name is empty");
            if (ProductPrice == 0)
                throw new ArgumentOutOfRangeException("ProductPrice", "pRODUCT'S price is wrong");
            if (ProductPrice < 0)
                throw new ArgumentOutOfRangeException("ProductPrice","pRODUCT'S price can't less than 0");
            if (Quantity == 0)
                throw new ArgumentOutOfRangeException("Quantity", "pRODUCT'S count is wrong");
            if (ProductPrice < 1)
                throw new ArgumentOutOfRangeException("Quantity", "pRODUCT'S count can't less than 0");

            if (category == ProductsCategory.xeta)
                throw new ArgumentNullException("category", "pRODUCT'S category is wrong");

            Products product = new();
            product.Name = Name;
            product.ProductPrice = ProductPrice;
            product.Quantity = Quantity;
            product.Category = category;
            //product.Id = Id;

            Product.Add(product);
            return product.No;
        }

        public void EditProduct(int Id,string name,double ProductPrice,int Quantity,string category)
        {
           
            var index = Product.FindIndex(x => x.No == Id);
            Product.RemoveAt(index);
            Products products = new();
            products.Name = name;
            products.ProductPrice = ProductPrice;
            //products.Id = newId;
            products.Quantity = Quantity;
            Product.Add(products);                    
        }
        public void DeleteProduct(int key)
        {
            int index = Product.FindIndex(d => d.No == key);
            if (index == -1)
                throw new KeyNotFoundException();
            Product.RemoveAt(index);
        }

        //public List<Products> GetProducts()
        //{
        //    var distinctList = Product.Select(x => new { x.Id, x.Name, Quantity = Product.Count(y => y.Id == x.Id), x.ProductPrice }).Distinct();
        //    return distinctList.Select(x => new Products { Id = x.Id, Name = x.Name, Quantity = x.Quantity, ProductPrice = x.ProductPrice }).ToList();
        //}

        public List<Products> DisplayAllProducts()
        {
            return Product.ToList();
        }



        public List<Products> SearchCategoryForProduct(ProductsCategory category)
        {
            return Product.Where(x => x.Category == category).ToList();

        }
        public List<Products> SearchPriceRangeProduct(int minprice,int maxprice)
        {
            //if (products.Count==0)
            //{
            //    throw new InvalidOperationException("empty list");
            //}
            //int maxprice = int.MinValue;
            var price = Product.FindAll(x => x.ProductPrice >= minprice && x.ProductPrice <= maxprice);

            return price;

        }
        public List<Products> SearchNameForProduct(string productName)
        {
            return Product.Where(i=>i.Name.Contains(productName)).ToList();
        }

        public int AddSales(int No, double Price,string SaleItem,DateTime date)
        {
            if (No == 0)
                throw new ArgumentNullException("No");
            if (string.IsNullOrEmpty(SaleItem))
                throw new ArgumentNullException("SaleItem");

            ProductSales productSale = new();
            productSale.No = No;
            //productSale.SaleItems. = SaleItem;
            ProductSales.Add(productSale);
            return productSale.No;

            

        }
        public static void ReturnSale()
        {

        }
        public void DeleteSales(int no)
        {
            int index = ProductSales.FindIndex(d => d.No == no);
            if (index == -1)
                throw new KeyNotFoundException();
            ProductSales.RemoveAt(index);
        }
        public List<ProductSales> DisplayAllSale()
        {
            return ProductSales;
        }
        public void DisplayDateRangeSale(DateTime date)
        {
            var DateList = ProductSales.Where(x => x.Date == date).ToList();
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
    }
}
