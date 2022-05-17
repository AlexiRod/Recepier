using System;
using System.Collections.Generic;
using System.Text;

namespace My_Recepies
{
    public class Ingredient
    {
        public Product Product { get; set; }
        public decimal Count { get; set; }
        public decimal Kkal { get; set; }

        public Ingredient(Product product, decimal count)
        {
            Product = product;
            Count = count;
            Kkal = product.Kkal / 100 * Count;
        }
    }
}
