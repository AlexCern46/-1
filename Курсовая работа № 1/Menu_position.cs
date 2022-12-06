using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа___1
{
    internal class Menu_position
    {
        private string name;
        private string composition;
        private int calories;
        private int prise;

        public void SetAll(string name, string composition, int calories, int prise)
        {
            this.name = name;
            this.composition = composition;
            this.calories = calories;
            this.prise = prise;
        }

        public string Name
        {
            get { return name; }
        }

        public string Composition
        {
            get { return composition; }
        }

        public int Calories
        {
            get { return calories; }
        }

        public int Prise
        {
            get { return prise; }
        }
    }
}
