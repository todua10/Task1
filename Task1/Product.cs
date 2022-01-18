using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    abstract class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Product(string name)
        {
            Name = name;
        }
        public abstract double GetCost();
    }
}
