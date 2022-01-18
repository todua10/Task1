using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Product
    {
        public Dictionary<string, double> prices = new Dictionary<string, double>
        {
            ["Кофе"] = 60,
            ["Сок"] = 75,
            ["Какао"] = 100,
            ["Макароны"] = 125,
            ["Пюре"] = 170,
            ["Говяжья котлета"] = 1416,
            ["Куриная котлета"] = 916
        };
        public string Name { get; set; }
        public double Price { get; set; }
        public double Size { get; set; }

        public Product(string name, double size)
        {
            Name = name;
            Size = size;
            Price = prices[name];
        }
        public double GetCost() 
        {
            return Price * Size;
        }
    }
}
