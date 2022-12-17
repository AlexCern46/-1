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
        private string mass;
        private string calories;

        public Menu_position(string name, string composition, string mass, string calories, string prise) : base(name, prise)
        {
            this.composition = composition;
            this.mass = mass;
            this.calories = calories;
        }

        public string Composition
        {
            get { return composition; }
        }

        public string Mass
        {
            get { return mass; }
        }

        public string Calories
        {
            get { return calories; }
        }
    }
}
