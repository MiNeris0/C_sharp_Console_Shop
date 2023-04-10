using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Shop
{
    public class Product
    {
        public string ProductName { get; set; }
        public ProductType Type { get; set; }
        public string ProductDescription { get; set; }
        public int Price { get; set; }
        public int ProductId { get; set; }
    }
}
