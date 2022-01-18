using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cashier leva = new Cashier("Левани Т.");
            
            Console.WriteLine($"Кассир: {leva.NameOnBadge}\n");
            
            Student first = new Student(1);
            Staff second = new Staff(2);

            Console.WriteLine($"Клиенты: {first.ID} и {second.ID}\n");

            Table table1 = new Table(1);
            Table table2 = new Table(2);

            Console.WriteLine($"Столики: {table1.Number} и {table2.Number}\n");

            Product[] productsList = new Product[8]
            {
                new Product("Сок", 0.25),
                new Product("Сок", 0.5),
                new Product("Сок", 1),
                new Product("Какао", 0.25),
                new Product("Макароны", 0.2),
                new Product("Пюре", 0.2),
                new Product("Куриная котлета", 0.06),
                new Product("Говяжья котлета", 0.06),

            };
            
            first.AddToOffer(productsList[0]);
            first.AddToOffer(productsList[4]);
            first.AddToOffer(productsList[7]);
            leva.ConfirmPurchase(first.Purchase(), first.rightsOfStaff);
            table1.isBusy = true;

            second.AddToOffer(productsList[1]);
            second.AddToOffer(productsList[5]);
            second.AddToOffer(productsList[6]);
            leva.ConfirmPurchase(second.Purchase(), second.rightsOfStaff);
            table2.isBusy = true;
            
            first.Check();
            second.Check();
            
            leva.OffersOfStudents();
            leva.OffersOfStaff();
            Console.WriteLine();
            ProductEnum ProductList = new ProductEnum(productsList);
            foreach (Product p in ProductList)
                Console.WriteLine($"{p.Name} - {p.GetCost()}");

            Console.ReadLine();
        }
    }
}
