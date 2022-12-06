using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа___1
{
    internal class Menu
    {
        private List<Menu_position> menu = new List<Menu_position>();
        
        public void AddPosition(Menu_position position)
        {
            menu.Add(position);
        }

        public void PrintMenu()
        {
            foreach(Menu_position mp in menu)
            {
                Console.WriteLine(mp);
            }
        }
    }
}
