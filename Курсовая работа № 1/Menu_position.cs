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
        private int mass;
        private int calories;
        private double prise;

        public Menu_position(string name, string composition, int mass, int calories, double prise)
        {
            this.name = name;
            this.composition = composition;
            this.mass = mass;
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

        public int Mass
        {
            get { return mass; }
        }

        public int Calories
        {
            get { return calories; }
        }

        public double Prise
        {
            get { return prise; }
        }
    }
}
