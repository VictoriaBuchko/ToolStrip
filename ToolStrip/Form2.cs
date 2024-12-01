using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolStrip
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private bool Input(out double num1, out double num2)
        {
            num1 = num2 = 0; 

            if (string.IsNullOrWhiteSpace(TextBoxNumber1.Text))
            {
                MessageBox.Show("Поле 1 не повинно бути порожнім");
                return false;
            }
            if (string.IsNullOrWhiteSpace(TextBoxNumber2.Text))
            {
                MessageBox.Show("Поле 2 не повинно бути порожнім");
                return false;
            }

            if (!double.TryParse(TextBoxNumber1.Text, out num1))
            {
                MessageBox.Show("Поле 1 повинно містити тільки числа");
                return false;
            }

            if (!double.TryParse(TextBoxNumber2.Text, out num2))
            {
                MessageBox.Show("Поле 2 повинно містити тільки числа");
                return false;
            }

            return true;
        }


        private void додаванняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double num1, num2;
            if (Input(out num1, out num2))
            {
                double result = num1 + num2;
                MessageBox.Show("Результат додавання: " + result);
            }
        }

        private void відніманняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double num1, num2;
            if (Input(out num1, out num2))
            {
                double result = num1 - num2;
                MessageBox.Show("Результат віднімання: " + result);
            }
        }

        private void очиститиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBoxNumber1.Clear();
            TextBoxNumber2.Clear();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
