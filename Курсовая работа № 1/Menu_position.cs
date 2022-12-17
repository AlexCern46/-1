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
        private double mass;
        private double calories;

        public Menu_position(string name, string composition, double mass, double calories, double prise) : base(name, prise)
        {
            this.composition = composition;
            this.mass = mass;
            this.calories = calories;
        }

        public string Composition
        {
            get { return composition; }
        }

        public double Mass
        {
            get { return mass; }
        }

        public double Calories
        {
            get { return calories; }
        }
    }
}
