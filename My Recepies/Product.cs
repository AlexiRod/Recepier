using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace My_Recepies
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Kkal { get; set; }
        public Product() { }
        public Product(string name, decimal kkal)
        {
            Name = name;
            Kkal = kkal;
        }

    }
}
