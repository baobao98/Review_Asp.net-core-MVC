using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMVC.Models
{
    public class ProductModel
    {
        public int id { get; set; }
        public string Name { get; set; }
        public bool Available { get; set; }
        public decimal Price { get; set; }
        public decimal? PromotionPrice { get; set; }
    }
}
