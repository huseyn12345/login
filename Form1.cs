namespace UserCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Please enter username and password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                String user_name = textBox1.Text;
                String pass_word = textBox2.Text;
                String date_now = DateTime.Now.ToString();
                this.dataGridView1.Rows.Add(user_name, pass_word, date_now);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.Show();
            this.Hide();
        }
    }
}
