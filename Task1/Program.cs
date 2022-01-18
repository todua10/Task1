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

            Product juice025 = new Product("Сок", 0.25);
            Product juice05 = new Product("Сок", 0.5);
            Product juice1 = new Product("Сок", 1);
            Product cocoa025 = new Product("Какао", 0.25);
            Product noodle = new Product("Макароны", 0.2);
            Product mashedPotatoes = new Product("Пюре", 0.2);
            Product cutletChicken = new Product("Куриная котлета", 0.06);
            Product cutletBeef = new Product("Говяжья котлета", 0.06);

            first.AddToOffer(juice025);
            first.AddToOffer(noodle);
            first.AddToOffer(cutletBeef);
            leva.ConfirmPurchase(first.Purchase(), first.rightsOfStaff);
            table1.isBusy = true;

            second.AddToOffer(juice05);
            second.AddToOffer(mashedPotatoes);
            second.AddToOffer(cutletChicken);
            leva.ConfirmPurchase(second.Purchase(), second.rightsOfStaff);
            table2.isBusy = true;
            
            first.Check();
            second.Check();
            
            leva.OffersOfStudents();
            leva.OffersOfStaff();

            Console.ReadLine();
        }
    }
}
