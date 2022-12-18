using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа___1
{
    internal class MenuOrder
    {
        private static List<MenuPosition> menu = new List<MenuPosition>();
        private static List<OrderPosition> orders = new List<OrderPosition>();

        public static void AddMenuPosition(MenuPosition position)
        {
            menu.Add(position);
        }

        public static void AddOrderPosition(OrderPosition position)
        {
            orders.Add(position);
        }

        /*public static void SaveMenu()
        {
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(@"..\..\menuBox.txt", false))
            {
                for (int i = 0; i < menu.Count; i++)
                    sw.WriteLine($"{menu[i].ViewMenu}|{menu[i].Name}|{menu[i].Composition}|{menu[i].Mass}|{menu[i].Calories}|{menu[i].Prise}");
            }
        }*/
    }
}
