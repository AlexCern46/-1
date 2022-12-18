using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Курсовая_работа___1
{
    public partial class MenuEditor : Form
    {
        string columns = "{0, -13}{1, -12}{2, -10}";
        string columnsFinal = "{0, -13}{1, -12}";
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
            errorProvider1.Clear();
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
                string viewMenu = name + "  " + mass + "  " + prise;
                MenuPosition position = new MenuPosition(viewMenu, name, composition, mass, calories, prise);
                MenuOrder.AddMenuPosition(position);
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
                string viewOrder = name + "  " + number + "  " + prise;
                OrderPosition order = new OrderPosition(viewOrder, name, number, prise);
                orderBox.Items.Add(order);
                MenuOrder.AddOrderPosition(order);
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
            if (orderBox.SelectedIndex != -1)
            {
                orderBox.Items.RemoveAt(orderBox.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Ничего не выбрано");
            }
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
                MenuOrder.SaveOrders();
                orderBox.Items.Clear();
                orderBox.Items.Add(string.Format(columns, "Назв.", "Кол-во", "Цена"));
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
            allOrdersBox.Items.Add(string.Format(columnsFinal, "Номер", "Цена"));
            StreamReader reader = new StreamReader(@"..\..\menuBox.txt");
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] fragments = line.Split('|');
                string viewMenu = fragments[0];
                string name = fragments[1];
                string composition = fragments[2];
                string mass = fragments[3];
                string calories = fragments[4];
                string prise = fragments[5];
                MenuPosition position = new MenuPosition(viewMenu, name, composition, mass, calories, prise);
                MenuOrder.AddMenuPosition(position);
                menuBox.Items.Add(position);
            }
            reader.Close();
        }

        private void close_Click(object sender, EventArgs e)
        {
            MenuOrder.SaveMenu();
            this.Close();
        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            close.ForeColor= Color.Red;
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.ForeColor = Color.Black;
        }

        Point lastPoint;
        private void MenuEditor_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MenuEditor_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
