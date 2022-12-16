using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа___1
{
    internal class OrderPosition : Position
    {
        int number;

        public OrderPosition(string name, int number, double prise) : base(name, prise)
        {
            this.number = number;
        }

        public int Number
        { 
            get { return number; } 
        }
    }
}
