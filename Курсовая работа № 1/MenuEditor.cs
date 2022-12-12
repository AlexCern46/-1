using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_работа___1
{
    public partial class MenuEditor : Form
    {
        public MenuEditor()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pAddButton_Click(object sender, EventArgs e)
        {
            string name = pName.Text;
            string composition = pComposition.Text;
            int mass = Convert.ToInt32(pMass.Text);
            int calories = Convert.ToInt32(pCalories.Text);
            double prise = Convert.ToDouble(pPrise.Text);
            Menu_position position = new Menu_position(name, composition, mass, calories, prise);
            Menu.AddPosition(position);
        }
    }
}
