using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Product
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
    public class ProductEnum : IEnumerable
    {

        private Product[] _productEnum;

        public ProductEnum(Product[] prArray)
        {
            _productEnum = new Product[prArray.Length];

            for (int i = 0; i < prArray.Length; i++)
            {
                _productEnum[i] = prArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public ProductEnumerator GetEnumerator()
        {
            return new ProductEnumerator(_productEnum);
        }
    }

    public class ProductEnumerator : IEnumerator
    {
        public Product[] _productEnum;

        int position = -1;

        public ProductEnumerator(Product[] list)
        {
            _productEnum = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _productEnum.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get 
            {
                return Current;
            }
        }

        public Product Current
        {
            get 
            {
                try
                {
                    return _productEnum[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
