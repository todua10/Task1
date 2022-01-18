using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Cashier
    {
        private List<List<Product>> offersStudents = new List<List<Product>>();
        public List<List<Product>> OffersStudents { get { return offersStudents; } }

        private List<List<Product>> offersStaff = new List<List<Product>>();
        public List<List<Product>> OffersStaff { get { return offersStaff; } }
        public string NameOnBadge { get; set; }
        public Cashier(string name)
        {
            NameOnBadge = name;
        }
        public void ConfirmPurchase(List<Product> offer, bool rightsOfStaff)
        {
            if (rightsOfStaff == false)
                offersStudents.Add(offer);
            else
                offersStaff.Add(offer);
        }
        public void OffersOfStudents()
        {
            Console.WriteLine("\nЗаказы студентов: \n");
            for (int i = 0; i < OffersStudents.Count; i++)
            {
                Console.WriteLine($"Заказ №{i + 1}: \n");
                for (int j = 0; j < OffersStudents[i].Count; j++)
                {
                    Console.WriteLine($"{OffersStudents[i][j].Name} - {OffersStudents[i][j].GetCost()}");
                }
                Console.WriteLine();
            }
        }
        public void OffersOfStaff()
        {
            Console.WriteLine("\nЗаказы персонала: \n");
            for (int i = 0; i < OffersStaff.Count; i++)
            {
                Console.WriteLine($"Заказ №{i + 1}: \n");
                for (int j = 0; j < OffersStaff[i].Count; j++)
                {
                    Console.WriteLine($"{OffersStaff[i][j].Name} - {OffersStaff[i][j].GetCost() * 0.9}");
                }
                Console.WriteLine();
            }
        }
    }
}