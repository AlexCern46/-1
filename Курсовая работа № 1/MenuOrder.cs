using System;
using System.Collections.Generic;
using System.IO;
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

        public static void SaveMenu()
        {
            StreamWriter sw = new StreamWriter(@"..\..\menuBox.txt", false);
            for (int i = 0; i < menu.Count; i++)
            {
                sw.WriteLine($"{menu[i].ViewMenu}|{menu[i].Name}|{menu[i].Composition}|{menu[i].Mass}|{menu[i].Calories}|{menu[i].Prise}");
            }
            sw.Close();
        }

        public static void SaveOrders()
        {
            StreamWriter sw = new StreamWriter(@"..\..\ordersBox.txt", true);
            sw.WriteLine();
            for (int i = 0; i < orders.Count; i++)
            {
                sw.WriteLine($"{orders[i].Name}|{orders[i].Number}|{orders[i].Prise}");
            }
            sw.Close();
            orders.Clear();
        }
    }
}
