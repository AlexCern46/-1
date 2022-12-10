using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа___1
{
    internal class Class1
    {
        public void GetPosition()
        {
            string name = Console.ReadLine();
            string composition = Console.ReadLine();
            int mass = Convert.ToInt32(Console.ReadLine());
            int calories = Convert.ToInt32(Console.ReadLine());
            double prise = Convert.ToDouble(Console.ReadLine());
            Menu_position position = new Menu_position(name, composition, mass, calories, prise);
            Menu.AddPosition(position);
        }
    }
}
