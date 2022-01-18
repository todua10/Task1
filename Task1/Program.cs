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
            
            Client first = new Client(1);
            Client second = new Client(2);

            Console.WriteLine($"Клиенты: {first.ID} и {second.ID}\n");

            Table table1 = new Table(1);
            Table table2 = new Table(2);

            Console.WriteLine($"Столики: {table1.Number} и {table2.Number}\n");

            Drink juice025 = new Drink("Сок", 0.25);
            Drink juice05 = new Drink("Сок", 0.5);
            Drink juice1 = new Drink("Сок", 1);
            Drink cocoa025 = new Drink("Какао", 0.25);
            Food noodle = new Food("Макароны", 0.2);
            Food mashedPotatoes = new Food("Пюре", 0.2);
            Food cutletChicken = new Food("Куриная котлета", 0.06);
            Food cutletBeef= new Food("Говяжья котлета", 0.06);

            first.AddToOffer(juice025);
            first.AddToOffer(noodle);
            first.AddToOffer(cutletBeef);
            leva.ConfirmPurchase(first.Purchase());
            table1.isBusy = true;

            second.AddToOffer(juice05);
            second.AddToOffer(mashedPotatoes);
            second.AddToOffer(cutletChicken);
            leva.ConfirmPurchase(second.Purchase());
            table2.isBusy = true;
            
            first.Check();
            second.Check();
            leva.OffersOfClients();

            Console.ReadLine();
        }
    }
}
