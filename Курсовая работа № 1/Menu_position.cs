using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа___1
{
    internal class Menu_position : Position
    {
        private string composition;
        private int mass;
        private int calories;

        public Menu_position(string name, string composition, int mass, int calories, double prise) : base(name, prise)
        {
            this.composition = composition;
            this.mass = mass;
            this.calories = calories;
        }

        public string Composition
        {
            get { return composition; }
        }

        public int Mass
        {
            get { return mass; }
        }

        public int Calories
        {
            get { return calories; }
        }
    }
}
