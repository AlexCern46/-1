using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа___1
{
    internal class MenuOrder
    {
        private List<Menu_position> menu = new List<Menu_position>();
        
        public void AddPosition(Menu_position position)
        {
            menu.Add(position);
        }
        public List<Menu_position> Menu
        {
            get { return menu; }
        }
    }
}
