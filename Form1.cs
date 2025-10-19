using System;
using System.Linq;
using System.Windows.Forms;

namespace StudentSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            toolTip1.IsBalloon = true;
            toolTip1.ToolTipTitle = "Input rule";
            toolTip1.ToolTipIcon = ToolTipIcon.Info;

            toolTip1.SetToolTip(maskedTextBox1, "Only numbers from 1 to 10 are allowed");
            toolTip1.SetToolTip(maskedTextBox6, "Only numbers from 1 to 10 are allowed");
            toolTip1.SetToolTip(maskedTextBox3, "Only numbers from 1 to 50 are allowed");
            toolTip1.SetToolTip(maskedTextBox4, "Only numbers from 1 to 20 are allowed");
            toolTip1.SetToolTip(maskedTextBox5, "Only numbers from 1 to 10 are allowed");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!IsValidRange(maskedTextBox1, 1, 10) ||
                !IsValidRange(maskedTextBox6, 1, 10) ||
                !IsValidRange(maskedTextBox3, 1, 50) ||
                !IsValidRange(maskedTextBox4, 1, 20) ||
                !IsValidRange(maskedTextBox5, 1, 10))
            {
                MessageBox.Show(
                    "Please enter valid values according to the input rules.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(maskedTextBox2.Text) ||
                maskedTextBox2.Text.Length != 9 ||
                !textBox1.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                errorProvider1.SetError(textBox1, "Please input name and surname");
                errorProvider2.SetError(maskedTextBox2, "Please input valid student number");
                return;
            }

            int total = Convert.ToInt16(maskedTextBox1.Text) +
                        Convert.ToInt16(maskedTextBox6.Text) +
                        Convert.ToInt16(maskedTextBox3.Text) +
                        Convert.ToInt16(maskedTextBox4.Text) +
                        Convert.ToInt16(maskedTextBox5.Text);

            string grade = total switch
            {
                >= 91 and <= 100 => "A",
                >= 81 and <= 90 => "B",
                >= 71 and <= 80 => "C",
                >= 61 and <= 70 => "D",
                >= 51 and <= 60 => "E",
                _ => "F",
            };

            dataGridView1.Rows.Add(textBox1.Text, maskedTextBox2.Text, $"{total} - {grade}");
        }

        private bool IsValidRange(MaskedTextBox box, int min, int max)
        {
            if (int.TryParse(box.Text, out int value))
                return value >= min && value <= max;
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Clear();
            maskedTextBox3.Clear();
            maskedTextBox4.Clear();
            maskedTextBox5.Clear();
            maskedTextBox6.Clear();
            textBox1.Clear();
            maskedTextBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
