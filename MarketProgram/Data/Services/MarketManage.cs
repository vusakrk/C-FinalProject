using MarketProgram.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketProgram.Data.Services
{
    public class MarketManage
    {
        public List<Products> Product { get; private set; }
        public List<ProductSale> ProductSales { get; private set; }
        public List<SaleItem> SaleItems { get; private set; }

        public MarketManage()
        {
            Product = new();
            ProductSales = new();
            SaleItems = new();
        }

        public int AddProduct(string Name, double ProductPrice, int Quantity, int Id)
        {
            if (string.IsNullOrEmpty(Name))
                throw new ArgumentNullException("Name");

            if (ProductPrice <= 0)
                throw new ArgumentOutOfRangeException("ProductPrice");
            if (Quantity < 1)
                throw new ArgumentOutOfRangeException("Quantity");
            if (Id < 1)
                throw new ArgumentOutOfRangeException("Id");

            Products product = new();
            product.Name = Name;
            product.ProductPrice = ProductPrice;
            product.Quantity = Quantity;
            product.Id = Id;

            Product.Add(product);
            return product.Id; 
        }

        public void DeleteProduct(int key)
        {
            int index = Product.FindIndex(p => p.Id == key);
                if (index == -1)
                throw new KeyNotFoundException();
            Product.RemoveAt(index);
        }
    }
}
