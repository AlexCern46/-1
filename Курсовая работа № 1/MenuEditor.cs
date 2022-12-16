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
            menuBox.DisplayMember = "Name";
            orderBox.DisplayMember = "Name";
        }
        
        private void pAddButton_Click(object sender, EventArgs e)
        {
            string name = pName.Text;
            string composition = pComposition.Text;
            int mass = Convert.ToInt32(pMass.Text);
            int calories = Convert.ToInt32(pCalories.Text);
            double prise = Convert.ToDouble(pPrise.Text);
            Menu_position position = new Menu_position(name, composition, mass, calories, prise);
            menuBox.Items.Add(position);
            pName.Text = null;
            pComposition.Text = null;
            pMass.Text = null;
            pCalories.Text = null;
            pPrise.Text = null;
        }

        private void addToOrderButton_Click(object sender, EventArgs e)
        {
            orderBox.Items.Add(menuBox.SelectedItem);
        }

        private void deleteFromOrderButton_Click(object sender, EventArgs e)
        {
            if(orderBox.SelectedIndex != -1) orderBox.Items.RemoveAt(orderBox.SelectedIndex);
        }

        private void menuBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Menu_position position = (Menu_position)menuBox.SelectedItem;
            textBox1.Text = position.Name;
            textBox2.Text = position.Composition;
            textBox3.Text = position.Mass.ToString();
            textBox4.Text = position.Calories.ToString();
            textBox5.Text = position.Prise.ToString();
        }

        private void MakingAnOrderButton_Click(object sender, EventArgs e)
        {
            OrderForm orderForm= new OrderForm(this);
            orderForm.Show();
        }
    }
}
