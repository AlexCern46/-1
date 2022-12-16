using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа___1
{
    internal abstract class Position
    {
        private string name;
        private double prise;

        public Position(string name, double prise)
        {
            this.name = name;
            this.prise = prise;
        }

        public string Name
        {
            get { return name; }
        }

        public double Prise
        {
            get { return prise; }
        }
    }
}
