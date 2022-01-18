using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Cashier
    {
        private List<List<Product>> offers = new List<List<Product>>();
        public List<List<Product>> Offers { get { return offers; } }

        public string NameOnBadge { get; set; }
        public Cashier(string name)
        {
            NameOnBadge = name;
        }
        public void ConfirmPurchase(List<Product> offer)
        {
            offers.Add(offer);
        }
        public void OffersOfClients()
        {
            Console.WriteLine("\nЗаказы клиентов: \n");
            for (int i = 0; i < Offers.Count; i++)
            {
                Console.WriteLine($"Заказ №{i + 1}: \n");
                for (int j = 0; j < Offers[i].Count; j++)
                {
                    Console.WriteLine($"{Offers[i][j].Name} - {Offers[i][j].GetCost()}");
                }
                Console.WriteLine();
            }
        }
    }
}
