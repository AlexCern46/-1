using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа___1
{
    internal class OrderPosition : Position
    {
        private string viewOrder;
        private string number;

        public OrderPosition(string viewOrder, string name, string number, string prise) : base(name, prise)
        {
            this.viewOrder = viewOrder;
            this.number = number;
        }

        public string ViewOrder
        {
            get { return viewOrder; }
        }
        public string Number
        { 
            get { return number; } 
        }
    }
}
