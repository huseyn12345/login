namespace card
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            if(textBox1.Text.Length != 16 || !long.TryParse(textBox1.Text, out _))
            {
                isValid = false;
            }
            if(string.IsNullOrWhiteSpace(textBox2.Text))
            {
                isValid = false;
            }
            if(dateTimePicker1.Value < DateTime.Now)
            {
                isValid = false;            }
            if (textBox3.Text.Length != 3 || !int.TryParse(textBox3.Text, out _))
            {
                isValid = false;
            }
            if(isValid)
            {
                MessageBox.Show("Card is valid.");
                label1.Text = textBox1.Text;
                label2.Text = textBox2.Text;
                label3.Text = dateTimePicker1.Value.ToString("MM/yy");
                label4.Text = textBox3.Text;
            }
            else             {
                MessageBox.Show("Card is invalid.");
            }
        }
    }
}
