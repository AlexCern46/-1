using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа___1
{
    internal class OrderPosition : Position
    {
        string number;

        public OrderPosition(string name, string number, string prise) : base(name, prise)
        {
            this.number = number;
        }

        public string Number
        { 
            get { return number; } 
        }
    }
}
