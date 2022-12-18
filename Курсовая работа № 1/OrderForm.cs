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
    public partial class OrderForm : Form
    {
        string columns = "{0, -26}{1, -24}{2, -20}";
        public OrderForm()
        {
            InitializeComponent();
        }

        public OrderForm(MenuEditor f)
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            finalOrder.Items.Add(string.Format(columns, "Назв.", "Кол-во", "Цена"));
        }
    }
}
