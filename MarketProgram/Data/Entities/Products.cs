using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketProgram.Data.Entities
{
    public class Products 
    {
        public string Name { get; set; }
        public double ProductPrice { get; set; }
        public int Quantity { get; set; }
        public int Id { get; set; }
    }
}
