using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Student: Client
    {
        public Student(int id): base(id)
        {
            rightsOfStaff = false;
        }
        public override void Check()
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
