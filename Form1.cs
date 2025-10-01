using System;
using System.Windows.Forms;

namespace MPL3
{
    public partial class Form1 : Form
    {
        private string currentOperator = "";
        private double firstNumber = 0;
        private bool isOperatorClicked = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (txtDisplay.Text == "0" || isOperatorClicked)
                txtDisplay.Text = "";
            isOperatorClicked = false;
            txtDisplay.Text += button.Text;
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentOperator = button.Text;
            firstNumber = double.Parse(txtDisplay.Text);
            isOperatorClicked = true;
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            double secondNumber = double.Parse(txtDisplay.Text);
            double result = 0;

            switch (currentOperator)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    if (secondNumber != 0)
                        result = firstNumber / secondNumber;
                    else
                        MessageBox.Show("0-a bölmək olmaz!");
                    break;
            }

            txtDisplay.Text = result.ToString();
            isOperatorClicked = false;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            firstNumber = 0;
            currentOperator = "";
        }
    }
}
