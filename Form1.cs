using System;
using System.Drawing;
using System.Windows.Forms;

namespace Travel_Ticket_Modern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ApplyModernTheme();
        }

        private void ApplyModernTheme()
        {
            this.BackColor = Color.FromArgb(235, 242, 250); // Açıq mavi-boz fon
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = Color.FromArgb(58, 123, 213); // Mavi ton
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                }
                else if (ctrl is ComboBox || ctrl is TextBox || ctrl is MaskedTextBox)
                {
                    ctrl.BackColor = Color.White;
                    ctrl.ForeColor = Color.Black;
                }
                else if (ctrl is ListBox lb)
                {
                    lb.BackColor = Color.WhiteSmoke;
                    lb.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Please select departure and destination.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string from = comboBox1.SelectedItem.ToString();
            string to = comboBox2.SelectedItem.ToString();
            string date = maskedTextBox1.Text;
            string time = maskedTextBox2.Text;
            string seat = textBox1.Text;
            string name = textBox2.Text;
            string zipCode = maskedTextBox3.Text;
            string phone = maskedTextBox4.Text;
            string email = textBox3.Text;

            string ticket = $"From: {from}\nTo: {to}\nDate: {date}\nTime: {time}\nSeat No: {seat}\nName: {name}\nZip Code: {zipCode}\nPhone: {phone}\nEmail: {email}";
            listBox1.Items.Add(ticket);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = temp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
                listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
