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
            int k = 0;
            string name = pName.Text;
            string composition = pComposition.Text;
            string mass = pMass.Text;
            string calories = pCalories.Text;
            string prise = pPrise.Text;
            if (String.IsNullOrEmpty(pName.Text) || pName.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(pName, "Не указано названте блюда!");
                k++;
            }
            if (String.IsNullOrEmpty(pComposition.Text) || pComposition.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(pComposition, "Не указано описание блюда!");
                k++;
            }
            if (!int.TryParse(pMass.Text, out int numMass))
            {
                errorProvider1.SetError(pMass, "Не коректное значение!");
                k++;
            }
            if (!int.TryParse(pCalories.Text, out int numCalories))
            {
                errorProvider1.SetError(pCalories, "Не коректное значение!");
                k++;
            }
            if (!int.TryParse(pPrise.Text, out int numPrise))
            {
                errorProvider1.SetError(pPrise, "Не коректное значение!");
                k++;
            }
            if (k == 0)
            {
                errorProvider1.Clear();
                Menu_position position = new Menu_position(name, composition, mass, calories, prise);
                MenuOrder.AddPosition(position);
                menuBox.Items.Add(position);
                pName.Text = null;
                pComposition.Text = null;
                pMass.Text = null;
                pCalories.Text = null;
                pPrise.Text = null;
            }
        }

        private void addToOrderButton_Click(object sender, EventArgs e)
        {
            orderBox.Items.Add(menuBox.SelectedItem);
        }

        private void deleteFromOrderButton_Click(object sender, EventArgs e)
        {
            if (orderBox.SelectedIndex != -1) orderBox.Items.RemoveAt(orderBox.SelectedIndex);
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
            if (orderBox.Items.Count != 0) 
            {
                OrderForm orderForm = new OrderForm(this);
                orderForm.Show();
            }
            else
            {
                MessageBox.Show("Заказ пуст");
            }
        }
    }
}
