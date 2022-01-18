using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Table
    {
        public int Number { get; set; }
        public bool isBusy { get; set; }
        public Table(int num)
        {
            Number = num;
            isBusy = false;
        }
    }
}
