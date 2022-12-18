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
        string columns = "{0, -13}{1, -12}{2, -10}";
        public MenuEditor()
        {
            InitializeComponent();
        }
        
        private void pAddButton_Click(object sender, EventArgs e)
        {
            int k = 0;
            string name = pName.Text.Trim();
            string composition = pComposition.Text.Trim();
            string mass = pMass.Text.Trim();
            string calories = pCalories.Text.Trim();
            string prise = pPrise.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                errorProvider1.SetError(pName, "Не указано названте блюда!");
                k++;
            }
            if (string.IsNullOrEmpty(composition))
            {
                errorProvider1.SetError(pComposition, "Не указано описание блюда!");
                k++;
            }
            if (!double.TryParse(mass, out double numMass) || mass.IndexOf("-") != -1 || string.IsNullOrEmpty(mass) || mass.StartsWith("0"))
            {
                errorProvider1.SetError(pMass, "Не коректное значение!");
                k++;
            }
            if (!double.TryParse(calories, out double numCalories) || calories.IndexOf("-") != -1 || string.IsNullOrEmpty(calories) || calories.StartsWith("0"))
            {
                errorProvider1.SetError(pCalories, "Не коректное значение!");
                k++;
            }
            if (!double.TryParse(prise, out double numPrise) || prise.IndexOf("-") != -1 || string.IsNullOrEmpty(prise) || prise.StartsWith("0"))
            {
                errorProvider1.SetError(pPrise, "Не коректное значение!");
                k++;
            }
            if (k == 0)
            {
                errorProvider1.Clear();
                string viewMenu = name + "    " + mass + "    " + prise;
                MenuPosition position = new MenuPosition(viewMenu, name, composition, mass, calories, prise);
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
            if (menuBox.SelectedIndex != -1)
            {
                MenuPosition position = (MenuPosition)menuBox.SelectedItem;
                string name = position.Name;
                string number = numberTextBox.Text;
                string prise = Convert.ToString(Convert.ToDouble(position.Prise) * Convert.ToDouble(number));
                string viewOrder = name + "    " + number + "    " + prise;
                OrderPosition order = new OrderPosition(viewOrder, name, number, prise);
                orderBox.Items.Add(order);
                textBox1.Text = null;
                textBox2.Text = null;
                textBox3.Text = null;
                textBox4.Text = null;
                textBox5.Text = null;
                numberTextBox.Text = null;
            }
            else
            {
                MessageBox.Show("Ничего не выбрано");
            }
        }

        private void deleteFromOrderButton_Click(object sender, EventArgs e)
        {
            if (orderBox.SelectedIndex != -1) orderBox.Items.RemoveAt(orderBox.SelectedIndex);
        }

        private void menuBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MenuPosition position = (MenuPosition)menuBox.SelectedItem;
            textBox1.Text = position.Name;
            textBox2.Text = position.Composition;
            textBox3.Text = position.Mass;
            textBox4.Text = position.Calories;
            textBox5.Text = position.Prise;
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

        private void MenuEditor_Load(object sender, EventArgs e)
        {
            menuBox.Items.Add(string.Format(columns, "Назв.", "Вес(г)", "Цена"));
            orderBox.Items.Add(string.Format(columns, "Назв.", "Кол-во", "Цена"));
        }
    }
}
