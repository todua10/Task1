using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Staff: Client
    {
        public Staff(int id): base(id)
        {
            rightsOfStaff = true;
        }
        public override void Check()
        {
            Console.WriteLine($"Чек об оплате клиента {ID}: \n");
            for (int i = 0; i < Offer.Count; i++)
            {
                Console.WriteLine($"{Offer[i].Name} - {Offer[i].GetCost()*0.9}");
            }
            Console.WriteLine($"Итого - {Sum*0.9}\n");
        }
    }
}
