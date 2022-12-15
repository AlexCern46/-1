using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа___1
{
    internal class Menu
    {
        private static List<Menu_position> menu = new List<Menu_position>();
        
        public static void AddPosition(Menu_position position)
        {
            Menu.menu.Add(position);
        }
    }
}
