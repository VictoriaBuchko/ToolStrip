using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace ToolStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ToolStripComboBox.SelectedIndexChanged += ToolStripComboBox_SelectedIndexChanged;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Дані оновлено!", "Оновлено");
        }

        private void ToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox comboBox = sender as ToolStripComboBox;

            switch (comboBox.SelectedItem.ToString())
            {
                case "Червоний":
                    this.BackColor = Color.Red;
                    break;
                case "Зелений":
                    this.BackColor = Color.Green;
                    break;
                case "Синій":
                    this.BackColor = Color.Blue;
                    break;
                default:
                    break;
            }
        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string text = toolStripTextBox1.Text;
                MessageBox.Show($"{text}", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);

                toolStripTextBox1.Clear();
            }
        }

        private void ButtonTask2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
