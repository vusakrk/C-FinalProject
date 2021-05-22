using MarketProgram.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketProgram.Data.Entities
{
    public class ProductSale: BaseEntity
    {   
        public int No { get; set; }
        public double Price { get; set; }
        public string SaleItem { get; set; }
        public DateTime Date { get; set; }

    }
}
