using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task1
{
    abstract class Client
    {
        public int ID { get; set; }
        public bool rightsOfStaff { get; set; }
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

        public abstract void Check();
    }
}
