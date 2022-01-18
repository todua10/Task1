using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Drink: Product
    {
        public Dictionary<string, double> pricesOfDrinks = new Dictionary<string, double>
        {
            ["Кофе"] = 60,
            ["Сок"] = 75,
            ["Какао"] = 100
        };
        public double Size { get; set; }
        public Drink(string name, double size) : base(name)
        {
            Size = size;
            Price = pricesOfDrinks[name];
        }

        public override double GetCost()
        {
            return Price * Size;
        }
    }
}
