using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task1
{
    class Client
    {
        public int ID { get; set; }
        private List<Product> offer = new List<Product>();
        public List<Product> Offer { get { return offer; } }

        private double sum;
        public double Sum { get { return sum; } }
        public Client(int id)
        {
            ID = id;
        }
        public void AddToOffer(Product product)
        {
            offer.Add(product);
            sum += product.GetCost();
        }
        
        public List<Product> Purchase()
        {
            return offer;
        }

        public void Check()
        {
            Console.WriteLine($"Чек об оплате клиента {ID}: \n");
            for (int i = 0; i < Offer.Count; i++)
            {
                Console.WriteLine($"{Offer[i].Name} - {Offer[i].GetCost()}");
            }
            Console.WriteLine($"Итого - {Sum}\n");
        }
    }
}
