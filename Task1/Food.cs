using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Food: Product
    {
        public Dictionary<string, double> pricesOfFoods = new Dictionary<string, double>
        {
            ["Макароны"] = 125,
            ["Пюре"] = 170,
            ["Говяжья котлета"] = 1416,
            ["Куриная котлета"] = 916
        };
        public double Weight { get; set; }
        public Food(string name, double weight) : base(name)
        {
            Weight = weight;
            Price = pricesOfFoods[name];
        }
        public override double GetCost()
        {
            return Price * Weight;
        }
    }
}
