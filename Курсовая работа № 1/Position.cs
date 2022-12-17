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
        private string prise;

        public Position(string name, string prise)
        {
            this.name = name;
            this.prise = prise;
        }

        public string Name
        {
            get { return name; }
        }

        public string Prise
        {
            get { return prise; }
        }
    }
}
