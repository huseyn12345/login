using System;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pass = password.Text;

            if (pass.Length < 8)
            {
                MessageBox.Show("En az 8 simvoldan ibaret olmalidir");
                return;
            }

            string specialSymbols = "!@#$%^&*()-_=+[]{}|;:'\",.<>?/`~";
            string upperLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowerLetters = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";

            bool hasUpper = false;
            bool hasLower = false;
            bool hasDigit = false;
            bool hasSpecial = false;
            bool has3InARow = false;

            for (int i = 0; i < pass.Length; i++)
            {
                char c = pass[i];

                if (digits.Contains(c)) hasDigit = true;
                if (upperLetters.Contains(c)) hasUpper = true;
                if (lowerLetters.Contains(c)) hasLower = true;
                if (specialSymbols.Contains(c)) hasSpecial = true;

                if (i + 2 < pass.Length)
                {
                    if (digits.Contains(pass[i]) && digits.Contains(pass[i + 1]) && digits.Contains(pass[i + 2])) has3InARow = true;
                    if (upperLetters.Contains(pass[i]) && upperLetters.Contains(pass[i + 1]) && upperLetters.Contains(pass[i + 2])) has3InARow = true;
                    if (lowerLetters.Contains(pass[i]) && lowerLetters.Contains(pass[i + 1]) && lowerLetters.Contains(pass[i + 2])) has3InARow = true;
                    if (specialSymbols.Contains(pass[i]) && specialSymbols.Contains(pass[i + 1]) && specialSymbols.Contains(pass[i + 2])) has3InARow = true;
                }
            }

            if (hasDigit && hasLower && hasUpper && hasSpecial && !has3InARow)
            {
                MessageBox.Show("Sifre ugurla yaradildi");
            }
            else
            {
                if (!hasUpper) MessageBox.Show("En az 1 boyuk herf olmalidir");
                if (!hasLower) MessageBox.Show("En az 1 kicik herf olmalidir");
                if (!hasDigit) MessageBox.Show("En az 1 reqem olmalidir");
                if (!hasSpecial) MessageBox.Show("En az 1 xususi simvol olmalidir");
                if (has3InARow) MessageBox.Show("Eyni tipli simvollar ard-arda 3 defe gele bilmez");
            }
        }
    }
}
